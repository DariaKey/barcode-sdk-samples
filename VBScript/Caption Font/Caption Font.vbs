'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Barcode object
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set barcode type to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value 
bc.Value = "012345" 

' Change caption font
bc.SetCaptionFont "Times New Roman", 24

' Save barcode 
bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false

