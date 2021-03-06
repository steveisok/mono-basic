  '
  ' Copyright (c) 2002-2003 Mainsoft Corporation.
  '
  ' Permission is hereby granted, free of charge, to any person obtaining a
  ' copy of this software and associated documentation files (the "Software"),
  ' to deal in the Software without restriction, including without limitation
  ' the rights to use, copy, modify, merge, publish, distribute, sublicense,
  ' and/or sell copies of the Software, and to permit persons to whom the
  ' Software is furnished to do so, subject to the following conditions:
  ' 
  ' The above copyright notice and this permission notice shall be included in
  ' all copies or substantial portions of the Software.
  ' 
  ' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  ' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  ' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  ' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  ' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
  ' FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
  ' DEALINGS IN THE SOFTWARE.
  '
Imports Microsoft.VisualBasic
Public Class TestClass
    Public Function Test() As String
        Dim fn As Integer
        Dim strFileName As String
        Dim strPathName As String
        
        '// make sure all files are closed
        Microsoft.VisualBasic.FileSystem.Reset()
        strPathName = "data/"
        strFileName = "6540.txt"
        'if this file exists - kill it
        If (strFileName = Dir(strPathName & strFileName)) Then
            Kill(strPathName & strFileName)
        End If
        'create the file
        fn = FreeFile()
        FileOpen(fn, strPathName & strFileName, OpenMode.Append)
        FileClose(fn)
        fn = FreeFile()
        'open with all modes
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Default, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Default, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Default, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Default, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Default, OpenShare.Shared)
        FileClose(fn)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Read, OpenShare.Default)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Read, OpenShare.LockRead)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Read, OpenShare.LockReadWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Read, OpenShare.LockWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Read, OpenShare.Shared)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Write, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Append, OpenAccess.Write, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Default, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Default, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Read, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        FileClose(fn)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.ReadWrite, OpenShare.Default)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.ReadWrite, OpenShare.LockRead)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.ReadWrite, OpenShare.LockWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.ReadWrite, OpenShare.Shared)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Write, OpenShare.Default)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Write, OpenShare.LockRead)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Write, OpenShare.LockReadWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Write, OpenShare.LockWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Input, OpenAccess.Write, OpenShare.Shared)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Default, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Default, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Default, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Default, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Default, OpenShare.Shared)
        FileClose(fn)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Read, OpenShare.Default)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Read, OpenShare.LockRead)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Read, OpenShare.LockReadWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Read, OpenShare.LockWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Read, OpenShare.Shared)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.ReadWrite, OpenShare.Default)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.ReadWrite, OpenShare.LockRead)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.ReadWrite, OpenShare.LockWrite)
        'FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.ReadWrite, OpenShare.Shared)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Default, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Default, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Default, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Default, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Default, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Read, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Read, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.Shared)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Write, OpenShare.Default)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockRead)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockReadWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite)
        FileClose(fn)
        FileOpen(fn, strPathName & strFileName, OpenMode.Random, OpenAccess.Write, OpenShare.Shared)
        FileClose(fn)
        Return "success"
    End Function
End Class
