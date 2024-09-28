# Threaded Letter Printer

**Threaded Letter Printer** is a simple C# console application, developed as a school assignment, that demonstrates the use of threads. The program creates three threads, each responsible for printing a specific letter (A, B, or C) 100 times. The threads are executed in sequence, ensuring one finishes before the next one starts.

## How It Works

1. The program creates three threads:
   - **Thread A**: Prints the letter 'A' followed by a number from 1 to 100.
   - **Thread B**: Prints the letter 'B' followed by a number from 1 to 100.
   - **Thread C**: Prints the letter 'C' followed by a number from 1 to 100.
2. The threads are executed in sequence, with each thread starting only after the previous one has completed.

## Installation

**Clone the repository:** `git clone https://github.com/lauri-sa/ThreadedLetterPrinter.git`

**Navigate to the project directory:** `cd ThreadedLetterPrinter`

**Build the project:** `dotnet build`

**Run the application:** `dotnet run`
