using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public partial class Form1 : Form
    {

        private Dictionary<string, List<string>> sentencesByLanguage; // Zbiór zdań dla różnych języków
        private string currentSentence;
        private DateTime startTime;
        private int errorCount;
        private string selectedLanguage;
        private Dictionary<char, Button> keyButtonMap;
        private Timer keyResetTimer;
        private bool hasErrorOnCurrentPosition; // Zmienna do śledzenia błędów na bieżącej pozycji

        public Form1()
        {
            InitializeComponent();

            keyResetTimer = new Timer
            {
                Interval = 500  // Opóźnienie 500 ms
            };
            keyResetTimer.Tick += KeyResetTimer_Tick;  // Podłącz zdarzenie
            keyResetTimer.Stop();  // Na początku Timer jest zatrzymany

            keyButtonMap = new Dictionary<char, Button>
            {
                { 'Q', buttonQ },
                { 'W', buttonW },
                { 'E', buttonE },
                { 'R', buttonR },
                { 'T', buttonT },
                { 'Y', buttonY },
                { 'U', buttonU },
                { 'I', buttonI },
                { 'O', buttonO },
                { 'P', buttonP },
                { 'A', buttonA },
                { 'S', buttonS },
                { 'D', buttonD },
                { 'F', buttonF },
                { 'G', buttonG },
                { 'H', buttonH },
                { 'J', buttonJ },
                { 'K', buttonK },
                { 'L', buttonL },
                { 'Z', buttonZ },
                { 'X', buttonX },
                { 'C', buttonC },
                { 'V', buttonV },
                { 'B', buttonB },
                { 'N', buttonN },
                { 'M', buttonM },
                { ' ', Space }
            };

            sentencesByLanguage = new Dictionary<string, List<string>>
            {
                {
                    "Polish", new List<string>
                    {
                        "Na ścianie w salonie powiesiłem nowy obraz przedstawiający górski krajobraz",
                        "Na parapecie usiadł mały wróbel i zaczął ćwierkać",
                        "Podczas burzy lubię słuchać deszczu uderzającego o szyby",
                        "Błyskawica rozświetliła ciemne niebo",
                        "Na ekranie komputera pojawił się komunikat o konieczności zaktualizowania systemu",
                        "Rynek Główny w Krakowie jest jednym z największych średniowiecznych rynków w Europie",
                        "Julia ogląda tureckie seriale razem z Twoją babcią",
                        "Wieczorne niebo pełne jest gwiazd, które migoczą i tworzą piękne wzory",
                        "On codziennie biega rano po plaży.",
                        "Na moim podwórku rośnie wielkie drzewo, które daje dużo cienia latem"
                    }
                },
                {
                    "English", new List<string>
                    {
                        "Bright stars twinkle in the night sky",
                        "She left her umbrella on the bus",
                        "The refrigerator needs to be cleaned",
                        "The sun sets in the west",
                        "A single step can change your entire journey",
                        "The movie starts at seven in the evening",
                        "We need to buy some groceries for dinner",
                        "The library has a great selection of books",
                        "A curious cat explores every corner of the room",
                        "She enjoys cooking Italian food"
                    }
                },
                {
                    "Spanish", new List<string>
                    {
                        "El gato juega con la pelota",
                        "Mi amigo toca la guitarra",
                        "La flor es de color rojo",
                        "El avion vuela por el cielo",
                        "Los ninos corren en el parque",
                        "La casa tiene una puerta grande",
                        "Los estudiantes estudian mucho",
                        "La playa es un lugar tranquilo",
                        "La luna brilla en la noche",
                        "Es muy dificil encontrar la llave del coche"
                    }
                }
            };

            selectedLanguage = "English"; // Domyślnie ustaw język angielski

            SetupLanguageSelector(); // Inicjuj wybór języka

            this.txtInput.TextChanged += new EventHandler(txtInput_TextChanged);

            StartNewExercise();
        }

        private void SetupLanguageSelector()
        {
            cmbLanguage.Items.Clear(); // Czyści istniejące elementy w ComboBox
            cmbLanguage.Items.AddRange(new[] { "Polish", "English", "Spanish" }); // Dodaj opcje językowe

            if (cmbLanguage.SelectedIndex == -1) // Sprawdź, czy nie ma wybranego elementu
            {
                cmbLanguage.SelectedIndex = 1; // Domyślnie ustaw język angielski
            }

            cmbLanguage.SelectedIndexChanged -= CmbLanguage_SelectedIndexChanged; // Usuń ewentualne stare zdarzenia
            cmbLanguage.SelectedIndexChanged += CmbLanguage_SelectedIndexChanged;
        }

        private Color defaultButtonColor = Color.LightGray;  // Domyślny kolor przycisków
        private Color highlightedButtonColor = Color.LightBlue;

        private void HighlightKey(char character)
        {
            // Resetuj podświetlenie wszystkich klawiszy
            foreach (var button in keyButtonMap.Values)
            {
                button.BackColor = defaultButtonColor;  // Przywróć domyślny kolor
            }

            char upperCharacter = char.ToUpper(character);  // Upewnij się, że litera jest wielka
            if (keyButtonMap.ContainsKey(upperCharacter))
            {
                keyButtonMap[upperCharacter].BackColor = highlightedButtonColor;  // Podświetl na niebiesko
            }
        }

        private void KeyResetTimer_Tick(object sender, EventArgs e)
        {
            keyResetTimer.Stop();  // Zatrzymaj Timer

            // Resetuj podświetlenie wszystkich klawiszy
            foreach (var button in keyButtonMap.Values)
            {
                button.BackColor = Color.LightGray;  // Domyślny kolor przycisków
            }
        }

        private void StartNewExercise()
        {
            var random = new Random();
            var sentences = sentencesByLanguage[selectedLanguage]; // Wybierz zdania dla wybranego języka
            currentSentence = sentences[random.Next(sentences.Count)]; // Wybierz losowe zdanie
            lblSentence.Text = currentSentence; // Wyświetl zdanie
            txtInput.Text = string.Empty; // Wyczyść pole wejściowe
            txtInput.Enabled = true; // Włącz edycję
            txtInput.Focus(); // Ustaw fokus na pole tekstowe
            errorCount = 0; // Zresetuj błędy
            startTime = DateTime.Now; // Rozpocznij pomiar czasu
            lblTime.Text = "Time: 0 s"; // Zresetuj czas
            lblErrors.Text = "Errors: 0"; // Zresetuj błędy
            hasErrorOnCurrentPosition = false; // Zresetuj flagę błędów

            foreach (var button in keyButtonMap.Values)
            {
                button.BackColor = defaultButtonColor;  // Domyślny kolor
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartNewExercise();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                char lastCharacter = txtInput.Text.Last();  // Ostatni wpisany znak
                HighlightKey(lastCharacter);  // Podświetl odpowiedni przycisk

                // Zatrzymaj i uruchom Timer, aby podświetlenie zostało zresetowane po krótkim czasie
                keyResetTimer.Stop();  // Zatrzymaj Timer, jeśli jest już uruchomiony
                keyResetTimer.Start();  // Uruchom Timer, aby zresetować podświetlenie po opóźnieniu
            }

            if (txtInput.Text == currentSentence)
            {
                txtInput.Enabled = false;
                TimeSpan elapsedTime = DateTime.Now - startTime;

                lblTime.Text = $"Time: {elapsedTime.TotalSeconds:F2} s";
                lblErrors.Text = $"Errors: {errorCount}";
            }
            else
            {
                int currentLength = txtInput.Text.Length;

                // Sprawdź, czy długość wpisanego tekstu nie przekracza długości zdania
                if (currentLength > 0 && currentLength <= currentSentence.Length)
                {
                    if (txtInput.Text[currentLength - 1] != currentSentence[currentLength - 1])
                    {
                        if (!hasErrorOnCurrentPosition)
                        {
                            errorCount++;
                            lblErrors.Text = $"Errors: {errorCount}";
                            hasErrorOnCurrentPosition = true; // Ustaw flagę błędu na bieżącej pozycji
                        }
                    }
                    else
                    {
                        hasErrorOnCurrentPosition = false; // Zresetuj flagę błędu, jeśli poprawny znak został wpisany
                    }
                }
            }
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLanguage = cmbLanguage.SelectedItem.ToString(); // Aktualizuje wybrany język
            StartNewExercise();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
