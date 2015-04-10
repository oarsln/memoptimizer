Imports System.Runtime.InteropServices
Module Module1
    <DllImport("kernel32.dll", CharSet:=CharSet.Ansi, SetLastError:=True, ExactSpelling:=True)> _
    Public Function SetProcessWorkingSetSize(ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    End Function
    Sub Main()
        Console.WriteLine("################################################")
        Console.WriteLine("               MEMORY OPTIMIZER")
        Console.WriteLine()
        Console.WriteLine("                GitHub: oarsln")
        Console.WriteLine("################################################")
        Console.WriteLine()
        Console.WriteLine("Press 'ENTER' to start optimization...")
        Console.ReadLine()
        Console.WriteLine(" [ i ] Avaible Physical Memory Before Optimization: " & Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 8) & " KB")
        Console.WriteLine()
        Console.WriteLine(" [ + ] Optimization started...")
        Console.WriteLine()
        For Each İşlem As Process In Process.GetProcesses
            Try
                SetProcessWorkingSetSize(İşlem.Handle, -1, -1)
            Catch ex As Exception
            End Try
        Next
        Console.WriteLine(" [ + ] Optimization OK.")
        Console.WriteLine()
        Console.WriteLine(" [ i ] Avaible Physical Memory After Optimization: " & Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 8) & " KB")
        Console.ReadLine()
    End Sub
End Module
