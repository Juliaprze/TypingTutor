namespace TypingTutor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSentence = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Space = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSentence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSentence.Location = new System.Drawing.Point(108, 104);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(143, 29);
            this.lblSentence.TabIndex = 0;
            this.lblSentence.Text = "SENTENCE";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtInput.Location = new System.Drawing.Point(113, 151);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(610, 203);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkBlue;
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(913, 282);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 72);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Location = new System.Drawing.Point(740, 157);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 21);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 0 s";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErrors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblErrors.Location = new System.Drawing.Point(740, 192);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(86, 21);
            this.lblErrors.TabIndex = 4;
            this.lblErrors.Text = "Errors: 0";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Polish",
            "English",
            "Spanish"});
            this.cmbLanguage.Location = new System.Drawing.Point(873, 151);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(165, 38);
            this.cmbLanguage.TabIndex = 5;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 50);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Typing Tutor";
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::TypingTutor.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(1025, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 50);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Space);
            this.panel2.Controls.Add(this.buttonM);
            this.panel2.Controls.Add(this.buttonN);
            this.panel2.Controls.Add(this.buttonB);
            this.panel2.Controls.Add(this.buttonV);
            this.panel2.Controls.Add(this.buttonC);
            this.panel2.Controls.Add(this.buttonX);
            this.panel2.Controls.Add(this.buttonZ);
            this.panel2.Controls.Add(this.buttonL);
            this.panel2.Controls.Add(this.buttonK);
            this.panel2.Controls.Add(this.buttonJ);
            this.panel2.Controls.Add(this.buttonH);
            this.panel2.Controls.Add(this.buttonG);
            this.panel2.Controls.Add(this.buttonF);
            this.panel2.Controls.Add(this.buttonD);
            this.panel2.Controls.Add(this.buttonS);
            this.panel2.Controls.Add(this.buttonA);
            this.panel2.Controls.Add(this.buttonP);
            this.panel2.Controls.Add(this.buttonO);
            this.panel2.Controls.Add(this.buttonI);
            this.panel2.Controls.Add(this.buttonU);
            this.panel2.Controls.Add(this.buttonY);
            this.panel2.Controls.Add(this.buttonT);
            this.panel2.Controls.Add(this.buttonR);
            this.panel2.Controls.Add(this.buttonE);
            this.panel2.Controls.Add(this.buttonW);
            this.panel2.Controls.Add(this.buttonQ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 337);
            this.panel2.TabIndex = 7;
            // 
            // Space
            // 
            this.Space.Location = new System.Drawing.Point(308, 254);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(304, 55);
            this.Space.TabIndex = 26;
            this.Space.UseVisualStyleBackColor = true;
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(668, 189);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(55, 55);
            this.buttonM.TabIndex = 25;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(583, 189);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(55, 55);
            this.buttonN.TabIndex = 24;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(501, 189);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(55, 55);
            this.buttonB.TabIndex = 23;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(419, 189);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(55, 55);
            this.buttonV.TabIndex = 22;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(338, 189);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(55, 55);
            this.buttonC.TabIndex = 21;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(254, 189);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(55, 55);
            this.buttonX.TabIndex = 20;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(173, 189);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(55, 55);
            this.buttonZ.TabIndex = 19;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(744, 116);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(55, 55);
            this.buttonL.TabIndex = 18;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(668, 116);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(55, 55);
            this.buttonK.TabIndex = 17;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(594, 116);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(55, 55);
            this.buttonJ.TabIndex = 16;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(522, 116);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(55, 55);
            this.buttonH.TabIndex = 15;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(442, 116);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(55, 55);
            this.buttonG.TabIndex = 14;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(361, 116);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(55, 55);
            this.buttonF.TabIndex = 13;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(284, 116);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(55, 55);
            this.buttonD.TabIndex = 12;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(206, 116);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(55, 55);
            this.buttonS.TabIndex = 11;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(130, 116);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(55, 55);
            this.buttonA.TabIndex = 10;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(776, 35);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(55, 55);
            this.buttonP.TabIndex = 9;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(700, 35);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(55, 55);
            this.buttonO.TabIndex = 8;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(630, 35);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(55, 55);
            this.buttonI.TabIndex = 7;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(557, 35);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(55, 55);
            this.buttonU.TabIndex = 6;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(480, 35);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(55, 55);
            this.buttonY.TabIndex = 5;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(399, 35);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(55, 55);
            this.buttonT.TabIndex = 4;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(317, 35);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(55, 55);
            this.buttonR.TabIndex = 3;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(239, 35);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(55, 55);
            this.buttonE.TabIndex = 2;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(163, 35);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(55, 55);
            this.buttonW.TabIndex = 1;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(90, 35);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(55, 55);
            this.buttonQ.TabIndex = 0;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1076, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblSentence);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Tutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblErrors;
        protected System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button Space;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonI;
    }
}

