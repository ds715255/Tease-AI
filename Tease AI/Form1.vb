﻿Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Runtime.InteropServices

Imports System
Imports System.Xml
Imports System.Xml.Linq
Imports System.Net
Imports System.Globalization

Imports System.Speech.Synthesis
Imports System.Speech.AudioFormat



'Comment added by kinkyswan to test pull request on GitHub (comment can be removed)

' Comment added to the test the effect of pulling a request into code that's been modified since the pull request was made



Public Class Form1

    Public Chat As String
    Public randomizer As New Random
    Public ScriptOperator As String
    Public ScriptCompare As String

    Public DomTyping As Boolean

    Dim CheckYes As Boolean
    Dim CheckNo As Boolean


    Public SubInChastity As Boolean

    Public FormLoading As Boolean

    Dim RandomDelay As Integer
    Dim Responding As Boolean

    Dim ScriptLineVal As Integer
    Public StrokeTauntVal As Integer
    Dim ThoughtTauntVal As Integer
    Dim ModuleTauntVal As Integer
    Public FileText As String
    Public TempStrokeTauntVal As Integer
    Public TempFileText As String
    Dim ModText As String

    Dim TeaseTick As Integer

    Dim StrokeTauntCount As Integer
    Dim TauntTextTotal As Integer
    Dim TauntLines As New List(Of String)
    Dim StrokeFilter As Boolean

    Public ScriptTick As Integer
    Dim StringLength As Integer
    Public FileGoto As String
    Public SkipGotoLine As Boolean

    Dim HandleScriptText As String
    Dim ChatString As String
    Dim DomTask As String
    Dim DomChat As String
    Dim TypeDelay As Integer
    Dim TempVal As Integer
    Dim NullResponse As Boolean

    Dim CleanFlag As Boolean

    Dim DebugAwarenessLine As String

    Public TagCount As Integer
    Public LocalTagCount As Integer

    Dim OrgasmResult As String
    Dim BeggedOrgasmDecision As Boolean
    Public TeaseOver As Boolean


    Dim TaskFile As String
    Dim TaskText As String
    Dim TaskTextDir As String


    Dim ResponseFile As String
    Dim ResponseLine As Integer

    Dim CBTCockActive As Boolean
    Dim CBTBallsActive As Boolean
    Dim CBTCockFlag As Boolean
    Dim CBTBallsFlag As Boolean
    Dim CBTBallsFirst As Boolean
    Dim CBTCockFirst As Boolean

    Dim ThoughtCount As Integer

    Dim GotoDommeLevel As Boolean

    Dim DommeMood As Integer

    Public AFK As Boolean

    Dim Chastity As Boolean
    Public HypnoGen As Boolean
    Public Induction As Boolean
    Public TempHypno As String

    Public DomColor As String
    Public SubColor As String

    Dim StrokeCycle As Integer

    Public StrokeTick As Integer
    Public StrokeTauntTick As Integer
    Public StrokePaceRight As Boolean
    Public StrokePace As Integer
    Public AudibleTick As Integer

    Dim StrokeTimeTotal As Integer
    Dim HoldEdgeTime As Integer
    Dim HoldEdgeTimeTotal As Integer

    Dim EdgeTauntInt As Integer

    Dim DelayTick As Integer
    Dim DelayFlag As Boolean

    Dim PreCleanString As String

    Dim DomTypeCheck As Boolean
    Dim TypeToggle As Boolean
    Dim IsTyping As Boolean
    Dim SubWroteLast As Boolean
    Dim YesOrNo As Boolean
    Dim GotoFlag As Boolean
    Dim LoopAnswer As Boolean

    Dim CBT As Boolean
    Dim NoEdge As Boolean

    Dim RunningScript As Boolean
    Dim RePound As Boolean

    Public BeforeTease As Boolean
    Public SubStroking As Boolean
    Dim SubEdging As Boolean
    Dim SubHoldingEdge As Boolean
    Dim SubCBT As Boolean
    Dim EndTease As Boolean

    Dim ShowThought As Boolean
    Dim ShowEdgeThought As Boolean
    Public ShowModule As Boolean
    Dim ModuleEnd As Boolean

    Dim DivideText As Boolean

    Dim HoldEdgeTick As Integer
    Dim HoldEdgeChance As Integer

    Dim EdgeHold As Boolean
    Dim EdgeNoHold As Boolean
    Dim EdgeToRuin As Boolean
    Dim EdgeToRuinSecret As Boolean
    Dim LongEdge As Boolean

    Dim AskedToGiveUp As Boolean
    Dim AskedToGiveUpSection As Boolean
    Dim SubGaveUp As Boolean
    Dim AskedToSpeedUp As Boolean
    Dim AskedToSlowDown As Boolean

    Dim ThoughtEnd As Boolean

    Dim VTLength As Integer

    Dim DommeVideo As Boolean
    Dim VideoType As String
    Public CensorshipGame As Boolean
    Public CensorshipTick As Integer
    Dim CensorshipTimerTick As Integer
    Dim CensorDuration As String
    Public AvoidTheEdgeGame As Boolean
    Public AvoidTheEdgeTick As Integer
    Dim AvoidTheEdgeTimerTick As Integer
    Dim AvoidTheEdgeDuration As String
    Public AvoidTheEdgeStroking As Boolean
    Dim AtECountdown As Integer

    Public VTPath As String
    Public NoVideo As Boolean
    Public NoSpecialVideo As Boolean
    Public VideoCheck As Boolean
    Public VideoTease As Boolean

    Public RLGLGame As Boolean
    Dim RLGLStroking As Boolean
    Public RLGLTick As Integer
    Dim RedLight As Boolean
    Dim RLGLTauntTick As Integer

    Public RandomizerVideo As Boolean
    Public RandomizerVideoTease As Boolean

    Public ScriptVideoTease As String
    Public ScriptVideoTeaseFlag As Boolean

    Dim VideoTauntTick As Integer


    Public SlideshowLoaded As Boolean
    Public RefreshVideoTotal As Integer

    Dim GlitterImageAV As String = Application.StartupPath & "\Images\Glitter\01.jpg"
    Public GlitterNCDomme As String
    Public GlitterNC1 As String
    Public GlitterNC2 As String
    Public GlitterNC3 As String
    Dim GlitterTempColor As String
    Public UpdatesTick As Integer
    Dim UpdatingPost As Boolean
    Public StatusText As String
    Dim ContactNumber As Integer
    Dim ContactTick As Integer
    Dim ContactFlag As Boolean


    Dim LastSuccessfulImage As Integer
    Dim GetFolder As String
    Dim FileCount As Integer
    Dim FileCountMax As Integer
    Private _ImageFileNames As New List(Of String)
    Private _CurrentImage As Integer = -1
    Dim WithTeaseImgDir As String
    Public ApproveImage As Integer = 0
    Public WIExit As Boolean
    Public RecentSlideshows As New List(Of String)

    Dim LockImage As Boolean

    Dim LocalTagImageList As New List(Of String)

    Dim Crazy As Boolean
    Dim Vulgar As Boolean
    Dim Supremacist As Boolean


    Public CockSize As Integer
    Dim TempDick As String
    Dim PetName As String
    Dim PetName2 As String
    Dim DescribeCock As String
    Dim Small As String
    Dim Worthless As String
    Dim TempSmallWords As Integer
    Dim TempBigWords As Integer
    Dim TempDickWords As Integer

    Dim SmallWords(0 To 18) As String
    Dim BigWords(0 To 18) As String
    Dim DickWords(0 To 9) As String
    Dim DescribeCockWords(0 To 20) As String
    Dim WorthlessWords(0 To 9) As String

    Dim TauntText As String
    Dim ScriptCount As Integer
    Dim TempScriptCount As Integer
    Dim TauntTextCount As Integer

    Dim StartIndex As Integer
    Dim EndIndex As Integer

    Dim Posts As XElement

    Public SlideshowTimerTick As Integer

    Dim ReadBlog As String
    Dim ReadBlogRate As String
    Dim SearchImageBlog As Boolean
    Dim FoundString As String
    Public WebImage As String

    Public WebImageFile As StreamReader
    Public WebImageLines As New List(Of String)
    Public WebImageLine As Integer
    Public WebImageLineTotal As Integer
    Public WebImagePath As String


    Dim ImageUrlFilePath As String
    Dim ImageUrlFileIndex As Integer


    Dim ReaderString As String
    Dim ReaderStringTotal As Integer

    Public StrokePaceInt As Integer

    Dim LastScriptCountdown As Integer
    Dim LastScript As Boolean

    Dim JustShowedBlogImage As Boolean

    Public SaidHello As Boolean

    Public StopMetronome As Boolean

    Public AvgEdgeStroking As Integer
    Public AvgEdgeNoTouch As Integer
    Public EdgeCountTick As Integer
    Public AvgEdgeStrokingFlag As Boolean
    Public AvgEdgeCount As Integer
    Public AvgEdgeCountRest As Integer
    Dim EdgeTickCheck As Integer

    Public AlreadyStrokingEdge As Boolean

    Dim WritingTaskLinesAmount As Integer
    Dim WritingTaskLinesWritten As Integer
    Dim WritingTaskLinesRemaining As Integer
    Dim WritingTaskMistakesAllowed As Integer
    Dim WritingTaskMistakesMade As Integer
    Dim WritingTaskFlag As Boolean

    Dim FirstRound As Boolean
    Public StartStrokingCount As Integer

    Dim TeaseJOI As Boolean
    Dim TeaseVideo As Boolean

    Dim TnAPath As String
    Dim TnAList As New List(Of String)
    Dim BoobList As New List(Of String)
    Dim AssList As New List(Of String)
    Dim AssImage As Boolean
    Dim BoobImage As Boolean

    Public ImageTagDir As New List(Of String)
    Public LocalImageTagDir As New List(Of String)
    Public ImageTagCount As Integer
    Public LocalImageTagCount As Integer

    Dim FoundTag As String = "Null"
    Dim TagGarment As String = "NULL"
    Dim TagUnderwear As String = "NULL"
    Dim TagTattoo As String = "NULL"
    Dim TagSexToy As String = "NULL"
    Dim TagFurniture As String = "NULL"

    Public ImportKeyword As Boolean

    Dim BookmarkModule As Boolean
    Dim BookmarkModuleFile As String
    Dim BookmarkModuleLine As Integer
    Dim BookmarkLink As Boolean
    Dim BookmarkLinkFile As String
    Dim BookmarkLinkLine As Integer

    Dim WaitTick As Integer

    Public synth As New SpeechSynthesizer
    Public synth2 As New SpeechSynthesizer



    Dim OrgasmDenied As Boolean
    Dim OrgasmAllowed As Boolean
    Dim OrgasmRuined As Boolean

    Dim StupidTick As Integer
    Dim StupidFlag As Boolean

    Public CaloriesConsumed As Integer
    Public CaloriesGoal As Integer

    Public GoldTokens As Integer
    Public SilverTokens As Integer
    Public BronzeTokens As Integer

    Dim EdgeFound As Boolean

    Dim OrgasmYesNo As Boolean

    Public VTFlag As Boolean

    Private GlitterThr As Threading.Thread

    Public Shared DomPersonality As String
    Public UpdateList As New List(Of String)

    Public GlitterDocument As String



    Private Const DISABLE_SOUNDS As Integer = 21
    Private Const SET_FEATURE_ON_PROCESS As Integer = 2


    ' IDs of video medias to be used with IMediaAccess
    Private Shared VideoHardCore As Guid = New Guid("{80C3D4B1-640F-4BE2-94DD-BA12FC04A6FD}")
    Private Shared VideoSoftCore As Guid = New Guid("{43370870-09C3-4B5C-8456-84713775094E}")
    Private Shared VideoLesbian As Guid = New Guid("{3EC1946B-DE0D-4415-B457-4024EC0A373E}")
    Private Shared VideoBlowjob As Guid = New Guid("{62892770-8E95-43E6-B7F9-1AA691A20DBC}")
    Private Shared VideoFemdom As Guid = New Guid("{0D844B64-EBEC-4979-9677-EBA9E22493E4}")
    Private Shared VideoFemsub As Guid = New Guid("{43F2BD51-C7C1-4C50-B7DE-CA32EECD409E}")
    Private Shared VideoJOI As Guid = New Guid("{66C185B3-088E-4258-B3F0-10445128BE5D}")
    Private Shared VideoCH As Guid = New Guid("{C5999F5E-B53A-4019-9752-D610CF0176D0}")
    Private Shared VideoGeneral As Guid = New Guid("{BDD06CA8-4A81-4B4A-89D2-36550FDBDA1E}")

    Private Shared VideoHardCoreD As Guid = New Guid("{AD7EB3E4-D352-4AA8-BD3A-709736FEF16A}")
    Private Shared VideoSoftCoreD As Guid = New Guid("{CBE01D9E-05F3-4EDE-B18D-1BD68102D7B8}")
    Private Shared VideoLesbianD As Guid = New Guid("{936E0989-5BCF-4C2F-A72A-B5B5C83FA22C}")
    Private Shared VideoBlowjobD As Guid = New Guid("{20D07577-2D6A-4DDE-9475-55C3F65158BC}")
    Private Shared VideoFemdomD As Guid = New Guid("{1CB83E62-EAF4-4AE8-9699-ABFE6086DD0C}")
    Private Shared VideoFemsubD As Guid = New Guid("{2A69CABD-A9DE-4EFF-BE63-B41BD43823E7}")
    Private Shared VideoJOID As Guid = New Guid("{E4447545-C333-472A-B46D-CCBF432382A8}")
    Private Shared VideoCHD As Guid = New Guid("{139E67CA-AE2D-4EDC-A833-308D772C1A09}")
    Private Shared VideoGeneralD As Guid = New Guid("{F0ACBEED-EEA1-4595-B2AA-25BE5EC9588B}")


    <DllImport("urlmon.dll")> _
    Public Shared Function CoInternetSetFeatureEnabled( _
    ByVal FeatureEntry As Integer, <MarshalAs(UnmanagedType.U4)> ByVal dwFlags As Integer, ByVal fEnable As Boolean) As Integer

    End Function

    Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, _
ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer


           




    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



        If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")

        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "Tease AI Metronome" Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception

        End Try


        Dim TempDate As String
        Dim TempDateNow As DateTime = DateTime.Now

        TempDate = TempDateNow.ToString("MM.dd.yyyy hhmm")

        If FrmSettings.CBSaveChatlogExit.Checked = True Then

            If (Not System.IO.Directory.Exists(Application.StartupPath & "\Chatlogs\")) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Chatlogs\")
            End If

            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\" & TempDate & " chatlog.html", ChatText.DocumentText, False)

        End If

        Try
            FrmSettings.Close()
            FrmSettings.Dispose()
        Catch ex As Exception
        End Try

        Try
            frmApps.Close()
            frmApps.Dispose()
        Catch ex As Exception
        End Try

        Try
            FrmWritingTask.Close()
            FrmWritingTask.Dispose()
        Catch ex As Exception
        End Try

        Try
            FrmCardList.Close()
            FrmCardList.Dispose()
        Catch ex As Exception
        End Try

        End




    End Sub




    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Debug.Print("Initializing Core")
        Core.Initialize()

        Debug.Print("Form Opened")

        FormLoading = True

        If My.Settings.OrgasmLockDate = Nothing Then My.Settings.OrgasmLockDate = FormatDateTime(Now, DateFormat.ShortDate)
        My.Settings.Save()
        Debug.Print("OrgasmLockDate = " & My.Settings.OrgasmLockDate)

   




        If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")

        frmApps.Show()


        If My.Settings.TCAgreed = True Then
            frmApps.ClearAgree()
        End If


        If My.Settings.LargeUI = True Then
            LargeUI()
            PNLChatBox.Location = New Point(0, 214)
        End If

        If My.Settings.SmallUI = True Then
            SmallUI()
            PNLChatBox.Location = New Point(0, 172)
        End If

        If My.Settings.UI768 = True Then
            UI768()
            PNLChatBox.Location = New Point(0, 173)
        End If


        FrmSettings.Show()
        FrmSettings.FrmSettingsLoading = True

        FrmSettings.FrmSettingStartUp()

        Do
            Application.DoEvents()
        Loop Until FrmSettings.FrmSettingsLoading = False

        FrmWritingTask.Show()
        FrmWritingTask.Visible = False



        StopMetronome = True



        StrokeTimeTotal = My.Settings.StrokeTimeTotal
        StrokeTimeTotalTimer.Start()

        Dim STT As TimeSpan = TimeSpan.FromSeconds(StrokeTimeTotal)
        FrmSettings.LBLStrokeTimeTotal.Text = String.Format("{0:0000}:{1:00}:{2:00}:{3:00}", STT.Days, STT.Hours, STT.Minutes, STT.Seconds)


        DomTask = "Null"
        DomChat = "Null"

        CBTBallsFirst = True
        CBTCockFirst = True

        CoInternetSetFeatureEnabled(DISABLE_SOUNDS, SET_FEATURE_ON_PROCESS, True)



        If File.Exists(My.Settings.DomAvatarSave) Then domAvatar.LoadFromUrl(My.Settings.DomAvatarSave)
        If File.Exists(My.Settings.SubAvatarSave) Then subAvatar.LoadFromUrl(My.Settings.SubAvatarSave)


        For Each comboitem As String In My.Settings.RecentSlideshows
            ImageFolderComboBox.Items.Add(comboitem)
        Next

        RecentSlideshows.Clear()

        For Each comboitem As String In My.Settings.RecentSlideshows
            RecentSlideshows.Add(comboitem)
        Next

        Chat = ""
        IsTypingTimer.Start()

        FrmSettings.LblVideoHardCore.Text = My.Settings.VideoHardcore
        FrmSettings.LblVideoSoftCore.Text = My.Settings.VideoSoftcore
        FrmSettings.LblVideoLesbian.Text = My.Settings.VideoLesbian
        FrmSettings.LblVideoBlowjob.Text = My.Settings.VideoBlowjob
        FrmSettings.LblVideoFemdom.Text = My.Settings.VideoFemdom
        FrmSettings.LblVideoFemsub.Text = My.Settings.VideoFemsub
        FrmSettings.LblVideoJOI.Text = My.Settings.VideoJOI
        FrmSettings.LblVideoCH.Text = My.Settings.VideoCH
        FrmSettings.LblVideoGeneral.Text = My.Settings.VideoGeneral

        FrmSettings.LblVideoHardCoreD.Text = My.Settings.VideoHardcoreD
        FrmSettings.LblVideoSoftCoreD.Text = My.Settings.VideoSoftcoreD
        FrmSettings.LblVideoLesbianD.Text = My.Settings.VideoLesbianD
        FrmSettings.LblVideoBlowjobD.Text = My.Settings.VideoBlowjobD
        FrmSettings.LblVideoFemdomD.Text = My.Settings.VideoFemdomD
        FrmSettings.LblVideoFemsubD.Text = My.Settings.VideoFemsubD
        FrmSettings.LblVideoJOID.Text = My.Settings.VideoJOID
        FrmSettings.LblVideoCHD.Text = My.Settings.VideoCHD
        FrmSettings.LblVideoGeneralD.Text = My.Settings.VideoGeneralD

        If My.Settings.CBHardcore = True Then FrmSettings.CBVideoHardcore.Checked = True
        If My.Settings.CBSoftcore = True Then FrmSettings.CBVideoSoftCore.Checked = True
        If My.Settings.CBLesbian = True Then FrmSettings.CBVideoLesbian.Checked = True
        If My.Settings.CBBlowjob = True Then FrmSettings.CBVideoBlowjob.Checked = True
        If My.Settings.CBFemdom = True Then FrmSettings.CBVideoFemdom.Checked = True
        If My.Settings.CBFemsub = True Then FrmSettings.CBVideoFemsub.Checked = True
        If My.Settings.CBJOI = True Then FrmSettings.CBVideoJOI.Checked = True
        If My.Settings.CBCH = True Then FrmSettings.CBVideoCH.Checked = True
        If My.Settings.CBGeneral = True Then FrmSettings.CBVideoGeneral.Checked = True

        If My.Settings.CBHardcoreD = True Then FrmSettings.CBVideoHardcoreD.Checked = True
        If My.Settings.CBSoftcoreD = True Then FrmSettings.CBVideoSoftCoreD.Checked = True
        If My.Settings.CBLesbianD = True Then FrmSettings.CBVideoLesbianD.Checked = True
        If My.Settings.CBBlowjobD = True Then FrmSettings.CBVideoBlowjobD.Checked = True
        If My.Settings.CBFemdomD = True Then FrmSettings.CBVideoFemdomD.Checked = True
        If My.Settings.CBFemsubD = True Then FrmSettings.CBVideoFemsubD.Checked = True
        If My.Settings.CBJOID = True Then FrmSettings.CBVideoJOID.Checked = True
        If My.Settings.CBCHD = True Then FrmSettings.CBVideoCHD.Checked = True
        If My.Settings.CBGeneralD = True Then FrmSettings.CBVideoGeneralD.Checked = True

        Dim mediaAccess As IMediaAccess = ServiceProvider.Instance.GetService(Of IMediaAccess)
        mediaAccess.AddMediaFolder(VideoHardCore, New MediaFolder(Function() FrmSettings.LblVideoHardCore.Text, Function() FrmSettings.CBVideoHardcore.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoSoftCore, New MediaFolder(Function() FrmSettings.LblVideoSoftCore.Text, Function() FrmSettings.CBVideoSoftCore.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoLesbian, New MediaFolder(Function() FrmSettings.LblVideoLesbian.Text, Function() FrmSettings.CBVideoLesbian.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoBlowjob, New MediaFolder(Function() FrmSettings.LblVideoBlowjob.Text, Function() FrmSettings.CBVideoBlowjob.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoFemdom, New MediaFolder(Function() FrmSettings.LblVideoFemdom.Text, Function() FrmSettings.CBVideoFemdom.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoFemsub, New MediaFolder(Function() FrmSettings.LblVideoFemsub.Text, Function() FrmSettings.CBVideoFemsub.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoJOI, New MediaFolder(Function() FrmSettings.LblVideoJOI.Text, Function() FrmSettings.CBVideoJOI.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoCH, New MediaFolder(Function() FrmSettings.LblVideoCH.Text, Function() FrmSettings.CBVideoCH.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoGeneral, New MediaFolder(Function() FrmSettings.LblVideoGeneral.Text, Function() FrmSettings.CBVideoGeneral.Checked, MediaFolder.Videos))

        mediaAccess.AddMediaFolder(VideoHardCoreD, New MediaFolder(Function() FrmSettings.LblVideoHardCoreD.Text, Function() FrmSettings.CBVideoHardcoreD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoSoftCoreD, New MediaFolder(Function() FrmSettings.LblVideoSoftCoreD.Text, Function() FrmSettings.CBVideoSoftCoreD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoLesbianD, New MediaFolder(Function() FrmSettings.LblVideoLesbianD.Text, Function() FrmSettings.CBVideoLesbianD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoBlowjobD, New MediaFolder(Function() FrmSettings.LblVideoBlowjobD.Text, Function() FrmSettings.CBVideoBlowjobD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoFemdomD, New MediaFolder(Function() FrmSettings.LblVideoFemdomD.Text, Function() FrmSettings.CBVideoFemdomD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoFemsubD, New MediaFolder(Function() FrmSettings.LblVideoFemsubD.Text, Function() FrmSettings.CBVideoFemsubD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoJOID, New MediaFolder(Function() FrmSettings.LblVideoJOID.Text, Function() FrmSettings.CBVideoJOID.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoCHD, New MediaFolder(Function() FrmSettings.LblVideoCHD.Text, Function() FrmSettings.CBVideoCHD.Checked, MediaFolder.Videos))
        mediaAccess.AddMediaFolder(VideoGeneralD, New MediaFolder(Function() FrmSettings.LblVideoGeneralD.Text, Function() FrmSettings.CBVideoGeneralD.Checked, MediaFolder.Videos))

        If My.Settings.NBCensorShowMin > 0 Then FrmSettings.NBCensorShowMin.Value = My.Settings.NBCensorShowMin
        If My.Settings.NBCensorShowMax > 0 Then FrmSettings.NBCensorShowMax.Value = My.Settings.NBCensorShowMax
        If My.Settings.NBCensorHideMin > 0 Then FrmSettings.NBCensorHideMin.Value = My.Settings.NBCensorHideMin
        If My.Settings.NBCensorHideMax > 0 Then FrmSettings.NBCensorHideMax.Value = My.Settings.NBCensorHideMax

        If My.Settings.CBCensorConstant = True Then FrmSettings.CBCensorConstant.Checked = True

        If File.Exists(My.Settings.GlitterAV) Then FrmSettings.GlitterAV.LoadFromUrl(My.Settings.GlitterAV)
        If File.Exists(My.Settings.GlitterAV1) Then FrmSettings.GlitterAV1.LoadFromUrl(My.Settings.GlitterAV1)
        If File.Exists(My.Settings.GlitterAV2) Then FrmSettings.GlitterAV2.LoadFromUrl(My.Settings.GlitterAV2)
        If File.Exists(My.Settings.GlitterAV3) Then FrmSettings.GlitterAV3.LoadFromUrl(My.Settings.GlitterAV3)

        HardCoreVideoTotal()
        SoftcoreVideoTotal()
        LesbianVideoTotal()
        BlowjobVideoTotal()
        FemdomVideoTotal()
        FemsubVideoTotal()
        JOIVideoTotal()
        CHVideoTotal()
        GeneralVideoTotal()

        HardcoreDVideoTotal()
        SoftcoreDVideoTotal()
        LesbianDVideoTotal()
        BlowjobDVideoTotal()
        FemdomDVideoTotal()
        FemsubDVideoTotal()
        JOIDVideoTotal()
        CHDVideoTotal()
        GeneralDVideoTotal()

        VideoType = "General"

        UpdatesTick = 120
        UpdatesTimer.Start()

        GlitterNC1 = "DeepPink"
        GlitterNC2 = "Green"
        GlitterNC3 = "Firebrick"

        Me.ActiveControl = Me.chatBox



        If My.Settings.GlitterSN <> "" Then FrmSettings.TBGlitterShortName.Text = My.Settings.GlitterSN
        If My.Settings.Glitter1 <> "" Then FrmSettings.TBGlitter1.Text = My.Settings.Glitter1
        If My.Settings.Glitter2 <> "" Then FrmSettings.TBGlitter2.Text = My.Settings.Glitter2
        If My.Settings.Glitter3 <> "" Then FrmSettings.TBGlitter3.Text = My.Settings.Glitter3

        If My.Settings.GlitterNCDomme <> "" Then
            GlitterNCDomme = My.Settings.GlitterNCDomme
            FrmSettings.LBLGlitterNCDomme.ForeColor = My.Settings.GlitterNCDommeColor
        End If

        If My.Settings.GlitterNC1 <> "" Then
            GlitterNC1 = My.Settings.GlitterNC1
            FrmSettings.LBLGlitterNC1.ForeColor = My.Settings.GlitterNC1Color
        End If

        If My.Settings.GlitterNC2 <> "" Then
            GlitterNC2 = My.Settings.GlitterNC2
            FrmSettings.LBLGlitterNC2.ForeColor = My.Settings.GlitterNC2Color
        End If

        If My.Settings.GlitterNC3 <> "" Then
            GlitterNC3 = My.Settings.GlitterNC3
            FrmSettings.LBLGlitterNC3.ForeColor = My.Settings.GlitterNC3Color
        End If

        If My.Settings.DomColor <> "" Then
            DomColor = My.Settings.DomColor
            FrmSettings.LBLDomColor.ForeColor = My.Settings.DomColorColor
        End If

        If My.Settings.SubColor <> "" Then
            SubColor = My.Settings.SubColor
            FrmSettings.LBLSubColor.ForeColor = My.Settings.SubColorColor
        End If

        If My.Settings.GlitterDSlider <> 0 Then FrmSettings.GlitterSlider.Value = My.Settings.GlitterDSlider
        If My.Settings.Glitter1Slider <> 0 Then FrmSettings.GlitterSlider1.Value = My.Settings.Glitter1Slider
        If My.Settings.Glitter2Slider <> 0 Then FrmSettings.GlitterSlider2.Value = My.Settings.Glitter2Slider
        If My.Settings.Glitter3Slider <> 0 Then FrmSettings.GlitterSlider3.Value = My.Settings.Glitter3Slider

        If My.Settings.CBGlitterFeed = True Then
            FrmSettings.CBGlitterFeed.Checked = True
        Else
            FrmSettings.CBGlitterFeed.Checked = False
        End If
        If My.Settings.CBGlitter1 = True Then
            FrmSettings.CBGlitter1.Checked = True
        Else
            FrmSettings.CBGlitter1.Checked = False
        End If
        If My.Settings.CBGlitter2 = True Then
            FrmSettings.CBGlitter2.Checked = True
        Else
            FrmSettings.CBGlitter2.Checked = False
        End If
        If My.Settings.CBGlitter3 = True Then
            FrmSettings.CBGlitter3.Checked = True
        Else
            FrmSettings.CBGlitter3.Checked = False
        End If


        If My.Settings.CBTease = True Then
            FrmSettings.CBTease.Checked = True
        Else
            FrmSettings.CBTease.Checked = False
        End If
        If My.Settings.CBEgotist = True Then
            FrmSettings.CBEgotist.Checked = True
        Else
            FrmSettings.CBEgotist.Checked = False
        End If
        If My.Settings.CBTrivia = True Then
            FrmSettings.CBTrivia.Checked = True
        Else
            FrmSettings.CBTrivia.Checked = False
        End If
        If My.Settings.CBDaily = True Then
            FrmSettings.CBDaily.Checked = True
        Else
            FrmSettings.CBDaily.Checked = False
        End If
        If My.Settings.CBCustom1 = True Then
            FrmSettings.CBCustom1.Checked = True
        Else
            FrmSettings.CBCustom1.Checked = False
        End If
        If My.Settings.CBCustom2 = True Then
            FrmSettings.CBCustom2.Checked = True
        Else
            FrmSettings.CBCustom2.Checked = False
        End If


        If My.Settings.CB1Bratty = True Then
            FrmSettings.CB1Bratty.Checked = True
        Else
            FrmSettings.CB1Bratty.Checked = False
        End If
        If My.Settings.CB1Cruel = True Then
            FrmSettings.CB1Cruel.Checked = True
        Else
            FrmSettings.CB1Cruel.Checked = False
        End If
        If My.Settings.CB1Caring = True Then
            FrmSettings.CB1Caring.Checked = True
        Else
            FrmSettings.CB1Caring.Checked = False
        End If
        If My.Settings.CB1Angry = True Then
            FrmSettings.CB1Angry.Checked = True
        Else
            FrmSettings.CB1Angry.Checked = False
        End If
        If My.Settings.CB1Custom1 = True Then
            FrmSettings.CB1Custom1.Checked = True
        Else
            FrmSettings.CB1Custom1.Checked = False
        End If
        If My.Settings.CB1Custom2 = True Then
            FrmSettings.CB1Custom2.Checked = True
        Else
            FrmSettings.CB1Custom2.Checked = False
        End If

        If My.Settings.CB2Bratty = True Then
            FrmSettings.CB2Bratty.Checked = True
        Else
            FrmSettings.CB2Bratty.Checked = False
        End If
        If My.Settings.CB2Cruel = True Then
            FrmSettings.CB2Cruel.Checked = True
        Else
            FrmSettings.CB2Cruel.Checked = False
        End If
        If My.Settings.CB2Caring = True Then
            FrmSettings.CB2Caring.Checked = True
        Else
            FrmSettings.CB2Caring.Checked = False
        End If
        If My.Settings.CB2Angry = True Then
            FrmSettings.CB2Angry.Checked = True
        Else
            FrmSettings.CB2Angry.Checked = False
        End If
        If My.Settings.CB2Custom1 = True Then
            FrmSettings.CB2Custom1.Checked = True
        Else
            FrmSettings.CB2Custom1.Checked = False
        End If
        If My.Settings.CB2Custom2 = True Then
            FrmSettings.CB2Custom2.Checked = True
        Else
            FrmSettings.CB2Custom2.Checked = False
        End If

        If My.Settings.CB3Bratty = True Then
            FrmSettings.CB3Bratty.Checked = True
        Else
            FrmSettings.CB3Bratty.Checked = False
        End If
        If My.Settings.CB3Cruel = True Then
            FrmSettings.CB3Cruel.Checked = True
        Else
            FrmSettings.CB3Cruel.Checked = False
        End If
        If My.Settings.CB3Caring = True Then
            FrmSettings.CB3Caring.Checked = True
        Else
            FrmSettings.CB3Caring.Checked = False
        End If
        If My.Settings.CB3Angry = True Then
            FrmSettings.CB3Angry.Checked = True
        Else
            FrmSettings.CB3Angry.Checked = False
        End If
        If My.Settings.CB3Custom1 = True Then
            FrmSettings.CB3Custom1.Checked = True
        Else
            FrmSettings.CB3Custom1.Checked = False
        End If
        If My.Settings.CB3Custom2 = True Then
            FrmSettings.CB3Custom2.Checked = True
        Else
            FrmSettings.CB3Custom2.Checked = False
        End If




        If My.Settings.DomName <> "" Then domName.Text = My.Settings.DomName
        If My.Settings.SubName <> "" Then subName.Text = My.Settings.SubName


        FrmSettings.petnameBox1.Text = My.Settings.pnSetting1
        FrmSettings.petnameBox2.Text = My.Settings.pnSetting2
        FrmSettings.petnameBox3.Text = My.Settings.pnSetting3
        FrmSettings.petnameBox4.Text = My.Settings.pnSetting4
        FrmSettings.petnameBox5.Text = My.Settings.pnSetting5
        FrmSettings.petnameBox6.Text = My.Settings.pnSetting6
        FrmSettings.petnameBox7.Text = My.Settings.pnSetting7
        FrmSettings.petnameBox8.Text = My.Settings.pnSetting8

        If My.Settings.CBTimeStamps = True Then
            FrmSettings.timestampCheckBox.Checked = True
        Else
            FrmSettings.timestampCheckBox.Checked = False
        End If

        If My.Settings.CBShowNames = True Then
            FrmSettings.shownamesCheckBox.Checked = True
        Else
            FrmSettings.shownamesCheckBox.Checked = False
        End If

        If My.Settings.CBInstantType = True Then
            FrmSettings.typeinstantlyCheckBox.Checked = True
        Else
            FrmSettings.typeinstantlyCheckBox.Checked = False
        End If

        If My.Settings.CBLockWindow = True Then
            FrmSettings.CBLockWindow.Checked = True
            SplitContainer1.IsSplitterFixed = True
        Else
            FrmSettings.CBLockWindow.Checked = False
            SplitContainer1.IsSplitterFixed = False
        End If

        If My.Settings.CBBlogImageMain = True Then
            FrmSettings.CBBlogImageWindow.Checked = True
        Else
            FrmSettings.CBBlogImageWindow.Checked = False
        End If

        If My.Settings.CBSlideshowSubDir = True Then
            FrmSettings.CBSlideshowSubDir.Checked = True
        Else
            FrmSettings.CBSlideshowSubDir.Checked = False
        End If

        If My.Settings.CBSlideshowRandom = True Then
            FrmSettings.CBSlideshowRandom.Checked = True
        Else
            FrmSettings.CBSlideshowRandom.Checked = False
        End If

        If My.Settings.CBStretchLandscape = True Then
            FrmSettings.landscapeCheckBox.Checked = True
        Else
            FrmSettings.landscapeCheckBox.Checked = False
        End If


        If My.Settings.CBSettingsPause = True Then
            FrmSettings.CBSettingsPause.Checked = True
        Else
            FrmSettings.CBSettingsPause.Checked = False
        End If


        If My.Settings.CBAutosaveChatlog = True Then
            FrmSettings.CBAutosaveChatlog.Checked = True
        Else
            FrmSettings.CBAutosaveChatlog.Checked = False
        End If

        If My.Settings.CBExitSaveChatlog = True Then
            FrmSettings.CBSaveChatlogExit.Checked = True
        Else
            FrmSettings.CBSaveChatlogExit.Checked = False
        End If

        If My.Settings.CBImageInfo = True Then
            FrmSettings.CBImageInfo.Checked = True
        Else
            FrmSettings.CBImageInfo.Checked = False
        End If

        If My.Settings.AuditStartup = True Then
            FrmSettings.CBAuditStartup.Checked = True
        Else
            FrmSettings.CBAuditStartup.Checked = False
        End If

        FrmSettings.domageNumBox.Value = My.Settings.DomAge

        If My.Settings.DomLevel <> 0 Then FrmSettings.domlevelNumBox.Value = My.Settings.DomLevel

        If FrmSettings.domlevelNumBox.Value = 1 Then FrmSettings.DomLevelDescLabel.Text = "Gentle"
        If FrmSettings.domlevelNumBox.Value = 2 Then FrmSettings.DomLevelDescLabel.Text = "Lenient"
        If FrmSettings.domlevelNumBox.Value = 3 Then FrmSettings.DomLevelDescLabel.Text = "Tease"
        If FrmSettings.domlevelNumBox.Value = 4 Then FrmSettings.DomLevelDescLabel.Text = "Rough"
        If FrmSettings.domlevelNumBox.Value = 5 Then FrmSettings.DomLevelDescLabel.Text = "Sadistic"

        FrmSettings.NBDomBirthdayMonth.Value = My.Settings.DomBirthMonth
        FrmSettings.NBDomBirthdayDay.Value = My.Settings.DomBirthDay

        FrmSettings.TBDomHairColor.Text = My.Settings.DomHair
        FrmSettings.domhairlengthComboBox.Text = My.Settings.DomHairLength
        FrmSettings.TBDomEyeColor.Text = My.Settings.DomEyes
        FrmSettings.boobComboBox.Text = My.Settings.DomCup
        FrmSettings.dompubichairComboBox.Text = My.Settings.DomPubicHair

        Debug.Print("Find Exception begin")

        If My.Settings.DomTattoos = True Then
            FrmSettings.CBDomTattoos.Checked = True
        Else
            FrmSettings.CBDomTattoos.Checked = False
        End If

        If My.Settings.DomFreckles = True Then
            FrmSettings.CBDomFreckles.Checked = True
        Else
            FrmSettings.CBDomFreckles.Checked = False
        End If




        Debug.Print("Find Exception")

        If My.Settings.DomCrazy = True Then
            FrmSettings.crazyCheckBox.Checked = True
        Else
            FrmSettings.crazyCheckBox.Checked = False
        End If

        If My.Settings.DomVulgar = True Then
            FrmSettings.vulgarCheckBox.Checked = True
        Else
            FrmSettings.vulgarCheckBox.Checked = False
        End If

        If My.Settings.DomSupremacist = True Then
            FrmSettings.supremacistCheckBox.Checked = True
        Else
            FrmSettings.supremacistCheckBox.Checked = False
        End If

        If My.Settings.DomLowercase = True Then
            FrmSettings.LCaseCheckBox.Checked = True
        Else
            FrmSettings.LCaseCheckBox.Checked = False
        End If

        If My.Settings.DomNoApostrophes = True Then
            FrmSettings.apostropheCheckBox.Checked = True
        Else
            FrmSettings.apostropheCheckBox.Checked = False
        End If

        If My.Settings.DomNoCommas = True Then
            FrmSettings.commaCheckBox.Checked = True
        Else
            FrmSettings.commaCheckBox.Checked = False
        End If

        If My.Settings.DomNoPeriods = True Then
            FrmSettings.periodCheckBox.Checked = True
        Else
            FrmSettings.periodCheckBox.Checked = False
        End If

        If My.Settings.DomMeMyMine = True Then
            FrmSettings.CBMeMyMine.Checked = True
        Else
            FrmSettings.CBMeMyMine.Checked = False
        End If



        FrmSettings.domemoteComboBox.Text = My.Settings.DomEmotes

        FrmSettings.alloworgasmComboBox.Text = My.Settings.OrgasmAllow
        FrmSettings.ruinorgasmComboBox.Text = My.Settings.OrgasmRuin

        If My.Settings.DomDenialEnd = True Then
            FrmSettings.CBDomDenialEnds.Checked = True
        Else
            FrmSettings.CBDomDenialEnds.Checked = False
        End If

        If My.Settings.DomOrgasmEnd = True Then
            FrmSettings.CBDomOrgasmEnds.Checked = True
        Else
            FrmSettings.CBDomOrgasmEnds.Checked = False
        End If


        FrmSettings.orgasmsPerNumBox.Value = My.Settings.DomOrgasmPer
        FrmSettings.orgasmsperComboBox.Text = My.Settings.DomPerMonth

        If My.Settings.DomLock = True Then
            FrmSettings.orgasmsperlockButton.Enabled = False
            FrmSettings.orgasmlockrandombutton.Enabled = False
            FrmSettings.limitcheckbox.Checked = True
            FrmSettings.limitcheckbox.Enabled = False
            FrmSettings.orgasmsPerNumBox.Enabled = False
            FrmSettings.orgasmsperComboBox.Enabled = False
        End If

        FrmSettings.NBDomMoodMin.Value = My.Settings.DomMoodMin
        FrmSettings.NBDomMoodMax.Value = My.Settings.DomMoodMax
        FrmSettings.NBAvgCockMin.Value = My.Settings.AvgCockMin
        FrmSettings.NBAvgCockMax.Value = My.Settings.AvgCockMax
        FrmSettings.NBSelfAgeMin.Value = My.Settings.SelfAgeMin
        FrmSettings.NBSelfAgeMax.Value = My.Settings.SelfAgeMax
        FrmSettings.NBSubAgeMin.Value = My.Settings.SubAgeMin
        FrmSettings.NBSubAgeMax.Value = My.Settings.SubAgeMax


        Debug.Print("Find Exception end")

        FrmSettings.LblGlitterSettingsDescription.Text = "Hover the cursor over any setting in the menu for a more detailed description of its function."

        Try
            FrmSettings.LBLGlitModDomType.Text = FrmSettings.dompersonalityComboBox.Text
        Catch
            FrmSettings.LBLGlitModDomType.Text = "Error!"
        End Try

        Try
            Dim files() As String = Directory.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\" & FrmSettings.CBGlitModType.Text & "\")
            Dim GlitterScriptCount As Integer
            FrmSettings.LBGlitModScripts.Items.Clear()
            For Each file As String In files
                GlitterScriptCount += 1
                FrmSettings.LBGlitModScripts.Items.Add(Path.GetFileName(file).Replace(".txt", ""))
            Next
            FrmSettings.LBLGlitModScriptCount.Text = FrmSettings.CBGlitModType.Text & " Scripts Found (" & GlitterScriptCount & ")"
        Catch
            FrmSettings.LBLGlitModScriptCount.Text = "No Scripts Found!"
        End Try


        FrmSettings.NBWritingTaskMin.Value = My.Settings.NBWritingTaskMin
        FrmSettings.NBWritingTaskMax.Value = My.Settings.NBWritingTaskMax



        If My.Settings.CBBnBLocal = True Then FrmSettings.CBBnBLocal.Checked = True
        If My.Settings.CBBnBURL = True Then FrmSettings.CBBnBURL.Checked = True
        If My.Settings.CBBoobSubDir = True Then FrmSettings.CBBoobSubDir.Checked = True
        If My.Settings.CBButtSubDir = True Then FrmSettings.CBButtSubDir.Checked = True

        FrmSettings.LBLBoobPath.Text = My.Settings.LBLBoobPath
        FrmSettings.LBLBoobURL.Text = My.Settings.LBLBoobURL
        FrmSettings.LBLButtPath.Text = My.Settings.LBLButtPath
        FrmSettings.LBLButtURL.Text = My.Settings.LBLButtURL

        If My.Settings.CBEnableBnB = True Then FrmSettings.CBEnableBnB.Checked = True


        FrmSettings.CockSizeNumBox.Value = My.Settings.SubCockSize
        FrmSettings.subAgeNumBox.Value = My.Settings.SubAge

        FrmSettings.TBGreeting.Text = My.Settings.SubGreeting
        FrmSettings.TBYes.Text = My.Settings.SubYes
        FrmSettings.TBNo.Text = My.Settings.SubNo
        FrmSettings.TBHonorific.Text = My.Settings.SubHonorific

        If My.Settings.CBUseHonor = True Then
            FrmSettings.CBHonorificInclude.Checked = True
        Else
            FrmSettings.CBHonorificInclude.Checked = False
        End If

        If My.Settings.CBCapHonor = True Then
            FrmSettings.CBHonorificCapitalized.Checked = True
        Else
            FrmSettings.CBHonorificCapitalized.Checked = False
        End If

        FrmSettings.SliderSTF.Value = My.Settings.TimerSTF
        If FrmSettings.SliderSTF.Value = 1 Then FrmSettings.LBLStf.Text = "Preoccupied"
        If FrmSettings.SliderSTF.Value = 2 Then FrmSettings.LBLStf.Text = "Distracted"
        If FrmSettings.SliderSTF.Value = 3 Then FrmSettings.LBLStf.Text = "Normal"
        If FrmSettings.SliderSTF.Value = 4 Then FrmSettings.LBLStf.Text = "Talkative"
        If FrmSettings.SliderSTF.Value = 5 Then FrmSettings.LBLStf.Text = "Verbose"

        FrmSettings.TauntSlider.Value = My.Settings.TimerVTF
        If FrmSettings.TauntSlider.Value = 1 Then FrmSettings.LBLVtf.Text = "Preoccupied"
        If FrmSettings.TauntSlider.Value = 2 Or FrmSettings.TauntSlider.Value = 3 Then FrmSettings.LBLVtf.Text = "Distracted"
        If FrmSettings.TauntSlider.Value = 4 Or FrmSettings.TauntSlider.Value = 5 Then FrmSettings.LBLVtf.Text = "Normal"
        If FrmSettings.TauntSlider.Value = 6 Or FrmSettings.TauntSlider.Value = 7 Or FrmSettings.TauntSlider.Value = 8 Then FrmSettings.LBLVtf.Text = "Talkative"
        If FrmSettings.TauntSlider.Value = 9 Or FrmSettings.TauntSlider.Value = 10 Then FrmSettings.LBLVtf.Text = "Verbose"

        FrmSettings.NBBirthdayMonth.Value = My.Settings.SubBirthMonth
        FrmSettings.NBBirthdayDay.Value = My.Settings.SubBirthDay
        FrmSettings.TBSubHairColor.Text = My.Settings.SubHair
        FrmSettings.TBSubEyeColor.Text = My.Settings.SubEyes


        FrmSettings.FontComboBoxD.Text = My.Settings.DomFont
        FrmSettings.NBFontSizeD.Text = My.Settings.DomFontSize
        FrmSettings.FontComboBox.Text = My.Settings.SubFont
        FrmSettings.NBFontSize.Text = My.Settings.SubFontSize

        DomWMP.Height = SplitContainer1.Panel1.Height + 60

        If My.Settings.DomAVStretch = False Then domAvatar.SizeMode = PictureBoxSizeMode.Zoom
        If My.Settings.SubAvStretch = False Then subAvatar.SizeMode = PictureBoxSizeMode.Zoom

        HoldEdgeTimeTotal = My.Settings.HoldEdgeTimeTotal

        BTNFileTransferOpen.Visible = False
        BTNFIleTransferDismiss.Visible = False


        frmApps.LBLCalorie.Text = My.Settings.CaloriesConsumed
        Debug.Print("HOW MANY FUCKING CALORIES!!!! " & My.Settings.CaloriesConsumed)

        If File.Exists(Application.StartupPath & "\System\VitalSub\ExerciseList.cld") Then
            LoadExercise()
        End If

        CaloriesConsumed = My.Settings.CaloriesConsumed

        If File.Exists(Application.StartupPath & "\System\VitalSub\CalorieItems.txt") Then
            Dim CalReader As New StreamReader(Application.StartupPath & "\System\VitalSub\CalorieItems.txt")
            While CalReader.Peek <> -1
                frmApps.LBCalorie.Items.Add(CalReader.ReadLine())
            End While
            CalReader.Close()
            CalReader.Dispose()
            frmApps.LBLCalorie.Text = CaloriesConsumed
        Else
            CaloriesConsumed = 0
            My.Settings.CaloriesConsumed = 0
            My.Settings.Save()
            frmApps.LBLCalorie.Text = CaloriesConsumed
        End If


        frmApps.CBVitalSub.Checked = My.Settings.VitalSub

        If frmApps.CBVitalSub.Checked = True Then
            frmApps.CBVitalSub.ForeColor = Color.LightGreen
            frmApps.CBVitalSub.Text = "VitalSub Active"
        Else
            frmApps.CBVitalSub.ForeColor = Color.Red
            frmApps.CBVitalSub.Text = "VitalSub Inactive"
        End If

        frmApps.CBVitalSubDomTask.Checked = My.Settings.VitalSubAssignments

        Try
            RefreshCards()
        Catch
        End Try

        GoldTokens = My.Settings.GoldTokens
        SilverTokens = My.Settings.SilverTokens
        BronzeTokens = My.Settings.BronzeTokens

        StrokePaceInt = 1
        StrokePaceRight = True
        StrokePaceTimer.Start()

      

        DommeMood = randomizer.Next(5, 8)


        If My.Settings.LastOrgasm = Nothing Then
            My.Settings.LastOrgasm = FormatDateTime(Now, DateFormat.ShortDate)
            My.Settings.Save()
        End If

        FrmSettings.LBLLastOrgasm.Text = My.Settings.LastOrgasm.ToString()

        If My.Settings.LastRuined = Nothing Then
            My.Settings.LastRuined = FormatDateTime(Now, DateFormat.ShortDate)
            My.Settings.Save()
        End If

        FrmSettings.LBLLastRuined.Text = My.Settings.LastRuined.ToString()

        If CompareDates(My.Settings.DateStamp) <> 0 Then
            MessageBox.Show(Me, "You've received 5 Bronze tokens!", "Daily Login Bonus", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.DateStamp = FormatDateTime(Now, DateFormat.ShortDate)
            BronzeTokens += 5
            SaveTokens()
        End If


        If CompareDates(My.Settings.WishlistDate) <> 0 Then
            My.Settings.ClearWishlist = False
            My.Settings.Save()
        End If
     

        AvgEdgeStroking = My.Settings.AvgEdgeStroking
        AvgEdgeNoTouch = My.Settings.AvgEdgeNoTouch
        AvgEdgeCount = My.Settings.AvgEdgeCount
        AvgEdgeCountRest = My.Settings.AvgEdgeCountRest



        If My.Settings.AvgEdgeCount > 4 Then
            Dim TS1 As TimeSpan = TimeSpan.FromSeconds(AvgEdgeStroking)
            FrmSettings.LBLAvgEdgeStroking.Text = String.Format("{0:00}:{1:00}", TS1.Minutes, TS1.Seconds)
        Else
            FrmSettings.LBLAvgEdgeStroking.Text = "WAIT"
        End If


        If My.Settings.AvgEdgeCountRest > 4 Then
            Dim TS2 As TimeSpan = TimeSpan.FromSeconds(AvgEdgeNoTouch)
            FrmSettings.LBLAvgEdgeNoTouch.Text = String.Format("{0:00}:{1:00}", TS2.Minutes, TS2.Seconds)
        Else
            FrmSettings.LBLAvgEdgeNoTouch.Text = "WAIT"
        End If

        PictureStrip.Items(0).Enabled = False
        PictureStrip.Items(1).Enabled = False
        PictureStrip.Items(2).Enabled = False
        PictureStrip.Items(3).Enabled = False

        DomPersonality = FrmSettings.dompersonalityComboBox.Text

        FormLoading = False

        Debug.Print("Form1 Loading Finished")

    End Sub

    Private Sub sendButton_BindingContextChanged(sender As Object, e As System.EventArgs) Handles sendButton.BindingContextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendButton.Click

        Dim CheckSpace As String = chatBox.Text

        CheckSpace = CheckSpace.Replace(" ", "")

        If CheckSpace = "" Then Return


        If FrmSettings.dompersonalityComboBox.Items.Count < 1 Then
            MessageBox.Show(Me, "No domme Personalities were found! Please install at least one Personality directory in the Scripts folder before using this part of the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return
        End If

        ChatString = chatBox.Text

        chatBox.Text = ""

        If ChatString.Substring(0, 1) = "@" Then

            If ChatString = "@" Then

                Chat = "<font face=""Cambria"" size=""2"" color=""Green"">" & Chat & ChatString.Replace("@", "") & "::: TYPO ::: <br>::: FileText = " & FileText & " ::: LineVal = " & StrokeTauntVal & "<br>::: TauntText = " & TauntText & " ::: LineVal = " & TauntTextCount & "<br>::: ResponseFile = " & ResponseFile & " ::: LineVal = " & ResponseLine & "<br></font>"
            Else
                Chat = "<font face=""Cambria"" size=""2"" color=""Green"">" & Chat & ChatString.Replace("@", "") & " :::  <br>::: FileText = " & FileText & " ::: LineVal = " & StrokeTauntVal & "<br>::: TauntText = " & TauntText & " ::: LineVal = " & TauntTextCount & "<br>::: ResponseFile = " & ResponseFile & " ::: LineVal = " & ResponseLine & "<br></font>"
            End If


            ChatText.DocumentText = Chat
            While ChatText.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
          ScrollChatDown()

            chatBox.Text = ""

            If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

            Return
        End If

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If



        ' Add timestamps to domme response if the option is checked in the menu
        If FrmSettings.timestampCheckBox.Checked = True Then
            Chat = Chat & "<font face=""Cambria"" size=""2"" color=""DimGray"">" & (Date.Now.ToString("hh:mm tt ")) & "</font>"
        End If

        If WritingTaskFlag = True Then GoTo WritingTaskLine

        If SubWroteLast = True And FrmSettings.shownamesCheckBox.Checked = False Then

            Chat = "<body style=""word-wrap:break-word;"">" & Chat & "<font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#000000"">" & ChatString & "<br></font></body>"
            ChatText.DocumentText = Chat
            While ChatText.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
           ScrollChatDown()


        Else

            Chat = "<body style=""word-wrap:break-word;"">" & Chat & "<font face=""Cambria"" size=""3"" font color=""" & _
                SubColor & """><b>" & subName.Text & ": </b></font><font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#000000"">" & ChatString & "<br></font></body>"

            ChatText.DocumentText = Chat
            While ChatText.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
         ScrollChatDown()

        End If



        If My.Settings.UI768 = True Then
            If PNLMediaBar.Visible = True Then
                ChatText.Location = New Point(0, 29)
            Else
                ChatText.Location = New Point(0, 0)
            End If
            ChatText.Width = 683
        End If

        If My.Settings.LargeUI = True Then
            If PNLMediaBar.Visible = True Then
                ChatText.Location = New Point(0, 29)
            Else
                ChatText.Location = New Point(0, 0)
            End If
            ChatText.Width = 1089
        End If

        If My.Settings.SmallUI = True Then
            If PNLMediaBar.Visible = True Then
                ChatText.Location = New Point(0, 29)
            Else
                ChatText.Location = New Point(0, 0)
            End If
            ChatText.Width = 839
        End If

       ScrollChatDown()

        If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

        If IsTyping = True Then

            ChatText.DocumentText = Chat & "<font color=""DimGray""><i>" & domName.Text & " is typing...</i></font>"
            While ChatText.ReadyState <> WebBrowserReadyState.Complete
                Application.DoEvents()
            End While
          ScrollChatDown()
        End If



        SubWroteLast = True




        If frmApps.CBDebugAwareness.Checked = True Then GoTo DebugAwareness



        If SaidHello = False Then
            If UCase(ChatString).Contains("TASK") Then
                Dim TaskList As New List(Of String)

                For Each TaskFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Start Tasks\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                    TaskList.Add(TaskFile)
                Next
                If TaskList.Count > 0 Then
                    BeforeTease = True
                    SaidHello = True
                    SubEdging = False
                    SubHoldingEdge = False
                    FileText = TaskList(randomizer.Next(0, TaskList.Count))
                    LockImage = False
                    StrokeTauntVal = -1
                    ScriptTick = 3
                    ScriptTimer.Start()
                    ShowModule = False
                Else
                    MessageBox.Show(Me, "No files were found in " & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Start Tasks!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
                Return
            End If




            Dim TempGreeting As String = FrmSettings.TBGreeting.Text
            TempGreeting = "[" & TempGreeting & "] Null"
            Dim Splits As String() = TempGreeting.Split(New Char() {"]"c})
            Splits(0) = Splits(0).Replace("[", "")

            Do
                Splits(0) = Splits(0).Replace("  ", " ")
                Splits(0) = Splits(0).Replace(" ,", ",")
                Splits(0) = Splits(0).Replace(", ", ",")
                Splits(0) = Splits(0).Replace("'", "")
            Loop Until Not Splits(0).Contains("  ") And Not Splits(0).Contains(", ") And Not Splits(0).Contains(" ,") And Not Splits(0).Contains("'")

            Dim SplitParts As String() = Splits(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1

                If UCase(ChatString).Contains(UCase(SplitParts(i))) Then


                    If FrmSettings.CBHonorificInclude.Checked = True Then

                        If WordExists(UCase(ChatString), UCase(FrmSettings.TBHonorific.Text)) = False Then

                            'If InStr(UCase(ChatString), (UCase(FrmSettings.TBHonorific.Text))) = 0 Then
                            'If Not UCase(ChatString).Contains(UCase(FrmSettings.TBHonorific.Text)) Then
                            DomChat = SplitParts(i) & " what?"
                            If FrmSettings.LCaseCheckBox.Checked = False Then
                                Dim DomU As String = UCase(DomChat.Substring(0, 1))
                                DomChat = DomChat.Remove(0, 1)
                                DomChat = DomU & DomChat
                            End If
                            TypingDelay()
                            Return
                        End If




                        If FrmSettings.CBHonorificCapitalized.Checked = True Then
                            If WordExists(ChatString, Capitalize(FrmSettings.TBHonorific.Text)) = False Then
                                'If Not ChatString.Contains(FrmSettings.TBHonorific.Text) Then
                                DomChat = "#CapitalizeHonorific"
                                TypingDelay()
                                Return
                            End If
                        End If
                    End If

                    Debug.Print("CHeck")

                    SaidHello = True
                    BeforeTease = True

                    If FrmSettings.CBTeaseLengthDD.Checked = True Then


                        If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                        If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                        If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                        If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                        If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60


                    Else

                        TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)

                    End If


                    TeaseTimer.Start()

                    Dim StartList As New List(Of String)
                    StartList.Clear()

                    Dim ChastityStartCheck As String
                    If Chastity = True Then
                        ChastityStartCheck = "*_CHASTITY.txt"
                    Else
                        ChastityStartCheck = "*.txt"
                    End If

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\Start\", FileIO.SearchOption.SearchTopLevelOnly, ChastityStartCheck)
                        Dim TempStart As String = foundFile
                        TempStart = TempStart.Replace(".txt", "")
                        Do Until Not TempStart.Contains("\")
                            TempStart = TempStart.Remove(0, 1)
                        Loop
                        For x As Integer = 0 To FrmSettings.CLBStartList.Items.Count - 1
                            If Chastity = True Then
                                If FrmSettings.CLBStartList.Items(x) = TempStart And FrmSettings.CLBStartList.GetItemChecked(x) = True Then
                                    StartList.Add(foundFile)
                                End If
                            Else
                                If FrmSettings.CLBStartList.Items(x) = TempStart And FrmSettings.CLBStartList.GetItemChecked(x) = True And Not TempStart.Contains("_CHASTITY") Then
                                    StartList.Add(foundFile)
                                End If
                            End If

                        Next
                    Next

                    If StartList.Count < 1 Then
                        If Chastity = True Then
                            FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Start_CHASTITY.txt"
                        Else
                            FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Start.txt"
                        End If
                    Else
                        FileText = StartList(randomizer.Next(0, StartList.Count))
                    End If

                    LastScriptCountdown = randomizer.Next(3, 5 * FrmSettings.domlevelNumBox.Value)

                    If Directory.Exists(FrmSettings.LBLDomImageDir.Text) And SlideshowLoaded = False Then
                        LoadDommeImageFolder()
                    End If




                    StrokeTauntVal = -1
                    ScriptTick = 3
                    ScriptTimer.Start()


                End If


            Next

        End If




        If SaidHello = False Then Return

        If UCase(ChatString) = UCase(FrmSettings.TBSafeword.Text) Then


            Dim SafeList As New List(Of String)

            For Each SafeFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Safeword\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                SafeList.Add(SafeFile)
            Next

            If SafeList.Count > 0 Then
                StopEverything()
                FileText = SafeList(randomizer.Next(0, SafeList.Count))
                ShowModule = True
                StrokeTauntVal = -1
                ScriptTick = 2
                ScriptTimer.Start()
            Else
                MessageBox.Show(Me, "No files were found in " & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Safeword!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            Return
        End If

        If UCase(ChatString).Contains(UCase("stop")) Then TnASlides.Stop()

WritingTaskLine:

        If WritingTaskFlag = True Then


            If ChatString = FrmWritingTask.LBLWritingTaskText.Text Then

                WritingTaskLinesWritten += 1
                WritingTaskLinesRemaining -= 1

                FrmWritingTask.LBLLinesWritten.Text = WritingTaskLinesWritten
                FrmWritingTask.LBLLinesRemaining.Text = WritingTaskLinesRemaining

                If SubWroteLast = True And FrmSettings.shownamesCheckBox.Checked = False Then

                    Chat = "<font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#000000"">" & Chat & ChatString & "<br></font>"
                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                  ScrollChatDown()

                Else

                    Chat = Chat & "<font face=""Cambria"" size=""3"" font color=""" & _
                SubColor & """><b>" & subName.Text & ": </b></font><font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#000000"">" & ChatString & "<br></font>"

                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                 ScrollChatDown()

                End If

                If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

                If IsTyping = True Then

                    ChatText.DocumentText = Chat & "<font color=""DimGray""><i>" & domName.Text & " is typing...</i></font>"
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                   ScrollChatDown()
                End If

                chatBox.Text = ""

                SubWroteLast = True


                If WritingTaskLinesRemaining = 0 Then
                    WritingTaskFlag = False
                    FrmWritingTask.Visible = False
                    chatBox.ShortcutsEnabled = True
                    RunFileText()
                End If


            Else

                If SubWroteLast = True And FrmSettings.shownamesCheckBox.Checked = False Then

                    Chat = "<font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#000000"">" & Chat & "</font><font color=""#FF0000"">" & ChatString & "<br></font>"
                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                   ScrollChatDown()

                Else

                    Chat = Chat & "<font face=""Cambria"" size=""3"" font color=""" & _
                SubColor & """><b>" & subName.Text & ": </b></font><font face=""" & FrmSettings.FontComboBox.Text & """ size=""" & FrmSettings.NBFontSize.Value & """ color=""#FF0000"">" & ChatString & "<br></font>"
                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                 ScrollChatDown()

                End If

                If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

                If IsTyping = True Then

                    ChatText.DocumentText = Chat & "<font color=""DimGray""><i>" & domName.Text & " is typing...</i></font>"
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                    ScrollChatDown()
                End If

                SubWroteLast = True

                WritingTaskMistakesMade += 1
                FrmWritingTask.LBLMistakesMade.Text = WritingTaskMistakesMade

                If WritingTaskMistakesMade = WritingTaskMistakesAllowed Then
                    WritingTaskFlag = False
                    FrmWritingTask.Visible = False
                    chatBox.ShortcutsEnabled = True
                    SkipGotoLine = True
                    FileGoto = "Failed Writing Task"
                    GetGoto()
                    RunFileText()
                End If


            End If

        End If

        If AFK = True Then Return

        ' Remove commas and apostrophes from user's entered text
        ChatString = ChatString.Replace(",", "")
        ChatString = ChatString.Replace("'", "")
        ChatString = ChatString.Replace(".", "")

        ' If the domme is waiting for a response, go straight to this sub-routine instead
        If YesOrNo = True And OrgasmYesNo = False Then
            YesOrNoQuestions()
            Return
        End If


        Dim EdgeReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\EdgeKEY.txt")
        Dim EdgeList As New List(Of String)

        While EdgeReader.Peek <> -1
            EdgeList.Add(EdgeReader.ReadLine)
        End While

        EdgeReader.Close()
        EdgeReader.Dispose()

        Dim EdgeCheck As String = ChatString


        Dim EdgeString As String

        Debug.Print("EdgeFOund 1 = " & EdgeFound)

        For i As Integer = 0 To EdgeList.Count - 1
            EdgeString = EdgeList(i)
            EdgeString = EdgeString.Replace("'", "")
            EdgeString = EdgeString.Replace(".", "")
            EdgeString = EdgeString.Replace(",", "")
            EdgeString = EdgeString.Replace("!", "")
            Debug.Print("UCase(EdgeString)  = " & UCase(EdgeString))
            Debug.Print("EdgeCheck  = " & UCase(EdgeCheck))
            If UCase(EdgeString) = UCase(EdgeCheck) Then EdgeFound = True
        Next

        Debug.Print("EdgeFOund 2 = " & EdgeFound)

        If EdgeFound = True Then

            Debug.Print("EdgeFOund = True Called")

            EdgeFound = False

            If SubHoldingEdge = True Then
                Debug.Print("EdgeFOund = SubHoldingedge")
                DomChat = " #YoureAlreadySupposedToBeClose"
                TypingDelay()
                Return
            End If

            If RLGLGame = True Then
                Debug.Print("EdgeFOund = RLGL")
                DomChat = "#TryToHoldIt"
                TypingDelay()
                Return
            End If


            If AvoidTheEdgeStroking = True Then

                Debug.Print("EdgeFOund = ATE")

                AvoidTheEdgeTaunts.Stop()

                AvoidTheEdgeStroking = False
                VideoTease = False

                Dim ATEList As New List(Of String)

                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Avoid The Edge\Scripts\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                    ATEList.Add(foundFile)
                Next

                If ATEList.Count < 1 Then
                    MessageBox.Show(Me, "No Avoid The Edge scripts were found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return
                End If

                DomWMP.Ctlcontrols.pause()

                StrokeTauntVal = -1
                FileText = ATEList(randomizer.Next(0, ATEList.Count))

                ScriptTick = 2
                ScriptTimer.Start()
                Return
            End If


            If SubEdging = True Then

                Debug.Print("EdgeFOund = SubEdging")

                EdgeCountTimer.Stop()

                If SubStroking = True Then
                    AvgEdgeCount += 1
                    If AvgEdgeStroking = 0 Then
                        AvgEdgeStroking = EdgeCountTick
                    Else
                        AvgEdgeStroking = (AvgEdgeStroking + EdgeCountTick) / AvgEdgeCount
                    End If
                    My.Settings.AvgEdgeStroking = AvgEdgeStroking
                    My.Settings.AvgEdgeCount = AvgEdgeCount
                Else
                    AvgEdgeCountRest += 1
                    If AvgEdgeNoTouch = 0 Then
                        AvgEdgeNoTouch = EdgeCountTick
                    Else
                        AvgEdgeNoTouch = (AvgEdgeNoTouch + EdgeCountTick) / AvgEdgeCountRest
                    End If
                    My.Settings.AvgEdgeNoTouch = AvgEdgeNoTouch
                    My.Settings.AvgEdgeCountRest = AvgEdgeCountRest
                End If

                My.Settings.Save()

                If My.Settings.AvgEdgeCount > 4 Then
                    AvgEdgeStroking = My.Settings.AvgEdgeStroking
                    Dim TS1 As TimeSpan = TimeSpan.FromSeconds(AvgEdgeStroking)
                    FrmSettings.LBLAvgEdgeStroking.Text = String.Format("{0:00}:{1:00}", TS1.Minutes, TS1.Seconds)
                Else
                    FrmSettings.LBLAvgEdgeStroking.Text = "WAIT"
                End If

                If My.Settings.AvgEdgeCountRest > 4 Then
                    AvgEdgeNoTouch = My.Settings.AvgEdgeNoTouch
                    Dim TS2 As TimeSpan = TimeSpan.FromSeconds(AvgEdgeNoTouch)
                    FrmSettings.LBLAvgEdgeNoTouch.Text = String.Format("{0:00}:{1:00}", TS2.Minutes, TS2.Seconds)
                Else
                    FrmSettings.LBLAvgEdgeNoTouch.Text = "WAIT"
                End If

                If FrmSettings.domlevelNumBox.Value = 1 Then HoldEdgeChance = 20
                If FrmSettings.domlevelNumBox.Value = 2 Then HoldEdgeChance = 25
                If FrmSettings.domlevelNumBox.Value = 3 Then HoldEdgeChance = 30
                If FrmSettings.domlevelNumBox.Value = 4 Then HoldEdgeChance = 40
                If FrmSettings.domlevelNumBox.Value = 5 Then HoldEdgeChance = 50

                Dim HoldEdgeInt As Integer = randomizer.Next(1, 101)

                If EdgeHold = True Then HoldEdgeInt = 0
                If EdgeNoHold = True Then HoldEdgeInt = 1000


                Debug.Print("HoldEdgeInt = " & HoldEdgeInt)

                EdgeHold = False
                EdgeNoHold = False



                If HoldEdgeInt < HoldEdgeChance Then

                    Debug.Print("EdgeFOund = HOldtheedge")

                    DomTypeCheck = True
                    SubEdging = False
                    SubStroking = False
                    SubHoldingEdge = True
                    EdgeTauntTimer.Stop()
                    If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                    DomChat = "#HoldTheEdge"
                    TypingDelay()

                    HoldEdgeTick = HoldEdgeChance

                    If FrmSettings.NBHoldTheEdgeMax.Value = 0 Then

                        If FrmSettings.domlevelNumBox.Value = 1 Then HoldEdgeTick = randomizer.Next(10, 31)
                        If FrmSettings.domlevelNumBox.Value = 2 Then HoldEdgeTick = randomizer.Next(15, 46)
                        If FrmSettings.domlevelNumBox.Value = 3 Then HoldEdgeTick = randomizer.Next(20, 61)
                        If FrmSettings.domlevelNumBox.Value = 4 Then HoldEdgeTick = randomizer.Next(45, 121)
                        If FrmSettings.domlevelNumBox.Value = 5 Then HoldEdgeTick = randomizer.Next(60, 301)

                        If FrmSettings.domlevelNumBox.Value >= 3 And FrmSettings.crazyCheckBox.Checked = True Then
                            TempVal = randomizer.Next(1, 101)
                            If TempVal < 21 Then HoldEdgeTick *= 2
                        End If

                    Else

                        Dim HoldEdgeMin As Integer = 30
                        If FrmSettings.NBHoldTheEdgeMax.Value < 31 Then HoldEdgeMin = FrmSettings.NBHoldTheEdgeMax.Value / 2
                        HoldEdgeTick = randomizer.Next(HoldEdgeMin, FrmSettings.NBHoldTheEdgeMax.Value + 1)
                        If HoldEdgeTick < 10 Then HoldEdgeTick = 10

                    End If

                    HoldEdgeTime = 0

                    HoldEdgeTimer.Start()
                    HoldEdgeTauntTimer.Start()
                    Return

                Else

                    If EdgeToRuin = True Or OrgasmRuined = True Then GoTo RuinedOrgasm
                    If OrgasmAllowed = True Then GoTo AllowedOrgasm

                    Debug.Print("Ruined Orgasm skipped")

                    If OrgasmDenied = True Then

                        If FrmSettings.CBDomDenialEnds.Checked = False Then

                            Dim RepeatChance As Integer = randomizer.Next(0, 101)

                            If RepeatChance < 10 * FrmSettings.domlevelNumBox.Value Then
                                SubEdging = False
                                SubStroking = False
                                EdgeTauntTimer.Stop()

                                Dim RepeatList As New List(Of String)

                                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Denial Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                                    RepeatList.Add(foundFile)
                                Next

                                If RepeatList.Count < 1 Then GoTo NoRepeatFiles


                                If FrmSettings.CBTeaseLengthDD.Checked = True Then
                                    If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                                    If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                                    If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                                    If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                                    If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                                Else
                                    TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                                End If
                                TeaseTimer.Start()

                                'ShowModule = True
                                StrokeTauntVal = -1
                                FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                                ScriptTick = 2
                                ScriptTimer.Start()
                                OrgasmDenied = False
                                OrgasmYesNo = False
                                Return
                            End If

                        End If


                    End If

NoRepeatFiles:

                    DomTypeCheck = True
                    OrgasmYesNo = False
                    SubEdging = False
                    SubStroking = False
                    EdgeTauntTimer.Stop()
                    DomChat = "#StopStrokingEdge"
                    TypingDelay()
                    Return

                End If

RuinedOrgasm:

                My.Settings.LastRuined = FormatDateTime(Now, DateFormat.ShortDate)
                My.Settings.Save()
                FrmSettings.LBLLastOrgasm.Text = My.Settings.LastRuined

                If FrmSettings.CBDomOrgasmEnds.Checked = False And OrgasmRuined = True Then

                    Dim RepeatChance As Integer = randomizer.Next(0, 101)

                    If RepeatChance < 8 * FrmSettings.domlevelNumBox.Value Then

                        SubEdging = False
                        SubStroking = False
                        EdgeToRuin = False
                        EdgeToRuinSecret = False
                        EdgeTauntTimer.Stop()

                        Dim RepeatList As New List(Of String)

                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Ruin Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                            RepeatList.Add(foundFile)
                        Next

                        If RepeatList.Count < 1 Then GoTo NoRepeatRFiles


                        If FrmSettings.CBTeaseLengthDD.Checked = True Then
                            If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                            If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                            If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                            If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                            If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                        Else
                            TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                        End If
                        TeaseTimer.Start()

                        'ShowModule = True
                        StrokeTauntVal = -1
                        FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                        ScriptTick = 2
                        ScriptTimer.Start()
                        OrgasmRuined = False
                        OrgasmYesNo = False
                        Return
                    End If

                End If



NoRepeatRFiles:


                DomTypeCheck = True
                SubEdging = False
                SubStroking = False
                EdgeToRuin = False
                EdgeToRuinSecret = False
                EdgeTauntTimer.Stop()
                OrgasmYesNo = False
                DomChat = "#RuinYourOrgasm"
                TypingDelay()
                Return

AllowedOrgasm:

                If My.Settings.OrgasmsLocked = True Then

                    If My.Settings.OrgasmsRemaining < 1 Then

                        Dim NoCumList As New List(Of String)

                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Out of Orgasms\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                            NoCumList.Add(foundFile)
                        Next

                        If NoCumList.Count < 1 Then GoTo NoNoCumFiles


                        SubEdging = False
                        SubStroking = False
                        EdgeTauntTimer.Stop()
                        OrgasmYesNo = False

                        'ShowModule = True
                        StrokeTauntVal = -1
                        FileText = NoCumList(randomizer.Next(0, NoCumList.Count))
                        ScriptTick = 2
                        ScriptTimer.Start()
                        Return
                    End If


                    My.Settings.OrgasmsRemaining -= 1

                    My.Settings.Save()

                End If

NoNoCumFiles:

                My.Settings.LastOrgasm = FormatDateTime(Now, DateFormat.ShortDate)
                My.Settings.Save()
                FrmSettings.LBLLastOrgasm.Text = My.Settings.LastOrgasm

                If FrmSettings.CBDomOrgasmEnds.Checked = False Then

                    Dim RepeatChance As Integer = randomizer.Next(0, 101)

                    If RepeatChance < 4 * FrmSettings.domlevelNumBox.Value Then
                        SubEdging = False
                        SubStroking = False
                        EdgeTauntTimer.Stop()

                        Dim RepeatList As New List(Of String)

                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Orgasm Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                            RepeatList.Add(foundFile)
                        Next

                        If RepeatList.Count < 1 Then GoTo NoRepeatOFiles


                        If FrmSettings.CBTeaseLengthDD.Checked = True Then
                            If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                            If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                            If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                            If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                            If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                        Else
                            TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                        End If
                        TeaseTimer.Start()

                        'ShowModule = True
                        StrokeTauntVal = -1
                        FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                        ScriptTick = 2
                        ScriptTimer.Start()
                        OrgasmAllowed = False
                        OrgasmYesNo = False
                        Return
                    End If

                End If



NoRepeatOFiles:








                DomTypeCheck = True
                SubEdging = False
                SubStroking = False
                'OrgasmAllowed = False
                EdgeTauntTimer.Stop()
                OrgasmYesNo = False
                DomChat = "#CumForMe"
                TypingDelay()
                Return


            End If



            If SubStroking = True Then

                FirstRound = False
                ShowModule = True
                StrokeTauntTimer.Stop()
                StrokeTimer.Stop()


                If BookmarkModule = True Then
                    DomTypeCheck = True
                    SubEdging = False
                    SubStroking = False
                    DomChat = "#StopStrokingEdge"
                    TypingDelay()

                    Do
                        Application.DoEvents()
                    Loop Until DomTypeCheck = False

                    BookmarkModule = False
                    FileText = BookmarkModuleFile
                    StrokeTauntVal = BookmarkModuleLine
                    RunFileText()
                    Return
                End If

                ShowModule = True

                Dim ModuleList As New List(Of String)
                ModuleList.Clear()

                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & _
                                                                                "\Modules\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                    Dim TempModule As String = foundFile
                    TempModule = TempModule.Replace(".txt", "")
                    Do Until Not TempModule.Contains("\")
                        TempModule = TempModule.Remove(0, 1)
                    Loop
                    For x As Integer = 0 To FrmSettings.CLBModuleList.Items.Count - 1
                        If FrmSettings.CLBModuleList.Items(x) = TempModule And FrmSettings.CLBModuleList.GetItemChecked(x) = True And foundFile.Contains("_EDGING") Then
                            ModuleList.Add(foundFile)
                        End If
                    Next
                Next


                If ModuleList.Count < 1 Then
                    FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Module_EDGING.txt"
                Else
                    FileText = ModuleList(randomizer.Next(0, ModuleList.Count))
                End If

                DomTask = DomTask.Replace("@Module", "")
                StrokeTauntVal = -1

                RunFileText()


            End If






            Return

        End If









DebugAwareness:





        DomResponse()


    End Sub

    Public Sub DomResponse()

        Debug.Print("DomResponse Called")

   
      
        

        'If BeforeTease = True And CBDebugAwareness.Checked = False Then Return

        Dim CheckResponse As String = UCase(ChatString)
        CheckResponse = CheckResponse.Replace(UCase(domName.Text), "")
        CheckResponse = CheckResponse.Replace(UCase(FrmSettings.TBHonorific.Text), "")
        CheckResponse = CheckResponse.Replace("!", "")
        CheckResponse = CheckResponse.Replace("?", "")
        CheckResponse = CheckResponse.Replace(".", "")
        CheckResponse = CheckResponse.Replace("*", "")
        CheckResponse = CheckResponse.Replace("  ", " ")

        If Not CheckResponse = UCase("please") Then CheckResponse = CheckResponse.Replace(UCase("please"), "")
        If Not CheckResponse = UCase("fucking") Then CheckResponse = CheckResponse.Replace(UCase("fucking"), "")
        If Not CheckResponse = UCase("fuckin") Then CheckResponse = CheckResponse.Replace(UCase("fuckin"), "")


        Try
            If CheckResponse.Substring(0, 1) = " " Then
                Do Until CheckResponse.Substring(0, 1) <> " "
                    CheckResponse = CheckResponse.Remove(0, 1)
                Loop
            End If
        Catch
        End Try
        Try
            If CheckResponse.Substring(CheckResponse.Length - 1) = " " Then
                Do Until CheckResponse.Substring(CheckResponse.Length - 1) <> " "
                    CheckResponse = CheckResponse.Remove(CheckResponse.Length - 1)
                Loop
            End If
        Catch
        End Try

        ResponseFile = ""


        If BeforeTease = False Then
            If UCase(CheckResponse).Contains(UCase("I need to cum")) Or UCase(CheckResponse).Contains(UCase("let me cum")) Or UCase(CheckResponse).Contains(UCase("I want to cum")) Then
                If TeaseTick > 0 Then
                    ResponseFile = (Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\BegToCum.txt")
                    If Chastity = False Then TeaseTick = TeaseTick / 2
                    Debug.Print("LastScriptCountdown = " & LastScriptCountdown)
                    If TeaseTick < 1 Then
                        StrokeTimer.Stop()
                        StrokeTauntTimer.Stop()
                        EdgeTauntTimer.Stop()
                        SubStroking = False
                        SubEdging = False
                        RunLastBegScript()
                        Return
                    Else
                        GoTo FoundResponse
                    End If
                End If
            End If
        End If


     
        CheckResponse = CheckResponse.Replace("  ", " ")


        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\", FileIO.SearchOption.SearchTopLevelOnly, "*KEY.txt")
            If Not foundFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\EdgeKEY.txt" Then
                Dim SysKeyReader As New StreamReader(foundFile)
                Dim SysKeyList As New List(Of String)
                SysKeyList.Clear()
                While SysKeyReader.Peek <> -1
                    SysKeyList.Add(SysKeyReader.ReadLine())
                End While
                SysKeyReader.Close()
                SysKeyReader.Dispose()

                DebugAwarenessLine = "Domme does not recognize this statement"

                For i As Integer = 0 To SysKeyList.Count - 1

                    SysKeyList(i) = SysKeyList(i).Replace(",", "")
                    SysKeyList(i) = SysKeyList(i).Replace("'", "")
                    SysKeyList(i) = SysKeyList(i).Replace("!", "")
                    SysKeyList(i) = SysKeyList(i).Replace("?", "")
                    SysKeyList(i) = SysKeyList(i).Replace(".", "")
                    SysKeyList(i) = SysKeyList(i).Replace("*", "")
                    SysKeyList(i) = SysKeyList(i).Replace("  ", " ")

                    If UCase(CheckResponse) = UCase(SysKeyList(i)) Then
                        ResponseFile = foundFile
                        ResponseFile = ResponseFile.Replace("KEY", "")

                        Dim AwarenessReader As New StreamReader(ResponseFile)
                        DebugAwarenessLine = AwarenessReader.ReadLine()
                        AwarenessReader.Close()
                        AwarenessReader.Dispose()
                        GoTo FoundResponse
                        Exit For
                    End If
                Next
            End If

        Next

        If frmApps.CBDebugAwareness.Checked = True Then GoTo DebugAwarenessStep2

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")


            Dim SplitReader As New StreamReader(foundFile)
            Dim SplitText As String = SplitReader.ReadLine()

            SplitReader.Close()
            SplitReader.Dispose()


            Dim SplitResponse As String() = SplitText.Split(New Char() {"]"c})
            SplitResponse(0) = SplitResponse(0).Replace("[", "")

            Do
                SplitResponse(0) = SplitResponse(0).Replace("  ", " ")
                SplitResponse(0) = SplitResponse(0).Replace(" ,", ",")
                SplitResponse(0) = SplitResponse(0).Replace(", ", ",")
                SplitResponse(0) = SplitResponse(0).Replace("'", "")
            Loop Until Not SplitResponse(0).Contains("  ") And Not SplitResponse(0).Contains(", ") And Not SplitResponse(0).Contains(" ,") And Not SplitResponse(0).Contains("'")

            Dim SplitParts As String() = SplitResponse(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1
                If UCase(CheckResponse) = UCase(SplitParts(i)) Then
                    ResponseFile = foundFile
                    GoTo FoundResponse
                    Exit For
                End If
            Next

        Next

DebugAwarenessStep2:

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\", FileIO.SearchOption.SearchTopLevelOnly, "*KEY.txt")
            If Not foundFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\EdgeKEY.txt" Then


                Dim SysKeyReader As New StreamReader(foundFile)
                Dim SysKeyList As New List(Of String)
                SysKeyList.Clear()
                While SysKeyReader.Peek <> -1
                    SysKeyList.Add(SysKeyReader.ReadLine())
                End While
                SysKeyReader.Close()
                SysKeyReader.Dispose()

                For i As Integer = 0 To SysKeyList.Count - 1

                    SysKeyList(i) = SysKeyList(i).Replace(",", "")
                    SysKeyList(i) = SysKeyList(i).Replace("'", "")
                    SysKeyList(i) = SysKeyList(i).Replace("!", "")
                    SysKeyList(i) = SysKeyList(i).Replace("?", "")
                    SysKeyList(i) = SysKeyList(i).Replace(".", "")
                    SysKeyList(i) = SysKeyList(i).Replace("*", "")
                    SysKeyList(i) = SysKeyList(i).Replace("  ", " ")

                    If UCase(CheckResponse).Contains(UCase(SysKeyList(i))) Then
                        ResponseFile = foundFile
                        ResponseFile = ResponseFile.Replace("KEY", "")

                        Dim AwarenessReader As New StreamReader(ResponseFile)
                        DebugAwarenessLine = AwarenessReader.ReadLine()
                        AwarenessReader.Close()
                        AwarenessReader.Dispose()
                        GoTo FoundResponse
                        Exit For
                    End If
                Next
            End If
        Next


        If frmApps.CBDebugAwareness.Checked = True Then GoTo FoundResponse

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")


            Dim SplitReader As New StreamReader(foundFile)
            Dim SplitText As String = SplitReader.ReadLine()

            SplitReader.Close()
            SplitReader.Dispose()


            Dim SplitResponse As String() = SplitText.Split(New Char() {"]"c})
            SplitResponse(0) = SplitResponse(0).Replace("[", "")

            Do
                SplitResponse(0) = SplitResponse(0).Replace("  ", " ")
                SplitResponse(0) = SplitResponse(0).Replace(" ,", ",")
                SplitResponse(0) = SplitResponse(0).Replace(", ", ",")
                SplitResponse(0) = SplitResponse(0).Replace("'", "")
            Loop Until Not SplitResponse(0).Contains("  ") And Not SplitResponse(0).Contains(", ") And Not SplitResponse(0).Contains(" ,") And Not SplitResponse(0).Contains("'")

            Dim SplitParts As String() = SplitResponse(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1
                If UCase(CheckResponse).Contains(UCase(SplitParts(i))) Then
                    ResponseFile = foundFile
                    GoTo FoundResponse
                    Exit For
                End If
            Next

        Next



        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")


            Dim SplitReader As New StreamReader(foundFile)
            Dim SplitText As String = SplitReader.ReadLine()

            SplitReader.Close()
            SplitReader.Dispose()


            Dim SplitResponse As String() = SplitText.Split(New Char() {"]"c})
            SplitResponse(0) = SplitResponse(0).Replace("[", "")

            Do
                SplitResponse(0) = SplitResponse(0).Replace("  ", " ")
                SplitResponse(0) = SplitResponse(0).Replace(" ,", ",")
                SplitResponse(0) = SplitResponse(0).Replace(", ", ",")
                SplitResponse(0) = SplitResponse(0).Replace("'", "")
            Loop Until Not SplitResponse(0).Contains("  ") And Not SplitResponse(0).Contains(", ") And Not SplitResponse(0).Contains(" ,") And Not SplitResponse(0).Contains("'")

            Dim SplitParts As String() = SplitResponse(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1

                Dim CheckResponseArray() As String = Split(UCase(SplitParts(i)))

                For j As Integer = 0 To CheckResponseArray.Length - 1
                    ResponseFile = foundFile
                    If Not UCase(CheckResponse).Contains(CheckResponseArray(j)) Then
                        ResponseFile = ""
                        Exit For
                    End If
                Next

                If ResponseFile <> "" Then GoTo FoundResponse

            Next

        Next



        If CBTCockFlag = True Or CBTBallsFlag = True Then
            Dim CBTStop As Integer = randomizer.Next(1, 101)
            If CBTStop < 30 Then
                CBTCockFlag = False
                CBTBallsFlag = False
                CBTBallsFirst = True
                CBTCockFirst = True
                RunFileText()
            End If
        End If

        If CBTCockFlag = True Then
            CBTCock()
        End If

        If CBTBallsFlag = True Then
            CBTBalls()
        End If

        Return



        CheckResponse = CheckResponse.Replace(" ", "")


FoundResponse:

        If frmApps.CBDebugAwareness.Checked = True Then
            If DebugAwarenessLine = "Domme does not recognize this statement" Then
                Chat = Chat & "<font color=""red"">" & DebugAwarenessLine & "<br>"
            Else
                Chat = Chat & "<font color=""green"">" & DebugAwarenessLine & "<br>"
            End If
            ChatText.DocumentText = Chat
            Return
        End If

        If StrokeTauntTimer.Enabled = True Then
            TempScriptCount = 0
            If FrmSettings.SliderSTF.Value = 1 Then StrokeTauntTick = randomizer.Next(120, 241)
            If FrmSettings.SliderSTF.Value = 2 Then StrokeTauntTick = randomizer.Next(75, 121)
            If FrmSettings.SliderSTF.Value = 3 Then StrokeTauntTick = randomizer.Next(45, 76)
            If FrmSettings.SliderSTF.Value = 4 Then StrokeTauntTick = randomizer.Next(25, 46)
            If FrmSettings.SliderSTF.Value = 5 Then StrokeTauntTick = randomizer.Next(15, 26)
        End If

        DomChat = ResponseClean(DomChat)

        If DomChat = "NULL" Then
            DomChat = ""
            Return
        End If

        TypingDelay()


    End Sub

    Public Function ResponseClean(ByVal CleanResponse As String) As String


        Dim DomResponse As New StreamReader(ResponseFile)
        Dim DRLines As New List(Of String)
        Dim DRLineTotal As Integer
        Dim SubState As String

        DRLineTotal = -1
        DRLines.Clear()

        Dim AddResponse As Boolean
        AddResponse = False

        If Chastity = True Then
            SubState = "Chastity"
            GoTo FoundState
        End If

        If BeforeTease = True Then
            SubState = "Before Tease"
            GoTo FoundState
        End If

        If FirstRound = True Then
            SubState = "First Round"
            GoTo FoundState
        End If

        If EndTease = True Then
            SubState = "After Tease"
            GoTo FoundState
        End If

        If CBTCockFlag = True Then
            SubState = "CBT Cock"
            GoTo FoundState
        End If

        If CBTBallsFlag = True Then
            SubState = "CBT Balls"
            GoTo FoundState
        End If

        If SubHoldingEdge = True Then
            SubState = "Sub Holding Edge"
            GoTo FoundState
        End If

        If SubEdging = True Then
            SubState = "Sub Edging"
            GoTo FoundState
        End If

        If SubStroking = True Then
            SubState = "Sub Stroking"
            GoTo FoundState
        End If

        SubState = "Not Stroking"

FoundState:


        If SubState = "Before Tease" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Before Tease]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Before Tease End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Before Tease]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If


        If SubState = "Chastity" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Chastity]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Chastity End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Chastity]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "First Round" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[First Round]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[First Round End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[First Round]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "Sub Stroking" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Stroking]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Stroking End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Stroking]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "Not Stroking" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Not Stroking]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Not Stroking End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Not Stroking]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "Sub Edging" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Edging]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Edging End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Edging]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "Sub Holding Edge" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[Holding The Edge]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[Holding The Edge End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[Holding The Edge]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "CBT Cock" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[CBT Cock]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[CBT Cock End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[CBT Cock]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "CBT Balls" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[CBT Balls]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[CBT Balls End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[CBT Balls]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        If SubState = "After Tease" Then

            While DomResponse.Peek <> -1
                DRLineTotal += 1
                DRLines.Add(DomResponse.ReadLine())
                If DRLines(DRLineTotal) = "[After Tease]" Then
                    AddResponse = True
                End If
                If DRLines(DRLineTotal) = "[After Tease End]" Then
                    AddResponse = False
                End If
                If AddResponse = False Or DRLines(DRLineTotal) = "[After Tease]" Then
                    DRLines.Remove(DRLines(DRLineTotal))
                    DRLineTotal -= 1
                End If
            End While
        End If

        DomResponse.Close()
        DomResponse.Dispose()

        ' ###########

        If DRLines.Count < 1 Then
            CleanResponse = "NULL"
            GoTo NullSkip
        End If

        DRLines = FilterList(DRLines)

        ResponseLine = randomizer.Next(0, DRLines.Count)
        CleanResponse = DRLines(ResponseLine)
        Responding = True

NullSkip:


        Return CleanResponse


    End Function

    Public Sub YesOrNoQuestions()

        Dim TempChatString As String

        TempChatString = UCase(ChatString)

        If CBT = True Then
            If InStr(UCase(TempChatString), UCase("done")) <> 0 Or InStr(UCase(TempChatString), UCase("finish")) <> 0 Then
                YesOrNo = False
                CBT = False
                Return
            Else
                DomChat = "Hurry up and tell me when you're done"
                TypingDelay()
                Return
            End If
        End If

        Dim dir As String

        dir = FileText

        Dim AcceptLine As Integer

        Dim ioFile As New StreamReader(dir)
        Dim lines As New List(Of String)
        Dim line As Integer
        While ioFile.Peek <> -1
            lines.Add(ioFile.ReadLine())
        End While

        ioFile.Close()
        ioFile.Dispose()

        line = StrokeTauntVal

        AcceptLine = 0

        Dim TempLineVal As Integer
        Do
            line += 1
            AcceptLine += 1
        Loop Until InStr(UCase(lines(line)), UCase("@AcceptAnswer")) <> 0 Or InStr(UCase(lines(line)), UCase("@DifferentAnswer")) <> 0


        TempLineVal = line

        line = StrokeTauntVal

        Dim CheckLines As String


        Do
            line += 1

            CheckLines = lines(line)


            CheckYes = False
            CheckNo = False

            If UCase(CheckLines).Contains(UCase("[yes]")) Then CheckYes = True
            If UCase(CheckLines).Contains(UCase("[no]")) Then CheckNo = True


            Dim Splits As String() = CheckLines.Split(New Char() {"]"c})
            Splits(0) = Splits(0).Replace("[", "")

            If CheckYes = True Then Splits(0) = FrmSettings.TBYes.Text
            If CheckNo = True Then Splits(0) = FrmSettings.TBNo.Text



            Do
                Splits(0) = Splits(0).Replace("  ", " ")
                Splits(0) = Splits(0).Replace(" ,", ",")
                Splits(0) = Splits(0).Replace(", ", ",")
                Splits(0) = Splits(0).Replace("'", "")
            Loop Until Not Splits(0).Contains("  ") And Not Splits(0).Contains(", ") And Not Splits(0).Contains(" ,") And Not Splits(0).Contains("'")

            Dim SplitParts As String() = Splits(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1
           
                If UCase(TempChatString) = (UCase(SplitParts(i))) Then

                    If CheckYes = True Or CheckNo = True Then
                        If FrmSettings.CBHonorificInclude.Checked = True Then
                            If Not UCase(TempChatString).Contains(UCase(FrmSettings.TBHonorific.Text)) Then
                                DomChat = SplitParts(i) & " what?"
                                If FrmSettings.LCaseCheckBox.Checked = False Then
                                    Dim DomU As String = UCase(DomChat.Substring(0, 1))
                                    DomChat = DomChat.Remove(0, 1)
                                    DomChat = DomU & DomChat
                                End If
                                TypingDelay()
                                Return
                            End If
                            If FrmSettings.CBHonorificCapitalized.Checked = True Then
                                If Not ChatString.Contains(FrmSettings.TBHonorific.Text) Then
                                    TempVal = randomizer.Next(1, 6)
                                    TempVal = 1
                                    If TempVal = 1 Then DomChat = "Your shift key had better be broken"
                                    If TempVal = 2 Then DomChat = "That's not the proper way to address me"
                                    If TempVal = 3 Then DomChat = "Check your typing and try again"
                                    If TempVal = 4 Then DomChat = "You better answer me again correctly"
                                    If TempVal = 5 Then DomChat = "Look at what's wrong with what you just typed and try again"
                                    TypingDelay()
                                    Return
                                End If
                            End If
                        End If
                    End If


                    DomChat = Splits(1)
                    GoTo FoundAnswer
                End If
            Next

        Loop Until InStr(UCase(lines(line)), UCase("@DifferentAnswer")) <> 0 Or InStr(UCase(lines(line)), UCase("@AcceptAnswer")) <> 0

        line = StrokeTauntVal

        Do
            line += 1

            CheckLines = lines(line)

            CheckYes = False
            CheckNo = False

            If UCase(CheckLines).Contains(UCase("[yes]")) Then CheckYes = True
            If UCase(CheckLines).Contains(UCase("[no]")) Then CheckNo = True


            Dim Splits As String() = CheckLines.Split(New Char() {"]"c})
            Splits(0) = Splits(0).Replace("[", "")

            If CheckYes = True Then Splits(0) = FrmSettings.TBYes.Text
            If CheckNo = True Then Splits(0) = FrmSettings.TBNo.Text

            Do
                Splits(0) = Splits(0).Replace("  ", " ")
                Splits(0) = Splits(0).Replace(" ,", ",")
                Splits(0) = Splits(0).Replace(", ", ",")
                Splits(0) = Splits(0).Replace("'", "")
            Loop Until Not Splits(0).Contains("  ") And Not Splits(0).Contains(", ") And Not Splits(0).Contains(" ,") And Not Splits(0).Contains("'")

            Dim SplitParts As String() = Splits(0).Split(New Char() {","c})

            For i As Integer = 0 To SplitParts.Length - 1
              

                If UCase(TempChatString).Contains(UCase(SplitParts(i))) Then

                    If CheckYes = True Or CheckNo = True Then
                        If FrmSettings.CBHonorificInclude.Checked = True Then
                            If Not UCase(TempChatString).Contains(UCase(FrmSettings.TBHonorific.Text)) Then
                                DomChat = SplitParts(i) & " what?"
                                If FrmSettings.LCaseCheckBox.Checked = False Then
                                    Dim DomU As String = UCase(DomChat.Substring(0, 1))
                                    DomChat = DomChat.Remove(0, 1)
                                    DomChat = DomU & DomChat
                                End If
                                TypingDelay()
                                Return
                            End If
                            If FrmSettings.CBHonorificCapitalized.Checked = True Then
                                If Not ChatString.Contains(FrmSettings.TBHonorific.Text) Then
                                    DomChat = "#CapitalizeHonorific"
                                    TypingDelay()
                                    Return
                                End If
                            End If
                        End If
                    End If

                    DomChat = Splits(1)
                    GoTo FoundAnswer
                End If
            Next

        Loop Until InStr(UCase(lines(line)), UCase("@DifferentAnswer")) <> 0 Or InStr(UCase(lines(line)), UCase("@AcceptAnswer")) <> 0

        GoTo NothingFound

FoundAnswer:

        If DomChat.Contains("@NullResponse") Then NullResponse = True
        If DomChat.Contains("@LoopAnswer") Then GoTo LoopAnswer

        YesOrNo = False
        YesOrNoLanguageCheck()

        If GotoFlag = False Then StrokeTauntVal = TempLineVal

        TypingDelay()

        Return


NothingFound:

        If InStr(UCase(lines(line)), UCase("DifferentAnswer")) <> 0 Then

DifferentAnswer:
            DomChat = lines(line)
            DomChat = DomChat.Replace("@DifferentAnswer ", "")

LoopAnswer:
            DomChat = DomChat.Replace("@LoopAnswer", "")
            ' CleanParse()
            TypingDelay()
            Return
        End If


        If InStr(UCase(lines(line)), UCase("AcceptAnswer")) <> 0 Then
AcceptAnswer:
            DomChat = lines(TempLineVal)
            ' TimedAnswerTimer.Stop()

            DomChat = DomChat.Replace("@AcceptAnswer ", "")
            ScriptTimer.Start()
            YesOrNo = False

            YesOrNoLanguageCheck()

            If GotoFlag = False Then
                StrokeTauntVal = TempLineVal

            End If
            TypingDelay()
            Return
        End If



    End Sub

    Public Sub YesOrNoLanguageCheck()


        If InStr(UCase(DomChat), UCase("@Goto")) <> 0 Then
            GetGotoChat()
        End If

    End Sub

    Public Sub GetGotoChat()

        GotoFlag = True

        DomTypeCheck = True

        'Debug.Print("GetGotoChat() Chat FileText = " & FileText)

        If InStr(UCase(DomChat), UCase("@Goto")) <> 0 Then

            DomTypeCheck = True
            DomChat = DomChat.Replace("@Goto", "")
            Dim R2 As RegularExpressions.Regex
            R2 = New RegularExpressions.Regex("\(([^\)]*)\)")
            FileGoto = R2.Match(DomChat).Value
            DomChat = DomChat.Replace(R2.Match(DomChat).Value(), "")


            'Debug.Print("GetGotoChat() Domchat R2 = " & FileGoto)

            If File.Exists(FileText) Then
                Dim ioFile2 As New StreamReader(FileText)
                Dim gotolines As New List(Of String)
                Dim gotoline As Integer
                While ioFile2.Peek <> -1
                    gotolines.Add(ioFile2.ReadLine())
                End While

                Do
                    gotoline += 1
                    'Debug.Print("GetGotoChat() gotoline = " & gotoline)
                    'Debug.Print("GetGotoChat() gotolines(gotoline) = " & (gotolines(gotoline)))
                Loop Until InStr(gotolines(gotoline), FileGoto) <> 0 And InStr(gotolines(gotoline), "@Goto") = 0

                'Debug.Print("GetGotoChat() Final gotolines(gotoline) = " & (gotolines(gotoline)))

                ioFile2.Close()
                ioFile2.Dispose()

                'If ShowThought = True Or ShowEdgeThought = True Then
                StrokeTauntVal = gotoline
                'ThoughtTauntVal = gotoline
                'Else
                '   If ShowModule = True Then
                'ModuleTauntVal = gotoline
                'Else
                '   StrokeTauntVal = gotoline
                'End If
                'End If



                'Debug.Print("GetGotoChat() StrokeTauntVal = " & StrokeTauntVal)


            End If

        End If


    End Sub


    Public Sub ScriptTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ScriptTimer.Tick
        'If DomTyping = True Then Return
        If ChatText.IsBusy Then Return

        If WaitTimer.Enabled = True Or DomTypeCheck = True Then Return

        'Debug.Print("ScriptTimer Substroking = " & SubStroking)
        'Debug.Print("ScriptTimer StrokePaceTimer = " & StrokePaceTimer.Enabled)

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If playingStatus() Then
            If ScriptTick < 4 Then Return
        End If

        If DomTypeCheck = False And YesOrNo = False And chatBox.Text = "" Then

            ScriptTick -= 1
            Debug.Print("ScriptTick = " & ScriptTick)
            If ScriptTick < 1 Then



                ScriptTick = randomizer.Next(5, 8)

                RunFileText()


            End If


        End If

    End Sub

    Public Sub CBTBalls()


        'Dim CBTReader As New StreamReader(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\CBT\CBT Balls.txt")
        'Dim CBTLines As New List(Of String)
        'Dim CBTLine As Integer
        'Dim CBTLineTotal As Integer

        'CBTLine = 0
        'CBTLineTotal = 0

        'While CBTReader.Peek <> -1
        'CBTLines.Add(CBTReader.ReadLine())
        'CBTLineTotal += 1
        'End While

        'CBTReader.Close()
        'CBTReader.Dispose()

        'CBTLine = randomizer.Next(0, CBTLineTotal)

        'DomTask = CBTLines(CBTLine)

        Dim BallReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\CBT\CBTBalls_First.txt")

        If CBTBallsFirst = False Then
            BallReader = New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\CBT\CBTBalls.txt")
        End If

        Dim BallList As New List(Of String)
        While BallReader.Peek <> -1
            BallList.Add(BallReader.ReadLine())
        End While
        BallReader.Close()
        BallReader.Dispose()

        BallList = FilterList(BallList)

        DomTask = BallList(randomizer.Next(0, BallList.Count))

        CBTBallsFirst = False

        TypingDelayGeneric()

    End Sub

    Public Sub CBTCock()

        'Dim CBTReader As New StreamReader(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\CBT\CBT Cock.txt")
        'Dim CBTLines As New List(Of String)
        'Dim CBTLine As Integer
        'Dim CBTLineTotal As Integer

        'CBTLine = 0
        'CBTLineTotal = 0

        'While CBTReader.Peek <> -1
        'CBTLines.Add(CBTReader.ReadLine())
        'CBTLineTotal += 1
        'End While

        'CBTReader.Close()
        'CBTReader.Dispose()

        'CBTLine = randomizer.Next(0, CBTLineTotal)

        'DomTask = CBTLines(CBTLine)

        Dim CockReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\CBT\CBTCock_First.txt")

        If CBTCockFirst = False Then
            CockReader = New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\CBT\CBTCock.txt")
        End If

        Dim CockList As New List(Of String)
        While CockReader.Peek <> -1
            CockList.Add(CockReader.ReadLine())
        End While
        CockReader.Close()
        CockReader.Dispose()

        CockList = FilterList(CockList)

        DomTask = CockList(randomizer.Next(0, CockList.Count))

        CBTBallsFirst = False

        TypingDelayGeneric()

    End Sub



    Public Sub RunFileText()




       

        Debug.Print("SaidHello = " & SaidHello)
        If SaidHello = False Then Return

        'Debug.Print("TeaseOver = " & TeaseOver)
        If TeaseOver = True Then Return

        'Debug.Print("CBTCockFlag = " & CBTCockFlag)
        'Debug.Print("CBTBallsFlag = " & CBTBallsFlag)
        If CBTCockFlag = True Or CBTBallsFlag = True Then Return

        'Debug.Print("WritingTaskFlag = " & WritingTaskFlag)
        If WritingTaskFlag = True Then Return

        'Debug.Print("TeaseVideo = " & TeaseVideo)
        If TeaseVideo = True Then Return

        If CensorshipGame = True Or RLGLGame = True Or AvoidTheEdgeStroking = True Or SubEdging = True Or SubHoldingEdge = True Then Return
        'If SearchImageBlog = True Then Return

        'Debug.Print("RunFileText " & StrokeTauntVal)

        StrokeTauntVal += 1


        'If ShowThought = True Or ShowEdgeThought = True Then
        'ThoughtTauntVal += 1
        'ScriptLineVal = ThoughtTauntVal
        'Else
        'If ShowModule = True Then
        ' ModuleTauntVal += 1
        'ScriptLineVal = ModuleTauntVal
        'Else
        'StrokeTauntVal += 1
        'ScriptLineVal = StrokeTauntVal
        'End If
        'End If

        HandleScripts()
    End Sub

    Public Sub HandleScripts()

        Debug.Print("Handlescripts Called")

        '  If ThoughtEnd = True Then
        'ScriptTimer.Stop()
        'ThoughtEnd = False
        'ShowThought = False
        'ShowEdgeThought = False

        'DelayFlag = True
        'DelayTick = randomizer.Next(30, 180)

        'DelayTimer.Start()

        'Do
        'Application.DoEvents()
        'Loop Until DelayFlag = False

        'StartStroking()
        'Return
        'End If

        ' ### Debug


        If ModuleEnd = True And AvoidTheEdgeGame = False Then
            Debug.Print("Module End Called?")
            ScriptTimer.Stop()
            ModuleEnd = False
            ShowModule = False

            DelayFlag = True
            DelayTick = randomizer.Next(3, 6)

            DelayTimer.Start()

            Do
                Application.DoEvents()
            Loop Until DelayFlag = False

            'LastScriptCountdown -= 1
            'Debug.Print("LastScriptCountdown = " & LastScriptCountdown)



            If TeaseTick < 1 Then
                RunLastScript()
            Else
                RunLinkScript()
            End If
            Return
        End If

        If StrokeTimer.Enabled = True Then Return

        'If ShowThought = False And ShowEdgeThought = False And ShowModule = False Then HandleScriptText = FileText
        'If ShowThought = True Then HandleScriptText = (Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\Thoughts\Thoughts.txt")
        'If ShowEdgeThought = True Then HandleScriptText = (Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\Thoughts\EdgeThoughts.txt")
        'If ShowModule = True Then HandleScriptText = ModText

        Debug.Print("CHeck")

        Debug.Print(FileText)

        'If File.Exists(HandleScriptText) Then
        If File.Exists(FileText) Then
            'Debug.Print(StrokeTauntVal)
            'Dim ioFile As New StreamReader(HandleScriptText)
            Dim ioFile As New StreamReader(FileText)
            Dim lines As New List(Of String)
            Dim rnd As New Random()
            Dim line As Integer

            While ioFile.Peek <> -1
                lines.Add(ioFile.ReadLine())
            End While

            'line = ScriptLineVal
            line = StrokeTauntVal


            Debug.Print("CHeck")

            If lines(line) = "@End" Then
                If LastScript = True Then
                    LastScript = False
                    EndTease = True
                End If
                If HypnoGen = True Then
                    If Induction = True Then
                        Induction = False
                        StrokeTauntVal = -1
                        FileText = TempHypno
                        ScriptTick = 1
                        ScriptTimer.Start()
                        Return
                    End If
                    HypnoGen = False
                    AFK = False
                    DomWMP.Ctlcontrols.stop()
                    frmApps.BTNHypnoGenStart.Text = "Guide Me!"
                End If
                'If AvoidTheEdgeStroking = True Then
                'DomWMP.Ctlcontrols.play()
                'End If
                ScriptTimer.Stop()
                Return
            End If

            If lines(line).Substring(0, 1) = "(" Then
                Do
                    line += 1
                    StrokeTauntVal += 1
                Loop Until lines(line).Substring(0, 1) <> "("
            End If

            If lines(line + 1).Substring(0, 1) = "[" Then
                YesOrNo = True
                ScriptTimer.Stop()
            End If

            If RunningScript = False And AvoidTheEdgeGame = False Then
                Debug.Print("Is this being called?")
                If lines(line + 1) = "@End" Then 'Or lines(line + 1) = "@Thought" Then
                    ' If ShowThought = True Or ShowEdgeThought = True Then ThoughtEnd = True
                    Debug.Print("And this??")
                    If ShowModule = True Then ModuleEnd = True
                End If
            End If

            Debug.Print("CHeck")





            DomTask = (lines(line).Trim)





            StringLength = 1



            DomTask = DomTask.Replace("#SubName", subName.Text)

            DomTask = DomTask.Replace("#VTLength", VTLength / 60)


            If InStr(DomTask, "@CockSizeSmall") <> 0 Then DivideText = True


            If DomTask.Contains("@SearchImageBlogAgain") Then

                SearchImageBlog = True
                GetBlogImage()

            End If


            If DomTask.Contains("@SearchImageBlog") And Not DomTask.Contains("@SearchImageBlogAgain") Then

                SearchImageBlog = True
                GetBlogImage()

            End If


            If InStr(UCase(DomTask), UCase("@Goto")) <> 0 And InStr(UCase(DomTask), UCase("@GotoDommeLevel")) = 0 And InStr(UCase(DomTask), UCase("@GotoDommeOrgasm")) = 0 And InStr(UCase(DomTask), UCase("@GotoDommeApathy")) = 0 Then
                GetGoto()
            End If

            'If DomTask.Contains("@Chance") Then

            'Dim ChanceTemp As String
            'Dim TSStartIndex As Integer
            'Dim TSEndIndex As Integer

            'TSStartIndex = DomTask.IndexOf("@Chance") + 7
            'TSEndIndex = DomTask.IndexOf("@Chance") + 9

            'ChanceTemp = DomTask.Substring(TSStartIndex, TSEndIndex - TSStartIndex).Trim

            '            Dim ChanceVal As Integer

            ' ChanceVal = Val(ChanceTemp)

            ' 'Debug.Print("Check Substring " & ChanceTemp & " , " & ChanceVal)
            ' 'Debug.Print("Check Substring " & DomTask.Substring("@Chance", 2))

            ' TempVal = randomizer.Next(1, 101)

            Debug.Print("TempVal = " & TempVal)
            'Debug.Print("ChanceVal = " & ChanceVal)

            'If TempVal <= ChanceVal Then

            ''Debug.Print("Goto should be called")

            'GetGoto()

            'End If

            ' 'Debug.Print("ChanceTemp DomTask = " & DomTask)

            'DomTask = DomTask.Replace("@Chance" & ChanceTemp, "")

            'End If




            '  If DomTask.Contains("@CheckFlag") Then

            ''Debug.Print("CheckFlagcalled")

            'Dim CheckFlag As String = DomTask

            'CheckFlag = DomTask.Split("@CheckFlag(")(1)
            'CheckFlag = CheckFlag.Split(")")(0)
            'CheckFlag = CheckFlag.Replace("CheckFlag(", "")

            'If File.Exists(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\System\Flags\" & CheckFlag & ".txt") Then
            ''Debug.Print("CheckFlag = " & CheckFlag)
            'SkipGotoLine = True
            'FileGoto = CheckFlag
            'GetGoto()
            'End If

            '    DomTask = DomTask.Replace("@CheckFlag", "")

            'End If


            If DomTask.Contains("@SetFlag") Then

                Debug.Print("SetFlag called")

                Dim WriteFlag As String = DomTask

                Dim WriteStart As Integer
                Dim WriteEnd As Integer


                WriteStart = WriteFlag.IndexOf("@SetFlag(") + 9
                WriteFlag = WriteFlag.Substring(WriteStart, WriteFlag.Length - WriteStart)


                'WriteFlag = WriteFlag.Substring(WriteStart, WriteFlag.Length - 1).Trim
                Debug.Print("WriteFlag = " & WriteFlag)

                'WriteFlag = DomTask.Split("@SetFlag(")(1)
                WriteFlag = WriteFlag.Split(")")(0)
                WriteFlag = WriteFlag.Replace("SetFlag(", "")

                Debug.Print("WriteFlag = " & WriteFlag)

                'If File.Exists(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Flags\" & WriteFlag) Then
                'Else
                Debug.Print("WriteFlag.Write Called")
                Dim FlagCreate As FileStream = File.Create(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Flags\" & WriteFlag)
                FlagCreate.Close()
                'End If

                DomTask = DomTask.Replace("@SetFlag", "")

            End If

            'If DomTask.Contains("@GotoDommeLevel") Then

            'GotoDommeLevel = True

            'Dim GotoDommeLevelString As String

            'GotoDommeLevelString = DomTask.Split("@GotoDommeLevel(")(1)
            'GotoDommeLevelString = GotoDommeLevelString.Split(")")(0)
            'GotoDommeLevelString = GotoDommeLevelString.Replace("GotoDommeLevel(", "")

            'FileGoto = "DommeLevel" & GotoDommeLevelString & FrmSettings.domlevelNumBox.Value

            'Debug.Print("GotoDommeLebel FileGoto = " & FileGoto)

            'DomTask = DomTask.Replace("GotoDommeLevel(" & GotoDommeLevelString & ")", "")

            'GetGoto()

            'End If

            ' If DomTask.Contains("@VTLength") Then

            'SkipGotoLine = True

            'If FrmSettings.ComboBoxVTLength.Text = "Never" Then FileGoto = "VTLengthNo"

            'If FrmSettings.ComboBoxVTLength.Text = "Always" Then FileGoto = "VTLengthYes"

            'If FrmSettings.ComboBoxVTLength.Text = "Sometimes" Then

            'TempVal = randomizer.Next(5, 21) * FrmSettings.domlevelNumBox.Value

            ' 5, 20   10, 40   15, 60   20, 80   25, 100
            'If TempVal < 10 * FrmSettings.domlevelNumBox.Value Then
            'FileGoto = "VTLengthYes"
            'Else
            '   FileGoto = "VTLengthNo"
            ' End If

            'End If



            'Debug.Print("VTLength = " & FileGoto)

            'DomTask = DomTask.Replace("@VTLength", "")

            'GetGoto()

            'End If






            ioFile.Close()
            ioFile.Dispose()


            ' If DomTask.Contains("@Module") Then
            'ShowModule = True
            'ScriptCount = 0
            'For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\Modules\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            ' ScriptCount += 1
            'Next
            'TempVal = randomizer.Next(1, ScriptCount + 1)
            'ScriptCount = 0
            'For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\Modules\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            'ScriptCount += 1
            'If TempVal = ScriptCount Then ModText = foundFile
            'Next
            'DomTask = DomTask.Replace("@Module", "")
            'ModuleTauntVal = -1
            'End If

            'Debug.Print("GotoFLag = " & GotoFlag)

            'If DomTask.Contains("@PlayVideoTeaseCensorshipSucks") Then
            'ScriptVideoTease = "Censorship Sucks"
            'ScriptVideoTeaseFlag = True
            ' RandomVideo()
            'DomTask = DomTask.Replace("@PlayVideoTeaseCensorshipSucks", "")
            ' End If



            'If DomTask.Contains("@PauseAvoidTheEdge") Then
            'domVLC.playlist.pause()
            'AvoidTheEdgeTick = 120 / TauntSlider.Value
            'AvoidTheEdgeStroking = False
            'DomTask = DomTask.Replace("@PauseAvoidTheEdge", "")
            'End If

            '    If DomChat.Contains("@PauseAvoidTheEdge") Then
            'domVLC.playlist.pause()
            'AvoidTheEdgeTick = 120 / TauntSlider.Value
            'AvoidTheEdgeStroking = False
            'DomChat = DomChat.Replace("@PauseAvoidTheEdge", "")
            'End If

            '    If DomTask.Contains("@PauseAvoidTheEdgeNoTaunts") Then
            'AvoidTheEdge.Stop()
            'DomTask = DomTask.Replace("@PauseAvoidTheEdgeNoTaunts", "")
            'End If

            'If DomTask.Contains("@CountdownAvoidTheEdge") Then
            'ScriptTimer.Stop()
            'AtECountdown = randomizer.Next(FrmSettings.NBAvoidTheEdgeMin.Value, FrmSettings.NBAvoidTheEdgeMax.Value + 1)
            'DomTask = DomTask.Replace("@CountdownAvoidTheEdge", "")
            'AvoidTheEdgeResume.Start()
            'End If

            '    If DomTask.Contains("@ResumeAvoidTheEdge") Then
            'DomTask = DomTask.Replace("@ResumeAvoidTheEdge", "")
            'FileGoto = "AvoidTheEdgeBegin"
            'SkipGotoLine = True
            'GetGoto()
            'domVLC.playlist.play()
            'End If

            If DomTask.Contains("@EmbedImage") Then

                'Dim EmbedImageFile As New StreamReader(Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\System\ImageURLs.txt")
                'Dim ImageLines As New List(Of String)
                'Dim ImageLine As Integer

                'ImageLine = -1

                'While EmbedImageFile.Peek <> -1
                '  ImageLine += 1
                '   ImageLines.Add(EmbedImageFile.ReadLine())
                'End While
                ''Debug.Print("ImageLine = " & ImageLine)
                'TempVal = randomizer.Next(0, ImageLine + 1)
                ''Debug.Print("TempVal = " & TempVal)

                'subAvatar.LoadFromUrl(ImageLines(TempVal))


                Dim EmbedImageDoc As New XmlDocument()

                EmbedImageDoc.Load("http://justblowjobgifs.tumblr.com/api/read")

                EmbedImageDoc.Save("G:\Temp\EmbedImage.xml")

                '   For Each XmlAttribute As XElement In EmbedImageDoc

                'If XmlAttribute.Attribute("type") = "photo" Then
                'MsgBox(XmlAttribute.Elements("photo-url").Value)
                'End If

                '    Next



                RunFileText()
                Return
            End If

            If DomTask.Contains("@ShowTaggedImage") Then JustShowedBlogImage = True

            If DomTask.Contains("@NullResponse") Then NullResponse = True

            If HypnoGen = True Then

                If frmApps.CBHypnoGenSlideshow.Checked = True Then

                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Boobs" Then DomTask = DomTask & " @ShowBoobsImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Butts" Then DomTask = DomTask & " @ShowButtImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Hardcore" Then DomTask = DomTask & " @ShowHardcoreImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Softcore" Then DomTask = DomTask & " @ShowSoftcoreImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Lesbian" Then DomTask = DomTask & " @ShowLesbianImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Blowjob" Then DomTask = DomTask & " @ShowBlowjobImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Femdom" Then DomTask = DomTask & " @ShowFemdomImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Lezdom" Then DomTask = DomTask & " @ShowLezdomImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Hentai" Then DomTask = DomTask & " @ShowHentaiImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Gay" Then DomTask = DomTask & " @ShowGayImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Maledom" Then DomTask = DomTask & " @ShowMaledomImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Captions" Then DomTask = DomTask & " @ShowCaptionsImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "General" Then DomTask = DomTask & " @ShowGeneralImage"
                    If frmApps.LBHypnoGenSlideshow.SelectedItem = "Tagged" Then DomTask = DomTask & " @ShowTaggedImage @Tag" & frmApps.TBHypnoGenImageTag.Text



                End If

            End If


            If DomTask <> "" Then
                TypingDelayGeneric()
            Else
                RunFileText()
            End If


        End If

    End Sub

    Public Sub GetGoto()

        GotoFlag = True
        'Debug.Print("DomTask = " & DomTask)
        DomTypeCheck = True

        'Debug.Print("SkipGotoLine = " & SkipGotoLine)

        If GotoDommeLevel = True Or SkipGotoLine = True Then GoTo SkipGotoSearch

        'If InStr(UCase(DomTask), UCase("@Goto")) <> 0 Then
        'Debug.Print("Goto called")
        DomTask = DomTask.Replace("@Goto", "")
        Dim R2 As RegularExpressions.Regex
        R2 = New RegularExpressions.Regex("\(([^\)]*)\)")
        FileGoto = R2.Match(DomTask).Value
        'Debug.Print("DomTask = " & DomTask)

        DomTask = DomTask.Replace(R2.Match(DomTask).Value(), "")
        'Debug.Print("DomTask = " & DomTask)


SkipGotoSearch:

        'Debug.Print("GetGoto() Domtask R2 = " & FileGoto)

        If File.Exists(FileText) Then
            Dim ioFile2 As New StreamReader(FileText)
            Dim gotolines As New List(Of String)
            Dim CountGotoLines As Integer

            CountGotoLines = 0

            While ioFile2.Peek <> -1
                gotolines.Add(ioFile2.ReadLine())
                CountGotoLines += 1
            End While



            Dim gotoline As Integer
            Do
                gotoline += 1
                If GotoDommeLevel = True And gotoline = CountGotoLines Then
                    FileGoto = "(DommeLevel)"
                    GoTo SkipGotoSearch
                End If
            Loop Until InStr(gotolines(gotoline), FileGoto) <> 0 And InStr(gotolines(gotoline), "@Goto") = 0 And InStr(gotolines(gotoline), "@CheckFlag") = 0 _
                And InStr(gotolines(gotoline), "@SetFlag") = 0 And InStr(gotolines(gotoline), "@Chance") = 0 And InStr(gotolines(gotoline), "@GotoDommeLevel") = 0 _
                And InStr(gotolines(gotoline), "Then(") = 0 'And InStr(gotolines(gotoline), "@GotoDommeApathy") = 0

            ioFile2.Close()
            ioFile2.Dispose()


            ' If ShowThought = True Or ShowEdgeThought = True Then
            StrokeTauntVal = gotoline
            '  ThoughtTauntVal = gotoline
            'Else
            '   If ShowModule = True Then
            'ModuleTauntVal = gotoline
            'Else
            '   StrokeTauntVal = gotoline
            'End If
            'End If

            'Debug.Print("GetGoto() Task GotoLine  = " & gotoline)
        End If
        ' End If


        GotoDommeLevel = False
        SkipGotoLine = False




    End Sub

    Public Sub TypingDelay()

        'Debug.Print("Typing Delay Called " & StrokeTauntVal)
        TypeDelay = StringLength
        If FrmSettings.typeinstantlyCheckBox.Checked = True Then TypeDelay = 0
        SendTimer.Start()


    End Sub

    Public Sub TypingDelayGeneric()
        'Debug.Print("Typing Delay Generic Called " & StrokeTauntVal)
        TypeDelay = StringLength
        If FrmSettings.typeinstantlyCheckBox.Checked = True Then TypeDelay = 0
        If HypnoGen = True And frmApps.CBHypnoGenNoText.Checked = True Then TypeDelay = 0
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        DomTyping = True
        Dim ShowPicture As Boolean = False

        ' Let the program know that the domme is currently typing
        DomTypeCheck = True

        If frmApps.CBHypnoGenNoText.Checked = True And HypnoGen = True Then NullResponse = True
        'Debug.Print("CBHypnoGenNoText.Enabled = " & CBHypnoGenNoText.Enabled)
        'Debug.Print("HypnoGen = " & HypnoGen)

        ' Debug.Print("TypeToggle = " & TypeToggle)
        'Debug.Print("TypeDelay = " & TypeDelay)


        ' Toggle switch to let the program know when to display "Domme is typing..." and when to remove it and display what she wrote
        If TypeToggle = 0 Then
            If TypeDelay > 0 Then
                TypeDelay -= 1
            Else
                Timer1.Stop()
                'Debug.Print("NullCommand DomTask = " & DomTask)
                Debug.Print("Nullresponse = " & NullResponse)
                If NullResponse = True Then GoTo NullResponse
                If NullResponse = False Then
                    IsTyping = True
                    ChatText.DocumentText = Chat & "<font color=""DimGray""><i>" & domName.Text & " is typing...</i></font>"
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                    ScrollChatDown()
                End If
                TypeToggle = 1
                StringLength = DomTask.Length
                If DivideText = True Then
                    StringLength /= 3
                    DivideText = False
                End If
                If RLGLGame = True Then StringLength = 0
                If FrmSettings.typeinstantlyCheckBox.Checked = True Then StringLength = 0
                If HypnoGen = True And frmApps.CBHypnoGenNoText.Checked = True Then StringLength = 0
                TypingDelayGeneric()
            End If

        Else

            If TypeDelay > 0 Then
                TypeDelay -= 1

            Else
                TypeToggle = 0
                Timer1.Stop()
                IsTyping = False

                PictureStrip.Items(0).Enabled = False
                PictureStrip.Items(1).Enabled = False
                PictureStrip.Items(2).Enabled = False
                PictureStrip.Items(3).Enabled = False

                ' If PreCleanString.Contains("#") Then GoTo PoundLoop

                ' DomTask = PreCleanString


                If DomTask.Contains("@ShowHardcoreImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowSoftcoreImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowLesbianImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowBlowjobImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowFemdomImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowLezdomImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowHentaiImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowGayImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowMaledomImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowCaptionsImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowGeneralImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowLocalImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@ShowBlogImage") Then JustShowedBlogImage = True
                If DomTask.Contains("@NewBlogImage") Then JustShowedBlogImage = True

                

                'Debug.Print("TeaseRadio = " & FrmSettings.teaseRadio.Checked)
                'Debug.Print("JustShowedBlogImage = " & JustShowedBlogImage)
                'Debug.Print("TeaseVideo  = " & TeaseVideo)
                'Debug.Print("DomTask = " & DomTask)
                'Debug.Print("NullResponse = " & NullResponse)
                'Debug.Print("SlideshowLoaded = " & SlideshowLoaded)
                'Debug.Print("SubStroking = " & SubStroking)
                'Debug.Print("SubEdging  = " & SubEdging)
                'Debug.Print("SubHoldingEdge = " & SubHoldingEdge)



                If FrmSettings.teaseRadio.Checked = True And JustShowedBlogImage = False And TeaseVideo = False And Not DomTask.Contains("@NewBlogImage") And NullResponse = False _
                    And SlideshowLoaded = True And Not DomTask.Contains("@ShowButtImage") And Not DomTask.Contains("@ShowBoobsImage") And LockImage = False Then
                    If SubStroking = False Or SubEdging = True Or SubHoldingEdge = True Then
                        ' Begin Next Button

                        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
TryNextWithTease:

                        Dim TeaseDirection As Integer = randomizer.Next(1, 101)

                        'Debug.Print("TeaseDirection = " & TeaseDirection)

                        If TeaseDirection > FrmSettings.NBNextImageChance.Value Then

                            FileCount -= 1
                            If FileCount < 0 Then
                                FileCount = 0
                            End If

                        Else


                            FileCount += 1
                            If FileCount > FileCountMax Then
                                FileCount = FileCountMax
                            End If

                        End If

                        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                        If _ImageFileNames(FileCount).Contains(".db") Then GoTo TryNextWithTease


                    End If
                    ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                    If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)


                    ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                    ShowPicture = True

                    ' End Next Button
                    'On Error GoTo TryNextWithTease
                    'On Error Resume Next
                    ' End Next Button
                End If



NullResponse:

                PreCleanString = DomTask
                CleanParse()
                DomTask = PreCleanString
                'SaveBlogImage.Text = ""

                Do
                    DomTask = PoundClean(DomTask)
                    DomTask = CommandClean(DomTask)

                    Dim AtArray() As String = Split(DomTask)
                    For i As Integer = 0 To AtArray.Length - 1
                        'If AtArray(i) = "" Then GoTo AtBreak
                        If AtArray(i) = "" Then GoTo AtNext
                        If AtArray(i).Contains("@") Then
                            AtArray(i) = AtArray(i).Replace(AtArray(i), "")
                        End If
AtNext:

                    Next

                    DomTask = Join(AtArray)

                    'AtBreak:

                    DomTask = PoundClean(DomTask)
                Loop Until Not DomTask.Contains("#") And Not DomTask.Contains("@")


            


                'Debug.Print("NullResponse = " & NullResponse)
                If frmApps.CBHypnoGenNoText.Checked = True And HypnoGen = True Then GoTo HypNoResponse
                If NullResponse = True Then GoTo NoResponse

                ' Dim AtArray() As String = Split(DomTask)
                ' For i As Integer = 0 To AtArray.Length - 1
                'If AtArray(i) = "" Then GoTo AtBreak
                'If AtArray(i) = "" Then GoTo AtNext
                ' If AtArray(i).Contains("@") Then
                'AtArray(i) = AtArray(i).Replace(AtArray(i), "")
                'End If
                'AtNext:

                ' Next

                'DomTask = Join(AtArray)

                'AtBreak:


                If DomTask.Contains("(") And DomTask.Contains(")") Then
                    Dim ParenReg As RegularExpressions.Regex
                    ParenReg = New RegularExpressions.Regex("\(([^\)]*)\)")
                    DomTask = DomTask.Replace(ParenReg.Match(DomTask).Value(), "")
                End If

                If FrmSettings.LCaseCheckBox.Checked = True Then DomTask = LCase(DomTask)
                If FrmSettings.CBMeMyMine.Checked = True Then
                    Dim MeArray() As String = Split(DomTask)
                    For i As Integer = MeArray.Length - 1 To 0 Step -1
                        If UCase(MeArray(i)) = "ME" Then MeArray(i) = "Me"
                        If UCase(MeArray(i)) = "MY" Then MeArray(i) = "My"
                        If UCase(MeArray(i)) = "MINE" Then MeArray(i) = "Mine"
                        If UCase(MeArray(i)) = "I" Then MeArray(i) = "I"
                        If UCase(MeArray(i)) = "I'D" Then MeArray(i) = "I'd"
                        If UCase(MeArray(i)) = "I'M" Then MeArray(i) = "I'm"
                        If UCase(MeArray(i)) = "I'LL" Then MeArray(i) = "I'll"
                        If UCase(MeArray(i)) = "YOU" Then MeArray(i) = "you"
                        If UCase(MeArray(i)) = "YOUR" Then MeArray(i) = "your"
                        If UCase(MeArray(i)) = "YOURS" Then MeArray(i) = "yours"
                        If UCase(MeArray(i)) = "YOU'RE" Then MeArray(i) = "you're"
                        If UCase(MeArray(i)) = "YOU'D" Then MeArray(i) = "you'd"
                        If UCase(MeArray(i)) = "YOU'LL" Then MeArray(i) = "you'll"
                    Next
                    DomTask = Join(MeArray)
                End If
                If FrmSettings.apostropheCheckBox.Checked = True Then DomTask = DomTask.Replace("'", "")
                If FrmSettings.commaCheckBox.Checked = True Then DomTask = DomTask.Replace(",", "")
                If FrmSettings.periodCheckBox.Checked = True Then DomTask = DomTask.Replace(".", "")

                Try
                    DomTask = DomTask.Replace("*", FrmSettings.domemoteComboBox.Text.Substring(0, 1))
                Catch
                End Try

                DomTask = DomTask.Replace(":d", ":D")
                DomTask = DomTask.Replace(": d", ": D")

                If NullResponse = False And DomTask <> "" Then

                    ' Add timestamps to domme response if the option is checked in the menu
                    If FrmSettings.timestampCheckBox.Checked = True Then
                        Chat = Chat & "<font face=""Cambria"" size=""2"" color=""DimGray"">" & (Date.Now.ToString("hh:mm tt ")) & "</font>"
                    End If



                    If SubWroteLast = False And FrmSettings.shownamesCheckBox.Checked = False Then

                        Chat = "<body style=""word-wrap:break-word;"">" & "<font face=""" & FrmSettings.FontComboBoxD.Text & """ size=""" & FrmSettings.NBFontSizeD.Value & """ color=""#000000"">" & Chat & DomTask & "<br></font></body>"
                        ChatText.DocumentText = Chat
                        While ChatText.ReadyState <> WebBrowserReadyState.Complete
                            Application.DoEvents()
                        End While
                        ScrollChatDown()

                    Else


                        Chat = "<body style=""word-wrap:break-word;"">" & Chat & "<font face=""Cambria"" size=""3"" font color=""" & _
                DomColor & """><b>" & domName.Text & ": </b></font><font face=""" & FrmSettings.FontComboBoxD.Text & """ size=""" & FrmSettings.NBFontSizeD.Value & """ color=""#000000"">" & DomTask & "<br></font></body>"

                        TypeToggle = 0
                        ChatText.DocumentText = Chat
                        While ChatText.ReadyState <> WebBrowserReadyState.Complete
                            Application.DoEvents()
                        End While
                        ScrollChatDown()

                    End If

                    If My.Settings.UI768 = True Then
                        If PNLMediaBar.Visible = True Then
                            ChatText.Location = New Point(0, 29)
                        Else
                            ChatText.Location = New Point(0, 0)
                        End If
                        ChatText.Width = 683
                    End If

                    If My.Settings.LargeUI = True Then
                        If PNLMediaBar.Visible = True Then
                            ChatText.Location = New Point(0, 29)
                        Else
                            ChatText.Location = New Point(0, 0)
                        End If
                        ChatText.Width = 1089
                    End If

                    If My.Settings.SmallUI = True Then
                        If PNLMediaBar.Visible = True Then
                            ChatText.Location = New Point(0, 29)
                        Else
                            ChatText.Location = New Point(0, 0)
                        End If
                        ChatText.Width = 839
                    End If

                    ScrollChatDown()

                    If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

                    ' Dsplay the next picture in the slideshow as the domme responds if "With Tease" radio button is checked



                    SubWroteLast = False

                End If


                If ShowPicture = True Then
                    Try
                        If Not mainPictureBox Is Nothing Then
                            mainPictureBox.Image.Dispose()
                            mainPictureBox.Image = Nothing
                            GC.Collect()
                        End If
                    Catch
                    End Try
                    Try
                        mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
                        ShowImageInfo()
                    Catch
                        ' GoTo TryNextWithTease
                    End Try
                    If FrmSettings.landscapeCheckBox.Checked = True Then
                        If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                            mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                        End If
                    Else
                        mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    End If

                    mainPictureBox.Refresh()
                    mainPictureBox.Invalidate()
                    ShowPicture = False
                End If

HypNoResponse:

                If FrmSettings.TTSCheckBox.Checked = True And FrmSettings.TTSComboBox.Text <> "No voices installed" Then

                    mciSendString("CLOSE Speech1", String.Empty, 0, 0)
                    mciSendString("CLOSE Echo1", String.Empty, 0, 0)

                    Dim SpeechDir As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Hypnotic Guide\TempWav.wav"
                    Dim Speech1 As String = "Speech1"
                    Dim Echo1 As String = "Echo1"

                    synth2.SelectVoice(FrmSettings.TTSComboBox.Text)
                    synth2.SetOutputToWaveFile(SpeechDir, New SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono))
                    synth2.Speak(DomTask)
                    synth2.SetOutputToNull()

                    SpeechDir = GetShortPathName(SpeechDir)

                    mciSendString("OPEN " & SpeechDir & " TYPE WAVEAUDIO ALIAS Speech1", String.Empty, 0, 0)
                    mciSendString("PLAY Speech1 FROM 0", String.Empty, 0, 0)


                    If frmApps.CBHypnoGenPhase.Checked And HypnoGen = True Then
                        Delay(0.4)
                        mciSendString("OPEN " & SpeechDir & " TYPE WAVEAUDIO ALIAS Echo1", String.Empty, 0, 0)
                        mciSendString("PLAY Echo1 FROM 0", String.Empty, 0, 0)
                    End If

                End If

NoResponse:

                If SubStroking = False Then
                    If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                    If FrmSettings.TBWebStop.Text <> "" Then
                        Try
                            FrmSettings.WebToy.Navigate(FrmSettings.TBWebStop.Text)
                        Catch
                        End Try
                    End If
                End If

                If RLGLGame = True And RedLight = False Then
                    If (DomWMP.playState = WMPLib.WMPPlayState.wmppsPaused) Then
                        DomWMP.Ctlcontrols.play()


                        AskedToSpeedUp = False
                        AskedToSlowDown = False
                        SubStroking = True
                        SubEdging = False
                        SubHoldingEdge = False
                        StopMetronome = False
                        StrokePace = randomizer.Next(3, 8) * 10
                        StrokePaceTimer.Interval = StrokePace
                        RLGLTauntTick = randomizer.Next(20, 31)
                        ' VideoTauntTick = randomizer.Next(20, 31)
                        RLGLTauntTimer.Start()

                    End If
                End If

                If RLGLGame = True And RedLight = True Then
                    If (DomWMP.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
                        DomWMP.Ctlcontrols.pause()
                        SubStroking = False
                        'VideoTauntTimer.Stop()
                    End If
                End If



                NullResponse = False
                DomTypeCheck = False
                DomTyping = False
                StringLength = 20

                If SubStroking = False Then StopMetronome = True
                'Debug.Print("End of DomTask #######################################################################################################################")
                'JustShowedBlogImage = False

                If TempScriptCount = 0 Then JustShowedBlogImage = False

                If CBTCockActive = True Then
                    CBTCockActive = False
                    CBTCock()
                End If

                If CBTBallsActive = True Then
                    CBTBallsActive = False
                    CBTBalls()
                End If

                If YesOrNo = False Then
                    ScriptTick = randomizer.Next(4, 9)
                    ScriptTimer.Start()
                End If

                GotoFlag = False


                If SubGaveUp = True Then

                    SubGaveUp = False

                    If TnASlides.Enabled = True Then TnASlides.Stop()


                    EdgeTauntTimer.Stop()
                    HoldEdgeTauntTimer.Stop()
                    StrokeTauntTimer.Stop()
                    ScriptTimer.Stop()
                    ModuleEnd = False
                    ShowModule = False

                    DelayFlag = True
                    DelayTick = randomizer.Next(3, 6)

                    DelayTimer.Start()

                    Do
                        Application.DoEvents()
                    Loop Until DelayFlag = False

                    LastScriptCountdown -= 1
                    'Debug.Print("LastScriptCountdown = " & LastScriptCountdown)

                    'FrmSettings.LBLOrgasmCountdown.Text = LastScriptCountdown

                    StrokeTauntVal = -1

                    If LastScriptCountdown < 1 Then
                        RunLastScript()
                    Else
                        RunLinkScript()
                    End If

                End If



            End If
        End If

    End Sub

    Private Function playingStatus() As Boolean

        Dim retval As Integer
        Dim returnData As String = Space(128)

        retVal = mciSendString("status Speech1 mode", returnData, 128, 0)

        If returnData.Substring(0, 7) = "playing" Then

            playingStatus = True

        Else

            playingStatus = False

        End If

    End Function

    Public Shared Function GetShortPathName(ByVal longPath As String) As String
        Const MaxPath As Int32 = 260
        Const SBStartSize As Int32 = MaxPath + 1
        Dim sb As New System.Text.StringBuilder(SBStartSize)
        Dim len As Int32 = GetShortPathName(longPath, sb, sb.Length - 1)
        Return sb.ToString()
    End Function

    <System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Ansi, EntryPoint:="GetShortPathNameA")> _
    Public Shared Function GetShortPathName(ByVal lpszLongPath As String, _
                                        <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)> ByVal lpszShortPath As System.Text.StringBuilder, _
                                        ByVal cchBuffer As Int32) As Int32
    End Function

    Private Sub SendTimer_Tick(sender As System.Object, e As System.EventArgs) Handles SendTimer.Tick

        If NullResponse = True Then GoTo NullResponseLine

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        ' Let the program know that the domme is currently typing
        DomTypeCheck = True

        ' Toggle switch to let the program know when to display "Domme is typing..." and when to remove it and display what she wrote
        If TypeToggle = 0 Then
            If TypeDelay > 0 Then
                TypeDelay -= 1
            Else
                SendTimer.Stop()
                IsTyping = True
                ChatText.DocumentText = Chat & "<font color=""DimGray""><i>" & domName.Text & " is typing...</i></font>"
                While ChatText.ReadyState <> WebBrowserReadyState.Complete
                    Application.DoEvents()
                End While
                ScrollChatDown()
                TypeToggle = 1
                StringLength = DomChat.Length
                If DivideText = True Then
                    StringLength /= 3
                    DivideText = False
                End If
                If FrmSettings.typeinstantlyCheckBox.Checked = True Then StringLength = 0
                TypingDelay()
            End If

        Else

            If TypeDelay > 0 Then
                TypeDelay -= 1

            Else
                TypeToggle = 0
                SendTimer.Stop()
                IsTyping = False

NullResponseLine:


                PictureStrip.Items(0).Enabled = False
                PictureStrip.Items(1).Enabled = False
                PictureStrip.Items(2).Enabled = False
                PictureStrip.Items(3).Enabled = False


                PreCleanString = DomChat

                CleanParse()


                DomChat = PreCleanString

                Do
                    DomChat = PoundClean(DomChat)
                    DomChat = CommandClean(DomChat)

                    Dim AtArray() As String = Split(DomChat)
                    For i As Integer = 0 To AtArray.Length - 1
                        'If AtArray(i) = "" Then GoTo AtBreak
                        If AtArray(i) = "" Then GoTo AtNext
                        If AtArray(i).Contains("@") Then
                            AtArray(i) = AtArray(i).Replace(AtArray(i), "")
                        End If
AtNext:

                    Next

                    DomChat = Join(AtArray)

                    'AtBreak:

                    DomChat = PoundClean(DomChat)
                Loop Until Not DomChat.Contains("#") And Not DomChat.Contains("@")

            

                '##############

                'SaveBlogImage.Text = ""

                '  Do
                'DomChat = PoundClean(DomChat)
                'DomChat = CommandClean(DomChat)
                'DomChat = PoundClean(DomChat)
                'Loop Until Not DomChat.Contains("#") ' And Not DomChat.Contains("@")

                '    Dim AtArray() As String = Split(DomChat)
                '   For i As Integer = 0 To AtArray.Length - 1
                'Debug.Print("DomChat AtArray(i) = " & AtArray(i))
                'If AtArray(i) = "" Then GoTo AtNext
                'If AtArray(i) = "" Then GoTo AtBreak
                'If AtArray(i).Contains("@") Then
                'AtArray(i) = AtArray(i).Replace(AtArray(i), "")
                '       End If
                'atNext:
                '  Next

                ' DomChat = Join(AtArray)

                'AtBreak:

                ' #######################

                If FrmSettings.LCaseCheckBox.Checked = True Then DomChat = LCase(DomChat)
                If FrmSettings.CBMeMyMine.Checked = True Then
                    Dim MeArray() As String = Split(DomChat)
                    For i As Integer = MeArray.Length - 1 To 0 Step -1
                        If UCase(MeArray(i)) = "ME" Then MeArray(i) = "Me"
                        If UCase(MeArray(i)) = "MY" Then MeArray(i) = "My"
                        If UCase(MeArray(i)) = "MINE" Then MeArray(i) = "Mine"
                        If UCase(MeArray(i)) = "I" Then MeArray(i) = "I"
                        If UCase(MeArray(i)) = "I'D" Then MeArray(i) = "I'd"
                        If UCase(MeArray(i)) = "I'M" Then MeArray(i) = "I'm"
                        If UCase(MeArray(i)) = "I'LL" Then MeArray(i) = "I'll"
                        If UCase(MeArray(i)) = "YOU" Then MeArray(i) = "you"
                        If UCase(MeArray(i)) = "YOUR" Then MeArray(i) = "your"
                        If UCase(MeArray(i)) = "YOURS" Then MeArray(i) = "yours"
                        If UCase(MeArray(i)) = "YOU'RE" Then MeArray(i) = "you're"
                        If UCase(MeArray(i)) = "YOU'D" Then MeArray(i) = "you'd"
                        If UCase(MeArray(i)) = "YOU'LL" Then MeArray(i) = "you'll"
                    Next
                    DomChat = Join(MeArray)
                End If
                If FrmSettings.apostropheCheckBox.Checked = True Then DomChat = DomChat.Replace("'", "")
                If FrmSettings.commaCheckBox.Checked = True Then DomChat = DomChat.Replace(",", "")
                If FrmSettings.periodCheckBox.Checked = True Then DomChat = DomChat.Replace(".", "")

                Try
                    DomChat = DomChat.Replace("*", FrmSettings.domemoteComboBox.Text.Substring(0, 1))
                Catch
                End Try

                DomChat = DomChat.Replace(":d", ":D")
                DomChat = DomChat.Replace(": d", ": D")


                If NullResponse = True Then GoTo NullResponseLine2

                ' Add timestamps to domme response if the option is checked in the menu
                If FrmSettings.timestampCheckBox.Checked = True Then
                    Chat = Chat & "<font face=""Cambria"" size=""2"" color=""DimGray"">" & (Date.Now.ToString("hh:mm tt ")) & "</font>"
                End If

                'Debug.Print("DomChat = " & DomChat)

                If SubWroteLast = False And FrmSettings.shownamesCheckBox.Checked = False Then

                    Chat = "<body style=""word-wrap:break-word;"">" & "<font face=""" & FrmSettings.FontComboBoxD.Text & """ size=""" & FrmSettings.NBFontSizeD.Value & """ color=""#000000"">" & Chat & DomChat & "<br></font></body>"
                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                    ScrollChatDown()

                Else


                    Chat = "<body style=""word-wrap:break-word;"">" & Chat & "<font face=""Cambria"" size=""3"" font color=""" & _
                DomColor & """><b>" & domName.Text & ": </b></font><font face=""" & FrmSettings.FontComboBoxD.Text & """ size=""" & FrmSettings.NBFontSizeD.Value & """ color=""#000000"">" & DomChat & "<br></font></body>"
                    TypeToggle = 0
                    ChatText.DocumentText = Chat
                    While ChatText.ReadyState <> WebBrowserReadyState.Complete
                        Application.DoEvents()
                    End While
                    ScrollChatDown()

                End If

                If My.Settings.UI768 = True Then
                    If PNLMediaBar.Visible = True Then
                        ChatText.Location = New Point(0, 29)
                    Else
                        ChatText.Location = New Point(0, 0)
                    End If
                    ChatText.Width = 683
                End If

                If My.Settings.LargeUI = True Then
                    If PNLMediaBar.Visible = True Then
                        ChatText.Location = New Point(0, 29)
                    Else
                        ChatText.Location = New Point(0, 0)
                    End If
                    ChatText.Width = 1089
                End If

                If My.Settings.SmallUI = True Then
                    If PNLMediaBar.Visible = True Then
                        ChatText.Location = New Point(0, 29)
                    Else
                        ChatText.Location = New Point(0, 0)
                    End If
                    ChatText.Width = 839
                End If

                ScrollChatDown()


                If FrmSettings.CBAutosaveChatlog.Checked = True Then My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Chatlogs\Autosave.html", ChatText.DocumentText, False)

                SubWroteLast = False



                If FrmSettings.TTSCheckBox.Checked = True And FrmSettings.TTSComboBox.Text <> "No voices installed" Then
                    synth.SelectVoice(FrmSettings.TTSComboBox.Text)
                    synth.Speak(DomChat)
                End If

NullResponseLine2:

                If SubStroking = False Then
                    If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                    If FrmSettings.TBWebStop.Text <> "" Then
                        Try
                            FrmSettings.WebToy.Navigate(FrmSettings.TBWebStop.Text)
                        Catch
                        End Try
                    End If
                End If

                NullResponse = False
                DomTypeCheck = False
                StringLength = 20

                If SubStroking = False Then StopMetronome = True

                If CBTCockActive = True Then CBTCockActive = False
                If CBTBallsActive = True Then CBTBallsActive = False



                If CBTCockFlag = True Or CBTBallsFlag = True Then
                    Dim CBTStop As Integer = randomizer.Next(1, 101)
                    'Debug.Print("CBTSTop = " & CBTStop)
                    If CBTStop < 30 Then
                        CBTCockFlag = False
                        CBTBallsFlag = False
                        CBTBallsFirst = True
                        CBTCockFirst = True
                    End If
                End If

                If CBTCockFlag = True Then
                    CBTCock()
                End If

                If CBTBallsFlag = True Then
                    CBTBalls()
                End If

                If YesOrNo = False And Responding = False Then
                    ScriptTick = randomizer.Next(4, 9)
                    ScriptTimer.Start()
                End If

                Responding = False

                If SubGaveUp = True Then

                    SubGaveUp = False

                    If TnASlides.Enabled = True Then TnASlides.Stop()


                    EdgeTauntTimer.Stop()
                    HoldEdgeTauntTimer.Stop()
                    StrokeTauntTimer.Stop()
                    ScriptTimer.Stop()
                    ModuleEnd = False
                    ShowModule = False

                    DelayFlag = True
                    DelayTick = randomizer.Next(3, 6)

                    DelayTimer.Start()

                    Do
                        Application.DoEvents()
                    Loop Until DelayFlag = False

                    LastScriptCountdown -= 1
                    'Debug.Print("LastScriptCountdown = " & LastScriptCountdown)

                    'FrmSettings.LBLOrgasmCountdown.Text = LastScriptCountdown

                    StrokeTauntVal = -1

                    If LastScriptCountdown < 1 Then
                        RunLastScript()
                    Else
                        RunLinkScript()
                    End If

                End If

            End If
        End If

    End Sub

    Public Sub CleanParse()

        'Debug.Print("CleanParse Called")

        Dim PetNameVal As Integer = randomizer.Next(1, 5)

        If PetNameVal = 1 Then PetName = FrmSettings.petnameBox3.Text
        If PetNameVal = 2 Then PetName = FrmSettings.petnameBox4.Text
        If PetNameVal = 3 Then PetName = FrmSettings.petnameBox5.Text
        If PetNameVal = 4 Then PetName = FrmSettings.petnameBox6.Text

        If DommeMood < FrmSettings.NBDomMoodMin.Value Then
            PetNameVal = randomizer.Next(1, 3)
            If PetNameVal = 1 Then PetName = " " & FrmSettings.petnameBox7.Text
            If PetNameVal = 2 Then PetName = " " & FrmSettings.petnameBox8.Text
        End If


        If DommeMood > FrmSettings.NBDomMoodMax.Value Then
            PetNameVal = randomizer.Next(1, 3)
            If PetNameVal = 1 Then PetName = " " & FrmSettings.petnameBox1.Text
            If PetNameVal = 2 Then PetName = " " & FrmSettings.petnameBox2.Text
        End If

        TempVal = randomizer.Next(1, 9)
        If TempVal > 6 Then PetName = subName.Text

        PreCleanString = PreCleanString.Replace("#SubName", subName.Text)
        PreCleanString = PreCleanString.Replace("#PetName", PetName)
        PreCleanString = PreCleanString.Replace("#PetName2", PetName2)

        If Hour(Date.Now) < 11 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "this morning")
        If Hour(Date.Now) < 12 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodMorningSub")
        If Hour(Date.Now) > 10 And Hour(Date.Now) < 18 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "today")
        If Hour(Date.Now) > 11 And Hour(Date.Now) < 18 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodAfternoonSub")
        If Hour(Date.Now) > 17 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "tonight")
        If Hour(Date.Now) > 17 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodEveningSub")

        If AssImage = True Then PreCleanString = PreCleanString.Replace("#TnAFastSlidesResult", "#BBnB_Ass")
        If BoobImage = True Then PreCleanString = PreCleanString.Replace("#TnAFastSlidesResult", "#BBnB_Boobs")


        '        If Hour(Date.Now) < 3 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "tonight")
        '       If Hour(Date.Now) < 3 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodEveningSub")
        '      If Hour(Date.Now) > 2 And Hour(Date.Now) < 11 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "this morning")
        '     If Hour(Date.Now) > 2 And Hour(Date.Now) < 12 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodMorningSub")
        '    If Hour(Date.Now) > 10 And Hour(Date.Now) < 18 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "today")
        '   If Hour(Date.Now) > 11 And Hour(Date.Now) < 18 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodAfternoonSub")
        '  If Hour(Date.Now) > 17 Then PreCleanString = PreCleanString.Replace("#GeneralTime", "tonight")
        ' If Hour(Date.Now) > 17 Then PreCleanString = PreCleanString.Replace("#GreetSub", "#GoodEveningSub")



        If PreCleanString.Contains("#RNDNumberLow") Then
            ' ### Number between 3-5 , 5-25
            TempVal = randomizer.Next(1, 6) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            If TempVal < 3 Then TempVal = 3
            PreCleanString = PreCleanString.Replace("#RNDNumberLow", TempVal)
        End If

        If PreCleanString.Contains("#RNDNumber") Then
            ' ### Number between 3-10 , 5-50
            TempVal = randomizer.Next(1, 11) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            If TempVal < 3 Then TempVal = 3
            PreCleanString = PreCleanString.Replace("#RNDNumber", TempVal)
        End If

        If PreCleanString.Contains("#RNDNumberHigh") Then
            ' ### Number between 5-25 , 25-100
            TempVal = randomizer.Next(5, 21) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            PreCleanString = PreCleanString.Replace("#RNDNumberHigh", TempVal)
        End If

        'If FrmSettings.dompersonalityComboBox.Text = "Total Brat" Then CleanArrayTotalBrat()




        If PreCleanString.Contains("#CockSize") Then
            PreCleanString = PreCleanString.Replace("#CockSize", FrmSettings.CockSizeNumBox.Value)
        End If

        If PreCleanString.Contains("@CockSizeSmall") Then
            If FrmSettings.CockSizeNumBox.Value < 6 Then
                StartIndex = PreCleanString.IndexOf("@CockSizeSmall") + 13
                EndIndex = PreCleanString.IndexOf("@CockSizeMedium", StartIndex)
                PreCleanString = PreCleanString.Substring(StartIndex, EndIndex - StartIndex).Trim
                PreCleanString = PreCleanString.Remove(0, 2)
            End If
            If FrmSettings.CockSizeNumBox.Value > 5 And FrmSettings.CockSizeNumBox.Value < 9 Then
                StartIndex = PreCleanString.IndexOf("@CockSizeMedium") + 14
                EndIndex = PreCleanString.IndexOf("@CockSizeLarge", StartIndex)
                PreCleanString = PreCleanString.Substring(StartIndex, EndIndex - StartIndex).Trim
                PreCleanString = PreCleanString.Remove(0, 2)
            End If
            If FrmSettings.CockSizeNumBox.Value > 8 Then
                StartIndex = PreCleanString.IndexOf("@CockSizeLarge") + 13
                EndIndex = PreCleanString.IndexOf("@CockSizeEnd", StartIndex)
                PreCleanString = PreCleanString.Substring(StartIndex, EndIndex - StartIndex).Trim
                PreCleanString = PreCleanString.Remove(0, 2)
            End If
        End If



    End Sub


#Region " Images "

    Private Sub browsefolderButton_Click(sender As System.Object, e As System.EventArgs) Handles browsefolderButton.Click

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            GetFolder = FolderBrowserDialog1.SelectedPath

            RecentSlideshows.Add(GetFolder)

            Do Until RecentSlideshows.Count < 11
                RecentSlideshows.Remove(RecentSlideshows(0))
            Loop

            'Debug.Print(RecentSlideshows(0))

            ImageFolderComboBox.Items.Clear()

            For Each comboitem As String In RecentSlideshows
                ImageFolderComboBox.Items.Add(comboitem)
            Next

            ImageFolderComboBox.Text = GetFolder

            My.Settings.RecentSlideshows.Add(GetFolder)

            My.Settings.RecentSlideshows.Clear()

            For i As Integer = 0 To RecentSlideshows.Count - 1
                My.Settings.RecentSlideshows.Add(RecentSlideshows(i))
            Next

            My.Settings.Save()

            SlideshowLoaded = True

            ' domVLC.playlist.pause()
            ' domVLC.Visible = False
            DomWMP.Visible = False
            DomWMP.Ctlcontrols.pause()
            mainPictureBox.Visible = True
            'programsettingsPanel.Visible = False
            FrmSettings.timedRadio.Enabled = True
            FrmSettings.teaseRadio.Enabled = True




            'imgfolderTextBox.Text = GetFolder

            FileCount = 0
            FileCountMax = -1
            _ImageFileNames.Clear()


            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            'Dim files As String() = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)

            Dim files As String()

            If FrmSettings.CBSlideshowSubDir.Checked = True Then
                files = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)
            Else
                files = Directory.GetFiles(GetFolder, "*.*")
            End If

            ' Dim files As String() = Directory.GetFiles(GetFolder, "*.*")
            Array.Sort(files)

            ' For Each fi As String In files
            'If supportedExtensions.Contains(Path.GetExtension(fi)) Then
            '_ImageFileNames.AddRange(files)
            'End If
            '   Next

            Dim TestCOUnt As Integer = 0
            For Each fi As String In files
                If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                    TestCOUnt += 1
                    'Debug.Print("fi = " & fi)
                    _ImageFileNames.Add(fi)
                End If
            Next

            ' If FrmSettings.CBSlideshowSubDir.Checked = True Then
            'FileCountMax = Directory.GetFiles(GetFolder, "*.jpg", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.png", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.gif", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg", SearchOption.AllDirectories).Count
            'Else
            '   FileCountMax = Directory.GetFiles(GetFolder, "*.jpg").Count
            '  FileCountMax += Directory.GetFiles(GetFolder, "*.png").Count
            ' FileCountMax += Directory.GetFiles(GetFolder, "*.gif").Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp").Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg").Count
            'End If

            FileCountMax = _ImageFileNames.Count - 1

            'Debug.Print("FileCOuntMax = " & FileCountMax)


            If FileCountMax < 0 Then
                MessageBox.Show(Me, "There are no images in the specified folder.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            ' Begin Next Button
            FileCount = 0
            If Not mainPictureBox Is Nothing Then
                Try
                    mainPictureBox.Image.Dispose()
                    mainPictureBox.Image = Nothing
                    GC.Collect()
                Catch
                End Try
            End If

            If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

            mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
            ShowImageInfo()

            If FrmSettings.landscapeCheckBox.Checked = True Then
                If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                    mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If


            mainPictureBox.Refresh()
            mainPictureBox.Invalidate()

            If FrmSettings.timedRadio.Checked = True Then
                SlideshowTimerTick = FrmSettings.slideshowNumBox.Value
                SlideshowTimer.Start()
            End If
            ' End Next Button
        End If

    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        ' Begin Next Button

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If

        If SlideshowLoaded = False Or TeaseVideo = True Then Return


TryNext:
        FileCount += 1
        'Debug.Print("Filecount = " & FileCount)
        'Debug.Print("FileCOuntMax = " & FileCountMax)
        If FileCount > FileCountMax Then
            FileCount = 0
        End If

        If File.Exists(_ImageFileNames(FileCount)) Then
        Else
            Return
        End If

        If _ImageFileNames(FileCount).Contains(".db") Then GoTo TryNext

        Try
            If Not mainPictureBox Is Nothing Then
                mainPictureBox.Image.Dispose()
                mainPictureBox.Image = Nothing
                GC.Collect()
            End If
        Catch
        End Try

        If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

        Try
            mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
            ShowImageInfo()
        Catch
            GoTo TryNext
        End Try


        If FrmSettings.landscapeCheckBox.Checked = True Then
            If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Else
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If


        mainPictureBox.Refresh()
        mainPictureBox.Invalidate()
        ' End Next Button
        'On Error GoTo TryNext
        'On Error Resume Next

    End Sub

    Private Sub Button10_Click_1(sender As System.Object, e As System.EventArgs) Handles previousButton.Click

        ' Begin Previous Button

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If


        If SlideshowLoaded = False Or TeaseVideo = True Then Return

TryPrevious:
        FileCount -= 1
        'Debug.Print("Filecount = " & FileCount)
        'Debug.Print("FileCOuntMax = " & FileCountMax)

        If FileCount < 0 Then
            FileCount = FileCountMax
        End If

        If _ImageFileNames(FileCount).Contains(".db") Then GoTo TryPrevious

        Try
            If Not mainPictureBox Is Nothing Then
                mainPictureBox.Image.Dispose()
                mainPictureBox.Image = Nothing
                GC.Collect()
            End If
        Catch
        End Try

        If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

        Try
            mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
            ShowImageInfo()
        Catch
            GoTo TryPrevious
        End Try

        If FrmSettings.landscapeCheckBox.Checked = True Then
            If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Else
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If

        mainPictureBox.Refresh()
        mainPictureBox.Invalidate()
        'On Error GoTo TryPrevious
        'On Error Resume Next
    End Sub






#End Region

#Region " VLC "

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles BTNLoadVideo.Click

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If

        If (OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK) Then

            DomWMP.Visible = True
            DomWMP.stretchToFit = True

            ' domVLC.Visible = True
            'SlideshowLoaded = False

            'programsettingsPanel.Visible = False
            mainPictureBox.Visible = False

            ' domVLC.playlist.items.clear()
            ' domVLC.playlist.add("file:///" & OpenFileDialog2.FileName & "")
            ' 'Debug.Print("ChosenVideo = " & OpenFileDialog2.FileName)
            ' domVLC.video.crop = domVLC.Width & ":" & domVLC.Height
            ' domVLC.playlist.play()
            ' If FrmSettings.VLCfillRadio.Checked = True Then
            'domVLC.video.crop = domVLC.Width & ":" & domVLC.Height
            'End If
            'If FrmSettings.VLC43Radio.Checked = True Then domVLC.video.crop = "4:3"
            'If FrmSettings.VLC1610Radio.Checked = True Then domVLC.video.crop = "16:10"
            ' If FrmSettings.VLC169Radio.Checked = True Then domVLC.video.crop = "16:9"

            DomWMP.URL = OpenFileDialog2.FileName
        End If
    End Sub



    Private Sub Button11_Click_2(sender As System.Object, e As System.EventArgs) Handles BTNVideoControls.Click

        'If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
        'MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
        'Return
        'End If

        'If domVLC.Visible = True Then

        'domVLC.playlist.stop()

        'End If

        If DomWMP.Height = SplitContainer1.Panel1.Height Then
            DomWMP.Height = SplitContainer1.Panel1.Height + 60
            BTNVideoControls.Text = "Show Video Controls"
        Else
            DomWMP.Height = SplitContainer1.Panel1.Height
            BTNVideoControls.Text = "Hide Video Controls"
        End If

        DomWMP.stretchToFit = True

    End Sub



#End Region


    Private Sub StrokeTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StrokeTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return


        If ChatText.IsBusy Then Return
        If DomTypeCheck = True And StrokeTick < 5 Then Return
        If chatBox.Text <> "" And StrokeTick < 5 Then Return


        StrokeTick -= 1
        Debug.Print("StrokeTick = " & StrokeTick)

        If StrokeTick < 4 And TempScriptCount > 0 Then StrokeTick += 1

        If StrokeTick = 0 Then

           
                'SubStroking = False

                FirstRound = False

                StrokeTimer.Stop()
            StrokeTauntTimer.Stop()

            'DomTask = "@NullResponse"
            'TypingDelayGeneric()

                If RunningScript = True Then
                    RunFileText()
                Else

                    ShowModule = True

                    Dim ModuleList As New List(Of String)
                    ModuleList.Clear()

                    Dim ChastityModuleCheck As String
                    If Chastity = True Then
                        AskedToSpeedUp = False
                        AskedToSlowDown = False
                        SubStroking = False
                        SubEdging = False
                        SubHoldingEdge = False
                        StrokeTimer.Stop()
                        StrokeTauntTimer.Stop()
                        EdgeTauntTimer.Stop()
                        HoldEdgeTauntTimer.Stop()
                        ChastityModuleCheck = "*_CHASTITY.txt"
                    Else
                        ChastityModuleCheck = "*.txt"
                    End If

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & _
                                                                                    "\Modules\", FileIO.SearchOption.SearchTopLevelOnly, ChastityModuleCheck)
                        Dim TempModule As String = foundFile
                        TempModule = TempModule.Replace(".txt", "")
                        Do Until Not TempModule.Contains("\")
                            TempModule = TempModule.Remove(0, 1)
                        Loop
                    For x As Integer = 0 To FrmSettings.CLBModuleList.Items.Count - 1
                        If Chastity = True Then
                            If FrmSettings.CLBModuleList.Items(x) = TempModule And FrmSettings.CLBModuleList.GetItemChecked(x) = True And Not foundFile.Contains("_EDGING") Then
                                ModuleList.Add(foundFile)
                            End If
                        Else
                            If FrmSettings.CLBModuleList.Items(x) = TempModule And FrmSettings.CLBModuleList.GetItemChecked(x) = True And Not foundFile.Contains("_EDGING") And Not foundFile.Contains("_CHASTITY") Then
                                ModuleList.Add(foundFile)
                            End If
                        End If

                    Next
                    Next

                    If ModuleList.Count < 1 Then
                        If Chastity = True Then
                            FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Module_CHASTITY.txt"
                        Else
                            FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Module.txt"
                        End If
                    Else
                        FileText = ModuleList(randomizer.Next(0, ModuleList.Count))
                    End If

                    DomTask = DomTask.Replace("@Module", "")
                    StrokeTauntVal = -1

                    If BookmarkModule = True Then
                        BookmarkModule = False
                        FileText = BookmarkModuleFile
                        StrokeTauntVal = BookmarkModuleLine
                    End If

                    RunFileText()

                End If


            End If









    End Sub

    Private Sub StrokeTauntTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StrokeTauntTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return


        If DomTyping = True And StrokeTauntTick < 4 Then Return

        If DomTypeCheck = False And YesOrNo = False And chatBox.Text = "" Then



            StrokeTauntTick -= 1

            Debug.Print("StrokeTauntTick = " & StrokeTauntTick)

            If StrokeTauntTick = 0 Then

                ' TauntText = Application.StartupPath & "\Scripts\" & dompersonalityComboBox.Text & "\StrokeTaunts.txt"

                If TempScriptCount = 0 Then



                    'Debug.Print("TempScriptCount = 0")

                    If FrmSettings.teaseRadio.Checked = True And JustShowedBlogImage = False And TeaseVideo = False And Not DomTask.Contains("@NewBlogImage") And SlideshowLoaded = True Then
                        'If FrmSettings.teaseRadio.Checked = True And JustShowedBlogImage = False And TeaseVideo = False And Not DomTask.Contains("@NewBlogImage") Then
TryNextWithTease:

                        Dim TeaseDirection As Integer = randomizer.Next(1, 101)

                        If TeaseDirection > FrmSettings.NBNextImageChance.Value Then

                            FileCount -= 1

                            If FileCount < 0 Then
                                FileCount = 0
                            End If

                        Else


                            FileCount += 1
                            If FileCount > FileCountMax Then
                                FileCount = FileCountMax
                            End If

                        End If

                        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                        If _ImageFileNames(FileCount).Contains(".db") Then GoTo TryNextWithTease

                        ' @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                        If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)



                    End If


                    'BlankLineLoop:

                    Dim TauntFile As String
                    TauntFile = "StrokeTaunts"
                    If Chastity = True Then TauntFile = "ChastityTaunts"
                    ' ### Debug
                    'TauntFile = "StrokeTaunts"

                    TauntTextCount = 0
                    ScriptCount = 0
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\", FileIO.SearchOption.SearchTopLevelOnly, TauntFile & "_*.txt")
                        ScriptCount += 1
                    Next

                    Dim TauntTempVal As Integer = randomizer.Next(1, 101)

                    If TauntTempVal < 45 Then
                        TauntTempVal = 1
                    Else
                        TauntTempVal = randomizer.Next(1, ScriptCount + 1)
                    End If

                    '### Debug
                    'TauntTempVal = 3


                    StrokeTauntCount = TauntTempVal



                    ScriptCount = 0
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\", FileIO.SearchOption.SearchTopLevelOnly, TauntFile & "_*.txt")
                        ScriptCount += 1
                        If TauntTempVal = ScriptCount Then TauntText = foundFile
                    Next
                    ScriptCount = TauntTempVal
                End If

                'Debug.Print("ScriptCount = " & ScriptCount)

                'Debug.Print("TempScriptCOunt = " & TempScriptCount)





                ' ##############################################################################################################






                If TempScriptCount = 0 Then

                    TauntTextTotal = 0

                    Dim ioFile2 As New StreamReader(TauntText)
                    TauntLines.Clear()
                    While ioFile2.Peek <> -1
                        TauntLines.Add(ioFile2.ReadLine())
                        TauntTextTotal += 1
                    End While
                    ioFile2.Close()
                    ioFile2.Dispose()
                    TauntTextTotal -= 1

                    StrokeFilter = True

                    TauntLines = FilterList(TauntLines)

                    StrokeFilter = False

                    TauntTextTotal = TauntLines.Count

                    'Debug.Print("TauntTextTotal = " & TauntTextTotal)


                End If




                '##############################################################################################################



                If TempScriptCount = 0 Then
                    'Debug.Print("Equal called")
                    TempScriptCount = ScriptCount
                    TauntTextTotal /= ScriptCount
                    TauntTextCount = randomizer.Next(0, TauntTextTotal) * ScriptCount
                Else
                    'Debug.Print("Not equal called")
                    TauntTextCount += 1
                End If

                TempScriptCount -= 1




                'Debug.Print("TauntTextCount = " & TauntTextCount)


                DomTask = TauntLines(TauntTextCount)

                If DomTask.Contains("@ShowTaggedImage") Then JustShowedBlogImage = True

                'If DomTask = "" Then GoTo BlankLineLoop

                If InStr(UCase(DomTask), UCase("@CBT")) <> 0 Then
                    CBTScript()
                Else
                    TypingDelayGeneric()
                End If



                If TempScriptCount = 0 Then
                    If FrmSettings.SliderSTF.Value = 1 Then StrokeTauntTick = randomizer.Next(120, 241)
                    If FrmSettings.SliderSTF.Value = 2 Then StrokeTauntTick = randomizer.Next(75, 121)
                    If FrmSettings.SliderSTF.Value = 3 Then StrokeTauntTick = randomizer.Next(45, 76)
                    If FrmSettings.SliderSTF.Value = 4 Then StrokeTauntTick = randomizer.Next(25, 46)
                    If FrmSettings.SliderSTF.Value = 5 Then StrokeTauntTick = randomizer.Next(15, 26)
                    'StrokeTauntTick = randomizer.Next(11, 21)
                Else
                    StrokeTauntTick = randomizer.Next(5, 9)
                End If






            End If

        End If



    End Sub

    Public Sub CBTScript()

        Dim CBTAmount As Integer

        CBT = True
        YesOrNo = True
        Dim CBTCount As Integer

        Dim ioFile3 As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\CBT\CBT.txt")
        Dim lines As New List(Of String)
        While ioFile3.Peek <> -1
            lines.Add(ioFile3.ReadLine())
            CBTCount += 1
        End While

        CBTCount = randomizer.Next(0, CBTCount)

        DomTask = lines(CBTCount)

        CBTAmount = randomizer.Next(1, 6) * 2 * FrmSettings.domlevelNumBox.Value
        DomTask = DomTask.Replace("#CBTAmount", CBTAmount)

        TypingDelayGeneric()


        ioFile3.Close()
        ioFile3.Dispose()



    End Sub



    Private Sub DelayTimer_Tick(sender As System.Object, e As System.EventArgs) Handles DelayTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DelayTick < 10 And chatBox.Text <> "" Then Return
        If DelayTick < 3 And DomTypeCheck = True Then Return

        DelayTick -= 1

        If DelayTick < 1 Then
            DelayTimer.Stop()
            DelayFlag = False
        End If


    End Sub

   

    Public Sub RandomVideo()

        'SlideshowLoaded = False
        DommeVideo = False

        Dim random As Random = New Random()
        Dim RandomVideo As String
        Dim TotalFiles As IEnumerable(Of String)
        Dim ArrayCycle As New Integer

        Dim mediaAccess As IMediaAccess = ServiceProvider.Instance.GetService(Of IMediaAccess)

        TotalFiles = mediaAccess.Folders(VideoHardCore).Files
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoSoftCore).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoLesbian).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoBlowjob).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoFemdom).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoFemsub).Files)

        If NoSpecialVideo = True Then GoTo SkipSpecial

        If ScriptVideoTeaseFlag = True Then
            If ScriptVideoTease = "Censorship Sucks" Or ScriptVideoTease = "Avoid The Edge" Or ScriptVideoTease = "RLGL" Then GoTo SkipSpecial
        End If

        If RandomizerVideo = True Then GoTo SkipSpecial

        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoJOI).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoCH).Files)


SkipSpecial:

        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoGeneral).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoHardCoreD).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoSoftCoreD).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoLesbianD).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoBlowjobD).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoFemdomD).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoFemsubD).Files)

        If NoSpecialVideo = True Then GoTo SkipSpecialD
        If ScriptVideoTeaseFlag = True Then
            If ScriptVideoTease = "Censorship Sucks" Or ScriptVideoTease = "Avoid The Edge" Or ScriptVideoTease = "RLGL" Then GoTo SkipSpecialD
        End If

        If RandomizerVideo = True Then GoTo SkipSpecialD

        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoJOID).Files)
        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoCHD).Files)


SkipSpecialD:

        TotalFiles = TotalFiles.Concat(mediaAccess.Folders(VideoGeneralD).Files)

        Dim totalFilesArray() As String = TotalFiles.ToArray()

        If totalFilesArray.Length = 0 Then
            NoVideo = True
            Return
        End If

        If VideoCheck = True Then Return

GetAnotherRandomVideo:



        RandomVideo = totalFilesArray(random.Next(0, totalFilesArray.Length - 1))

        If RandomVideo = "" Then GoTo GetAnotherRandomVideo


        If FrmSettings.CBVideoHardcore.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoHardCore.Text) <> 0 Then VideoType = "Hardcore"
        If FrmSettings.CBVideoSoftCore.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoSoftCore.Text) <> 0 Then VideoType = "Softcore"
        If FrmSettings.CBVideoLesbian.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoLesbian.Text) <> 0 Then VideoType = "Lesbian"
        If FrmSettings.CBVideoBlowjob.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoBlowjob.Text) <> 0 Then VideoType = "Blowjob"
        If FrmSettings.CBVideoFemdom.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoFemdom.Text) <> 0 Then VideoType = "Femdom"
        If FrmSettings.CBVideoFemsub.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoFemsub.Text) <> 0 Then VideoType = "Femsub"
        If FrmSettings.CBVideoJOI.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoJOI.Text) <> 0 Then VideoType = "JOI"
        If FrmSettings.CBVideoCH.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoCH.Text) <> 0 Then VideoType = "CH"
        If FrmSettings.CBVideoGeneral.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoGeneral.Text) <> 0 Then VideoType = "General"


        If FrmSettings.CBVideoHardcoreD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoHardCoreD.Text) <> 0 Then
            VideoType = "HardcoreD"
            DommeVideo = True
        End If
        If FrmSettings.CBVideoSoftCoreD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoSoftCoreD.Text) <> 0 Then
            VideoType = "SoftcoreD"
            DommeVideo = True
        End If
        If FrmSettings.CBVideoLesbianD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoLesbianD.Text) <> 0 Then
            VideoType = "LesbianD"
            DommeVideo = True
        End If

        If FrmSettings.CBVideoBlowjobD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoBlowjobD.Text) <> 0 Then
            VideoType = "BlowjobD"
            DommeVideo = True
        End If
        If FrmSettings.CBVideoFemdomD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoFemdomD.Text) <> 0 Then
            VideoType = "FemdomD"
            DommeVideo = True
        End If
        If FrmSettings.CBVideoFemsubD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoFemsubD.Text) <> 0 Then
            VideoType = "FemsubD"
            DommeVideo = True
        End If

        If FrmSettings.CBVideoJOID.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoJOID.Text) <> 0 Then
            VideoType = "JOID"
            DommeVideo = True
        End If

        If FrmSettings.CBVideoCHD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoCHD.Text) <> 0 Then
            VideoType = "CHD"
            DommeVideo = True
        End If

        If FrmSettings.CBVideoGeneralD.Checked = True And InStr(RandomVideo, FrmSettings.LblVideoGeneralD.Text) <> 0 Then
            VideoType = "GeneralD"
            DommeVideo = True
        End If


        'Debug.Print("VideoType = " & VideoType)

        '        domVLC.Visible = True
        DomWMP.Visible = True
        DomWMP.stretchToFit = True

        ' programsettingsPanel.Visible = False
        mainPictureBox.Visible = False
        ' domVLC.playlist.items.clear()
        ' domVLC.playlist.add("file:///" & RandomVideo & "")
        ' 'Debug.Print("randomVideo = " & RandomVideo)
        ' domVLC.video.crop = domVLC.Width & ":" & domVLC.Height
        ' domVLC.playlist.play()
        'If FrmSettings.VLCfillRadio.Checked = True Then
        ' domVLC.video.crop = domVLC.Width & ":" & domVLC.Height
        'End If
        'If FrmSettings.VLC43Radio.Checked = True Then domVLC.video.crop = "4:3"
        'If FrmSettings.VLC1610Radio.Checked = True Then domVLC.video.crop = "16:10"
        'If FrmSettings.VLC169Radio.Checked = True Then domVLC.video.crop = "16:9"

        DomWMP.URL = RandomVideo



    End Sub

    Private Sub VideoTotal(ByVal videoType As Guid, ByVal label As Label)
        Dim mediaAccess As IMediaAccess = ServiceProvider.Instance.GetService(Of IMediaAccess)
        Dim TotalFiles As Integer = mediaAccess.Folders(videoType).Files.Count()
        label.Text = TotalFiles
        RefreshVideoTotal += TotalFiles
    End Sub

    Public Sub HardCoreVideoTotal()
        VideoTotal(VideoHardCore, FrmSettings.LblVideoHardCoreTotal)
    End Sub

    Public Sub SoftcoreVideoTotal()
        VideoTotal(VideoSoftCore, FrmSettings.LblVideoSoftCoreTotal)
    End Sub

    Public Sub LesbianVideoTotal()
        VideoTotal(VideoLesbian, FrmSettings.LblVideoLesbianTotal)
    End Sub

    Public Sub BlowjobVideoTotal()
        VideoTotal(VideoBlowjob, FrmSettings.LblVideoBlowjobTotal)
    End Sub

    Public Sub FemdomVideoTotal()
        VideoTotal(VideoFemdom, FrmSettings.LblVideoFemdomTotal)
    End Sub

    Public Sub FemsubVideoTotal()
        VideoTotal(VideoFemsub, FrmSettings.LblVideoFemsubTotal)
    End Sub

    Public Sub JOIVideoTotal()
        VideoTotal(VideoJOI, FrmSettings.LblVideoJOITotal)
    End Sub

    Public Sub CHVideoTotal()
        VideoTotal(VideoCH, FrmSettings.LblVideoCHTotal)
    End Sub

    Public Sub GeneralVideoTotal()
        VideoTotal(VideoGeneral, FrmSettings.LblVideoGeneralTotal)
    End Sub


    Public Sub HardcoreDVideoTotal()
        VideoTotal(VideoHardCoreD, FrmSettings.LblVideoHardCoreTotalD)
    End Sub


    Public Sub SoftcoreDVideoTotal()
        VideoTotal(VideoSoftCoreD, FrmSettings.LblVideoSoftCoreTotalD)
    End Sub


    Public Sub LesbianDVideoTotal()
        VideoTotal(VideoLesbianD, FrmSettings.LblVideoLesbianTotalD)
    End Sub


    Public Sub BlowjobDVideoTotal()
        VideoTotal(VideoBlowjobD, FrmSettings.LblVideoBlowjobTotalD)
    End Sub

    Public Sub FemdomDVideoTotal()
        VideoTotal(VideoFemdomD, FrmSettings.LblVideoFemdomTotalD)
    End Sub


    Public Sub FemsubDVideoTotal()
        VideoTotal(VideoFemsubD, FrmSettings.LblVideoFemsubTotalD)
    End Sub


    Public Sub JOIDVideoTotal()
        VideoTotal(VideoJOID, FrmSettings.LblVideoJOITotalD)
    End Sub


    Public Sub CHDVideoTotal()
        VideoTotal(VideoCHD, FrmSettings.LblVideoCHTotalD)
    End Sub


    Public Sub GeneralDVideoTotal()
        VideoTotal(VideoGeneralD, FrmSettings.LblVideoGeneralTotalD)
    End Sub


    Private Sub SettingsButton_Click(sender As System.Object, e As System.EventArgs) Handles SettingsButton.Click
        If FrmSettings.Visible = True Then
            FrmSettings.Visible = False
            SettingsButton.Text = "Open Settings Menu"
        Else
            FrmSettings.Visible = True
            SettingsButton.Text = "Close Settings Menu"
        End If
    End Sub



    Public Sub CensorshipTimer_Tick(sender As System.Object, e As System.EventArgs) Handles CensorshipTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        CensorshipTimerTick -= 1
        If CensorshipTimerTick < 1 Then CensorshipTimerTick = 0
        'Debug.Print("CensorshipTimerTick = " & CensorshipTimerTick)

        If DomTypeCheck = True Then Return

        CensorshipTick -= 1


        If CensorshipTick = 0 Then


            Dim CensorLineTemp As Integer = randomizer.Next(1, 101)


            Dim CensorVideo As String

            If FrmSettings.CBCensorConstant.Checked = True Then GoTo CensorConstant

            If CensorshipBar.Visible = True Then
                CensorshipBar.Visible = False
                CensorshipTick = randomizer.Next(FrmSettings.NBCensorHideMin.Value, FrmSettings.NBCensorHideMax.Value + 1)

                If CensorLineTemp > FrmSettings.TauntSlider.Value * 5 Then
                    Return
                End If

                CensorVideo = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Censorship Sucks\CensorBarOff.txt"

            Else

CensorConstant:

                Dim CensorshipBarX As Integer
                Dim CensorshipBarY As Integer

                CensorshipBarX = randomizer.Next(50, DomWMP.Width / 3)
                CensorshipBarY = randomizer.Next(55, DomWMP.Height / 2)
                CensorshipBar.Location = New Point(CensorshipBarX, CensorshipBarY)

                CensorshipBar.Visible = False
                CensorshipBar.Visible = True

                CensorshipTick = randomizer.Next(FrmSettings.NBCensorShowMin.Value, FrmSettings.NBCensorShowMax.Value + 1)

                If CensorLineTemp > FrmSettings.TauntSlider.Value * 5 Then
                    Return
                End If

                CensorVideo = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Censorship Sucks\CensorBarOn.txt"

            End If

            Dim ioFile As New StreamReader(CensorVideo)
            Dim lines As New List(Of String)
            While ioFile.Peek <> -1
                lines.Add(ioFile.ReadLine())
            End While

            Dim CensorLine As Integer


            lines = FilterList(lines)

            If lines.Count < 1 Then Return

            CensorLine = randomizer.Next(0, lines.Count)

            DomTask = lines(CensorLine)

            TypingDelayGeneric()

        End If

    End Sub


    Public Sub RLGLTimer_Tick(sender As System.Object, e As System.EventArgs) Handles RLGLTimer.Tick

        ' DEBUG CHANGE THIS ONCE WMP IS IMPLEMENTED

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return


        If RLGLTick < 4 And chatBox.Text <> "" Then Return
        If RLGLTick < 4 And DomTypeCheck = True Then Return

        If RLGLGame = True Then RLGLTick -= 1

        If RLGLTick < 1 Then

            If RedLight = False Then

                RLGLTauntTimer.Stop()

                RedLight = True

                Dim RedReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Red Light Green Light\Red Light.txt")
                Dim RedList As New List(Of String)

                While RedReader.Peek <> -1
                    RedList.Add(RedReader.ReadLine())
                End While

                RedReader.Close()
                RedReader.Dispose()

                RedList = FilterList(RedList)

                DomTask = RedList(randomizer.Next(0, RedList.Count))
                TypingDelayGeneric()

                'DomWMP.Ctlcontrols.pause()



                RLGLTick = randomizer.Next(FrmSettings.NBRedLightMin.Value, FrmSettings.NBRedLightMax.Value + 1)

            Else



                RedLight = False


                Dim GreenReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Red Light Green Light\Green Light.txt")
                Dim GreenList As New List(Of String)

                While GreenReader.Peek <> -1
                    GreenList.Add(GreenReader.ReadLine())
                End While

                GreenReader.Close()
                GreenReader.Dispose()

                GreenList = FilterList(GreenList)

                DomTask = GreenList(randomizer.Next(0, GreenList.Count))
                TypingDelayGeneric()

                'DomWMP.Ctlcontrols.play()



                RLGLTick = randomizer.Next(FrmSettings.NBGreenLightMin.Value, FrmSettings.NBGreenLightMax.Value + 1)

            End If

        End If

    End Sub





    Private Sub domName_Leave(sender As System.Object, e As System.EventArgs) Handles domName.Leave
        My.Settings.DomName = domName.Text
        My.Settings.Save()
    End Sub
    Private Sub subName_Leave(sender As System.Object, e As System.EventArgs) Handles subName.Leave
        My.Settings.SubName = subName.Text
        My.Settings.Save()
    End Sub


    Public Sub StatusUpdatePost()


        UpdatingPost = True


       

        StatusText = UpdateList(randomizer.Next(0, UpdateList.Count))

        For i As Integer = 0 To UpdateList.Count - 1
            Debug.Print(i & ". " & UpdateList(i))
        Next
        Debug.Print("STatusText = " & StatusText)
        Debug.Print("Clear stage 1")

        Dim ioFile As New StreamReader(StatusText)

        Dim lines As New List(Of String)
        Dim TempUpdates As Integer

        While ioFile.Peek <> -1
            TempUpdates += 1
            lines.Add(ioFile.ReadLine())
        End While

        ioFile.Close()
        ioFile.Dispose()


        For i As Integer = lines.Count - 1 To 0 Step -1
            If lines(i) = "" Or lines(i) Is Nothing Then
                lines.Remove(lines(i))
            End If
        Next

        StatusText = lines(0)
        Debug.Print("HEre?")
        StatusText = PoundClean(StatusText)

        Dim AtArray() As String = Split(StatusText)
        For i As Integer = AtArray.Length - 1 To 0 Step -1
            If AtArray(i).Contains("@") Then
                AtArray(i) = AtArray(i).Replace(AtArray(i), "")
            End If
            If FrmSettings.CBHimHer.Checked = True Then
                If AtArray(i) = "He" Then AtArray(i) = AtArray(i).Replace("He", "She")
                If AtArray(i) = "he" Then AtArray(i) = AtArray(i).Replace("he", "she")
                If AtArray(i) = "Him" Then AtArray(i) = AtArray(i).Replace("Him", "Her")
                If AtArray(i) = "him" Then AtArray(i) = AtArray(i).Replace("him", "her")
                If AtArray(i) = "His" Then AtArray(i) = AtArray(i).Replace("His", "Her")
                If AtArray(i) = "his" Then AtArray(i) = AtArray(i).Replace("his", "her")
            End If
        Next
        StatusText = Join(AtArray)

        Dim DPic As String = My.Settings.GlitterAV
        DPic = "file://" & DPic
        DPic = DPic.Replace("\", "/")
        Debug.Print(DPic)

        Dim StatusName As String


        StatusName = StatusUpdates.DocumentText & "<img class=""floatright"" style="" float: left; width: 48; height: 48; border: 0;"" src=""" & DPic & """> <font face=""Cambria"" size=""3"" color=""" & GlitterNCDomme & """><b>" & domName.Text & "</b></font> <br><font face=""Cambria"" size=""2"" color=""DarkGray"">" & Date.Today & "</font><br><br>"
        StatusUpdates.DocumentText = StatusName & "<font face=""Cambria"" size=""2"" color=""Black"">" & StatusText & "</font><br><br>"

        'Debug.Print(GlitterImageAV)
        Debug.Print("Clear Stage 2")

    


        Dim StatusLines1 As New List(Of String)
        For i As Integer = 1 To lines.Count - 1
            StatusLines1.Add(lines(i))
        Next
        ContactNumber = 1

        ' For i As Integer = StatusLines1.Count - 1 To 0 Step -1
        'If StatusLines1(i) = "" Or StatusLines1(i) Is Nothing Then
        'StatusLines1.Remove(StatusLines1(i))
        'End If
        'Next

        StatusLines1 = StatusClean(StatusLines1)



        Dim StatusText1 As String = StatusLines1(randomizer.Next(0, StatusLines1.Count))

        Dim StatusLines2 As New List(Of String)
        For i As Integer = 1 To lines.Count - 1
            StatusLines2.Add(lines(i))
        Next
        ContactNumber = 2

        ' For i As Integer = StatusLines2.Count - 1 To 0 Step -1
        'If StatusLines2(i) = "" Or StatusLines2(i) Is Nothing Then
        'StatusLines2.Remove(StatusLines2(i))
        'End If
        'Next

        StatusLines2 = StatusClean(StatusLines2)



        Dim StatusText2 As String
        Do
            StatusText2 = StatusLines2(randomizer.Next(0, StatusLines2.Count))
        Loop Until StatusText2 <> StatusText1


        Dim StatusLines3 As New List(Of String)
        For i As Integer = 1 To lines.Count - 1
            StatusLines3.Add(lines(i))
        Next
        ContactNumber = 3

        'For i As Integer = StatusLines3.Count - 1 To 0 Step -1
        'If StatusLines3(i) = "" Or StatusLines3(i) Is Nothing Then
        'StatusLines3.Remove(StatusLines3(i))
        'End If
        'Next

        StatusLines3 = StatusClean(StatusLines3)
        Dim StatusText3 As String
        Do
            StatusText3 = StatusLines3(randomizer.Next(0, StatusLines3.Count))
        Loop Until StatusText3 <> StatusText2 And StatusText3 <> StatusText1

        ''Debug.Print("StatusLine = " & StatusLine)


   

        StatusText1 = StatusText1.Replace("#ShortName", FrmSettings.TBGlitterShortName.Text)
        StatusText2 = StatusText2.Replace("#ShortName", FrmSettings.TBGlitterShortName.Text)
        StatusText3 = StatusText3.Replace("#ShortName", FrmSettings.TBGlitterShortName.Text)

        StatusText1 = StatusText1.Replace("#SubName", subName.Text)
        StatusText2 = StatusText2.Replace("#SubName", subName.Text)
        StatusText3 = StatusText3.Replace("#SubName", subName.Text)

        StatusText1 = PoundClean(StatusText1)
        StatusText2 = PoundClean(StatusText2)
        StatusText3 = PoundClean(StatusText3)

        'GoTo TestSkip

        Dim AtArray1() As String = Split(StatusText1)
        For i As Integer = AtArray1.Length - 1 To 0 Step -1
            If AtArray1(i).Contains("@") Then
                AtArray1(i) = AtArray1(i).Replace(AtArray1(i), "")
            End If
            If FrmSettings.CBHimHer.Checked = True Then
                If AtArray1(i) = "He" Then AtArray1(i) = AtArray1(i).Replace("He", "She")
                If AtArray1(i) = "he" Then AtArray1(i) = AtArray1(i).Replace("he", "she")
                If AtArray1(i) = "Him" Then AtArray1(i) = AtArray1(i).Replace("Him", "Her")
                If AtArray1(i) = "him" Then AtArray1(i) = AtArray1(i).Replace("him", "her")
                If AtArray1(i) = "His" Then AtArray1(i) = AtArray1(i).Replace("His", "Her")
                If AtArray1(i) = "his" Then AtArray1(i) = AtArray1(i).Replace("his", "her")
            End If
        Next
        StatusText1 = Join(AtArray1)

        Dim AtArray2() As String = Split(StatusText2)
        For i As Integer = AtArray2.Length - 1 To 0 Step -1
            If AtArray2(i).Contains("@") Then
                AtArray2(i) = AtArray2(i).Replace(AtArray2(i), "")
            End If
            If FrmSettings.CBHimHer.Checked = True Then
                If AtArray2(i) = "He" Then AtArray2(i) = AtArray2(i).Replace("He", "She")
                If AtArray2(i) = "he" Then AtArray2(i) = AtArray2(i).Replace("he", "she")
                If AtArray2(i) = "Him" Then AtArray2(i) = AtArray2(i).Replace("Him", "Her")
                If AtArray2(i) = "him" Then AtArray2(i) = AtArray2(i).Replace("him", "her")
                If AtArray2(i) = "His" Then AtArray2(i) = AtArray2(i).Replace("His", "Her")
                If AtArray2(i) = "his" Then AtArray2(i) = AtArray2(i).Replace("his", "her")
            End If
        Next
        StatusText2 = Join(AtArray2)

        Dim AtArray3() As String = Split(StatusText3)
        For i As Integer = AtArray3.Length - 1 To 0 Step -1
            If AtArray3(i).Contains("@") Then
                AtArray3(i) = AtArray3(i).Replace(AtArray3(i), "")
            End If
            If FrmSettings.CBHimHer.Checked = True Then
                If AtArray3(i) = "He" Then AtArray3(i) = AtArray(i).Replace("He", "She")
                If AtArray3(i) = "he" Then AtArray3(i) = AtArray(i).Replace("he", "she")
                If AtArray3(i) = "Him" Then AtArray3(i) = AtArray(i).Replace("Him", "Her")
                If AtArray3(i) = "him" Then AtArray3(i) = AtArray(i).Replace("him", "her")
                If AtArray3(i) = "His" Then AtArray3(i) = AtArray(i).Replace("His", "Her")
                If AtArray3(i) = "his" Then AtArray3(i) = AtArray(i).Replace("his", "her")
            End If
        Next
        StatusText3 = Join(AtArray3)

        'TestSkip:

        Dim StatusChance1 As Integer = randomizer.Next(1, 101)
        Dim StatusChance2 As Integer = randomizer.Next(1, 101)
        Dim StatusChance3 As Integer = randomizer.Next(1, 101)

        Dim Update1 As Boolean
        Dim Update2 As Boolean
        Dim Update3 As Boolean

        Update1 = False
        Update2 = False
        Update3 = False


StatusUpdateBegin:

        If Update1 = True And Update2 = True And Update3 = True Then GoTo StatusUpdateEnd

        ContactTick = randomizer.Next(10, 21)
        ContactFlag = True
        ContactTimer.Start()

        Do
            Application.DoEvents()
        Loop Until ContactFlag = False

        'Delay(RandomDelay)

ReRoll:

        TempVal = randomizer.Next(1, 4)
        'Debug.Print("TempVal = " & TempVal)

        If TempVal = 1 Then
            If Update1 = False Then
                GoTo StatusUpdate1
            Else
                GoTo ReRoll
            End If
        End If

        If TempVal = 2 Then
            If Update2 = False Then
                GoTo StatusUpdate2
            Else
                GoTo ReRoll
            End If
        End If

        If TempVal = 3 Then
            If Update3 = False Then
                GoTo StatusUpdate3
            Else
                GoTo ReRoll
            End If
        End If

        GoTo ReRoll

StatusUpdate1:

        Dim S1Pic As String = My.Settings.GlitterAV1
        S1Pic = "file://" & S1Pic
        S1Pic = S1Pic.Replace("\", "/")
        Debug.Print(S1Pic)

        If StatusChance1 < FrmSettings.GlitterSlider1.Value * 10 And FrmSettings.CBGlitter1.Checked = True Then
            StatusName = StatusUpdates.DocumentText & "<img class=""floatright"" style="" float: left; width: 32; height: 32; border: 0;"" src=""" & S1Pic & """> <font face=""Cambria"" size=""3"" color=""" & GlitterNC1 & """><b>" & FrmSettings.TBGlitter1.Text & "</b></font><br> <font face=""Cambria"" size=""2"" color=""DarkGray"">" & Date.Today & "</font><br>" ' & "<font face=""Cambria"" size=""2"" color=""DarkGray"">" & TimeOfDay & "</font><br>"
            StatusUpdates.DocumentText = StatusName & "<font face=""Cambria"" size=""2"" color=""Black"">" & StatusText1 & "</font><br><br>"
       

        End If

        Update1 = True
        GoTo StatusUpdateBegin

StatusUpdate2:

        Dim S2Pic As String = My.Settings.GlitterAV2
        S2Pic = "file://" & S2Pic
        S2Pic = S2Pic.Replace("\", "/")
        Debug.Print(S2Pic)

        If StatusChance2 < FrmSettings.GlitterSlider2.Value * 10 And FrmSettings.CBGlitter2.Checked = True Then
            StatusName = StatusUpdates.DocumentText & "<img class=""floatright"" style="" float: left; width: 32; height: 32; border: 0;"" src=""" & S2Pic & """> <font face=""Cambria"" size=""3"" color=""" & GlitterNC2 & """><b>" & FrmSettings.TBGlitter2.Text & "</b></font><br> <font face=""Cambria"" size=""2"" color=""DarkGray"">" & Date.Today & "</font><br>" ' & "<font face=""Cambria"" size=""2"" color=""DarkGray"">" & TimeOfDay & "</font><br>"
            StatusUpdates.DocumentText = StatusName & "<font face=""Cambria"" size=""2"" color=""Black"">" & StatusText2 & "</font><br><br>"

       
        End If

        Update2 = True
        GoTo StatusUpdateBegin

StatusUpdate3:

        Dim S3Pic As String = My.Settings.GlitterAV3
        S3Pic = "file://" & S3Pic
        S3Pic = S3Pic.Replace("\", "/")
        Debug.Print(S3Pic)

        If StatusChance3 < FrmSettings.GlitterSlider3.Value * 10 And FrmSettings.CBGlitter3.Checked = True Then
            StatusName = StatusUpdates.DocumentText & "<img class=""floatright"" style="" float: left; width: 32; height: 32; border: 0;"" src=""" & S3Pic & """> <font face=""Cambria"" size=""3"" color=""" & GlitterNC3 & """><b>" & FrmSettings.TBGlitter3.Text & "</b></font><br> <font face=""Cambria"" size=""2"" color=""DarkGray"">" & Date.Today & "</font><br>" ' & "<font face=""Cambria"" size=""2"" color=""DarkGray"">" & TimeOfDay & "</font><br>"
            StatusUpdates.DocumentText = StatusName & "<font face=""Cambria"" size=""2"" color=""Black"">" & StatusText3 & "</font><br><br>"

     
        End If

        Update3 = True
        GoTo StatusUpdateBegin

StatusUpdateEnd:

     

        StatusText = "Null" & Environment.NewLine & "Null" & Environment.NewLine & "Null" & Environment.NewLine & "Null" & Environment.NewLine

        UpdatingPost = False


    End Sub

    Public Function StatusClean(ByVal ListClean As List(Of String)) As List(Of String)



        ListClean.Add("### BUFFER LINE ###")
        Debug.Print("ListClean.Count = " & ListClean.Count)

        If ContactNumber = 1 Then
            For i As Integer = ListClean.Count - 1 To 0 Step -1
                If ListClean(i).Contains("@Bratty") And FrmSettings.CB1Bratty.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Bratty ", "")
                End If
                If ListClean(i).Contains("@Cruel") And FrmSettings.CB1Cruel.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Cruel ", "")
                End If
                If ListClean(i).Contains("@Caring") And FrmSettings.CB1Caring.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Caring ", "")
                End If
                If ListClean(i).Contains("@Angry") And FrmSettings.CB1Angry.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Angry ", "")
                End If
                If ListClean(i).Contains("@Custom1") And FrmSettings.CB1Custom1.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom1 ", "")
                End If
                If ListClean(i).Contains("@Custom2") And FrmSettings.CB1Custom2.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom2 ", "")
                End If
            Next
        End If

        If ContactNumber = 2 Then
            For i As Integer = ListClean.Count - 1 To 0 Step -1
                If ListClean(i).Contains("@Bratty") And FrmSettings.CB2Bratty.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Bratty ", "")
                End If
                If ListClean(i).Contains("@Cruel") And FrmSettings.CB2Cruel.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Cruel ", "")
                End If
                If ListClean(i).Contains("@Caring") And FrmSettings.CB2Caring.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Caring ", "")
                End If
                If ListClean(i).Contains("@Angry") And FrmSettings.CB2Angry.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Angry ", "")
                End If
                If ListClean(i).Contains("@Custom1") And FrmSettings.CB2Custom1.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom1 ", "")
                End If
                If ListClean(i).Contains("@Custom2") And FrmSettings.CB2Custom2.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom2 ", "")
                End If
            Next
        End If

        If ContactNumber = 3 Then
            For i As Integer = ListClean.Count - 1 To 0 Step -1
                If ListClean(i).Contains("@Bratty") And FrmSettings.CB3Bratty.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Bratty ", "")
                End If
                If ListClean(i).Contains("@Cruel") And FrmSettings.CB3Cruel.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Cruel ", "")
                End If
                If ListClean(i).Contains("@Caring") And FrmSettings.CB3Caring.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Caring ", "")
                End If
                If ListClean(i).Contains("@Angry") And FrmSettings.CB3Angry.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Angry ", "")
                End If
                If ListClean(i).Contains("@Custom1") And FrmSettings.CB3Custom1.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom1 ", "")
                End If
                If ListClean(i).Contains("@Custom2") And FrmSettings.CB3Custom2.Checked = False Then
                    ListClean.Remove(ListClean(i))
                Else
                    ListClean(i) = ListClean(i).Replace("@Custom2 ", "")
                End If
            Next
        End If

        ListClean.Remove(ListClean(ListClean.Count - 1))

        Return ListClean

    End Function

    Private Sub Delay(ByVal Milliseconds As Integer)
        Dim Count As Integer
        Milliseconds *= 1000
        Do Until Count >= Milliseconds
            Count += 1
            Thread.Sleep(1)
            Debug.Print(Count)
            Application.DoEvents()
        Loop
    End Sub

    Private Sub domAvatar_Click(sender As System.Object, e As System.EventArgs) Handles domAvatar.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                domAvatar.Image.Dispose()
                domAvatar.Image = Nothing
                GC.Collect()
            Catch
            End Try

            domAvatar.LoadFromUrl(OpenFileDialog1.FileName)
            My.Settings.DomAvatarSave = OpenFileDialog1.FileName
            My.Settings.Save()
        End If
    End Sub

    Private Sub subAvatar_Click(sender As System.Object, e As System.EventArgs) Handles subAvatar.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                subAvatar.Image.Dispose()
                subAvatar.Image = Nothing
                GC.Collect()
            Catch
            End Try
            subAvatar.LoadFromUrl(OpenFileDialog1.FileName)
            My.Settings.SubAvatarSave = OpenFileDialog1.FileName
            My.Settings.Save()
        End If
    End Sub


    Private Sub UpdatesTimer_Tick(sender As System.Object, e As System.EventArgs) Handles UpdatesTimer.Tick

        'Debug.Print("updates tick = " & UpdatesTick)

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If FrmSettings.CBGlitterFeed.Checked = True And UpdatingPost = False Then

            UpdatesTick -= 1

            If UpdatesTick < 1 Then

                UpdatesTick = 120

                UpdateList.Clear()

                If FrmSettings.CBTease.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Tease\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If FrmSettings.CBEgotist.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Egotist\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If FrmSettings.CBTrivia.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Trivia\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If FrmSettings.CBDaily.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Daily\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If FrmSettings.CBCustom1.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Custom 1\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If FrmSettings.CBCustom2.Checked = True Then
                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Glitter\Custom 2\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        UpdateList.Add(foundFile)
                    Next
                End If

                If UpdateList.Count < 1 Then
                    FrmSettings.CBGlitterFeed.Checked = False
                    'MessageBox.Show(Me, "Tease AI attempted to create a Glitter update, but no files were found! Please make sure at least one category containing Glitter txt files has been selected.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    MessageBox.Show(Me, "Tease AI attempted to create a Glitter update, but no files were found! Please make sure at least one category containing Glitter txt files has been selected." & Environment.NewLine _
                    & Environment.NewLine & "Glitter feed has been automatically disabled.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Return
                End If



                StatusUpdatePost()



            End If

        End If
    End Sub

  

   

    Private Sub Button18_Click_1(sender As System.Object, e As System.EventArgs) Handles MediaButton.Click


        If PNLMediaBar.Visible = True Then
            PNLMediaBar.Visible = False
            MediaButton.Text = "Show Media Panel"
            ChatText.Location = New Point(0, 0)
            ChatText.Height = ChatText.Height + 29


        Else
            PNLMediaBar.Visible = True
            MediaButton.Text = "Hide Media Panel"
            ChatText.Location = New Point(0, 29)
            ChatText.Height = ChatText.Height - 29

        End If

       ScrollChatDown()

    End Sub

    Public Function Color2Html(ByVal MyColor As Color) As String
        Return "#" & MyColor.ToArgb().ToString("x").Substring(2).ToUpper
    End Function

    Public Function SysKeywordClean(ByVal StringClean As String) As String

        StringClean = StringClean.Replace("#SubName", subName.Text)

        StringClean = StringClean.Replace("#DomName", domName.Text)

        StringClean = StringClean.Replace("#DomHonorific", FrmSettings.TBHonorific.Text)

        StringClean = StringClean.Replace("#DomAge", FrmSettings.domageNumBox.Value)

        StringClean = StringClean.Replace("#DomLevel", FrmSettings.domlevelNumBox.Value)

        StringClean = StringClean.Replace("#DomHair", FrmSettings.TBDomHairColor.Text)

        StringClean = StringClean.Replace("#DomEyes", FrmSettings.TBDomEyeColor.Text)

        StringClean = StringClean.Replace("#DomCup", FrmSettings.boobComboBox.Text)

        StringClean = StringClean.Replace("#DomMood", DommeMood)

        StringClean = StringClean.Replace("#DomAvgCockMin", FrmSettings.NBAvgCockMin.Value)

        StringClean = StringClean.Replace("#DomAvgCockMax", FrmSettings.NBAvgCockMax.Value)

        StringClean = StringClean.Replace("#DomSmallCockMax", FrmSettings.NBAvgCockMin.Value - 1)

        StringClean = StringClean.Replace("#DomLargeCockMin", FrmSettings.NBAvgCockMax.Value + 1)

        StringClean = StringClean.Replace("#DomSelfAgeMin", FrmSettings.NBSelfAgeMin.Value)

        StringClean = StringClean.Replace("#DomSelfAgeMax", FrmSettings.NBSelfAgeMax.Value)

        StringClean = StringClean.Replace("#DomSubAgeMin", FrmSettings.NBSubAgeMin.Value)

        StringClean = StringClean.Replace("#DomSubAgeMax", FrmSettings.NBSubAgeMax.Value)

        StringClean = StringClean.Replace("#DomOrgasmRate", LCase(FrmSettings.alloworgasmComboBox.Text))

        StringClean = StringClean.Replace("#DomRuinRate", LCase(FrmSettings.ruinorgasmComboBox.Text))

        StringClean = StringClean.Replace("#SubAge", FrmSettings.subAgeNumBox.Value)

        StringClean = StringClean.Replace("#SubBirthdayMonth", FrmSettings.NBBirthdayMonth.Value)

        StringClean = StringClean.Replace("#SubBirthdayDay", FrmSettings.NBBirthdayDay.Value)

        StringClean = StringClean.Replace("#SubHair", FrmSettings.TBSubHairColor.Text)

        StringClean = StringClean.Replace("#SubEyes", FrmSettings.TBSubEyeColor.Text)

        StringClean = StringClean.Replace("#SubCockSize", FrmSettings.CockSizeNumBox.Value)

        StringClean = StringClean.Replace("#SubWritingTaskMin", FrmSettings.NBWritingTaskMin.Value)

        StringClean = StringClean.Replace("#SubWritingTaskMax", FrmSettings.NBWritingTaskMax.Value)

        ' StringClean = StringClean.Replace("#SubWritingTaskRAND", randomizer.Next(NBWritingTaskMin.Value / 10, (NBWritingTaskMax.Value / 10) + 1)) * 10

        StringClean = StringClean.Replace("#ShortName", FrmSettings.TBGlitterShortName.Text)

        StringClean = StringClean.Replace("#GlitterContact1", FrmSettings.TBGlitter1.Text)

        StringClean = StringClean.Replace("#GlitterContact2", FrmSettings.TBGlitter2.Text)

        StringClean = StringClean.Replace("#GlitterContact3", FrmSettings.TBGlitter3.Text)

        Debug.Print("Test")

        If My.Settings.OrgasmsLocked = True Then
            StringClean = StringClean.Replace("#OrgasmLockDate", My.Settings.OrgasmLockDate.Date.ToString())
        Else
            StringClean = StringClean.Replace("#OrgasmLockDate", "later")
        End If

      



        Dim PetNameVal As Integer = randomizer.Next(1, 5)

        If PetNameVal = 1 Then PetName = FrmSettings.petnameBox3.Text
        If PetNameVal = 2 Then PetName = FrmSettings.petnameBox4.Text
        If PetNameVal = 3 Then PetName = FrmSettings.petnameBox5.Text
        If PetNameVal = 4 Then PetName = FrmSettings.petnameBox6.Text

        If DommeMood < FrmSettings.NBDomMoodMin.Value Then
            PetNameVal = randomizer.Next(1, 3)
            If PetNameVal = 1 Then PetName = FrmSettings.petnameBox7.Text
            If PetNameVal = 2 Then PetName = FrmSettings.petnameBox8.Text
        End If


        If DommeMood > FrmSettings.NBDomMoodMax.Value Then
            PetNameVal = randomizer.Next(1, 3)
            If PetNameVal = 1 Then PetName = FrmSettings.petnameBox1.Text
            If PetNameVal = 2 Then PetName = FrmSettings.petnameBox2.Text
        End If

        StringClean = StringClean.Replace("#PetName2", PetName2)
        StringClean = StringClean.Replace("#PetName", PetName)
        StringClean = StringClean.Replace("#SubName", subName.Text)



        If Hour(Date.Now) < 3 Then StringClean = StringClean.Replace("#GeneralTime", "tonight")
        If Hour(Date.Now) > 2 And Hour(Date.Now) < 11 Then StringClean = StringClean.Replace("#GeneralTime", "this morning")
        If Hour(Date.Now) > 10 And Hour(Date.Now) < 18 Then StringClean = StringClean.Replace("#GeneralTime", "today")
        If Hour(Date.Now) > 17 Then StringClean = StringClean.Replace("#GeneralTime", "tonight")

        If StringClean.Contains("#RANDNumberLow") Then
            ' ### Number between 3-5 , 5-25
            TempVal = randomizer.Next(1, 6) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            If TempVal < 3 Then TempVal = 3
            StringClean = StringClean.Replace("#RNDNumberLow", TempVal)
        End If


        If StringClean.Contains("#RANDNumberHigh") Then
            ' ### Number between 5-25 , 25-100
            TempVal = randomizer.Next(5, 21) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            StringClean = StringClean.Replace("#RNDNumberHigh", TempVal)
        End If


        If StringClean.Contains("#RANDNumber") Then
            ' ### Number between 3-10 , 5-50
            TempVal = randomizer.Next(1, 11) * FrmSettings.domlevelNumBox.Value
            If TempVal > 10 Then TempVal = 5 * Math.Round(TempVal / 5)
            If TempVal < 3 Then TempVal = 3
            StringClean = StringClean.Replace("#RNDNumber", TempVal)
        End If

        Return StringClean


    End Function


    Public Function PoundClean(ByVal StringClean As String) As String

        'Debug.Print("StringClean = " & StringClean)

DeepClean:


        StringClean = SysKeywordClean(StringClean)
       
        Debug.Print("PoundClean System Keyword Checkpoint")

       

        FoundTag = "NULL"

        If File.Exists(Application.StartupPath & "\Images\System\ImageTags.txt") Then
            Dim TagReader As New StreamReader(Application.StartupPath & "\Images\System\ImageTags.txt")
            Dim TagList As New List(Of String)
            While TagReader.Peek <> -1
                TagList.Add(TagReader.ReadLine())
            End While

            TagReader.Close()
            TagReader.Dispose()



            'If SlideshowLoaded = True And Not mainPictureBox.Image Is Nothing And domVLC.Visible = False Then
            If SlideshowLoaded = True And Not mainPictureBox.Image Is Nothing And DomWMP.Visible = False Then
                Try
                    For t As Integer = 0 To TagList.Count - 1
                        'Debug.Print("TagList(t) = " & TagList(t))
                        If TagList(t).Contains(_ImageFileNames(FileCount)) Then
                            FoundTag = TagList(t)
                            Dim FoundTagSplit As String() = Split(FoundTag)
                            For j As Integer = 0 To FoundTagSplit.Length - 1
                                If FoundTagSplit(j).Contains("TagGarment") Then TagGarment = FoundTagSplit(j).Replace("TagGarment", "")
                                If FoundTagSplit(j).Contains("TagUnderwear") Then TagUnderwear = FoundTagSplit(j).Replace("TagUnderwear", "")
                                If FoundTagSplit(j).Contains("TagTattoo") Then TagTattoo = FoundTagSplit(j).Replace("TagTattoo", "")
                                If FoundTagSplit(j).Contains("TagSexToy") Then TagSexToy = FoundTagSplit(j).Replace("TagSexToy", "")
                                If FoundTagSplit(j).Contains("TagFurniture") Then TagFurniture = FoundTagSplit(j).Replace("TagFurniture", "")
                            Next
                            Exit For
                        End If
                    Next
                Catch
                End Try
            End If


            'Debug.Print("TagGarment = " & TagGarment)
            'Debug.Print("TagUnderwear = " & TagUnderwear)
            'Debug.Print("TagTattoo = " & TagTattoo)
            'Debug.Print("TagSexToy = " & TagSexToy)
            'Debug.Print("TagFurniture = " & TagFurniture)
            'Debug.Print("FoundTag = " & FoundTag)



        End If

        StringClean = StringClean.Replace("#TagGarment", TagGarment)
        StringClean = StringClean.Replace("#TagUnderwear", TagUnderwear)
        StringClean = StringClean.Replace("#TagTattoo", TagTattoo)
        StringClean = StringClean.Replace("#TagSexToy", TagSexToy)
        StringClean = StringClean.Replace("#TagFurniture", TagFurniture)


        If StringClean.Contains("#") Or StringClean.Contains("@Tag") Then


            Dim PoundArray() As String = Split(StringClean)


            Dim LastNonEmpty As Integer = -1

            For i As Integer = 0 To PoundArray.Length - 1
                'Debug.Print("PoundArray(i) = " & PoundArray(i))
                'Debug.Print("PoundArray.Length = " & PoundArray.Length)
                If PoundArray(i) = "" Then GoTo PoundBreak
                If PoundArray(i).Substring(0, 1) = "#" Then

                    'DoItHere:

                    ' PoundArray(i) = SysKeywordClean(PoundArray(i))

                    'If Not PoundArray(i).Contains("#") Then GoTo PoundBreak


                    PoundArray(i) = PoundArray(i).Replace(".", "")
                    PoundArray(i) = PoundArray(i).Replace(",", "")
                    PoundArray(i) = PoundArray(i).Replace("!", "")
                    PoundArray(i) = PoundArray(i).Replace("?", "")
                    PoundArray(i) = PoundArray(i).Replace(":", "")
                    PoundArray(i) = PoundArray(i).Replace(";", "")
                    PoundArray(i) = PoundArray(i).Replace("'s", "")

                    If File.Exists(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\" & PoundArray(i) & ".txt") Then

                        Dim ioFile As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\" & PoundArray(i) & ".txt")
                        Dim lines As New List(Of String)
                        Dim Vocab As New List(Of String)
                        Dim PoundLine As Integer
                        PoundLine = -1

                        While ioFile.Peek <> -1
                            PoundLine += 1
                            lines.Add(ioFile.ReadLine())
                            'Debug.Print("iofile.readline = " & lines(PoundLine))
                            If lines(PoundLine) = "" Then
                                lines.Remove(PoundLine)
                                PoundLine -= 1
                            End If
                        End While

                        ioFile.Close()
                        ioFile.Dispose()


                        lines = FilterList(lines)



                        Crazy = False
                        Vulgar = False
                        Supremacist = False

                        Dim PoundVal As Integer = randomizer.Next(0, lines.Count)

                        'Debug.Print("PoundLine = " & PoundLine)
                        'Debug.Print("PoundVal = " & PoundVal)


                        StringClean = StringClean.Replace(PoundArray(i), lines(PoundVal))

                        StringClean = StringClean.Replace("TagFace", "")
                        StringClean = StringClean.Replace("TagBoobs", "")
                        StringClean = StringClean.Replace("TagPussy", "")
                        StringClean = StringClean.Replace("TagAss", "")
                        StringClean = StringClean.Replace("TagFeet", "")
                        StringClean = StringClean.Replace("TagFullyDressed", "")
                        StringClean = StringClean.Replace("TagHalfDressed", "")
                        StringClean = StringClean.Replace("TagNaked", "")
                        StringClean = StringClean.Replace("TagSideView", "")
                        StringClean = StringClean.Replace("TagCloseUp", "")
                        StringClean = StringClean.Replace("TagMasturbating", "")
                        StringClean = StringClean.Replace("TagSucking", "")


                        'If PoundArray(i).Contains("#") Then GoTo DoItHere

                    Else

                        MsgBox("""" & PoundArray(i) & ".txt"" was not found in """ & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\. Please verify the file is in the correct folder and that " _
                               & "the Vocabulary word is spelled correctly in the script.", , "Error!")

                        StringClean = StringClean.Replace(PoundArray(i), PoundArray(i).Replace("#", ""))

                        'PoundArray(i) = PoundArray(i).Replace("#", "")
                        Debug.Print("dafuq?")
                        Debug.Print(StringClean)
                        'GoTo BadVocabBreak

                    End If

                End If

PoundBreak:

            Next

            'PoundBreak:

        End If

        'Debug.Print("StringClean = " & StringClean)

        If StringClean.Contains("#") Then GoTo DeepClean

BadVocabBreak:

        Return StringClean
    End Function

    Public Function CommandClean(ByVal StringClean As String) As String

        Debug.Print("Stringclean Intro = " & StringClean)

RinseLatherRepeat:

        

        If StringClean.Contains("@LockImages") Then
            LockImage = True
            nextButton.Enabled = False
            previousButton.Enabled = False
            StringClean = StringClean.Replace("@LockImages", "")
        End If

        If StringClean.Contains("@UnlockImages") Then
            nextButton.Enabled = True
            previousButton.Enabled = True
            LockImage = False
            StringClean = StringClean.Replace("@UnlockImages", "")
        End If


        '  ┌─┐╔═╗┬ ┬┌─┐┌┐┌┌─┐┌─┐
        '  │└┘║  ├─┤├─┤││││  ├┤ 
        '  └──╚═╝┴ ┴┴ ┴┘└┘└─┘└─┘


        If StringClean.Contains("@Chance") Then

            Dim ChanceTemp As String
            Dim TSStartIndex As Integer
            Dim TSEndIndex As Integer

            TSStartIndex = StringClean.IndexOf("@Chance") + 7
            TSEndIndex = StringClean.IndexOf("@Chance") + 9

            ChanceTemp = StringClean.Substring(TSStartIndex, TSEndIndex - TSStartIndex).Trim

            Dim ChanceVal As Integer

            ChanceVal = Val(ChanceTemp)

            TempVal = randomizer.Next(1, 101)
            'Debug.Print("Stringclean = " & StringClean)

            Dim ChanceString As String = StringClean.Substring(TSStartIndex + 2, StringClean.Length - (TSStartIndex + 2)).Trim
            'Debug.Print("ChanceString= " & ChanceString)
            Dim ChanceSplit As String() = Split(ChanceString, ")")
            'Debug.Print("ChanceSplit(0) = " & ChanceSplit(0))

            'Debug.Print("@Chance n ChanceString= " & "@Chance" & ChanceVal & ChanceString)
            StringClean = StringClean.Replace("@Chance" & ChanceVal & ChanceString, "")

            If TempVal <= ChanceVal Then



                FileGoto = ChanceSplit(0) & ")"
                'Debug.Print("FileGoto = " & FileGoto)
                SkipGotoLine = True



                If YesOrNo = True Then
                    'StringClean = StringClean.Replace("@Chance" & ChanceTemp, "@Goto")
                    GetGotoChat()
                Else
                    'StringClean = StringClean.Replace("@Chance" & ChanceTemp, "@Goto")
                    GetGoto()
                End If


            End If

            'StringClean = StringClean.Replace("@Chance" & ChanceTemp, "")

        End If

        '  ┌─┐╔═╗┬ ┬┌─┐┌─┐┬┌─╔═╗┬  ┌─┐┌─┐
        '  │└┘║  ├─┤├┤ │  ├┴┐╠╣ │  ├─┤│ ┬
        '  └──╚═╝┴ ┴└─┘└─┘┴ ┴╚  ┴─┘┴ ┴└─┘

        If StringClean.Contains("@CheckFlag") Then

            'Debug.Print("Stringclean = " & StringClean)
            'Debug.Print("CheckFlagcalled")

            Dim CheckFlag As String = StringClean & " some test garbage"

            Dim CFIndex As Integer = StringClean.IndexOf("@CheckFlag(") + 11
            'TSEndIndex = StringClean.IndexOf("@Chance") + 9

            CheckFlag = CheckFlag.Substring(CFIndex, StringClean.Length - CFIndex)
            'CheckFlag = CheckFlag.Split("@CheckFlag(")(1)
            CheckFlag = CheckFlag.Split(")")(0)
            CheckFlag = CheckFlag.Replace("CheckFlag(", "")

            'Debug.Print("CheckFlag = " & CheckFlag)

            If CheckFlag.Contains(",") Then

                'Debug.Print("CheckFlag Contains Comma ")
                CheckFlag = CheckFlag.Replace(", ", ",")
                CheckFlag = CheckFlag.Replace(" ,", ",")

                Dim FlagArray() As String = CheckFlag.Split(",")

                For i As Integer = 0 To FlagArray.Length - 1
                    'Debug.Print("FlagArray(i) = " & FlagArray(i))
                    If File.Exists(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Flags\" & FlagArray(i)) Then
                        SkipGotoLine = True
                        FileGoto = FlagArray(i)
                        GetGoto()
                    End If
                Next
            Else
                If File.Exists(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Flags\" & CheckFlag) Then
                    'Debug.Print("CheckFlag = " & CheckFlag)
                    SkipGotoLine = True
                    FileGoto = CheckFlag
                    GetGoto()
                End If
            End If
            StringClean = StringClean.Replace("@CheckFlag", "")
        End If

        '  ┌─┐╔╦╗┬┌─┐┬  ┬┬┌─┌─┐╔╗ ┬  ┌─┐┌─┐╦┌┬┐┌─┐┌─┐┌─┐
        '  │└┘ ║║│└─┐│  │├┴┐├┤ ╠╩╗│  │ ││ ┬║│││├─┤│ ┬├┤ 
        '  └──═╩╝┴└─┘┴─┘┴┴ ┴└─┘╚═╝┴─┘└─┘└─┘╩┴ ┴┴ ┴└─┘└─┘

        If StringClean.Contains("@DislikeBlogImage") Then

            If FoundString <> "" Then

                If File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\DislikedImageURLs.txt", Environment.NewLine & FoundString, True)
                Else
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\DislikedImageURLs.txt", FoundString, True)
                End If
                StringClean = StringClean.Replace("@DislikeBlogImage", "")
            End If

        End If

        '  ┌─┐╦  ┬┬┌─┌─┐╔╗ ┬  ┌─┐┌─┐╦┌┬┐┌─┐┌─┐┌─┐
        '  │└┘║  │├┴┐├┤ ╠╩╗│  │ ││ ┬║│││├─┤│ ┬├┤ 
        '  └──╩═╝┴┴ ┴└─┘╚═╝┴─┘└─┘└─┘╩┴ ┴┴ ┴└─┘└─┘

        If StringClean.Contains("@LikeBlogImage") Then

            If FoundString <> "" Then

                If File.Exists(Application.StartupPath & "\Images\System\LikedImageURLs.txt") Then
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\LikedImageURLs.txt", Environment.NewLine & FoundString, True)
                Else
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\LikedImageURLs.txt", FoundString, True)
                End If
                StringClean = StringClean.Replace("@LikeBlogImage", "")
            End If

        End If


        If StringClean.Contains("@ShowLikedImage") Then
            If File.Exists(Application.StartupPath & "\Images\System\LikedImageURLs.txt") Then
                Dim LikeReader As New StreamReader(Application.StartupPath & "\Images\System\LikedImageURLs.txt")
                Dim LikeList As New List(Of String)

                While LikeReader.Peek <> -1
                    LikeList.Add(LikeReader.ReadLine())
                End While

                LikeReader.Close()
                LikeReader.Dispose()

                If LikeList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    FoundString = LikeList(randomizer.Next(0, LikeList.Count))
                End If
                ShowGotImage()
            End If
            StringClean = StringClean.Replace("@ShowLikedImage", "")
        End If

        If StringClean.Contains("@ShowDislikedImage") Then
            If File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then
                Dim DislikeReader As New StreamReader(Application.StartupPath & "\Images\System\DislikedImageURLs.txt")
                Dim DislikeList As New List(Of String)

                While DislikeReader.Peek <> -1
                    DislikeList.Add(DislikeReader.ReadLine())
                End While

                DislikeReader.Close()
                DislikeReader.Dispose()

                If DislikeList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    FoundString = DislikeList(randomizer.Next(0, DislikeList.Count))
                End If
                ShowGotImage()
            End If
            StringClean = StringClean.Replace("@ShowDislikedImage", "")
        End If


        'If StringClean.Contains("@NullResponse") Then
        'NullResponse = True
        'StringClean = StringClean.Replace("@NullResponse", "")
        'End If

        '  ┌─┐╔╗╔┌─┐┬ ┬╔╗ ┬  ┌─┐┌─┐╦┌┬┐┌─┐┌─┐┌─┐
        '  │└┘║║║├┤ │││╠╩╗│  │ ││ ┬║│││├─┤│ ┬├┤ 
        '  └──╝╚╝└─┘└┴┘╚═╝┴─┘└─┘└─┘╩┴ ┴┴ ┴└─┘└─┘

        If StringClean.Contains("@NewBlogImage") Then
            GetBlogImage()
            StringClean = StringClean.Replace("@NewBlogImage", "")
            'Debug.Print("Is this being called?")
        End If

        If StringClean.Contains("@ShowBlogImage") Then
            GetBlogImage()
            StringClean = StringClean.Replace("@ShowBlogImage", "")
        End If

        If StringClean.Contains("@ShowLocalImage") Then
            GetLocalImage()
            StringClean = StringClean.Replace("@ShowLocalImage", "")
        End If

        If StringClean.Contains("@ShowImage[") Then
            Dim ImageClean As String = StringClean
            Dim StartIndex As Integer = ImageClean.IndexOf("@ShowImage[") + 11
            For i As Integer = 1 To StartIndex
                ImageClean = ImageClean.Remove(0, 1)
            Next
            Dim ImageS As String() = ImageClean.Split("]")
            ImageClean = Application.StartupPath & "\Images\" & ImageS(0)
            ImageClean = ImageClean.Replace("\\", "\")
            Try
                mainPictureBox.LoadFromUrl(ImageClean)
            Catch
                MessageBox.Show(Me, "\" & ImageS(0) & " was not found in " & Application.StartupPath & "\Images!" & Environment.NewLine & Environment.NewLine & "Please make sure the file exists and that it is spelled correctly in the script.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
            StringClean = StringClean.Replace("@ShowImage[" & ImageS(0) & "]", "")
            JustShowedBlogImage = True
        End If


        If StringClean.Contains("@ShowImage") Then
            TempVal = randomizer.Next(1, 101)
            If TempVal < 51 Then
                GetBlogImage()
            Else
                GetLocalImage()
            End If
            StringClean = StringClean.Replace("@ShowImage", "")
        End If

        Debug.Print("SubStroking = " & SubStroking)
        Debug.Print("SubEdging = " & SubEdging)
        Debug.Print("SubHoldingEdge = " & SubHoldingEdge)

        '  ╔═╗┌┬┐┬─┐┌─┐┬┌─┌─┐╔═╗┌─┐┌─┐┌┬┐┌─┐┬─┐
        '  ╚═╗ │ ├┬┘│ │├┴┐├┤ ╠╣ ├─┤└─┐ │ ├┤ ├┬┘
        '  ╚═╝ ┴ ┴└─└─┘┴ ┴└─┘╚  ┴ ┴└─┘ ┴ └─┘┴└─

        If StringClean.Contains("@StrokeFaster") Then
            If SubStroking = True And SubEdging = False And SubHoldingEdge = False Then
                Debug.Print("Stroke Faster")
                StrokePace = StrokePace - 10
                If StrokePace < 10 Then StrokePace = 10
                If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)
            End If
            StringClean = StringClean.Replace("@StrokeFaster", "")
        End If

        '  ╔═╗┌┬┐┬─┐┌─┐┬┌─┌─┐╔═╗┬  ┌─┐┬ ┬┌─┐┬─┐
        '  ╚═╗ │ ├┬┘│ │├┴┐├┤ ╚═╗│  │ ││││├┤ ├┬┘
        '  ╚═╝ ┴ ┴└─└─┘┴ ┴└─┘╚═╝┴─┘└─┘└┴┘└─┘┴└─

        If StringClean.Contains("@StrokeSlower") Then
            If SubStroking = True And SubEdging = False And SubHoldingEdge = False Then
                Debug.Print("Stroke Slower")
                StrokePace = StrokePace + 10
                If StrokePace > 100 Then StrokePace = 100
                If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)
            End If
            StringClean = StringClean.Replace("@StrokeSlower", "")
        End If

        '  ╔═╗┌┬┐┬─┐┌─┐┬┌─┌─┐╔═╗┌─┐┌─┐┌┬┐┌─┐┌─┐┌┬┐
        '  ╚═╗ │ ├┬┘│ │├┴┐├┤ ╠╣ ├─┤└─┐ │ ├┤ └─┐ │ 
        '  ╚═╝ ┴ ┴└─└─┘┴ ┴└─┘╚  ┴ ┴└─┘ ┴ └─┘└─┘ ┴ 

        If StringClean.Contains("@StrokeFastest") Then
            If SubStroking = True And SubEdging = False And SubHoldingEdge = False Then
                Debug.Print("Stroke Fastest")
                StrokePace = 10
                If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)
            End If
            StringClean = StringClean.Replace("@StrokeFastest", "")
        End If

        '  ╔═╗┌┬┐┬─┐┌─┐┬┌─┌─┐╔═╗┬  ┌─┐┬ ┬┌─┐┌─┐┌┬┐
        '  ╚═╗ │ ├┬┘│ │├┴┐├┤ ╚═╗│  │ ││││├┤ └─┐ │ 
        '  ╚═╝ ┴ ┴└─└─┘┴ ┴└─┘╚═╝┴─┘└─┘└┴┘└─┘└─┘ ┴ 

        If StringClean.Contains("@StrokeSlowest") Then
            If SubStroking = True And SubEdging = False And SubHoldingEdge = False Then
                Debug.Print("Stroke Slowest")
                StrokePace = 100
                If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)
            End If
            StringClean = StringClean.Replace("@StrokeSlowest", "")
        End If


        If StringClean.Contains("@StartStroking") Then
            If FrmSettings.TBWebStart.Text <> "" Then
                Try
                    FrmSettings.WebToy.Navigate(FrmSettings.TBWebStart.Text)
                Catch
                End Try
            End If
            AskedToGiveUpSection = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            BeforeTease = False
            SubStroking = True
            ShowModule = False
            'StrokeCycle = -1
            If StartStrokingCount = 0 Then FirstRound = True
            StartStrokingCount += 1
            StopMetronome = False
            StrokePace = randomizer.Next(3, 8) * 10
            If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)


            If FrmSettings.CBTauntCycleDD.Checked = True Then
                If FrmSettings.domlevelNumBox.Value = 1 Then StrokeTick = randomizer.Next(1, 3) * 60
                If FrmSettings.domlevelNumBox.Value = 2 Then StrokeTick = randomizer.Next(1, 4) * 60
                If FrmSettings.domlevelNumBox.Value = 3 Then StrokeTick = randomizer.Next(3, 6) * 60
                If FrmSettings.domlevelNumBox.Value = 4 Then StrokeTick = randomizer.Next(4, 8) * 60
                If FrmSettings.domlevelNumBox.Value = 5 Then StrokeTick = randomizer.Next(5, 11) * 60
            Else
                StrokeTick = randomizer.Next(FrmSettings.NBTauntCycleMin.Value * 60, FrmSettings.NBTauntCycleMax.Value * 60)
            End If



            StrokeTauntTick = randomizer.Next(11, 21)
            StrokeTimer.Start()
            StrokeTauntTimer.Start()
            StringClean = StringClean.Replace("@StartStroking", "")
        End If

        If StringClean.Contains("@StartTaunts") Then
            AskedToGiveUpSection = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            BeforeTease = False
            SubStroking = True
            ShowModule = False
            'StrokeCycle = -1
            If StartStrokingCount = 0 Then FirstRound = True
            StartStrokingCount += 1
            StrokePace = randomizer.Next(3, 8) * 10
            StrokePaceTimer.Interval = StrokePace
            StopMetronome = False
            If FrmSettings.CBTauntCycleDD.Checked = True Then
                If FrmSettings.domlevelNumBox.Value = 1 Then StrokeTick = randomizer.Next(1, 3) * 60
                If FrmSettings.domlevelNumBox.Value = 2 Then StrokeTick = randomizer.Next(1, 4) * 60
                If FrmSettings.domlevelNumBox.Value = 3 Then StrokeTick = randomizer.Next(3, 6) * 60
                If FrmSettings.domlevelNumBox.Value = 4 Then StrokeTick = randomizer.Next(4, 8) * 60
                If FrmSettings.domlevelNumBox.Value = 5 Then StrokeTick = randomizer.Next(5, 11) * 60
            Else
                StrokeTick = randomizer.Next(FrmSettings.NBTauntCycleMin.Value * 60, FrmSettings.NBTauntCycleMax.Value * 60)
            End If
            StrokeTauntTick = randomizer.Next(11, 21)
            StrokeTimer.Start()
            StrokeTauntTimer.Start()
            StringClean = StringClean.Replace("@StartTaunts", "")
        End If

        If StringClean.Contains("@StopStroking") Then
            If FrmSettings.TBWebStop.Text <> "" Then
                Try
                    FrmSettings.WebToy.Navigate(FrmSettings.TBWebStop.Text)
                Catch
                End Try
            End If
            AskedToSpeedUp = False
            AskedToSlowDown = False
            SubStroking = False
            SubEdging = False
            SubHoldingEdge = False
            StrokeTimer.Stop()
            StrokeTauntTimer.Stop()
            If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
            EdgeTauntTimer.Stop()
            HoldEdgeTauntTimer.Stop()
            StringClean = StringClean.Replace("@StopStroking", "")
        End If

        If StringClean.Contains("@StopTaunts") Then
            AskedToSpeedUp = False
            AskedToSlowDown = False
            SubStroking = False
            SubEdging = False
            SubHoldingEdge = False
            StrokeTimer.Stop()
            StrokeTauntTimer.Stop()
            EdgeTauntTimer.Stop()
            HoldEdgeTauntTimer.Stop()
            StringClean = StringClean.Replace("@StopTaunts", "")
        End If

        If StringClean.Contains("@EdgeToRuinNoHoldSecret") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeNoHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuin = True
            EdgeToRuinSecret = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuinNoHoldSecret", "")
        End If

        If StringClean.Contains("@EdgeToRuinHoldSecret") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuin = True
            EdgeToRuinSecret = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuinHoldSecret", "")
        End If

        If StringClean.Contains("@EdgeToRuinSecret") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuinSecret = True
            EdgeToRuin = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuinSecret", "")
        End If

        If StringClean.Contains("@EdgeToRuinNoHold") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeNoHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuin = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuinNoHold", "")
        End If

        If StringClean.Contains("@EdgeToRuinHold") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuin = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuinHold", "")
        End If

        If StringClean.Contains("@EdgeToRuin") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeToRuin = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeToRuin", "")
        End If

        If StringClean.Contains("@EdgeNoHold") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeNoHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeNoHold", "")
        End If

        If StringClean.Contains("@EdgeHold") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeHold = True
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@EdgeHold", "")
        End If

        If StringClean.Contains("@Edge") Then
            If SubStroking = True Then AlreadyStrokingEdge = True
            GetEdgeTickCheck()
            SubStroking = True
            LongEdge = False
            AskedToSpeedUp = False
            AskedToSlowDown = False
            EdgeCountTick = 0
            EdgeCountTimer.Start()
            SubEdging = True
            EdgeTauntInt = randomizer.Next(30, 46)
            EdgeTauntTimer.Start()
            If OrgasmAllowed = True Or OrgasmDenied = True Or OrgasmRuined = True Then OrgasmYesNo = True
            EdgePace()
            StringClean = StringClean.Replace("@Edge", "")
        End If

        If StringClean.Contains("@CBTBalls") Then
            If FrmSettings.CBCBTBalls.Checked = True Then
                CBTBallsActive = True
                CBTBallsFlag = True
            End If
            StringClean = StringClean.Replace("@CBTBalls", "")
        End If

        If StringClean.Contains("@CBTCock") Then
            If FrmSettings.CBCBTCock.Checked = True Then
                CBTCockActive = True
                CBTCockFlag = True
            End If
            StringClean = StringClean.Replace("@CBTCock", "")
        End If

        If StringClean.Contains("@CBT") And Not StringClean.Contains("@CBTLevel") Then

            If FrmSettings.CBCBTBalls.Checked = False And FrmSettings.CBCBTCock.Checked = True Then
                CBTCockFlag = True
                CBTCockActive = True
                GoTo CBTFinish
            End If

            If FrmSettings.CBCBTBalls.Checked = True And FrmSettings.CBCBTCock.Checked = False Then
                CBTBallsFlag = True
                CBTBallsActive = True
                GoTo CBTFinish
            End If

            If FrmSettings.CBCBTBalls.Checked = False And FrmSettings.CBCBTCock.Checked = False Then
                GoTo CBTFinish
            End If

            TempVal = randomizer.Next(1, 101)
            If TempVal > 50 Then
                CBTBallsFlag = True
                CBTBallsActive = True
            Else
                CBTCockFlag = True
                CBTCockActive = True
            End If

CBTFinish:

            StringClean = StringClean.Replace("@CBT", "")
        End If

        If StringClean.Contains("@DecideOrgasm") Then


            If FrmSettings.alloworgasmComboBox.Text = "Always Allows" And FrmSettings.ruinorgasmComboBox.Text = "Always Ruins" Then
                FileGoto = "Orgasm Ruin"
                OrgasmRuined = True
                GoTo OrgasmDecided
            End If

            Dim OrgasmInt As Integer = randomizer.Next(1, 101)
            'Debug.Print("OrgasmInt =" & OrgasmInt)
            Dim OrgasmThreshold As Integer

            If FrmSettings.alloworgasmComboBox.Text = "Never Allows" Then OrgasmThreshold = 0
            If FrmSettings.alloworgasmComboBox.Text = "Always Allows" Then OrgasmThreshold = 1000

            If FrmSettings.CBRangeOrgasm.Checked = True Then
                If FrmSettings.alloworgasmComboBox.Text = "Rarely Allows" Then OrgasmThreshold = 20
                If FrmSettings.alloworgasmComboBox.Text = "Sometimes Allows" Then OrgasmThreshold = 50
                If FrmSettings.alloworgasmComboBox.Text = "Often Allows" Then OrgasmThreshold = 75
            Else
                If FrmSettings.alloworgasmComboBox.Text = "Rarely Allows" Then OrgasmThreshold = FrmSettings.NBAllowRarely.Value
                If FrmSettings.alloworgasmComboBox.Text = "Sometimes Allows" Then OrgasmThreshold = FrmSettings.NBAllowSometimes.Value
                If FrmSettings.alloworgasmComboBox.Text = "Often Allows" Then OrgasmThreshold = FrmSettings.NBAllowOften.Value
            End If


            If OrgasmInt > OrgasmThreshold Then
                FileGoto = "Orgasm Deny"
                OrgasmDenied = True
                GoTo OrgasmDecided
            End If

            Dim RuinInt As Integer = randomizer.Next(1, 101)
            'Debug.Print("OrgasmInt =" & OrgasmInt)
            Dim RuinThreshold As Integer

            If FrmSettings.ruinorgasmComboBox.Text = "Never Ruins" Then RuinThreshold = 0
            If FrmSettings.ruinorgasmComboBox.Text = "Always Ruins" Then RuinThreshold = 1000


            If FrmSettings.CBRangeRuin.Checked = True Then
                If FrmSettings.ruinorgasmComboBox.Text = "Rarely Ruins" Then RuinThreshold = 20
                If FrmSettings.ruinorgasmComboBox.Text = "Sometimes Ruins" Then RuinThreshold = 50
                If FrmSettings.ruinorgasmComboBox.Text = "Often Ruins" Then RuinThreshold = 75
            Else
                If FrmSettings.ruinorgasmComboBox.Text = "Rarely Ruins" Then RuinThreshold = FrmSettings.NBRuinRarely.Value
                If FrmSettings.ruinorgasmComboBox.Text = "Sometimes Ruins" Then RuinThreshold = FrmSettings.NBRuinSometimes.Value
                If FrmSettings.ruinorgasmComboBox.Text = "Often Ruins" Then RuinThreshold = FrmSettings.NBRuinOften.Value
            End If


            If RuinInt > RuinThreshold Then
                FileGoto = "Orgasm Allow"
                OrgasmAllowed = True
            Else
                FileGoto = "Orgasm Ruin"
                OrgasmRuined = True
            End If

OrgasmDecided:

            SkipGotoLine = True
            GetGoto()

            StringClean = StringClean.Replace("@DecideOrgasm", "")
        End If


        If StringClean.Contains("@WritingTask") Then

            WritingTaskFlag = True




            ' Dim WTBuffer As String = StringClean & "Null"
            ''Debug.Print("WTBuffer = " & WTBuffer)

            'Dim WTTempString As String() = Split(WTBuffer, "@WritingTask(", 2)
            ''Debug.Print("WTTempString(1) = " & WTTempString(0))
            'Dim WTTemp As String() = Split(WTTempString(1), ")")
            ''Debug.Print("WTTemp(0) = " & WTTemp(0))
            'LBLWritingTaskText.Text = WTTemp(0)


            Dim WTTempString As String() = Split(StringClean, "@WritingTask(", 2)
            Dim WTTemp As String() = Split(WTTempString(1), ")")
            FrmWritingTask.LBLWritingTaskText.Text = WTTemp(0)

            Dim WritingTaskVal As Integer = Val(FrmWritingTask.LBLWritingTaskText.Text)
            'Debug.Print("WritingTaskVal = " & WritingTaskVal)

            If WritingTaskVal = 0 Then
                WritingTaskLinesAmount = randomizer.Next(FrmSettings.NBWritingTaskMin.Value, FrmSettings.NBWritingTaskMax.Value)
                WritingTaskLinesAmount = 5 * Math.Round(WritingTaskLinesAmount / 5)
            Else
                WritingTaskLinesAmount = WritingTaskVal
                FrmWritingTask.LBLWritingTaskText.Text = FrmWritingTask.LBLWritingTaskText.Text.Replace(WritingTaskVal, "")
            End If


            FrmWritingTask.LBLWritingTask.Text = "Write the following line " & WritingTaskLinesAmount & " times:"
            FrmWritingTask.LBLWritingTask.Text = FrmWritingTask.LBLWritingTaskText.Text.Replace("line 1 times", "line 1 time")
            FrmWritingTask.LBLLinesWritten.Text = "0"
            FrmWritingTask.LBLLinesRemaining.Text = WritingTaskLinesAmount


            ' Dim WTTempString As String() = Split(StringClean, "@WritingTask(", 2)
            ' Dim WTTemp As String() = Split(WTTempString(1), ")" 1)

            ' LBLWritingTaskText.Text = WTTemp(0)

            FrmWritingTask.Show()
            WritingTaskMistakesAllowed = randomizer.Next(3, 11)
            FrmWritingTask.LBLMistakesAllowed.Text = WritingTaskMistakesAllowed
            FrmWritingTask.LBLMistakesMade.Text = "0"
            StringClean = StringClean.Replace("@WritingTask", "")
            FrmWritingTask.LBLWritingTask.Text = "Write the following line " & WritingTaskLinesAmount & " times."
            WritingTaskLinesRemaining = WritingTaskLinesAmount
            WritingTaskLinesWritten = 0
            WritingTaskMistakesMade = 0
            chatBox.ShortcutsEnabled = False
        End If

        If StringClean.Contains("@CheckJOIVideo") Then

            If Directory.Exists(FrmSettings.LblVideoJOI.Text) Or Directory.Exists(FrmSettings.LblVideoJOID.Text) Then
                If FrmSettings.LblVideoJOITotal.Text <> "0" Or FrmSettings.LblVideoJOITotalD.Text <> "0" Then
                Else
                    SkipGotoLine = True
                    FileGoto = "No JOI Found"
                    GetGoto()
                End If
            Else
                SkipGotoLine = True
                FileGoto = "No JOI Found"
                GetGoto()
            End If

            StringClean = StringClean.Replace("@CheckJOIVideo", "")

        End If


        If StringClean.Contains("@PlayJOIVideo") Then

            If Directory.Exists(FrmSettings.LblVideoJOI.Text) Or Directory.Exists(FrmSettings.LblVideoJOID.Text) Then

                TeaseVideo = True
                PlayRandomJOI()
            End If

            StringClean = StringClean.Replace("@PlayJOIVideo", "")

        End If

        If StringClean.Contains("@PlayCHVideo") Then

            If Directory.Exists(FrmSettings.LblVideoCH.Text) Or Directory.Exists(FrmSettings.LblVideoCH.Text) Then

                TeaseVideo = True
                PlayRandomCH()
            End If

            StringClean = StringClean.Replace("@PlayCHVideo", "")

        End If





        If StringClean.Contains("@TnAFastSlides") Or StringClean.Contains("@TnASlowSlides") Or StringClean.Contains("@TnASlides") Then

            ' FrmSettings.offRadio.Checked = True
            TnAList.Clear()

            If StringClean.Contains("@TnAFastSlides") Then TnASlides.Interval = 334
            If StringClean.Contains("@TnASlides") Then TnASlides.Interval = 1000
            If StringClean.Contains("@TnASlowSlides") Then TnASlides.Interval = 5000


            'Debug.Print("TNAFASTSLIDES CALLED")

            GetTnAList()

            'Debug.Print("TNALIST.COUNT = " & TnAList.Count)

            'Debug.Print("CALLING TNAFASTLIDES.START")
            TnASlides.Start()
            StringClean = StringClean.Replace("@TnAFastSlides", "")
            StringClean = StringClean.Replace("@TnASlowSlides", "")
            StringClean = StringClean.Replace("@TnASlides", "")
        End If

        If StringClean.Contains("@CheckTnA") Then
            TnASlides.Stop()

            'Debug.Print("@CheckTnA called ::: AssImage = " & AssImage & " ::: BoobImage = " & BoobImage)
            If AssImage = True Then FileGoto = "(Butt)"
            If BoobImage = True Then FileGoto = "(Boobs)"
            SkipGotoLine = True
            GetGoto()
            StringClean = StringClean.Replace("@CheckTnA", "")
        End If

        If StringClean.Contains("@StopTnA") Then
            TnASlides.Stop()
            StringClean = StringClean.Replace("@StopTnA", "")
        End If


        If StringClean.Contains("@SetVar") Then

            Do

                Dim SCSetVar As String() = Split(StringClean)
                Dim SCGotVar As String = "Null"

                For i As Integer = 0 To SCSetVar.Length - 1
                    If SCSetVar(i).Contains("@SetVar") Then
                        'Debug.Print("@SetVar SCSetVar(i) = " & SCSetVar(i))
                        SCGotVar = SCSetVar(i)
                        SCSetVar(i) = ""
                        StringClean = Join(SCSetVar)
                        'Debug.Print("@SetVar SCSetVar Joined StringClean = " & StringClean)
                        Exit For
                    End If
                Next

                SCGotVar = SCGotVar.Replace("@SetVar[", "")

                Dim SCGotVarSplit As String() = Split(SCGotVar, "]")

                Dim VarName As String = SCGotVarSplit(0)
                'Debug.Print("@SetVar VarName = " & VarName)

                SCGotVarSplit(0) = ""

                SCGotVar = Join(SCGotVarSplit)
                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                SCGotVar = SCGotVar.Replace("=[", "")
                SCGotVar = SCGotVar.Replace(" ", "")

                Dim VarValue As Integer = Val(SCGotVar)

                If SCGotVar = "RAND5" Then VarValue = randomizer.Next(1, 6)
                If SCGotVar = "RAND10" Then VarValue = randomizer.Next(1, 11)
                If SCGotVar = "RAND50" Then VarValue = randomizer.Next(1, 51)
                If SCGotVar = "RAND100" Then VarValue = randomizer.Next(1, 101)
                If SCGotVar = "RAND1000" Then VarValue = randomizer.Next(1, 1001)

                If VarValue = 0 And SCGotVar <> "0" Then

                    Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVar
                    'Debug.Print("VarCheck = " & VarCheck)

                    If File.Exists(VarCheck) Then

                        'Debug.Print("VarCheck Exists")

                        Dim VarReader As New StreamReader(VarCheck)
                        VarValue = Val(VarReader.ReadLine())

                        VarReader.Close()
                        VarReader.Dispose()

                    End If

                End If

                'Debug.Print("@SetVar VarValue = " & VarValue)

                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & VarName, VarValue, False)

            Loop Until Not StringClean.Contains("@SetVar")

        End If




        If StringClean.Contains("@ChangeVar") Then

            Do

                Dim SCChangeVar As String() = Split(StringClean)
                Dim SCGotVar As String = "Null"

                For i As Integer = 0 To SCChangeVar.Length - 1
                    If SCChangeVar(i).Contains("@ChangeVar") Then
                        'Debug.Print("@SetVar SCSetVar(i) = " & SCChangeVar(i))
                        SCGotVar = SCChangeVar(i)
                        SCChangeVar(i) = ""
                        StringClean = Join(SCChangeVar)
                        'Debug.Print("@SetVar SCSetVar Joined StringClean = " & StringClean)
                        Exit For
                    End If
                Next

                SCGotVar = SCGotVar.Replace("@ChangeVar[", "")
                Dim SCGotVarSplit As String() = Split(SCGotVar, "]", 2)

                Dim VarName As String = SCGotVarSplit(0)
                VarName = VarName.Replace(" ", "")
                'Debug.Print("@SetVar VarName = " & VarName)
                SCGotVarSplit(0) = ""

                SCGotVar = Join(SCGotVarSplit)
                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                SCGotVar = SCGotVar.Replace("=[", "")

                SCGotVarSplit = Split(SCGotVar, "]", 2)
                SCGotVarSplit(0) = SCGotVarSplit(0).Replace(" ", "")
                Dim Val1 As Integer = Val(SCGotVarSplit(0))

                If Val1 = 0 And SCGotVarSplit(0) <> "0" Then
                    Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVarSplit(0)
                    'Debug.Print("VarCheck = " & VarCheck)
                    If File.Exists(VarCheck) Then
                        'Debug.Print("VarCheck Exists")
                        Dim VarReader As New StreamReader(VarCheck)
                        Val1 = Val(VarReader.ReadLine())
                        VarReader.Close()
                        VarReader.Dispose()
                    End If
                End If

                'Debug.Print("@SetVar VarDifference = " & Val1)

                'Debug.Print("@SetVar VarName2 = " & Val1)

                SCGotVarSplit(0) = ""

                SCGotVar = Join(SCGotVarSplit)
                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                SCGotVar = SCGotVar.Replace(" ", "")

                ScriptOperator = "Null"
                If SCGotVar.Substring(0, 1) = "+" Then ScriptOperator = "Add"
                If SCGotVar.Substring(0, 1) = "-" Then ScriptOperator = "Subtract"
                If SCGotVar.Substring(0, 1) = "*" Then ScriptOperator = "Multiply"
                If SCGotVar.Substring(0, 1) = "/" Then ScriptOperator = "Divide"

                'Debug.Print("ScriptOperator = " & ScriptOperator)

                SCGotVar = SCGotVar.Remove(0, 2)
                SCGotVar = SCGotVar.Replace("]", "")

                'Debug.Print("SCGotVar = " & SCGotVar)

                Dim Val2 As Integer = Val(SCGotVar)

                If Val2 = 0 And SCGotVar <> "0" Then
                    Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVar
                    'Debug.Print("VarCheck = " & VarCheck)
                    If File.Exists(VarCheck) Then
                        'Debug.Print("VarCheck Exists")
                        Dim VarReader As New StreamReader(VarCheck)
                        Val2 = Val(VarReader.ReadLine())
                        VarReader.Close()
                        VarReader.Dispose()
                    End If
                End If

                'Debug.Print("@SetVar VarDifference = " & Val2)

                Dim ChangeVal As Integer = 0

                If ScriptOperator = "Add" Then ChangeVal = Val1 + Val2
                If ScriptOperator = "Subtract" Then ChangeVal = Val1 - Val2
                If ScriptOperator = "Multiply" Then ChangeVal = Val1 * Val2
                If ScriptOperator = "Divide" Then ChangeVal = Val1 / Val2

                'Debug.Print("ChangeVal = " & ChangeVal)

                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & VarName, ChangeVal, False)


            Loop Until Not StringClean.Contains("@ChangeVar")



        End If


        If StringClean.Contains("@If[") Then

            Do

                Dim SCIfVar As String() = Split(StringClean)
                Dim SCGotVar As String = "Null"

                For i As Integer = 0 To SCIfVar.Length - 1
                    If SCIfVar(i).Contains("@If[") Then
                        'Debug.Print("@SetVar SCSetVar(i) = " & SCIfVar(i))
                        Dim IFJoin As Integer = 0
                        If Not SCIfVar(i).Contains(")") Then
                            Do
                                IFJoin += 1
                                SCIfVar(i) = SCIfVar(i) & " " & SCIfVar(i + IFJoin)
                                SCIfVar(i + IFJoin) = ""
                            Loop Until SCIfVar(i).Contains(")")
                        End If
                        SCGotVar = SCIfVar(i)
                        SCIfVar(i) = ""
                        StringClean = Join(SCIfVar)
                        Do
                            StringClean = StringClean.Replace("  ", " ")
                        Loop Until Not StringClean.Contains("  ")
                        'Debug.Print("@SetVar SCSetVar Joined StringClean = " & StringClean)
                        Exit For
                    End If
                Next

                SCGotVar = SCGotVar.Replace("@If[", "")
                Dim SCGotVarSplit As String() = Split(SCGotVar, "]", 2)

                Dim Val1 As Integer = Val(SCGotVarSplit(0))
                ' Val1 = VarName.Replace(" ", "")

                If Val1 = 0 And SCGotVarSplit(0) <> "0" Then
                    Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVarSplit(0)
                    'Debug.Print("VarCheck = " & VarCheck)
                    If File.Exists(VarCheck) Then
                        'Debug.Print("VarCheck Exists")
                        Dim VarReader As New StreamReader(VarCheck)
                        Val1 = Val(VarReader.ReadLine())
                        VarReader.Close()
                        VarReader.Dispose()
                    End If
                End If

                'Debug.Print("@SetVar VarDifference = " & Val1)

                'Debug.Print("@SetVar Val = " & Val1)
                SCGotVarSplit(0) = ""

                SCGotVar = Join(SCGotVarSplit)
                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                SCGotVarSplit = Split(SCGotVar, "[", 2)
                SCGotVarSplit(0) = SCGotVarSplit(0).Replace(" ", "")
                'Debug.Print("@SetVar SCGotVarSplit = " & SCGotVarSplit(0))

                ScriptCompare = "Null"

                If SCGotVarSplit(0) = "=" Or SCGotVarSplit(0) = "==" Then ScriptCompare = "="
                If SCGotVarSplit(0) = "<>" Then ScriptCompare = "<>"
                If SCGotVarSplit(0) = ">" Then ScriptCompare = ">"
                If SCGotVarSplit(0) = "<" Then ScriptCompare = "<"
                If SCGotVarSplit(0) = ">=" Then ScriptCompare = ">="
                If SCGotVarSplit(0) = "<=" Then ScriptCompare = "<="

                'Debug.Print("Script Compare = " & ScriptCompare)

                SCGotVarSplit(0) = ""

                SCGotVar = Join(SCGotVarSplit)
                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                Do Until SCGotVar.Substring(0, 1) <> " "
                    SCGotVar = SCGotVar.Remove(0, 1)
                Loop

                'Debug.Print("@SetVar SCGotVar = " & SCGotVar)

                SCGotVarSplit = Split(SCGotVar, "]", 2)
                SCGotVarSplit(0) = SCGotVarSplit(0).Replace(" ", "")
                'Debug.Print("@SetVar SCGotVarSplit(0) = " & SCGotVarSplit(0))
                SCGotVarSplit(1) = SCGotVarSplit(1).Replace("Then", "")
                'Debug.Print("@SetVar SCGotVarSplit(1) = " & SCGotVarSplit(1))

                Dim Val2 As Integer = Val(SCGotVarSplit(0))

                If Val2 = 0 And SCGotVarSplit(0) <> "0" Then
                    Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVarSplit(0)
                    'Debug.Print("VarCheck = " & VarCheck)
                    If File.Exists(VarCheck) Then
                        'Debug.Print("VarCheck Exists")
                        Dim VarReader As New StreamReader(VarCheck)
                        Val2 = Val(VarReader.ReadLine())
                        VarReader.Close()
                        VarReader.Dispose()
                    End If
                End If

                'Debug.Print("@SetVar Val2 = " & Val2)

                Dim CompareCheck As String = "Null"

                If ScriptCompare = "=" Then
                    If Val1 = Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                If ScriptCompare = "<>" Then
                    If Val1 <> Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                If ScriptCompare = ">" Then
                    If Val1 > Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                If ScriptCompare = "<" Then
                    If Val1 < Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                If ScriptCompare = ">=" Then
                    If Val1 >= Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                If ScriptCompare = "<=" Then
                    If Val1 <= Val2 Then CompareCheck = SCGotVarSplit(1)
                End If

                'Debug.Print("CompareCheck = " & CompareCheck)

                If CompareCheck <> "Null" Then
                    FileGoto = CompareCheck
                    SkipGotoLine = True
                    GetGoto()
                End If

            Loop Until Not StringClean.Contains("@If")

        End If

        If StringClean.Contains("@ShowVar") Then

            Do

                Dim SCShowVar As String() = Split(StringClean)
                Dim SCGotVar As String = "Null"

                For i As Integer = 0 To SCShowVar.Length - 1
                    If SCShowVar(i).Contains("@ShowVar") Then
                        'Debug.Print("@SetVar SCSetVar(i) = " & SCShowVar(i))
                        SCGotVar = SCShowVar(i)
                        SCGotVar = SCGotVar.Replace("@ShowVar[", "")
                        SCGotVar = SCGotVar.Replace("]", "")
                        Dim VarValue As Integer = 0
                        Dim VarCheck As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Variables\" & SCGotVar
                        'Debug.Print("VarCheck = " & VarCheck)
                        If File.Exists(VarCheck) Then
                            'Debug.Print("VarCheck Exists")
                            Dim VarReader As New StreamReader(VarCheck)
                            VarValue = Val(VarReader.ReadLine())
                            VarReader.Close()
                            VarReader.Dispose()
                        Else
                            VarValue = 0
                        End If
                        SCShowVar(i) = VarValue.ToString()

                        StringClean = Join(SCShowVar)
                        'Debug.Print("@SetVar SCSetVar Joined StringClean = " & StringClean)
                        Exit For
                    End If
                Next

            Loop Until Not StringClean.Contains("@ShowVar")

        End If


        If StringClean.Contains("@GotoDommeOrgasm") Then

            'Debug.Print("GotoDommeOrgasmCalled")


            If FrmSettings.alloworgasmComboBox.Text = "Never Allows" Then FileGoto = "(Never Allows)"
            If FrmSettings.alloworgasmComboBox.Text = "Rarely Allows" Then FileGoto = "(Rarely Allows)"
            If FrmSettings.alloworgasmComboBox.Text = "Sometimes Allows" Then FileGoto = "(Sometimes Allows)"
            If FrmSettings.alloworgasmComboBox.Text = "Often Allows" Then FileGoto = "(Often Allows)"
            If FrmSettings.alloworgasmComboBox.Text = "Always Allows" Then FileGoto = "(Always Allows)"

            'Debug.Print(FileGoto)

            SkipGotoLine = True
            GetGoto()

            StringClean = StringClean.Replace("@GotoDommeOrgasm", "")

        End If

        If StringClean.Contains("@GotoDommeRuin") Then

            'Debug.Print("GotoDommeOrgasmCalled")


            If FrmSettings.ruinorgasmComboBox.Text = "Never Ruins" Then FileGoto = "(Never Ruins)"
            If FrmSettings.ruinorgasmComboBox.Text = "Rarely Ruins" Then FileGoto = "(Rarely Ruins)"
            If FrmSettings.ruinorgasmComboBox.Text = "Sometimes Ruins" Then FileGoto = "(Sometimes Ruins)"
            If FrmSettings.ruinorgasmComboBox.Text = "Often Ruins" Then FileGoto = "(Often Ruins)"
            If FrmSettings.ruinorgasmComboBox.Text = "Always Ruins" Then FileGoto = "(Always Ruins)"

            'Debug.Print(FileGoto)

            SkipGotoLine = True

            StringClean = StringClean.Replace("@GotoDommeRuin", "")

        End If

        If StringClean.Contains("@GotoDommeApathy") Then

            'Debug.Print("GotoDommeApathyCalled")


            If FrmSettings.NBEmpathy.Value = 1 Then FileGoto = "(ApathyLevel1)"
            If FrmSettings.NBEmpathy.Value = 2 Then FileGoto = "(ApathyLevel2)"
            If FrmSettings.NBEmpathy.Value = 3 Then FileGoto = "(ApathyLevel3)"
            If FrmSettings.NBEmpathy.Value = 4 Then FileGoto = "(ApathyLevel4)"
            If FrmSettings.NBEmpathy.Value = 5 Then FileGoto = "(ApathyLevel5)"

            'Debug.Print(FileGoto)

            SkipGotoLine = True
            GetGoto()

            StringClean = StringClean.Replace("@GotoDommeApathy", "")

        End If

        If StringClean.Contains("@GotoDommeLevel") Then




            If FrmSettings.domlevelNumBox.Value = 1 Then FileGoto = "(DommeLevel1)"
            If FrmSettings.domlevelNumBox.Value = 2 Then FileGoto = "(DommeLevel2)"
            If FrmSettings.domlevelNumBox.Value = 3 Then FileGoto = "(DommeLevel3)"
            If FrmSettings.domlevelNumBox.Value = 4 Then FileGoto = "(DommeLevel4)"
            If FrmSettings.domlevelNumBox.Value = 5 Then FileGoto = "(DommeLevel5)"

            'Debug.Print(FileGoto)

            SkipGotoLine = True
            GetGoto()

            StringClean = StringClean.Replace("@GotoDommeLevel", "")

        End If


        If StringClean.Contains("@CheckBnB") Then
            If FrmSettings.CBEnableBnB.Checked = False Then
                FileGoto = "(No BnB)"
                SkipGotoLine = True
                GetGoto()
            End If
            StringClean = StringClean.Replace("@CheckBnB", "")
        End If


        If StringClean.Contains("@GiveUpCheck") Then


            If AskedToGiveUpSection = True Then

                If SubGaveUp = True Then
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\GiveUpREHASH.txt"
                Else
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\GiveUpREPEAT.txt"
                End If
                StringClean = ResponseClean(StringClean)

            Else

                AskedToGiveUpSection = True
                AskedToGiveUp = True

                Dim GiveUpCheck As Integer

                If FrmSettings.NBEmpathy.Value = 1 Then GiveUpCheck = 0
                If FrmSettings.NBEmpathy.Value = 2 Then GiveUpCheck = 25
                If FrmSettings.NBEmpathy.Value = 3 Then GiveUpCheck = 50
                If FrmSettings.NBEmpathy.Value = 4 Then GiveUpCheck = 75
                If FrmSettings.NBEmpathy.Value = 5 Then GiveUpCheck = 1000

                Dim GiveUpVal As Integer = randomizer.Next(1, 101)

                If GiveUpVal > GiveUpCheck Then
                    ' you can give up
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\GiveUpALLOWED.txt"
                    SubGaveUp = True
                    FirstRound = False
                Else
                    ' you can't give up
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\GiveUpDENIED.txt"
                End If

                StringClean = ResponseClean(StringClean)

            End If


        End If




        If StringClean.Contains("@EndTease") Then
            TeaseOver = True
            SaidHello = False
            StringClean = StringClean.Replace("@EndTease", "")
        End If

        If StringClean.Contains("@FinishTease") Then
            TeaseTick = 0
            StringClean = StringClean.Replace("@FinishTease", "")
        End If

        If StringClean.Contains("@ShowButtImage") Then
            JustShowedBlogImage = True
            GetTnAList()
            mainPictureBox.LoadFromUrl(AssList(randomizer.Next(0, AssList.Count)))
            ShowImageInfo()
            StringClean = StringClean.Replace("@ShowButtImage", "")
        End If

        If StringClean.Contains("@ShowBoobsImage") Then
            JustShowedBlogImage = True
            GetTnAList()
            mainPictureBox.LoadFromUrl(BoobList(randomizer.Next(0, BoobList.Count)))
            ShowImageInfo()
            StringClean = StringClean.Replace("@ShowBoobsImage", "")
        End If

        If StringClean.Contains("@DommeLevelDown") Then
            If FrmSettings.domlevelNumBox.Value > 1 Then
                FrmSettings.domlevelNumBox.Value -= 1
            End If
            StringClean = StringClean.Replace("@DommeLevelDown", "")
        End If

        If StringClean.Contains("@DommeLevelUp") Then
            If FrmSettings.domlevelNumBox.Value < 5 Then
                FrmSettings.domlevelNumBox.Value += 1
            End If
            StringClean = StringClean.Replace("@DommeLevelUp", "")
        End If

        If StringClean.Contains("@ShowHardcoreImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIHardcoreSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIHardcore.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIHardcore.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowHardcoreImage", "")
        End If

        If StringClean.Contains("@ShowSoftcoreImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBISoftcoreSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLISoftcore.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLISoftcore.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowSoftcoreImage", "")
        End If

        If StringClean.Contains("@ShowLesbianImage") Then
            'Debug.Print("Show Lesbian Image Called")
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBILesbianSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLILesbian.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLILesbian.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowLesbianImage", "")
        End If

        If StringClean.Contains("@ShowBlowjobImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIBlowjobSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIBlowjob.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIBlowjob.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowBlowjobImage", "")
        End If

        If StringClean.Contains("@ShowFemdomImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIFemdomSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIFemdom.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIFemdom.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowFemdomImage", "")
        End If

        If StringClean.Contains("@ShowLezdomImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBILezdomSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLILezdom.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLILezdom.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowLezdomImage", "")
        End If

        If StringClean.Contains("@ShowHentaiImage") Then
            'Debug.Print("Show Hentai Image Called")
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIHentaiSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIHentai.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIHentai.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowHentaiImage", "")
        End If

        If StringClean.Contains("@ShowGayImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIGaySD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIGay.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIGay.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowGayImage", "")
        End If

        If StringClean.Contains("@ShowMaledomImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIMaledomSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIMaledom.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIMaledom.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowMaledomImage", "")
        End If

        If StringClean.Contains("@ShowCaptionsImage") Then
            'Debug.Print("Show Captions Image Called")
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBICaptionsSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLICaptions.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLICaptions.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowCaptionsImage", "")
        End If

        If StringClean.Contains("@ShowGeneralImage") Then
            Dim PornList As New List(Of String)
            PornList.Clear()
            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            Dim files As String()
            Try
                If FrmSettings.CBIGeneralSD.Checked = True Then
                    files = Directory.GetFiles(FrmSettings.LBLIGeneral.Text, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(FrmSettings.LBLIGeneral.Text, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        PornList.Add(fi)
                    End If
                Next

                If PornList.Count = 0 Then
                    FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
                Else
                    Do
                        FoundString = PornList(randomizer.Next(0, PornList.Count))
                    Loop Until FoundString <> ""
                End If
            Catch
                FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
            End Try
            ShowGotImage()
            StringClean = StringClean.Replace("@ShowGeneralImage", "")
        End If


        If StringClean.Contains("@CheckStrokingState") Then
            If SubStroking = True Then
                FileGoto = "(Sub Stroking)"
            Else
                FileGoto = "(Sub Not Stroking)"
            End If
            SkipGotoLine = True
            GetGoto()
            StringClean = StringClean.Replace("@CheckStrokingState", "")
        End If




        If StringClean.Contains("@InterruptLongEdge") Then

            Dim EdgeList As New List(Of String)

            For Each EdgeFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Long Edge\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                'Debug.Print("EdgeFile = " & EdgeFile)
                EdgeList.Add(EdgeFile)
            Next

            'Debug.Print("EdgeList.Count = " & EdgeList.Count)

            If EdgeList.Count > 0 Then

                SubEdging = False
                SubHoldingEdge = False
                EdgeTauntTimer.Stop()
                StrokeTimer.Stop()
                StrokeTauntTimer.Stop()
                FileText = EdgeList(randomizer.Next(0, EdgeList.Count))
                LockImage = False
                StrokeTauntVal = -1
                ScriptTick = 3
                ScriptTimer.Start()
                ShowModule = True

            Else
                MessageBox.Show(Me, "No files were found in " & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Long Edge!" & Environment.NewLine _
                                & Environment.NewLine & "Please make sure at lease one LongEdge_ file exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            StringClean = StringClean.Replace("@InterruptLongEdge", "")
            JustShowedBlogImage = True
        End If

        If StringClean.Contains("@InterruptStartStroking") Then

            If CensorshipGame = True Or AvoidTheEdgeGame = True Or RLGLGame = True Then
                StringClean = "Ask me later"
                GoTo VTSkip
            End If

            Dim StrokeList As New List(Of String)

            For Each StrokeFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Start Stroking\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                'Debug.Print("EdgeFile = " & EdgeFile)
                StrokeList.Add(StrokeFile)
            Next

            'Debug.Print("EdgeList.Count = " & EdgeList.Count)

            If StrokeList.Count > 0 Then

                SubEdging = False
                SubHoldingEdge = False
                EdgeTauntTimer.Stop()
                StrokeTimer.Stop()
                StrokeTauntTimer.Stop()
                FileText = StrokeList(randomizer.Next(0, StrokeList.Count))
                LockImage = False
                StrokeTauntVal = -1
                ScriptTick = 3
                ScriptTimer.Start()
                ShowModule = True

            Else
                MessageBox.Show(Me, "No files were found in " & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Start Stroking!" & Environment.NewLine _
                                & Environment.NewLine & "Please make sure at lease one StartStroking_ file exists.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            StringClean = StringClean.Replace("@InterruptStartStroking", "")
            JustShowedBlogImage = True
        End If

        If StringClean.Contains("@Interrupt(") Then
            Dim InterruptClean As String = StringClean
            Dim StartIndex As Integer = InterruptClean.IndexOf("@Interrupt(") + 11
            For i As Integer = 1 To StartIndex
                InterruptClean = InterruptClean.Remove(0, 1)
            Next
            Dim InterruptS As String() = InterruptClean.Split(")")
            InterruptClean = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\" & InterruptS(0) & ".txt"

            If File.Exists(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\" & InterruptS(0) & ".txt") Then
                SubEdging = False
                SubHoldingEdge = False
                StrokeTimer.Stop()
                StrokeTauntTimer.Stop()

                CensorshipTimer.Stop()
                RLGLTimer.Stop()
                TnASlides.Stop()
                AvoidTheEdge.Stop()
                EdgeTauntTimer.Stop()
                HoldEdgeTimer.Stop()
                HoldEdgeTauntTimer.Stop()
                AvoidTheEdgeTaunts.Stop()
                RLGLTauntTimer.Stop()
                VideoTauntTimer.Stop()
                EdgeCountTimer.Stop()

                FileText = InterruptClean
                LockImage = False
                StrokeTauntVal = -1
                ScriptTick = 3
                ScriptTimer.Start()
                ShowModule = True

            Else
                MessageBox.Show(Me, InterruptS(0) & ".txt was not found in " & Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt!" & Environment.NewLine _
                                & Environment.NewLine & "Please make sure the file exists and that it is spelled correctly in the script.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            StringClean = StringClean.Replace("@Interrupt(" & InterruptS(0) & ")", "")
            'Debug.Print("StringClean INterrupt Remove = " & "@Interrupt(" & InterruptS(0) & ")")
            JustShowedBlogImage = True
        End If

        If StringClean.Contains("@BookmarkModule") Then
            BookmarkModule = True
            BookmarkModuleFile = FileText
            BookmarkModuleLine = StrokeTauntVal + 1
            StringClean = StringClean.Replace("@BookmarkModule", "")
        End If

        If StringClean.Contains("@BookmarkLink") Then
            BookmarkLink = True
            BookmarkLinkFile = FileText
            BookmarkLinkLine = StrokeTauntVal + 1
            StringClean = StringClean.Replace("@BookmarkLink", "")
        End If

        If StringClean.Contains("@AFKOn") Then
            AFK = True
            StringClean = StringClean.Replace("@AFKOn", "")
        End If

        If StringClean.Contains("@AFKOff") Then
            AFK = False
            StringClean = StringClean.Replace("@AFKOff", "")
        End If

        If StringClean.Contains("@Wait(") Then
            Dim WaitAmount As String() = Split(StringClean)
            For i As Integer = 0 To WaitAmount.Length - 1
                If WaitAmount(i).Contains("@Wait(") Then
                    Dim WaitInt As String = WaitAmount(i)
                    WaitInt = WaitInt.Replace("@Wait(", "")
                    WaitInt = WaitInt.Replace(")", "")
                    WaitTick = Val(WaitInt)
                    'Debug.Print("WaitTick = " & WaitTick)
                    WaitTimer.Start()
                    StringClean = StringClean.Replace(WaitAmount(i), "")
                End If
            Next
        End If



        If StringClean.Contains("@ShowTaggedImage") Then

            'Debug.Print("ShowTaggedImage StringClean ^^^^^^^^^^^^^^^^^^^^^^ = " & StringClean)

            If File.Exists(Application.StartupPath & "\Images\System\LocalImageTags.txt") Then
                Dim LocalReader As New StreamReader(Application.StartupPath & "\Images\System\LocalImageTags.txt")
                While LocalReader.Peek <> -1
                    LocalTagImageList.Add(LocalReader.ReadLine())
                End While
                LocalReader.Close()
                LocalReader.Dispose()

                For i As Integer = LocalTagImageList.Count - 1 To 0 Step -1
                    If LocalTagImageList(i) = "" Or LocalTagImageList(i) Is Nothing Then LocalTagImageList.RemoveAt(i)
                Next
            End If


            If StringClean.Contains("@Tag") Then
                Dim TSplit As String() = Split(StringClean)
                For i As Integer = 0 To TSplit.Length - 1
                    If TSplit(i).Contains("@Tag") Then
                        Dim TString As String = TSplit(i).Replace("@Tag", "")
                        For j As Integer = LocalTagImageList.Count - 1 To 0 Step -1
                            If Not LocalTagImageList(j).Contains(TString) Then LocalTagImageList.RemoveAt(j)
                        Next
                    End If
                Next
            End If

            For i As Integer = 0 To LocalTagImageList.Count - 1
                'Debug.Print(i & ". " & LocalTagImageList(i))
            Next

            Dim TagSplit As String() = Split(LocalTagImageList(randomizer.Next(0, LocalTagImageList.Count)))
            FoundString = TagSplit(0) & " "

            If Not FoundString.Contains(".jpg ") Or Not FoundString.Contains(".jpeg ") Or Not FoundString.Contains(".png ") Or Not FoundString.Contains(".bmp ") Or Not FoundString.Contains(".gif ") Then
                Dim FSLoop As Integer = 1
                Do Until FoundString.Contains(".jpg ") Or FoundString.Contains(".jpeg ") Or FoundString.Contains(".png ") Or FoundString.Contains(".bmp ") Or FoundString.Contains(".gif ")
                    FoundString = FoundString & TagSplit(FSLoop) & " "
                    FSLoop += 1
                Loop
            End If

            JustShowedBlogImage = True


            mainPictureBox.LoadFromUrl(FoundString)
            ShowImageInfo()


            ShowImageInfo()
            StringClean = StringClean.Replace("@ShowTaggedImage", "")

        End If

        If StringClean.Contains("@SendDailyTasks") Then
            CreateTaskLetter()
            StringClean = StringClean.Replace("@SendDailyTasks", "")
        End If

        If StringClean.Contains("@EdgingHold") Then

            DomTypeCheck = True
            SubEdging = False
            SubStroking = False
            SubHoldingEdge = True
            EdgeTauntTimer.Stop()
            If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
            DomChat = "#HoldTheEdge"
            TypingDelay()

            HoldEdgeTick = HoldEdgeChance

            If FrmSettings.NBHoldTheEdgeMax.Value = 0 Then

                If FrmSettings.domlevelNumBox.Value = 1 Then HoldEdgeTick = randomizer.Next(10, 31)
                If FrmSettings.domlevelNumBox.Value = 2 Then HoldEdgeTick = randomizer.Next(15, 46)
                If FrmSettings.domlevelNumBox.Value = 3 Then HoldEdgeTick = randomizer.Next(20, 61)
                If FrmSettings.domlevelNumBox.Value = 4 Then HoldEdgeTick = randomizer.Next(45, 121)
                If FrmSettings.domlevelNumBox.Value = 5 Then HoldEdgeTick = randomizer.Next(60, 301)

                If FrmSettings.domlevelNumBox.Value >= 3 And FrmSettings.crazyCheckBox.Checked = True Then
                    TempVal = randomizer.Next(1, 101)
                    If TempVal < 21 Then HoldEdgeTick *= 2
                End If

            Else

                Dim HoldEdgeMin As Integer = 30
                If FrmSettings.NBHoldTheEdgeMax.Value < 31 Then HoldEdgeMin = FrmSettings.NBHoldTheEdgeMax.Value / 2
                HoldEdgeTick = randomizer.Next(HoldEdgeMin, FrmSettings.NBHoldTheEdgeMax.Value + 1)
                If HoldEdgeTick < 10 Then HoldEdgeTick = 10

            End If

            HoldEdgeTime = 0

            HoldEdgeTimer.Start()
            HoldEdgeTauntTimer.Start()

            Do
                Application.DoEvents()
            Loop Until DomTypeCheck = False


            StringClean = StringClean.Replace("@EdgingHold", "")
        End If

        If StringClean.Contains("@EdgingStop") Then

            DomTypeCheck = True
            SubEdging = False
            SubStroking = False
            EdgeTauntTimer.Stop()
            DomChat = "#StopStrokingEdge"
            TypingDelay()

            Do
                Application.DoEvents()
            Loop Until DomTypeCheck = False

            StringClean = StringClean.Replace("@EdgingStop", "")
        End If

        If StringClean.Contains("@EdgingDecide") Then

            TempVal = randomizer.Next(0, 101)

            If TempVal < 51 Then

                DomTypeCheck = True
                SubEdging = False
                SubStroking = False
                SubHoldingEdge = True
                EdgeTauntTimer.Stop()
                If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
                DomChat = "#HoldTheEdge"
                TypingDelay()

                HoldEdgeTick = HoldEdgeChance

                If FrmSettings.NBHoldTheEdgeMax.Value = 0 Then

                    If FrmSettings.domlevelNumBox.Value = 1 Then HoldEdgeTick = randomizer.Next(10, 31)
                    If FrmSettings.domlevelNumBox.Value = 2 Then HoldEdgeTick = randomizer.Next(15, 46)
                    If FrmSettings.domlevelNumBox.Value = 3 Then HoldEdgeTick = randomizer.Next(20, 61)
                    If FrmSettings.domlevelNumBox.Value = 4 Then HoldEdgeTick = randomizer.Next(45, 121)
                    If FrmSettings.domlevelNumBox.Value = 5 Then HoldEdgeTick = randomizer.Next(60, 301)

                    If FrmSettings.domlevelNumBox.Value >= 3 And FrmSettings.crazyCheckBox.Checked = True Then
                        TempVal = randomizer.Next(1, 101)
                        If TempVal < 21 Then HoldEdgeTick *= 2
                    End If

                Else

                    Dim HoldEdgeMin As Integer = 30
                    If FrmSettings.NBHoldTheEdgeMax.Value < 31 Then HoldEdgeMin = FrmSettings.NBHoldTheEdgeMax.Value / 2
                    HoldEdgeTick = randomizer.Next(HoldEdgeMin, FrmSettings.NBHoldTheEdgeMax.Value + 1)
                    If HoldEdgeTick < 10 Then HoldEdgeTick = 10

                End If

                HoldEdgeTime = 0

                HoldEdgeTimer.Start()
                HoldEdgeTauntTimer.Start()

            Else

                DomTypeCheck = True
                SubEdging = False
                SubStroking = False
                EdgeTauntTimer.Stop()
                DomChat = "#StopStrokingEdge"
                TypingDelay()

            End If

            Do
                Application.DoEvents()
            Loop Until DomTypeCheck = False


            StringClean = StringClean.Replace("@EdgingDecide", "")
        End If

        If StringClean.Contains("@CheckVideo") Then
            VideoCheck = True
            RandomVideo()
            If NoVideo = True Then
                FileGoto = "(No Videos Found)"
            Else
                FileGoto = "(Videos Found)"
            End If
            VideoCheck = False
            NoVideo = False
            SkipGotoLine = True
            GetGoto()
            StringClean = StringClean.Replace("@CheckVideo", "")
        End If

        If StringClean.Contains("@PlayCensorshipSucks") Then
            ScriptVideoTease = "Censorship Sucks"
            ScriptVideoTeaseFlag = True
            RandomVideo()
            ScriptVideoTeaseFlag = False
            CensorshipGame = True
            VideoTease = True
            CensorshipTick = randomizer.Next(FrmSettings.NBCensorHideMin.Value, FrmSettings.NBCensorHideMax.Value + 1)
            CensorshipTimer.Start()
            StringClean = StringClean.Replace("@PlayCensorshipSucks", "")
        End If

        If StringClean.Contains("@ChastityOn") Then
            Chastity = True
            My.Settings.Chastity = True
            My.Settings.Save()
            StringClean = StringClean.Replace("@ChastityOn", "")
        End If

        If StringClean.Contains("@ChastityOff") Then
            Chastity = False
            My.Settings.Chastity = False
            My.Settings.Save()
            StringClean = StringClean.Replace("@ChastityOff", "")
        End If

        If StringClean.Contains("@VitalSubAssignment") Then
            Dim AssignReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\VitalSub\Assignments.txt")
            Dim AssignList As New List(Of String)
            While AssignReader.Peek <> -1
                AssignList.Add(AssignReader.ReadLine())
            End While
            AssignReader.Close()
            AssignReader.Dispose()
            AssignList = FilterList(AssignList)
            Dim TempAssign As String = AssignList(randomizer.Next(0, AssignList.Count))
            frmApps.CLBExercise.Items.Add(TempAssign)
            SaveExercise()
            frmApps.CBVitalSubDomTask.Checked = False
            My.Settings.VitalSubAssignments = False
            My.Settings.Save()
            StringClean = StringClean.Replace("@VitalSubAssignment", "")
        End If

        If StringClean.Contains("@DeleteLocalImage") Then

            Debug.Print("FoundString = " & FoundString)

            If Not mainPictureBox Is Nothing Then
                Try
                    mainPictureBox.Image.Dispose()
                    mainPictureBox.Image = Nothing
                    GC.Collect()
                Catch
                End Try
                Do
                    Application.DoEvents()
                Loop Until mainPictureBox.Image Is Nothing
            End If

            mainPictureBox.BackgroundImage = Nothing
            mainPictureBox.Refresh()
            mainPictureBox.LoadFromUrl(Application.StartupPath & "\Images\System\Black.jpg")

            If FrmSettings.CBDomDel.Checked = True Then
                Try
                    My.Computer.FileSystem.DeleteFile(FoundString)
                Catch
                End Try
            End If

            
            StringClean = StringClean.Replace("@DeleteLocalImage", "")
        End If

        If StringClean.Contains("@Add1Token") Then
            BronzeTokens += 1
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 1 Bronze token!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add1Token", "")
        End If

        If StringClean.Contains("@Add3Tokens") Then
            BronzeTokens += 3
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 3 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add3Tokens", "")
        End If

        If StringClean.Contains("@Add5Tokens") Then
            BronzeTokens += 5
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            StringClean = StringClean.Replace("@Add5Tokens", "")
            MessageBox.Show(Me, domName.Text & " has given you 5 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If StringClean.Contains("@Add10Tokens") Then
            BronzeTokens += 10
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 10 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add10Tokens", "")
        End If

        If StringClean.Contains("@Add25Tokens") Then
            BronzeTokens += 25
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 25 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add25Tokens", "")
        End If

        If StringClean.Contains("@Add50Tokens") Then
            BronzeTokens += 50
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 50 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add50Tokens", "")
        End If

        If StringClean.Contains("@Add100Tokens") Then
            BronzeTokens += 100
            My.Settings.BronzeTokens = BronzeTokens
            My.Settings.Save()
            FrmCardList.UpdateBronzeTokens()
            MessageBox.Show(Me, domName.Text & " has given you 100 Bronze tokens!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            StringClean = StringClean.Replace("@Add50Tokens", "")
        End If


        If StringClean.Contains("@PlayAvoidTheEdge") Then
            ' #### Reboot
            ScriptTimer.Stop()
            SubStroking = True
            TempStrokeTauntVal = StrokeTauntVal
            TempFileText = FileText
            ScriptVideoTease = "Avoid The Edge"
            ScriptVideoTeaseFlag = True
            AvoidTheEdgeStroking = True
            AvoidTheEdgeGame = True
            RandomVideo()
            ScriptVideoTeaseFlag = False
            VideoTease = True
            StartStrokingCount += 1
            StopMetronome = False
            StrokePace = randomizer.Next(3, 8) * 10
            StrokePaceTimer.Interval = StrokePace
            StrokePaceTimer.Start()
            AvoidTheEdgeTick = 120 / FrmSettings.TauntSlider.Value
            AvoidTheEdgeTaunts.Start()
            StringClean = StringClean.Replace("@PlayAvoidTheEdge", "")
        End If

        If StringClean.Contains("@ResumeAvoidTheEdge") Then
            DomWMP.Ctlcontrols.play()
            ScriptTimer.Stop()
            AvoidTheEdgeStroking = True
            SubStroking = True
            StartStrokingCount += 1
            StopMetronome = False
            VideoTease = True
            StrokePace = randomizer.Next(3, 8) * 10
            StrokePaceTimer.Interval = StrokePace
            StrokePaceTimer.Start()
            AvoidTheEdgeTick = 120 / FrmSettings.TauntSlider.Value
            AvoidTheEdgeTaunts.Start()
            StringClean = StringClean.Replace("@ResumeAvoidTheEdge", "")
        End If

        If StringClean.Contains("@PlayRedLightGreenLight") Then
            ' #### Reboot
            ScriptTimer.Stop()
            SubStroking = True
            TempStrokeTauntVal = StrokeTauntVal
            TempFileText = FileText
            ScriptVideoTease = "RLGL"
            ScriptVideoTeaseFlag = True
            'AvoidTheEdgeStroking = True
            RLGLGame = True
            RandomVideo()
            ScriptVideoTeaseFlag = False
            VideoTease = True
            RLGLTick = randomizer.Next(FrmSettings.NBGreenLightMin.Value, FrmSettings.NBGreenLightMax.Value + 1)
            RLGLTimer.Start()
            StartStrokingCount += 1
            StopMetronome = False
            StrokePace = randomizer.Next(3, 8) * 10
            StrokePaceTimer.Interval = StrokePace
            StrokePaceTimer.Start()
            'VideoTauntTick = randomizer.Next(20, 31)
            'VideoTauntTimer.Start()
            StringClean = StringClean.Replace("@PlayRedLightGreenLight", "")
        End If

        If StringClean.Contains("@PlayVideo[") Then
            Dim VideoClean As String = StringClean
            Dim StartIndex As Integer = VideoClean.IndexOf("@PlayVideo[") + 11
            For i As Integer = 1 To StartIndex
                VideoClean = VideoClean.Remove(0, 1)
            Next
            Dim VideoS As String() = VideoClean.Split("]")
            VideoClean = Application.StartupPath & "\Video\" & VideoS(0)
            VideoClean = VideoClean.Replace("\\", "\")
            Try
                DomWMP.Visible = True
                mainPictureBox.Visible = False
                DomWMP.URL = VideoClean
                TeaseVideo = True
            Catch
                MessageBox.Show(Me, "\" & VideoS(0) & " was not found in " & Application.StartupPath & "\Video!" & Environment.NewLine & Environment.NewLine & "Please make sure the file exists and that it is spelled correctly in the script.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
            StringClean = StringClean.Replace("@PlayVideo[" & VideoS(0) & "]", "")
        End If

        If StringClean.Contains("@PlayAudio[") Then
            Dim AudioClean As String = StringClean
            Dim StartIndex As Integer = AudioClean.IndexOf("@PlayAudio[") + 11
            For i As Integer = 1 To StartIndex
                AudioClean = AudioClean.Remove(0, 1)
            Next
            Dim AudioS As String() = AudioClean.Split("]")
            AudioClean = Application.StartupPath & "\Audio\" & AudioS(0)
            AudioClean = AudioClean.Replace("\\", "\")
            Try
                DomWMP.URL = AudioClean
            Catch
                MessageBox.Show(Me, "\" & AudioS(0) & " was not found in " & Application.StartupPath & "\Audio!" & Environment.NewLine & Environment.NewLine & "Please make sure the file exists and that it is spelled correctly in the script.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End Try
            StringClean = StringClean.Replace("@PlayAudio[" & AudioS(0) & "]", "")
        End If




        If StringClean.Contains("@NullResponse") Then
            NullResponse = True
            StringClean = StringClean.Replace("@NullResponse", "")
            'Debug.Print("NullResponse Called")
        End If

VTSkip:

        If StringClean.Contains("@SpeedUpCheck") Then

            If AskedToSpeedUp = True Then
                ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SpeedUpREPEAT.txt"
                StringClean = ResponseClean(StringClean)

            Else

                If StrokePace > 99 Then
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SpeedUpMAX.txt"
                    StringClean = ResponseClean(StringClean)

                Else

                    Dim SpeedUpCheck As Integer

                    If FrmSettings.domlevelNumBox.Value = 1 Then SpeedUpCheck = 70
                    If FrmSettings.domlevelNumBox.Value = 2 Then SpeedUpCheck = 40
                    If FrmSettings.domlevelNumBox.Value = 3 Then SpeedUpCheck = 60
                    If FrmSettings.domlevelNumBox.Value = 4 Then SpeedUpCheck = 50
                    If FrmSettings.domlevelNumBox.Value = 5 Then SpeedUpCheck = 65

                    Dim SpeedUpVal As Integer = randomizer.Next(1, 101)

                    If SpeedUpVal > SpeedUpCheck Then

                        ' you can speed up
                        ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SpeedUpALLOWED.txt"

                    Else

                        ' you can't speed up
                        AskedToSpeedUp = True
                        ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SpeedUpDENIED.txt"

                    End If

                    StringClean = ResponseClean(StringClean)

                End If

            End If

            StringClean = StringClean.Replace("@SpeedUpCheck", "")
            GoTo RinseLatherRepeat
        End If


        If StringClean.Contains("@SlowDownCheck") Then

            If AskedToSpeedUp = True Then
                ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SlowDownREPEAT.txt"
                StringClean = ResponseClean(StringClean)

            Else

                If StrokePace < 11 Then
                    ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SlowDownMIN.txt"
                    StringClean = ResponseClean(StringClean)

                Else

                    Dim SpeedUpCheck As Integer

                    If FrmSettings.domlevelNumBox.Value = 1 Then SpeedUpCheck = 70
                    If FrmSettings.domlevelNumBox.Value = 2 Then SpeedUpCheck = 40
                    If FrmSettings.domlevelNumBox.Value = 3 Then SpeedUpCheck = 60
                    If FrmSettings.domlevelNumBox.Value = 4 Then SpeedUpCheck = 50
                    If FrmSettings.domlevelNumBox.Value = 5 Then SpeedUpCheck = 65

                    Dim SpeedUpVal As Integer = randomizer.Next(1, 101)

                    If SpeedUpVal > SpeedUpCheck Then

                        ' you can speed up
                        ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SlowDownALLOWED.txt"

                    Else

                        ' you can't speed up
                        AskedToSpeedUp = True
                        ResponseFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Vocabulary\Responses\System\SlowDownDENIED.txt"

                    End If

                    StringClean = ResponseClean(StringClean)

                End If

            End If

            StringClean = StringClean.Replace("@SlowDownCheck", "")
            GoTo RinseLatherRepeat

        End If


        Return StringClean

    End Function

    Public Sub CommandCleanBookmark()

    End Sub

    Public Sub EdgePace()

        StrokePace = randomizer.Next(10, 31)
        If File.Exists(Application.StartupPath & "\System\Metronome") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System\Metronome")
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\System\Metronome", StrokePace, False)

    End Sub

    Public Function FilterList(ByVal ListClean As List(Of String)) As List(Of String)

        ListClean.Add("### BUFFER LINE ###")

        'For i As Integer = 0 To ListClean.Count - 1
        'Debug.Print(i & ". " & ListClean(i))
        'Next

        FoundTag = "NULL"

        If File.Exists(Application.StartupPath & "\Images\System\ImageTags.txt") Then
            Dim TagReader As New StreamReader(Application.StartupPath & "\Images\System\ImageTags.txt")
            Dim TagList As New List(Of String)
            While TagReader.Peek <> -1
                TagList.Add(TagReader.ReadLine())
            End While

            TagReader.Close()
            TagReader.Dispose()



            'If SlideshowLoaded = True And Not mainPictureBox.Image Is Nothing And domVLC.Visible = False Then
            If SlideshowLoaded = True And Not mainPictureBox.Image Is Nothing And DomWMP.Visible = False Then
                Try
                    For t As Integer = 0 To TagList.Count - 1
                        'Debug.Print("TagList(t) = " & TagList(t))
                        If TagList(t).Contains(_ImageFileNames(FileCount)) Then
                            FoundTag = TagList(t)
                            Dim FoundTagSplit As String() = Split(FoundTag)
                            For j As Integer = 0 To FoundTagSplit.Length - 1
                                If FoundTagSplit(j).Contains("TagGarment") Then TagGarment = FoundTagSplit(j).Replace("TagGarment", "")
                                If FoundTagSplit(j).Contains("TagUnderwear") Then TagUnderwear = FoundTagSplit(j).Replace("TagUnderwear", "")
                                If FoundTagSplit(j).Contains("TagTattoo") Then TagTattoo = FoundTagSplit(j).Replace("TagTattoo", "")
                                If FoundTagSplit(j).Contains("TagSexToy") Then TagSexToy = FoundTagSplit(j).Replace("TagSexToy", "")
                                If FoundTagSplit(j).Contains("TagFurniture") Then TagFurniture = FoundTagSplit(j).Replace("TagFurniture", "")
                            Next
                            Exit For
                        End If
                    Next
                Catch
                End Try
            End If


            'Debug.Print("TagGarment = " & TagGarment)
            'Debug.Print("TagUnderwear = " & TagUnderwear)
            'Debug.Print("TagTattoo = " & TagTattoo)
            'Debug.Print("TagSexToy = " & TagSexToy)
            'Debug.Print("TagFurniture = " & TagFurniture)
            'Debug.Print("FoundTag = " & FoundTag)



        End If







        Dim PoundCount As Integer = ListClean.Count
        Dim PoundLine As Integer = PoundCount


        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@Crazy") Then
                If FrmSettings.crazyCheckBox.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@Crazy", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@Vulgar") Then
                If FrmSettings.vulgarCheckBox.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@Vulgar", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@Supremacist") Then
                If FrmSettings.supremacistCheckBox.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@Supremacist", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DommeLevel1") Then
                If FrmSettings.domlevelNumBox.Value <> 1 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DommeLevel1", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DommeLevel2") Then
                If FrmSettings.domlevelNumBox.Value <> 2 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DommeLevel2", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DommeLevel3") Then
                If FrmSettings.domlevelNumBox.Value <> 3 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DommeLevel3", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DommeLevel4") Then
                If FrmSettings.domlevelNumBox.Value <> 4 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DommeLevel4", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DommeLevel5") Then
                If FrmSettings.domlevelNumBox.Value <> 5 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DommeLevel5", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SelfYoung") Then
                If FrmSettings.domageNumBox.Value > FrmSettings.NBSelfAgeMin.Value - 1 Or DommeVideo = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SelfYoung", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SelfOld") Then
                If FrmSettings.domageNumBox.Value < FrmSettings.NBSelfAgeMax.Value + 1 Or DommeVideo = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SelfOld", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ACup") Then
                If FrmSettings.boobComboBox.Text <> "A" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@ACup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@BCup") Then
                If FrmSettings.boobComboBox.Text <> "B" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@BCup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CCup") Then
                If FrmSettings.boobComboBox.Text <> "C" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@CCup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DCup") Then
                If FrmSettings.boobComboBox.Text <> "D" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DCup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DDCup") Then
                If FrmSettings.boobComboBox.Text <> "DD" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DDCup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@DDD+Cup") Then
                If FrmSettings.boobComboBox.Text <> "DDD+" Or Not _ImageFileNames.Contains(mainPictureBox.ImageLocation) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@DDD+Cup", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CockSmall") Then
                If FrmSettings.CockSizeNumBox.Value >= FrmSettings.NBAvgCockMin.Value Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@CockSmall", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CockLarge") Then
                If FrmSettings.CockSizeNumBox.Value <= FrmSettings.NBAvgCockMax.Value Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@CockLarge", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubYoung") Then
                If FrmSettings.subAgeNumBox.Value >= FrmSettings.NBSubAgeMin.Value Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SubYoung", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubOld") Then
                If FrmSettings.subAgeNumBox.Value <= FrmSettings.NBSubAgeMax.Value Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SubOld", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubBirthday") Then
                If FrmSettings.NBBirthdayMonth.Value <> Month(Date.Now) And FrmSettings.NBBirthdayDay.Value <> DateAndTime.Day(Date.Now) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SubBirthday", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ValentinesDay") Then
                If Month(Date.Now) <> 2 And DateAndTime.Day(Date.Now) <> 14 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@ValentinesDay", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ChristmasEve") Then
                If Month(Date.Now) <> 12 And DateAndTime.Day(Date.Now) <> 24 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@ChristmasEve", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ChristmasDay") Then
                If Month(Date.Now) <> 12 And DateAndTime.Day(Date.Now) <> 25 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@ChristmasDay", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NewYearsEve") Then
                If Month(Date.Now) <> 12 And DateAndTime.Day(Date.Now) <> 31 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NewYearsEve", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NewYearsDay") Then
                If Month(Date.Now) <> 12 And DateAndTime.Day(Date.Now) <> 25 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NewYearsDay", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagFace") Then
                If Not FoundTag.Contains("TagFace") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Face")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagFace", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagBoobs") Then
                If Not FoundTag.Contains("TagBoobs") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Boobs")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagBoobs", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagPussy") Then
                If Not FoundTag.Contains("TagPussy") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Pussy")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagPussy", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagAss") Then
                If Not FoundTag.Contains("TagAss") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Ass")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagAss", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagFeet") Then
                If Not FoundTag.Contains("TagFeet") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains FullBody")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagFeet", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagLegs") Then
                If Not FoundTag.Contains("TagLegs") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagLegs")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagLegs", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagMasturbating") Then
                If Not FoundTag.Contains("TagMasturbating") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Masturbating")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagMasturbating", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagSucking") Then
                If Not FoundTag.Contains("TagSucking") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Sucking")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagSucking", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagFullyDressed") Then
                If Not FoundTag.Contains("TagFullyDressed") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains FullyDressed")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagFullyDressed", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagHalfDressed") Then
                If Not FoundTag.Contains("TagHalfDressed") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains HalfDressed")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagHalfDressed", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagGarmentCovering") Then
                If Not FoundTag.Contains("TagGarmentCovering") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagGarmentCovering")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagGarmentCovering", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagHandsCovering") Then
                If Not FoundTag.Contains("TagHandsCovering") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagHandsCovering")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagHandsCovering", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagNaked") Then
                If Not FoundTag.Contains("TagNaked") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Naked")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagNaked", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagSideView") Then
                If Not FoundTag.Contains("TagSideView") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains Normal")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagNormal", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagCloseUp") Then
                If Not FoundTag.Contains("TagCloseUp") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains CloseUp")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagCloseUp", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagPiercing") Then
                If Not FoundTag.Contains("TagPiercing") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagPiercing")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagPiercing", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagGarment") Then
                If Not FoundTag.Contains("TagGarment") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagGarment")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagGarment", TagGarment)
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagUnderwear") Then
                If Not FoundTag.Contains("TagUnderwear") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagUnderwear")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagUnderwear", TagUnderwear)
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagTattoo") Then
                If Not FoundTag.Contains("TagTattoo") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagTattoo")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagTattoo", TagTattoo)
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagSexToy") Then
                If Not FoundTag.Contains("TagSexToy") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagSexToy")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagSexToy", TagSexToy)
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@TagFurniture") Then
                If Not FoundTag.Contains("TagFurniture") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                Else
                    'Debug.Print("FoundTag Contains TagFurniture")
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@TagFurniture", TagFurniture)
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@FirstRound") Then
                If FirstRound = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@FirstRound", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NotFirstRound") Then
                If FirstRound = True Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@FirstRound", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@StrokeSpeedMax") Then
                If StrokePace < 100 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@StrokeSpeedMax", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@StrokeSpeedMin") Then
                If StrokePace > 10 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@StrokeSpeedMin", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@AlwaysAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text <> "Always Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@AlwaysAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@OftenAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text <> "Often Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@OftenAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SometimesAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text <> "Sometimes Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SometimesAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@RarelyAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text <> "Rarely Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@RarelyAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NeverAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text <> "Never Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NeverAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@AlwaysRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text <> "Always Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@AlwaysRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@OftenRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text <> "Often Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@OftenRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SometimesRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text <> "Sometimes Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@SometimesRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@RarelyRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text <> "Rarely Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@RarelyRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NeverRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text <> "Never Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NeverRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NotAlwaysAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text = "Always Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NotAlwaysAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NotNeverAllowsOrgasm") Then
                If FrmSettings.alloworgasmComboBox.Text = "Never Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NotNeverAllowsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NotAlwaysRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text = "Always Ruins" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NotAlwaysRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@NotNeverRuinsOrgasm") Then
                If FrmSettings.ruinorgasmComboBox.Text = "Never Allows" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@NotNeverRuinsOrgasm", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@LongEdge") Then
                If LongEdge = False Or FrmSettings.CBLongEdgeTaunts.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@LongEdge", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@InterruptLongEdge") Then
                If LongEdge = False Or FrmSettings.CBLongEdgeInterrupts.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
                'ListClean(PoundCount) = ListClean(PoundCount).Replace("@InterruptLongEdge", "")
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowHardcoreImage") Then
                If Not Directory.Exists(FrmSettings.LBLIHardcore.Text) Or FrmSettings.CBIHardcore.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowSoftcoreImage") Then
                If Not Directory.Exists(FrmSettings.LBLISoftcore.Text) Or FrmSettings.CBISoftcore.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowLesbianImage") Then
                If Not Directory.Exists(FrmSettings.LBLILesbian.Text) Or FrmSettings.CBILesbian.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowBlowjobImage") Then
                If Not Directory.Exists(FrmSettings.LBLIBlowjob.Text) Or FrmSettings.CBIBlowjob.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowFemdomImage") Then
                If Not Directory.Exists(FrmSettings.LBLIFemdom.Text) Or FrmSettings.CBIFemdom.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowLezdomImage") Then
                If Not Directory.Exists(FrmSettings.LBLILezdom.Text) Or FrmSettings.CBILezdom.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowHentaiImage") Then
                If Not Directory.Exists(FrmSettings.LBLIHentai.Text) Or FrmSettings.CBIHentai.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowGayImage") Then
                If Not Directory.Exists(FrmSettings.LBLIGay.Text) Or FrmSettings.CBIGay.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowMaledomImage") Then
                If Not Directory.Exists(FrmSettings.LBLIMaledom.Text) Or FrmSettings.CBIMaledom.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowCaptionsImage") Then
                If Not Directory.Exists(FrmSettings.LBLICaptions.Text) Or FrmSettings.CBICaptions.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowGeneralImage") Then
                If Not Directory.Exists(FrmSettings.LBLIGeneral.Text) Or FrmSettings.CBIGeneral.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowBlogImage") Or ListClean(PoundCount).Contains("@NewBlogImage") Then
                If FrmSettings.URLFileList.CheckedItems.Count = 0 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowLocalImage") Then
                If FrmSettings.CBIHardcore.Checked = False And FrmSettings.CBISoftcore.Checked = False And FrmSettings.CBILesbian.Checked = False And FrmSettings.CBIBlowjob.Checked = False And _
                    FrmSettings.CBIFemdom.Checked = False And FrmSettings.CBILezdom.Checked = False And FrmSettings.CBIHentai.Checked = False And FrmSettings.CBIGay.Checked = False And _
                    FrmSettings.CBIMaledom.Checked = False And FrmSettings.CBICaptions.Checked = False And FrmSettings.CBIGeneral.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowButtImage") Then
                If Not Directory.Exists(FrmSettings.LBLButtPath.Text) And Not File.Exists(FrmSettings.LBLButtURL.Text) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowBoobsImage") Then
                If Not Directory.Exists(FrmSettings.LBLBoobPath.Text) And Not File.Exists(FrmSettings.LBLBoobURL.Text) Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@1MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 60 Or HoldEdgeTime > 119 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@2MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 120 Or HoldEdgeTime > 179 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@3MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 180 Or HoldEdgeTime > 239 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@4MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 240 Or HoldEdgeTime > 299 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@5MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 300 Or HoldEdgeTime > 599 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@10MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 600 Or HoldEdgeTime > 899 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@15MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 900 Or HoldEdgeTime > 1799 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@30MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 1800 Or HoldEdgeTime > 2699 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@45MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 2700 Or HoldEdgeTime > 3599 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@60MinuteHold") Then
                If SubHoldingEdge = False Or HoldEdgeTime < 3600 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CBTLevel1") Then
                If FrmSettings.CBTSlider.Value <> 1 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CBTLevel2") Then
                If FrmSettings.CBTSlider.Value <> 2 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CBTLevel3") Then
                If FrmSettings.CBTSlider.Value <> 3 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CBTLevel4") Then
                If FrmSettings.CBTSlider.Value <> 4 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@CBTLevel5") Then
                If FrmSettings.CBTSlider.Value <> 5 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubCircumcised") Then
                If FrmSettings.CBSubCircumcised.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubNotCircumcised") Then
                If FrmSettings.CBSubCircumcised.Checked = True Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubPierced") Then
                If FrmSettings.CBSubPierced.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@SubNotPierced") Then
                If FrmSettings.CBSubPierced.Checked = True Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        Dim ListCount As Integer
        LocalTagImageList.Clear()
        Dim ListCountTotal As Integer = -1


        If File.Exists(Application.StartupPath & "\Images\System\LocalImageTags.txt") Then
            Dim LocalReader As New StreamReader(Application.StartupPath & "\Images\System\LocalImageTags.txt")
            While LocalReader.Peek <> -1
                LocalTagImageList.Add(LocalReader.ReadLine())
            End While
            LocalReader.Close()
            LocalReader.Dispose()

            ListCount = LocalTagImageList.Count - 1

            Do
                ListCountTotal += 1
                'Debug.Print("LocalTagImageList(i) = &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&" & LocalTagImageList(ListCountTotal))
                If LocalTagImageList(ListCountTotal) = "" Or LocalTagImageList(ListCountTotal) Is Nothing Then
                    LocalTagImageList.Remove(LocalTagImageList(ListCountTotal))
                    ListCount -= 1
                End If
            Loop Until ListCountTotal = ListCount
        End If

        For i As Integer = 0 To LocalTagImageList.Count - 1
            'Debug.Print(i & ": LocalTagImageList(i) = " & LocalTagImageList(i))
        Next

        'ListCountTotal = -1
        Dim TagCount As Integer = 0

        For i As Integer = ListClean.Count - 1 To 0 Step -1
            TagCount = 0
            If ListClean(i).Contains("@ShowTaggedImage") And ListClean(i).Contains("@Tag") Then
                Dim TSplit As String() = Split(ListClean(i))
                For j As Integer = 0 To TSplit.Length - 1
                    If TSplit(j).Contains("@Tag") Then
                        Dim TString As String = TSplit(j).Replace("@Tag", "")
                        For k As Integer = LocalTagImageList.Count - 1 To 0 Step -1
                            If LocalTagImageList(k).Contains(TString) Then TagCount += 1
                        Next
                        If TagCount = 0 Then
                            If StrokeFilter = True Then
                                For l As Integer = 0 To StrokeTauntCount - 1
                                    ListClean.RemoveAt(i)
                                    PoundLine -= 1
                                Next
                            Else
                                ListClean.RemoveAt(i)
                                PoundLine -= 1
                            End If
                            Exit For
                        End If
                        TagCount = 0
                    End If
                Next
            End If
        Next

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowTaggedImage") Then
                If LocalTagImageList.Count = 0 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@BeforeTease") Then
                If BeforeTease = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@OrgasmDenied") Then
                If OrgasmDenied = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@OrgasmAllowed") Then
                If OrgasmAllowed = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@OrgasmRuined") Then
                If OrgasmRuined = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ApathyLevel1") Then
                If FrmSettings.NBEmpathy.Value <> 1 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ApathyLevel2") Then
                If FrmSettings.NBEmpathy.Value <> 2 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ApathyLevel3") Then
                If FrmSettings.NBEmpathy.Value <> 3 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ApathyLevel4") Then
                If FrmSettings.NBEmpathy.Value <> 4 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ApathyLevel5") Then
                If FrmSettings.NBEmpathy.Value <> 5 Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0


        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@InChastity") Then
                If Chastity = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@HasChastity") Then
                If FrmSettings.CBOwnChastity.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ChastityPA") Then
                If FrmSettings.CBChastityPA.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ChastitySpikes") Then
                If FrmSettings.CBChastitySpikes.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VitalSub") Then
                If frmApps.CBVitalSub.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VitalSubAssignment") Then
                If frmApps.CBVitalSub.Checked = False Or frmApps.CBVitalSubDomTask.Checked = False Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@RuinTaunt") Then
                If EdgeToRuin = False Or EdgeToRuinSecret = True Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowLikedImage") Then
                If Not File.Exists(Application.StartupPath & "\Images\System\LikedImageURLs.txt") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@ShowDislikedImage") Then
                If Not File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoHardcore") Then
                If VideoTease = False Or VideoType <> "Hardcore" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoSoftcore") Then
                If VideoTease = False Or VideoType <> "Softcore" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoLesbian") Then
                If VideoTease = False Or VideoType <> "Lesbian" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoBlowjob") Then
                If VideoTease = False Or VideoType <> "Blowjob" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoFemdom") Then
                If VideoTease = False Or VideoType <> "Femdom" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoFemsub") Then
                If VideoTease = False Or VideoType <> "Femsub" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoGeneral") Then
                If VideoTease = False Or VideoType <> "General" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0


        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoHardcoreDomme") Then
                If VideoTease = False Or VideoType <> "HardcoreD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoSoftcoreDomme") Then
                If VideoTease = False Or VideoType <> "SoftcoreD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoLesbianDomme") Then
                If VideoTease = False Or VideoType <> "LesbianD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoBlowjobDomme") Then
                If VideoTease = False Or VideoType <> "BlowjobD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoFemdomDomme") Then
                If VideoTease = False Or VideoType <> "FemdomD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoFemsubDomme") Then
                If VideoTease = False Or VideoType <> "FemsubD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@VideoGeneralDomme") Then
                If VideoTease = False Or VideoType <> "GeneralD" Then
                    If StrokeFilter = True Then
                        For i As Integer = 0 To StrokeTauntCount - 1
                            ListClean.Remove(ListClean(PoundCount))
                            PoundLine -= 1
                        Next
                    Else
                        ListClean.Remove(ListClean(PoundCount))
                        PoundLine -= 1
                    End If
                End If
            End If
        Loop Until PoundCount = 0


        'If File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then

        'Debug.Print("LocalTagImageList.Count = " & LocalTagImageList.Count)

        PoundCount = PoundLine
        Do
            PoundCount -= 1
            If ListClean(PoundCount).Contains("@Info") Then
                ListClean.Remove(ListClean(PoundCount))
                PoundLine -= 1
            End If
        Loop Until PoundCount = 0

        ListClean.Remove(ListClean(ListClean.Count - 1))

        'For i As Integer = 0 To ListClean.Count - 1
        'Debug.Print("AFTER " & i & ". " & ListClean(i))
        'Next

        'Dim ListReturn As String = ListClean(randomizer.Next(0, ListClean.Count - 1))

        For x As Integer = 0 To ListClean.Count - 1
            ListClean(x) = ListClean(x).Replace("#TagGarment", TagGarment)
            ListClean(x) = ListClean(x).Replace("#TagUnderwear", TagUnderwear)
            ListClean(x) = ListClean(x).Replace("#TagTattoo", TagTattoo)
            ListClean(x) = ListClean(x).Replace("#TagSexToy", TagSexToy)
            ListClean(x) = ListClean(x).Replace("#TagFurniture", TagFurniture)
        Next

        Return ListClean

    End Function

    Public Sub FilterListBookmark()

    End Sub


    Public Sub ShowGotImage()

        'Debug.Print("ShowGotImage Called")
        'Debug.Print("FoundString = " & FoundString)
        JustShowedBlogImage = True



        mainPictureBox.LoadFromUrl(FoundString)
        ShowImageInfo()
        

    End Sub

    Private Sub chatbox_KeyDown(sender As Object, e As KeyEventArgs) Handles chatBox.KeyDown


        If e.KeyCode = Keys.Return Then
            sendButton.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    'Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles chatBox.KeyDown



    'If e.KeyCode = Keys.Enter Then
    '   'sendButton.PerformClick()
    '   e.SuppressKeyPress = True
    'End If



    'End Sub

    ' Private Sub Text1_KeyPress(KeyAscii As Integer)

    ''Debug.Print("boo?")

    '    If KeyAscii = 13 Then
    '       'Debug.Print("yay?")
    '      KeyAscii = 0
    ' End If
    'End Sub


    Public Sub GetTnAList()

        BoobList.Clear()
        AssList.Clear()

        If FrmSettings.CBBnBLocal.Checked = True Then
            'Debug.Print("CBBnBLocal called")
            If FrmSettings.CBBoobSubDir.Checked = True Then
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpeg")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.bmp")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.gif")
                    BoobList.Add(foundFile)
                Next
            Else
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jpeg")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.bmp")
                    BoobList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLBoobPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.gif")
                    BoobList.Add(foundFile)
                Next
            End If

            If FrmSettings.CBButtSubDir.Checked = True Then
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpeg")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.bmp")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.gif")
                    AssList.Add(foundFile)
                Next
            Else
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jpeg")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.png")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.bmp")
                    AssList.Add(foundFile)
                Next
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LBLButtPath.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.gif")
                    AssList.Add(foundFile)
                Next
            End If

        End If

        If FrmSettings.CBBnBURL.Checked = True Then

            Dim BoobURLs As New StreamReader(FrmSettings.LBLBoobURL.Text)

            While BoobURLs.Peek <> -1
                BoobList.Add(BoobURLs.ReadLine())
            End While

            BoobURLs.Close()
            BoobURLs.Dispose()

            Dim AssURLs As New StreamReader(FrmSettings.LBLButtURL.Text)

            While AssURLs.Peek <> -1
                AssList.Add(AssURLs.ReadLine())
            End While

            AssURLs.Close()
            AssURLs.Dispose()

        End If


    End Sub

    Private Sub chatBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chatBox.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            ' sendButton.PerformClick()
            e.KeyChar = Chr(0)
        End If
    End Sub




    Private Sub AvoidTheEdge_Tick(sender As System.Object, e As System.EventArgs) Handles AvoidTheEdge.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Then Return

        AvoidTheEdgeTick -= 1

        If AvoidTheEdgeTick < 1 Then



            Dim AvoidTheEdgeLineTemp As Integer = randomizer.Next(1, 101)
            'Debug.Print("AtELT = " & AvoidTheEdgeLineTemp)



            Dim AvoidTheEdgeVideo As String = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\AvoidTheEdge.txt"
            If DommeVideo = True Then AvoidTheEdgeVideo = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\AvoidTheEdgeD.txt"

            Dim AvoidTheEdgeLineStart As Integer
            Dim AvoidTheEdgeLineEnd As Integer


            If File.Exists(AvoidTheEdgeVideo) Then
            Else
                If DommeVideo = True Then
                    MsgBox("AvoidTheEdgeD.txt is missing!", , "Error!")
                Else
                    MsgBox("AvoidTheEdge.txt is missing!", , "Error!")
                End If
                Return
            End If



            If AvoidTheEdgeStroking = False Then


                'CensorshipTick = randomizer.Next(NBCensorHideMin.Value, NBCensorHideMax.Value + 1)

                AvoidTheEdgeTick = 120 / FrmSettings.TauntSlider.Value

                ' If AvoidTheEdgeLineTemp > TauntSlider.Value * 5 Then
                'Return
                'End If

                Dim ioFileA As New StreamReader(AvoidTheEdgeVideo)
                Dim linesA As New List(Of String)
                Dim TempAvoidTheEdgeLine As Integer

                TempAvoidTheEdgeLine = -1
                While ioFileA.Peek <> -1
                    TempAvoidTheEdgeLine += 1
                    linesA.Add(ioFileA.ReadLine())
                    If VideoType = "Hardcore" And linesA(TempAvoidTheEdgeLine) = "[HardcoreStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Hardcore" And linesA(TempAvoidTheEdgeLine) = "[SoftcoreStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Softcore" And linesA(TempAvoidTheEdgeLine) = "[SoftcoreStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Softcore" And linesA(TempAvoidTheEdgeLine) = "[LesbianStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Lesbian" And linesA(TempAvoidTheEdgeLine) = "[LesbianStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Lesbian" And linesA(TempAvoidTheEdgeLine) = "[BlowjobStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Blowjob" And linesA(TempAvoidTheEdgeLine) = "[BlowjobStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Blowjob" And linesA(TempAvoidTheEdgeLine) = "[FemdomStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Femdom" And linesA(TempAvoidTheEdgeLine) = "[FemdomStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Femdom" And linesA(TempAvoidTheEdgeLine) = "[FemsubStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Femsub" And linesA(TempAvoidTheEdgeLine) = "[FemsubStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Femsub" And linesA(TempAvoidTheEdgeLine) = "[JOIStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "JOI" And linesA(TempAvoidTheEdgeLine) = "[JOIStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "JOI" And linesA(TempAvoidTheEdgeLine) = "[CHStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "CH" And linesA(TempAvoidTheEdgeLine) = "[CHStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "CH" And linesA(TempAvoidTheEdgeLine) = "[GeneralStrokingOn]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "General" And linesA(TempAvoidTheEdgeLine) = "[GeneralStrokingOff]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "General" And linesA(TempAvoidTheEdgeLine) = "[StrokingEnd]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                End While

                ioFileA.Close()
                ioFileA.Dispose()

            Else






                AvoidTheEdgeTick = 120 / FrmSettings.TauntSlider.Value

                Dim ioFileB As New StreamReader(AvoidTheEdgeVideo)
                Dim linesB As New List(Of String)
                Dim TempAvoidTheEdgeLine As Integer

                TempAvoidTheEdgeLine = -1
                While ioFileB.Peek <> -1
                    TempAvoidTheEdgeLine += 1
                    linesB.Add(ioFileB.ReadLine())
                    If VideoType = "Hardcore" And linesB(TempAvoidTheEdgeLine) = "[HardcoreStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Hardcore" And linesB(TempAvoidTheEdgeLine) = "[HardcoreStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Softcore" And linesB(TempAvoidTheEdgeLine) = "[SoftcoreStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Softcore" And linesB(TempAvoidTheEdgeLine) = "[SoftcoreStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Lesbian" And linesB(TempAvoidTheEdgeLine) = "[LesbianStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Lesbian" And linesB(TempAvoidTheEdgeLine) = "[LesbianStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Blowjob" And linesB(TempAvoidTheEdgeLine) = "[BlowjobStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Blowjob" And linesB(TempAvoidTheEdgeLine) = "[BlowjobStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Femdom" And linesB(TempAvoidTheEdgeLine) = "[FemdomStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Femdom" And linesB(TempAvoidTheEdgeLine) = "[FemdomStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "Femsub" And linesB(TempAvoidTheEdgeLine) = "[FemsubStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "Femsub" And linesB(TempAvoidTheEdgeLine) = "[FemsubStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "JOI" And linesB(TempAvoidTheEdgeLine) = "[JOIStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "JOI" And linesB(TempAvoidTheEdgeLine) = "[JOIStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "CH" And linesB(TempAvoidTheEdgeLine) = "[CHStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "CH" And linesB(TempAvoidTheEdgeLine) = "[CHStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                    If VideoType = "General" And linesB(TempAvoidTheEdgeLine) = "[GeneralStrokingOn]" Then AvoidTheEdgeLineStart = TempAvoidTheEdgeLine
                    If VideoType = "General" And linesB(TempAvoidTheEdgeLine) = "[GeneralStrokingOff]" Then AvoidTheEdgeLineEnd = TempAvoidTheEdgeLine
                End While

                ioFileB.Close()
                ioFileB.Dispose()

            End If

            Dim ioFile As New StreamReader(AvoidTheEdgeVideo)
            Dim lines As New List(Of String)
            While ioFile.Peek <> -1
                lines.Add(ioFile.ReadLine())
            End While

            Dim AvoidTheEdgeLine As Integer

            'Debug.Print("AvoidTheEdgeLineStart = " & AvoidTheEdgeLineStart)
            'Debug.Print("AvoidTheEdgeLineEnd = " & AvoidTheEdgeLineEnd)

            AvoidTheEdgeLine = randomizer.Next(AvoidTheEdgeLineStart + 1, AvoidTheEdgeLineEnd)

            DomTask = lines(AvoidTheEdgeLine)

            TypingDelayGeneric()




        End If

    End Sub

    Private Sub AvoidTheEdgeResume_Tick(sender As System.Object, e As System.EventArgs) Handles AvoidTheEdgeResume.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Then Return

        AtECountdown -= 1
        'Debug.Print("AtECountdown = " & AtECountdown)

        If AtECountdown < 1 Then
            AvoidTheEdgeResume.Stop()

            FileGoto = "NoAvoidTheEdgeInstructions"
            SkipGotoLine = True
            GetGoto()
            'domVLC.playlist.play()
            DomWMP.Ctlcontrols.play()
            HandleScripts()
            ScriptTimer.Start()


        End If


    End Sub



    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs)

        If StrokePaceTimer.Enabled = True Then
            StrokePaceTimer.Stop()
            Return
        End If


        StrokePaceInt = 10
        StrokePaceTimer.Start()








    End Sub



  

   

    Private Sub SaveBlogImage_Click_2(sender As System.Object, e As System.EventArgs) Handles SaveBlogImage.Click


        If mainPictureBox.Visible = True Then
            DomWMP.Visible = True
            mainPictureBox.Visible = False
        Else
            mainPictureBox.Visible = True
            DomWMP.Visible = False
        End If

    End Sub


    Public Sub GetBlogImage()

        If FrmSettings.URLFileList.CheckedItems.Count = 0 Then
            GetLocalImage()
            Return
        End If

AlreadySeen:



        Dim URLList As New List(Of String)
        URLList.Clear()


        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Images\System\URL Files\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            URLList.Add(foundFile.Replace(".txt", ""))
        Next

        Dim URLCount As Integer = URLList.Count

        For i As Integer = 0 To FrmSettings.URLFileList.Items.Count - 1
            For j As Integer = 0 To URLCount - 1
                'Debug.Print(FrmSettings.URLFileList.Items(i))
                'Debug.Print(URLList(j).Replace(Application.StartupPath & "\Images\System\URL Files\", ""))
                If FrmSettings.URLFileList.GetItemChecked(i) = False And FrmSettings.URLFileList.Items(i) = URLList(j).Replace(Application.StartupPath & "\Images\System\URL Files\", "") Then
                    URLList.Remove(URLList(j))
                    URLCount -= 1
                    Exit For
                End If
            Next
        Next

        'Debug.Print("URLList Count = " & URLList.Count)

        ImageUrlFilePath = URLList(randomizer.Next(0, URLCount)) & ".txt"

        Dim GetBlogImage As New StreamReader(ImageUrlFilePath)
        Dim linesGB As New List(Of String)

        While GetBlogImage.Peek <> -1
            linesGB.Add(GetBlogImage.ReadLine())
        End While

        Do
            ImageUrlFileIndex = randomizer.Next(0, linesGB.Count)
            FoundString = linesGB(ImageUrlFileIndex)
        Loop Until FoundString <> ""

        GetBlogImage.Close()
        GetBlogImage.Dispose()

        If File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then

            Dim ImageRepeat() As String = Filter(System.IO.File.ReadAllLines(Application.StartupPath & "\Images\System\DislikedImageURLs.txt"), FoundString)

            If Not UBound(ImageRepeat) = -1 Then GoTo AlreadySeen

        End If


        If File.Exists(Application.StartupPath & "\Images\System\LikedImageURLs.txt") Then


            Dim ImageRepeat2() As String = Filter(System.IO.File.ReadAllLines(Application.StartupPath & "\Images\System\LikedImageURLs.txt"), FoundString)

            If Not UBound(ImageRepeat2) = -1 Then GoTo AlreadySeen

        End If

        Try

            JustShowedBlogImage = True
            mainPictureBox.LoadFromUrl(FoundString)
            ShowImageInfo()

            If FrmSettings.CBBlogImageWindow.Checked = True Then
                WebImage = FoundString
                Do Until Not WebImage.Contains("/")
                    WebImage = WebImage.Remove(0, 1)
                Loop
                My.Computer.Network.DownloadFile(FoundString, Application.StartupPath & "\Images\Session Images\" & WebImage)
            End If

            PictureStrip.Items(0).Enabled = True
            PictureStrip.Items(1).Enabled = True
            PictureStrip.Items(2).Enabled = True
            PictureStrip.Items(3).Enabled = True

        Catch
            GetLocalImage()
            Return
        End Try




    End Sub

    Public Sub GetLocalImage()


        Dim LocalFileCheck As Integer = 0
        Dim CheckString As String
        Dim CheckBoolean As Boolean
        Dim LocalList As New List(Of String)
        LocalList.Clear()

        Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
        Dim files As String()

        For i As Integer = 1 To 11
            CheckString = "NULL"
            CheckBoolean = False
            If i = 1 And FrmSettings.CBIHardcore.Checked = True And Directory.Exists(FrmSettings.LBLIHardcore.Text) Then CheckString = FrmSettings.LBLIHardcore.Text
            If i = 2 And FrmSettings.CBISoftcore.Checked = True And Directory.Exists(FrmSettings.LBLISoftcore.Text) Then CheckString = FrmSettings.LBLISoftcore.Text
            If i = 3 And FrmSettings.CBILesbian.Checked = True And Directory.Exists(FrmSettings.LBLILesbian.Text) Then CheckString = FrmSettings.LBLILesbian.Text
            If i = 4 And FrmSettings.CBIBlowjob.Checked = True And Directory.Exists(FrmSettings.LBLIBlowjob.Text) Then CheckString = FrmSettings.LBLIBlowjob.Text
            If i = 5 And FrmSettings.CBIFemdom.Checked = True And Directory.Exists(FrmSettings.LBLIFemdom.Text) Then CheckString = FrmSettings.LBLIFemdom.Text
            If i = 6 And FrmSettings.CBILezdom.Checked = True And Directory.Exists(FrmSettings.LBLILezdom.Text) Then CheckString = FrmSettings.LBLILezdom.Text
            If i = 7 And FrmSettings.CBIHentai.Checked = True And Directory.Exists(FrmSettings.LBLIHentai.Text) Then CheckString = FrmSettings.LBLIHentai.Text
            If i = 8 And FrmSettings.CBIGay.Checked = True And Directory.Exists(FrmSettings.LBLIGay.Text) Then CheckString = FrmSettings.LBLIGay.Text
            If i = 9 And FrmSettings.CBIMaledom.Checked = True And Directory.Exists(FrmSettings.LBLIMaledom.Text) Then CheckString = FrmSettings.LBLIMaledom.Text
            If i = 10 And FrmSettings.CBICaptions.Checked = True And Directory.Exists(FrmSettings.LBLICaptions.Text) Then CheckString = FrmSettings.LBLICaptions.Text
            If i = 11 And FrmSettings.CBIGeneral.Checked = True And Directory.Exists(FrmSettings.LBLIGeneral.Text) Then CheckString = FrmSettings.LBLIGeneral.Text

            If i = 1 And FrmSettings.CBIHardcoreSD.Checked = True Then CheckBoolean = True
            If i = 2 And FrmSettings.CBISoftcoreSD.Checked = True Then CheckBoolean = True
            If i = 3 And FrmSettings.CBILesbianSD.Checked = True Then CheckBoolean = True
            If i = 4 And FrmSettings.CBIBlowjobSD.Checked = True Then CheckBoolean = True
            If i = 5 And FrmSettings.CBIFemdomSD.Checked = True Then CheckBoolean = True
            If i = 6 And FrmSettings.CBILezdomSD.Checked = True Then CheckBoolean = True
            If i = 7 And FrmSettings.CBIHentaiSD.Checked = True Then CheckBoolean = True
            If i = 8 And FrmSettings.CBIGaySD.Checked = True Then CheckBoolean = True
            If i = 9 And FrmSettings.CBIMaledomSD.Checked = True Then CheckBoolean = True
            If i = 10 And FrmSettings.CBICaptionsSD.Checked = True Then CheckBoolean = True
            If i = 11 And FrmSettings.CBIGeneralSD.Checked = True Then CheckBoolean = True


            If Not CheckString = "NULL" Then
                If CheckBoolean = True Then
                    files = Directory.GetFiles(CheckString, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(CheckString, "*.*")
                End If

                Array.Sort(files)

                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        LocalList.Add(fi)
                    End If
                Next

            End If

        Next

        If LocalList.Count = 0 Then
            FoundString = Application.StartupPath & "\Images\System\NoLocalImagesFound.jpg"
        Else
            Do
                FoundString = LocalList(randomizer.Next(0, LocalList.Count))
            Loop Until FoundString <> ""
        End If


        JustShowedBlogImage = True

        PictureStrip.Items(0).Enabled = False
        PictureStrip.Items(1).Enabled = True
        PictureStrip.Items(2).Enabled = True
        PictureStrip.Items(3).Enabled = False


        mainPictureBox.LoadFromUrl(FoundString)
        ShowImageInfo()



    End Sub



    Public Sub RunLinkScript()

        'Debug.Print("RunLinkScript() Called")

        Dim LinkList As New List(Of String)
        LinkList.Clear()


        Dim ChastityLinkCheck As String
        If Chastity = True Then
            ChastityLinkCheck = "*_CHASTITY.txt"
        Else
            ChastityLinkCheck = "*.txt"
        End If

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\Link\", FileIO.SearchOption.SearchTopLevelOnly, ChastityLinkCheck)
            Dim TempLink As String = foundFile
            TempLink = TempLink.Replace(".txt", "")
            Do Until Not TempLink.Contains("\")
                TempLink = TempLink.Remove(0, 1)
            Loop
            For x As Integer = 0 To FrmSettings.CLBLinkList.Items.Count - 1
                If Chastity = True Then
                    If FrmSettings.CLBLinkList.Items(x) = TempLink And FrmSettings.CLBLinkList.GetItemChecked(x) = True Then
                        LinkList.Add(foundFile)
                    End If
                Else
                    If FrmSettings.CLBLinkList.Items(x) = TempLink And FrmSettings.CLBLinkList.GetItemChecked(x) = True And Not TempLink.Contains("_CHASTITY") Then
                        LinkList.Add(foundFile)
                    End If
                End If

            Next
        Next


        If LinkList.Count < 1 Then
            If Chastity = True Then
                FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Link_CHASTITY.txt"
            Else
                FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\Link.txt"
            End If
        Else
            FileText = LinkList(randomizer.Next(0, LinkList.Count))
        End If

        LockImage = False

        StrokeTauntVal = -1

        If BookmarkLink = True Then
            BookmarkLink = False
            FileText = BookmarkLinkFile
            StrokeTauntVal = BookmarkLinkLine
        End If

        RunFileText()


    End Sub

    Public Sub RunLastScript()

        'Debug.Print("RunLastScript() Called")

        Dim EndList As New List(Of String)
        EndList.Clear()

        Dim ChastityEndCheck As String
        If Chastity = True Then
            ChastityEndCheck = "*_CHASTITY.txt"
        Else
            ChastityEndCheck = "*.txt"
        End If

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\End\", FileIO.SearchOption.SearchTopLevelOnly, ChastityEndCheck)
            Dim TempEnd As String = foundFile
            TempEnd = TempEnd.Replace(".txt", "")
            Do Until Not TempEnd.Contains("\")
                TempEnd = TempEnd.Remove(0, 1)
            Loop
            For x As Integer = 0 To FrmSettings.CLBEndList.Items.Count - 1
                If Chastity = True Then
                    If FrmSettings.CLBEndList.Items(x) = TempEnd And FrmSettings.CLBEndList.GetItemChecked(x) = True And Not TempEnd.Contains("_BEG") Then
                        EndList.Add(foundFile)
                    End If
                Else
                    If FrmSettings.CLBEndList.Items(x) = TempEnd And FrmSettings.CLBEndList.GetItemChecked(x) = True And Not TempEnd.Contains("_BEG") And Not TempEnd.Contains("_CHASTITY") Then
                        EndList.Add(foundFile)
                    End If
                End If
            Next
        Next


        If EndList.Count < 1 Then
            If Chastity = True Then
                FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\End_CHASTITY.txt"
            Else
                FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\End.txt"
            End If
        Else
            FileText = EndList(randomizer.Next(0, EndList.Count))
        End If

        LockImage = False

        StrokeTauntVal = -1

        LastScript = True

        RunFileText()

    End Sub

    Public Sub RunLastBegScript()

        'Debug.Print("RunLastBegScript() Called")
        Dim EndList As New List(Of String)
        EndList.Clear()

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\End\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
            Dim TempEnd As String = foundFile
            TempEnd = TempEnd.Replace(".txt", "")
            Do Until Not TempEnd.Contains("\")
                TempEnd = TempEnd.Remove(0, 1)
            Loop
            For x As Integer = 0 To FrmSettings.CLBEndList.Items.Count - 1
                If FrmSettings.CLBEndList.Items(x) = TempEnd And FrmSettings.CLBEndList.GetItemChecked(x) = True And TempEnd.Contains("_BEG") Then
                    EndList.Add(foundFile)
                    'Debug.Print("Greeting added: " & TempEnd)
                End If
            Next
        Next


        If EndList.Count < 1 Then
            FileText = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\System\Scripts\End_BEG.txt"
        Else
            FileText = EndList(randomizer.Next(0, EndList.Count))
        End If

        LockImage = False

        StrokeTauntVal = -1

        ScriptTick = 4
        ScriptTimer.Start()
        LastScript = True

        RunFileText()

    End Sub

    Public Sub StopEverything()

        ScriptTimer.Stop()
        StrokeTimer.Stop()
        StrokeTauntTimer.Stop()
        CensorshipTimer.Stop()
        RLGLTimer.Stop()
        TnASlides.Stop()
        AvoidTheEdge.Stop()
        EdgeTauntTimer.Stop()
        HoldEdgeTimer.Stop()
        HoldEdgeTauntTimer.Stop()
        StrokePaceTimer.Stop()
        AvoidTheEdgeTaunts.Stop()
        RLGLTauntTimer.Stop()
        VideoTauntTimer.Stop()
        EdgeCountTimer.Stop()

        SubStroking = False
        SubEdging = False
        SubHoldingEdge = False


    End Sub


    Private Sub EdgeTauntTimer_Tick(sender As System.Object, e As System.EventArgs) Handles EdgeTauntTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Or chatBox.Text <> "" Then Return

        Debug.Print("EdgeTauntIn = " & EdgeTauntInt)

        EdgeTauntInt -= 1

        If EdgeTauntInt < 1 Then

            Dim EdgeTaunt As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\Edge\Edge.txt")
            Dim ETLines As New List(Of String)

            While EdgeTaunt.Peek <> -1
                ETLines.Add(EdgeTaunt.ReadLine())
            End While

            EdgeTaunt.Close()
            EdgeTaunt.Dispose()

            ETLines = FilterList(ETLines)

            DomTask = ETLines(randomizer.Next(0, ETLines.Count))
            TypingDelayGeneric()

            EdgeTauntInt = randomizer.Next(30, 46)

        End If

    End Sub



    Private Sub HoldEdgeTimer_Tick(sender As System.Object, e As System.EventArgs) Handles HoldEdgeTimer.Tick

        'Debug.Print("HoldEdgeTick = " & HoldEdgeTick)

        HoldEdgeTime += 1
        HoldEdgeTimeTotal += 1

        My.Settings.HoldEdgeTimeTotal = HoldEdgeTimeTotal
        My.Settings.Save()

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Or chatBox.Text <> "" Then Return

        HoldEdgeTick -= 1

        If HoldEdgeTick < 1 Then

            'stop


            If OrgasmAllowed = True Then GoTo AllowedOrgasm
            If EdgeToRuin = True Or OrgasmRuined = True Then GoTo RuinedOrgasm



            If OrgasmDenied = True Then

                If FrmSettings.CBDomDenialEnds.Checked = False Then

                    Dim RepeatChance As Integer = randomizer.Next(0, 101)

                    If RepeatChance < 10 * FrmSettings.domlevelNumBox.Value Then
                        SubEdging = False
                        SubStroking = False
                        EdgeTauntTimer.Stop()

                        Dim RepeatList As New List(Of String)

                        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Denial Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                            RepeatList.Add(foundFile)
                        Next

                        If RepeatList.Count < 1 Then GoTo NoRepeatFiles

                        If FrmSettings.CBTeaseLengthDD.Checked = True Then
                            If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                            If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                            If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                            If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                            If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                        Else
                            TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                        End If

                        TeaseTimer.Start()

                        'ShowModule = True
                        StrokeTauntVal = -1
                        FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                        ScriptTick = 2
                        ScriptTimer.Start()
                        OrgasmDenied = False
                        OrgasmYesNo = False
                        Return
                    End If

                End If


            End If

NoRepeatFiles:

            HoldEdgeTimer.Stop()
            HoldEdgeTauntTimer.Stop()
            SubHoldingEdge = False
            SubStroking = False
            OrgasmYesNo = False
            DomTask = "#StopStroking"
            TypingDelayGeneric()
            Return

RuinedOrgasm:

            My.Settings.LastRuined = FormatDateTime(Now, DateFormat.ShortDate)
            My.Settings.Save()
            FrmSettings.LBLLastOrgasm.Text = My.Settings.LastRuined

            If FrmSettings.CBDomOrgasmEnds.Checked = False And OrgasmRuined = True Then

                Dim RepeatChance As Integer = randomizer.Next(0, 101)

                If RepeatChance < 8 * FrmSettings.domlevelNumBox.Value Then

                    EdgeTauntTimer.Stop()
                    HoldEdgeTimer.Stop()
                    HoldEdgeTauntTimer.Stop()
                    SubHoldingEdge = False
                    SubStroking = False
                    EdgeToRuin = False
                    EdgeToRuinSecret = False

                    Dim RepeatList As New List(Of String)

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Ruin Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        RepeatList.Add(foundFile)
                    Next

                    If RepeatList.Count < 1 Then GoTo NoRepeatRFiles


                    If FrmSettings.CBTeaseLengthDD.Checked = True Then
                        If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                        If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                        If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                        If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                        If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                    Else
                        TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                    End If
                    TeaseTimer.Start()

                    'ShowModule = True
                    StrokeTauntVal = -1
                    FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                    ScriptTick = 2
                    ScriptTimer.Start()
                    OrgasmRuined = False
                    OrgasmYesNo = False
                    Return
                End If

            End If



NoRepeatRFiles:



            DomTypeCheck = True
            HoldEdgeTimer.Stop()
            HoldEdgeTauntTimer.Stop()
            SubHoldingEdge = False
            SubStroking = False
            EdgeToRuin = False
            EdgeToRuinSecret = False
            OrgasmYesNo = False
            DomChat = "#RuinYourOrgasm"
            TypingDelay()
            Return

AllowedOrgasm:

            If My.Settings.OrgasmsLocked = True Then

                If My.Settings.OrgasmsRemaining < 1 Then

                    Dim NoCumList As New List(Of String)

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Out of Orgasms\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        NoCumList.Add(foundFile)
                    Next

                    If NoCumList.Count < 1 Then GoTo NoNoCumFiles


                    HoldEdgeTimer.Stop()
                    HoldEdgeTauntTimer.Stop()
                    SubHoldingEdge = False
                    SubStroking = False
                    OrgasmYesNo = False
                    'ShowModule = True
                    StrokeTauntVal = -1
                    FileText = NoCumList(randomizer.Next(0, NoCumList.Count))
                    ScriptTick = 2
                    ScriptTimer.Start()
                    Return
                End If


                My.Settings.OrgasmsRemaining -= 1

                My.Settings.Save()

            End If

NoNoCumFiles:


            My.Settings.LastOrgasm = FormatDateTime(Now, DateFormat.ShortDate)
            My.Settings.Save()
            FrmSettings.LBLLastOrgasm.Text = My.Settings.LastOrgasm

            If FrmSettings.CBDomOrgasmEnds.Checked = False Then

                Dim RepeatChance As Integer = randomizer.Next(0, 101)

                If RepeatChance < 4 * FrmSettings.domlevelNumBox.Value Then

                    HoldEdgeTimer.Stop()
                    HoldEdgeTauntTimer.Stop()
                    SubHoldingEdge = False
                    SubStroking = False
                    EdgeToRuin = False
                    EdgeToRuinSecret = False
                    EdgeTauntTimer.Stop()

                    Dim RepeatList As New List(Of String)

                    For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Interrupt\Orgasm Continue\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                        RepeatList.Add(foundFile)
                    Next

                    If RepeatList.Count < 1 Then GoTo NoRepeatOFiles


                    If FrmSettings.CBTeaseLengthDD.Checked = True Then
                        If FrmSettings.domlevelNumBox.Value = 1 Then TeaseTick = randomizer.Next(10, 16) * 60
                        If FrmSettings.domlevelNumBox.Value = 2 Then TeaseTick = randomizer.Next(15, 21) * 60
                        If FrmSettings.domlevelNumBox.Value = 3 Then TeaseTick = randomizer.Next(20, 31) * 60
                        If FrmSettings.domlevelNumBox.Value = 4 Then TeaseTick = randomizer.Next(30, 46) * 60
                        If FrmSettings.domlevelNumBox.Value = 5 Then TeaseTick = randomizer.Next(45, 61) * 60
                    Else
                        TeaseTick = randomizer.Next(FrmSettings.NBTeaseLengthMin.Value * 60, FrmSettings.NBTeaseLengthMax.Value * 60)
                    End If
                    TeaseTimer.Start()

                    'ShowModule = True
                    StrokeTauntVal = -1
                    FileText = RepeatList(randomizer.Next(0, RepeatList.Count))
                    ScriptTick = 2
                    ScriptTimer.Start()
                    OrgasmAllowed = False
                    OrgasmYesNo = False
                    Return
                End If

            End If



NoRepeatOFiles:


            DomTypeCheck = True
            HoldEdgeTimer.Stop()
            HoldEdgeTauntTimer.Stop()
            SubHoldingEdge = False
            SubStroking = False
            OrgasmYesNo = False
            'OrgasmAllowed = False
            DomChat = "#CumForMe"
            TypingDelay()
            Return

        End If

    End Sub

    Private Sub HoldEdgeTauntTimer_Tick(sender As System.Object, e As System.EventArgs) Handles HoldEdgeTauntTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Or chatBox.Text <> "" Then Return

        EdgeTauntInt -= 1

        If EdgeTauntInt < 1 Then

            Dim EdgeTaunt As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Stroke\HoldTheEdge\HoldTheEdge.txt")
            Dim ETLines As New List(Of String)

            While EdgeTaunt.Peek <> -1
                ETLines.Add(EdgeTaunt.ReadLine())
            End While

            EdgeTaunt.Close()
            EdgeTaunt.Dispose()

            ETLines = FilterList(ETLines)

            DomTask = ETLines(randomizer.Next(0, ETLines.Count))

            TypingDelayGeneric()

            EdgeTauntInt = randomizer.Next(15, 31)


        End If

    End Sub



    Private Sub ChatText_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles ChatText.DocumentCompleted
        ScrollChatDown()
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles ChatText.Navigating
        ' e.Cancel = True
    End Sub



    Public Sub CreateTaskLetter()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Greeting.txt"
        TaskText = ""

        Dim TaskRead As New StreamReader(TaskFile)
        Dim TaskLines As New List(Of String)
        Dim TaskEntry As String

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()

        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Intro.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Task_1.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Link_1-2.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()


        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Task_2.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()


        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Link_2-3.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()


        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()


        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Task_3.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()

        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Outro.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()

        TaskFile = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Tasks\Signature.txt"

        TaskRead = New StreamReader(TaskFile)
        TaskLines.Clear()

        While TaskRead.Peek <> -1
            TaskLines.Add(TaskRead.ReadLine())
        End While

        TaskRead.Close()
        TaskRead.Dispose()

        TaskLines = FilterList(TaskLines)

        TaskEntry = TaskLines(randomizer.Next(0, TaskLines.Count))
        PoundClean(TaskEntry)

        TaskText = TaskText & TaskEntry & " " & Environment.NewLine & Environment.NewLine
        CleanTaskText()
        TaskLines.Clear()

        If FrmSettings.CBHonorificInclude.Checked = True Then
            TaskText = TaskText & FrmSettings.TBHonorific.Text & " " & domName.Text
        Else
            TaskText = TaskText & domName.Text
        End If


        'TaskText = PoundClean(TaskText)

        Dim AtArray2() As String = Split(TaskText)
        For i As Integer = 0 To AtArray2.Length - 1
            'If AtArray(i) = "" Then GoTo AtBreak
            If AtArray2(i) = "" Then GoTo AtNext
            If AtArray2(i).Contains("#") Then
                AtArray2(i) = PoundClean(AtArray2(i))
            End If
AtNext:

        Next

        TaskText = Join(AtArray2)


        Dim TextLines() As String = TaskText.Split(Environment.NewLine)
        Dim TextTemp As String
        For x As Integer = 0 To TextLines.Count - 1
            Dim AtArray() As String = Split(TextLines(x))
            For i As Integer = 0 To AtArray.Length - 1
                If AtArray(i).Contains("@") Then AtArray(i) = ""
            Next
            TextLines(x) = Join(AtArray)
            If TextLines(x).Substring(0, 1) = " " Then
                Do
                    TextLines(x) = TextLines(x).Remove(0, 1)
                Loop Until Not TextLines(x).Substring(0, 1) = " "

            End If
            TextTemp = TextTemp & TextLines(x) & Environment.NewLine
            'TextLines(x) = Join(AtArray)
        Next

        TaskText = TextTemp






        Dim TempDate As String
        Dim TempDateNow As DateTime = DateTime.Now

        TempDate = TempDateNow.ToString("M dd")

        TaskTextDir = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Received Files\Tasks for " & TempDate & ".txt"
        My.Computer.FileSystem.WriteAllText(TaskTextDir, TaskText, False)


        LBLFileTransfer.Text = domName.Text & " is sending you a file!"
        PNLFileTransfer.Visible = True


        StupidTick = 1
        StupidTimer.Start()

        Do
            Application.DoEvents()
        Loop Until StupidFlag = True
        'Delay(1)

        PBFileTransfer.Value = 1

        StupidFlag = False
        StupidTick = 1
        StupidTimer.Start()

        Do
            Application.DoEvents()
        Loop Until StupidFlag = True
        'Delay(1)

        PBFileTransfer.Value = 2

        StupidFlag = False
        StupidTick = 1
        StupidTimer.Start()

        Do
            Application.DoEvents()
        Loop Until StupidFlag = True
        'Delay(1)

        PBFileTransfer.Value = 3

        StupidFlag = False
        StupidTick = 1
        StupidTimer.Start()

        Do
            Application.DoEvents()
        Loop Until StupidFlag = True
        'Delay(1)

        LBLFileTransfer.Text = "Download complete!"
        BTNFileTransferOpen.Visible = True
        BTNFIleTransferDismiss.Visible = True


    End Sub


    Public Sub CleanTaskText()

        Dim i As Integer

        If TaskText.Contains("#TaskEdges") Then
            Do
                i = randomizer.Next(5, 21) * FrmSettings.domlevelNumBox.Value
                i = 5 * Math.Round(i / 5)
                TaskText = TaskText.Replace("#TaskEdges", i)
            Loop Until Not TaskText.Contains("#TaskEdges")
        End If

        If TaskText.Contains("#TaskStrokes") Then
            Do
                i = randomizer.Next(50, 201) * FrmSettings.domlevelNumBox.Value
                i = 10 * Math.Round(i / 10)
                TaskText = TaskText.Replace("#TaskStrokes", i)
            Loop Until Not TaskText.Contains("#TaskStrokes")
        End If

        If TaskText.Contains("#TaskHours") Then
            Do
                i = randomizer.Next(1, FrmSettings.domlevelNumBox.Value + 1) + FrmSettings.domlevelNumBox.Value
                TaskText = TaskText.Replace("#TaskHours", i)
            Loop Until Not TaskText.Contains("#TaskHours")
        End If

        If TaskText.Contains("#TaskMinutes") Then
            Do
                i = randomizer.Next(5, 13) * FrmSettings.domlevelNumBox.Value
                TaskText = TaskText.Replace("#TaskMinutes", i)
            Loop Until Not TaskText.Contains("#TaskMinutes")
        End If

        If TaskText.Contains("#TaskSeconds") Then
            Do
                i = randomizer.Next(10, 30) * FrmSettings.domlevelNumBox.Value * randomizer.Next(1, FrmSettings.domlevelNumBox.Value + 1)
                TaskText = TaskText.Replace("#TaskSeconds", i)
            Loop Until Not TaskText.Contains("#TaskSeconds")
        End If

        If TaskText.Contains("#TaskAmountLarge") Then
            Do
                i = (randomizer.Next(15, 26) * FrmSettings.domlevelNumBox.Value) * 2
                i = 5 * Math.Round(i / 5)
                TaskText = TaskText.Replace("#TaskAmountLarge", i)
            Loop Until Not TaskText.Contains("#TaskAmountLarge")
        End If

        If TaskText.Contains("#TaskAmountSmall") Then
            Do
                i = (randomizer.Next(15, 26) * FrmSettings.domlevelNumBox.Value) / 2
                i = 5 * Math.Round(i / 5)
                TaskText = TaskText.Replace("#TaskAmountSmall", i)
            Loop Until Not TaskText.Contains("#TaskAmountSmall")
        End If

        If TaskText.Contains("#TaskAmount") Then
            Do
                i = randomizer.Next(15, 26) * FrmSettings.domlevelNumBox.Value
                i = 5 * Math.Round(i / 5)
                TaskText = TaskText.Replace("#TaskAmount", i)
            Loop Until Not TaskText.Contains("#TaskAmount")
        End If






    End Sub


    Private Sub BTNFIleTransferDismiss_Click(sender As System.Object, e As System.EventArgs) Handles BTNFIleTransferDismiss.Click

        PNLFileTransfer.Visible = False
        BTNFileTransferOpen.Visible = False
        BTNFIleTransferDismiss.Visible = False
        LBLFileTransfer.Text = domName.Text & " is sending you a file!"
        PBFileTransfer.Value = 0

    End Sub

    Public Function ShellExecute(ByVal File As String) As Boolean
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Function


    Public Sub BTNFileTransferOpen_Click(sender As System.Object, e As System.EventArgs) Handles BTNFileTransferOpen.Click

        ShellExecute(TaskTextDir)

        PNLFileTransfer.Visible = False
        BTNFileTransferOpen.Visible = False
        BTNFIleTransferDismiss.Visible = False
        LBLFileTransfer.Text = domName.Text & " is sending you a file!"
        PBFileTransfer.Value = 0

    End Sub



    Private Sub SlideshowTimer_Tick(sender As System.Object, e As System.EventArgs) Handles SlideshowTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If SlideshowLoaded = False Or FrmSettings.timedRadio.Checked = False Or TeaseVideo = True Or LockImage = True Then Return

        SlideshowTimerTick -= 1

        If SlideshowTimerTick < 1 Then

TryNext:
            FileCount += 1
            'Debug.Print("Filecount = " & FileCount)
            'Debug.Print("FileCOuntMax = " & FileCountMax)
            If FileCount > FileCountMax Then
                FileCount = 0
            End If

            If File.Exists(_ImageFileNames(FileCount)) Then
            Else
                Return
            End If

            If _ImageFileNames(FileCount).Contains(".db") Then GoTo TryNext

            Try
                If Not mainPictureBox Is Nothing Then
                    mainPictureBox.Image.Dispose()
                    mainPictureBox.Image = Nothing
                    GC.Collect()
                End If
            Catch
            End Try

            If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

            Try
                mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
                ShowImageInfo()
            Catch
                GoTo TryNext
            End Try


            If FrmSettings.landscapeCheckBox.Checked = True Then
                If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                    mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If


            mainPictureBox.Refresh()
            mainPictureBox.Invalidate()

            SlideshowTimerTick = FrmSettings.slideshowNumBox.Value
        End If

    End Sub

    Public Sub GetEdgeTickCheck()

        If AlreadyStrokingEdge = True Then

            If AvgEdgeCount < 5 Then
                EdgeTickCheck = 60
            Else
                EdgeTickCheck = AvgEdgeStroking
            End If

        Else

            If AvgEdgeCountRest < 5 Then
                EdgeTickCheck = 300
            Else
                EdgeTickCheck = AvgEdgeNoTouch
            End If

        End If

    End Sub



    Private Sub EdgeCountTimer_Tick(sender As System.Object, e As System.EventArgs) Handles EdgeCountTimer.Tick
        EdgeCountTick += 1









        If FrmSettings.CBEdgeUseAvg.Checked = True Then
            If EdgeCountTick > EdgeTickCheck Then LongEdge = True
        Else
            If EdgeCountTick > FrmSettings.NBLongEdge.Value Then LongEdge = True
        End If




        Dim m As Integer = TimeSpan.FromSeconds(EdgeCountTick).Minutes
        Dim s As Integer = TimeSpan.FromSeconds(EdgeCountTick).Seconds


        Dim TST As TimeSpan = TimeSpan.FromSeconds(EdgeCountTick)

        ''Debug.Print("{0:c} : {1:c}", TST.Minutes, TST.Seconds)



        'Debug.Print("EdgeCountTick = " & String.Format("{0:00}:{1:00}", TST.Minutes, TST.Seconds))
    End Sub

    Private Sub StrokeTimeTotalTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StrokeTimeTotalTimer.Tick

        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If SubStroking = False Then Return

        StrokeTimeTotal += 1
        'Debug.Print("StrokeTimeTotal = " & StrokeTimeTotal)

        My.Settings.StrokeTimeTotal = StrokeTimeTotal
        My.Settings.Save()

        Dim STT As TimeSpan = TimeSpan.FromSeconds(StrokeTimeTotal)

        'LBLStrokeTimeTotal.Text = String.Format("{0:000} D {1:00} H {2:00} M {3:00} S", STT.Days, STT.Hours, STT.Minutes, STT.Seconds)
        FrmSettings.LBLStrokeTimeTotal.Text = String.Format("{0:0000}:{1:00}:{2:00}:{3:00}", STT.Days, STT.Hours, STT.Minutes, STT.Seconds)


    End Sub




    Public Sub PlayRandomJOI()

        Dim JOIVideos As New List(Of String)
        JOIVideos.Clear()

        If FrmSettings.LblVideoJOITotal.Text <> "0" Then

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.wmv")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.avi")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mp4")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mov")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.m4v")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOI.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mpg")
                JOIVideos.Add(foundFile)
            Next
        End If



        If FrmSettings.LblVideoJOITotalD.Text <> "0" Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.wmv")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.avi")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mp4")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mov")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.m4v")
                JOIVideos.Add(foundFile)
            Next
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoJOID.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.mpg")
                JOIVideos.Add(foundFile)
            Next
        End If

        If JOIVideos.Count < 1 Then
            MessageBox.Show(Me, "No JOI Videos found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If TeaseVideo = True Then RunFileText()
            TeaseVideo = False
            Return
        End If

        Dim JOIVideoLine As Integer = randomizer.Next(0, JOIVideos.Count)

        DomWMP.Visible = True
        DomWMP.stretchToFit = True

        mainPictureBox.Visible = False

        DomWMP.URL = JOIVideos(JOIVideoLine)


    End Sub


    Public Sub PlayRandomCH()

        Dim CHVideos As New List(Of String)
        CHVideos.Clear()

        If FrmSettings.LblVideoCHTotal.Text <> "0" Then

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoCH.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                If foundFile.Contains(".wmv") Or foundFile.Contains(".avi") Or foundFile.Contains(".mp4") Or foundFile.Contains(".mov") Or foundFile.Contains(".flv") Or foundFile.Contains(".m4v") Or foundFile.Contains(".mpg") Then CHVideos.Add(foundFile)
            Next
        End If
        If FrmSettings.LblVideoCHTotalD.Text <> "0" Then
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(FrmSettings.LblVideoCHD.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                If foundFile.Contains(".wmv") Or foundFile.Contains(".avi") Or foundFile.Contains(".mp4") Or foundFile.Contains(".mov") Or foundFile.Contains(".flv") Or foundFile.Contains(".m4v") Or foundFile.Contains(".mpg") Then CHVideos.Add(foundFile)
            Next
        End If

        If CHVideos.Count < 1 Then
            MessageBox.Show(Me, "No CH Videos found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If TeaseVideo = True Then RunFileText()
            TeaseVideo = False
            Return
        End If

        Dim CHVideoLine As Integer = randomizer.Next(0, CHVideos.Count)

        DomWMP.Visible = True
        DomWMP.stretchToFit = True

        mainPictureBox.Visible = False

        DomWMP.URL = CHVideos(CHVideoLine)


    End Sub




    Private Sub TnAFastSlides_Tick(sender As System.Object, e As System.EventArgs) Handles TnASlides.Tick

        Dim TnARandom As Integer = randomizer.Next(1, 101)

        If TnARandom < 51 Then

            mainPictureBox.LoadFromUrl(BoobList(randomizer.Next(0, BoobList.Count)))
            ShowImageInfo()
            BoobImage = True
            AssImage = False

        Else

            mainPictureBox.LoadFromUrl(AssList(randomizer.Next(0, AssList.Count)))
            ShowImageInfo()
            BoobImage = False
            AssImage = True

        End If



        ''Debug.Print("TNAFASTSLIDES CALLED")


    End Sub



    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs)

        Dim sVar As String

        sVar = "<head>" & vbCrLf &
"  <meta content=""text/html; charset=ISO-8859-1""" & vbCrLf &
" http-equiv=""content-type"">" & vbCrLf &
"  <title>OKay</title>" & vbCrLf &
"</head>" & vbCrLf &
"<body>" & vbCrLf &
"<span style=""font-weight: bold;""><span" & vbCrLf &
" style=""color: red;""><big><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);"">@Chance</span></big><span" & vbCrLf &
" style=""color: rgb(51, 51, 255);""><big>X</big><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);""><big><span" & vbCrLf &
" style=""color: rgb(51, 51, 255);"">X</span>( )</big><br>" & vbCrLf &
"<span style=""font-weight: bold;""></span></span></span></span></span><span" & vbCrLf &
" style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Domme" & vbCrLf &
"has <span style=""color: rgb(51, 51, 255);"">XX</span>" & vbCrLf &
"percent chance of going to the line in parentheses. Similar to the <span" & vbCrLf &
" style=""color: rgb(204, 0, 0);"">@Goto( )</span>" & vbCrLf &
"&nbsp;Command. For example, <span style=""color: rgb(204, 0, 0);"">@Chance</span></span></span></span></span><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);""></span><span" & vbCrLf &
" style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);""><span style=""color: black;""><span" & vbCrLf &
" style=""color: rgb(204, 0, 0);"">50(Because I Said So)</span>" & vbCrLf
        sVar = sVar & "would have a 50% chance of going to the next line in the</span></span></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""> </span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span" & vbCrLf &
        " style=""color: rgb(51, 0, 0);"">script, and 50% chance of" & vbCrLf &
        "going to the line (Because I Said So). <span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);"">XX</span> must be a" & vbCrLf &
        "2-digit number between 01 and 99.</span><br>" & vbCrLf &
        "</span></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "</span></span></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "@CheckFlag</span></big><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><big><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""></span>( )</big></span></span></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">The" & vbCrLf &
        "program checks to see if the Flag named in parentheses has been" & vbCrLf
        sVar = sVar & "created, and will go to that line in the script if it has. Similar to" & vbCrLf &
        "the <span style=""color: rgb(204, 0, 0);"">@Goto( )</span>" & vbCrLf &
        "Command. For example, <span style=""color: rgb(204, 0, 0);"">@CheckFlag(MyFlag1)</span>" & vbCrLf &
        "goes to the next line of the script if the flag MyFlag1 does not exist." & vbCrLf &
        "and goes to the line (MyFlag1) if it does. Flags are created with the <span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@SetFlag( )</span>" & vbCrLf &
        "Command.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "@DislikeBlogImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">The" & vbCrLf &
        "program adds the URL address of the most recently displayed blog image" & vbCrLf &
        "and adds it to the file ""DislikedImageURLs.txt"" located in" & vbCrLf &
        """\Images\System\""<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "</span></span></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@Edge</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge of orgasm and begin displaying Edge Taunts. Once the sub lets" & vbCrLf &
        "the domme know he has reached the edge, the domme will then decide to" & vbCrLf &
        "let him stop stroking or hold it. Modules must contain <span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StopStroking</span> or" & vbCrLf &
        "one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeHold</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him hold it. Modules" & vbCrLf &
        "must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf &
        "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf
        sVar = sVar & "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeNoHold</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him stop stroking." & vbCrLf &
        "Modules must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf &
        "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuin</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf
        sVar = sVar & "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will then decide to let him" & vbCrLf &
        "stop stroking or hold it. In either case, the sub will be instructed to" & vbCrLf &
        "ruin his orgasm. Modules must contain <span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StopStroking</span> or" & vbCrLf &
        "one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuinSecret</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will then decide to let him" & vbCrLf &
        "stop stroking or hold it. In either case, the sub will be instructed to" & vbCrLf &
        "ruin his orgasm. This Command will prevent the domme from letting the" & vbCrLf &
        "sub know his orgasm will be ruined during Edge and Hold The Edge" & vbCrLf &
        "Taunts. Modules must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf
        sVar = sVar & "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuinHold</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him hold it. At some" & vbCrLf &
        "point during holding the edge, the sub will be instructed to ruin his" & vbCrLf &
        "orgasm. Modules must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf &
        "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuinHoldSecret</span></big></span></span><br>" & vbCrLf
        sVar = sVar & "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him hold it. At some" & vbCrLf &
        "point during holding the edge, the sub will be instructed to ruin his" & vbCrLf &
        "orgasm. </span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command will prevent the domme from letting the sub know his orgasm" & vbCrLf &
        "will be ruined during Edge and Hold The Edge Taunts. </span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Modules" & vbCrLf &
        "must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf &
        "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuinNoHold</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him ruin his" & vbCrLf &
        "orgasm.&nbsp;Modules must contain <span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StopStroking</span> or" & vbCrLf &
        "one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@EdgeToRuinNoHoldSecret</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command let's the program now the sub&nbsp;has been told to get to" & vbCrLf &
        "the edge" & vbCrLf &
        "of orgasm and begin displaying Edge Taunts. Once the sub lets the domme" & vbCrLf &
        "know he has reached the edge, the domme will make him ruin his" & vbCrLf &
        "orgasm.&nbsp;</span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(204, 0, 0);""><span style=""color: black;""></span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command will prevent the domme from letting the sub know his orgasm" & vbCrLf &
        "will be ruined during Edge&nbsp;Taunts.</span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Modules" & vbCrLf &
        "must contain <span style=""color: rgb(204, 0, 0);"">@StopStroking</span>" & vbCrLf &
        "or one of the <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands. <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Commands can be used in any Linear script.</span></span></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;""><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "</span></span></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@LikeBlogImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">The" & vbCrLf &
        "program adds the URL address of the most recently displayed blog image" & vbCrLf &
        "and adds it to the file ""LikedImageURLs.txt"" located in" & vbCrLf &
        """\Images\System\""</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf
        sVar = sVar & "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "@ShowBlogImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Displays" & vbCrLf &
        "a random online image from one of the user's selected URL Files.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "@ShowImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Has" & vbCrLf &
        "a 50% chance of diplaying a random online image from one of the user's" & vbCrLf &
        "selected URL Files, or a 50% chance of displaying a </span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">random&nbsp;image" & vbCrLf &
        "from one of the user's selected Local Image File paths.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf
        sVar = sVar & "@Show</span></big></span></span><span" & vbCrLf &
        " style=""font-weight: bold;""><span style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">Image[ ]</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Displays" & vbCrLf &
        "a specific image noted between the brackets, using ""<span" & vbCrLf &
        " style=""font-style: italic;"">Tease AI Root Folder</span>\Images\""" & vbCrLf &
        "as the starting path.&nbsp; For example, <span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@ShowImage[1885\secrets05.jpg]</span>" & vbCrLf &
        "would display the picture secrets05.jpg located in </span></span></span></span><span" & vbCrLf &
        " style=""color: red;""><span style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">""<span" & vbCrLf &
        " style=""font-style: italic;"">Tease AI Root Folder</span>\Images\1885\""</span></span></span></span>.<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><br>" & vbCrLf &
        "@ShowLocalImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Displays" & vbCrLf &
        "a random&nbsp;image from one of the user's selected Local Image" & vbCrLf &
        "File paths.</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf
        sVar = sVar & "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@ShowDislikedImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Displays" & vbCrLf &
        "a random image taken from&nbsp;""DislikedImageURLs.txt"" located in" & vbCrLf &
        """\Images\System\""</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@ShowLikedImage</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Displays" & vbCrLf &
        "a random image taken from&nbsp;""LikedImageURLs.txt"" located in" & vbCrLf &
        """\Images\System\""</span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StartStroking</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Begins" & vbCrLf &
        "the Taunt cycle. This lets the program know the sub is stroking and" & vbCrLf &
        "allows the domme to start using Stroke Taunts. This command MUST be" & vbCrLf &
        "used in the line before every <span style=""color: rgb(204, 0, 0);"">@End</span>" & vbCrLf &
        "command in each Start and Link script (unless the tease is being ended" & vbCrLf &
        "or an Interrupt is called) <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Start and" & vbCrLf &
        "Link scripts ONLY.</span></span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StartTaunts</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Begins" & vbCrLf &
        "the Taunt cycle when the sub can't stroke.&nbsp;This lets the" & vbCrLf &
        "program know to begin the appropriate Taunt cycle. Currently this is" & vbCrLf &
        "only used for for the Chastity state, but may encompass other states in" & vbCrLf &
        "the future. This command MUST be" & vbCrLf &
        "used in the line before every <span style=""color: rgb(204, 0, 0);"">@End</span>" & vbCrLf &
        "command in each Chastity Start and Link script (unless the tease is" & vbCrLf &
        "being ended or an Interrupt is called) <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Chastity" & vbCrLf
        sVar = sVar & "Start and Link scripts ONLY.</span></span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StopStroking</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">This" & vbCrLf &
        "Command is used in Modules to let the program know that the sub is no" & vbCrLf &
        "longer stroking.&nbsp;<span style=""color: rgb(204, 0, 0);""></span>Each" & vbCrLf &
        "Module MUST contain this or an <span style=""color: rgb(204, 0, 0);"">@Edge</span>" & vbCrLf &
        "Command. <span style=""font-weight: bold; color: rgb(204, 0, 0);"">Module" & vbCrLf &
        "scripts ONLY.</span></span></span></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StrokeFaster</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Increases" & vbCrLf &
        "the speed the user is stroking by one. This lets the domme know the sub" & vbCrLf &
        "is stroking faster, and slightly speeds up the silent metronome. <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Stroke" & vbCrLf
        sVar = sVar & "Taunts&nbsp;</span></span></span></span></span><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span" & vbCrLf &
        " style=""font-weight: bold;"">ONLY</span><span" & vbCrLf &
        " style=""font-weight: bold;"">.</span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StrokeFastest</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Increases" & vbCrLf &
        "the speed the user is stroking by full value. This lets the domme know" & vbCrLf &
        "the sub" & vbCrLf &
        "is stroking as fast as possible, and speeds up the silent metronome to" & vbCrLf &
        "its highest setting. <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Stroke" & vbCrLf &
        "Taunts&nbsp;</span></span></span></span></span><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span" & vbCrLf &
        " style=""font-weight: bold;"">ONLY</span><span" & vbCrLf &
        " style=""font-weight: bold;"">.</span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(204, 0, 0);"">@StrokeSlower</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Decreases" & vbCrLf &
        "the speed the user is stroking by one. This lets the domme know the sub" & vbCrLf &
        "is stroking slower, and slightly slows down the silent metronome. <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Stroke" & vbCrLf &
        "Taunts&nbsp;</span></span></span></span></span><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span" & vbCrLf &
        " style=""font-weight: bold;"">ONLY</span><span" & vbCrLf &
        " style=""font-weight: bold;"">.</span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);"">@StrokeSlowest</span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;"">Decreases" & vbCrLf &
        "the speed the user is stroking by full value. This lets the domme know" & vbCrLf &
        "the sub" & vbCrLf &
        "is stroking as slow as possible, and&nbsp; slows down the silent" & vbCrLf &
        "metronome to its lowest setting. <span" & vbCrLf &
        " style=""font-weight: bold; color: rgb(204, 0, 0);"">Stroke" & vbCrLf &
        "Taunts&nbsp;</span></span></span></span></span><span" & vbCrLf
        sVar = sVar & " style=""color: rgb(204, 0, 0);""><span" & vbCrLf &
        " style=""font-weight: bold;"">ONLY</span><span" & vbCrLf &
        " style=""font-weight: bold;"">.</span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""></span></big></span></span><br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<br>" & vbCrLf &
        "<span style=""font-weight: bold;""><span" & vbCrLf &
        " style=""color: red;""><big><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""></span></big></span></span><br>" & vbCrLf &
        "<span style=""color: red;""><span" & vbCrLf &
        " style=""color: rgb(51, 51, 255);""><span" & vbCrLf &
        " style=""color: rgb(204, 0, 0);""><span style=""color: black;""><br>" & vbCrLf &
        "</span></span></span></span>" & vbCrLf &
        "</body>" & vbCrLf &
        "</html>"


        'frmApps.WEBScriptGuide.DocumentText = sVar

        'frmApps.PNLScriptGuide.Visible = True
        frmApps.PNLAppHome.Visible = False

    End Sub








    Private Sub Button36_Click_1(sender As System.Object, e As System.EventArgs)

        Dim Result As Integer = MessageBox.Show(Me, "This is will reset all settings and close the program." & Environment.NewLine & Environment.NewLine & "You will then need to open it again. Do you wish to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = DialogResult.Yes Then
            My.Settings.Reset()
            Application.Exit()
            Return
        End If

    End Sub

    Private Sub ImageFolderComboBox_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ImageFolderComboBox.MouseWheel
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        mwe.Handled = True
    End Sub

    Private Sub ImageFolderComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ImageFolderComboBox.SelectedIndexChanged



        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If



        If My.Computer.FileSystem.DirectoryExists(ImageFolderComboBox.Text) Then

            SlideshowLoaded = True

            'domVLC.playlist.pause()
            'domVLC.Visible = False
            DomWMP.Visible = False
            DomWMP.Ctlcontrols.pause()
            mainPictureBox.Visible = True
            'programsettingsPanel.Visible = False


            FrmSettings.timedRadio.Enabled = True
            FrmSettings.teaseRadio.Enabled = True

            FileCount = 0
            FileCountMax = -1
            _ImageFileNames.Clear()

            GetFolder = ImageFolderComboBox.Text

            Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
            'Dim files As String() = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)

            Dim files As String()

            If FrmSettings.CBSlideshowSubDir.Checked = True Then
                files = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)
            Else
                files = Directory.GetFiles(GetFolder, "*.*")
            End If


            ' Dim files As String() = Directory.GetFiles(GetFolder, "*.*")
            Array.Sort(files)
            ' For Each fi As String In files
            'If supportedExtensions.Contains(Path.GetExtension(fi)) Then
            '_ImageFileNames.AddRange(files)
            'End If
            '   Next

            Dim TestCOUnt As Integer = 0
            For Each fi As String In files
                If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                    TestCOUnt += 1
                    'Debug.Print("fi = " & fi)
                    _ImageFileNames.Add(fi)
                End If
            Next

            ' If FrmSettings.CBSlideshowSubDir.Checked = True Then
            'FileCountMax = Directory.GetFiles(GetFolder, "*.jpg", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.png", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.gif", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp", SearchOption.AllDirectories).Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg", SearchOption.AllDirectories).Count
            'Else
            '   FileCountMax = Directory.GetFiles(GetFolder, "*.jpg").Count
            '  FileCountMax += Directory.GetFiles(GetFolder, "*.png").Count
            ' FileCountMax += Directory.GetFiles(GetFolder, "*.gif").Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp").Count
            'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg").Count
            'End If

            FileCountMax = _ImageFileNames.Count - 1

            'Debug.Print("FileCOuntMax = " & FileCountMax)

            ' If FileCountMax = -1 Then
            If FileCountMax < 1 Then
                MessageBox.Show(Me, "There are no images in the specified folder.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            ' Begin Next Button
            FileCount = 0

            If Not mainPictureBox Is Nothing Then
                Try
                    mainPictureBox.Image.Dispose()
                    mainPictureBox.Image = Nothing
                    GC.Collect()
                Catch
                End Try
            End If

            If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

            mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
            ShowImageInfo()

            If FrmSettings.landscapeCheckBox.Checked = True Then
                If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                    mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If

            mainPictureBox.Refresh()
            mainPictureBox.Invalidate()

            If FrmSettings.timedRadio.Checked = True Then
                SlideshowTimerTick = FrmSettings.slideshowNumBox.Value
                SlideshowTimer.Start()
            End If

        Else

            ImageFolderComboBox.Text = "Not a valid directory"

        End If






    End Sub



    Private Sub ImageFolderComboBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ImageFolderComboBox.KeyPress



        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then
            MsgBox("Please close the settings menu or disable ""Pause Program When Settings Menu is Visible"" option first!", , "Warning!")
            Return
        End If

        If e.KeyChar = Convert.ToChar(13) Then

            e.Handled = True
            ' sendButton.PerformClick()
            e.KeyChar = Chr(0)

            If My.Computer.FileSystem.DirectoryExists(ImageFolderComboBox.Text) Then

                GetFolder = ImageFolderComboBox.Text

                RecentSlideshows.Add(GetFolder)

                Do Until RecentSlideshows.Count < 11
                    RecentSlideshows.Remove(RecentSlideshows(0))
                Loop

                'Debug.Print(RecentSlideshows(0))

                ImageFolderComboBox.Items.Clear()

                For Each comboitem As String In RecentSlideshows
                    ImageFolderComboBox.Items.Add(comboitem)
                Next

                ImageFolderComboBox.Text = GetFolder

                My.Settings.RecentSlideshows.Add(GetFolder)

                My.Settings.RecentSlideshows.Clear()

                For i As Integer = 0 To RecentSlideshows.Count - 1
                    My.Settings.RecentSlideshows.Add(RecentSlideshows(i))
                Next

                My.Settings.Save()


                SlideshowLoaded = True

                ' domVLC.playlist.pause()
                'domVLC.Visible = False
                DomWMP.Visible = False
                DomWMP.Ctlcontrols.pause()
                mainPictureBox.Visible = True
                'programsettingsPanel.Visible = False


                FrmSettings.timedRadio.Enabled = True
                FrmSettings.teaseRadio.Enabled = True

                FileCount = 0
                FileCountMax = -1
                _ImageFileNames.Clear()



                Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"
                'Dim files As String() = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)

                Dim files As String()

                If FrmSettings.CBSlideshowSubDir.Checked = True Then
                    files = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)
                Else
                    files = Directory.GetFiles(GetFolder, "*.*")
                End If


                ' Dim files As String() = Directory.GetFiles(GetFolder, "*.*")
                Array.Sort(files)

                ' For Each fi As String In files
                'If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                '_ImageFileNames.AddRange(files)
                'End If
                '   Next

                Dim TestCOUnt As Integer = 0
                For Each fi As String In files
                    If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                        TestCOUnt += 1
                        'Debug.Print("fi = " & fi)
                        _ImageFileNames.Add(fi)
                    End If
                Next

                ' If FrmSettings.CBSlideshowSubDir.Checked = True Then
                'FileCountMax = Directory.GetFiles(GetFolder, "*.jpg", SearchOption.AllDirectories).Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.png", SearchOption.AllDirectories).Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.gif", SearchOption.AllDirectories).Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp", SearchOption.AllDirectories).Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg", SearchOption.AllDirectories).Count
                'Else
                '   FileCountMax = Directory.GetFiles(GetFolder, "*.jpg").Count
                '  FileCountMax += Directory.GetFiles(GetFolder, "*.png").Count
                ' FileCountMax += Directory.GetFiles(GetFolder, "*.gif").Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.bmp").Count
                'FileCountMax += Directory.GetFiles(GetFolder, "*.jpeg").Count
                'End If

                FileCountMax = _ImageFileNames.Count - 1

                'Debug.Print("FileCOuntMax = " & FileCountMax)

                ' If FileCountMax = -1 Then
                If FileCountMax < 1 Then
                    MessageBox.Show(Me, "There are no images in the specified folder.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If


                ' Begin Next Button
                FileCount = 0

                If Not mainPictureBox Is Nothing Then
                    Try
                        mainPictureBox.Image.Dispose()
                        mainPictureBox.Image = Nothing
                        GC.Collect()
                    Catch
                    End Try
                End If

                If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

                mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
                ShowImageInfo()

                If FrmSettings.landscapeCheckBox.Checked = True Then
                    If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                        mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                    Else
                        mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    End If
                Else
                    mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                End If

                mainPictureBox.Refresh()
                mainPictureBox.Invalidate()

                If FrmSettings.timedRadio.Checked = True Then
                    SlideshowTimerTick = FrmSettings.slideshowNumBox.Value
                    SlideshowTimer.Start()
                End If

            Else

                ImageFolderComboBox.Text = "Not a valid directory"

            End If



        End If


    End Sub


    Public Sub ShowImageInfo()
        'Debug.Print("ShowImageCalled")
        'Debug.Print(mainPictureBox.ImageLocation)
        If FrmSettings.CBImageInfo.Checked = True Then
            Try
                If JustShowedBlogImage = True Then
                    LBLImageInfo.Text = FoundString
                Else
                    LBLImageInfo.Text = _ImageFileNames(FileCount)
                End If

                'LBLImageInfo.Text = "Test"
            Catch ex As Exception
                LBLImageInfo.Text = "Error!"
            End Try
        End If
    End Sub



    Private Sub DomWMP_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles DomWMP.PlayStateChange

        If (DomWMP.playState = WMPLib.WMPPlayState.wmppsStopped) Then
            'Debug.Print("WMP Stopped Called")





            If CensorshipGame = True Then
                CensorshipTimer.Stop()
                CensorshipBar.Visible = False
                CensorshipGame = False
                VideoTease = False
                mainPictureBox.Visible = True
                DomWMP.Visible = False

                'SkipGotoLine = True
                'If CensorshipTimerTick < 1 Then
                'FileGoto = "(Censorship Sucks Video Stop)"
                'Else
                'FileGoto = "(Censorship Sucks Video Continue)"
                'End If
                'GetGoto()

                If RandomizerVideoTease = True Then
                    ScriptTimer.Stop()
                    SaidHello = False
                    RandomizerVideoTease = False
                    StopEverything()
                    Return
                End If

                RunFileText()
            End If

            If AvoidTheEdgeGame = True Then

                TeaseVideo = False
                AvoidTheEdgeGame = False
                AvoidTheEdgeStroking = False
                AvoidTheEdgeTaunts.Stop()
                VideoTease = False
                SubStroking = False


                Debug.Print("TempStrokeTauntVal = " & TempStrokeTauntVal)
                Debug.Print("TempFileText = " & TempFileText)


                If RandomizerVideoTease = True Then
                    ScriptTimer.Stop()
                    SaidHello = False
                    RandomizerVideoTease = False
                    StopEverything()
                    Return
                End If

                StrokeTauntVal = TempStrokeTauntVal
                FileText = TempFileText

                ScriptTick = 2
                ScriptTimer.Start()

                'RunFileText()



                mainPictureBox.Visible = True
                DomWMP.Visible = False


                'AvoidTheEdge.Stop()
                'AvoidTheEdgeGame = False
                'SkipGotoLine = True
                'If AvoidTheEdgeTimerTick < 1 Then
                'FileGoto = "(AvoidTheEdge Video Stop)"
                'Else
                '   FileGoto = "(AvoidTheEdge Video Continue)"
                'End If
                'GetGoto()
                'RunFileText()
            End If

            If RLGLGame = True Then
                RLGLTimer.Stop()
                RLGLTauntTimer.Stop()
                RLGLGame = False
                VideoTease = False
                SubStroking = False


                If RandomizerVideoTease = True Then
                    ScriptTimer.Stop()
                    SaidHello = False
                    RandomizerVideoTease = False
                    StopEverything()
                    Return
                End If

                ScriptTick = 1
                ScriptTimer.Start()
                mainPictureBox.Visible = True
                DomWMP.Visible = False

                Return
            End If


            If TeaseVideo = True Then
                TeaseVideo = False
                DomWMP.Visible = False
                DomWMP.Ctlcontrols.pause()
                mainPictureBox.Visible = True
                RunFileText()
            End If



        End If

    End Sub

    Private Sub domAvatar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles domAvatar.MouseEnter
        If FrmSettings.Visible = False And FrmCardList.Visible = False Then domAvatar.Focus()
    End Sub

    Private Sub domAvatar_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles domAvatar.MouseWheel



        If domAvatar.SizeMode = PictureBoxSizeMode.StretchImage Then
            domAvatar.SizeMode = PictureBoxSizeMode.Zoom
            My.Settings.DomAVStretch = False
        Else
            domAvatar.SizeMode = PictureBoxSizeMode.StretchImage
            My.Settings.DomAVStretch = True
        End If
        My.Settings.Save()

    End Sub
    Private Sub subAvatar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles subAvatar.MouseEnter
        If FrmSettings.Visible = False And FrmCardList.Visible = False Then subAvatar.Focus()
    End Sub

    Private Sub subAvatar_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles subAvatar.MouseWheel



        If subAvatar.SizeMode = PictureBoxSizeMode.StretchImage Then
            subAvatar.SizeMode = PictureBoxSizeMode.Zoom
            My.Settings.SubAvStretch = False
        Else
            subAvatar.SizeMode = PictureBoxSizeMode.StretchImage
            My.Settings.SubAvStretch = True
        End If

        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        TempVal = randomizer.Next(1, 101)
        If TempVal < 51 Then
            GetBlogImage()
        Else
            GetLocalImage()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        Dim Stringclean As String = "@Crazy Check this out @CheckFlag(Test) @ShowImage[1885's Images\image.jpg]"
        Dim ImageClean As String = Stringclean
        Dim StartIndex As Integer = ImageClean.IndexOf("@ShowImage[") + 11
        For i As Integer = 1 To StartIndex
            ImageClean = ImageClean.Remove(0, 1)
        Next
        Dim ImageS As String() = ImageClean.Split("]")
        ImageClean = Application.StartupPath & "\Images\" & ImageS(0)
        ImageClean = ImageClean.Replace("\\", "\")
        Try
            mainPictureBox.LoadFromUrl(ImageClean)
        Catch
            MessageBox.Show(Me, "\" & ImageS(0) & " was not found in " & Application.StartupPath & "\Images!" & Environment.NewLine & Environment.NewLine & "Please make sure the file exists and that it is spelled correctly in the script.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub


    Private Sub WaitTimer_Tick(sender As System.Object, e As System.EventArgs) Handles WaitTimer.Tick
        If FrmSettings.CBSettingsPause.Checked = True And FrmSettings.SettingsPanel.Visible = True Then Return

        If DomTypeCheck = True Or YesOrNo = True Then Return

        'Debug.Print("WaitTick = " & WaitTick)

        WaitTick -= 1

        If WaitTick < 1 Then
            WaitTimer.Stop()
            ScriptTick = 1
        End If


    End Sub

    Private Sub StupidTimer_Tick(sender As System.Object, e As System.EventArgs) Handles StupidTimer.Tick
        StupidTick -= 1

        If StupidTick < 1 Then
            StupidTimer.Stop()
            StupidFlag = True
        End If


    End Sub

    Private Sub PNLAppHome_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub





    Private Sub AppPanelGlitter_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub PNLScriptHelper_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub










    Public Sub SaveExercise()

        If FormLoading = True Then Return

        Dim FileStream As New System.IO.FileStream(Application.StartupPath & "\System\VitalSub\ExerciseList.cld", IO.FileMode.Create)
        Dim BinaryWriter As New System.IO.BinaryWriter(FileStream)
        For i = 0 To frmApps.CLBExercise.Items.Count - 1
            BinaryWriter.Write(CStr(frmApps.CLBExercise.Items(i)))
            BinaryWriter.Write(CBool(frmApps.CLBExercise.GetItemChecked(i)))
        Next
        BinaryWriter.Close()
        FileStream.Dispose()

    End Sub

    Public Sub LoadExercise()

        frmApps.CLBExercise.Items.Clear()
        Dim FileStream As New System.IO.FileStream(Application.StartupPath & "\System\VitalSub\ExerciseList.cld", IO.FileMode.Open)
        Dim BinaryReader As New System.IO.BinaryReader(FileStream)
        frmApps.CLBExercise.BeginUpdate()
        Do While FileStream.Position < FileStream.Length
            frmApps.CLBExercise.Items.Add(BinaryReader.ReadString)
            frmApps.CLBExercise.SetItemChecked(frmApps.CLBExercise.Items.Count - 1, BinaryReader.ReadBoolean)
        Loop
        frmApps.CLBExercise.EndUpdate()
        BinaryReader.Close()
        FileStream.Dispose()


    End Sub









    Public Sub RefreshCards()

        'Dim GoldReader As New StreamReader(Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Apps\Cards\Gold.txt")
        'Dim GoldList As New List(Of String)

        'While GoldReader.Peek <> -1
        'GoldList.Add(GoldReader.ReadLine())
        'End While

        'GoldReader.Close()
        'GoldReader.Dispose()

        FrmCardList.GoldN1.Text = FrmSettings.GN1.Text
        FrmCardList.GoldN2.Text = FrmSettings.GN2.Text
        FrmCardList.GoldN3.Text = FrmSettings.GN3.Text
        FrmCardList.GoldN4.Text = FrmSettings.GN4.Text
        FrmCardList.GoldN5.Text = FrmSettings.GN5.Text
        FrmCardList.GoldN6.Text = FrmSettings.GN6.Text

        FrmCardList.GoldP1.LoadFromUrl(My.Settings.GP1)
        FrmCardList.GoldP2.LoadFromUrl(My.Settings.GP2)
        FrmCardList.GoldP3.LoadFromUrl(My.Settings.GP3)
        FrmCardList.GoldP4.LoadFromUrl(My.Settings.GP4)
        FrmCardList.GoldP5.LoadFromUrl(My.Settings.GP5)
        FrmCardList.GoldP6.LoadFromUrl(My.Settings.GP6)

        FrmCardList.SilverN1.Text = FrmSettings.SN1.Text
        FrmCardList.SilverN2.Text = FrmSettings.SN2.Text
        FrmCardList.SilverN3.Text = FrmSettings.SN3.Text
        FrmCardList.SilverN4.Text = FrmSettings.SN4.Text
        FrmCardList.SilverN5.Text = FrmSettings.SN5.Text
        FrmCardList.SilverN6.Text = FrmSettings.SN6.Text

        FrmCardList.SilverP1.LoadFromUrl(My.Settings.SP1)
        FrmCardList.SilverP2.LoadFromUrl(My.Settings.SP2)
        FrmCardList.SilverP3.LoadFromUrl(My.Settings.SP3)
        FrmCardList.SilverP4.LoadFromUrl(My.Settings.SP4)
        FrmCardList.SilverP5.LoadFromUrl(My.Settings.SP5)
        FrmCardList.SilverP6.LoadFromUrl(My.Settings.SP6)

        FrmCardList.BronzeN1.Text = FrmSettings.BN1.Text
        FrmCardList.BronzeN2.Text = FrmSettings.BN2.Text
        FrmCardList.BronzeN3.Text = FrmSettings.BN3.Text
        FrmCardList.BronzeN4.Text = FrmSettings.BN4.Text
        FrmCardList.BronzeN5.Text = FrmSettings.BN5.Text
        FrmCardList.BronzeN6.Text = FrmSettings.BN6.Text

        FrmCardList.BronzeP1.LoadFromUrl(My.Settings.BP1)
        FrmCardList.BronzeP2.LoadFromUrl(My.Settings.BP2)
        FrmCardList.BronzeP3.LoadFromUrl(My.Settings.BP3)
        FrmCardList.BronzeP4.LoadFromUrl(My.Settings.BP4)
        FrmCardList.BronzeP5.LoadFromUrl(My.Settings.BP5)
        FrmCardList.BronzeP6.LoadFromUrl(My.Settings.BP6)









    End Sub

 

   


 

    Public Sub SaveTokens()

        My.Settings.BronzeTokens = BronzeTokens
        My.Settings.SilverTokens = SilverTokens
        My.Settings.GoldTokens = GoldTokens
        My.Settings.Save()

    End Sub





   

 







    

    Private Sub VideoTauntTimer_Tick(sender As System.Object, e As System.EventArgs) Handles VideoTauntTimer.Tick


        If VideoTauntTick < 4 And DomTypeCheck = True Then Return
        If VideoTauntTick < 4 And chatBox.Text <> "" Then Return

        VideoTauntTick -= 1


        If VideoTauntTick < 1 Then

            Dim FrequencyTemp As Integer = randomizer.Next(1, 101)
            If FrequencyTemp > FrmSettings.TauntSlider.Value * 5 Then
                VideoTauntTick = randomizer.Next(20, 31)
                Return
            End If

            Dim VTDir As String

            If RLGLGame = True Then VTDir = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Red Light Green Light\Taunts.txt"

            If Not File.Exists(VTDir) Then Return


            Dim VTList As New List(Of String)

            Dim VTReader As New StreamReader(VTDir)

            While VTReader.Peek <> -1
                VTList.Add(VTReader.ReadLine())
            End While


            VTReader.Close()
            VTReader.Dispose()

            VTList = FilterList(VTList)

            If VTList.Count < 1 Then Return

            DomTask = VTList(randomizer.Next(0, VTList.Count))
            TypingDelayGeneric()



            VideoTauntTick = randomizer.Next(20, 31)


        End If









    End Sub

    Private Sub TeaseTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TeaseTimer.Tick



        Debug.Print("TeaseTick = " & TeaseTick)

        TeaseTick -= 1

        If TeaseTick < 1 Then TeaseTimer.Stop()



    End Sub

    Public Sub RLGLTauntTimer_Tick(sender As System.Object, e As System.EventArgs) Handles RLGLTauntTimer.Tick


        If RLGLTauntTick < 4 And DomTypeCheck = True Then Return
        If RLGLTauntTick < 4 And chatBox.Text <> "" Then Return

        RLGLTauntTick -= 1


        If RLGLTauntTick < 1 Then

            Dim FrequencyTemp As Integer = randomizer.Next(1, 101)
            If FrequencyTemp > FrmSettings.TauntSlider.Value * 5 Then
                RLGLTauntTick = randomizer.Next(20, 31)
                Return
            End If

            Dim VTDir As String

            VTDir = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Red Light Green Light\Taunts.txt"

            If Not File.Exists(VTDir) Then Return


            Dim VTList As New List(Of String)

            Dim VTReader As New StreamReader(VTDir)

            While VTReader.Peek <> -1
                VTList.Add(VTReader.ReadLine())
            End While


            VTReader.Close()
            VTReader.Dispose()

            VTList = FilterList(VTList)

            If VTList.Count < 1 Then Return

            DomTask = VTList(randomizer.Next(0, VTList.Count))
            TypingDelayGeneric()



            RLGLTauntTick = randomizer.Next(20, 31)


        End If



    End Sub

    Private Sub AvoidTheEdgeTaunts_Tick(sender As System.Object, e As System.EventArgs) Handles AvoidTheEdgeTaunts.Tick


        If AvoidTheEdgeTick < 4 And DomTypeCheck = True Then Return
        If AvoidTheEdgeTick < 4 And chatBox.Text <> "" Then Return



        AvoidTheEdgeTick -= 1


        If AvoidTheEdgeTick < 1 Then

            Dim FrequencyTemp As Integer = randomizer.Next(1, 101)
            If FrequencyTemp > FrmSettings.TauntSlider.Value * 5 Then
                AvoidTheEdgeTick = randomizer.Next(20, 31)
                Return
            End If

            Dim VTDir As String

            VTDir = Application.StartupPath & "\Scripts\" & FrmSettings.dompersonalityComboBox.Text & "\Video\Avoid The Edge\Taunts.txt"

            If Not File.Exists(VTDir) Then Return


            Dim VTList As New List(Of String)

            Dim VTReader As New StreamReader(VTDir)

            While VTReader.Peek <> -1
                VTList.Add(VTReader.ReadLine())
            End While


            VTReader.Close()
            VTReader.Dispose()

            VTList = FilterList(VTList)

            If VTList.Count < 1 Then Return

            DomTask = VTList(randomizer.Next(0, VTList.Count))
            TypingDelayGeneric()



            AvoidTheEdgeTick = randomizer.Next(20, 31)


        End If


    End Sub




    Public Sub LargeUI()

        BTN768.BackColor = Color.SteelBlue
        BTNCompact.BackColor = Color.SteelBlue
        BTN1080.BackColor = Color.White

        BTN768.ForeColor = Color.White
        BTNCompact.ForeColor = Color.White
        BTN1080.ForeColor = Color.SteelBlue

        BTN768.Font = New Font(BTN768.Font.FontFamily, BTN768.Font.Size, FontStyle.Regular)
        BTNCompact.Font = New Font(BTNCompact.Font.FontFamily, BTNCompact.Font.Size, FontStyle.Regular)
        BTN1080.Font = New Font(BTN1080.Font.FontFamily, BTN1080.Font.Size, FontStyle.Bold)

        PNLGlitter.Height = 449
        StatusUpdates.Height = 444

        SP1.Visible = True
        SP2.Visible = True
        SP3.Visible = True
        SP4.Visible = True
        SP5.Visible = True
        SP6.Visible = True
        SP7.Visible = True
        SP8.Visible = True
        SP9.Visible = True
        SP10.Visible = True

        subName.Location = New Point(10, 977)
        SplitContainer1.Height = 988
        SplitContainer1.Width = 1092

        subAvatar.Location = New Point(10, 791)
        Me.Height = 1044
        Me.Width = 1384

        Try
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\System\LargeBack.png")
        Catch ex As Exception
        End Try


        If PNLMediaBar.Visible = True Then
            ChatText.Location = New Point(0, 29)
        Else
            ChatText.Location = New Point(0, 0)
        End If
        ChatText.Width = 1089

        ImageFolderComboBox.Width = 716

        previousButton.Location = New Point(779, -4)
        nextButton.Location = New Point(836, -4)
        BTNLoadVideo.Location = New Point(893, -4)
        BTNVideoControls.Location = New Point(969, -4)

        If PNLMediaBar.Visible = True Then
            PNLChatBox.Location = New Point(0, ChatText.Height + 23)
        Else
            PNLChatBox.Location = New Point(0, ChatText.Height - 6)
        End If

        DomWMP.Location = New Point(0, 0)
        DomWMP.Width = SplitContainer1.Width
        ' DomWMP.Height = SplitContainer1.Panel1.Height

        If BTNVideoControls.Text = "Show Video Controls" Then
            DomWMP.Height = SplitContainer1.Panel1.Height + 60
        Else
            DomWMP.Height = SplitContainer1.Panel1.Height
        End If

        DomWMP.stretchToFit = True

        mainPictureBox.Location = New Point(0, 0)
        mainPictureBox.Width = SplitContainer1.Width
        mainPictureBox.Height = SplitContainer1.Panel1.Height

        chatBox.Width = 768
        chatBox.Location = New Point(5, 6)

        MediaButton.Location = New Point(782, -1)
        SaveBlogImage.Location = New Point(896, -1)
        SettingsButton.Location = New Point(972, -1)

      

    End Sub

    Public Sub SmallUI()

        BTN768.BackColor = Color.SteelBlue
        BTNCompact.BackColor = Color.White
        BTN1080.BackColor = Color.SteelBlue

        BTN768.ForeColor = Color.White
        BTNCompact.ForeColor = Color.SteelBlue
        BTN1080.ForeColor = Color.White

        BTN768.Font = New Font(BTN768.Font.FontFamily, BTN768.Font.Size, FontStyle.Regular)
        BTNCompact.Font = New Font(BTNCompact.Font.FontFamily, BTNCompact.Font.Size, FontStyle.Bold)
        BTN1080.Font = New Font(BTN1080.Font.FontFamily, BTN1080.Font.Size, FontStyle.Regular)


        PNLGlitter.Height = 297
        StatusUpdates.Height = 292







        SP1.Visible = False
        SP2.Visible = False
        SP3.Visible = False
        SP4.Visible = False
        SP5.Visible = False
        SP6.Visible = False
        SP7.Visible = False
        SP8.Visible = False
        SP9.Visible = False
        SP10.Visible = False



        subName.Location = New Point(10, 791)
        SplitContainer1.Height = 802
        SplitContainer1.Width = 843
        subAvatar.Location = New Point(10, 603)
        Me.Height = 856
        Me.Width = 1134
        Try
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\System\SmallBack.png")
        Catch ex As Exception
        End Try


        If PNLMediaBar.Visible = True Then
            ChatText.Location = New Point(0, 29)
        Else
            ChatText.Location = New Point(0, 0)
        End If
        ChatText.Width = 839

        ImageFolderComboBox.Width = 466

        previousButton.Location = New Point(529, -4)
        nextButton.Location = New Point(586, -4)
        BTNLoadVideo.Location = New Point(643, -4)
        BTNVideoControls.Location = New Point(719, -4)

        If PNLMediaBar.Visible = True Then
            PNLChatBox.Location = New Point(0, ChatText.Height + 23)
        Else
            PNLChatBox.Location = New Point(0, ChatText.Height - 6)
        End If


        'DomWMP.Width = 843
        DomWMP.Location = New Point(0, 0)
        DomWMP.Width = SplitContainer1.Width
        ' DomWMP.Height = SplitContainer1.Panel1.Height

        If BTNVideoControls.Text = "Show Video Controls" Then
            DomWMP.Height = SplitContainer1.Panel1.Height + 60
        Else
            DomWMP.Height = SplitContainer1.Panel1.Height
        End If

        DomWMP.stretchToFit = True







        mainPictureBox.Location = New Point(0, 0)
        mainPictureBox.Width = SplitContainer1.Width
        mainPictureBox.Height = SplitContainer1.Panel1.Height


        chatBox.Width = 519
        chatBox.Location = New Point(5, 6)

        MediaButton.Location = New Point(530, -1)
        SaveBlogImage.Location = New Point(644, -1)
        SettingsButton.Location = New Point(720, -1)

    



    End Sub

    Public Sub UI768()

        BTN768.BackColor = Color.White
        BTNCompact.BackColor = Color.SteelBlue
        BTN1080.BackColor = Color.SteelBlue

        BTN768.ForeColor = Color.SteelBlue
        BTNCompact.ForeColor = Color.White
        BTN1080.ForeColor = Color.White

        BTN768.Font = New Font(BTN768.Font.FontFamily, BTN768.Font.Size, FontStyle.Bold)
        BTNCompact.Font = New Font(BTNCompact.Font.FontFamily, BTNCompact.Font.Size, FontStyle.Regular)
        BTN1080.Font = New Font(BTN1080.Font.FontFamily, BTN1080.Font.Size, FontStyle.Regular)

        PNLGlitter.Height = 171
        StatusUpdates.Height = 166

        SP1.Visible = False
        SP2.Visible = False
        SP3.Visible = False
        SP4.Visible = False
        SP5.Visible = False
        SP6.Visible = False
        SP7.Visible = False
        SP8.Visible = False
        SP9.Visible = False
        SP10.Visible = False

        subName.Location = New Point(10, 665)
        subAvatar.Location = New Point(10, 477)
        SplitContainer1.Height = 676
        SplitContainer1.Width = 685
        'subAvatar.Visible = True
        Me.Height = 734
        Me.Width = 978

        Try
            Me.BackgroundImage = Nothing
            GC.Collect()
        Catch ex As Exception
        End Try

        If PNLMediaBar.Visible = True Then
            ChatText.Location = New Point(0, 29)
        Else
            ChatText.Location = New Point(0, 0)
        End If
        ChatText.Width = 683

        ImageFolderComboBox.Width = 307

        previousButton.Location = New Point(370, -4)
        nextButton.Location = New Point(427, -4)
        BTNLoadVideo.Location = New Point(484, -4)
        BTNVideoControls.Location = New Point(560, -4)

        If PNLMediaBar.Visible = True Then
            PNLChatBox.Location = New Point(0, ChatText.Height + 23)
        Else
            PNLChatBox.Location = New Point(0, ChatText.Height - 6)
        End If

        DomWMP.Location = New Point(0, 0)
        DomWMP.Width = SplitContainer1.Width
        ' DomWMP.Height = SplitContainer1.Panel1.Height

        If BTNVideoControls.Text = "Show Video Controls" Then
            DomWMP.Height = SplitContainer1.Panel1.Height + 60
        Else
            DomWMP.Height = SplitContainer1.Panel1.Height
        End If

        DomWMP.stretchToFit = True

        mainPictureBox.Location = New Point(0, 0)
        mainPictureBox.Width = SplitContainer1.Width
        mainPictureBox.Height = SplitContainer1.Panel1.Height

        chatBox.Width = 359
        chatBox.Location = New Point(5, 6)

        MediaButton.Location = New Point(370, -1)
        SaveBlogImage.Location = New Point(484, -1)
        SettingsButton.Location = New Point(560, -1)

    

    End Sub







    Private Sub mainPictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mainPictureBox.MouseDown


        If e.Button = MouseButtons.Right Then
            PictureStrip.Show(CType(sender, Control), e.Location)
        End If

    End Sub




    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click

      

        SaveFileDialog1.Filter = "jpegs|*.jpg|gifs|*.gif|pngs|*.png|Bitmaps|*.bmp"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True

        WebImage = FoundString
        Do Until Not WebImage.Contains("/")
            WebImage = WebImage.Remove(0, 1)
        Loop

        SaveFileDialog1.FileName = WebImage

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            My.Computer.Network.DownloadFile(FoundString, SaveFileDialog1.FileName)

        End If


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click

        If FoundString <> "" Then
            If File.Exists(Application.StartupPath & "\Images\System\LikedImageURLs.txt") Then
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\LikedImageURLs.txt", Environment.NewLine & FoundString, True)
            Else
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\LikedImageURLs.txt", FoundString, True)
            End If
            PictureStrip.Items(1).Enabled = False
        End If


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click

        If FoundString <> "" Then

            If File.Exists(Application.StartupPath & "\Images\System\DislikedImageURLs.txt") Then
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\DislikedImageURLs.txt", Environment.NewLine & FoundString, True)
            Else
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\Images\System\DislikedImageURLs.txt", FoundString, True)
            End If
            PictureStrip.Items(2).Enabled = False
        End If

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click


        Dim RemoveList As New List(Of String)
        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Images\System\URL Files\", FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
        Debug.Print(ImageUrlFilePath)
        Dim filereader As New StreamReader(ImageUrlFilePath)
        RemoveList.Clear()
        While filereader.Peek <> -1
            RemoveList.Add(filereader.ReadLine())
        End While
        filereader.Close()
        filereader.Dispose()
        'For i As Integer = RemoveList.Count - 1 To 0 Step -1
        Debug.Print(RemoveList(ImageUrlFileIndex))
        Debug.Print("foundstring = " & FoundString)
        'If RemoveList(i) = FoundString Then
        'Debug.Print("MMMMMMMMMMMMMMMMMMMMMMMAAAAAAAAAAAAAAAAATTTTTTTTTTTTTTTTCCCCCCCCCCCCCCHHHHHHHHHHHHHHHHH")
        RemoveList.Remove(RemoveList(ImageUrlFileIndex))
        'End If
        'Next

        If File.Exists(ImageUrlFilePath) Then My.Computer.FileSystem.DeleteFile(ImageUrlFilePath)

        Debug.Print(RemoveList.Count)

        For i As Integer = 0 To RemoveList.Count - 1
            If File.Exists(ImageUrlFilePath) Then
                My.Computer.FileSystem.WriteAllText(ImageUrlFilePath, Environment.NewLine & RemoveList(i), True)
            Else
                My.Computer.FileSystem.WriteAllText(ImageUrlFilePath, RemoveList(i), True)
            End If
        Next
        'Next

        PictureStrip.Items(3).Enabled = False

    End Sub















    Private Sub ContactTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ContactTimer.Tick
        ContactTick -= 1


        If ContactTick < 1 Then
            ContactTimer.Stop()
            ContactFlag = False
        End If

    End Sub

    
    
    Private Sub BTNShowHideApps_Click(sender As System.Object, e As System.EventArgs) Handles BTNShowHideApps.Click
        If frmApps.Visible = True Then
            frmApps.Visible = False
            BTNShowHideApps.Text = "Show Apps"
        Else
            frmApps.Show()
            BTNShowHideApps.Text = "Hide Apps"
        End If
    End Sub
   

   











    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles BTN1080.Click

        If My.Settings.LargeUI = True Then Return

        LargeUI()
        'Form1.PNLChatBox.Location = New Point(0, 214)
        My.Settings.LargeUI = True
        My.Settings.SmallUI = False
        My.Settings.UI768 = False
        My.Settings.Save()

        ScrollChatDown()
    End Sub

    Private Sub Button1_Click_2(sender As System.Object, e As System.EventArgs) Handles BTNCompact.Click

        If My.Settings.SmallUI = True Then Return

        SmallUI()
        'Form1.PNLChatBox.Location = New Point(0, 172)
        My.Settings.LargeUI = False
        My.Settings.SmallUI = True
        My.Settings.UI768 = False
        My.Settings.Save()

        ScrollChatDown()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles BTN768.Click

        If My.Settings.UI768 = True Then Return

        UI768()
        'Form1.PNLChatBox.Location = New Point(0, 173)
        My.Settings.LargeUI = False
        My.Settings.SmallUI = False
        My.Settings.UI768 = True
        My.Settings.Save()

        ScrollChatDown()
    End Sub

    Public Sub LoadDommeImageFolder()

        Dim GreetFolder As New List(Of String)
        GreetFolder.Clear()



        For Each Dir As String In Directory.GetDirectories(FrmSettings.LBLDomImageDir.Text)
            Try
                GreetFolder.Add(Dir)
            Catch
            End Try
        Next

        ' Try
        If GreetFolder.Count < 1 Then
            MessageBox.Show(Me, "There are no directories in the specified Domme Images Directory folder." & Environment.NewLine & Environment.NewLine & _
                            "Please make sure the Domme Images Directory points to a location containing at least one subdirectory of images.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return
        End If

        GetFolder = GreetFolder(randomizer.Next(0, GreetFolder.Count))

        SlideshowLoaded = True

        DomWMP.Visible = False
        DomWMP.Ctlcontrols.pause()
        mainPictureBox.Visible = True

        FrmSettings.timedRadio.Enabled = True
        FrmSettings.teaseRadio.Enabled = True

        FileCount = 0
        FileCountMax = -1
        _ImageFileNames.Clear()


        Dim supportedExtensions As String = "*.png,*.jpg,*.gif,*.bmp,*.jpeg"


        Dim files As String()

        If FrmSettings.CBSlideshowSubDir.Checked = True Then
            files = Directory.GetFiles(GetFolder, "*.*", SearchOption.AllDirectories)
        Else
            files = Directory.GetFiles(GetFolder, "*.*")
        End If


        Array.Sort(files)



        Dim TestCOUnt As Integer = 0
        For Each fi As String In files
            If supportedExtensions.Contains(Path.GetExtension(fi)) Then
                TestCOUnt += 1
                _ImageFileNames.Add(fi)
            End If
        Next

        FileCountMax = _ImageFileNames.Count - 1



        If FileCountMax < 0 Then
            MessageBox.Show(Me, "There are no images in the specified folder.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return
        End If

        FileCount = 0
        If Not mainPictureBox Is Nothing Then
            Try
                mainPictureBox.Image.Dispose()
                mainPictureBox.Image = Nothing
                GC.Collect()
            Catch
            End Try
        End If

        If FrmSettings.CBSlideshowRandom.Checked = True Then FileCount = randomizer.Next(0, FileCountMax + 1)

        mainPictureBox.Image = Image.FromFile(_ImageFileNames(FileCount))
        ShowImageInfo()

        If FrmSettings.landscapeCheckBox.Checked = True Then
            If mainPictureBox.Image.Width > mainPictureBox.Image.Height Then
                mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Else
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        End If


        mainPictureBox.Refresh()
        mainPictureBox.Invalidate()

        If FrmSettings.timedRadio.Checked = True Then
            SlideshowTimerTick = FrmSettings.slideshowNumBox.Value
            SlideshowTimer.Start()
        End If





    End Sub

    Public Sub ScrollChatDown()

        Try
            ChatText.Document.Window.ScrollTo(Int16.MaxValue, Int16.MaxValue)
        Catch
        End Try

    End Sub

   


    Private Sub StatusUpdates_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles StatusUpdates.DocumentCompleted
        Try
            StatusUpdates.Document.Window.ScrollTo(Int16.MaxValue, Int16.MaxValue)
        Catch
        End Try
    End Sub

    Public Function WordExists(ByVal searchString As String, ByVal findString As String) As Boolean

        Dim returnValue As Boolean = False

        If System.Text.RegularExpressions.Regex.Matches(searchString, "\b" & findString & "\b").Count > 0 Then returnValue = True
        Return returnValue

    End Function

    Function Capitalize(ByVal val As String) As String
        If String.IsNullOrEmpty(val) Then
            Return val
        End If
        Dim array() As Char = val.ToCharArray
        array(0) = Char.ToUpper(array(0))
        Return New String(array)
    End Function



    Public Function CompareDates(ByVal CheckDate As Date) As Integer

        Dim result As Integer = DateTime.Compare(FormatDateTime(CheckDate, DateFormat.ShortDate), FormatDateTime(Now, DateFormat.ShortDate))
        Debug.Print("Compare dates: " & FormatDateTime(CheckDate, DateFormat.ShortDate) & " <-> " & FormatDateTime(Now, DateFormat.ShortDate) & " = " & result)
        Return result

    End Function



End Class
