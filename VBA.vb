
'reader del csv per la creazione della tabella per aula

Sub csvReader()

    dim preamble as String
    dim myValue as String
    dim finalString as String
    myValue = InputBox("Inserisci aula", "Aula", "A1")
    preamble = "Ing-Aula "
    finalString = preamble & myValue
    MsgBox(finalString)

    Dim FilePath As String
    xSheet = ThisComponent.Sheets(0)
    document = ThisComponent.CurrentController.Frame
    dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

    'directory in cui è salvato il file csv sorgente
    'FilePath = "/home/dandi/Downloads/informatica_I_anno.csv"

    Open FilePath For Input As #1
    Dim column as Integer
    Dim row As Integer
    column = 1
    row = 1
    oCell = xSheet.getCellByPosition(row, column)
    oCell.string = "test"

    Do Until EOF(1)

'        OffsetCell.string = "test2"
        Line Input #1, LineFromFile
        LineItems = Split(LineFromFile, ",")
        for i = 1 to 3
            OffsetCell = xSheet.getCellByPosition(row, column + i)
            OffsetCell.string = LineItems(i)
        next i
        row = row + 1
    Loop
    Close #1

    msgBox("ok")

End Sub







sub tableCreator
	rem ----------------------------------------------------------------------
	rem define variables
	dim document   as object
	dim dispatcher as object
	rem ----------------------------------------------------------------------
	rem get access to the document
	document   = ThisComponent.CurrentController.Frame
	dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

	rem ----------------------------------------------------------------------
	dim args1(0) as new com.sun.star.beans.PropertyValue
	args1(0).Name = "ToPoint"
	args1(0).Value = "$A$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:Paste", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args3(0) as new com.sun.star.beans.PropertyValue
	args3(0).Name = "ToPoint"
	args3(0).Value = "$D$16"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args3())

end sub



'----------------------------------------MACRO CHIAMATA PER LA RICERCA PER AULA------------------------------------

sub example_macro

	call final_delete	'cancellazione delle tabelle precedentemente create
	call deleter		'cancellazione del contenuto della tabella
	call test			'riempimento della nuova tabella con i campi delle ore e dei giorni



    dim preamble as String
    dim myValue as String
    dim finalString as String
    myValue = InputBox("Inserisci aula", "Aula", "A1")
    preamble = "Ing-Aula "
    finalString = preamble & myValue

    rem define variables
    dim document   as object
    dim dispatcher as object
    xSheet = ThisComponent.Sheets(0)
    document   = ThisComponent.CurrentController.Frame
    dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")
    'FilePath = "/home/dandi/PycharmProjects/CSVeditor/result.csv"

    'apertura del file csv sorgente, deve essere nella stessa directory in cui si trova il foglio di lavoro
    FilePath = ThisComponent.url()
    len1 = Len(FilePath)
    len2 = Len(ThisComponent.Title)
    FilePath = Left(FilePath, len1 - len2)

    FilePath = FilePath + "result.csv"
    Open FilePath For Input As #1
    Open FilePath For Input As #2

rem ----------------------------------------------------------------------

    Dim column as integer
    Dim row As integer

rem ----------------------------------------------------------------------

    Dim i As Integer
    i = 0


    Do Until EOF(1)


        Line Input #1, LineFromFile
        LineItems = Split(LineFromFile, ",")
        If LineItems(i) = "0" Then
            row = "1"
            column = "1"
        End If
        If LineItems(i) = "1" Then
            row = "1"
            column = "2"
        End If
        If LineItems(i) = "2" Then
            row = "1"
            column = "3"
        End If
        If LineItems(i) = "3" Then
            row = "1"
            column = "4"
        End If
        If LineItems(i) = "4" Then
            row = "1"
            column = "5"
        End If
        If LineItems(i) = "5" Then
            row = "1"
            column = "6"
        End If
        If LineItems(i) = "6" Then
            row = "1"
            column = "7"
        End If
        If LineItems(i) = "7" Then
            row = "1"
            column = "8"
        End If
        If LineItems(i) = "8" Then
            row = "1"
            column = "9"
        End If
        If LineItems(i) = "9" Then
            row = "1"
            column = "10"
        End If



        If LineItems(i) = "10" Then
            row = "2"
            column = "1"
        End If
        If LineItems(i) = "11" Then
            row = "2"
            column = "2"
        End If
        If LineItems(i) = "12" Then
            row = "2"
            column = "3"
        End If
        If LineItems(i) = "13" Then
            row = "2"
            column = "4"
        End If
        If LineItems(i) = "14" Then
            row = "2"
            column = "5"
        End If
        If LineItems(i) = "15" Then
            row = "2"
            column = "6"
        End If
        If LineItems(i) = "16" Then
            row = "2"
            column = "7"
        End If
        If LineItems(i) = "17" Then
            row = "2"
            column = "8"
        End If
        If LineItems(i) = "18" Then
            row = "2"
            column = "9"
        End If
        If LineItems(i) = "19" Then
            row = "2"
            column = "10"
        End If



        If LineItems(i) = "20" Then
            row = "3"
            column = "1"
        End If
        If LineItems(i) = "21" Then
            row = "3"
            column = "2"
        End If
        If LineItems(i) = "22" Then
            row = "3"
            column = "3"
        End If
        If LineItems(i) = "23" Then
            row = "3"
            column = "4"
        End If
        If LineItems(i) = "24" Then
            row = "3"
            column = "5"
        End If
        If LineItems(i) = "25" Then
            row = "3"
            column = "6"
        End If
        If LineItems(i) = "26" Then
            row = "3"
            column = "7"
        End If
        If LineItems(i) = "27" Then
            row = "3"
            column = "8"
        End If
        If LineItems(i) = "28" Then
            row = "3"
            column = "9"
        End If
        If LineItems(i) = "29" Then
            row = "3"
            column = "10"
        End If



        If LineItems(i) = "30" Then
            row = "4"
            column = "1"
        End If
        If LineItems(i) = "31" Then
            row = "4"
            column = "2"
        End If
        If LineItems(i) = "32" Then
            row = "4"
            column = "3"
        End If
        If LineItems(i) = "33" Then
            row = "4"
            column = "4"
        End If
        If LineItems(i) = "34" Then
            row = "4"
            column = "5"
        End If
        If LineItems(i) = "35" Then
            row = "4"
            column = "6"
        End If
        If LineItems(i) = "36" Then
            row = "4"
            column = "7"
        End If
        If LineItems(i) = "37" Then
            row = "4"
            column = "8"
        End If
        If LineItems(i) = "38" Then
            row = "4"
            column = "9"
        End If
        If LineItems(i) = "39" Then
            row = "4"
            column = "10"
        End If




        If LineItems(i) = "40" Then
            row = "5"
            column = "1"
        End If
        If LineItems(i) = "41" Then
            row = "5"
            column = "2"
        End If
        If LineItems(i) = "42" Then
            row = "5"
            column = "3"
        End If
        If LineItems(i) = "43" Then
            row = "5"
            column = "4"
        End If
        If LineItems(i) = "44" Then
            row = "5"
            column = "5"
        End If
        If LineItems(i) = "45" Then
            row = "5"
            column = "6"
        End If
        If LineItems(i) = "46" Then
            row = "5"
            column = "7"
        End If
        If LineItems(i) = "47" Then
            row = "5"
            column = "8"
        End If
        If LineItems(i) = "48" Then
            row = "5"
            column = "9"
        End If
        If LineItems(i) = "49" Then
            row = "5"
            column = "10"
        End If
            If LineItems(1) = finalString Then
                 xSheet.getCellByPosition(row, column).string = LineItems(2)

            End If

    Loop

    call minitable
	call minitableBorder


    Dim j As Integer
    j = 0
	Dim forCycle As Integer
	dim materia As String
	Dim check As Integer
	check = 0


    Do Until EOF(2)

        Line Input #2, LineFromFile
        LineItems = Split(LineFromFile, ",")
		If LineItems(1) = finalString Then
			If materia <> LineItems(2) Then
				For forCycle = 0 To j
	        		If LineItems(2) = xSheet.getCellByPosition(1, 15 + forCycle).string Then
	        			check = 1
	        		End If
	        	Next forCycle
	        	If check <> 1 Then
	        	xSheet.getCellByPosition(1, 15 + j).string = LineItems(2)
	        	xSheet.getCellByPosition(2, 15 + j).string = LineItems(3)
	        	xSheet.getCellByPosition(3, 15 + j).string = LineItems(5)
	        	j = j+1
	        	materia = LineItems(2)
	        	End If
				check = 0
        	End If
		End If

    Loop
    rem MsgBox(finalString + " " + LineItems(1))
    rem MsgBox("raw =  " + row + ", column = " + column + ", lineItem(0) = " + LineItems(0))

end sub


sub tableCreator2
	rem ----------------------------------------------------------------------
	rem define variables
	dim document   as object
	dim dispatcher as object
	rem ----------------------------------------------------------------------
	rem get access to the document
	document   = ThisComponent.CurrentController.Frame
	dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

	rem ----------------------------------------------------------------------
	dim args1(0) as new com.sun.star.beans.PropertyValue
	args1(0).Name = "ToPoint"
	args1(0).Value = "$B$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

	rem ----------------------------------------------------------------------
	dim args2(0) as new com.sun.star.beans.PropertyValue
	args2(0).Name = "StringName"
	args2(0).Value = "LUN"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args2())

	rem ----------------------------------------------------------------------
	dim args3(0) as new com.sun.star.beans.PropertyValue
	args3(0).Name = "StringName"
	args3(0).Value = "MAR"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args3())

	rem ----------------------------------------------------------------------
	dim args4(0) as new com.sun.star.beans.PropertyValue
	args4(0).Name = "StringName"
	args4(0).Value = "MER"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args4())

	rem ----------------------------------------------------------------------
	dim args5(0) as new com.sun.star.beans.PropertyValue
	args5(0).Name = "StringName"
	args5(0).Value = "GIO"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args5())

	rem ----------------------------------------------------------------------
	dim args6(0) as new com.sun.star.beans.PropertyValue
	args6(0).Name = "StringName"
	args6(0).Value = "VEN"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args6())

	rem ----------------------------------------------------------------------
	dim args7(0) as new com.sun.star.beans.PropertyValue
	args7(0).Name = "ToPoint"
	args7(0).Value = "$A$2"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args7())

	rem ----------------------------------------------------------------------
	dim args8(0) as new com.sun.star.beans.PropertyValue
	args8(0).Name = "StringName"
	args8(0).Value = "8:30-9:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args8())

	rem ----------------------------------------------------------------------
	dim args9(0) as new com.sun.star.beans.PropertyValue
	args9(0).Name = "StringName"
	args9(0).Value = "9-30-10:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args9())

	rem ----------------------------------------------------------------------
	dim args10(0) as new com.sun.star.beans.PropertyValue
	args10(0).Name = "ToPoint"
	args10(0).Value = "$A$4"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args10())

	rem ----------------------------------------------------------------------
	dim args11(0) as new com.sun.star.beans.PropertyValue
	args11(0).Name = "StringName"
	args11(0).Value = "10:30-11.15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args11())

	rem ----------------------------------------------------------------------
	dim args12(0) as new com.sun.star.beans.PropertyValue
	args12(0).Name = "StringName"
	args12(0).Value = "11:30-12.15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args12())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args14(0) as new com.sun.star.beans.PropertyValue
	args14(0).Name = "StringName"
	args14(0).Value = "12:30-13:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args14())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args16(0) as new com.sun.star.beans.PropertyValue
	args16(0).Name = "StringName"
	args16(0).Value = "14:30-15:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args16())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args18(0) as new com.sun.star.beans.PropertyValue
	args18(0).Name = "StringName"
	args18(0).Value = "15:30-16:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args18())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args20(0) as new com.sun.star.beans.PropertyValue
	args20(0).Name = "StringName"
	args20(0).Value = "16:30-17:15"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args20())

	rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args22(1) as new com.sun.star.beans.PropertyValue
	args22(0).Name = "By"
	args22(0).Value = 1
	args22(1).Name = "Sel"
	args22(1).Value = false

	dispatcher.executeDispatch(document, ".uno:GoUp", "", 0, args22())

	rem ----------------------------------------------------------------------
	dim args23(1) as new com.sun.star.beans.PropertyValue
	args23(0).Name = "By"
	args23(0).Value = 1
	args23(1).Name = "Sel"
	args23(1).Value = false

	dispatcher.executeDispatch(document, ".uno:GoUp", "", 0, args23())

	rem ----------------------------------------------------------------------
	dim args24(1) as new com.sun.star.beans.PropertyValue
	args24(0).Name = "By"
	args24(0).Value = 1
	args24(1).Name = "Sel"
	args24(1).Value = false

	dispatcher.executeDispatch(document, ".uno:GoUp", "", 0, args24())

	rem ----------------------------------------------------------------------
	dim args25(1) as new com.sun.star.beans.PropertyValue
	args25(0).Name = "By"
	args25(0).Value = 1
	args25(1).Name = "Sel"
	args25(1).Value = false

	dispatcher.executeDispatch(document, ".uno:GoRight", "", 0, args25())

	rem ----------------------------------------------------------------------
	dim args26(1) as new com.sun.star.beans.PropertyValue
	args26(0).Name = "By"
	args26(0).Value = 1
	args26(1).Name = "Sel"
	args26(1).Value = false

	dispatcher.executeDispatch(document, ".uno:GoLeft", "", 0, args26())

	rem ----------------------------------------------------------------------
	dim args27(0) as new com.sun.star.beans.PropertyValue
	args27(0).Name = "ToPoint"
	args27(0).Value = "$A$7"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args27())

	rem ----------------------------------------------------------------------
	dim args28(0) as new com.sun.star.beans.PropertyValue
	args28(0).Name = "StringName"
	args28(0).Value = "14:00-14:45"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args28())

	rem ----------------------------------------------------------------------
	dim args29(0) as new com.sun.star.beans.PropertyValue
	args29(0).Name = "ToPoint"
	args29(0).Value = "$A$8"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args29())

	rem ----------------------------------------------------------------------
	dim args30(0) as new com.sun.star.beans.PropertyValue
	args30(0).Name = "StringName"
	args30(0).Value = "15:00-15:45"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args30())

	rem ----------------------------------------------------------------------
	dim args31(0) as new com.sun.star.beans.PropertyValue
	args31(0).Name = "ToPoint"
	args31(0).Value = "$A$9"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args31())

	rem ----------------------------------------------------------------------
	dim args32(0) as new com.sun.star.beans.PropertyValue
	args32(0).Name = "StringName"
	args32(0).Value = "16:00-16:45"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args32())

	rem ----------------------------------------------------------------------
	dim args33(0) as new com.sun.star.beans.PropertyValue
	args33(0).Name = "ToPoint"
	args33(0).Value = "$A$10"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args33())

	rem ----------------------------------------------------------------------
	dim args34(0) as new com.sun.star.beans.PropertyValue
	args34(0).Name = "StringName"
	args34(0).Value = "17:00-17:45"

	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args34())

	rem ----------------------------------------------------------------------
	dim args35(0) as new com.sun.star.beans.PropertyValue
	args35(0).Name = "ToPoint"
	args35(0).Value = "$D$9"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args35())

	rem ----------------------------------------------------------------------
	dim args36(0) as new com.sun.star.beans.PropertyValue
	args36(0).Name = "ToPoint"
	args36(0).Value = "$A$1:$A$10"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args36())

	rem ----------------------------------------------------------------------
	dim args37(0) as new com.sun.star.beans.PropertyValue
	args37(0).Name = "BackgroundColor"
	args37(0).Value = 15658734

	dispatcher.executeDispatch(document, ".uno:BackgroundColor", "", 0, args37())

	rem ----------------------------------------------------------------------
	dim args38(0) as new com.sun.star.beans.PropertyValue
	args38(0).Name = "ToPoint"
	args38(0).Value = "$A$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args38())

	rem ----------------------------------------------------------------------
	dim args39(0) as new com.sun.star.beans.PropertyValue
	args39(0).Name = "ToPoint"
	args39(0).Value = "$A$1:$F$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args39())

	rem ----------------------------------------------------------------------
	dim args40(0) as new com.sun.star.beans.PropertyValue
	args40(0).Name = "BackgroundColor"
	args40(0).Value = 15658734

	dispatcher.executeDispatch(document, ".uno:BackgroundColor", "", 0, args40())

	rem ----------------------------------------------------------------------
	dim args41(0) as new com.sun.star.beans.PropertyValue
	args41(0).Name = "ToPoint"
	args41(0).Value = "$C$5"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args41())

	rem ----------------------------------------------------------------------
	dim args42(0) as new com.sun.star.beans.PropertyValue
	args42(0).Name = "ToPoint"
	args42(0).Value = "$A$1:$A$10"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args42())

	rem ----------------------------------------------------------------------
	dim args43(12) as new com.sun.star.beans.PropertyValue
	args43(0).Name = "OuterBorder.LeftBorder"
	args43(0).Value = Array(0,0,2,0,0,2)
	args43(1).Name = "OuterBorder.LeftDistance"
	args43(1).Value = 0
	args43(2).Name = "OuterBorder.RightBorder"
	args43(2).Value = Array(0,0,2,0,0,2)
	args43(3).Name = "OuterBorder.RightDistance"
	args43(3).Value = 0
	args43(4).Name = "OuterBorder.TopBorder"
	args43(4).Value = Array(0,0,2,0,0,2)
	args43(5).Name = "OuterBorder.TopDistance"
	args43(5).Value = 0
	args43(6).Name = "OuterBorder.BottomBorder"
	args43(6).Value = Array(0,0,2,0,0,2)
	args43(7).Name = "OuterBorder.BottomDistance"
	args43(7).Value = 0
	args43(8).Name = "InnerBorder.Horizontal"
	args43(8).Value = Array(0,0,2,0,0,2)
	args43(9).Name = "InnerBorder.Vertical"
	args43(9).Value = Array(0,0,2,0,0,2)
	args43(10).Name = "InnerBorder.Flags"
	args43(10).Value = 0
	args43(11).Name = "InnerBorder.ValidFlags"
	args43(11).Value = 127
	args43(12).Name = "InnerBorder.DefaultDistance"
	args43(12).Value = 0

	dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args43())

	rem ----------------------------------------------------------------------
	dim args44(0) as new com.sun.star.beans.PropertyValue
	args44(0).Name = "ToPoint"
	args44(0).Value = "$A$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args44())

	rem ----------------------------------------------------------------------
	dim args45(0) as new com.sun.star.beans.PropertyValue
	args45(0).Name = "ToPoint"
	args45(0).Value = "$A$1:$F$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args45())

	rem ----------------------------------------------------------------------
	dim args46(12) as new com.sun.star.beans.PropertyValue
	args46(0).Name = "OuterBorder.LeftBorder"
	args46(0).Value = Array(0,0,2,0,0,2)
	args46(1).Name = "OuterBorder.LeftDistance"
	args46(1).Value = 0
	args46(2).Name = "OuterBorder.RightBorder"
	args46(2).Value = Array(0,0,2,0,0,2)
	args46(3).Name = "OuterBorder.RightDistance"
	args46(3).Value = 0
	args46(4).Name = "OuterBorder.TopBorder"
	args46(4).Value = Array(0,0,2,0,0,2)
	args46(5).Name = "OuterBorder.TopDistance"
	args46(5).Value = 0
	args46(6).Name = "OuterBorder.BottomBorder"
	args46(6).Value = Array(0,0,2,0,0,2)
	args46(7).Name = "OuterBorder.BottomDistance"
	args46(7).Value = 0
	args46(8).Name = "InnerBorder.Horizontal"
	args46(8).Value = Array(0,0,2,0,0,2)
	args46(9).Name = "InnerBorder.Vertical"
	args46(9).Value = Array(0,0,2,0,0,2)
	args46(10).Name = "InnerBorder.Flags"
	args46(10).Value = 0
	args46(11).Name = "InnerBorder.ValidFlags"
	args46(11).Value = 127
	args46(12).Name = "InnerBorder.DefaultDistance"
	args46(12).Value = 0

	dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args46())

	rem ----------------------------------------------------------------------
	rem dispatcher.executeDispatch(document, ".uno:Undo", "", 0, Array())

	rem ----------------------------------------------------------------------
	rem dispatcher.executeDispatch(document, ".uno:Undo", "", 0, Array())

	rem ----------------------------------------------------------------------
	dim args49(0) as new com.sun.star.beans.PropertyValue
	args49(0).Name = "ToPoint"
	args49(0).Value = "$B$10"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args49())

	rem ----------------------------------------------------------------------
	dim args50(0) as new com.sun.star.beans.PropertyValue
	args50(0).Name = "ToPoint"
	args50(0).Value = "$A$1:$F$10"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args50())

	rem ----------------------------------------------------------------------
	dim args51(12) as new com.sun.star.beans.PropertyValue
	args51(0).Name = "OuterBorder.LeftBorder"
	args51(0).Value = Array(0,0,2,0,0,2)
	args51(1).Name = "OuterBorder.LeftDistance"
	args51(1).Value = 0
	args51(2).Name = "OuterBorder.RightBorder"
	args51(2).Value = Array(0,0,2,0,0,2)
	args51(3).Name = "OuterBorder.RightDistance"
	args51(3).Value = 0
	args51(4).Name = "OuterBorder.TopBorder"
	args51(4).Value = Array(0,0,2,0,0,2)
	args51(5).Name = "OuterBorder.TopDistance"
	args51(5).Value = 0
	args51(6).Name = "OuterBorder.BottomBorder"
	args51(6).Value = Array(0,0,2,0,0,2)
	args51(7).Name = "OuterBorder.BottomDistance"
	args51(7).Value = 0
	args51(8).Name = "InnerBorder.Horizontal"
	args51(8).Value = Array(0,0,2,0,0,2)
	args51(9).Name = "InnerBorder.Vertical"
	args51(9).Value = Array(0,0,2,0,0,2)
	args51(10).Name = "InnerBorder.Flags"
	args51(10).Value = 0
	args51(11).Name = "InnerBorder.ValidFlags"
	args51(11).Value = 127
	args51(12).Name = "InnerBorder.DefaultDistance"
	args51(12).Value = 0

	dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args51())

	rem ----------------------------------------------------------------------
	dim args52(0) as new com.sun.star.beans.PropertyValue
	args52(0).Name = "ToPoint"
	args52(0).Value = "$E$6"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args52())

	rem ----------------------------------------------------------------------
	dim args53(0) as new com.sun.star.beans.PropertyValue
	args53(0).Name = "ToPoint"
	args53(0).Value = "$A$1"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args53())

	rem ----------------------------------------------------------------------
	dim args54(0) as new com.sun.star.beans.PropertyValue
	args54(0).Name = "BackgroundColor"
	args54(0).Value = 8421504

	dispatcher.executeDispatch(document, ".uno:BackgroundColor", "", 0, args54())

	rem ----------------------------------------------------------------------
	dim args55(0) as new com.sun.star.beans.PropertyValue
	args55(0).Name = "ToPoint"
	args55(0).Value = "$C$14"

	dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args55())


end sub


sub test()

xSheet = ThisComponent.Sheets(0)
document = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

OffsetCell = xSheet.getCellByPosition(0,1)
offsetCell.string = "08:30-09:15"
OffsetCell = xSheet.getCellByPosition(0,2)
offsetCell.string = "09:30-10:15"
OffsetCell = xSheet.getCellByPosition(0,3)
OffsetCell.string = "10:30-11:15"
OffsetCell = xSheet.getCellByPosition(0,4)
offsetCell.string = "11:30-12:15"
OffsetCell = xSheet.getCellByPosition(0,5)
OffsetCell.string = "12:30-13:15"
OffsetCell = xSheet.getCellByPosition(0,7)
offsetCell.string = "14:00-14:45"
OffsetCell = xSheet.getCellByPosition(0,8)
OffsetCell.string = "15:00-15:45"
OffsetCell = xSheet.getCellByPosition(0,9)
offsetCell.string = "16:00-16:45"
OffsetCell = xSheet.getCellByPosition(0,10
OffsetCell.string = "17:00-17:45"
OffsetCell = xSheet.getCellByPosition(0,11)
OffsetCell.string = "18:00-18:45"


OffsetCell = xSheet.getCellByPosition(1,0)
offsetCell.string = "LUN"
OffsetCell = xSheet.getCellByPosition(2,0)
OffsetCell.string = "MAR"
OffsetCell = xSheet.getCellByPosition(3,0)
offsetCell.string = "MER"
OffsetCell = xSheet.getCellByPosition(4,0)
OffsetCell.string = "GIO"
OffsetCell = xSheet.getCellByPosition(5,0)
offsetCell.string = "VEN"


rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$A$1:$A$12"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "BackgroundColor"
args2(0).Value = 15658734

dispatcher.executeDispatch(document, ".uno:BackgroundColor", "", 0, args2())



rem ----------------------------------------------------------------------
dim args3(0) as new com.sun.star.beans.PropertyValue
args3(0).Name = "ToPoint"
args3(0).Value = "$A$1:$F$1"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args3())

rem ----------------------------------------------------------------------
dim args4(0) as new com.sun.star.beans.PropertyValue
args4(0).Name = "BackgroundColor"
args4(0).Value = 15658734

dispatcher.executeDispatch(document, ".uno:BackgroundColor", "", 0, args4())

rem ----------------------------------------------------------------------
dim args5(0) as new com.sun.star.beans.PropertyValue
args5(0).Name = "ToPoint"
args5(0).Value = "$D$3"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args5())







rem ----------------------------------------------------------------------
dim args6(0) as new com.sun.star.beans.PropertyValue
args6(0).Name = "ToPoint"
args6(0).Value = "$A$1:$F$12"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args6())

rem ----------------------------------------------------------------------
dim args7(12) as new com.sun.star.beans.PropertyValue
args7(0).Name = "OuterBorder.LeftBorder"
args7(0).Value = Array(0,0,2,0,0,2)
args7(1).Name = "OuterBorder.LeftDistance"
args7(1).Value = 0
args7(2).Name = "OuterBorder.RightBorder"
args7(2).Value = Array(0,0,2,0,0,2)
args7(3).Name = "OuterBorder.RightDistance"
args7(3).Value = 0
args7(4).Name = "OuterBorder.TopBorder"
args7(4).Value = Array(0,0,2,0,0,2)
args7(5).Name = "OuterBorder.TopDistance"
args7(5).Value = 0
args7(6).Name = "OuterBorder.BottomBorder"
args7(6).Value = Array(0,0,2,0,0,2)
args7(7).Name = "OuterBorder.BottomDistance"
args7(7).Value = 0
args7(8).Name = "InnerBorder.Horizontal"
args7(8).Value = Array(0,0,2,0,0,2)
args7(9).Name = "InnerBorder.Vertical"
args7(9).Value = Array(0,0,2,0,0,2)
args7(10).Name = "InnerBorder.Flags"
args7(10).Value = 0
args7(11).Name = "InnerBorder.ValidFlags"
args7(11).Value = 127
args7(12).Name = "InnerBorder.DefaultDistance"
args7(12).Value = 0

dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args7())


end sub




sub deleter
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$A$1:$F$13"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "Flags"
args2(0).Value = "A"

dispatcher.executeDispatch(document, ".uno:Delete", "", 0, args2())


end sub


sub minitable
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$B$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "StringName"
args2(0).Value = "Sigla"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args2())

dim args20(0) as new com.sun.star.beans.PropertyValue
args20(0).Name = "ToPoint"
args20(0).Value = "$C$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args20())

rem ----------------------------------------------------------------------
dim args3(0) as new com.sun.star.beans.PropertyValue
args3(0).Name = "StringName"
args3(0).Value = "Nome"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args3())

dim args21(0) as new com.sun.star.beans.PropertyValue
args21(0).Name = "ToPoint"
args21(0).Value = "$D$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args21())

rem ----------------------------------------------------------------------
dim args4(0) as new com.sun.star.beans.PropertyValue
args4(0).Name = "StringName"
args4(0).Value = "Docente"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args4())


rem ----------------------------------------------------------------------
dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())


end sub



sub minitable_corso
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args51(0) as new com.sun.star.beans.PropertyValue
args51(0).Name = "ToPoint"
args51(0).Value = "$A$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args51())

dim args24(0) as new com.sun.star.beans.PropertyValue
args24(0).Name = "StringName"
args24(0).Value = "Aula"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args24())

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$B$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "StringName"
args2(0).Value = "Sigla"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args2())

dim args20(0) as new com.sun.star.beans.PropertyValue
args20(0).Name = "ToPoint"
args20(0).Value = "$C$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args20())

rem ----------------------------------------------------------------------
dim args3(0) as new com.sun.star.beans.PropertyValue
args3(0).Name = "StringName"
args3(0).Value = "Nome"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args3())

dim args21(0) as new com.sun.star.beans.PropertyValue
args21(0).Name = "ToPoint"
args21(0).Value = "$D$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args21())

rem ----------------------------------------------------------------------
dim args4(0) as new com.sun.star.beans.PropertyValue
args4(0).Name = "StringName"
args4(0).Value = "Docente"

dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args4())


rem ----------------------------------------------------------------------
dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())


end sub



sub minitableBorder
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$B$14:$D$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(12) as new com.sun.star.beans.PropertyValue
args2(0).Name = "OuterBorder.LeftBorder"
args2(0).Value = Array(0,0,2,0,0,2)
args2(1).Name = "OuterBorder.LeftDistance"
args2(1).Value = 0
args2(2).Name = "OuterBorder.RightBorder"
args2(2).Value = Array(0,0,2,0,0,2)
args2(3).Name = "OuterBorder.RightDistance"
args2(3).Value = 0
args2(4).Name = "OuterBorder.TopBorder"
args2(4).Value = Array(0,0,2,0,0,2)
args2(5).Name = "OuterBorder.TopDistance"
args2(5).Value = 0
args2(6).Name = "OuterBorder.BottomBorder"
args2(6).Value = Array(0,0,2,0,0,2)
args2(7).Name = "OuterBorder.BottomDistance"
args2(7).Value = 0
args2(8).Name = "InnerBorder.Horizontal"
args2(8).Value = Array(0,0,2,0,0,2)
args2(9).Name = "InnerBorder.Vertical"
args2(9).Value = Array(0,0,2,0,0,2)
args2(10).Name = "InnerBorder.Flags"
args2(10).Value = 0
args2(11).Name = "InnerBorder.ValidFlags"
args2(11).Value = 127
args2(12).Name = "InnerBorder.DefaultDistance"
args2(12).Value = 0

dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args2())


end sub


sub minitableBorder_corso
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$A$14:$D$14"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(12) as new com.sun.star.beans.PropertyValue
args2(0).Name = "OuterBorder.LeftBorder"
args2(0).Value = Array(0,0,2,0,0,2)
args2(1).Name = "OuterBorder.LeftDistance"
args2(1).Value = 0
args2(2).Name = "OuterBorder.RightBorder"
args2(2).Value = Array(0,0,2,0,0,2)
args2(3).Name = "OuterBorder.RightDistance"
args2(3).Value = 0
args2(4).Name = "OuterBorder.TopBorder"
args2(4).Value = Array(0,0,2,0,0,2)
args2(5).Name = "OuterBorder.TopDistance"
args2(5).Value = 0
args2(6).Name = "OuterBorder.BottomBorder"
args2(6).Value = Array(0,0,2,0,0,2)
args2(7).Name = "OuterBorder.BottomDistance"
args2(7).Value = 0
args2(8).Name = "InnerBorder.Horizontal"
args2(8).Value = Array(0,0,2,0,0,2)
args2(9).Name = "InnerBorder.Vertical"
args2(9).Value = Array(0,0,2,0,0,2)
args2(10).Name = "InnerBorder.Flags"
args2(10).Value = 0
args2(11).Name = "InnerBorder.ValidFlags"
args2(11).Value = 127
args2(12).Name = "InnerBorder.DefaultDistance"
args2(12).Value = 0

dispatcher.executeDispatch(document, ".uno:SetBorderStyle", "", 0, args2())


end sub

sub deleterAll
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$A$1:$J$43"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "Flags"
args2(0).Value = "A"

dispatcher.executeDispatch(document, ".uno:Delete", "", 0, args2())

rem ----------------------------------------------------------------------
dim args3(0) as new com.sun.star.beans.PropertyValue
args3(0).Name = "ToPoint"
args3(0).Value = "$E$8"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args3())
end sub




sub forCorso

	call final_delete
	call deleter
	call test
	call minitable_corso
	call minitableBorder_corso


    dim preamble as String
    dim myValue as String
    dim finalString as String


    valore = InputBox("Inserisci codice corso di studi", "Corso di studi", "1")
    If valore <> "" Then


    rem define variables
    dim document   as object
    dim dispatcher as object
    xSheet = ThisComponent.Sheets(0)
    document   = ThisComponent.CurrentController.Frame
    dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")
    'FilePath = "/home/dandi/PycharmProjects/CSVeditor/result2.csv"


    'apre il file csv sorgente, deve trovarsi nella stessa directory del foglio di calcolo

    FilePath = ThisComponent.url()
    len1 = Len(FilePath)
    len2 = Len(ThisComponent.Title)
    FilePath = Left(FilePath, len1 - len2)

    FilePath = FilePath + "result2.csv"

    Open FilePath For Input As #1
    Open FilePath For Input As #2

rem ----------------------------------------------------------------------

    Dim column as integer
    Dim row As integer

rem ----------------------------------------------------------------------

    Dim i As Integer
    i = 0
    Dim valueToCheck As Integer


    Do Until EOF(1)


        Line Input #1, LineFromFile
        LineItems = Split(LineFromFile, ",")
        If LineItems(i) = "0" Then
            row = "1"
            column = "1"
        End If
        If LineItems(i) = "1" Then
            row = "1"
            column = "2"
        End If
        If LineItems(i) = "2" Then
            row = "1"
            column = "3"
        End If
        If LineItems(i) = "3" Then
            row = "1"
            column = "4"
        End If
        If LineItems(i) = "4" Then
            row = "1"
            column = "5"
        End If
        If LineItems(i) = "5" Then
            row = "1"
            column = "6"
        End If
        If LineItems(i) = "6" Then
            row = "1"
            column = "7"
        End If
        If LineItems(i) = "7" Then
            row = "1"
            column = "8"
        End If
        If LineItems(i) = "8" Then
            row = "1"
            column = "9"
        End If
        If LineItems(i) = "9" Then
            row = "1"
            column = "10"
        End If



        If LineItems(i) = "10" Then
            row = "2"
            column = "1"
        End If
        If LineItems(i) = "11" Then
            row = "2"
            column = "2"
        End If
        If LineItems(i) = "12" Then
            row = "2"
            column = "3"
        End If
        If LineItems(i) = "13" Then
            row = "2"
            column = "4"
        End If
        If LineItems(i) = "14" Then
            row = "2"
            column = "5"
        End If
        If LineItems(i) = "15" Then
            row = "2"
            column = "6"
        End If
        If LineItems(i) = "16" Then
            row = "2"
            column = "7"
        End If
        If LineItems(i) = "17" Then
            row = "2"
            column = "8"
        End If
        If LineItems(i) = "18" Then
            row = "2"
            column = "9"
        End If
        If LineItems(i) = "19" Then
            row = "2"
            column = "10"
        End If



        If LineItems(i) = "20" Then
            row = "3"
            column = "1"
        End If
        If LineItems(i) = "21" Then
            row = "3"
            column = "2"
        End If
        If LineItems(i) = "22" Then
            row = "3"
            column = "3"
        End If
        If LineItems(i) = "23" Then
            row = "3"
            column = "4"
        End If
        If LineItems(i) = "24" Then
            row = "3"
            column = "5"
        End If
        If LineItems(i) = "25" Then
            row = "3"
            column = "6"
        End If
        If LineItems(i) = "26" Then
            row = "3"
            column = "7"
        End If
        If LineItems(i) = "27" Then
            row = "3"
            column = "8"
        End If
        If LineItems(i) = "28" Then
            row = "3"
            column = "9"
        End If
        If LineItems(i) = "29" Then
            row = "3"
            column = "10"
        End If



        If LineItems(i) = "30" Then
            row = "4"
            column = "1"
        End If
        If LineItems(i) = "31" Then
            row = "4"
            column = "2"
        End If
        If LineItems(i) = "32" Then
            row = "4"
            column = "3"
        End If
        If LineItems(i) = "33" Then
            row = "4"
            column = "4"
        End If
        If LineItems(i) = "34" Then
            row = "4"
            column = "5"
        End If
        If LineItems(i) = "35" Then
            row = "4"
            column = "6"
        End If
        If LineItems(i) = "36" Then
            row = "4"
            column = "7"
        End If
        If LineItems(i) = "37" Then
            row = "4"
            column = "8"
        End If
        If LineItems(i) = "38" Then
            row = "4"
            column = "9"
        End If
        If LineItems(i) = "39" Then
            row = "4"
            column = "10"
        End If




        If LineItems(i) = "40" Then
            row = "5"
            column = "1"
        End If
        If LineItems(i) = "41" Then
            row = "5"
            column = "2"
        End If
        If LineItems(i) = "42" Then
            row = "5"
            column = "3"
        End If
        If LineItems(i) = "43" Then
            row = "5"
            column = "4"
        End If
        If LineItems(i) = "44" Then
            row = "5"
            column = "5"
        End If
        If LineItems(i) = "45" Then
            row = "5"
            column = "6"
        End If
        If LineItems(i) = "46" Then
            row = "5"
            column = "7"
        End If
        If LineItems(i) = "47" Then
            row = "5"
            column = "8"
        End If
        If LineItems(i) = "48" Then
            row = "5"
            column = "9"
        End If
        If LineItems(i) = "49" Then
            row = "5"
            column = "10"
        End If
        valueToCheck = InStr(LineItems(6), valore)
        If valueToCheck <> 0 Then
        	xSheet.getCellByPosition(row, column).string = LineItems(2)
        End If
    Loop



    Dim j As Integer
    j = 0
	Dim forCycle As Integer
	dim materia As String
	Dim check As Integer
	check = 0


    Do Until EOF(2)

        Line Input #2, LineFromFile
        LineItems = Split(LineFromFile, ",")
		valueToCheck = InStr(LineItems(6), valore)
        If valueToCheck <> 0 Then
			If materia <> LineItems(2) Then
				For forCycle = 0 To j
	        		If LineItems(2) = xSheet.getCellByPosition(1, 15 + forCycle).string Then
	        			check = 1
	        		End If
	        	Next forCycle
	        	If check <> 1 Then
	        	xSheet.getCellByPosition(0, 15 + j).string = LineItems(1)
	        	xSheet.getCellByPosition(1, 15 + j).string = LineItems(2)
	        	xSheet.getCellByPosition(2, 15 + j).string = LineItems(3)
	        	xSheet.getCellByPosition(3, 15 + j).string = LineItems(5)
	        	j = j+1
	        	materia = LineItems(2)
	        	End If
				check = 0
        	End If
		End If

    Loop

    End If




end sub









sub final_delete
rem ----------------------------------------------------------------------
rem define variables
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args1(0) as new com.sun.star.beans.PropertyValue
args1(0).Name = "ToPoint"
args1(0).Value = "$A$1:$F$198"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args1())

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "Flags"
args2(0).Value = "A"

dispatcher.executeDispatch(document, ".uno:Delete", "", 0, args2())


end sub