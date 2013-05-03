Imports System
Imports System.IO

Public Class Form1

    Inherits System.Windows.Forms.Form

    Dim bWeHaveAValidInputFile As Boolean = False 'For data validation (rudimentary)
    Dim stringInputStringFile As FileStream
    Dim stringReader As StreamReader
    Dim workingString As String = ""
    Const FILE_PATH As String = "cs540hw8input.txt"

    Private Function readValidInputTextFile(ByVal fileName As String)
        Try
            stringInputStringFile = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            stringReader = New StreamReader(stringInputStringFile)
            bWeHaveAValidInputFile = True
            Return True
        Catch ex As Exception
            bWeHaveAValidInputFile = False
            Return False
        End Try
    End Function

    Private Function getNextString(ByRef reader As StreamReader)
        Dim readString As String
        If reader.Peek() > -1 Then
            readString = reader.ReadLine()
        Else
            readString = ""
        End If
        Return readString
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If readValidInputTextFile(FILE_PATH) Then
            statusBarLabel.Text = ""
            workingString = getNextString(stringReader)
            processString(workingString)
        Else
            statusBarLabel.Text = "Input text file not found or is invalid"
        End If
    End Sub

    Private Sub processString(ByVal str As String)

        Dim f1 As Font
        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.resizeControlLabel.CreateGraphics
        s1 = g1.MeasureString(str, resizeControlLabel.Font)
        marginBuffer = g1.MeasureString(" ", resizeControlLabel.Font).Width
        resizeControlLabel.Width = s1.Width + marginBuffer
        g1.Dispose()

        resizeControlLabel.Text = str
        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Faktor, FaktorX, FaktorY As Single
        g2 = Me.resizeControlLabel.CreateGraphics
        s2 = g2.MeasureString("   " + str, resizeControlLabel.Font)
        g2.Dispose()
        FaktorX = resizeControlLabel.Width / s2.Width
        FaktorY = resizeControlLabel.Height / s2.Height
        If FaktorX > FaktorY Then
            Faktor = FaktorY
        Else
            Faktor = FaktorX
        End If
        f2 = resizeControlLabel.Font
        resizeControlLabel.Font = New Font(f2.Name, f2.SizeInPoints * Faktor)
        resizeControlLabel.Text = str

        Dim f3 As Font
        Dim g3 As Graphics
        Dim s3 As SizeF
        Dim Faktor1, Faktor1X, Faktor1Y As Single
        g3 = Me.resizeFontLabelAlt.CreateGraphics
        s3 = g3.MeasureString("   " + str, resizeFontLabelAlt.Font)
        g3.Dispose()
        Faktor1 = resizeFontLabelAlt.Width / s3.Width
        f3 = resizeFontLabelAlt.Font
        resizeFontLabelAlt.Text = str

    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        Dim fileReader As String
        Dim sFile As String
        Dim lineReader As System.IO.StreamReader
        sFile = StatusBarLabel.Text
        lineReader = My.Computer.FileSystem.OpenTextFileReader(sFile)
        fileReader = My.Computer.FileSystem.ReadAllText(sFile)
        resizeFontLabelAlt.Text = fileReader
        resizeControlLabel.Text = fileReader
        Dim b As String() = Split(resizeFontLabelAlt.Text, vbNewLine)
        Dim c As String() = Split(resizeControlLabel.Text, vbNewLine)
        resizeFontLabelAlt.Text = String.Join(vbNewLine, b, 1, b.Length - 1)
        resizeControlLabel.Text = String.Join(vbNewLine, c, 1, c.Length - 1)
    End Sub

  
    Private Sub StatusBarLabel_Click(sender As System.Object, e As System.EventArgs) Handles StatusBarLabel.Click
        Dim sMyFile As String
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim retVal As DialogResult = OpenFileDialog1.ShowDialog()
        If retVal = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1.CheckFileExists = True And OpenFileDialog1.CheckPathExists = True Then
                sMyFile = OpenFileDialog1.FileName
                StatusBarLabel.Text = sMyFile
            End If
        End If
    End Sub


End Class
