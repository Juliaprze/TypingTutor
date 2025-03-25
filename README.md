# Typing Tutor

## Overview

This is a simple Typing Tutor application built using Windows Forms in C#. It is designed to help users improve their typing speed and accuracy. The application provides sentences in different languages (English, Polish, and Spanish) and tracks the user's typing performance.

## Features

1. **Language Selection**: The user can choose from three languages (Polish, English, Spanish) to practice typing.
2. **Sentence Display**: A random sentence from the selected language is displayed, and the user needs to type it correctly.
3. **Real-time Error Tracking**: The application tracks the number of errors as the user types and provides feedback.
4. **Typing Speed and Accuracy**: The time taken to complete the exercise and the number of errors are displayed.
5. **Key Highlighting**: Keys corresponding to the typed characters are visually highlighted, providing better user feedback.
6. **Timer**: A timer tracks how long it takes for the user to type the sentence correctly.
7. **Error Reset**: Errors are tracked for each character typed, and the system will not count errors again on the same character once it is corrected.

## Setup

To get started with the application, follow these steps:

1. **Download or Clone**: Get the source code from the repository.
2. **Open in Visual Studio**: Open the solution in Visual Studio.
3. **Build and Run**: Build and run the application. It should open the Typing Tutor form.

## Requirements

- Visual Studio 2019
- .NET Framework 4.5 
- Windows Operating System

## User Interface

- **Language Selector**: A ComboBox at the top of the form allows the user to choose between Polish, English, or Spanish.
- **Sentence Display**: A Label shows the current sentence the user needs to type.
- **Input Box**: A TextBox where the user types the sentence.
- **Error Count**: A Label that tracks the number of errors made while typing.
- **Timer**: A Label that displays the time taken to type the sentence.
- **Key Buttons**: Virtual buttons representing keyboard keys that highlight when typed characters are matched.
- **Start Button**: A button that starts a new typing exercise with a new sentence.

## How It Works

1. **Start a New Exercise**: When the application starts, the user can click the "Start" button to start a new exercise. A random sentence from the selected language will be displayed.
2. **Typing**: As the user types the sentence, each key press highlights the corresponding button. The application checks if the typed character matches the character in the sentence.
3. **Errors**: If the user types a wrong character, an error is recorded, and the error count is updated.
4. **Completion**: When the user types the sentence correctly, the timer stops, and the time along with the number of errors is displayed.

## How to Use

1. **Select a Language**: Use the language selector to choose the language for the exercise.
2. **Start Typing**: The user can click on the "Start" button to begin a new typing exercise. The sentence will appear, and the user can start typing it in the TextBox.
3. **Track Progress**: As the user types, the application will display the time elapsed and the number of errors. After completing the exercise, the user can see the results.
4. **Repeat**: To practice more, simply click the "Start" button again to generate a new sentence.

## Code Structure

- **Form1.cs**: The main form where all the UI elements and logic are implemented.
  - Handles language selection.
  - Manages sentence selection and error tracking.
  - Tracks typing progress and time.
  - Manages key highlighting using the `Dictionary` of buttons corresponding to each character.

## Known Issues

- **Character Case Sensitivity**: The application does not differentiate between uppercase and lowercase letters in the typing input.
- **Key Mapping**: The key mapping is currently limited to the English alphabet and spacebar. Special characters or accented characters are not included.

## Future Improvements

- Support for more languages and characters, including accented characters.
- Option to change sentence difficulty based on typing level.
- Add statistics tracking over time, such as words per minute (WPM).
- Implement a feature for practicing typing with different keyboard layouts.

