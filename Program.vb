Imports System

Module CurrencyConverter
    Sub Main(args As String())
        Dim currency, yen, euro As Decimal
        Console.WriteLine("Please enter the desired amount of money to calculate in £")
        currency = Console.ReadLine
        yen = currency * 124.6
        euro = currency * 1.26
        Console.WriteLine("£" & currency & " Yen ¥" & yen & " Euro €" & euro)
    End Sub
End Module
