

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór: ");
        string? command = Console.ReadLine();

        if (command == "1" || command == "2" || command == "3")
        {
            return command;
        }
        else
        {
            Console.WriteLine("Nieprawidłowa komenda. Spróbuj ponownie.");
        }
        // Sprawdź command.
        // Jeśli jest poprawna, zwróć ją przez return.
        // W przeciwnym razie wyświetl komunikat.
    }
}

ReadCommand();