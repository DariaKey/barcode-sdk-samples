'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Diagnostics
Imports System.Text
Imports Bytescout.BarCode

Class Program
	Friend Shared Sub Main(args As String())
		' Create Barcode component instance
		Using barcode As New Barcode()
			barcode.RegistrationName = "demo"
			barcode.RegistrationKey = "demo"

			' Set barcode type
			barcode.Symbology = SymbologyType.Aztec
			' Force binary mode
			barcode.Options.AztecCompactionMode = AztecCompactionMode.Binary

			' Sample byte array to use as value  
			Dim byteArray As Byte() = New Byte() {0, 10, 11, 12, 13, 14, _
				15, &Hff}

			' Set value by converting byte array to string  
			barcode.Value = Encoding.[Default].GetString(byteArray)

			' Save barcode image
			barcode.SaveImage("result.png")

			' Open output image in default associated application
			Process.Start("result.png")
		End Using
	End Sub
End Class
