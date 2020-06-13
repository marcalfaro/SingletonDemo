Module Module1

    Sub Main()
        Console.WriteLine($"This is a simple demo of using Singleton pattern{vbNewLine}")

        'try and instantiate your singleton class
        Console.WriteLine("Creating 1st singleton class...")
        Dim msc As MySingletonClass = MySingletonClass.Create()

        'now try to instantiate another singleton class
        Console.WriteLine("Creating another singleton class... (2nd one)")
        Dim msc2 As MySingletonClass = MySingletonClass.Create()

        Console.WriteLine()

        'add items to your first singleton class
        Console.WriteLine("Adding items to 1st singleton class...")
        msc.List.Add("First")
        msc.List.Add("Second")
        msc.List.Add("Third")

        Console.WriteLine()

        'enumerate those items using the 2nd singleton instance...
        Console.WriteLine("Enumerating those added items in 1st Singleton class FROM THE 2ND Singleton class...")
        For i As Integer = 0 To msc2.List.Count - 1
            Console.WriteLine(msc2.List.Item(i).ToString())
        Next

        'you cannot create a new instance using "New", below will fail...
        'Dim thirdMSC As New MySingletonClass

        Console.WriteLine()
        Console.WriteLine("Instantiating 3rd Singleton class using 'Create()' method and adding an item to it...")

        'you can only use "Create"...
        Dim thirdMSC As MySingletonClass = MySingletonClass.Create
        thirdMSC.List.Add("added from thirdMSC")


        Console.WriteLine()
        Console.WriteLine("Instantiating 4th Singleton class using 'GetInstance()' property and adding an item to it...")

        'or "GetInstance" property (I added this property) 
        Dim fourthMSC = MySingletonClass.GetInstance
        fourthMSC.List.Add("added from fourthMSC")

        Console.WriteLine()
        Console.WriteLine($"Enumerating items of all 4 Singleton classes...")
        Console.WriteLine()

        'the newly added item is accessible to other similar instances....
        Console.WriteLine("+++ Enumerating msc...")
        For i As Integer = 0 To msc.List.Count - 1
            Console.WriteLine(msc.List.Item(i).ToString())
        Next

        Console.WriteLine()

        Console.WriteLine("+++ Enumerating msc2...")
        For i As Integer = 0 To msc2.List.Count - 1
            Console.WriteLine(msc2.List.Item(i).ToString())
        Next

        Console.WriteLine()

        Console.WriteLine("+++ Enumerating thirdMSC...")
        For i As Integer = 0 To thirdMSC.List.Count - 1
            Console.WriteLine(thirdMSC.List.Item(i).ToString())
        Next

        Console.WriteLine()

        Console.WriteLine("+++ Enumerating fourthMSC...")
        For i As Integer = 0 To fourthMSC.List.Count - 1
            Console.WriteLine(fourthMSC.List.Item(i).ToString())
        Next

        Console.WriteLine()
        Console.WriteLine("And there you have it!")
        Console.ReadLine()
    End Sub

End Module
