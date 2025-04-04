﻿Option Explicit
Option Strict On

Imports System.Data.OracleClient

Module Module1
    ' <Snippet1>
    Sub Main()
        Dim builder As _
     New OracleConnectionStringBuilder(GetConnectionString())
        Console.WriteLine("Connection string = " & builder.ConnectionString)

        ' Keys you have provided return true.
        Console.WriteLine(builder.ContainsKey("Integrated Security"))

        ' Keys that are valid but have not been set return true.
        Console.WriteLine(builder.ContainsKey("Unicode"))

        ' Keys that don't exist return false.
        Console.WriteLine(builder.ContainsKey("MyKey"))

        Console.WriteLine("Press Enter to continue.")
        Console.ReadLine()
    End Sub

    Private Function GetConnectionString() As String
        ' To avoid storing the connection string in your code,
        ' you can retrieve it from a configuration file.
        Return "Server=OracleDemo;Integrated Security=True"
    End Function
    ' </Snippet1>
End Module

