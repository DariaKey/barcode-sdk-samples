'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.BarCode
Imports System.Data.OleDb

Module Module1

    Sub Main()

        Dim barcode As Barcode = New Barcode()

        barcode.Symbology = SymbologyType.Code128

        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Book1.xlsx;Extended Properties='Excel 8.0;HDR=Yes'")
        connection.Open()

        Dim command As OleDbCommand = connection.CreateCommand()
        command.CommandText = "SELECT * FROM [Sheet1$]"

        Dim dataReader As OleDbDataReader = command.ExecuteReader()

        Dim i As Integer

        While dataReader.Read()
            barcode.Value = Convert.ToString(dataReader.GetValue(0))
            barcode.SaveImage(barcode.Value & ".png")
            i = i + 1
        End While

        dataReader.Dispose()
        connection.Dispose()
        barcode.Dispose()

    End Sub

End Module
