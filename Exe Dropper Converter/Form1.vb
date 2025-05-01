Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Public Class Form1

    Public Sub New()
        InitializeComponent()

        Guna2ComboBox1.SelectedIndex = 0
        Guna2ComboBox1.SelectedItem = "exe -> bat"
    End Sub
    Private Function OpenFile(ByVal type As String) As String
        Using d As OpenFileDialog = New OpenFileDialog()
            d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            d.Filter = $"{type}|{type}"
            d.DefaultExt = type
            d.RestoreDirectory = True

            If d.ShowDialog() <> DialogResult.OK Then Return Nothing

            Return d.FileName
        End Using
    End Function
    Private Function SaveFile(ByVal type As String) As String
        Using d As SaveFileDialog = New SaveFileDialog()
            d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            d.Filter = $"{type}|{type}"
            d.DefaultExt = type
            d.RestoreDirectory = True

            If d.ShowDialog() <> DialogResult.OK Then Return Nothing

            Return d.FileName
        End Using
    End Function

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim infile = OpenFile("*.exe")
        If infile Is Nothing Then Return
        Dim input = File.ReadAllBytes(infile)

        Dim output = New Byte(-1) {}
        Dim outtype = ""

        If Guna2ComboBox1.SelectedIndex = 0 Then
            output = Encoding.UTF8.GetBytes(Exe_Dropper_Converter.ExeConverter.ExeToBat(input))
            outtype = "*.bat"
        ElseIf Guna2ComboBox1.SelectedIndex = 1 Then
            output = Exe_Dropper_Converter.ExeConverter.ExeToBatNonPrintable(input)
            outtype = "*.bat"
        ElseIf Guna2ComboBox1.SelectedIndex = 2 Then
            output = Encoding.UTF8.GetBytes(Exe_Dropper_Converter.ExeConverter.ExeToVbs(input))
            outtype = "*.vbs"
        ElseIf Guna2ComboBox1.SelectedIndex = 3 Then
            output = Encoding.UTF8.GetBytes(Exe_Dropper_Converter.ExeConverter.ExeToJs(input))
            outtype = "*.js"
        ElseIf Guna2ComboBox1.SelectedIndex = 4 Then
            output = Encoding.UTF8.GetBytes(Exe_Dropper_Converter.ExeConverter.ExeToPs1(input))
            outtype = "*.ps1"
        End If

        Dim outfile = SaveFile(outtype)
        If outfile Is Nothing Then Return
        File.WriteAllBytes(outfile, output)
    End Sub
End Class
