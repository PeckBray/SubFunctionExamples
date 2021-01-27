Module SubFunctionExamples

    Sub Main()
        'Console.WriteLine("I'm in sub main!!")
        'MyOtherSub() 'call other sub
        'Console.WriteLine("I'm back in sub main!!")
        'MyOtherSub()
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 6
        'DoMath(firstNumber)
        'DoMath(secondNumber)
        'DoMath(7)

        ' DoMath(firstNumber, secondNumber)
        Console.WriteLine(MyCoolFunction("Hi"))

        Console.Read()
    End Sub
    'Subs execute a block of code 
    Sub MyOtherSub()
        Console.WriteLine("I'm in my other sub!!")
    End Sub
    'pass data to a sub/function with arguments
    Sub DoMath(someNumber As Integer, someOtherNumber As Integer)
        someNumber *= 2
        Console.WriteLine(someNumber + someOtherNumber)
    End Sub
    'functions execute a block of code and then return data to the caller
    Function MyCoolFunction(noteToSelf) As String
        Dim temp As String
        temp = $"hello, {noteToSelf}"
        Return temp
    End Function

End Module
