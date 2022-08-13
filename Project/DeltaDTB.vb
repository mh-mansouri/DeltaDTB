
#Region "Options"

Option Explicit On

#End Region

#Region "References"

Imports System.IO.Ports

#End Region

#Region "Delta"

Namespace Delta

#Region "Enum Definition"

#Region "Commands"

    Friend Enum Delta_Command
        Read_Bits = &H2
        Read_Register_s = &H3
        Write_1_Bit = &H5
        Write_1_Word = &H6
    End Enum

#End Region

#Region "Error"

    Friend Enum Delta_Read_Error
        Initial_Proce_Temperature_Value_Is_Not_Got_Yet = -32766
        Temperature_Sensor_Is_Not_Connected = -32765
        Temperature_Sensor_Input_Error = -32764
        ADC_Input_Error = -32763
        Memory_Read_Write_Err = -32762
    End Enum

    Friend Enum Delta_Com_Ack_Error
        Preset_Value_Unstable = 1
        Re_Initial_No_Temperature_At_this_Time = 2
        Input_Sensor_Did_Not_Connect = 3
        Input_Signal_Error = 4
        Over_Input_Range = 5
        ADC_Fail = 6
        EEPROM_Read_Write_Error = 7
    End Enum

#End Region

#Region "Reg/Bit Address"

    Friend Enum Delta_Reg_Add

        'First 16 Segment Range
        CV_Current_Value = &H1000
        SP_Set_Point = &H1001
        Upper_Limit_Of_Temperature_Range = &H1002
        Lower_Limit_Of_Temperature_Range = &H1003
        Input_Temperature_Sensor_Type = &H1004
        Control_Method = &H1005
        Heating_Colling_Control_Selection = &H1006
        Fst_Group_Of_Heating_Cooling_Control_Cycle = &H1007
        Snd_Group_Of_Heating_Cooling_Control_Cycle = &H1008
        P_Proportional_Band = &H1009
        I_Integral_Time = &H100A
        D_Derivative_Time = &H100B
        Integration_Default = &H100C
        Proportional_Control_Offset_Error_Value_When_Ti_is_0 = &H100D
        The_Setting_Of_COEF_When_Dual_Loop_Output_Control_Are_Used = &H100E
        The_Setting_Of_Dead_Band_When_Dual_Loop_Output_Control_Are_Used = &H100F

        'Second 16 Segment Range
        Hystersis_Setting_Value_Of_The_1st_Output_Group = &H1010
        Hystersis_Setting_Value_Of_The_2nd_Output_Group = &H1011
        Output_Value_Read_And_Write_Of_Output_1 = &H1012
        Output_Value_Read_And_Write_Of_Output_2 = &H1013
        Upper_Limit_Regulation_Of_Analog_Linear_Output = &H1014
        Lower_Limit_Regulation_Of_Analog_Linear_Output = &H1015
        Temperature_Regulation_Value = &H1016
        Analog_Decimal_Setting = &H1017
        Time_For_Valve_From_Full_Open_To_Full_Close = &H1018
        Dead_Band_Setting_Of_Vavle = &H1019
        Upper_Limit_Of_FeedBack_Signal_Set_By_Vavle = &H101A
        Lower_Limit_Of_FeedBack_Signal_Set_Bye_Valve = &H101B
        PID_Parameter_selection = &H101C
        Set_Value_Coresponded_to_PID_Value = &H101D

        'Third 16 Segment Range
        Alarm_1_Type = &H1020
        Alarm_2_Type = &H1021
        Alarm_3_Type = &H1022
        System_Alarm_Setting = &H1023
        Upper_Limit_Alarm_1 = &H1024
        Lower_Limit_Alarm_1 = &H1025
        Upper_Limit_Alarm_2 = &H1026
        Lower_Limit_Alarm_2 = &H1027
        Upper_Limit_Alarm_3 = &H1028
        Lower_Limit_Alarm_3 = &H1029
        Red_LED_Status = &H102A
        Read_Pushbutton_Status = &H102B
        Setting_Lock_Status = &H102C
        CT_read_Value = &H102D
        Software_Version = &H102F

        'Forth 16 Segment Range
        Start_Pattern_Number = &H1030

        'Fifth 16 Segment Range
        Actual_Step_Number_Setting_Inside_Pattern_0 = &H1040
        Actual_Step_Number_Setting_Inside_Pattern_1 = &H1041
        Actual_Step_Number_Setting_Inside_Pattern_2 = &H1042
        Actual_Step_Number_Setting_Inside_Pattern_3 = &H1043
        Actual_Step_Number_Setting_Inside_Pattern_4 = &H1044
        Actual_Step_Number_Setting_Inside_Pattern_5 = &H1045
        Actual_Step_Number_Setting_Inside_Pattern_6 = &H1046
        Actual_Step_Number_Setting_Inside_Pattern_7 = &H1047

        'Sixth 16 Segmet Range
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_0 = &H1050
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_1 = &H1051
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_2 = &H1052
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_3 = &H1053
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_4 = &H1054
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_5 = &H1055
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_6 = &H1056
        Cycle_Number_For_Repeating_The_Execution_of_Pattern_7 = &H1057

    End Enum

    Friend Enum Delta_Bit_Add

        Communication_Write_In_Selection = &H810
        Temperature_Unit_Display_Selection = &H811
        Decimal_Point_Position_Selection = &H812
        AT_Setting = &H813
        Control_Run_Stop_Setting = &H814
        Stop_Setting_For_PID_Program_Control = &H815
        Temporarily_Stop_For_PID_Program_Control = &H816
        Valve_Feedback_Setting_Status = &H817
        Auto_Tuning_Valve_Feedback_Status = &H818

    End Enum

#End Region

#Region "Reg Contents"

    Friend Enum Control_Method
        PID = 0
        ON_OFF = 1
        Manual_Tuning = 2
        Cooling_Heating = 3
    End Enum

    Friend Enum Heating_Cooling_Control_Selection
        Heating = 0
        Cooling = 1
        Heating_Cooling = 2
        Cooling_heating = 3
    End Enum

    Friend Enum System_Alarm_Setting
        None = 0
        Alarm_01 = 1
        Alarm_02 = 2
        Alarm_03 = 3
    End Enum

    Friend Enum Setting_Lick_Status
        Normal = 0
        All_Setting_Lick = 1
        Lock_Others_Than_SV_Value = 11
    End Enum

#End Region

#End Region

#Region "Delta Classes"

#Region "Delta Exception"

    ''' <summary>
    ''' Delta Exception Class
    ''' Version 2.0.1
    ''' Created and Tested by: Mahdi Mansouri
    ''' Farzankar Ind. Co.
    ''' Apr 14 2011
    ''' </summary>
    Friend Class DeltaException
        Inherits Exception
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

    End Class

#End Region

#Region "Delta DTB"

    ''' <summary>
    ''' Delta DTB PC Interface Class
    ''' Version 2.0.1
    ''' Created and Tested by: Mahdi Mansouri
    ''' Farzankar Ind. Co.
    ''' Apr 14 2011
    ''' </summary>
    Friend Class DeltaDTB

#Region "Fields"

        Private Link As SerialPort = Nothing
        Private unit_Address As Integer = 0
        Private Const delay_ticks As Long = TimeSpan.TicksPerMillisecond * 100
        Private Const delay_ms As Long = 100
        Private is_open As Boolean = False
        Private is_alive As Boolean = False
        Private byte_time As Single = -1

#End Region

#Region "Methods"

        Friend Function Test() As Boolean
            Return Test(UnitAddress)
        End Function

        Friend Function Test(ByVal unit_num As Integer) As Boolean
            Try
                If Link Is Nothing Then Throw New DeltaException("The object is not initilized yet!")
                If Not ISOpen Then Throw New DeltaException("Port is not Opened!")

                Dim bytes_to_read As Integer = 13, predicted_length As Long = 0
                Dim unit_no As String = Hex(unit_num).PadLeft(2, "0"c)
                Dim str_resp As String = ""


                'Read if any remained in buffer
                predicted_length = ((bytes_to_read * ByteTime) + delay_ms) * TimeSpan.TicksPerMillisecond
                str_resp = Link.ReadExisting

                Link.Write(":" & Trim(LRC_CheckSum(unit_no & "03" & Trim(Hex(Delta_Reg_Add.Software_Version)) & "0001")) & vbCrLf)

                Dim Cr_Tme As Long = DateAndTime.Now.Ticks
                While Link.BytesToRead < bytes_to_read And ((DateAndTime.Now.Ticks - Cr_Tme) < predicted_length)
                End While
                str_resp = Link.ReadExisting
                If str_resp.Length < bytes_to_read Then
                    Me.Alive = False : Return False
                End If
                Me.Alive = True : Return True
            Catch ex As Exception
                Throw New DeltaException(ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Close CommPort
        ''' </summary>
        Public Function Close() As Boolean
            If Link Is Nothing Then Throw New DeltaException("Object is not initialized yet!")
            Try
                If Link.IsOpen Then Link.Close()
            Catch ex As Exception
                Throw New DeltaException("CommPort Error Occurred!" & vbNewLine & ex.Message)
            End Try
            Opened = False
        End Function

        Private Function Command_Header(ByVal Str_Recieve As String) As String
            Dim Str_Command As String = Mid(Str_Recieve, 4, 2)
            Select Case Str_Command
                Case "02"
                    Return "Bit Reading"
                Case "03"
                    Return "Rgister Reading"
                Case "05"
                    Return "Bit Writing"
                Case "06"
                    Return "Word Writing"
                Case Else
                    Return "Unknow Command!"
            End Select
        End Function

        Protected Shared Function ConvertHexToSingle(ByVal hexValue As String) As Single
            Try
                Dim iInputIndex As Integer = 0
                Dim iOutputIndex As Integer = 0
                Dim bArray(3) As Byte
                For iInputIndex = 0 To hexValue.Length - 1 Step 2
                    bArray(iOutputIndex) = Byte.Parse(hexValue.Chars(iInputIndex) & hexValue.Chars(iInputIndex + 1), Globalization.NumberStyles.HexNumber)
                    iOutputIndex += 1
                Next
                Array.Reverse(bArray)
                Return BitConverter.ToSingle(bArray, 0)
            Catch ex As Exception
                Throw New FormatException("Hex to Single" & vbNewLine & "The supplied hex value is either empty or in an incorrect format. Use the following format: 00000000", ex)
            End Try
        End Function

        Protected Shared Function ConvertSingleToHex(ByVal singleValue As Single) As String
            Dim ByteArr(3) As Byte
            ByteArr = BitConverter.GetBytes(singleValue)
            ConvertSingleToHex = ByteArr(3).ToString("X2") & ByteArr(2).ToString("X2") & ByteArr(1).ToString("X2") & ByteArr(0).ToString("X2")
        End Function

        Protected Shared Function ConvertHexToInteger(ByVal hexValue As String) As Integer
            Try
                Dim iInputIndex As Integer = 0
                Dim iOutputIndex As Integer = 0
                Dim realHexValue As String
                If hexValue.Length <= 8 Then
                    realHexValue = New String("0", 8 - hexValue.Length) & hexValue
                Else
                    realHexValue = hexValue.Substring(0, 8)
                End If
                Dim bArray(3) As Byte
                For iInputIndex = 0 To realHexValue.Length - 1 Step 2
                    bArray(iOutputIndex) = Byte.Parse(realHexValue.Chars(iInputIndex) & realHexValue.Chars(iInputIndex + 1), Globalization.NumberStyles.HexNumber)
                    iOutputIndex += 1
                Next
                Array.Reverse(bArray)
                Return BitConverter.ToInt16(bArray, 0)
            Catch ex As Exception
                Throw New FormatException("Hex to Integer" & vbNewLine & "The supplied hex value is either empty or in an incorrect format. Use the following format: 00000000", ex)
            End Try
        End Function

        Protected Shared Function ConvertIntegerToHex(ByVal IntegerValue As Integer) As String
            Dim ByteArr(3) As Byte
            ByteArr = BitConverter.GetBytes(IntegerValue)
            ConvertIntegerToHex = ByteArr(3).ToString("X2") & ByteArr(2).ToString("X2") & ByteArr(1).ToString("X2") & ByteArr(0).ToString("X2")
        End Function

        Sub Dispose()
            Me.Finalize()
        End Sub

        Friend Function Extract_Value_bit(ByVal Str_Recieve As String) As Integer
            If Str_Recieve = CStr(False) Then Return Integer.MinValue
            If Str_Recieve = "Not Active" Then Return Integer.MinValue
            Return IIf((Mid(Str_Recieve, 6, 4)) = "0101", 1, IIf(Mid(Str_Recieve, 6, 4) = "0100", 0, Integer.MinValue))
        End Function

        Friend Function Extract_Value_Word(ByVal Str_Recieve As String) As Integer
            If Str_Recieve = CStr(False) Then Return Integer.MinValue
            If Str_Recieve = "Not Active" Then Return Integer.MinValue
            Extract_Value_Word = ConvertHexToInteger(Mid(Str_Recieve, 8, 4))
        End Function

        ''' <summary>
        ''' Dispose Current Object
        ''' </summary>
        Protected Overrides Sub Finalize()
            If ISOpen Then Me.Close()
            Alive = False
            Opened = False
            Link = Nothing
            MyBase.Finalize()
        End Sub

        Protected Shared Function GetChecksum_Str(ByVal Sentence As String) As String
            Dim Character As Char
            Dim Checksum As Integer
            Dim TempByte As Byte
            Checksum = 0
            For Each Character In Sentence
                TempByte = Convert.ToByte(Character)
                Checksum = Checksum + TempByte
                Checksum = Checksum Mod 256
            Next
            Return Checksum.ToString("X2")
        End Function

        Protected Shared Function GetChecksum_Byte(ByVal Sentence As Byte()) As String
            Dim Character As Byte
            Dim Checksum As Integer
            Checksum = 0
            For Each Character In Sentence
                Checksum = (Checksum + Convert.ToByte(Character)) Mod 256
            Next
            Return Checksum.ToString("X2")
        End Function

        Protected Shared Function LRC_CheckSum(ByVal Str1 As String) As String
            Dim LCR As Integer
            Dim I As Integer
            Dim C As String
            LCR = 0
            For I = 1 To Len(Str1) Step 2
                LCR = LCR + ConvertHexToInteger(Mid(Str1, I, 2))
            Next I
            If LCR < 255 Then
                C = Trim(Hex(255 - LCR + 1))
            Else
                C = Trim(Hex(65535 - LCR + 1))
            End If
            If Len(Trim(C)) > 2 Then C = Right$(C, 2)
            Select Case Len(Trim(C))
                Case 0 : C = "00"
                Case 1 : C = "0" & Trim(C)
                Case 2 : C = Trim(C)
                Case Else : C = Format(Trim(C), "00")
            End Select
            LRC_CheckSum = Str1 & Trim(C)
        End Function

        ''' <summary>
        ''' Create New Instance of Object
        ''' </summary>
        Sub New()
            Call Me.New(New SerialPort)
        End Sub

        ''' <summary>
        ''' Create New Instance of Object
        ''' </summary>
        Sub New(ByVal serial As SerialPort)
            Call Me.New(serial, 1)
        End Sub

        ''' <summary>
        ''' Create New Instance of Object
        ''' </summary>
        Sub New(ByVal serial As SerialPort, ByVal unit_address As Integer)
            If serial Is Nothing Then serial = New SerialPort
            CommSetting = serial
            UnitAddress = unit_address
        End Sub

        ''' <summary>
        ''' Open CommPort for Communication
        ''' </summary>
        Public Function Open() As Boolean
            If Link Is Nothing Then Throw New DeltaException("Object is not initialized yet!")
            Try
                If Not Link.IsOpen Then Link.Open()
            Catch ex As Exception
                Throw New DeltaException("CommPort Error Occurred!" & vbNewLine & ex.Message)
            End Try
            Opened = True
        End Function

        Friend Function Read_bit(ByVal bit_add As Delta_Bit_Add) As String
            Return Read_bit(UnitAddress, bit_add)
        End Function

        Friend Function Read_bit(ByVal unit_num As Integer, ByVal bit_add As Delta_Bit_Add) As String
            Try
                If Link Is Nothing Then Throw New DeltaException("The object is not initilized yet!")
                If Not ISAlive Then Throw New DeltaException("Device is not Alive!")
                If Not ISOpen Then Throw New DeltaException("Port is not Opened!")

                Dim bytes_to_read As Integer = 13, predicted_length As Long = 0
                Dim unit_no As String = Hex(unit_num).PadLeft(2, "0"c)

                Dim str_responce As String = ""
                Dim str_address As String = Hex(bit_add)

                If str_address.Length < 4 Then str_address = New String("0", 4 - str_address.Length) & str_address
                If str_address.Length > 4 Then str_address = Mid(str_address, 1, 4)

                'Read if any remained in buffer
                predicted_length = ((bytes_to_read * ByteTime) + delay_ms) * TimeSpan.TicksPerMillisecond
                str_responce = Link.ReadExisting

                Link.Write(":" & Trim(LRC_CheckSum(unit_no & "02" & str_address & "0001")) & vbCrLf)

                Dim Cr_Tme As Long = DateAndTime.Now.Ticks

                While Link.BytesToRead < bytes_to_read And ((DateAndTime.Now.Ticks - Cr_Tme) < predicted_length)
                End While

                str_responce = Link.ReadExisting

                If str_responce.Length < bytes_to_read Then
                    Throw New DeltaException("Data Corrupted, Error in Communication Line!")
                End If

                Return str_responce

            Catch ex As Exception
                Throw New DeltaException(ex.Message)
            End Try
        End Function

        Friend Function Read_word(ByVal reg_add As Delta_Reg_Add) As String
            Return Read_word(UnitAddress, reg_add)
        End Function

        Friend Function Read_word(ByVal unit_num As Integer, ByVal reg_Add As Delta_Reg_Add) As String
            Try
                If Link Is Nothing Then Throw New DeltaException("The object is not initilized yet!")
                If Not ISAlive Then Throw New DeltaException("Device is not Alive!")
                If Not ISOpen Then Throw New DeltaException("Port is not Opened!")

                Dim bytes_to_read As Integer = 13, predicted_length As Long = 0
                Dim unit_no As String = Hex(unit_num Mod 256).PadLeft(2, "0"c)

                Dim str_responce As String = ""
                Dim str_address As String = Hex(reg_Add)

                If str_address.Length < 4 Then str_address = New String("0", 4 - str_address.Length) & str_address
                If str_address.Length > 4 Then str_address = Mid(str_address, 1, 4)

                'Read if any remained in buffer
                predicted_length = ((bytes_to_read * ByteTime) + delay_ms) * TimeSpan.TicksPerMillisecond
                str_responce = Link.ReadExisting

                Link.Write(":" & Trim(LRC_CheckSum(unit_no & "03" & str_address & "0001")) & vbCrLf)

                Dim Cr_Tme As Long = DateAndTime.Now.Ticks

                While Link.BytesToRead < bytes_to_read And ((DateAndTime.Now.Ticks - Cr_Tme) < predicted_length)
                End While

                str_responce = Link.ReadExisting

                If str_responce.Length < bytes_to_read Then
                    Throw New DeltaException("Data Corrupted, Error in Communication Line!")
                End If

                Return str_responce

            Catch ex As Exception
                Throw New DeltaException(ex.Message)
            End Try

        End Function

        Friend Function Write_bit(ByVal bit_add As Delta_Bit_Add, ByVal reg_data As Boolean) As String
            Return Write_bit(UnitAddress, bit_add, reg_data)
        End Function

        Friend Function Write_bit(ByVal unit_num As Integer, ByVal bit_add As Delta_Bit_Add, ByVal reg_data As Boolean) As String
            Try
                If Link Is Nothing Then Throw New DeltaException("The object is not initilized yet!")
                If Not ISAlive Then Throw New DeltaException("Device is not Alive!")
                If Not ISOpen Then Throw New DeltaException("Port is not Opened!")

                Dim bytes_to_read As Integer = 15, predicted_length As Long = 0
                Dim unit_no As String = Hex(unit_num Mod 256).PadLeft(2, "0"c)

                Dim str_responce As String = ""
                Dim str_address As String = Hex(bit_add)
                If str_address.Length < 4 Then str_address = New String("0", 4 - str_address.Length) & str_address
                If str_address.Length > 4 Then str_address = Mid(str_address, 1, 4)

                'Read if any remained in buffer
                predicted_length = ((bytes_to_read * ByteTime) + delay_ms) * TimeSpan.TicksPerMillisecond
                str_responce = Link.ReadExisting

                Link.Write(":" & Trim(LRC_CheckSum(unit_no & "05" & str_address & IIf(reg_data, "FF00", "0000"))) & vbCrLf)

                Dim Cr_Tme As Long = DateAndTime.Now.Ticks

                While Link.BytesToRead < bytes_to_read And ((DateAndTime.Now.Ticks - Cr_Tme) < predicted_length)
                End While

                str_responce = Link.ReadExisting

                If str_responce.Length < bytes_to_read Then
                    Throw New DeltaException("Data Corrupted, Error in Communication Line!")
                End If

                Return str_responce

            Catch ex As Exception
                Throw New DeltaException(ex.Message)
            End Try

        End Function

        Friend Function Write_word(ByVal reg_add As Delta_Reg_Add, ByVal reg_data As Integer) As String
            Return Write_word(UnitAddress, reg_add, reg_data)
        End Function

        Friend Function Write_word(ByVal unit_num As Integer, ByVal reg_add As Delta_Reg_Add, ByVal reg_data As Integer) As String
            Try
                If Link Is Nothing Then Throw New DeltaException("The object is not initilized yet!")
                If Not ISAlive Then Throw New DeltaException("Device is not Alive!")
                If Not ISOpen Then Throw New DeltaException("Port is not Opened!")

                Dim bytes_to_read As Integer = 15, predicted_length As Long = 0
                Dim unit_no As String = Hex(unit_num).PadLeft(2, "0"c)

                Dim str_responce As String = ""
                Dim str_address As String = Hex(reg_add)

                If str_address.Length < 4 Then str_address = New String("0", 4 - str_address.Length) & str_address
                If str_address.Length > 4 Then str_address = Mid(str_address, 1, 4)

                Dim str_data As String = IIf(reg_data > 0, Hex(reg_data), ConvertIntegerToHex(reg_data))
                If str_data.Length < 4 Then str_data = New String("0", 4 - str_data.Length) & str_data
                If str_data.Length > 4 Then str_data = Mid(str_data, str_data.Length - 3, 4)

                'Read if any remained in buffer
                predicted_length = ((bytes_to_read * ByteTime) + delay_ms) * TimeSpan.TicksPerMillisecond
                str_responce = Link.ReadExisting

                Link.Write(":" & Trim(LRC_CheckSum(unit_no & "06" & str_address & str_data)) & vbCrLf)

                Dim Cr_Tme As Long = DateAndTime.Now.Ticks

                While Link.BytesToRead < bytes_to_read And ((DateAndTime.Now.Ticks - Cr_Tme) < predicted_length)
                End While

                str_responce = Link.ReadExisting

                If str_responce.Length < bytes_to_read Then
                    Throw New DeltaException("Data Corrupted, Error in Communication Line!")
                End If

                Return str_responce

            Catch ex As Exception
                Throw New DeltaException(ex.Message)
            End Try

        End Function

#End Region

#Region "Properties"

        ''' <summary>
        ''' Get/Set IsAlive Status
        ''' </summary>
        Private Property Alive() As Boolean
            Get
                Return is_alive
            End Get
            Set(ByVal value As Boolean)
                is_alive = value
            End Set
        End Property

        ''' <summary>
        ''' Get/Set Each Byte Responce Time
        ''' </summary>
        Private Property ByteTime() As Single
            Get
                Return byte_time
            End Get
            Set(ByVal value As Single)
                byte_time = value
            End Set
        End Property

        ''' <summary>
        ''' Get/Set CommPort Settings
        ''' </summary>
        Public Property CommSetting() As SerialPort
            Get
                Return Link
            End Get
            Set(ByVal value As SerialPort)
                If ISOpen Then Throw New DeltaException("Assigning is prohibited while port is open!")
                Link = value
                With Link
                    Dim tmp_len As Single = 0
                    Select Case .StopBits
                        Case StopBits.None
                            tmp_len += 0
                        Case StopBits.One
                            tmp_len += 1
                        Case StopBits.OnePointFive
                            tmp_len += 1.5
                        Case StopBits.Two
                            tmp_len += 2
                    End Select
                    Select Case .Parity
                        Case Parity.Even
                            tmp_len += 1
                        Case Parity.Mark
                            tmp_len += 1
                        Case Parity.Odd
                            tmp_len += 1
                        Case Parity.Space
                            tmp_len += 1
                        Case Parity.None
                            tmp_len += 0
                    End Select
                    ByteTime = CSng(.DataBits + 1 + tmp_len) / CSng(.BaudRate)
                End With
            End Set
        End Property

        ''' <summary>
        ''' Verify whether PLC Is Alive or Not
        ''' </summary>
        Public ReadOnly Property ISAlive() As Boolean
            Get
                Return is_alive
            End Get
        End Property

        ''' <summary>
        ''' Verify whether CommPort Opened or Not
        ''' </summary>
        Public ReadOnly Property ISOpen() As Boolean
            Get
                Return is_open
            End Get
        End Property

        ''' <summary>
        ''' Get/Set IsOpen Status
        ''' </summary>
        Private Property Opened() As Boolean
            Get
                Return is_open
            End Get
            Set(ByVal value As Boolean)
                is_open = value
            End Set
        End Property

        ''' <summary>
        ''' Get/Set Active PLCUnit Address
        ''' </summary>
        Public Property UnitAddress() As Integer
            Get
                Return unit_Address
            End Get
            Set(ByVal value As Integer)
                If value < 0 Or value > 255 Then Throw New DeltaException("Invalid Unit Address!")
                unit_Address = value
            End Set
        End Property

#End Region

    End Class

#End Region

#End Region

End Namespace

#End Region
