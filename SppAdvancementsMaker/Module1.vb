Imports System.IO
Imports System.Text

Module Module1
    Public StrSavePath As String
    Public StrEditingAdvancementName As String

    ' 奖励类型 用于   FormRecipeLoot
    Public Enum RewardType
        Recipe
        Loot
    End Enum

    Public Sub CreateFile(StrFilePath As String, StrFileParentPath As String, StrFileText As String)
        ' 检测路径是否存在
        If Dir(StrFileParentPath, vbDirectory) = "" Then
            My.Computer.FileSystem.CreateDirectory(StrFileParentPath)
        End If
        ' 创建函数文件
        Dim FS As FileStream = File.Create(StrFilePath)
        Dim Info As Byte() = New UTF8Encoding(True).GetBytes(StrFileText)
        FS.Write(Info, 0, Info.Length)
        FS.Close()
    End Sub

    Public Function GetParentPath(StrPath As String) As String
        Dim StrTemps As String() = StrPath.Split("\")
        Dim StrTemp As String = ""
        For i = 0 To UBound(StrTemps) - 1
            StrTemp &= StrTemps(i) & "\"
        Next
        Return StrTemp
    End Function

    Public Function GetAdvancementPath(StrName As String)
        Dim StrPathName As String
        Dim StrTempPath As String = StrSavePath & "\data\advancements"
        ' 加后缀
        StrPathName = StrName & ".json"
        ' 改斜杠
        StrPathName = StrPathName.Replace("/", "\")
        StrPathName = StrPathName.Replace(":", "\")
        ' 加前缀
        StrPathName = StrTempPath & "\" & StrPathName
        Return StrPathName
    End Function
    Public Function GetAdvancementName(StrPath As String)
        Dim StrTempPath As String = StrSavePath & "\data\advancements"
        ' 把前面一大串删掉
        StrPath = StrPath.Replace(StrTempPath & "\", "")
        ' 换斜杠
        StrPath = StrPath.Replace("\", "/")
        ' 改冒号
        If StrPath.IndexOf("/") <> -1 Then
            StrPath = Microsoft.VisualBasic.Left(StrPath, StrPath.IndexOf("/")) & ":" & Microsoft.VisualBasic.Right(StrPath, StrPath.Length - StrPath.IndexOf("/") - 1)
        End If
        ' 去.json
        StrPath = Microsoft.VisualBasic.Left(StrPath, StrPath.Length - 5)
        ' 如果和原版进度名称相同
        For i = 0 To UBound(EnAdvancements)
            If StrPath = EnAdvancements(i) Then
                ' 就用原版的中文名代替
                StrPath = ZhAdvancements(i)
                Exit For
            End If
        Next
        Return StrPath
    End Function

    Public Function GetFunctionPath(StrName As String)
        Dim StrPathName As String
        Dim StrTempPath As String = StrSavePath & "\data\functions"
        ' 加后缀
        StrPathName = StrName & ".mcfunction"
        ' 改斜杠
        StrPathName = StrPathName.Replace("/", "\")
        StrPathName = StrPathName.Replace(":", "\")
        ' 加前缀
        StrPathName = StrTempPath & "\" & StrPathName
        Return StrPathName
    End Function
    Public Function GetFunctionName(StrPath As String)
        Dim StrTempPath As String = StrSavePath & "\data\functions"
        ' 把前面一大串删掉
        StrPath = StrPath.Replace(StrTempPath & "\", "")
        ' 换斜杠
        StrPath = StrPath.Replace("\", "/")
        ' 改冒号
        If StrPath.IndexOf("/") <> -1 Then
            StrPath = Left(StrPath, StrPath.IndexOf("/")) & ":" & Right(StrPath, StrPath.Length - StrPath.IndexOf("/") - 1)
        End If
        ' 去.mcfunction
        StrPath = Left(StrPath, StrPath.Length - 11)
        Return StrPath
    End Function

    Public Function GenerateAdvancement(StrItem As String, IntData As Int16, StrTitle As String, StrFrame As String,
                                        StrBackground As String, StrDescription As String, BoolShowToast As Boolean,
                                        BoolAnnounceToChat As Boolean, BoolHidden As Boolean, StrParent As String,
                                        StrCriteria As String, StrRequirements As String, StrRewards As String)
        Dim StrResult As String
        Dim BooRoot As Boolean = False
        Dim BooNotRoot As Boolean = False
        StrResult = "{"
        StrResult &= Chr(34) & "display" & Chr(34) & ":{"
        StrResult &= """icon"":{"
        If StrItem <> "" Then
            StrResult &= """item"":""" & StrItem & ""","
        Else
            Throw New Exception("未输入物品ID")
        End If
        StrResult &= """data"":" & IntData
        StrResult &= "},"
        If StrTitle <> "{}" Then
            StrResult &= """title"":" & StrTitle & ","
        Else
            Throw New Exception("未输入进度名称")
        End If
        If StrFrame <> "" Then
            StrResult &= """frame"":""" & StrFrame & ""","
        Else
            Throw New Exception("未输入边框种类")
        End If
        If StrBackground <> "" Then
            StrResult &= """background"":""" & StrBackground & ""","
            BooRoot = True
        Else
            BooRoot = False
        End If
        If StrDescription <> "{}" Then
            StrResult &= """description"":" & StrDescription & ","
        Else
            Throw New Exception("未输入进度描述")
        End If
        StrResult &= """show_toast"":" & BoolShowToast.ToString.ToLower & ","
        StrResult &= """announce_to_chat"":" & BoolAnnounceToChat.ToString.ToLower & ","
        StrResult &= """hidden"":" & BoolHidden.ToString.ToLower
        StrResult &= "},"
        If StrParent <> "" Then
            StrResult &= """parent"":""" & StrParent & ""","
            BooNotRoot = True
        Else
            BooNotRoot = False
        End If
        If (BooRoot And BooNotRoot) Or ((Not BooRoot) And (Not BooNotRoot)) Then
            Throw New Exception("根进度与子进度不明确")
        End If
        If StrCriteria <> "" Then
            StrResult &= Chr(34) & "criteria" & Chr(34) & ":{" & StrCriteria & "},"
        Else
            Throw New Exception("未设置条件")
        End If
        If StrRequirements <> "" Then
            StrResult &= Chr(34) & "requirements" & Chr(34) & ":[" & StrRequirements & "],"
        Else
            Throw New Exception("未设置条件")
        End If
        If StrRewards <> "" Then
            StrResult &= Chr(34) & "rewards" & Chr(34) & ":{" & StrRewards & "}"
        End If
        StrResult &= "}"
        StrResult = StrResult.Replace(",}", "}")
        StrResult = StrResult.Replace(",]", "]")
        StrResult = StrResult.Replace(",[]", "")
        StrResult = StrResult.Replace(",{}", "")
        Return StrResult
    End Function
End Module
