'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to PDF417
barcode.Symbology = 13 ' 13 = PDF417 symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at bottom-right corner of the the first TIFF page
barcode.DrawToImage "..\wikipedia.tif", 0, 550, 1100, "result.tif"

' Open the output file in default image viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.tif", 1, false
Set shell = Nothing

Set barcode = Nothing

