namespace PLC_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch 
            {

            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.axDBCommManager1 = new AxDATABUILDERAXLibLB.AxDBCommManager();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_High_Speed_Cutting = new System.Windows.Forms.Panel();
            this.pictureBox_Boltun_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Operation_Guide = new System.Windows.Forms.Button();
            this.label_High_Speed_Cutting = new System.Windows.Forms.Label();
            this.btn_Shutdown = new System.Windows.Forms.Button();
            this.panel_Shutdown = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Reboot = new System.Windows.Forms.Button();
            this.btn_Shutdown_close = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lab_Progress = new System.Windows.Forms.Label();
            this.lab_SystemStatus = new System.Windows.Forms.Label();
            this.lab_HideButton = new System.Windows.Forms.Label();
            this.panel_CloseProgram = new System.Windows.Forms.Panel();
            this.label_Enter_Password_Close = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn__7 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_CancelClose = new System.Windows.Forms.Button();
            this.btn_OK_Close = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.panel_Operation_Guide1 = new System.Windows.Forms.Panel();
            this.checkBox_Screw_Below_Dead_Point_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Screw_Dead_Top_Center_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Feeding_Confirm_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_No_Material_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Full_Material_Sensor = new System.Windows.Forms.CheckBox();
            this.label_Operation_Guide1 = new System.Windows.Forms.Label();
            this.label_Confirm_Machine_Sensors = new System.Windows.Forms.Label();
            this.btn_Next1 = new System.Windows.Forms.Button();
            this.panel_Operation_Guide2 = new System.Windows.Forms.Panel();
            this.label_Operation_Guide2 = new System.Windows.Forms.Label();
            this.button_None_Workpiece_Turntable = new System.Windows.Forms.Button();
            this.button_Machine_Table_No_Foreign_Body = new System.Windows.Forms.Button();
            this.button_Track_No_Material_Discharge_Port = new System.Windows.Forms.Button();
            this.checkBox_None_Workpiece_Turntable = new System.Windows.Forms.CheckBox();
            this.checkBox_Machine_Table_No_Foreign_Body = new System.Windows.Forms.CheckBox();
            this.checkBox_Track_No_Material_Discharge_Port = new System.Windows.Forms.CheckBox();
            this.label_Confirm_Machine_Workpiece = new System.Windows.Forms.Label();
            this.btn_Next2 = new System.Windows.Forms.Button();
            this.panel_Operation_Guide3 = new System.Windows.Forms.Panel();
            this.label_Operation_Guide3 = new System.Windows.Forms.Label();
            this.button_Hair_Shock_On_Track = new System.Windows.Forms.Button();
            this.button_Pneumatic_Adequate_Machine = new System.Windows.Forms.Button();
            this.checkBox_Hair_Shock_On_Track = new System.Windows.Forms.CheckBox();
            this.checkBox_Pneumatic_Adequate_Machine = new System.Windows.Forms.CheckBox();
            this.label_Confirm_Before_Running_Machine = new System.Windows.Forms.Label();
            this.btn_Next3 = new System.Windows.Forms.Button();
            this.panel_Operation_Guide4 = new System.Windows.Forms.Panel();
            this.panel_Machine_OPR2 = new System.Windows.Forms.Panel();
            this.button_Sensor_Normal = new System.Windows.Forms.Button();
            this.checkBox_Sensor_Normal = new System.Windows.Forms.CheckBox();
            this.label_Confirm_Screw = new System.Windows.Forms.Label();
            this.panel_Machine_OPR1 = new System.Windows.Forms.Panel();
            this.button_OPR = new System.Windows.Forms.Button();
            this.button_Motor_Start = new System.Windows.Forms.Button();
            this.checkBox_Positioning_Completed = new System.Windows.Forms.CheckBox();
            this.btn_Next4 = new System.Windows.Forms.Button();
            this.label_Operation_Guide4 = new System.Windows.Forms.Label();
            this.label_Machine_OPR = new System.Windows.Forms.Label();
            this.panel_Operation_Guide5 = new System.Windows.Forms.Panel();
            this.button_Main = new System.Windows.Forms.Button();
            this.checkBox_Xaxis = new System.Windows.Forms.CheckBox();
            this.button_Tool_Rotation = new System.Windows.Forms.Button();
            this.button_Screw_Synchronization = new System.Windows.Forms.Button();
            this.label_Operation_Guide5 = new System.Windows.Forms.Label();
            this.label_Screw_Position_Value = new System.Windows.Forms.Label();
            this.label_Screw_Position = new System.Windows.Forms.Label();
            this.label_Tool_Rotation = new System.Windows.Forms.Label();
            this.label_Screw_Synchronization = new System.Windows.Forms.Label();
            this.label_Screw_Synchronous_Starting_Point = new System.Windows.Forms.Label();
            this.label_Xaxis_Hand_Wheel_Knob = new System.Windows.Forms.Label();
            this.label_Tool_Positioning_Screw_Start = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Hide_Password_Function = new System.Windows.Forms.Panel();
            this.label_Hidden_Features_Password = new System.Windows.Forms.Label();
            this.button_Hidden_Features_Return = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Delete = new System.Windows.Forms.Button();
            this.textBox_Hidden_Features_Password = new System.Windows.Forms.TextBox();
            this.button_Hidden_Features_9 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_6 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_3 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_8 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_5 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_2 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_7 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_4 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Cancel = new System.Windows.Forms.Button();
            this.button_Hidden_Features_OK = new System.Windows.Forms.Button();
            this.button_Hidden_Features_0 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_1 = new System.Windows.Forms.Button();
            this.pictureBox_Boltun_Main = new System.Windows.Forms.PictureBox();
            this.button_Analog_Operation = new System.Windows.Forms.Button();
            this.button_Machine_Stop = new System.Windows.Forms.Button();
            this.button_Input_Output_List = new System.Windows.Forms.Button();
            this.button_Machine_Start = new System.Windows.Forms.Button();
            this.button_Error_Message = new System.Windows.Forms.Button();
            this.button_Counting_System = new System.Windows.Forms.Button();
            this.button_Manual_Mode = new System.Windows.Forms.Button();
            this.button_Speed_Setting = new System.Windows.Forms.Button();
            this.panel_WorkingSpeed = new System.Windows.Forms.Panel();
            this.panel_Counting_System = new System.Windows.Forms.Panel();
            this.textBox_Stroke_Rate = new System.Windows.Forms.TextBox();
            this.textBox_Total_Number_Actions = new System.Windows.Forms.TextBox();
            this.label_Stroke_Rate = new System.Windows.Forms.Label();
            this.label_Stroke_Rate_Count = new System.Windows.Forms.Label();
            this.label_Total_Number_Actions_Count = new System.Windows.Forms.Label();
            this.label_Total_Number_Actions = new System.Windows.Forms.Label();
            this.label_Counting_System = new System.Windows.Forms.Label();
            this.panel_WorkingSpeedSetting = new System.Windows.Forms.Panel();
            this.btn_WorkingSpeedSetting_Modify = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_Delete = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_0 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_9 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_6 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_3 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_8 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_5 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_2 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_7 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_4 = new System.Windows.Forms.Button();
            this.btn_WorkingSpeedSetting_1 = new System.Windows.Forms.Button();
            this.checkBox_FullMaterial_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Nomaterial_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Screw_Down_Dead = new System.Windows.Forms.CheckBox();
            this.button_Write_Speed_Value = new System.Windows.Forms.Button();
            this.checkBox_Discharge_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Screw_Up_Dead = new System.Windows.Forms.CheckBox();
            this.checkBox_Positioning_Completed1 = new System.Windows.Forms.CheckBox();
            this.textBox_SpeedSetting = new System.Windows.Forms.TextBox();
            this.textBox_CurrentSpeed = new System.Windows.Forms.TextBox();
            this.label_Speed_Setting = new System.Windows.Forms.Label();
            this.label_SpeedSetting = new System.Windows.Forms.Label();
            this.label_CurrentSpeed = new System.Windows.Forms.Label();
            this.buttonBackToMainScreen_WorkingSpeed = new System.Windows.Forms.Button();
            this.button_Count_OR_Speed = new System.Windows.Forms.Button();
            this.panel_Manual_Mode = new System.Windows.Forms.Panel();
            this.panel_OPR = new System.Windows.Forms.Panel();
            this.button_OPR_Cancel = new System.Windows.Forms.Button();
            this.button_OPR_Confirmation = new System.Windows.Forms.Button();
            this.label_OPR = new System.Windows.Forms.Label();
            this.panel_Close_Electronic_Handwheel3 = new System.Windows.Forms.Panel();
            this.panel_Close_Electronic_Handwheel2 = new System.Windows.Forms.Panel();
            this.panel_Close_Electronic_Handwheel1 = new System.Windows.Forms.Panel();
            this.button_Close_Cancel_Handwheel = new System.Windows.Forms.Button();
            this.button_Close_Electronic_Handwheel = new System.Windows.Forms.Button();
            this.label_Close_Electronic_Handwheel = new System.Windows.Forms.Label();
            this.button_Main_Manual_Mode = new System.Windows.Forms.Button();
            this.button_A_Loop = new System.Windows.Forms.Button();
            this.button_JOG = new System.Windows.Forms.Button();
            this.button_Continuous_Action = new System.Windows.Forms.Button();
            this.button_OPR_Run = new System.Windows.Forms.Button();
            this.button_Tool_Rotation_Run = new System.Windows.Forms.Button();
            this.button_Calibration_Screw = new System.Windows.Forms.Button();
            this.button_Tool_Containing_A_Loop = new System.Windows.Forms.Button();
            this.button_Motor_Start_Run = new System.Windows.Forms.Button();
            this.button_Calibration_Fixture = new System.Windows.Forms.Button();
            this.button_Empty_Disk = new System.Windows.Forms.Button();
            this.button_Turn_Handwheel = new System.Windows.Forms.Button();
            this.button_Turn_Vibration_Plate = new System.Windows.Forms.Button();
            this.button_Turntable_Correction = new System.Windows.Forms.Button();
            this.button_Manual_Mode_Run = new System.Windows.Forms.Button();
            this.panel_Turntable_Correction = new System.Windows.Forms.Panel();
            this.panel_Turntable_Correction_Determine_Disk = new System.Windows.Forms.Panel();
            this.checkBox_OFF_State_Disk = new System.Windows.Forms.CheckBox();
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine = new System.Windows.Forms.Button();
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk = new System.Windows.Forms.Label();
            this.panel_Correction_Boot_Disk2 = new System.Windows.Forms.Panel();
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor = new System.Windows.Forms.CheckBox();
            this.button_Turntable_Correction_Complete = new System.Windows.Forms.Button();
            this.button_panel_Correction_Boot_Disk2_Determine = new System.Windows.Forms.Button();
            this.label_Press_Done_Complete_Disk_Surface_Correction = new System.Windows.Forms.Label();
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point = new System.Windows.Forms.Label();
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes = new System.Windows.Forms.Label();
            this.panel_Correction_Boot_Disk1 = new System.Windows.Forms.Panel();
            this.checkBox_OPR_Complete_Disk = new System.Windows.Forms.CheckBox();
            this.checkBox_Disk_OPR_Point = new System.Windows.Forms.CheckBox();
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor = new System.Windows.Forms.CheckBox();
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor = new System.Windows.Forms.CheckBox();
            this.button_Turntable_Correction_Next = new System.Windows.Forms.Button();
            this.button_Turntable_Correction_Determine = new System.Windows.Forms.Button();
            this.label_OPR_Performed_After_Confirmation = new System.Windows.Forms.Label();
            this.label_Go_Disk_OPR_Point = new System.Windows.Forms.Label();
            this.label_Clamp_Mechanism_Moved_After_Dead_Point = new System.Windows.Forms.Label();
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center = new System.Windows.Forms.Label();
            this.label_Correction_Boot_Disk = new System.Windows.Forms.Label();
            this.panel_Calibration_Fixture = new System.Windows.Forms.Panel();
            this.panel_Turntable_Correction_Determine_Fixture = new System.Windows.Forms.Panel();
            this.checkBox_OFF_State_Fixture = new System.Windows.Forms.CheckBox();
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine = new System.Windows.Forms.Button();
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture = new System.Windows.Forms.Label();
            this.panel_Correcting_Jig_Guide2 = new System.Windows.Forms.Panel();
            this.button_Correcting_Jig_Guide_Determine_Complete = new System.Windows.Forms.Button();
            this.button_Correcting_Jig_Guide_Determine2 = new System.Windows.Forms.Button();
            this.label_Press_Done_Complete_Correction_Jig = new System.Windows.Forms.Label();
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation = new System.Windows.Forms.Label();
            this.panel_Correcting_Jig_Guide1 = new System.Windows.Forms.Panel();
            this.checkBox_OPR_Completed_Jig = new System.Windows.Forms.CheckBox();
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise = new System.Windows.Forms.CheckBox();
            this.button_Correcting_Jig_Guide_Next = new System.Windows.Forms.Button();
            this.button_Correcting_Jig_Guide_Determine1 = new System.Windows.Forms.Button();
            this.label_After_Confirmation_Performed_OPR = new System.Windows.Forms.Label();
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture = new System.Windows.Forms.Label();
            this.label_Correcting_Jig_Guide = new System.Windows.Forms.Label();
            this.panel_Empty_Disk = new System.Windows.Forms.Panel();
            this.panel_Start_Empty_Disk = new System.Windows.Forms.Panel();
            this.button_Start_Empty_Disk_Confirm = new System.Windows.Forms.Button();
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable = new System.Windows.Forms.Label();
            this.label_Note_Machine_About_Run = new System.Windows.Forms.Label();
            this.checkBox_Disk_Empty = new System.Windows.Forms.CheckBox();
            this.checkBox_Empty_Disk = new System.Windows.Forms.CheckBox();
            this.checkBox_Machine_Can_Turned_Off = new System.Windows.Forms.CheckBox();
            this.button_Empty_Disk_Complete = new System.Windows.Forms.Button();
            this.button_label_Start_Empty_Disk_Confirm = new System.Windows.Forms.Button();
            this.button_Start_Empty_Ramp_Confirm = new System.Windows.Forms.Button();
            this.label_Start_Empty_Disk = new System.Windows.Forms.Label();
            this.label_Start_Empty_Ramp = new System.Windows.Forms.Label();
            this.label_Empty_Disk = new System.Windows.Forms.Label();
            this.panel_Screw_Correction_Guide = new System.Windows.Forms.Panel();
            this.panel_Turntable_Correction_Determine_Screw = new System.Windows.Forms.Panel();
            this.checkBox_OFF_State_Screw = new System.Windows.Forms.CheckBox();
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine = new System.Windows.Forms.Button();
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw = new System.Windows.Forms.Label();
            this.panel_Screw_Correction_Guide2 = new System.Windows.Forms.Panel();
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2 = new System.Windows.Forms.CheckBox();
            this.button_Screw_Correction_Guide_Complete = new System.Windows.Forms.Button();
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm = new System.Windows.Forms.Button();
            this.label_Press_Done_Complete_Correction_Screw = new System.Windows.Forms.Label();
            this.label_Screw_Mechanism_Away_Lower_Dead_Point = new System.Windows.Forms.Label();
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction = new System.Windows.Forms.Label();
            this.panel_Screw_Correction_Guide1 = new System.Windows.Forms.Panel();
            this.checkBox_Screw_OPR_Completed = new System.Windows.Forms.CheckBox();
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1 = new System.Windows.Forms.CheckBox();
            this.button_Screw_Correction_Guide_Next = new System.Windows.Forms.Button();
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm = new System.Windows.Forms.Button();
            this.label_OPR_Performed_After_Confirmation_Screw = new System.Windows.Forms.Label();
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw = new System.Windows.Forms.Label();
            this.label_Screw_Correction_Guide = new System.Windows.Forms.Label();
            this.panel_Error_Message = new System.Windows.Forms.Panel();
            this.button_Error_Message_Exclusion_Mistake = new System.Windows.Forms.Button();
            this.button_Error_Message_Speed_Setting = new System.Windows.Forms.Button();
            this.button_Error_Message_Main = new System.Windows.Forms.Button();
            this.button_Error_Message_Manual_Mode = new System.Windows.Forms.Button();
            this.textBox_Error_Message = new System.Windows.Forms.TextBox();
            this.label_Error_Message = new System.Windows.Forms.Label();
            this.panel_Hidden_Features = new System.Windows.Forms.Panel();
            this.label_Hidden_Features_Tool_Speed_Count = new System.Windows.Forms.Label();
            this.label_Hidden_Features_Operating_Speed_Count = new System.Windows.Forms.Label();
            this.label_Hidden_Features_Screw_Position_Count = new System.Windows.Forms.Label();
            this.label_Hidden_Features_Tool_Speed = new System.Windows.Forms.Label();
            this.label_Hidden_Features_Operating_Speed = new System.Windows.Forms.Label();
            this.label_Hidden_Features_Screw_Position = new System.Windows.Forms.Label();
            this.button_Hidden_Features_Two_Axis_Positioning = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Continuous = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Knife_Cycle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Tool_JOG = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Turntable_Inversion = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Screw_Synchronization = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Reverse_Fixture = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Screw_Decline = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Tool_Rotation = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Forward_Wheel = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Fixture_Forward = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Screw_Rise = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Fixture_Synchronization = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Tool_Relax = new System.Windows.Forms.Button();
            this.button_Hidden_Features_PASS_Bottom_Dead = new System.Windows.Forms.Button();
            this.button_Hidden_Features_Motor_Start = new System.Windows.Forms.Button();
            this.panel_I_O_Table = new System.Windows.Forms.Panel();
            this.button_I_O_Table_Switching = new System.Windows.Forms.Button();
            this.button_I_O_Table_Main = new System.Windows.Forms.Button();
            this.panel_I_O_Table_Y = new System.Windows.Forms.Panel();
            this.checkBox_Y101 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y100 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y112 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y012 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y104 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y004 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y111 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y011 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y103 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y003 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y115 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y015 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y107 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y007 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y110 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y010 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y102 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y002 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y114 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y014 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y106 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y006 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y109 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y009 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y001 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y113 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y013 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y105 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y005 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y108 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y008 = new System.Windows.Forms.CheckBox();
            this.checkBox_Y000 = new System.Windows.Forms.CheckBox();
            this.panel_I_O_Table_X = new System.Windows.Forms.Panel();
            this.checkBox_X112 = new System.Windows.Forms.CheckBox();
            this.checkBox_X012 = new System.Windows.Forms.CheckBox();
            this.checkBox_X104 = new System.Windows.Forms.CheckBox();
            this.checkBox_X004 = new System.Windows.Forms.CheckBox();
            this.checkBox_X111 = new System.Windows.Forms.CheckBox();
            this.checkBox_X011 = new System.Windows.Forms.CheckBox();
            this.checkBox_X103 = new System.Windows.Forms.CheckBox();
            this.checkBox_X003 = new System.Windows.Forms.CheckBox();
            this.checkBox_X115 = new System.Windows.Forms.CheckBox();
            this.checkBox_X015 = new System.Windows.Forms.CheckBox();
            this.checkBox_X107 = new System.Windows.Forms.CheckBox();
            this.checkBox_X007 = new System.Windows.Forms.CheckBox();
            this.checkBox_X110 = new System.Windows.Forms.CheckBox();
            this.checkBox_X010 = new System.Windows.Forms.CheckBox();
            this.checkBox_X102 = new System.Windows.Forms.CheckBox();
            this.checkBox_X002 = new System.Windows.Forms.CheckBox();
            this.checkBox_X114 = new System.Windows.Forms.CheckBox();
            this.checkBox_X014 = new System.Windows.Forms.CheckBox();
            this.checkBox_X106 = new System.Windows.Forms.CheckBox();
            this.checkBox_X006 = new System.Windows.Forms.CheckBox();
            this.checkBox_X109 = new System.Windows.Forms.CheckBox();
            this.checkBox_X009 = new System.Windows.Forms.CheckBox();
            this.checkBox_X101 = new System.Windows.Forms.CheckBox();
            this.checkBox_X001 = new System.Windows.Forms.CheckBox();
            this.checkBox_X113 = new System.Windows.Forms.CheckBox();
            this.checkBox_X013 = new System.Windows.Forms.CheckBox();
            this.checkBox_X105 = new System.Windows.Forms.CheckBox();
            this.checkBox_X005 = new System.Windows.Forms.CheckBox();
            this.checkBox_X108 = new System.Windows.Forms.CheckBox();
            this.checkBox_X008 = new System.Windows.Forms.CheckBox();
            this.checkBox_X100 = new System.Windows.Forms.CheckBox();
            this.checkBox_X000 = new System.Windows.Forms.CheckBox();
            this.btn_Program_New_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).BeginInit();
            this.panel_High_Speed_Cutting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Boltun_Logo)).BeginInit();
            this.panel_Shutdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel_CloseProgram.SuspendLayout();
            this.panel_Operation_Guide1.SuspendLayout();
            this.panel_Operation_Guide2.SuspendLayout();
            this.panel_Operation_Guide3.SuspendLayout();
            this.panel_Operation_Guide4.SuspendLayout();
            this.panel_Machine_OPR2.SuspendLayout();
            this.panel_Machine_OPR1.SuspendLayout();
            this.panel_Operation_Guide5.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel_Hide_Password_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Boltun_Main)).BeginInit();
            this.panel_WorkingSpeed.SuspendLayout();
            this.panel_Counting_System.SuspendLayout();
            this.panel_WorkingSpeedSetting.SuspendLayout();
            this.panel_Manual_Mode.SuspendLayout();
            this.panel_OPR.SuspendLayout();
            this.panel_Close_Electronic_Handwheel1.SuspendLayout();
            this.panel_Turntable_Correction.SuspendLayout();
            this.panel_Turntable_Correction_Determine_Disk.SuspendLayout();
            this.panel_Correction_Boot_Disk2.SuspendLayout();
            this.panel_Correction_Boot_Disk1.SuspendLayout();
            this.panel_Calibration_Fixture.SuspendLayout();
            this.panel_Turntable_Correction_Determine_Fixture.SuspendLayout();
            this.panel_Correcting_Jig_Guide2.SuspendLayout();
            this.panel_Correcting_Jig_Guide1.SuspendLayout();
            this.panel_Empty_Disk.SuspendLayout();
            this.panel_Start_Empty_Disk.SuspendLayout();
            this.panel_Screw_Correction_Guide.SuspendLayout();
            this.panel_Turntable_Correction_Determine_Screw.SuspendLayout();
            this.panel_Screw_Correction_Guide2.SuspendLayout();
            this.panel_Screw_Correction_Guide1.SuspendLayout();
            this.panel_Error_Message.SuspendLayout();
            this.panel_Hidden_Features.SuspendLayout();
            this.panel_I_O_Table.SuspendLayout();
            this.panel_I_O_Table_Y.SuspendLayout();
            this.panel_I_O_Table_X.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // axDBCommManager1
            // 
            this.axDBCommManager1.Enabled = true;
            this.axDBCommManager1.Location = new System.Drawing.Point(0, 2);
            this.axDBCommManager1.Name = "axDBCommManager1";
            this.axDBCommManager1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDBCommManager1.OcxState")));
            this.axDBCommManager1.Size = new System.Drawing.Size(24, 24);
            this.axDBCommManager1.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Connect.Location = new System.Drawing.Point(266, 508);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(220, 82);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "連線";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(24, 656);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(114, 37);
            this.btnDisConnect.TabIndex = 2;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Visible = false;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(138, 656);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 37);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(1178, 171);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(96, 50);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "關閉程式";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Visible = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_High_Speed_Cutting
            // 
            this.panel_High_Speed_Cutting.Controls.Add(this.pictureBox_Boltun_Logo);
            this.panel_High_Speed_Cutting.Controls.Add(this.btn_Operation_Guide);
            this.panel_High_Speed_Cutting.Controls.Add(this.label_High_Speed_Cutting);
            this.panel_High_Speed_Cutting.Controls.Add(this.btn_Connect);
            this.panel_High_Speed_Cutting.Location = new System.Drawing.Point(24, 12);
            this.panel_High_Speed_Cutting.Name = "panel_High_Speed_Cutting";
            this.panel_High_Speed_Cutting.Size = new System.Drawing.Size(1148, 638);
            this.panel_High_Speed_Cutting.TabIndex = 7;
            // 
            // pictureBox_Boltun_Logo
            // 
            this.pictureBox_Boltun_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Boltun_Logo.Image")));
            this.pictureBox_Boltun_Logo.Location = new System.Drawing.Point(114, 12);
            this.pictureBox_Boltun_Logo.Name = "pictureBox_Boltun_Logo";
            this.pictureBox_Boltun_Logo.Size = new System.Drawing.Size(919, 264);
            this.pictureBox_Boltun_Logo.TabIndex = 35;
            this.pictureBox_Boltun_Logo.TabStop = false;
            // 
            // btn_Operation_Guide
            // 
            this.btn_Operation_Guide.Enabled = false;
            this.btn_Operation_Guide.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Operation_Guide.Location = new System.Drawing.Point(632, 508);
            this.btn_Operation_Guide.Name = "btn_Operation_Guide";
            this.btn_Operation_Guide.Size = new System.Drawing.Size(220, 82);
            this.btn_Operation_Guide.TabIndex = 3;
            this.btn_Operation_Guide.Text = "操作導引";
            this.btn_Operation_Guide.UseVisualStyleBackColor = true;
            this.btn_Operation_Guide.Click += new System.EventHandler(this.btn_Operation_Guide_Click);
            // 
            // label_High_Speed_Cutting
            // 
            this.label_High_Speed_Cutting.AutoSize = true;
            this.label_High_Speed_Cutting.Font = new System.Drawing.Font("PMingLiU", 100F);
            this.label_High_Speed_Cutting.Location = new System.Drawing.Point(202, 328);
            this.label_High_Speed_Cutting.Name = "label_High_Speed_Cutting";
            this.label_High_Speed_Cutting.Size = new System.Drawing.Size(727, 134);
            this.label_High_Speed_Cutting.TabIndex = 2;
            this.label_High_Speed_Cutting.Text = "高速割尾機";
            // 
            // btn_Shutdown
            // 
            this.btn_Shutdown.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Shutdown.Location = new System.Drawing.Point(1178, 12);
            this.btn_Shutdown.Name = "btn_Shutdown";
            this.btn_Shutdown.Size = new System.Drawing.Size(96, 49);
            this.btn_Shutdown.TabIndex = 10;
            this.btn_Shutdown.Text = "關機";
            this.btn_Shutdown.UseVisualStyleBackColor = true;
            this.btn_Shutdown.Click += new System.EventHandler(this.btn_Shutdown_Click);
            // 
            // panel_Shutdown
            // 
            this.panel_Shutdown.Controls.Add(this.btn_Cancel);
            this.panel_Shutdown.Controls.Add(this.btn_Reboot);
            this.panel_Shutdown.Controls.Add(this.btn_Shutdown_close);
            this.panel_Shutdown.Location = new System.Drawing.Point(24, 12);
            this.panel_Shutdown.Name = "panel_Shutdown";
            this.panel_Shutdown.Size = new System.Drawing.Size(1148, 638);
            this.panel_Shutdown.TabIndex = 12;
            this.panel_Shutdown.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(350, 380);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(342, 197);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Reboot
            // 
            this.btn_Reboot.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Reboot.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Reboot.Location = new System.Drawing.Point(590, 110);
            this.btn_Reboot.Name = "btn_Reboot";
            this.btn_Reboot.Size = new System.Drawing.Size(342, 197);
            this.btn_Reboot.TabIndex = 11;
            this.btn_Reboot.Text = "重新開機";
            this.btn_Reboot.UseVisualStyleBackColor = false;
            this.btn_Reboot.Click += new System.EventHandler(this.btn_Reboot_Click);
            // 
            // btn_Shutdown_close
            // 
            this.btn_Shutdown_close.BackColor = System.Drawing.Color.Red;
            this.btn_Shutdown_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Shutdown_close.FlatAppearance.BorderSize = 0;
            this.btn_Shutdown_close.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Shutdown_close.Location = new System.Drawing.Point(97, 110);
            this.btn_Shutdown_close.Name = "btn_Shutdown_close";
            this.btn_Shutdown_close.Size = new System.Drawing.Size(342, 197);
            this.btn_Shutdown_close.TabIndex = 10;
            this.btn_Shutdown_close.Text = "關機";
            this.btn_Shutdown_close.UseVisualStyleBackColor = false;
            this.btn_Shutdown_close.Click += new System.EventHandler(this.btn_Shutdown_close_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lab_Progress
            // 
            this.lab_Progress.AutoSize = true;
            this.lab_Progress.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Progress.Location = new System.Drawing.Point(211, 721);
            this.lab_Progress.Name = "lab_Progress";
            this.lab_Progress.Size = new System.Drawing.Size(91, 37);
            this.lab_Progress.TabIndex = 13;
            this.lab_Progress.Text = "進度";
            // 
            // lab_SystemStatus
            // 
            this.lab_SystemStatus.AutoSize = true;
            this.lab_SystemStatus.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_SystemStatus.Location = new System.Drawing.Point(17, 721);
            this.lab_SystemStatus.Name = "lab_SystemStatus";
            this.lab_SystemStatus.Size = new System.Drawing.Size(202, 37);
            this.lab_SystemStatus.TabIndex = 14;
            this.lab_SystemStatus.Text = "系統狀態：";
            this.lab_SystemStatus.DoubleClick += new System.EventHandler(this.lab_SystemStatus_DoubleClick);
            // 
            // lab_HideButton
            // 
            this.lab_HideButton.AutoSize = true;
            this.lab_HideButton.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_HideButton.Location = new System.Drawing.Point(1224, 569);
            this.lab_HideButton.Name = "lab_HideButton";
            this.lab_HideButton.Size = new System.Drawing.Size(47, 27);
            this.lab_HideButton.TabIndex = 15;
            this.lab_HideButton.Text = "     ";
            this.lab_HideButton.DoubleClick += new System.EventHandler(this.lab_HideButton_DoubleClick);
            // 
            // panel_CloseProgram
            // 
            this.panel_CloseProgram.Controls.Add(this.label_Enter_Password_Close);
            this.panel_CloseProgram.Controls.Add(this.btn_Return);
            this.panel_CloseProgram.Controls.Add(this.btn_Delete);
            this.panel_CloseProgram.Controls.Add(this.textBox_Password);
            this.panel_CloseProgram.Controls.Add(this.btn_9);
            this.panel_CloseProgram.Controls.Add(this.btn_6);
            this.panel_CloseProgram.Controls.Add(this.btn_3);
            this.panel_CloseProgram.Controls.Add(this.btn_8);
            this.panel_CloseProgram.Controls.Add(this.btn_5);
            this.panel_CloseProgram.Controls.Add(this.btn_2);
            this.panel_CloseProgram.Controls.Add(this.btn__7);
            this.panel_CloseProgram.Controls.Add(this.btn_4);
            this.panel_CloseProgram.Controls.Add(this.btn_CancelClose);
            this.panel_CloseProgram.Controls.Add(this.btn_OK_Close);
            this.panel_CloseProgram.Controls.Add(this.btn_0);
            this.panel_CloseProgram.Controls.Add(this.btn_1);
            this.panel_CloseProgram.Location = new System.Drawing.Point(24, 12);
            this.panel_CloseProgram.Name = "panel_CloseProgram";
            this.panel_CloseProgram.Size = new System.Drawing.Size(1148, 638);
            this.panel_CloseProgram.TabIndex = 25;
            this.panel_CloseProgram.Visible = false;
            // 
            // label_Enter_Password_Close
            // 
            this.label_Enter_Password_Close.AutoSize = true;
            this.label_Enter_Password_Close.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Enter_Password_Close.Location = new System.Drawing.Point(276, 33);
            this.label_Enter_Password_Close.Name = "label_Enter_Password_Close";
            this.label_Enter_Password_Close.Size = new System.Drawing.Size(308, 48);
            this.label_Enter_Password_Close.TabIndex = 3;
            this.label_Enter_Password_Close.Text = "輸入關閉密碼";
            this.label_Enter_Password_Close.DoubleClick += new System.EventHandler(this.label_Enter_Password_Close_DoubleClick);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Return.Location = new System.Drawing.Point(489, 452);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(82, 72);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "退回";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Location = new System.Drawing.Point(594, 205);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(82, 72);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Password.Location = new System.Drawing.Point(264, 91);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(333, 84);
            this.textBox_Password.TabIndex = 1;
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_9.Location = new System.Drawing.Point(489, 369);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(82, 72);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_6.Location = new System.Drawing.Point(489, 288);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(82, 72);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_3.Location = new System.Drawing.Point(489, 205);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(82, 72);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_8.Location = new System.Drawing.Point(386, 369);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(82, 72);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_5.Location = new System.Drawing.Point(386, 288);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(82, 72);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_2.Location = new System.Drawing.Point(386, 205);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(82, 72);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn__7
            // 
            this.btn__7.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn__7.Location = new System.Drawing.Point(284, 369);
            this.btn__7.Name = "btn__7";
            this.btn__7.Size = new System.Drawing.Size(82, 72);
            this.btn__7.TabIndex = 0;
            this.btn__7.Text = "7";
            this.btn__7.UseVisualStyleBackColor = true;
            this.btn__7.Click += new System.EventHandler(this.btn__7_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_4.Location = new System.Drawing.Point(284, 288);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(82, 72);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_CancelClose
            // 
            this.btn_CancelClose.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CancelClose.Location = new System.Drawing.Point(719, 328);
            this.btn_CancelClose.Name = "btn_CancelClose";
            this.btn_CancelClose.Size = new System.Drawing.Size(125, 79);
            this.btn_CancelClose.TabIndex = 0;
            this.btn_CancelClose.Text = "取消";
            this.btn_CancelClose.UseVisualStyleBackColor = true;
            this.btn_CancelClose.Click += new System.EventHandler(this.btn_CancelClose_Click);
            // 
            // btn_OK_Close
            // 
            this.btn_OK_Close.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OK_Close.Location = new System.Drawing.Point(719, 205);
            this.btn_OK_Close.Name = "btn_OK_Close";
            this.btn_OK_Close.Size = new System.Drawing.Size(125, 79);
            this.btn_OK_Close.TabIndex = 0;
            this.btn_OK_Close.Text = "確定";
            this.btn_OK_Close.UseVisualStyleBackColor = true;
            this.btn_OK_Close.Click += new System.EventHandler(this.btn_OK_Close_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_0.Location = new System.Drawing.Point(386, 452);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(82, 72);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_1.Location = new System.Drawing.Point(284, 205);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(82, 72);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // panel_Operation_Guide1
            // 
            this.panel_Operation_Guide1.Controls.Add(this.checkBox_Screw_Below_Dead_Point_Sensor);
            this.panel_Operation_Guide1.Controls.Add(this.checkBox_Screw_Dead_Top_Center_Sensor);
            this.panel_Operation_Guide1.Controls.Add(this.checkBox_Feeding_Confirm_Sensor);
            this.panel_Operation_Guide1.Controls.Add(this.checkBox_No_Material_Sensor);
            this.panel_Operation_Guide1.Controls.Add(this.checkBox_Full_Material_Sensor);
            this.panel_Operation_Guide1.Controls.Add(this.label_Operation_Guide1);
            this.panel_Operation_Guide1.Controls.Add(this.label_Confirm_Machine_Sensors);
            this.panel_Operation_Guide1.Controls.Add(this.btn_Next1);
            this.panel_Operation_Guide1.Location = new System.Drawing.Point(24, 12);
            this.panel_Operation_Guide1.Name = "panel_Operation_Guide1";
            this.panel_Operation_Guide1.Size = new System.Drawing.Size(1148, 638);
            this.panel_Operation_Guide1.TabIndex = 16;
            this.panel_Operation_Guide1.Visible = false;
            // 
            // checkBox_Screw_Below_Dead_Point_Sensor
            // 
            this.checkBox_Screw_Below_Dead_Point_Sensor.AllowDrop = true;
            this.checkBox_Screw_Below_Dead_Point_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Below_Dead_Point_Sensor.AutoCheck = false;
            this.checkBox_Screw_Below_Dead_Point_Sensor.AutoSize = true;
            this.checkBox_Screw_Below_Dead_Point_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Below_Dead_Point_Sensor.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Below_Dead_Point_Sensor.Location = new System.Drawing.Point(205, 535);
            this.checkBox_Screw_Below_Dead_Point_Sensor.Name = "checkBox_Screw_Below_Dead_Point_Sensor";
            this.checkBox_Screw_Below_Dead_Point_Sensor.Size = new System.Drawing.Size(338, 42);
            this.checkBox_Screw_Below_Dead_Point_Sensor.TabIndex = 2;
            this.checkBox_Screw_Below_Dead_Point_Sensor.Text = "螺桿下死點感測器";
            this.checkBox_Screw_Below_Dead_Point_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Screw_Dead_Top_Center_Sensor
            // 
            this.checkBox_Screw_Dead_Top_Center_Sensor.AllowDrop = true;
            this.checkBox_Screw_Dead_Top_Center_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Dead_Top_Center_Sensor.AutoCheck = false;
            this.checkBox_Screw_Dead_Top_Center_Sensor.AutoSize = true;
            this.checkBox_Screw_Dead_Top_Center_Sensor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Screw_Dead_Top_Center_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Dead_Top_Center_Sensor.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Dead_Top_Center_Sensor.Location = new System.Drawing.Point(205, 458);
            this.checkBox_Screw_Dead_Top_Center_Sensor.Name = "checkBox_Screw_Dead_Top_Center_Sensor";
            this.checkBox_Screw_Dead_Top_Center_Sensor.Size = new System.Drawing.Size(338, 42);
            this.checkBox_Screw_Dead_Top_Center_Sensor.TabIndex = 2;
            this.checkBox_Screw_Dead_Top_Center_Sensor.Text = "螺桿上死點感測器";
            this.checkBox_Screw_Dead_Top_Center_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Feeding_Confirm_Sensor
            // 
            this.checkBox_Feeding_Confirm_Sensor.AllowDrop = true;
            this.checkBox_Feeding_Confirm_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Feeding_Confirm_Sensor.AutoCheck = false;
            this.checkBox_Feeding_Confirm_Sensor.AutoSize = true;
            this.checkBox_Feeding_Confirm_Sensor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Feeding_Confirm_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Feeding_Confirm_Sensor.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Feeding_Confirm_Sensor.Location = new System.Drawing.Point(205, 390);
            this.checkBox_Feeding_Confirm_Sensor.Name = "checkBox_Feeding_Confirm_Sensor";
            this.checkBox_Feeding_Confirm_Sensor.Size = new System.Drawing.Size(301, 42);
            this.checkBox_Feeding_Confirm_Sensor.TabIndex = 2;
            this.checkBox_Feeding_Confirm_Sensor.Text = "入料確認感測器";
            this.checkBox_Feeding_Confirm_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_No_Material_Sensor
            // 
            this.checkBox_No_Material_Sensor.AllowDrop = true;
            this.checkBox_No_Material_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_No_Material_Sensor.AutoCheck = false;
            this.checkBox_No_Material_Sensor.AutoSize = true;
            this.checkBox_No_Material_Sensor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_No_Material_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_No_Material_Sensor.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_No_Material_Sensor.Location = new System.Drawing.Point(205, 324);
            this.checkBox_No_Material_Sensor.Name = "checkBox_No_Material_Sensor";
            this.checkBox_No_Material_Sensor.Size = new System.Drawing.Size(227, 42);
            this.checkBox_No_Material_Sensor.TabIndex = 2;
            this.checkBox_No_Material_Sensor.Text = "無料感測器";
            this.checkBox_No_Material_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Full_Material_Sensor
            // 
            this.checkBox_Full_Material_Sensor.AllowDrop = true;
            this.checkBox_Full_Material_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Full_Material_Sensor.AutoCheck = false;
            this.checkBox_Full_Material_Sensor.AutoSize = true;
            this.checkBox_Full_Material_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Full_Material_Sensor.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Full_Material_Sensor.Location = new System.Drawing.Point(205, 258);
            this.checkBox_Full_Material_Sensor.Name = "checkBox_Full_Material_Sensor";
            this.checkBox_Full_Material_Sensor.Size = new System.Drawing.Size(227, 42);
            this.checkBox_Full_Material_Sensor.TabIndex = 2;
            this.checkBox_Full_Material_Sensor.Text = "滿料感測器";
            this.checkBox_Full_Material_Sensor.UseVisualStyleBackColor = true;
            // 
            // label_Operation_Guide1
            // 
            this.label_Operation_Guide1.AutoSize = true;
            this.label_Operation_Guide1.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Operation_Guide1.Location = new System.Drawing.Point(322, 16);
            this.label_Operation_Guide1.Name = "label_Operation_Guide1";
            this.label_Operation_Guide1.Size = new System.Drawing.Size(424, 96);
            this.label_Operation_Guide1.TabIndex = 1;
            this.label_Operation_Guide1.Text = "操作導引";
            // 
            // label_Confirm_Machine_Sensors
            // 
            this.label_Confirm_Machine_Sensors.AutoSize = true;
            this.label_Confirm_Machine_Sensors.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Confirm_Machine_Sensors.Location = new System.Drawing.Point(182, 187);
            this.label_Confirm_Machine_Sensors.Name = "label_Confirm_Machine_Sensors";
            this.label_Confirm_Machine_Sensors.Size = new System.Drawing.Size(486, 48);
            this.label_Confirm_Machine_Sensors.TabIndex = 1;
            this.label_Confirm_Machine_Sensors.Text = "1.確認機台感測器狀態";
            // 
            // btn_Next1
            // 
            this.btn_Next1.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next1.Location = new System.Drawing.Point(630, 506);
            this.btn_Next1.Name = "btn_Next1";
            this.btn_Next1.Size = new System.Drawing.Size(142, 71);
            this.btn_Next1.TabIndex = 0;
            this.btn_Next1.Text = "下一頁";
            this.btn_Next1.UseVisualStyleBackColor = true;
            this.btn_Next1.Click += new System.EventHandler(this.btn_Next1_Click);
            // 
            // panel_Operation_Guide2
            // 
            this.panel_Operation_Guide2.Controls.Add(this.label_Operation_Guide2);
            this.panel_Operation_Guide2.Controls.Add(this.button_None_Workpiece_Turntable);
            this.panel_Operation_Guide2.Controls.Add(this.button_Machine_Table_No_Foreign_Body);
            this.panel_Operation_Guide2.Controls.Add(this.button_Track_No_Material_Discharge_Port);
            this.panel_Operation_Guide2.Controls.Add(this.checkBox_None_Workpiece_Turntable);
            this.panel_Operation_Guide2.Controls.Add(this.checkBox_Machine_Table_No_Foreign_Body);
            this.panel_Operation_Guide2.Controls.Add(this.checkBox_Track_No_Material_Discharge_Port);
            this.panel_Operation_Guide2.Controls.Add(this.label_Confirm_Machine_Workpiece);
            this.panel_Operation_Guide2.Controls.Add(this.btn_Next2);
            this.panel_Operation_Guide2.Location = new System.Drawing.Point(24, 12);
            this.panel_Operation_Guide2.Name = "panel_Operation_Guide2";
            this.panel_Operation_Guide2.Size = new System.Drawing.Size(1148, 638);
            this.panel_Operation_Guide2.TabIndex = 17;
            this.panel_Operation_Guide2.Visible = false;
            // 
            // label_Operation_Guide2
            // 
            this.label_Operation_Guide2.AutoSize = true;
            this.label_Operation_Guide2.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Operation_Guide2.Location = new System.Drawing.Point(322, 16);
            this.label_Operation_Guide2.Name = "label_Operation_Guide2";
            this.label_Operation_Guide2.Size = new System.Drawing.Size(424, 96);
            this.label_Operation_Guide2.TabIndex = 11;
            this.label_Operation_Guide2.Text = "操作導引";
            // 
            // button_None_Workpiece_Turntable
            // 
            this.button_None_Workpiece_Turntable.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_None_Workpiece_Turntable.Location = new System.Drawing.Point(552, 410);
            this.button_None_Workpiece_Turntable.Name = "button_None_Workpiece_Turntable";
            this.button_None_Workpiece_Turntable.Size = new System.Drawing.Size(101, 42);
            this.button_None_Workpiece_Turntable.TabIndex = 10;
            this.button_None_Workpiece_Turntable.Text = "確認";
            this.button_None_Workpiece_Turntable.UseVisualStyleBackColor = true;
            this.button_None_Workpiece_Turntable.Click += new System.EventHandler(this.button_None_Workpiece_Turntable_Click);
            // 
            // button_Machine_Table_No_Foreign_Body
            // 
            this.button_Machine_Table_No_Foreign_Body.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Machine_Table_No_Foreign_Body.Location = new System.Drawing.Point(552, 324);
            this.button_Machine_Table_No_Foreign_Body.Name = "button_Machine_Table_No_Foreign_Body";
            this.button_Machine_Table_No_Foreign_Body.Size = new System.Drawing.Size(101, 42);
            this.button_Machine_Table_No_Foreign_Body.TabIndex = 10;
            this.button_Machine_Table_No_Foreign_Body.Text = "確認";
            this.button_Machine_Table_No_Foreign_Body.UseVisualStyleBackColor = true;
            this.button_Machine_Table_No_Foreign_Body.Click += new System.EventHandler(this.button_Machine_Table_No_Foreign_Body_Click);
            // 
            // button_Track_No_Material_Discharge_Port
            // 
            this.button_Track_No_Material_Discharge_Port.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Track_No_Material_Discharge_Port.Location = new System.Drawing.Point(552, 243);
            this.button_Track_No_Material_Discharge_Port.Name = "button_Track_No_Material_Discharge_Port";
            this.button_Track_No_Material_Discharge_Port.Size = new System.Drawing.Size(101, 42);
            this.button_Track_No_Material_Discharge_Port.TabIndex = 10;
            this.button_Track_No_Material_Discharge_Port.Text = "確認";
            this.button_Track_No_Material_Discharge_Port.UseVisualStyleBackColor = true;
            this.button_Track_No_Material_Discharge_Port.Click += new System.EventHandler(this.button_Track_No_Material_Discharge_Port_Click);
            // 
            // checkBox_None_Workpiece_Turntable
            // 
            this.checkBox_None_Workpiece_Turntable.AllowDrop = true;
            this.checkBox_None_Workpiece_Turntable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_None_Workpiece_Turntable.AutoCheck = false;
            this.checkBox_None_Workpiece_Turntable.AutoSize = true;
            this.checkBox_None_Workpiece_Turntable.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_None_Workpiece_Turntable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_None_Workpiece_Turntable.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_None_Workpiece_Turntable.Location = new System.Drawing.Point(224, 410);
            this.checkBox_None_Workpiece_Turntable.Name = "checkBox_None_Workpiece_Turntable";
            this.checkBox_None_Workpiece_Turntable.Size = new System.Drawing.Size(264, 42);
            this.checkBox_None_Workpiece_Turntable.TabIndex = 8;
            this.checkBox_None_Workpiece_Turntable.Text = "轉盤上無工件";
            this.checkBox_None_Workpiece_Turntable.UseVisualStyleBackColor = true;
            // 
            // checkBox_Machine_Table_No_Foreign_Body
            // 
            this.checkBox_Machine_Table_No_Foreign_Body.AllowDrop = true;
            this.checkBox_Machine_Table_No_Foreign_Body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Machine_Table_No_Foreign_Body.AutoCheck = false;
            this.checkBox_Machine_Table_No_Foreign_Body.AutoSize = true;
            this.checkBox_Machine_Table_No_Foreign_Body.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Machine_Table_No_Foreign_Body.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Machine_Table_No_Foreign_Body.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Machine_Table_No_Foreign_Body.Location = new System.Drawing.Point(224, 324);
            this.checkBox_Machine_Table_No_Foreign_Body.Name = "checkBox_Machine_Table_No_Foreign_Body";
            this.checkBox_Machine_Table_No_Foreign_Body.Size = new System.Drawing.Size(264, 42);
            this.checkBox_Machine_Table_No_Foreign_Body.TabIndex = 9;
            this.checkBox_Machine_Table_No_Foreign_Body.Text = "機台上無異物";
            this.checkBox_Machine_Table_No_Foreign_Body.UseVisualStyleBackColor = true;
            // 
            // checkBox_Track_No_Material_Discharge_Port
            // 
            this.checkBox_Track_No_Material_Discharge_Port.AllowDrop = true;
            this.checkBox_Track_No_Material_Discharge_Port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Track_No_Material_Discharge_Port.AutoCheck = false;
            this.checkBox_Track_No_Material_Discharge_Port.AutoSize = true;
            this.checkBox_Track_No_Material_Discharge_Port.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Track_No_Material_Discharge_Port.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Track_No_Material_Discharge_Port.Location = new System.Drawing.Point(224, 243);
            this.checkBox_Track_No_Material_Discharge_Port.Name = "checkBox_Track_No_Material_Discharge_Port";
            this.checkBox_Track_No_Material_Discharge_Port.Size = new System.Drawing.Size(301, 42);
            this.checkBox_Track_No_Material_Discharge_Port.TabIndex = 5;
            this.checkBox_Track_No_Material_Discharge_Port.Text = "軌道出料口無料";
            this.checkBox_Track_No_Material_Discharge_Port.UseVisualStyleBackColor = true;
            // 
            // label_Confirm_Machine_Workpiece
            // 
            this.label_Confirm_Machine_Workpiece.AutoSize = true;
            this.label_Confirm_Machine_Workpiece.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Confirm_Machine_Workpiece.Location = new System.Drawing.Point(201, 172);
            this.label_Confirm_Machine_Workpiece.Name = "label_Confirm_Machine_Workpiece";
            this.label_Confirm_Machine_Workpiece.Size = new System.Drawing.Size(486, 48);
            this.label_Confirm_Machine_Workpiece.TabIndex = 4;
            this.label_Confirm_Machine_Workpiece.Text = "2.確認機台上有無工件";
            // 
            // btn_Next2
            // 
            this.btn_Next2.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next2.Location = new System.Drawing.Point(630, 506);
            this.btn_Next2.Name = "btn_Next2";
            this.btn_Next2.Size = new System.Drawing.Size(142, 71);
            this.btn_Next2.TabIndex = 3;
            this.btn_Next2.Text = "下一頁";
            this.btn_Next2.UseVisualStyleBackColor = true;
            this.btn_Next2.Click += new System.EventHandler(this.btn_Next2_Click);
            // 
            // panel_Operation_Guide3
            // 
            this.panel_Operation_Guide3.Controls.Add(this.label_Operation_Guide3);
            this.panel_Operation_Guide3.Controls.Add(this.button_Hair_Shock_On_Track);
            this.panel_Operation_Guide3.Controls.Add(this.button_Pneumatic_Adequate_Machine);
            this.panel_Operation_Guide3.Controls.Add(this.checkBox_Hair_Shock_On_Track);
            this.panel_Operation_Guide3.Controls.Add(this.checkBox_Pneumatic_Adequate_Machine);
            this.panel_Operation_Guide3.Controls.Add(this.label_Confirm_Before_Running_Machine);
            this.panel_Operation_Guide3.Controls.Add(this.btn_Next3);
            this.panel_Operation_Guide3.Location = new System.Drawing.Point(24, 12);
            this.panel_Operation_Guide3.Name = "panel_Operation_Guide3";
            this.panel_Operation_Guide3.Size = new System.Drawing.Size(1148, 638);
            this.panel_Operation_Guide3.TabIndex = 18;
            this.panel_Operation_Guide3.Visible = false;
            // 
            // label_Operation_Guide3
            // 
            this.label_Operation_Guide3.AutoSize = true;
            this.label_Operation_Guide3.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Operation_Guide3.Location = new System.Drawing.Point(322, 16);
            this.label_Operation_Guide3.Name = "label_Operation_Guide3";
            this.label_Operation_Guide3.Size = new System.Drawing.Size(424, 96);
            this.label_Operation_Guide3.TabIndex = 17;
            this.label_Operation_Guide3.Text = "操作導引";
            // 
            // button_Hair_Shock_On_Track
            // 
            this.button_Hair_Shock_On_Track.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hair_Shock_On_Track.Location = new System.Drawing.Point(610, 382);
            this.button_Hair_Shock_On_Track.Name = "button_Hair_Shock_On_Track";
            this.button_Hair_Shock_On_Track.Size = new System.Drawing.Size(101, 42);
            this.button_Hair_Shock_On_Track.TabIndex = 15;
            this.button_Hair_Shock_On_Track.Text = "確認";
            this.button_Hair_Shock_On_Track.UseVisualStyleBackColor = true;
            this.button_Hair_Shock_On_Track.Click += new System.EventHandler(this.button_Hair_Shock_On_Track_Click);
            // 
            // button_Pneumatic_Adequate_Machine
            // 
            this.button_Pneumatic_Adequate_Machine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Pneumatic_Adequate_Machine.Location = new System.Drawing.Point(610, 292);
            this.button_Pneumatic_Adequate_Machine.Name = "button_Pneumatic_Adequate_Machine";
            this.button_Pneumatic_Adequate_Machine.Size = new System.Drawing.Size(101, 42);
            this.button_Pneumatic_Adequate_Machine.TabIndex = 16;
            this.button_Pneumatic_Adequate_Machine.Text = "確認";
            this.button_Pneumatic_Adequate_Machine.UseVisualStyleBackColor = true;
            this.button_Pneumatic_Adequate_Machine.Click += new System.EventHandler(this.button_Pneumatic_Adequate_Machine_Click);
            // 
            // checkBox_Hair_Shock_On_Track
            // 
            this.checkBox_Hair_Shock_On_Track.AllowDrop = true;
            this.checkBox_Hair_Shock_On_Track.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Hair_Shock_On_Track.AutoCheck = false;
            this.checkBox_Hair_Shock_On_Track.AutoSize = true;
            this.checkBox_Hair_Shock_On_Track.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Hair_Shock_On_Track.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Hair_Shock_On_Track.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Hair_Shock_On_Track.Location = new System.Drawing.Point(233, 386);
            this.checkBox_Hair_Shock_On_Track.Name = "checkBox_Hair_Shock_On_Track";
            this.checkBox_Hair_Shock_On_Track.Size = new System.Drawing.Size(375, 42);
            this.checkBox_Hair_Shock_On_Track.TabIndex = 14;
            this.checkBox_Hair_Shock_On_Track.Text = "軌道吹風震動已開啟";
            this.checkBox_Hair_Shock_On_Track.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pneumatic_Adequate_Machine
            // 
            this.checkBox_Pneumatic_Adequate_Machine.AllowDrop = true;
            this.checkBox_Pneumatic_Adequate_Machine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Pneumatic_Adequate_Machine.AutoCheck = false;
            this.checkBox_Pneumatic_Adequate_Machine.AutoSize = true;
            this.checkBox_Pneumatic_Adequate_Machine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Pneumatic_Adequate_Machine.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Pneumatic_Adequate_Machine.Location = new System.Drawing.Point(233, 292);
            this.checkBox_Pneumatic_Adequate_Machine.Name = "checkBox_Pneumatic_Adequate_Machine";
            this.checkBox_Pneumatic_Adequate_Machine.Size = new System.Drawing.Size(264, 42);
            this.checkBox_Pneumatic_Adequate_Machine.TabIndex = 13;
            this.checkBox_Pneumatic_Adequate_Machine.Text = "機台空壓充足";
            this.checkBox_Pneumatic_Adequate_Machine.UseVisualStyleBackColor = true;
            // 
            // label_Confirm_Before_Running_Machine
            // 
            this.label_Confirm_Before_Running_Machine.AutoSize = true;
            this.label_Confirm_Before_Running_Machine.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Confirm_Before_Running_Machine.Location = new System.Drawing.Point(201, 187);
            this.label_Confirm_Before_Running_Machine.Name = "label_Confirm_Before_Running_Machine";
            this.label_Confirm_Before_Running_Machine.Size = new System.Drawing.Size(390, 48);
            this.label_Confirm_Before_Running_Machine.TabIndex = 12;
            this.label_Confirm_Before_Running_Machine.Text = "3.機台運行前確認";
            // 
            // btn_Next3
            // 
            this.btn_Next3.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next3.Location = new System.Drawing.Point(630, 506);
            this.btn_Next3.Name = "btn_Next3";
            this.btn_Next3.Size = new System.Drawing.Size(142, 71);
            this.btn_Next3.TabIndex = 11;
            this.btn_Next3.Text = "下一頁";
            this.btn_Next3.UseVisualStyleBackColor = true;
            this.btn_Next3.Click += new System.EventHandler(this.btn_Next3_Click);
            // 
            // panel_Operation_Guide4
            // 
            this.panel_Operation_Guide4.Controls.Add(this.panel_Machine_OPR2);
            this.panel_Operation_Guide4.Controls.Add(this.panel_Machine_OPR1);
            this.panel_Operation_Guide4.Controls.Add(this.label_Operation_Guide4);
            this.panel_Operation_Guide4.Controls.Add(this.label_Machine_OPR);
            this.panel_Operation_Guide4.Location = new System.Drawing.Point(24, 12);
            this.panel_Operation_Guide4.Name = "panel_Operation_Guide4";
            this.panel_Operation_Guide4.Size = new System.Drawing.Size(1148, 638);
            this.panel_Operation_Guide4.TabIndex = 19;
            this.panel_Operation_Guide4.Visible = false;
            // 
            // panel_Machine_OPR2
            // 
            this.panel_Machine_OPR2.Controls.Add(this.button_Sensor_Normal);
            this.panel_Machine_OPR2.Controls.Add(this.checkBox_Sensor_Normal);
            this.panel_Machine_OPR2.Controls.Add(this.label_Confirm_Screw);
            this.panel_Machine_OPR2.Location = new System.Drawing.Point(157, 256);
            this.panel_Machine_OPR2.Name = "panel_Machine_OPR2";
            this.panel_Machine_OPR2.Size = new System.Drawing.Size(651, 357);
            this.panel_Machine_OPR2.TabIndex = 18;
            this.panel_Machine_OPR2.Visible = false;
            // 
            // button_Sensor_Normal
            // 
            this.button_Sensor_Normal.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Sensor_Normal.Location = new System.Drawing.Point(318, 170);
            this.button_Sensor_Normal.Name = "button_Sensor_Normal";
            this.button_Sensor_Normal.Size = new System.Drawing.Size(110, 44);
            this.button_Sensor_Normal.TabIndex = 20;
            this.button_Sensor_Normal.Text = "確認";
            this.button_Sensor_Normal.UseVisualStyleBackColor = true;
            this.button_Sensor_Normal.Click += new System.EventHandler(this.button_Sensor_Normal_Click);
            // 
            // checkBox_Sensor_Normal
            // 
            this.checkBox_Sensor_Normal.AllowDrop = true;
            this.checkBox_Sensor_Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Sensor_Normal.AutoCheck = false;
            this.checkBox_Sensor_Normal.AutoSize = true;
            this.checkBox_Sensor_Normal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Sensor_Normal.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Sensor_Normal.Location = new System.Drawing.Point(73, 172);
            this.checkBox_Sensor_Normal.Name = "checkBox_Sensor_Normal";
            this.checkBox_Sensor_Normal.Size = new System.Drawing.Size(227, 42);
            this.checkBox_Sensor_Normal.TabIndex = 19;
            this.checkBox_Sensor_Normal.Text = "感測器正常";
            this.checkBox_Sensor_Normal.UseVisualStyleBackColor = true;
            // 
            // label_Confirm_Screw
            // 
            this.label_Confirm_Screw.AutoSize = true;
            this.label_Confirm_Screw.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Confirm_Screw.Location = new System.Drawing.Point(56, 83);
            this.label_Confirm_Screw.Name = "label_Confirm_Screw";
            this.label_Confirm_Screw.Size = new System.Drawing.Size(508, 37);
            this.label_Confirm_Screw.TabIndex = 0;
            this.label_Confirm_Screw.Text = "請確認螺桿 下死點感測器正常";
            // 
            // panel_Machine_OPR1
            // 
            this.panel_Machine_OPR1.Controls.Add(this.button_OPR);
            this.panel_Machine_OPR1.Controls.Add(this.button_Motor_Start);
            this.panel_Machine_OPR1.Controls.Add(this.checkBox_Positioning_Completed);
            this.panel_Machine_OPR1.Controls.Add(this.btn_Next4);
            this.panel_Machine_OPR1.Location = new System.Drawing.Point(157, 256);
            this.panel_Machine_OPR1.Name = "panel_Machine_OPR1";
            this.panel_Machine_OPR1.Size = new System.Drawing.Size(651, 357);
            this.panel_Machine_OPR1.TabIndex = 18;
            // 
            // button_OPR
            // 
            this.button_OPR.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OPR.Location = new System.Drawing.Point(319, 36);
            this.button_OPR.Name = "button_OPR";
            this.button_OPR.Size = new System.Drawing.Size(198, 123);
            this.button_OPR.TabIndex = 19;
            this.button_OPR.Text = "原點復歸";
            this.button_OPR.UseVisualStyleBackColor = true;
            this.button_OPR.Click += new System.EventHandler(this.button_OPR_Click);
            // 
            // button_Motor_Start
            // 
            this.button_Motor_Start.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Motor_Start.Location = new System.Drawing.Point(37, 35);
            this.button_Motor_Start.Name = "button_Motor_Start";
            this.button_Motor_Start.Size = new System.Drawing.Size(197, 123);
            this.button_Motor_Start.TabIndex = 20;
            this.button_Motor_Start.Text = "馬達啟動";
            this.button_Motor_Start.UseVisualStyleBackColor = true;
            this.button_Motor_Start.Click += new System.EventHandler(this.button_Motor_Start_Click);
            // 
            // checkBox_Positioning_Completed
            // 
            this.checkBox_Positioning_Completed.AllowDrop = true;
            this.checkBox_Positioning_Completed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Positioning_Completed.AutoCheck = false;
            this.checkBox_Positioning_Completed.AutoSize = true;
            this.checkBox_Positioning_Completed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Positioning_Completed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Positioning_Completed.Location = new System.Drawing.Point(35, 231);
            this.checkBox_Positioning_Completed.Name = "checkBox_Positioning_Completed";
            this.checkBox_Positioning_Completed.Size = new System.Drawing.Size(190, 42);
            this.checkBox_Positioning_Completed.TabIndex = 18;
            this.checkBox_Positioning_Completed.Text = "定位完成";
            this.checkBox_Positioning_Completed.UseVisualStyleBackColor = true;
            // 
            // btn_Next4
            // 
            this.btn_Next4.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Next4.Location = new System.Drawing.Point(473, 250);
            this.btn_Next4.Name = "btn_Next4";
            this.btn_Next4.Size = new System.Drawing.Size(142, 71);
            this.btn_Next4.TabIndex = 17;
            this.btn_Next4.Text = "下一頁";
            this.btn_Next4.UseVisualStyleBackColor = true;
            this.btn_Next4.Click += new System.EventHandler(this.btn_Next4_Click);
            // 
            // label_Operation_Guide4
            // 
            this.label_Operation_Guide4.AutoSize = true;
            this.label_Operation_Guide4.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Operation_Guide4.Location = new System.Drawing.Point(322, 16);
            this.label_Operation_Guide4.Name = "label_Operation_Guide4";
            this.label_Operation_Guide4.Size = new System.Drawing.Size(424, 96);
            this.label_Operation_Guide4.TabIndex = 17;
            this.label_Operation_Guide4.Text = "操作導引";
            // 
            // label_Machine_OPR
            // 
            this.label_Machine_OPR.AutoSize = true;
            this.label_Machine_OPR.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Machine_OPR.Location = new System.Drawing.Point(201, 187);
            this.label_Machine_OPR.Name = "label_Machine_OPR";
            this.label_Machine_OPR.Size = new System.Drawing.Size(342, 48);
            this.label_Machine_OPR.TabIndex = 12;
            this.label_Machine_OPR.Text = "4.機台原點復歸";
            // 
            // panel_Operation_Guide5
            // 
            this.panel_Operation_Guide5.Controls.Add(this.button_Main);
            this.panel_Operation_Guide5.Controls.Add(this.checkBox_Xaxis);
            this.panel_Operation_Guide5.Controls.Add(this.button_Tool_Rotation);
            this.panel_Operation_Guide5.Controls.Add(this.button_Screw_Synchronization);
            this.panel_Operation_Guide5.Controls.Add(this.label_Operation_Guide5);
            this.panel_Operation_Guide5.Controls.Add(this.label_Screw_Position_Value);
            this.panel_Operation_Guide5.Controls.Add(this.label_Screw_Position);
            this.panel_Operation_Guide5.Controls.Add(this.label_Tool_Rotation);
            this.panel_Operation_Guide5.Controls.Add(this.label_Screw_Synchronization);
            this.panel_Operation_Guide5.Controls.Add(this.label_Screw_Synchronous_Starting_Point);
            this.panel_Operation_Guide5.Controls.Add(this.label_Xaxis_Hand_Wheel_Knob);
            this.panel_Operation_Guide5.Controls.Add(this.label_Tool_Positioning_Screw_Start);
            this.panel_Operation_Guide5.Location = new System.Drawing.Point(24, 12);
            this.panel_Operation_Guide5.Name = "panel_Operation_Guide5";
            this.panel_Operation_Guide5.Size = new System.Drawing.Size(1148, 638);
            this.panel_Operation_Guide5.TabIndex = 20;
            this.panel_Operation_Guide5.Visible = false;
            // 
            // button_Main
            // 
            this.button_Main.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Main.Location = new System.Drawing.Point(421, 554);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(142, 71);
            this.button_Main.TabIndex = 17;
            this.button_Main.Text = "主畫面";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // checkBox_Xaxis
            // 
            this.checkBox_Xaxis.AllowDrop = true;
            this.checkBox_Xaxis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Xaxis.AutoCheck = false;
            this.checkBox_Xaxis.AutoSize = true;
            this.checkBox_Xaxis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Xaxis.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Xaxis.Location = new System.Drawing.Point(669, 282);
            this.checkBox_Xaxis.Name = "checkBox_Xaxis";
            this.checkBox_Xaxis.Size = new System.Drawing.Size(104, 42);
            this.checkBox_Xaxis.TabIndex = 18;
            this.checkBox_Xaxis.Text = "X軸";
            this.checkBox_Xaxis.UseVisualStyleBackColor = true;
            // 
            // button_Tool_Rotation
            // 
            this.button_Tool_Rotation.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Tool_Rotation.Location = new System.Drawing.Point(609, 482);
            this.button_Tool_Rotation.Name = "button_Tool_Rotation";
            this.button_Tool_Rotation.Size = new System.Drawing.Size(117, 40);
            this.button_Tool_Rotation.TabIndex = 19;
            this.button_Tool_Rotation.Text = "刀具旋轉";
            this.button_Tool_Rotation.UseVisualStyleBackColor = true;
            this.button_Tool_Rotation.Click += new System.EventHandler(this.button_Tool_Rotation_Click);
            // 
            // button_Screw_Synchronization
            // 
            this.button_Screw_Synchronization.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Screw_Synchronization.Location = new System.Drawing.Point(609, 416);
            this.button_Screw_Synchronization.Name = "button_Screw_Synchronization";
            this.button_Screw_Synchronization.Size = new System.Drawing.Size(117, 40);
            this.button_Screw_Synchronization.TabIndex = 19;
            this.button_Screw_Synchronization.Text = "螺桿同步";
            this.button_Screw_Synchronization.UseVisualStyleBackColor = true;
            this.button_Screw_Synchronization.Click += new System.EventHandler(this.button_Screw_Synchronization_Click);
            // 
            // label_Operation_Guide5
            // 
            this.label_Operation_Guide5.AutoSize = true;
            this.label_Operation_Guide5.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Operation_Guide5.Location = new System.Drawing.Point(322, 16);
            this.label_Operation_Guide5.Name = "label_Operation_Guide5";
            this.label_Operation_Guide5.Size = new System.Drawing.Size(424, 96);
            this.label_Operation_Guide5.TabIndex = 17;
            this.label_Operation_Guide5.Text = "操作導引";
            // 
            // label_Screw_Position_Value
            // 
            this.label_Screw_Position_Value.AutoSize = true;
            this.label_Screw_Position_Value.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Position_Value.Location = new System.Drawing.Point(232, 602);
            this.label_Screw_Position_Value.Name = "label_Screw_Position_Value";
            this.label_Screw_Position_Value.Size = new System.Drawing.Size(60, 24);
            this.label_Screw_Position_Value.TabIndex = 12;
            this.label_Screw_Position_Value.Text = "999.9";
            // 
            // label_Screw_Position
            // 
            this.label_Screw_Position.AutoSize = true;
            this.label_Screw_Position.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Position.Location = new System.Drawing.Point(220, 567);
            this.label_Screw_Position.Name = "label_Screw_Position";
            this.label_Screw_Position.Size = new System.Drawing.Size(106, 24);
            this.label_Screw_Position.TabIndex = 12;
            this.label_Screw_Position.Text = "螺桿位置";
            // 
            // label_Tool_Rotation
            // 
            this.label_Tool_Rotation.AutoSize = true;
            this.label_Tool_Rotation.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Tool_Rotation.Location = new System.Drawing.Point(257, 482);
            this.label_Tool_Rotation.Name = "label_Tool_Rotation";
            this.label_Tool_Rotation.Size = new System.Drawing.Size(166, 32);
            this.label_Tool_Rotation.TabIndex = 12;
            this.label_Tool_Rotation.Text = "4.刀具旋轉";
            // 
            // label_Screw_Synchronization
            // 
            this.label_Screw_Synchronization.AutoSize = true;
            this.label_Screw_Synchronization.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Synchronization.Location = new System.Drawing.Point(257, 416);
            this.label_Screw_Synchronization.Name = "label_Screw_Synchronization";
            this.label_Screw_Synchronization.Size = new System.Drawing.Size(306, 32);
            this.label_Screw_Synchronization.TabIndex = 12;
            this.label_Screw_Synchronization.Text = "3.螺桿同步(手輪OFF)";
            // 
            // label_Screw_Synchronous_Starting_Point
            // 
            this.label_Screw_Synchronous_Starting_Point.AutoSize = true;
            this.label_Screw_Synchronous_Starting_Point.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Synchronous_Starting_Point.Location = new System.Drawing.Point(257, 354);
            this.label_Screw_Synchronous_Starting_Point.Name = "label_Screw_Synchronous_Starting_Point";
            this.label_Screw_Synchronous_Starting_Point.Size = new System.Drawing.Size(358, 32);
            this.label_Screw_Synchronous_Starting_Point.TabIndex = 12;
            this.label_Screw_Synchronous_Starting_Point.Text = "2.請螺桿移到同步起始點";
            // 
            // label_Xaxis_Hand_Wheel_Knob
            // 
            this.label_Xaxis_Hand_Wheel_Knob.AutoSize = true;
            this.label_Xaxis_Hand_Wheel_Knob.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Xaxis_Hand_Wheel_Knob.Location = new System.Drawing.Point(257, 288);
            this.label_Xaxis_Hand_Wheel_Knob.Name = "label_Xaxis_Hand_Wheel_Knob";
            this.label_Xaxis_Hand_Wheel_Knob.Size = new System.Drawing.Size(348, 32);
            this.label_Xaxis_Hand_Wheel_Knob.TabIndex = 12;
            this.label_Xaxis_Hand_Wheel_Knob.Text = "1.請將手輪旋扭轉至X軸";
            // 
            // label_Tool_Positioning_Screw_Start
            // 
            this.label_Tool_Positioning_Screw_Start.AutoSize = true;
            this.label_Tool_Positioning_Screw_Start.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Tool_Positioning_Screw_Start.Location = new System.Drawing.Point(240, 187);
            this.label_Tool_Positioning_Screw_Start.Name = "label_Tool_Positioning_Screw_Start";
            this.label_Tool_Positioning_Screw_Start.Size = new System.Drawing.Size(486, 48);
            this.label_Tool_Positioning_Screw_Start.TabIndex = 12;
            this.label_Tool_Positioning_Screw_Start.Text = "5.刀具螺桿定位、啟動";
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_Hide_Password_Function);
            this.panel_Main.Controls.Add(this.pictureBox_Boltun_Main);
            this.panel_Main.Controls.Add(this.button_Analog_Operation);
            this.panel_Main.Controls.Add(this.button_Machine_Stop);
            this.panel_Main.Controls.Add(this.button_Input_Output_List);
            this.panel_Main.Controls.Add(this.button_Machine_Start);
            this.panel_Main.Controls.Add(this.button_Error_Message);
            this.panel_Main.Controls.Add(this.button_Counting_System);
            this.panel_Main.Controls.Add(this.button_Manual_Mode);
            this.panel_Main.Controls.Add(this.button_Speed_Setting);
            this.panel_Main.Location = new System.Drawing.Point(24, 12);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1148, 638);
            this.panel_Main.TabIndex = 26;
            this.panel_Main.Visible = false;
            // 
            // panel_Hide_Password_Function
            // 
            this.panel_Hide_Password_Function.Controls.Add(this.label_Hidden_Features_Password);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_Return);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_Delete);
            this.panel_Hide_Password_Function.Controls.Add(this.textBox_Hidden_Features_Password);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_9);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_6);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_3);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_8);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_5);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_2);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_7);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_4);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_Cancel);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_OK);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_0);
            this.panel_Hide_Password_Function.Controls.Add(this.button_Hidden_Features_1);
            this.panel_Hide_Password_Function.Location = new System.Drawing.Point(85, 16);
            this.panel_Hide_Password_Function.Name = "panel_Hide_Password_Function";
            this.panel_Hide_Password_Function.Size = new System.Drawing.Size(957, 606);
            this.panel_Hide_Password_Function.TabIndex = 35;
            this.panel_Hide_Password_Function.Visible = false;
            // 
            // label_Hidden_Features_Password
            // 
            this.label_Hidden_Features_Password.AutoSize = true;
            this.label_Hidden_Features_Password.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Password.Location = new System.Drawing.Point(191, 17);
            this.label_Hidden_Features_Password.Name = "label_Hidden_Features_Password";
            this.label_Hidden_Features_Password.Size = new System.Drawing.Size(404, 48);
            this.label_Hidden_Features_Password.TabIndex = 19;
            this.label_Hidden_Features_Password.Text = "輸入隱藏功能密碼";
            // 
            // button_Hidden_Features_Return
            // 
            this.button_Hidden_Features_Return.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Return.Location = new System.Drawing.Point(404, 436);
            this.button_Hidden_Features_Return.Name = "button_Hidden_Features_Return";
            this.button_Hidden_Features_Return.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_Return.TabIndex = 17;
            this.button_Hidden_Features_Return.Text = "退回";
            this.button_Hidden_Features_Return.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Return.Click += new System.EventHandler(this.button_Hidden_Features_Return_Click);
            // 
            // button_Hidden_Features_Delete
            // 
            this.button_Hidden_Features_Delete.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Delete.Location = new System.Drawing.Point(509, 189);
            this.button_Hidden_Features_Delete.Name = "button_Hidden_Features_Delete";
            this.button_Hidden_Features_Delete.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_Delete.TabIndex = 18;
            this.button_Hidden_Features_Delete.Text = "刪除";
            this.button_Hidden_Features_Delete.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Delete.Click += new System.EventHandler(this.button_Hidden_Features_Delete_Click);
            // 
            // textBox_Hidden_Features_Password
            // 
            this.textBox_Hidden_Features_Password.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Hidden_Features_Password.Location = new System.Drawing.Point(179, 75);
            this.textBox_Hidden_Features_Password.Name = "textBox_Hidden_Features_Password";
            this.textBox_Hidden_Features_Password.PasswordChar = '*';
            this.textBox_Hidden_Features_Password.Size = new System.Drawing.Size(333, 84);
            this.textBox_Hidden_Features_Password.TabIndex = 16;
            // 
            // button_Hidden_Features_9
            // 
            this.button_Hidden_Features_9.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_9.Location = new System.Drawing.Point(404, 353);
            this.button_Hidden_Features_9.Name = "button_Hidden_Features_9";
            this.button_Hidden_Features_9.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_9.TabIndex = 12;
            this.button_Hidden_Features_9.Text = "9";
            this.button_Hidden_Features_9.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_9.Click += new System.EventHandler(this.button_Hidden_Features_9_Click);
            // 
            // button_Hidden_Features_6
            // 
            this.button_Hidden_Features_6.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_6.Location = new System.Drawing.Point(404, 272);
            this.button_Hidden_Features_6.Name = "button_Hidden_Features_6";
            this.button_Hidden_Features_6.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_6.TabIndex = 15;
            this.button_Hidden_Features_6.Text = "6";
            this.button_Hidden_Features_6.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_6.Click += new System.EventHandler(this.button_Hidden_Features_6_Click);
            // 
            // button_Hidden_Features_3
            // 
            this.button_Hidden_Features_3.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_3.Location = new System.Drawing.Point(404, 189);
            this.button_Hidden_Features_3.Name = "button_Hidden_Features_3";
            this.button_Hidden_Features_3.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_3.TabIndex = 14;
            this.button_Hidden_Features_3.Text = "3";
            this.button_Hidden_Features_3.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_3.Click += new System.EventHandler(this.button_Hidden_Features_3_Click);
            // 
            // button_Hidden_Features_8
            // 
            this.button_Hidden_Features_8.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_8.Location = new System.Drawing.Point(301, 353);
            this.button_Hidden_Features_8.Name = "button_Hidden_Features_8";
            this.button_Hidden_Features_8.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_8.TabIndex = 13;
            this.button_Hidden_Features_8.Text = "8";
            this.button_Hidden_Features_8.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_8.Click += new System.EventHandler(this.button_Hidden_Features_8_Click);
            // 
            // button_Hidden_Features_5
            // 
            this.button_Hidden_Features_5.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_5.Location = new System.Drawing.Point(301, 272);
            this.button_Hidden_Features_5.Name = "button_Hidden_Features_5";
            this.button_Hidden_Features_5.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_5.TabIndex = 6;
            this.button_Hidden_Features_5.Text = "5";
            this.button_Hidden_Features_5.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_5.Click += new System.EventHandler(this.button_Hidden_Features_5_Click);
            // 
            // button_Hidden_Features_2
            // 
            this.button_Hidden_Features_2.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_2.Location = new System.Drawing.Point(301, 189);
            this.button_Hidden_Features_2.Name = "button_Hidden_Features_2";
            this.button_Hidden_Features_2.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_2.TabIndex = 5;
            this.button_Hidden_Features_2.Text = "2";
            this.button_Hidden_Features_2.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_2.Click += new System.EventHandler(this.button_Hidden_Features_2_Click);
            // 
            // button_Hidden_Features_7
            // 
            this.button_Hidden_Features_7.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_7.Location = new System.Drawing.Point(199, 353);
            this.button_Hidden_Features_7.Name = "button_Hidden_Features_7";
            this.button_Hidden_Features_7.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_7.TabIndex = 4;
            this.button_Hidden_Features_7.Text = "7";
            this.button_Hidden_Features_7.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_7.Click += new System.EventHandler(this.button_Hidden_Features_7_Click);
            // 
            // button_Hidden_Features_4
            // 
            this.button_Hidden_Features_4.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_4.Location = new System.Drawing.Point(199, 272);
            this.button_Hidden_Features_4.Name = "button_Hidden_Features_4";
            this.button_Hidden_Features_4.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_4.TabIndex = 7;
            this.button_Hidden_Features_4.Text = "4";
            this.button_Hidden_Features_4.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_4.Click += new System.EventHandler(this.button_Hidden_Features_4_Click);
            // 
            // button_Hidden_Features_Cancel
            // 
            this.button_Hidden_Features_Cancel.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Cancel.Location = new System.Drawing.Point(634, 312);
            this.button_Hidden_Features_Cancel.Name = "button_Hidden_Features_Cancel";
            this.button_Hidden_Features_Cancel.Size = new System.Drawing.Size(125, 79);
            this.button_Hidden_Features_Cancel.TabIndex = 10;
            this.button_Hidden_Features_Cancel.Text = "取消";
            this.button_Hidden_Features_Cancel.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Cancel.Click += new System.EventHandler(this.button_Hidden_Features_Cancel_Click);
            // 
            // button_Hidden_Features_OK
            // 
            this.button_Hidden_Features_OK.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_OK.Location = new System.Drawing.Point(634, 189);
            this.button_Hidden_Features_OK.Name = "button_Hidden_Features_OK";
            this.button_Hidden_Features_OK.Size = new System.Drawing.Size(125, 79);
            this.button_Hidden_Features_OK.TabIndex = 9;
            this.button_Hidden_Features_OK.Text = "確定";
            this.button_Hidden_Features_OK.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_OK.Click += new System.EventHandler(this.button_Hidden_Features_OK_Click);
            // 
            // button_Hidden_Features_0
            // 
            this.button_Hidden_Features_0.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_0.Location = new System.Drawing.Point(301, 436);
            this.button_Hidden_Features_0.Name = "button_Hidden_Features_0";
            this.button_Hidden_Features_0.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_0.TabIndex = 8;
            this.button_Hidden_Features_0.Text = "0";
            this.button_Hidden_Features_0.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_0.Click += new System.EventHandler(this.button_Hidden_Features_0_Click);
            // 
            // button_Hidden_Features_1
            // 
            this.button_Hidden_Features_1.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_1.Location = new System.Drawing.Point(199, 189);
            this.button_Hidden_Features_1.Name = "button_Hidden_Features_1";
            this.button_Hidden_Features_1.Size = new System.Drawing.Size(82, 72);
            this.button_Hidden_Features_1.TabIndex = 11;
            this.button_Hidden_Features_1.Text = "1";
            this.button_Hidden_Features_1.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_1.Click += new System.EventHandler(this.button_Hidden_Features_1_Click);
            // 
            // pictureBox_Boltun_Main
            // 
            this.pictureBox_Boltun_Main.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Boltun_Main.Image")));
            this.pictureBox_Boltun_Main.Location = new System.Drawing.Point(115, 17);
            this.pictureBox_Boltun_Main.Name = "pictureBox_Boltun_Main";
            this.pictureBox_Boltun_Main.Size = new System.Drawing.Size(919, 264);
            this.pictureBox_Boltun_Main.TabIndex = 34;
            this.pictureBox_Boltun_Main.TabStop = false;
            this.pictureBox_Boltun_Main.DoubleClick += new System.EventHandler(this.pictureBox_Boltun_Main_DoubleClick);
            this.pictureBox_Boltun_Main.Click += new System.EventHandler(this.pictureBox_Boltun_Main_Click);
            // 
            // button_Analog_Operation
            // 
            this.button_Analog_Operation.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Analog_Operation.Location = new System.Drawing.Point(827, 470);
            this.button_Analog_Operation.Name = "button_Analog_Operation";
            this.button_Analog_Operation.Size = new System.Drawing.Size(180, 152);
            this.button_Analog_Operation.TabIndex = 18;
            this.button_Analog_Operation.Text = "運轉模擬";
            this.button_Analog_Operation.UseVisualStyleBackColor = true;
            this.button_Analog_Operation.Click += new System.EventHandler(this.button_Analog_Operation_Click);
            // 
            // button_Machine_Stop
            // 
            this.button_Machine_Stop.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Machine_Stop.Location = new System.Drawing.Point(827, 300);
            this.button_Machine_Stop.Name = "button_Machine_Stop";
            this.button_Machine_Stop.Size = new System.Drawing.Size(180, 152);
            this.button_Machine_Stop.TabIndex = 18;
            this.button_Machine_Stop.Text = "機台停止";
            this.button_Machine_Stop.UseVisualStyleBackColor = true;
            this.button_Machine_Stop.Click += new System.EventHandler(this.button_Machine_Stop_Click);
            // 
            // button_Input_Output_List
            // 
            this.button_Input_Output_List.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Input_Output_List.Location = new System.Drawing.Point(594, 470);
            this.button_Input_Output_List.Name = "button_Input_Output_List";
            this.button_Input_Output_List.Size = new System.Drawing.Size(180, 152);
            this.button_Input_Output_List.TabIndex = 18;
            this.button_Input_Output_List.Text = "I/O列表";
            this.button_Input_Output_List.UseVisualStyleBackColor = true;
            this.button_Input_Output_List.Click += new System.EventHandler(this.button_Input_Output_List_Click);
            // 
            // button_Machine_Start
            // 
            this.button_Machine_Start.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Machine_Start.Location = new System.Drawing.Point(594, 300);
            this.button_Machine_Start.Name = "button_Machine_Start";
            this.button_Machine_Start.Size = new System.Drawing.Size(180, 152);
            this.button_Machine_Start.TabIndex = 18;
            this.button_Machine_Start.Text = "機台啟動";
            this.button_Machine_Start.UseVisualStyleBackColor = true;
            this.button_Machine_Start.Click += new System.EventHandler(this.button_Machine_Start_Click);
            // 
            // button_Error_Message
            // 
            this.button_Error_Message.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Error_Message.Location = new System.Drawing.Point(363, 470);
            this.button_Error_Message.Name = "button_Error_Message";
            this.button_Error_Message.Size = new System.Drawing.Size(180, 152);
            this.button_Error_Message.TabIndex = 18;
            this.button_Error_Message.Text = "錯誤訊息";
            this.button_Error_Message.UseVisualStyleBackColor = true;
            this.button_Error_Message.Click += new System.EventHandler(this.button_Error_Message_Click);
            // 
            // button_Counting_System
            // 
            this.button_Counting_System.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Counting_System.Location = new System.Drawing.Point(363, 300);
            this.button_Counting_System.Name = "button_Counting_System";
            this.button_Counting_System.Size = new System.Drawing.Size(180, 152);
            this.button_Counting_System.TabIndex = 18;
            this.button_Counting_System.Text = "系統計數";
            this.button_Counting_System.UseVisualStyleBackColor = true;
            this.button_Counting_System.Click += new System.EventHandler(this.button_Counting_System_Click);
            // 
            // button_Manual_Mode
            // 
            this.button_Manual_Mode.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Manual_Mode.Location = new System.Drawing.Point(131, 470);
            this.button_Manual_Mode.Name = "button_Manual_Mode";
            this.button_Manual_Mode.Size = new System.Drawing.Size(180, 152);
            this.button_Manual_Mode.TabIndex = 18;
            this.button_Manual_Mode.Text = "手動模式";
            this.button_Manual_Mode.UseVisualStyleBackColor = true;
            this.button_Manual_Mode.Click += new System.EventHandler(this.button_Manual_Mode_Click);
            // 
            // button_Speed_Setting
            // 
            this.button_Speed_Setting.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Speed_Setting.Location = new System.Drawing.Point(131, 300);
            this.button_Speed_Setting.Name = "button_Speed_Setting";
            this.button_Speed_Setting.Size = new System.Drawing.Size(180, 152);
            this.button_Speed_Setting.TabIndex = 18;
            this.button_Speed_Setting.Text = "速度設定";
            this.button_Speed_Setting.UseVisualStyleBackColor = true;
            this.button_Speed_Setting.Click += new System.EventHandler(this.button_Speed_Setting_Click);
            // 
            // panel_WorkingSpeed
            // 
            this.panel_WorkingSpeed.Controls.Add(this.panel_Counting_System);
            this.panel_WorkingSpeed.Controls.Add(this.panel_WorkingSpeedSetting);
            this.panel_WorkingSpeed.Controls.Add(this.buttonBackToMainScreen_WorkingSpeed);
            this.panel_WorkingSpeed.Controls.Add(this.button_Count_OR_Speed);
            this.panel_WorkingSpeed.Location = new System.Drawing.Point(24, 12);
            this.panel_WorkingSpeed.Name = "panel_WorkingSpeed";
            this.panel_WorkingSpeed.Size = new System.Drawing.Size(1148, 638);
            this.panel_WorkingSpeed.TabIndex = 27;
            this.panel_WorkingSpeed.Visible = false;
            // 
            // panel_Counting_System
            // 
            this.panel_Counting_System.Controls.Add(this.textBox_Stroke_Rate);
            this.panel_Counting_System.Controls.Add(this.textBox_Total_Number_Actions);
            this.panel_Counting_System.Controls.Add(this.label_Stroke_Rate);
            this.panel_Counting_System.Controls.Add(this.label_Stroke_Rate_Count);
            this.panel_Counting_System.Controls.Add(this.label_Total_Number_Actions_Count);
            this.panel_Counting_System.Controls.Add(this.label_Total_Number_Actions);
            this.panel_Counting_System.Controls.Add(this.label_Counting_System);
            this.panel_Counting_System.Location = new System.Drawing.Point(37, 14);
            this.panel_Counting_System.Name = "panel_Counting_System";
            this.panel_Counting_System.Size = new System.Drawing.Size(957, 532);
            this.panel_Counting_System.TabIndex = 10;
            this.panel_Counting_System.Visible = false;
            // 
            // textBox_Stroke_Rate
            // 
            this.textBox_Stroke_Rate.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Stroke_Rate.Location = new System.Drawing.Point(276, 251);
            this.textBox_Stroke_Rate.Name = "textBox_Stroke_Rate";
            this.textBox_Stroke_Rate.Size = new System.Drawing.Size(224, 52);
            this.textBox_Stroke_Rate.TabIndex = 11;
            // 
            // textBox_Total_Number_Actions
            // 
            this.textBox_Total_Number_Actions.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Total_Number_Actions.Location = new System.Drawing.Point(276, 147);
            this.textBox_Total_Number_Actions.Name = "textBox_Total_Number_Actions";
            this.textBox_Total_Number_Actions.Size = new System.Drawing.Size(223, 52);
            this.textBox_Total_Number_Actions.TabIndex = 10;
            // 
            // label_Stroke_Rate
            // 
            this.label_Stroke_Rate.AutoSize = true;
            this.label_Stroke_Rate.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Stroke_Rate.Location = new System.Drawing.Point(80, 252);
            this.label_Stroke_Rate.Name = "label_Stroke_Rate";
            this.label_Stroke_Rate.Size = new System.Drawing.Size(202, 37);
            this.label_Stroke_Rate.TabIndex = 9;
            this.label_Stroke_Rate.Text = "動作速率：";
            // 
            // label_Stroke_Rate_Count
            // 
            this.label_Stroke_Rate_Count.AutoSize = true;
            this.label_Stroke_Rate_Count.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Stroke_Rate_Count.Location = new System.Drawing.Point(514, 262);
            this.label_Stroke_Rate_Count.Name = "label_Stroke_Rate_Count";
            this.label_Stroke_Rate_Count.Size = new System.Drawing.Size(54, 37);
            this.label_Stroke_Rate_Count.TabIndex = 8;
            this.label_Stroke_Rate_Count.Text = "次";
            // 
            // label_Total_Number_Actions_Count
            // 
            this.label_Total_Number_Actions_Count.AutoSize = true;
            this.label_Total_Number_Actions_Count.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Total_Number_Actions_Count.Location = new System.Drawing.Point(512, 150);
            this.label_Total_Number_Actions_Count.Name = "label_Total_Number_Actions_Count";
            this.label_Total_Number_Actions_Count.Size = new System.Drawing.Size(54, 37);
            this.label_Total_Number_Actions_Count.TabIndex = 8;
            this.label_Total_Number_Actions_Count.Text = "次";
            // 
            // label_Total_Number_Actions
            // 
            this.label_Total_Number_Actions.AutoSize = true;
            this.label_Total_Number_Actions.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Total_Number_Actions.Location = new System.Drawing.Point(80, 150);
            this.label_Total_Number_Actions.Name = "label_Total_Number_Actions";
            this.label_Total_Number_Actions.Size = new System.Drawing.Size(202, 37);
            this.label_Total_Number_Actions.TabIndex = 8;
            this.label_Total_Number_Actions.Text = "總動作數：";
            this.label_Total_Number_Actions.DoubleClick += new System.EventHandler(this.label_Total_Number_Actions_DoubleClick);
            // 
            // label_Counting_System
            // 
            this.label_Counting_System.AutoSize = true;
            this.label_Counting_System.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Counting_System.Location = new System.Drawing.Point(322, 12);
            this.label_Counting_System.Name = "label_Counting_System";
            this.label_Counting_System.Size = new System.Drawing.Size(212, 48);
            this.label_Counting_System.TabIndex = 6;
            this.label_Counting_System.Text = "系統計數";
            // 
            // panel_WorkingSpeedSetting
            // 
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_Modify);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_Delete);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_0);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_9);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_6);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_3);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_8);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_5);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_2);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_7);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_4);
            this.panel_WorkingSpeedSetting.Controls.Add(this.btn_WorkingSpeedSetting_1);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_FullMaterial_Sensor);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_Nomaterial_Sensor);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_Screw_Down_Dead);
            this.panel_WorkingSpeedSetting.Controls.Add(this.button_Write_Speed_Value);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_Discharge_Sensor);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_Screw_Up_Dead);
            this.panel_WorkingSpeedSetting.Controls.Add(this.checkBox_Positioning_Completed1);
            this.panel_WorkingSpeedSetting.Controls.Add(this.textBox_SpeedSetting);
            this.panel_WorkingSpeedSetting.Controls.Add(this.textBox_CurrentSpeed);
            this.panel_WorkingSpeedSetting.Controls.Add(this.label_Speed_Setting);
            this.panel_WorkingSpeedSetting.Controls.Add(this.label_SpeedSetting);
            this.panel_WorkingSpeedSetting.Controls.Add(this.label_CurrentSpeed);
            this.panel_WorkingSpeedSetting.Location = new System.Drawing.Point(37, 14);
            this.panel_WorkingSpeedSetting.Name = "panel_WorkingSpeedSetting";
            this.panel_WorkingSpeedSetting.Size = new System.Drawing.Size(957, 532);
            this.panel_WorkingSpeedSetting.TabIndex = 9;
            // 
            // btn_WorkingSpeedSetting_Modify
            // 
            this.btn_WorkingSpeedSetting_Modify.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_Modify.Location = new System.Drawing.Point(731, 434);
            this.btn_WorkingSpeedSetting_Modify.Name = "btn_WorkingSpeedSetting_Modify";
            this.btn_WorkingSpeedSetting_Modify.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_Modify.TabIndex = 30;
            this.btn_WorkingSpeedSetting_Modify.Text = "修改";
            this.btn_WorkingSpeedSetting_Modify.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_Modify.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_Modify_Click);
            // 
            // btn_WorkingSpeedSetting_Delete
            // 
            this.btn_WorkingSpeedSetting_Delete.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_Delete.Location = new System.Drawing.Point(845, 162);
            this.btn_WorkingSpeedSetting_Delete.Name = "btn_WorkingSpeedSetting_Delete";
            this.btn_WorkingSpeedSetting_Delete.Size = new System.Drawing.Size(103, 80);
            this.btn_WorkingSpeedSetting_Delete.TabIndex = 31;
            this.btn_WorkingSpeedSetting_Delete.Text = "刪除";
            this.btn_WorkingSpeedSetting_Delete.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_Delete.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_Delete_Click);
            // 
            // btn_WorkingSpeedSetting_0
            // 
            this.btn_WorkingSpeedSetting_0.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_0.Location = new System.Drawing.Point(614, 434);
            this.btn_WorkingSpeedSetting_0.Name = "btn_WorkingSpeedSetting_0";
            this.btn_WorkingSpeedSetting_0.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_0.TabIndex = 26;
            this.btn_WorkingSpeedSetting_0.Text = "0";
            this.btn_WorkingSpeedSetting_0.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_0.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_0_Click);
            // 
            // btn_WorkingSpeedSetting_9
            // 
            this.btn_WorkingSpeedSetting_9.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_9.Location = new System.Drawing.Point(731, 342);
            this.btn_WorkingSpeedSetting_9.Name = "btn_WorkingSpeedSetting_9";
            this.btn_WorkingSpeedSetting_9.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_9.TabIndex = 29;
            this.btn_WorkingSpeedSetting_9.Text = "9";
            this.btn_WorkingSpeedSetting_9.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_9.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_9_Click);
            // 
            // btn_WorkingSpeedSetting_6
            // 
            this.btn_WorkingSpeedSetting_6.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_6.Location = new System.Drawing.Point(731, 253);
            this.btn_WorkingSpeedSetting_6.Name = "btn_WorkingSpeedSetting_6";
            this.btn_WorkingSpeedSetting_6.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_6.TabIndex = 28;
            this.btn_WorkingSpeedSetting_6.Text = "6";
            this.btn_WorkingSpeedSetting_6.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_6.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_6_Click);
            // 
            // btn_WorkingSpeedSetting_3
            // 
            this.btn_WorkingSpeedSetting_3.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_3.Location = new System.Drawing.Point(731, 162);
            this.btn_WorkingSpeedSetting_3.Name = "btn_WorkingSpeedSetting_3";
            this.btn_WorkingSpeedSetting_3.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_3.TabIndex = 27;
            this.btn_WorkingSpeedSetting_3.Text = "3";
            this.btn_WorkingSpeedSetting_3.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_3.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_3_Click);
            // 
            // btn_WorkingSpeedSetting_8
            // 
            this.btn_WorkingSpeedSetting_8.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_8.Location = new System.Drawing.Point(614, 342);
            this.btn_WorkingSpeedSetting_8.Name = "btn_WorkingSpeedSetting_8";
            this.btn_WorkingSpeedSetting_8.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_8.TabIndex = 21;
            this.btn_WorkingSpeedSetting_8.Text = "8";
            this.btn_WorkingSpeedSetting_8.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_8.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_8_Click);
            // 
            // btn_WorkingSpeedSetting_5
            // 
            this.btn_WorkingSpeedSetting_5.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_5.Location = new System.Drawing.Point(614, 253);
            this.btn_WorkingSpeedSetting_5.Name = "btn_WorkingSpeedSetting_5";
            this.btn_WorkingSpeedSetting_5.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_5.TabIndex = 20;
            this.btn_WorkingSpeedSetting_5.Text = "5";
            this.btn_WorkingSpeedSetting_5.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_5.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_5_Click);
            // 
            // btn_WorkingSpeedSetting_2
            // 
            this.btn_WorkingSpeedSetting_2.Font = new System.Drawing.Font("PMingLiU", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_WorkingSpeedSetting_2.Location = new System.Drawing.Point(614, 162);
            this.btn_WorkingSpeedSetting_2.Name = "btn_WorkingSpeedSetting_2";
            this.btn_WorkingSpeedSetting_2.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_2.TabIndex = 22;
            this.btn_WorkingSpeedSetting_2.Text = "2";
            this.btn_WorkingSpeedSetting_2.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_2.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_2_Click);
            // 
            // btn_WorkingSpeedSetting_7
            // 
            this.btn_WorkingSpeedSetting_7.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_7.Location = new System.Drawing.Point(496, 342);
            this.btn_WorkingSpeedSetting_7.Name = "btn_WorkingSpeedSetting_7";
            this.btn_WorkingSpeedSetting_7.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_7.TabIndex = 24;
            this.btn_WorkingSpeedSetting_7.Text = "7";
            this.btn_WorkingSpeedSetting_7.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_7.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_7_Click);
            // 
            // btn_WorkingSpeedSetting_4
            // 
            this.btn_WorkingSpeedSetting_4.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.btn_WorkingSpeedSetting_4.Location = new System.Drawing.Point(496, 253);
            this.btn_WorkingSpeedSetting_4.Name = "btn_WorkingSpeedSetting_4";
            this.btn_WorkingSpeedSetting_4.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_4.TabIndex = 23;
            this.btn_WorkingSpeedSetting_4.Text = "4";
            this.btn_WorkingSpeedSetting_4.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_4.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_4_Click);
            // 
            // btn_WorkingSpeedSetting_1
            // 
            this.btn_WorkingSpeedSetting_1.Font = new System.Drawing.Font("PMingLiU", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_WorkingSpeedSetting_1.Location = new System.Drawing.Point(496, 162);
            this.btn_WorkingSpeedSetting_1.Name = "btn_WorkingSpeedSetting_1";
            this.btn_WorkingSpeedSetting_1.Size = new System.Drawing.Size(105, 80);
            this.btn_WorkingSpeedSetting_1.TabIndex = 25;
            this.btn_WorkingSpeedSetting_1.Text = "1";
            this.btn_WorkingSpeedSetting_1.UseVisualStyleBackColor = true;
            this.btn_WorkingSpeedSetting_1.Click += new System.EventHandler(this.btn_WorkingSpeedSetting_1_Click);
            // 
            // checkBox_FullMaterial_Sensor
            // 
            this.checkBox_FullMaterial_Sensor.AutoCheck = false;
            this.checkBox_FullMaterial_Sensor.AutoSize = true;
            this.checkBox_FullMaterial_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_FullMaterial_Sensor.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_FullMaterial_Sensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_FullMaterial_Sensor.Location = new System.Drawing.Point(820, 78);
            this.checkBox_FullMaterial_Sensor.Name = "checkBox_FullMaterial_Sensor";
            this.checkBox_FullMaterial_Sensor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_FullMaterial_Sensor.Size = new System.Drawing.Size(123, 24);
            this.checkBox_FullMaterial_Sensor.TabIndex = 19;
            this.checkBox_FullMaterial_Sensor.Text = "滿料 sensor";
            this.checkBox_FullMaterial_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Nomaterial_Sensor
            // 
            this.checkBox_Nomaterial_Sensor.AutoCheck = false;
            this.checkBox_Nomaterial_Sensor.AutoSize = true;
            this.checkBox_Nomaterial_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Nomaterial_Sensor.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Nomaterial_Sensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Nomaterial_Sensor.Location = new System.Drawing.Point(672, 78);
            this.checkBox_Nomaterial_Sensor.Name = "checkBox_Nomaterial_Sensor";
            this.checkBox_Nomaterial_Sensor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Nomaterial_Sensor.Size = new System.Drawing.Size(123, 24);
            this.checkBox_Nomaterial_Sensor.TabIndex = 19;
            this.checkBox_Nomaterial_Sensor.Text = "無料 sensor";
            this.checkBox_Nomaterial_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Screw_Down_Dead
            // 
            this.checkBox_Screw_Down_Dead.AutoCheck = false;
            this.checkBox_Screw_Down_Dead.AutoSize = true;
            this.checkBox_Screw_Down_Dead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Down_Dead.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Down_Dead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Screw_Down_Dead.Location = new System.Drawing.Point(196, 78);
            this.checkBox_Screw_Down_Dead.Name = "checkBox_Screw_Down_Dead";
            this.checkBox_Screw_Down_Dead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Screw_Down_Dead.Size = new System.Drawing.Size(134, 24);
            this.checkBox_Screw_Down_Dead.TabIndex = 19;
            this.checkBox_Screw_Down_Dead.Text = "螺桿 下死點";
            this.checkBox_Screw_Down_Dead.UseVisualStyleBackColor = true;
            // 
            // button_Write_Speed_Value
            // 
            this.button_Write_Speed_Value.Font = new System.Drawing.Font("PMingLiU", 26.25F);
            this.button_Write_Speed_Value.Location = new System.Drawing.Point(140, 359);
            this.button_Write_Speed_Value.Name = "button_Write_Speed_Value";
            this.button_Write_Speed_Value.Size = new System.Drawing.Size(235, 75);
            this.button_Write_Speed_Value.TabIndex = 7;
            this.button_Write_Speed_Value.Text = "速度值寫入";
            this.button_Write_Speed_Value.UseVisualStyleBackColor = true;
            this.button_Write_Speed_Value.Click += new System.EventHandler(this.button_Write_Speed_Value_Click);
            this.button_Write_Speed_Value.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Write_Speed_Value_MouseDown);
            this.button_Write_Speed_Value.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Write_Speed_Value_MouseUp);
            // 
            // checkBox_Discharge_Sensor
            // 
            this.checkBox_Discharge_Sensor.AutoCheck = false;
            this.checkBox_Discharge_Sensor.AutoSize = true;
            this.checkBox_Discharge_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Discharge_Sensor.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Discharge_Sensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Discharge_Sensor.Location = new System.Drawing.Point(521, 78);
            this.checkBox_Discharge_Sensor.Name = "checkBox_Discharge_Sensor";
            this.checkBox_Discharge_Sensor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Discharge_Sensor.Size = new System.Drawing.Size(123, 24);
            this.checkBox_Discharge_Sensor.TabIndex = 19;
            this.checkBox_Discharge_Sensor.Text = "出料 sensor";
            this.checkBox_Discharge_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Screw_Up_Dead
            // 
            this.checkBox_Screw_Up_Dead.AutoCheck = false;
            this.checkBox_Screw_Up_Dead.AutoSize = true;
            this.checkBox_Screw_Up_Dead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Up_Dead.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Up_Dead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Screw_Up_Dead.Location = new System.Drawing.Point(35, 78);
            this.checkBox_Screw_Up_Dead.Name = "checkBox_Screw_Up_Dead";
            this.checkBox_Screw_Up_Dead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Screw_Up_Dead.Size = new System.Drawing.Size(134, 24);
            this.checkBox_Screw_Up_Dead.TabIndex = 19;
            this.checkBox_Screw_Up_Dead.Text = "螺桿 上死點";
            this.checkBox_Screw_Up_Dead.UseVisualStyleBackColor = true;
            // 
            // checkBox_Positioning_Completed1
            // 
            this.checkBox_Positioning_Completed1.AutoCheck = false;
            this.checkBox_Positioning_Completed1.AutoSize = true;
            this.checkBox_Positioning_Completed1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Positioning_Completed1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Positioning_Completed1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Positioning_Completed1.Location = new System.Drawing.Point(364, 78);
            this.checkBox_Positioning_Completed1.Name = "checkBox_Positioning_Completed1";
            this.checkBox_Positioning_Completed1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Positioning_Completed1.Size = new System.Drawing.Size(115, 24);
            this.checkBox_Positioning_Completed1.TabIndex = 19;
            this.checkBox_Positioning_Completed1.Text = "定位 完成";
            this.checkBox_Positioning_Completed1.UseVisualStyleBackColor = true;
            // 
            // textBox_SpeedSetting
            // 
            this.textBox_SpeedSetting.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_SpeedSetting.Location = new System.Drawing.Point(250, 222);
            this.textBox_SpeedSetting.Name = "textBox_SpeedSetting";
            this.textBox_SpeedSetting.Size = new System.Drawing.Size(224, 52);
            this.textBox_SpeedSetting.TabIndex = 7;
            // 
            // textBox_CurrentSpeed
            // 
            this.textBox_CurrentSpeed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_CurrentSpeed.Location = new System.Drawing.Point(251, 143);
            this.textBox_CurrentSpeed.Name = "textBox_CurrentSpeed";
            this.textBox_CurrentSpeed.Size = new System.Drawing.Size(223, 52);
            this.textBox_CurrentSpeed.TabIndex = 6;
            // 
            // label_Speed_Setting
            // 
            this.label_Speed_Setting.AutoSize = true;
            this.label_Speed_Setting.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Speed_Setting.Location = new System.Drawing.Point(322, 12);
            this.label_Speed_Setting.Name = "label_Speed_Setting";
            this.label_Speed_Setting.Size = new System.Drawing.Size(212, 48);
            this.label_Speed_Setting.TabIndex = 5;
            this.label_Speed_Setting.Text = "速度設定";
            // 
            // label_SpeedSetting
            // 
            this.label_SpeedSetting.AutoSize = true;
            this.label_SpeedSetting.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_SpeedSetting.Location = new System.Drawing.Point(16, 227);
            this.label_SpeedSetting.Name = "label_SpeedSetting";
            this.label_SpeedSetting.Size = new System.Drawing.Size(239, 37);
            this.label_SpeedSetting.TabIndex = 5;
            this.label_SpeedSetting.Text = "速度值更改：";
            // 
            // label_CurrentSpeed
            // 
            this.label_CurrentSpeed.AutoSize = true;
            this.label_CurrentSpeed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_CurrentSpeed.Location = new System.Drawing.Point(16, 152);
            this.label_CurrentSpeed.Name = "label_CurrentSpeed";
            this.label_CurrentSpeed.Size = new System.Drawing.Size(239, 37);
            this.label_CurrentSpeed.TabIndex = 4;
            this.label_CurrentSpeed.Text = "當前速度值：";
            // 
            // buttonBackToMainScreen_WorkingSpeed
            // 
            this.buttonBackToMainScreen_WorkingSpeed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBackToMainScreen_WorkingSpeed.Location = new System.Drawing.Point(280, 568);
            this.buttonBackToMainScreen_WorkingSpeed.Name = "buttonBackToMainScreen_WorkingSpeed";
            this.buttonBackToMainScreen_WorkingSpeed.Size = new System.Drawing.Size(226, 58);
            this.buttonBackToMainScreen_WorkingSpeed.TabIndex = 8;
            this.buttonBackToMainScreen_WorkingSpeed.Text = "回主畫面";
            this.buttonBackToMainScreen_WorkingSpeed.UseVisualStyleBackColor = true;
            this.buttonBackToMainScreen_WorkingSpeed.Click += new System.EventHandler(this.buttonBackToMainScreen_WorkingSpeed_Click);
            // 
            // button_Count_OR_Speed
            // 
            this.button_Count_OR_Speed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Count_OR_Speed.Location = new System.Drawing.Point(569, 568);
            this.button_Count_OR_Speed.Name = "button_Count_OR_Speed";
            this.button_Count_OR_Speed.Size = new System.Drawing.Size(226, 58);
            this.button_Count_OR_Speed.TabIndex = 7;
            this.button_Count_OR_Speed.Text = "系統計數";
            this.button_Count_OR_Speed.UseVisualStyleBackColor = true;
            this.button_Count_OR_Speed.Click += new System.EventHandler(this.button_Count_OR_Speed_Click);
            // 
            // panel_Manual_Mode
            // 
            this.panel_Manual_Mode.Controls.Add(this.panel_OPR);
            this.panel_Manual_Mode.Controls.Add(this.panel_Close_Electronic_Handwheel3);
            this.panel_Manual_Mode.Controls.Add(this.panel_Close_Electronic_Handwheel2);
            this.panel_Manual_Mode.Controls.Add(this.panel_Close_Electronic_Handwheel1);
            this.panel_Manual_Mode.Controls.Add(this.button_Main_Manual_Mode);
            this.panel_Manual_Mode.Controls.Add(this.button_A_Loop);
            this.panel_Manual_Mode.Controls.Add(this.button_JOG);
            this.panel_Manual_Mode.Controls.Add(this.button_Continuous_Action);
            this.panel_Manual_Mode.Controls.Add(this.button_OPR_Run);
            this.panel_Manual_Mode.Controls.Add(this.button_Tool_Rotation_Run);
            this.panel_Manual_Mode.Controls.Add(this.button_Calibration_Screw);
            this.panel_Manual_Mode.Controls.Add(this.button_Tool_Containing_A_Loop);
            this.panel_Manual_Mode.Controls.Add(this.button_Motor_Start_Run);
            this.panel_Manual_Mode.Controls.Add(this.button_Calibration_Fixture);
            this.panel_Manual_Mode.Controls.Add(this.button_Empty_Disk);
            this.panel_Manual_Mode.Controls.Add(this.button_Turn_Handwheel);
            this.panel_Manual_Mode.Controls.Add(this.button_Turn_Vibration_Plate);
            this.panel_Manual_Mode.Controls.Add(this.button_Turntable_Correction);
            this.panel_Manual_Mode.Controls.Add(this.button_Manual_Mode_Run);
            this.panel_Manual_Mode.Location = new System.Drawing.Point(24, 12);
            this.panel_Manual_Mode.Name = "panel_Manual_Mode";
            this.panel_Manual_Mode.Size = new System.Drawing.Size(1148, 638);
            this.panel_Manual_Mode.TabIndex = 28;
            this.panel_Manual_Mode.Visible = false;
            // 
            // panel_OPR
            // 
            this.panel_OPR.Controls.Add(this.button_OPR_Cancel);
            this.panel_OPR.Controls.Add(this.button_OPR_Confirmation);
            this.panel_OPR.Controls.Add(this.label_OPR);
            this.panel_OPR.Location = new System.Drawing.Point(19, 16);
            this.panel_OPR.Name = "panel_OPR";
            this.panel_OPR.Size = new System.Drawing.Size(1063, 597);
            this.panel_OPR.TabIndex = 0;
            this.panel_OPR.Visible = false;
            // 
            // button_OPR_Cancel
            // 
            this.button_OPR_Cancel.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OPR_Cancel.Location = new System.Drawing.Point(502, 291);
            this.button_OPR_Cancel.Name = "button_OPR_Cancel";
            this.button_OPR_Cancel.Size = new System.Drawing.Size(119, 73);
            this.button_OPR_Cancel.TabIndex = 28;
            this.button_OPR_Cancel.Text = "否";
            this.button_OPR_Cancel.UseVisualStyleBackColor = true;
            this.button_OPR_Cancel.Click += new System.EventHandler(this.button_OPR_Cancel_Click);
            // 
            // button_OPR_Confirmation
            // 
            this.button_OPR_Confirmation.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OPR_Confirmation.Location = new System.Drawing.Point(262, 291);
            this.button_OPR_Confirmation.Name = "button_OPR_Confirmation";
            this.button_OPR_Confirmation.Size = new System.Drawing.Size(119, 73);
            this.button_OPR_Confirmation.TabIndex = 28;
            this.button_OPR_Confirmation.Text = "是";
            this.button_OPR_Confirmation.UseVisualStyleBackColor = true;
            this.button_OPR_Confirmation.Click += new System.EventHandler(this.button_OPR_Confirmation_Click);
            // 
            // label_OPR
            // 
            this.label_OPR.AutoSize = true;
            this.label_OPR.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OPR.Location = new System.Drawing.Point(184, 135);
            this.label_OPR.Name = "label_OPR";
            this.label_OPR.Size = new System.Drawing.Size(540, 64);
            this.label_OPR.TabIndex = 27;
            this.label_OPR.Text = "是否進行原點復歸";
            // 
            // panel_Close_Electronic_Handwheel3
            // 
            this.panel_Close_Electronic_Handwheel3.Location = new System.Drawing.Point(778, 14);
            this.panel_Close_Electronic_Handwheel3.Name = "panel_Close_Electronic_Handwheel3";
            this.panel_Close_Electronic_Handwheel3.Size = new System.Drawing.Size(322, 599);
            this.panel_Close_Electronic_Handwheel3.TabIndex = 28;
            this.panel_Close_Electronic_Handwheel3.Visible = false;
            // 
            // panel_Close_Electronic_Handwheel2
            // 
            this.panel_Close_Electronic_Handwheel2.Location = new System.Drawing.Point(18, 16);
            this.panel_Close_Electronic_Handwheel2.Name = "panel_Close_Electronic_Handwheel2";
            this.panel_Close_Electronic_Handwheel2.Size = new System.Drawing.Size(738, 152);
            this.panel_Close_Electronic_Handwheel2.TabIndex = 27;
            this.panel_Close_Electronic_Handwheel2.Visible = false;
            // 
            // panel_Close_Electronic_Handwheel1
            // 
            this.panel_Close_Electronic_Handwheel1.Controls.Add(this.button_Close_Cancel_Handwheel);
            this.panel_Close_Electronic_Handwheel1.Controls.Add(this.button_Close_Electronic_Handwheel);
            this.panel_Close_Electronic_Handwheel1.Controls.Add(this.label_Close_Electronic_Handwheel);
            this.panel_Close_Electronic_Handwheel1.Location = new System.Drawing.Point(18, 306);
            this.panel_Close_Electronic_Handwheel1.Name = "panel_Close_Electronic_Handwheel1";
            this.panel_Close_Electronic_Handwheel1.Size = new System.Drawing.Size(738, 304);
            this.panel_Close_Electronic_Handwheel1.TabIndex = 1;
            this.panel_Close_Electronic_Handwheel1.Visible = false;
            // 
            // button_Close_Cancel_Handwheel
            // 
            this.button_Close_Cancel_Handwheel.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Close_Cancel_Handwheel.Location = new System.Drawing.Point(390, 123);
            this.button_Close_Cancel_Handwheel.Name = "button_Close_Cancel_Handwheel";
            this.button_Close_Cancel_Handwheel.Size = new System.Drawing.Size(117, 50);
            this.button_Close_Cancel_Handwheel.TabIndex = 26;
            this.button_Close_Cancel_Handwheel.Text = "取消";
            this.button_Close_Cancel_Handwheel.UseVisualStyleBackColor = true;
            this.button_Close_Cancel_Handwheel.Click += new System.EventHandler(this.button_Close_Cancel_Handwheel_Click);
            // 
            // button_Close_Electronic_Handwheel
            // 
            this.button_Close_Electronic_Handwheel.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Close_Electronic_Handwheel.Location = new System.Drawing.Point(215, 125);
            this.button_Close_Electronic_Handwheel.Name = "button_Close_Electronic_Handwheel";
            this.button_Close_Electronic_Handwheel.Size = new System.Drawing.Size(117, 50);
            this.button_Close_Electronic_Handwheel.TabIndex = 26;
            this.button_Close_Electronic_Handwheel.Text = "確定";
            this.button_Close_Electronic_Handwheel.UseVisualStyleBackColor = true;
            this.button_Close_Electronic_Handwheel.Click += new System.EventHandler(this.button_Close_Electronic_Handwheel_Click);
            // 
            // label_Close_Electronic_Handwheel
            // 
            this.label_Close_Electronic_Handwheel.AutoSize = true;
            this.label_Close_Electronic_Handwheel.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Close_Electronic_Handwheel.Location = new System.Drawing.Point(178, 24);
            this.label_Close_Electronic_Handwheel.Name = "label_Close_Electronic_Handwheel";
            this.label_Close_Electronic_Handwheel.Size = new System.Drawing.Size(412, 64);
            this.label_Close_Electronic_Handwheel.TabIndex = 23;
            this.label_Close_Electronic_Handwheel.Text = "關閉電子手輪";
            // 
            // button_Main_Manual_Mode
            // 
            this.button_Main_Manual_Mode.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Main_Manual_Mode.Location = new System.Drawing.Point(801, 482);
            this.button_Main_Manual_Mode.Name = "button_Main_Manual_Mode";
            this.button_Main_Manual_Mode.Size = new System.Drawing.Size(199, 112);
            this.button_Main_Manual_Mode.TabIndex = 0;
            this.button_Main_Manual_Mode.Text = "主畫面";
            this.button_Main_Manual_Mode.UseVisualStyleBackColor = true;
            this.button_Main_Manual_Mode.Click += new System.EventHandler(this.button_Main_Manual_Mode_Click);
            // 
            // button_A_Loop
            // 
            this.button_A_Loop.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_A_Loop.Location = new System.Drawing.Point(801, 331);
            this.button_A_Loop.Name = "button_A_Loop";
            this.button_A_Loop.Size = new System.Drawing.Size(199, 112);
            this.button_A_Loop.TabIndex = 0;
            this.button_A_Loop.Text = "一循環";
            this.button_A_Loop.UseVisualStyleBackColor = true;
            this.button_A_Loop.Click += new System.EventHandler(this.button_A_Loop_Click);
            // 
            // button_JOG
            // 
            this.button_JOG.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_JOG.Location = new System.Drawing.Point(546, 482);
            this.button_JOG.Name = "button_JOG";
            this.button_JOG.Size = new System.Drawing.Size(199, 112);
            this.button_JOG.TabIndex = 0;
            this.button_JOG.Text = "JOG";
            this.button_JOG.UseVisualStyleBackColor = true;
            this.button_JOG.Click += new System.EventHandler(this.button_JOG_Click);
            // 
            // button_Continuous_Action
            // 
            this.button_Continuous_Action.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Continuous_Action.Location = new System.Drawing.Point(546, 331);
            this.button_Continuous_Action.Name = "button_Continuous_Action";
            this.button_Continuous_Action.Size = new System.Drawing.Size(199, 112);
            this.button_Continuous_Action.TabIndex = 0;
            this.button_Continuous_Action.Text = "連續動作";
            this.button_Continuous_Action.UseVisualStyleBackColor = true;
            this.button_Continuous_Action.Click += new System.EventHandler(this.button_Continuous_Action_Click);
            // 
            // button_OPR_Run
            // 
            this.button_OPR_Run.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OPR_Run.Location = new System.Drawing.Point(801, 180);
            this.button_OPR_Run.Name = "button_OPR_Run";
            this.button_OPR_Run.Size = new System.Drawing.Size(199, 112);
            this.button_OPR_Run.TabIndex = 0;
            this.button_OPR_Run.Text = "原點復歸";
            this.button_OPR_Run.UseVisualStyleBackColor = true;
            this.button_OPR_Run.Click += new System.EventHandler(this.button_OPR_Run_Click);
            // 
            // button_Tool_Rotation_Run
            // 
            this.button_Tool_Rotation_Run.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Tool_Rotation_Run.Location = new System.Drawing.Point(285, 331);
            this.button_Tool_Rotation_Run.Name = "button_Tool_Rotation_Run";
            this.button_Tool_Rotation_Run.Size = new System.Drawing.Size(199, 112);
            this.button_Tool_Rotation_Run.TabIndex = 0;
            this.button_Tool_Rotation_Run.Text = "刀具旋轉";
            this.button_Tool_Rotation_Run.UseVisualStyleBackColor = true;
            this.button_Tool_Rotation_Run.Click += new System.EventHandler(this.button_Tool_Rotation_Run_Click);
            // 
            // button_Calibration_Screw
            // 
            this.button_Calibration_Screw.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Calibration_Screw.Location = new System.Drawing.Point(546, 180);
            this.button_Calibration_Screw.Name = "button_Calibration_Screw";
            this.button_Calibration_Screw.Size = new System.Drawing.Size(199, 112);
            this.button_Calibration_Screw.TabIndex = 0;
            this.button_Calibration_Screw.Text = "螺桿校正";
            this.button_Calibration_Screw.UseVisualStyleBackColor = true;
            this.button_Calibration_Screw.Click += new System.EventHandler(this.button_Calibration_Screw_Click);
            // 
            // button_Tool_Containing_A_Loop
            // 
            this.button_Tool_Containing_A_Loop.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Tool_Containing_A_Loop.Location = new System.Drawing.Point(31, 479);
            this.button_Tool_Containing_A_Loop.Name = "button_Tool_Containing_A_Loop";
            this.button_Tool_Containing_A_Loop.Size = new System.Drawing.Size(199, 112);
            this.button_Tool_Containing_A_Loop.TabIndex = 0;
            this.button_Tool_Containing_A_Loop.Text = "含刀具一循環";
            this.button_Tool_Containing_A_Loop.UseVisualStyleBackColor = true;
            this.button_Tool_Containing_A_Loop.Click += new System.EventHandler(this.button_Tool_Containing_A_Loop_Click);
            // 
            // button_Motor_Start_Run
            // 
            this.button_Motor_Start_Run.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Motor_Start_Run.Location = new System.Drawing.Point(801, 23);
            this.button_Motor_Start_Run.Name = "button_Motor_Start_Run";
            this.button_Motor_Start_Run.Size = new System.Drawing.Size(199, 112);
            this.button_Motor_Start_Run.TabIndex = 0;
            this.button_Motor_Start_Run.Text = "馬達啟動";
            this.button_Motor_Start_Run.UseVisualStyleBackColor = true;
            this.button_Motor_Start_Run.Click += new System.EventHandler(this.button_Motor_Start_Run_Click);
            // 
            // button_Calibration_Fixture
            // 
            this.button_Calibration_Fixture.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Calibration_Fixture.Location = new System.Drawing.Point(285, 180);
            this.button_Calibration_Fixture.Name = "button_Calibration_Fixture";
            this.button_Calibration_Fixture.Size = new System.Drawing.Size(199, 112);
            this.button_Calibration_Fixture.TabIndex = 0;
            this.button_Calibration_Fixture.Text = "夾具校正";
            this.button_Calibration_Fixture.UseVisualStyleBackColor = true;
            this.button_Calibration_Fixture.Click += new System.EventHandler(this.button_Calibration_Fixture_Click);
            // 
            // button_Empty_Disk
            // 
            this.button_Empty_Disk.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Empty_Disk.Location = new System.Drawing.Point(546, 23);
            this.button_Empty_Disk.Name = "button_Empty_Disk";
            this.button_Empty_Disk.Size = new System.Drawing.Size(199, 112);
            this.button_Empty_Disk.TabIndex = 0;
            this.button_Empty_Disk.Text = "盤面清空";
            this.button_Empty_Disk.UseVisualStyleBackColor = true;
            this.button_Empty_Disk.Click += new System.EventHandler(this.button_Empty_Disk_Click);
            // 
            // button_Turn_Handwheel
            // 
            this.button_Turn_Handwheel.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turn_Handwheel.Location = new System.Drawing.Point(31, 328);
            this.button_Turn_Handwheel.Name = "button_Turn_Handwheel";
            this.button_Turn_Handwheel.Size = new System.Drawing.Size(199, 112);
            this.button_Turn_Handwheel.TabIndex = 0;
            this.button_Turn_Handwheel.Text = "手輪開啟";
            this.button_Turn_Handwheel.UseVisualStyleBackColor = true;
            this.button_Turn_Handwheel.Click += new System.EventHandler(this.button_Turn_Handwheel_Click);
            // 
            // button_Turn_Vibration_Plate
            // 
            this.button_Turn_Vibration_Plate.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turn_Vibration_Plate.Location = new System.Drawing.Point(285, 23);
            this.button_Turn_Vibration_Plate.Name = "button_Turn_Vibration_Plate";
            this.button_Turn_Vibration_Plate.Size = new System.Drawing.Size(199, 112);
            this.button_Turn_Vibration_Plate.TabIndex = 0;
            this.button_Turn_Vibration_Plate.Text = "開啟震動盤";
            this.button_Turn_Vibration_Plate.UseVisualStyleBackColor = true;
            this.button_Turn_Vibration_Plate.Click += new System.EventHandler(this.button_Turn_Vibration_Plate_Click);
            // 
            // button_Turntable_Correction
            // 
            this.button_Turntable_Correction.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turntable_Correction.Location = new System.Drawing.Point(31, 177);
            this.button_Turntable_Correction.Name = "button_Turntable_Correction";
            this.button_Turntable_Correction.Size = new System.Drawing.Size(199, 112);
            this.button_Turntable_Correction.TabIndex = 0;
            this.button_Turntable_Correction.Text = "轉盤校正";
            this.button_Turntable_Correction.UseVisualStyleBackColor = true;
            this.button_Turntable_Correction.Click += new System.EventHandler(this.button_Turntable_Correction_Click);
            // 
            // button_Manual_Mode_Run
            // 
            this.button_Manual_Mode_Run.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Manual_Mode_Run.Location = new System.Drawing.Point(31, 20);
            this.button_Manual_Mode_Run.Name = "button_Manual_Mode_Run";
            this.button_Manual_Mode_Run.Size = new System.Drawing.Size(199, 112);
            this.button_Manual_Mode_Run.TabIndex = 0;
            this.button_Manual_Mode_Run.Text = "手動模式";
            this.button_Manual_Mode_Run.UseVisualStyleBackColor = true;
            this.button_Manual_Mode_Run.Click += new System.EventHandler(this.button_Manual_Mode_Run_Click);
            // 
            // panel_Turntable_Correction
            // 
            this.panel_Turntable_Correction.Controls.Add(this.panel_Turntable_Correction_Determine_Disk);
            this.panel_Turntable_Correction.Controls.Add(this.panel_Correction_Boot_Disk2);
            this.panel_Turntable_Correction.Controls.Add(this.panel_Correction_Boot_Disk1);
            this.panel_Turntable_Correction.Controls.Add(this.label_Correction_Boot_Disk);
            this.panel_Turntable_Correction.Location = new System.Drawing.Point(24, 12);
            this.panel_Turntable_Correction.Name = "panel_Turntable_Correction";
            this.panel_Turntable_Correction.Size = new System.Drawing.Size(1148, 638);
            this.panel_Turntable_Correction.TabIndex = 29;
            this.panel_Turntable_Correction.Visible = false;
            // 
            // panel_Turntable_Correction_Determine_Disk
            // 
            this.panel_Turntable_Correction_Determine_Disk.Controls.Add(this.checkBox_OFF_State_Disk);
            this.panel_Turntable_Correction_Determine_Disk.Controls.Add(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine);
            this.panel_Turntable_Correction_Determine_Disk.Controls.Add(this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk);
            this.panel_Turntable_Correction_Determine_Disk.Location = new System.Drawing.Point(137, 11);
            this.panel_Turntable_Correction_Determine_Disk.Name = "panel_Turntable_Correction_Determine_Disk";
            this.panel_Turntable_Correction_Determine_Disk.Size = new System.Drawing.Size(970, 596);
            this.panel_Turntable_Correction_Determine_Disk.TabIndex = 24;
            this.panel_Turntable_Correction_Determine_Disk.Visible = false;
            // 
            // checkBox_OFF_State_Disk
            // 
            this.checkBox_OFF_State_Disk.AllowDrop = true;
            this.checkBox_OFF_State_Disk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_OFF_State_Disk.AutoCheck = false;
            this.checkBox_OFF_State_Disk.AutoSize = true;
            this.checkBox_OFF_State_Disk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_OFF_State_Disk.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_OFF_State_Disk.Location = new System.Drawing.Point(154, 193);
            this.checkBox_OFF_State_Disk.Name = "checkBox_OFF_State_Disk";
            this.checkBox_OFF_State_Disk.Size = new System.Drawing.Size(224, 53);
            this.checkBox_OFF_State_Disk.TabIndex = 24;
            this.checkBox_OFF_State_Disk.Text = "OFF狀態";
            this.checkBox_OFF_State_Disk.UseVisualStyleBackColor = true;
            // 
            // button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine
            // 
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Location = new System.Drawing.Point(209, 294);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Name = "button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Size = new System.Drawing.Size(117, 50);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.TabIndex = 25;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Text = "確定";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.UseVisualStyleBackColor = true;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Click += new System.EventHandler(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Determine_Click);
            // 
            // label_Handwheel_Shaft_Torsional_Choose_OFF_Disk
            // 
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.AutoSize = true;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.Location = new System.Drawing.Point(92, 83);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.Name = "label_Handwheel_Shaft_Torsional_Choose_OFF_Disk";
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.Size = new System.Drawing.Size(794, 64);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.TabIndex = 22;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Disk.Text = "請將手輪 軸選擇扭轉至OFF";
            // 
            // panel_Correction_Boot_Disk2
            // 
            this.panel_Correction_Boot_Disk2.Controls.Add(this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor);
            this.panel_Correction_Boot_Disk2.Controls.Add(this.button_Turntable_Correction_Complete);
            this.panel_Correction_Boot_Disk2.Controls.Add(this.button_panel_Correction_Boot_Disk2_Determine);
            this.panel_Correction_Boot_Disk2.Controls.Add(this.label_Press_Done_Complete_Disk_Surface_Correction);
            this.panel_Correction_Boot_Disk2.Controls.Add(this.label_Screw_Mechanism_Away_From_Lower_Dead_Point);
            this.panel_Correction_Boot_Disk2.Controls.Add(this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes);
            this.panel_Correction_Boot_Disk2.Location = new System.Drawing.Point(182, 127);
            this.panel_Correction_Boot_Disk2.Name = "panel_Correction_Boot_Disk2";
            this.panel_Correction_Boot_Disk2.Size = new System.Drawing.Size(909, 464);
            this.panel_Correction_Boot_Disk2.TabIndex = 26;
            this.panel_Correction_Boot_Disk2.Visible = false;
            // 
            // checkBox_Screw_Mechanism_Away_Dead_Point_Sensor
            // 
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.AllowDrop = true;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.AutoCheck = false;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.AutoSize = true;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Location = new System.Drawing.Point(106, 216);
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Name = "checkBox_Screw_Mechanism_Away_Dead_Point_Sensor";
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Size = new System.Drawing.Size(386, 34);
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.TabIndex = 40;
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Text = "螺桿機構離開下死點感測器";
            this.checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.UseVisualStyleBackColor = true;
            // 
            // button_Turntable_Correction_Complete
            // 
            this.button_Turntable_Correction_Complete.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turntable_Correction_Complete.Location = new System.Drawing.Point(116, 338);
            this.button_Turntable_Correction_Complete.Name = "button_Turntable_Correction_Complete";
            this.button_Turntable_Correction_Complete.Size = new System.Drawing.Size(162, 54);
            this.button_Turntable_Correction_Complete.TabIndex = 41;
            this.button_Turntable_Correction_Complete.Text = "完成";
            this.button_Turntable_Correction_Complete.UseVisualStyleBackColor = true;
            this.button_Turntable_Correction_Complete.Click += new System.EventHandler(this.button_Turntable_Correction_Complete_Click);
            // 
            // button_panel_Correction_Boot_Disk2_Determine
            // 
            this.button_panel_Correction_Boot_Disk2_Determine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_panel_Correction_Boot_Disk2_Determine.Location = new System.Drawing.Point(116, 72);
            this.button_panel_Correction_Boot_Disk2_Determine.Name = "button_panel_Correction_Boot_Disk2_Determine";
            this.button_panel_Correction_Boot_Disk2_Determine.Size = new System.Drawing.Size(117, 50);
            this.button_panel_Correction_Boot_Disk2_Determine.TabIndex = 42;
            this.button_panel_Correction_Boot_Disk2_Determine.Text = "確定";
            this.button_panel_Correction_Boot_Disk2_Determine.UseVisualStyleBackColor = true;
            this.button_panel_Correction_Boot_Disk2_Determine.Click += new System.EventHandler(this.button_panel_Correction_Boot_Disk2_Determine_Click);
            // 
            // label_Press_Done_Complete_Disk_Surface_Correction
            // 
            this.label_Press_Done_Complete_Disk_Surface_Correction.AutoSize = true;
            this.label_Press_Done_Complete_Disk_Surface_Correction.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Done_Complete_Disk_Surface_Correction.Location = new System.Drawing.Point(54, 280);
            this.label_Press_Done_Complete_Disk_Surface_Correction.Name = "label_Press_Done_Complete_Disk_Surface_Correction";
            this.label_Press_Done_Complete_Disk_Surface_Correction.Size = new System.Drawing.Size(450, 37);
            this.label_Press_Done_Complete_Disk_Surface_Correction.TabIndex = 34;
            this.label_Press_Done_Complete_Disk_Surface_Correction.Text = "6.按下完成即完成盤面補正";
            // 
            // label_Screw_Mechanism_Away_From_Lower_Dead_Point
            // 
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.AutoSize = true;
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.Location = new System.Drawing.Point(54, 154);
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.Name = "label_Screw_Mechanism_Away_From_Lower_Dead_Point";
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.Size = new System.Drawing.Size(413, 37);
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.TabIndex = 37;
            this.label_Screw_Mechanism_Away_From_Lower_Dead_Point.Text = "5.將螺桿機構離開下死點";
            // 
            // label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes
            // 
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.AutoSize = true;
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.Location = new System.Drawing.Point(54, 18);
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.Name = "label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes";
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.Size = new System.Drawing.Size(672, 37);
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.TabIndex = 36;
            this.label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes.Text = "4.將盤面順時針旋轉校正孔位後按下確認";
            // 
            // panel_Correction_Boot_Disk1
            // 
            this.panel_Correction_Boot_Disk1.Controls.Add(this.checkBox_OPR_Complete_Disk);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.checkBox_Disk_OPR_Point);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.checkBox_Screw_Mechanism_Dead_Point_Sensor);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.button_Turntable_Correction_Next);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.button_Turntable_Correction_Determine);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.label_OPR_Performed_After_Confirmation);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.label_Go_Disk_OPR_Point);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.label_Clamp_Mechanism_Moved_After_Dead_Point);
            this.panel_Correction_Boot_Disk1.Controls.Add(this.label_Screw_Mechanism_Moves_Bottom_Dead_Center);
            this.panel_Correction_Boot_Disk1.Location = new System.Drawing.Point(182, 127);
            this.panel_Correction_Boot_Disk1.Name = "panel_Correction_Boot_Disk1";
            this.panel_Correction_Boot_Disk1.Size = new System.Drawing.Size(909, 464);
            this.panel_Correction_Boot_Disk1.TabIndex = 25;
            // 
            // checkBox_OPR_Complete_Disk
            // 
            this.checkBox_OPR_Complete_Disk.AllowDrop = true;
            this.checkBox_OPR_Complete_Disk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_OPR_Complete_Disk.AutoCheck = false;
            this.checkBox_OPR_Complete_Disk.AutoSize = true;
            this.checkBox_OPR_Complete_Disk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_OPR_Complete_Disk.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_OPR_Complete_Disk.Location = new System.Drawing.Point(106, 406);
            this.checkBox_OPR_Complete_Disk.Name = "checkBox_OPR_Complete_Disk";
            this.checkBox_OPR_Complete_Disk.Size = new System.Drawing.Size(270, 34);
            this.checkBox_OPR_Complete_Disk.TabIndex = 28;
            this.checkBox_OPR_Complete_Disk.Text = "盤面原點復歸完畢";
            this.checkBox_OPR_Complete_Disk.UseVisualStyleBackColor = true;
            // 
            // checkBox_Disk_OPR_Point
            // 
            this.checkBox_Disk_OPR_Point.AllowDrop = true;
            this.checkBox_Disk_OPR_Point.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Disk_OPR_Point.AutoCheck = false;
            this.checkBox_Disk_OPR_Point.AutoSize = true;
            this.checkBox_Disk_OPR_Point.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Disk_OPR_Point.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Disk_OPR_Point.Location = new System.Drawing.Point(106, 298);
            this.checkBox_Disk_OPR_Point.Name = "checkBox_Disk_OPR_Point";
            this.checkBox_Disk_OPR_Point.Size = new System.Drawing.Size(241, 34);
            this.checkBox_Disk_OPR_Point.TabIndex = 29;
            this.checkBox_Disk_OPR_Point.Text = "盤面原點復歸點";
            this.checkBox_Disk_OPR_Point.UseVisualStyleBackColor = true;
            // 
            // checkBox_After_Clamp_Mechanism_Dead_Point_Sensor
            // 
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.AllowDrop = true;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.AutoCheck = false;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.AutoSize = true;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Location = new System.Drawing.Point(106, 184);
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Name = "checkBox_After_Clamp_Mechanism_Dead_Point_Sensor";
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Size = new System.Drawing.Size(328, 34);
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.TabIndex = 31;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Text = "夾具機構後死點感測器";
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.UseVisualStyleBackColor = true;
            // 
            // checkBox_Screw_Mechanism_Dead_Point_Sensor
            // 
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.AllowDrop = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.AutoCheck = false;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.AutoSize = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Location = new System.Drawing.Point(106, 68);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Name = "checkBox_Screw_Mechanism_Dead_Point_Sensor";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Size = new System.Drawing.Size(328, 34);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.TabIndex = 30;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.Text = "螺桿機構下死點感測器";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor.UseVisualStyleBackColor = true;
            // 
            // button_Turntable_Correction_Next
            // 
            this.button_Turntable_Correction_Next.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turntable_Correction_Next.Location = new System.Drawing.Point(692, 392);
            this.button_Turntable_Correction_Next.Name = "button_Turntable_Correction_Next";
            this.button_Turntable_Correction_Next.Size = new System.Drawing.Size(162, 54);
            this.button_Turntable_Correction_Next.TabIndex = 32;
            this.button_Turntable_Correction_Next.Text = "下一步";
            this.button_Turntable_Correction_Next.UseVisualStyleBackColor = true;
            this.button_Turntable_Correction_Next.Click += new System.EventHandler(this.button_Turntable_Correction_Next_Click);
            // 
            // button_Turntable_Correction_Determine
            // 
            this.button_Turntable_Correction_Determine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Turntable_Correction_Determine.Location = new System.Drawing.Point(530, 314);
            this.button_Turntable_Correction_Determine.Name = "button_Turntable_Correction_Determine";
            this.button_Turntable_Correction_Determine.Size = new System.Drawing.Size(117, 50);
            this.button_Turntable_Correction_Determine.TabIndex = 33;
            this.button_Turntable_Correction_Determine.Text = "確定";
            this.button_Turntable_Correction_Determine.UseVisualStyleBackColor = true;
            this.button_Turntable_Correction_Determine.Click += new System.EventHandler(this.button_Turntable_Correction_Determine_Click);
            // 
            // label_OPR_Performed_After_Confirmation
            // 
            this.label_OPR_Performed_After_Confirmation.AutoSize = true;
            this.label_OPR_Performed_After_Confirmation.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OPR_Performed_After_Confirmation.Location = new System.Drawing.Point(54, 351);
            this.label_OPR_Performed_After_Confirmation.Name = "label_OPR_Performed_After_Confirmation";
            this.label_OPR_Performed_After_Confirmation.Size = new System.Drawing.Size(376, 37);
            this.label_OPR_Performed_After_Confirmation.TabIndex = 25;
            this.label_OPR_Performed_After_Confirmation.Text = "4.確認後進行原點復歸";
            // 
            // label_Go_Disk_OPR_Point
            // 
            this.label_Go_Disk_OPR_Point.AutoSize = true;
            this.label_Go_Disk_OPR_Point.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Go_Disk_OPR_Point.Location = new System.Drawing.Point(54, 237);
            this.label_Go_Disk_OPR_Point.Name = "label_Go_Disk_OPR_Point";
            this.label_Go_Disk_OPR_Point.Size = new System.Drawing.Size(450, 37);
            this.label_Go_Disk_OPR_Point.TabIndex = 24;
            this.label_Go_Disk_OPR_Point.Text = "3.請將盤面轉至原點復歸點";
            // 
            // label_Clamp_Mechanism_Moved_After_Dead_Point
            // 
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.AutoSize = true;
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.Location = new System.Drawing.Point(54, 127);
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.Name = "label_Clamp_Mechanism_Moved_After_Dead_Point";
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.Size = new System.Drawing.Size(450, 37);
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.TabIndex = 27;
            this.label_Clamp_Mechanism_Moved_After_Dead_Point.Text = "2.請將夾具機構移到後死點";
            // 
            // label_Screw_Mechanism_Moves_Bottom_Dead_Center
            // 
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.AutoSize = true;
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.Location = new System.Drawing.Point(54, 18);
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.Name = "label_Screw_Mechanism_Moves_Bottom_Dead_Center";
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.Size = new System.Drawing.Size(487, 37);
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.TabIndex = 26;
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center.Text = "1.請先將螺桿機構移到下死點";
            // 
            // label_Correction_Boot_Disk
            // 
            this.label_Correction_Boot_Disk.AutoSize = true;
            this.label_Correction_Boot_Disk.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Correction_Boot_Disk.Location = new System.Drawing.Point(291, 16);
            this.label_Correction_Boot_Disk.Name = "label_Correction_Boot_Disk";
            this.label_Correction_Boot_Disk.Size = new System.Drawing.Size(616, 96);
            this.label_Correction_Boot_Disk.TabIndex = 18;
            this.label_Correction_Boot_Disk.Text = "盤面補正引導";
            // 
            // panel_Calibration_Fixture
            // 
            this.panel_Calibration_Fixture.Controls.Add(this.panel_Turntable_Correction_Determine_Fixture);
            this.panel_Calibration_Fixture.Controls.Add(this.panel_Correcting_Jig_Guide2);
            this.panel_Calibration_Fixture.Controls.Add(this.panel_Correcting_Jig_Guide1);
            this.panel_Calibration_Fixture.Controls.Add(this.label_Correcting_Jig_Guide);
            this.panel_Calibration_Fixture.Location = new System.Drawing.Point(24, 12);
            this.panel_Calibration_Fixture.Name = "panel_Calibration_Fixture";
            this.panel_Calibration_Fixture.Size = new System.Drawing.Size(1148, 638);
            this.panel_Calibration_Fixture.TabIndex = 30;
            this.panel_Calibration_Fixture.Visible = false;
            // 
            // panel_Turntable_Correction_Determine_Fixture
            // 
            this.panel_Turntable_Correction_Determine_Fixture.Controls.Add(this.checkBox_OFF_State_Fixture);
            this.panel_Turntable_Correction_Determine_Fixture.Controls.Add(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine);
            this.panel_Turntable_Correction_Determine_Fixture.Controls.Add(this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture);
            this.panel_Turntable_Correction_Determine_Fixture.Location = new System.Drawing.Point(137, 11);
            this.panel_Turntable_Correction_Determine_Fixture.Name = "panel_Turntable_Correction_Determine_Fixture";
            this.panel_Turntable_Correction_Determine_Fixture.Size = new System.Drawing.Size(970, 596);
            this.panel_Turntable_Correction_Determine_Fixture.TabIndex = 30;
            this.panel_Turntable_Correction_Determine_Fixture.Visible = false;
            // 
            // checkBox_OFF_State_Fixture
            // 
            this.checkBox_OFF_State_Fixture.AllowDrop = true;
            this.checkBox_OFF_State_Fixture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_OFF_State_Fixture.AutoCheck = false;
            this.checkBox_OFF_State_Fixture.AutoSize = true;
            this.checkBox_OFF_State_Fixture.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_OFF_State_Fixture.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_OFF_State_Fixture.Location = new System.Drawing.Point(154, 193);
            this.checkBox_OFF_State_Fixture.Name = "checkBox_OFF_State_Fixture";
            this.checkBox_OFF_State_Fixture.Size = new System.Drawing.Size(224, 53);
            this.checkBox_OFF_State_Fixture.TabIndex = 24;
            this.checkBox_OFF_State_Fixture.Text = "OFF狀態";
            this.checkBox_OFF_State_Fixture.UseVisualStyleBackColor = true;
            // 
            // button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine
            // 
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Location = new System.Drawing.Point(209, 294);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Name = "button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Size = new System.Drawing.Size(117, 50);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.TabIndex = 25;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Text = "確定";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.UseVisualStyleBackColor = true;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Click += new System.EventHandler(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine_Click);
            // 
            // label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture
            // 
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.AutoSize = true;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.Location = new System.Drawing.Point(92, 83);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.Name = "label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture";
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.Size = new System.Drawing.Size(794, 64);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.TabIndex = 22;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture.Text = "請將手輪 軸選擇扭轉至OFF";
            // 
            // panel_Correcting_Jig_Guide2
            // 
            this.panel_Correcting_Jig_Guide2.Controls.Add(this.button_Correcting_Jig_Guide_Determine_Complete);
            this.panel_Correcting_Jig_Guide2.Controls.Add(this.button_Correcting_Jig_Guide_Determine2);
            this.panel_Correcting_Jig_Guide2.Controls.Add(this.label_Press_Done_Complete_Correction_Jig);
            this.panel_Correcting_Jig_Guide2.Controls.Add(this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation);
            this.panel_Correcting_Jig_Guide2.Location = new System.Drawing.Point(182, 127);
            this.panel_Correcting_Jig_Guide2.Name = "panel_Correcting_Jig_Guide2";
            this.panel_Correcting_Jig_Guide2.Size = new System.Drawing.Size(909, 464);
            this.panel_Correcting_Jig_Guide2.TabIndex = 29;
            this.panel_Correcting_Jig_Guide2.Visible = false;
            // 
            // button_Correcting_Jig_Guide_Determine_Complete
            // 
            this.button_Correcting_Jig_Guide_Determine_Complete.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Correcting_Jig_Guide_Determine_Complete.Location = new System.Drawing.Point(116, 259);
            this.button_Correcting_Jig_Guide_Determine_Complete.Name = "button_Correcting_Jig_Guide_Determine_Complete";
            this.button_Correcting_Jig_Guide_Determine_Complete.Size = new System.Drawing.Size(162, 54);
            this.button_Correcting_Jig_Guide_Determine_Complete.TabIndex = 41;
            this.button_Correcting_Jig_Guide_Determine_Complete.Text = "完成";
            this.button_Correcting_Jig_Guide_Determine_Complete.UseVisualStyleBackColor = true;
            this.button_Correcting_Jig_Guide_Determine_Complete.Click += new System.EventHandler(this.button_Correcting_Jig_Guide_Determine_Complete_Click);
            // 
            // button_Correcting_Jig_Guide_Determine2
            // 
            this.button_Correcting_Jig_Guide_Determine2.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Correcting_Jig_Guide_Determine2.Location = new System.Drawing.Point(116, 89);
            this.button_Correcting_Jig_Guide_Determine2.Name = "button_Correcting_Jig_Guide_Determine2";
            this.button_Correcting_Jig_Guide_Determine2.Size = new System.Drawing.Size(117, 50);
            this.button_Correcting_Jig_Guide_Determine2.TabIndex = 42;
            this.button_Correcting_Jig_Guide_Determine2.Text = "確定";
            this.button_Correcting_Jig_Guide_Determine2.UseVisualStyleBackColor = true;
            this.button_Correcting_Jig_Guide_Determine2.Click += new System.EventHandler(this.button_Correcting_Jig_Guide_Determine2_Click);
            // 
            // label_Press_Done_Complete_Correction_Jig
            // 
            this.label_Press_Done_Complete_Correction_Jig.AutoSize = true;
            this.label_Press_Done_Complete_Correction_Jig.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Done_Complete_Correction_Jig.Location = new System.Drawing.Point(54, 192);
            this.label_Press_Done_Complete_Correction_Jig.Name = "label_Press_Done_Complete_Correction_Jig";
            this.label_Press_Done_Complete_Correction_Jig.Size = new System.Drawing.Size(450, 37);
            this.label_Press_Done_Complete_Correction_Jig.TabIndex = 37;
            this.label_Press_Done_Complete_Correction_Jig.Text = "4.按下完成即完成夾具補正";
            // 
            // label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation
            // 
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.AutoSize = true;
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.Location = new System.Drawing.Point(54, 18);
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.Name = "label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation";
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.Size = new System.Drawing.Size(672, 37);
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.TabIndex = 36;
            this.label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation.Text = "3.將夾爪順時針旋轉安全位置後按下確認";
            // 
            // panel_Correcting_Jig_Guide1
            // 
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.checkBox_OPR_Completed_Jig);
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise);
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.button_Correcting_Jig_Guide_Next);
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.button_Correcting_Jig_Guide_Determine1);
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.label_After_Confirmation_Performed_OPR);
            this.panel_Correcting_Jig_Guide1.Controls.Add(this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture);
            this.panel_Correcting_Jig_Guide1.Location = new System.Drawing.Point(182, 127);
            this.panel_Correcting_Jig_Guide1.Name = "panel_Correcting_Jig_Guide1";
            this.panel_Correcting_Jig_Guide1.Size = new System.Drawing.Size(909, 464);
            this.panel_Correcting_Jig_Guide1.TabIndex = 28;
            // 
            // checkBox_OPR_Completed_Jig
            // 
            this.checkBox_OPR_Completed_Jig.AllowDrop = true;
            this.checkBox_OPR_Completed_Jig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_OPR_Completed_Jig.AutoCheck = false;
            this.checkBox_OPR_Completed_Jig.AutoSize = true;
            this.checkBox_OPR_Completed_Jig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_OPR_Completed_Jig.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_OPR_Completed_Jig.Location = new System.Drawing.Point(106, 271);
            this.checkBox_OPR_Completed_Jig.Name = "checkBox_OPR_Completed_Jig";
            this.checkBox_OPR_Completed_Jig.Size = new System.Drawing.Size(270, 34);
            this.checkBox_OPR_Completed_Jig.TabIndex = 31;
            this.checkBox_OPR_Completed_Jig.Text = "夾具原點復歸完畢";
            this.checkBox_OPR_Completed_Jig.UseVisualStyleBackColor = true;
            // 
            // checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise
            // 
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.AllowDrop = true;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.AutoCheck = false;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.AutoSize = true;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Location = new System.Drawing.Point(106, 85);
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Name = "checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise";
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Size = new System.Drawing.Size(433, 34);
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.TabIndex = 30;
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Text = "夾具機構後死點感測器(順時針)";
            this.checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.UseVisualStyleBackColor = true;
            // 
            // button_Correcting_Jig_Guide_Next
            // 
            this.button_Correcting_Jig_Guide_Next.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Correcting_Jig_Guide_Next.Location = new System.Drawing.Point(487, 348);
            this.button_Correcting_Jig_Guide_Next.Name = "button_Correcting_Jig_Guide_Next";
            this.button_Correcting_Jig_Guide_Next.Size = new System.Drawing.Size(162, 54);
            this.button_Correcting_Jig_Guide_Next.TabIndex = 32;
            this.button_Correcting_Jig_Guide_Next.Text = "下一步";
            this.button_Correcting_Jig_Guide_Next.UseVisualStyleBackColor = true;
            this.button_Correcting_Jig_Guide_Next.Click += new System.EventHandler(this.button_Correcting_Jig_Guide_Next_Click);
            // 
            // button_Correcting_Jig_Guide_Determine1
            // 
            this.button_Correcting_Jig_Guide_Determine1.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Correcting_Jig_Guide_Determine1.Location = new System.Drawing.Point(487, 189);
            this.button_Correcting_Jig_Guide_Determine1.Name = "button_Correcting_Jig_Guide_Determine1";
            this.button_Correcting_Jig_Guide_Determine1.Size = new System.Drawing.Size(117, 50);
            this.button_Correcting_Jig_Guide_Determine1.TabIndex = 33;
            this.button_Correcting_Jig_Guide_Determine1.Text = "確定";
            this.button_Correcting_Jig_Guide_Determine1.UseVisualStyleBackColor = true;
            this.button_Correcting_Jig_Guide_Determine1.Click += new System.EventHandler(this.button_Correcting_Jig_Guide_Determine1_Click);
            // 
            // label_After_Confirmation_Performed_OPR
            // 
            this.label_After_Confirmation_Performed_OPR.AutoSize = true;
            this.label_After_Confirmation_Performed_OPR.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_After_Confirmation_Performed_OPR.Location = new System.Drawing.Point(59, 190);
            this.label_After_Confirmation_Performed_OPR.Name = "label_After_Confirmation_Performed_OPR";
            this.label_After_Confirmation_Performed_OPR.Size = new System.Drawing.Size(376, 37);
            this.label_After_Confirmation_Performed_OPR.TabIndex = 27;
            this.label_After_Confirmation_Performed_OPR.Text = "2.確認後進行原點復歸";
            // 
            // label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture
            // 
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.AutoSize = true;
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.Location = new System.Drawing.Point(54, 18);
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.Name = "label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture";
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.Size = new System.Drawing.Size(450, 37);
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.TabIndex = 26;
            this.label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture.Text = "1.請將夾具機構移到後死點";
            // 
            // label_Correcting_Jig_Guide
            // 
            this.label_Correcting_Jig_Guide.AutoSize = true;
            this.label_Correcting_Jig_Guide.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Correcting_Jig_Guide.Location = new System.Drawing.Point(291, 16);
            this.label_Correcting_Jig_Guide.Name = "label_Correcting_Jig_Guide";
            this.label_Correcting_Jig_Guide.Size = new System.Drawing.Size(616, 96);
            this.label_Correcting_Jig_Guide.TabIndex = 27;
            this.label_Correcting_Jig_Guide.Text = "夾具補正引導";
            // 
            // panel_Empty_Disk
            // 
            this.panel_Empty_Disk.Controls.Add(this.panel_Start_Empty_Disk);
            this.panel_Empty_Disk.Controls.Add(this.checkBox_Disk_Empty);
            this.panel_Empty_Disk.Controls.Add(this.checkBox_Empty_Disk);
            this.panel_Empty_Disk.Controls.Add(this.checkBox_Machine_Can_Turned_Off);
            this.panel_Empty_Disk.Controls.Add(this.button_Empty_Disk_Complete);
            this.panel_Empty_Disk.Controls.Add(this.button_label_Start_Empty_Disk_Confirm);
            this.panel_Empty_Disk.Controls.Add(this.button_Start_Empty_Ramp_Confirm);
            this.panel_Empty_Disk.Controls.Add(this.label_Start_Empty_Disk);
            this.panel_Empty_Disk.Controls.Add(this.label_Start_Empty_Ramp);
            this.panel_Empty_Disk.Controls.Add(this.label_Empty_Disk);
            this.panel_Empty_Disk.Location = new System.Drawing.Point(24, 12);
            this.panel_Empty_Disk.Name = "panel_Empty_Disk";
            this.panel_Empty_Disk.Size = new System.Drawing.Size(1148, 638);
            this.panel_Empty_Disk.TabIndex = 31;
            this.panel_Empty_Disk.Visible = false;
            // 
            // panel_Start_Empty_Disk
            // 
            this.panel_Start_Empty_Disk.Controls.Add(this.button_Start_Empty_Disk_Confirm);
            this.panel_Start_Empty_Disk.Controls.Add(this.label_Please_Confirm_Again_Do_Not_Close_Turntable);
            this.panel_Start_Empty_Disk.Controls.Add(this.label_Note_Machine_About_Run);
            this.panel_Start_Empty_Disk.Location = new System.Drawing.Point(279, 14);
            this.panel_Start_Empty_Disk.Name = "panel_Start_Empty_Disk";
            this.panel_Start_Empty_Disk.Size = new System.Drawing.Size(630, 599);
            this.panel_Start_Empty_Disk.TabIndex = 40;
            this.panel_Start_Empty_Disk.Visible = false;
            // 
            // button_Start_Empty_Disk_Confirm
            // 
            this.button_Start_Empty_Disk_Confirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Start_Empty_Disk_Confirm.Location = new System.Drawing.Point(267, 292);
            this.button_Start_Empty_Disk_Confirm.Name = "button_Start_Empty_Disk_Confirm";
            this.button_Start_Empty_Disk_Confirm.Size = new System.Drawing.Size(117, 50);
            this.button_Start_Empty_Disk_Confirm.TabIndex = 40;
            this.button_Start_Empty_Disk_Confirm.Text = "確定";
            this.button_Start_Empty_Disk_Confirm.UseVisualStyleBackColor = true;
            this.button_Start_Empty_Disk_Confirm.Click += new System.EventHandler(this.button_Start_Empty_Disk_Confirm_Click);
            // 
            // label_Please_Confirm_Again_Do_Not_Close_Turntable
            // 
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.AutoSize = true;
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.Location = new System.Drawing.Point(97, 160);
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.Name = "label_Please_Confirm_Again_Do_Not_Close_Turntable";
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.Size = new System.Drawing.Size(434, 37);
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.TabIndex = 35;
            this.label_Please_Confirm_Again_Do_Not_Close_Turntable.Text = "請再次確認 並勿靠近轉盤";
            // 
            // label_Note_Machine_About_Run
            // 
            this.label_Note_Machine_About_Run.AutoSize = true;
            this.label_Note_Machine_About_Run.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Note_Machine_About_Run.Location = new System.Drawing.Point(156, 58);
            this.label_Note_Machine_About_Run.Name = "label_Note_Machine_About_Run";
            this.label_Note_Machine_About_Run.Size = new System.Drawing.Size(313, 37);
            this.label_Note_Machine_About_Run.TabIndex = 35;
            this.label_Note_Machine_About_Run.Text = "注意機台即將運轉";
            // 
            // checkBox_Disk_Empty
            // 
            this.checkBox_Disk_Empty.AllowDrop = true;
            this.checkBox_Disk_Empty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Disk_Empty.AutoCheck = false;
            this.checkBox_Disk_Empty.AutoSize = true;
            this.checkBox_Disk_Empty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Disk_Empty.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Disk_Empty.Location = new System.Drawing.Point(480, 327);
            this.checkBox_Disk_Empty.Name = "checkBox_Disk_Empty";
            this.checkBox_Disk_Empty.Size = new System.Drawing.Size(183, 34);
            this.checkBox_Disk_Empty.TabIndex = 37;
            this.checkBox_Disk_Empty.Text = "盤面已清空";
            this.checkBox_Disk_Empty.UseVisualStyleBackColor = true;
            // 
            // checkBox_Empty_Disk
            // 
            this.checkBox_Empty_Disk.AllowDrop = true;
            this.checkBox_Empty_Disk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Empty_Disk.AutoCheck = false;
            this.checkBox_Empty_Disk.AutoSize = true;
            this.checkBox_Empty_Disk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Empty_Disk.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Empty_Disk.Location = new System.Drawing.Point(480, 466);
            this.checkBox_Empty_Disk.Name = "checkBox_Empty_Disk";
            this.checkBox_Empty_Disk.Size = new System.Drawing.Size(183, 34);
            this.checkBox_Empty_Disk.TabIndex = 36;
            this.checkBox_Empty_Disk.Text = "盤面清空中";
            this.checkBox_Empty_Disk.UseVisualStyleBackColor = true;
            // 
            // checkBox_Machine_Can_Turned_Off
            // 
            this.checkBox_Machine_Can_Turned_Off.AllowDrop = true;
            this.checkBox_Machine_Can_Turned_Off.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Machine_Can_Turned_Off.AutoCheck = false;
            this.checkBox_Machine_Can_Turned_Off.AutoSize = true;
            this.checkBox_Machine_Can_Turned_Off.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Machine_Can_Turned_Off.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Machine_Can_Turned_Off.Location = new System.Drawing.Point(480, 394);
            this.checkBox_Machine_Can_Turned_Off.Name = "checkBox_Machine_Can_Turned_Off";
            this.checkBox_Machine_Can_Turned_Off.Size = new System.Drawing.Size(183, 34);
            this.checkBox_Machine_Can_Turned_Off.TabIndex = 36;
            this.checkBox_Machine_Can_Turned_Off.Text = "機台可關閉";
            this.checkBox_Machine_Can_Turned_Off.UseVisualStyleBackColor = true;
            // 
            // button_Empty_Disk_Complete
            // 
            this.button_Empty_Disk_Complete.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Empty_Disk_Complete.Location = new System.Drawing.Point(480, 550);
            this.button_Empty_Disk_Complete.Name = "button_Empty_Disk_Complete";
            this.button_Empty_Disk_Complete.Size = new System.Drawing.Size(162, 54);
            this.button_Empty_Disk_Complete.TabIndex = 38;
            this.button_Empty_Disk_Complete.Text = "完成";
            this.button_Empty_Disk_Complete.UseVisualStyleBackColor = true;
            this.button_Empty_Disk_Complete.Click += new System.EventHandler(this.button_Empty_Disk_Complete_Click);
            // 
            // button_label_Start_Empty_Disk_Confirm
            // 
            this.button_label_Start_Empty_Disk_Confirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_label_Start_Empty_Disk_Confirm.Location = new System.Drawing.Point(656, 230);
            this.button_label_Start_Empty_Disk_Confirm.Name = "button_label_Start_Empty_Disk_Confirm";
            this.button_label_Start_Empty_Disk_Confirm.Size = new System.Drawing.Size(117, 50);
            this.button_label_Start_Empty_Disk_Confirm.TabIndex = 39;
            this.button_label_Start_Empty_Disk_Confirm.Text = "確定";
            this.button_label_Start_Empty_Disk_Confirm.UseVisualStyleBackColor = true;
            this.button_label_Start_Empty_Disk_Confirm.Click += new System.EventHandler(this.button_label_Start_Empty_Disk_Confirm_Click);
            // 
            // button_Start_Empty_Ramp_Confirm
            // 
            this.button_Start_Empty_Ramp_Confirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Start_Empty_Ramp_Confirm.Location = new System.Drawing.Point(655, 144);
            this.button_Start_Empty_Ramp_Confirm.Name = "button_Start_Empty_Ramp_Confirm";
            this.button_Start_Empty_Ramp_Confirm.Size = new System.Drawing.Size(117, 50);
            this.button_Start_Empty_Ramp_Confirm.TabIndex = 39;
            this.button_Start_Empty_Ramp_Confirm.Text = "確定";
            this.button_Start_Empty_Ramp_Confirm.UseVisualStyleBackColor = true;
            this.button_Start_Empty_Ramp_Confirm.Click += new System.EventHandler(this.button_Start_Empty_Ramp_Confirm_Click);
            // 
            // label_Start_Empty_Disk
            // 
            this.label_Start_Empty_Disk.AutoSize = true;
            this.label_Start_Empty_Disk.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Start_Empty_Disk.Location = new System.Drawing.Point(335, 237);
            this.label_Start_Empty_Disk.Name = "label_Start_Empty_Disk";
            this.label_Start_Empty_Disk.Size = new System.Drawing.Size(239, 37);
            this.label_Start_Empty_Disk.TabIndex = 34;
            this.label_Start_Empty_Disk.Text = "開始清空盤面";
            // 
            // label_Start_Empty_Ramp
            // 
            this.label_Start_Empty_Ramp.AutoSize = true;
            this.label_Start_Empty_Ramp.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Start_Empty_Ramp.Location = new System.Drawing.Point(335, 151);
            this.label_Start_Empty_Ramp.Name = "label_Start_Empty_Ramp";
            this.label_Start_Empty_Ramp.Size = new System.Drawing.Size(239, 37);
            this.label_Start_Empty_Ramp.TabIndex = 34;
            this.label_Start_Empty_Ramp.Text = "開始清空斜坡";
            // 
            // label_Empty_Disk
            // 
            this.label_Empty_Disk.AutoSize = true;
            this.label_Empty_Disk.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Empty_Disk.Location = new System.Drawing.Point(402, 16);
            this.label_Empty_Disk.Name = "label_Empty_Disk";
            this.label_Empty_Disk.Size = new System.Drawing.Size(424, 96);
            this.label_Empty_Disk.TabIndex = 28;
            this.label_Empty_Disk.Text = "清空盤面";
            // 
            // panel_Screw_Correction_Guide
            // 
            this.panel_Screw_Correction_Guide.Controls.Add(this.panel_Turntable_Correction_Determine_Screw);
            this.panel_Screw_Correction_Guide.Controls.Add(this.panel_Screw_Correction_Guide2);
            this.panel_Screw_Correction_Guide.Controls.Add(this.panel_Screw_Correction_Guide1);
            this.panel_Screw_Correction_Guide.Controls.Add(this.label_Screw_Correction_Guide);
            this.panel_Screw_Correction_Guide.Location = new System.Drawing.Point(24, 12);
            this.panel_Screw_Correction_Guide.Name = "panel_Screw_Correction_Guide";
            this.panel_Screw_Correction_Guide.Size = new System.Drawing.Size(1148, 638);
            this.panel_Screw_Correction_Guide.TabIndex = 32;
            this.panel_Screw_Correction_Guide.Visible = false;
            // 
            // panel_Turntable_Correction_Determine_Screw
            // 
            this.panel_Turntable_Correction_Determine_Screw.Controls.Add(this.checkBox_OFF_State_Screw);
            this.panel_Turntable_Correction_Determine_Screw.Controls.Add(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine);
            this.panel_Turntable_Correction_Determine_Screw.Controls.Add(this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw);
            this.panel_Turntable_Correction_Determine_Screw.Location = new System.Drawing.Point(137, 11);
            this.panel_Turntable_Correction_Determine_Screw.Name = "panel_Turntable_Correction_Determine_Screw";
            this.panel_Turntable_Correction_Determine_Screw.Size = new System.Drawing.Size(970, 596);
            this.panel_Turntable_Correction_Determine_Screw.TabIndex = 34;
            this.panel_Turntable_Correction_Determine_Screw.Visible = false;
            // 
            // checkBox_OFF_State_Screw
            // 
            this.checkBox_OFF_State_Screw.AllowDrop = true;
            this.checkBox_OFF_State_Screw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_OFF_State_Screw.AutoCheck = false;
            this.checkBox_OFF_State_Screw.AutoSize = true;
            this.checkBox_OFF_State_Screw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_OFF_State_Screw.Font = new System.Drawing.Font("PMingLiU", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_OFF_State_Screw.Location = new System.Drawing.Point(154, 193);
            this.checkBox_OFF_State_Screw.Name = "checkBox_OFF_State_Screw";
            this.checkBox_OFF_State_Screw.Size = new System.Drawing.Size(224, 53);
            this.checkBox_OFF_State_Screw.TabIndex = 24;
            this.checkBox_OFF_State_Screw.Text = "OFF狀態";
            this.checkBox_OFF_State_Screw.UseVisualStyleBackColor = true;
            // 
            // button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine
            // 
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Location = new System.Drawing.Point(209, 294);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Name = "button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Size = new System.Drawing.Size(117, 50);
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.TabIndex = 25;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Text = "確定";
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.UseVisualStyleBackColor = true;
            this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Click += new System.EventHandler(this.button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine_Click);
            // 
            // label_Handwheel_Shaft_Torsional_Choose_OFF_Screw
            // 
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.AutoSize = true;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.Font = new System.Drawing.Font("PMingLiU", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.Location = new System.Drawing.Point(92, 83);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.Name = "label_Handwheel_Shaft_Torsional_Choose_OFF_Screw";
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.Size = new System.Drawing.Size(794, 64);
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.TabIndex = 22;
            this.label_Handwheel_Shaft_Torsional_Choose_OFF_Screw.Text = "請將手輪 軸選擇扭轉至OFF";
            // 
            // panel_Screw_Correction_Guide2
            // 
            this.panel_Screw_Correction_Guide2.Controls.Add(this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2);
            this.panel_Screw_Correction_Guide2.Controls.Add(this.button_Screw_Correction_Guide_Complete);
            this.panel_Screw_Correction_Guide2.Controls.Add(this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm);
            this.panel_Screw_Correction_Guide2.Controls.Add(this.label_Press_Done_Complete_Correction_Screw);
            this.panel_Screw_Correction_Guide2.Controls.Add(this.label_Screw_Mechanism_Away_Lower_Dead_Point);
            this.panel_Screw_Correction_Guide2.Controls.Add(this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction);
            this.panel_Screw_Correction_Guide2.Location = new System.Drawing.Point(182, 127);
            this.panel_Screw_Correction_Guide2.Name = "panel_Screw_Correction_Guide2";
            this.panel_Screw_Correction_Guide2.Size = new System.Drawing.Size(909, 464);
            this.panel_Screw_Correction_Guide2.TabIndex = 33;
            this.panel_Screw_Correction_Guide2.Visible = false;
            // 
            // checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2
            // 
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.AllowDrop = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.AutoCheck = false;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.AutoSize = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Location = new System.Drawing.Point(98, 230);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Name = "checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Size = new System.Drawing.Size(328, 34);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.TabIndex = 43;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Text = "螺桿機構下死點感測器";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.UseVisualStyleBackColor = true;
            // 
            // button_Screw_Correction_Guide_Complete
            // 
            this.button_Screw_Correction_Guide_Complete.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Screw_Correction_Guide_Complete.Location = new System.Drawing.Point(116, 359);
            this.button_Screw_Correction_Guide_Complete.Name = "button_Screw_Correction_Guide_Complete";
            this.button_Screw_Correction_Guide_Complete.Size = new System.Drawing.Size(162, 54);
            this.button_Screw_Correction_Guide_Complete.TabIndex = 41;
            this.button_Screw_Correction_Guide_Complete.Text = "完成";
            this.button_Screw_Correction_Guide_Complete.UseVisualStyleBackColor = true;
            this.button_Screw_Correction_Guide_Complete.Click += new System.EventHandler(this.button_Screw_Correction_Guide_Complete_Click);
            // 
            // button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm
            // 
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Location = new System.Drawing.Point(116, 89);
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Name = "button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm";
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Size = new System.Drawing.Size(117, 50);
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.TabIndex = 42;
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Text = "確定";
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.UseVisualStyleBackColor = true;
            this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm.Click += new System.EventHandler(this.button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm_Click);
            // 
            // label_Press_Done_Complete_Correction_Screw
            // 
            this.label_Press_Done_Complete_Correction_Screw.AutoSize = true;
            this.label_Press_Done_Complete_Correction_Screw.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Done_Complete_Correction_Screw.Location = new System.Drawing.Point(51, 295);
            this.label_Press_Done_Complete_Correction_Screw.Name = "label_Press_Done_Complete_Correction_Screw";
            this.label_Press_Done_Complete_Correction_Screw.Size = new System.Drawing.Size(450, 37);
            this.label_Press_Done_Complete_Correction_Screw.TabIndex = 37;
            this.label_Press_Done_Complete_Correction_Screw.Text = "5.按下完成即完成螺桿補正";
            // 
            // label_Screw_Mechanism_Away_Lower_Dead_Point
            // 
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.AutoSize = true;
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.Location = new System.Drawing.Point(51, 168);
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.Name = "label_Screw_Mechanism_Away_Lower_Dead_Point";
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.Size = new System.Drawing.Size(413, 37);
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.TabIndex = 37;
            this.label_Screw_Mechanism_Away_Lower_Dead_Point.Text = "4.將螺桿機構離開下死點";
            // 
            // label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction
            // 
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.AutoSize = true;
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.Location = new System.Drawing.Point(54, 18);
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.Name = "label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction";
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.Size = new System.Drawing.Size(672, 37);
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.TabIndex = 36;
            this.label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction.Text = "3.將螺桿順時針旋轉校正高度後按下確認";
            // 
            // panel_Screw_Correction_Guide1
            // 
            this.panel_Screw_Correction_Guide1.Controls.Add(this.checkBox_Screw_OPR_Completed);
            this.panel_Screw_Correction_Guide1.Controls.Add(this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1);
            this.panel_Screw_Correction_Guide1.Controls.Add(this.button_Screw_Correction_Guide_Next);
            this.panel_Screw_Correction_Guide1.Controls.Add(this.button_OPR_Performed_After_Confirmation_Screw_Confirm);
            this.panel_Screw_Correction_Guide1.Controls.Add(this.label_OPR_Performed_After_Confirmation_Screw);
            this.panel_Screw_Correction_Guide1.Controls.Add(this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw);
            this.panel_Screw_Correction_Guide1.Location = new System.Drawing.Point(182, 127);
            this.panel_Screw_Correction_Guide1.Name = "panel_Screw_Correction_Guide1";
            this.panel_Screw_Correction_Guide1.Size = new System.Drawing.Size(909, 464);
            this.panel_Screw_Correction_Guide1.TabIndex = 32;
            // 
            // checkBox_Screw_OPR_Completed
            // 
            this.checkBox_Screw_OPR_Completed.AllowDrop = true;
            this.checkBox_Screw_OPR_Completed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_OPR_Completed.AutoCheck = false;
            this.checkBox_Screw_OPR_Completed.AutoSize = true;
            this.checkBox_Screw_OPR_Completed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_OPR_Completed.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_OPR_Completed.Location = new System.Drawing.Point(106, 271);
            this.checkBox_Screw_OPR_Completed.Name = "checkBox_Screw_OPR_Completed";
            this.checkBox_Screw_OPR_Completed.Size = new System.Drawing.Size(270, 34);
            this.checkBox_Screw_OPR_Completed.TabIndex = 31;
            this.checkBox_Screw_OPR_Completed.Text = "螺桿原點復歸完畢";
            this.checkBox_Screw_OPR_Completed.UseVisualStyleBackColor = true;
            // 
            // checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1
            // 
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.AllowDrop = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.AutoCheck = false;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.AutoSize = true;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Location = new System.Drawing.Point(106, 85);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Name = "checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Size = new System.Drawing.Size(328, 34);
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.TabIndex = 30;
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Text = "螺桿機構下死點感測器";
            this.checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.UseVisualStyleBackColor = true;
            // 
            // button_Screw_Correction_Guide_Next
            // 
            this.button_Screw_Correction_Guide_Next.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Screw_Correction_Guide_Next.Location = new System.Drawing.Point(487, 348);
            this.button_Screw_Correction_Guide_Next.Name = "button_Screw_Correction_Guide_Next";
            this.button_Screw_Correction_Guide_Next.Size = new System.Drawing.Size(162, 54);
            this.button_Screw_Correction_Guide_Next.TabIndex = 32;
            this.button_Screw_Correction_Guide_Next.Text = "下一步";
            this.button_Screw_Correction_Guide_Next.UseVisualStyleBackColor = true;
            this.button_Screw_Correction_Guide_Next.Click += new System.EventHandler(this.button_Screw_Correction_Guide_Next_Click);
            // 
            // button_OPR_Performed_After_Confirmation_Screw_Confirm
            // 
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Font = new System.Drawing.Font("PMingLiU", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Location = new System.Drawing.Point(487, 189);
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Name = "button_OPR_Performed_After_Confirmation_Screw_Confirm";
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Size = new System.Drawing.Size(117, 50);
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.TabIndex = 33;
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Text = "確定";
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.UseVisualStyleBackColor = true;
            this.button_OPR_Performed_After_Confirmation_Screw_Confirm.Click += new System.EventHandler(this.button_OPR_Performed_After_Confirmation_Screw_Confirm_Click);
            // 
            // label_OPR_Performed_After_Confirmation_Screw
            // 
            this.label_OPR_Performed_After_Confirmation_Screw.AutoSize = true;
            this.label_OPR_Performed_After_Confirmation_Screw.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_OPR_Performed_After_Confirmation_Screw.Location = new System.Drawing.Point(59, 190);
            this.label_OPR_Performed_After_Confirmation_Screw.Name = "label_OPR_Performed_After_Confirmation_Screw";
            this.label_OPR_Performed_After_Confirmation_Screw.Size = new System.Drawing.Size(376, 37);
            this.label_OPR_Performed_After_Confirmation_Screw.TabIndex = 27;
            this.label_OPR_Performed_After_Confirmation_Screw.Text = "2.確認後進行原點復歸";
            // 
            // label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw
            // 
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.AutoSize = true;
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.Location = new System.Drawing.Point(54, 18);
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.Name = "label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw";
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.Size = new System.Drawing.Size(487, 37);
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.TabIndex = 26;
            this.label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw.Text = "1.請先將螺桿機構移到下死點";
            // 
            // label_Screw_Correction_Guide
            // 
            this.label_Screw_Correction_Guide.AutoSize = true;
            this.label_Screw_Correction_Guide.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Screw_Correction_Guide.Location = new System.Drawing.Point(291, 16);
            this.label_Screw_Correction_Guide.Name = "label_Screw_Correction_Guide";
            this.label_Screw_Correction_Guide.Size = new System.Drawing.Size(616, 96);
            this.label_Screw_Correction_Guide.TabIndex = 31;
            this.label_Screw_Correction_Guide.Text = "螺桿補正引導";
            // 
            // panel_Error_Message
            // 
            this.panel_Error_Message.Controls.Add(this.button_Error_Message_Exclusion_Mistake);
            this.panel_Error_Message.Controls.Add(this.button_Error_Message_Speed_Setting);
            this.panel_Error_Message.Controls.Add(this.button_Error_Message_Main);
            this.panel_Error_Message.Controls.Add(this.button_Error_Message_Manual_Mode);
            this.panel_Error_Message.Controls.Add(this.textBox_Error_Message);
            this.panel_Error_Message.Controls.Add(this.label_Error_Message);
            this.panel_Error_Message.Location = new System.Drawing.Point(24, 12);
            this.panel_Error_Message.Name = "panel_Error_Message";
            this.panel_Error_Message.Size = new System.Drawing.Size(1148, 638);
            this.panel_Error_Message.TabIndex = 33;
            this.panel_Error_Message.Visible = false;
            // 
            // button_Error_Message_Exclusion_Mistake
            // 
            this.button_Error_Message_Exclusion_Mistake.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Error_Message_Exclusion_Mistake.Location = new System.Drawing.Point(774, 33);
            this.button_Error_Message_Exclusion_Mistake.Name = "button_Error_Message_Exclusion_Mistake";
            this.button_Error_Message_Exclusion_Mistake.Size = new System.Drawing.Size(226, 58);
            this.button_Error_Message_Exclusion_Mistake.TabIndex = 35;
            this.button_Error_Message_Exclusion_Mistake.Text = "清除錯誤";
            this.button_Error_Message_Exclusion_Mistake.UseVisualStyleBackColor = true;
            this.button_Error_Message_Exclusion_Mistake.Click += new System.EventHandler(this.button_Error_Message_Exclusion_Mistake_Click);
            // 
            // button_Error_Message_Speed_Setting
            // 
            this.button_Error_Message_Speed_Setting.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Error_Message_Speed_Setting.Location = new System.Drawing.Point(669, 545);
            this.button_Error_Message_Speed_Setting.Name = "button_Error_Message_Speed_Setting";
            this.button_Error_Message_Speed_Setting.Size = new System.Drawing.Size(226, 58);
            this.button_Error_Message_Speed_Setting.TabIndex = 35;
            this.button_Error_Message_Speed_Setting.Text = "速度設定";
            this.button_Error_Message_Speed_Setting.UseVisualStyleBackColor = true;
            this.button_Error_Message_Speed_Setting.Click += new System.EventHandler(this.button_Error_Message_Speed_Setting_Click);
            // 
            // button_Error_Message_Main
            // 
            this.button_Error_Message_Main.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Error_Message_Main.Location = new System.Drawing.Point(382, 546);
            this.button_Error_Message_Main.Name = "button_Error_Message_Main";
            this.button_Error_Message_Main.Size = new System.Drawing.Size(226, 58);
            this.button_Error_Message_Main.TabIndex = 35;
            this.button_Error_Message_Main.Text = "回主畫面";
            this.button_Error_Message_Main.UseVisualStyleBackColor = true;
            this.button_Error_Message_Main.Click += new System.EventHandler(this.button_Error_Message_Main_Click);
            // 
            // button_Error_Message_Manual_Mode
            // 
            this.button_Error_Message_Manual_Mode.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Error_Message_Manual_Mode.Location = new System.Drawing.Point(91, 546);
            this.button_Error_Message_Manual_Mode.Name = "button_Error_Message_Manual_Mode";
            this.button_Error_Message_Manual_Mode.Size = new System.Drawing.Size(226, 58);
            this.button_Error_Message_Manual_Mode.TabIndex = 34;
            this.button_Error_Message_Manual_Mode.Text = "手動模式";
            this.button_Error_Message_Manual_Mode.UseVisualStyleBackColor = true;
            this.button_Error_Message_Manual_Mode.Click += new System.EventHandler(this.button_Error_Message_Manual_Mode_Click);
            // 
            // textBox_Error_Message
            // 
            this.textBox_Error_Message.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Error_Message.Location = new System.Drawing.Point(177, 130);
            this.textBox_Error_Message.Multiline = true;
            this.textBox_Error_Message.Name = "textBox_Error_Message";
            this.textBox_Error_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Error_Message.Size = new System.Drawing.Size(696, 373);
            this.textBox_Error_Message.TabIndex = 33;
            // 
            // label_Error_Message
            // 
            this.label_Error_Message.AutoSize = true;
            this.label_Error_Message.Font = new System.Drawing.Font("PMingLiU", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Error_Message.Location = new System.Drawing.Point(291, 16);
            this.label_Error_Message.Name = "label_Error_Message";
            this.label_Error_Message.Size = new System.Drawing.Size(424, 96);
            this.label_Error_Message.TabIndex = 32;
            this.label_Error_Message.Text = "錯誤訊息";
            // 
            // panel_Hidden_Features
            // 
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Tool_Speed_Count);
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Operating_Speed_Count);
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Screw_Position_Count);
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Tool_Speed);
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Operating_Speed);
            this.panel_Hidden_Features.Controls.Add(this.label_Hidden_Features_Screw_Position);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Two_Axis_Positioning);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Continuous);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Knife_Cycle);
            this.panel_Hidden_Features.Controls.Add(this.button4);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Tool_JOG);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Turntable_Inversion);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Screw_Synchronization);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Reverse_Fixture);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Screw_Decline);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Tool_Rotation);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Forward_Wheel);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Fixture_Forward);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Screw_Rise);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Fixture_Synchronization);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Tool_Relax);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_PASS_Bottom_Dead);
            this.panel_Hidden_Features.Controls.Add(this.button_Hidden_Features_Motor_Start);
            this.panel_Hidden_Features.Location = new System.Drawing.Point(24, 12);
            this.panel_Hidden_Features.Name = "panel_Hidden_Features";
            this.panel_Hidden_Features.Size = new System.Drawing.Size(1148, 638);
            this.panel_Hidden_Features.TabIndex = 34;
            this.panel_Hidden_Features.Visible = false;
            // 
            // label_Hidden_Features_Tool_Speed_Count
            // 
            this.label_Hidden_Features_Tool_Speed_Count.AutoSize = true;
            this.label_Hidden_Features_Tool_Speed_Count.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Tool_Speed_Count.Location = new System.Drawing.Point(924, 65);
            this.label_Hidden_Features_Tool_Speed_Count.Name = "label_Hidden_Features_Tool_Speed_Count";
            this.label_Hidden_Features_Tool_Speed_Count.Size = new System.Drawing.Size(102, 37);
            this.label_Hidden_Features_Tool_Speed_Count.TabIndex = 36;
            this.label_Hidden_Features_Tool_Speed_Count.Text = "99999";
            // 
            // label_Hidden_Features_Operating_Speed_Count
            // 
            this.label_Hidden_Features_Operating_Speed_Count.AutoSize = true;
            this.label_Hidden_Features_Operating_Speed_Count.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Operating_Speed_Count.Location = new System.Drawing.Point(935, 425);
            this.label_Hidden_Features_Operating_Speed_Count.Name = "label_Hidden_Features_Operating_Speed_Count";
            this.label_Hidden_Features_Operating_Speed_Count.Size = new System.Drawing.Size(68, 37);
            this.label_Hidden_Features_Operating_Speed_Count.TabIndex = 36;
            this.label_Hidden_Features_Operating_Speed_Count.Text = "999";
            // 
            // label_Hidden_Features_Screw_Position_Count
            // 
            this.label_Hidden_Features_Screw_Position_Count.AutoSize = true;
            this.label_Hidden_Features_Screw_Position_Count.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Screw_Position_Count.Location = new System.Drawing.Point(77, 430);
            this.label_Hidden_Features_Screw_Position_Count.Name = "label_Hidden_Features_Screw_Position_Count";
            this.label_Hidden_Features_Screw_Position_Count.Size = new System.Drawing.Size(94, 37);
            this.label_Hidden_Features_Screw_Position_Count.TabIndex = 36;
            this.label_Hidden_Features_Screw_Position_Count.Text = "999.9";
            this.label_Hidden_Features_Screw_Position_Count.DoubleClick += new System.EventHandler(this.label_Hidden_Features_Screw_Position_Count_DoubleClick);
            this.label_Hidden_Features_Screw_Position_Count.Click += new System.EventHandler(this.label_Hidden_Features_Screw_Position_Count_Click);
            // 
            // label_Hidden_Features_Tool_Speed
            // 
            this.label_Hidden_Features_Tool_Speed.AutoSize = true;
            this.label_Hidden_Features_Tool_Speed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Tool_Speed.Location = new System.Drawing.Point(892, 23);
            this.label_Hidden_Features_Tool_Speed.Name = "label_Hidden_Features_Tool_Speed";
            this.label_Hidden_Features_Tool_Speed.Size = new System.Drawing.Size(165, 37);
            this.label_Hidden_Features_Tool_Speed.TabIndex = 36;
            this.label_Hidden_Features_Tool_Speed.Text = "刀具轉速";
            // 
            // label_Hidden_Features_Operating_Speed
            // 
            this.label_Hidden_Features_Operating_Speed.AutoSize = true;
            this.label_Hidden_Features_Operating_Speed.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Operating_Speed.Location = new System.Drawing.Point(894, 382);
            this.label_Hidden_Features_Operating_Speed.Name = "label_Hidden_Features_Operating_Speed";
            this.label_Hidden_Features_Operating_Speed.Size = new System.Drawing.Size(165, 37);
            this.label_Hidden_Features_Operating_Speed.TabIndex = 36;
            this.label_Hidden_Features_Operating_Speed.Text = "運轉速度";
            // 
            // label_Hidden_Features_Screw_Position
            // 
            this.label_Hidden_Features_Screw_Position.AutoSize = true;
            this.label_Hidden_Features_Screw_Position.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Hidden_Features_Screw_Position.Location = new System.Drawing.Point(45, 388);
            this.label_Hidden_Features_Screw_Position.Name = "label_Hidden_Features_Screw_Position";
            this.label_Hidden_Features_Screw_Position.Size = new System.Drawing.Size(165, 37);
            this.label_Hidden_Features_Screw_Position.TabIndex = 36;
            this.label_Hidden_Features_Screw_Position.Text = "螺桿位置";
            // 
            // button_Hidden_Features_Two_Axis_Positioning
            // 
            this.button_Hidden_Features_Two_Axis_Positioning.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Two_Axis_Positioning.Location = new System.Drawing.Point(874, 519);
            this.button_Hidden_Features_Two_Axis_Positioning.Name = "button_Hidden_Features_Two_Axis_Positioning";
            this.button_Hidden_Features_Two_Axis_Positioning.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Two_Axis_Positioning.TabIndex = 35;
            this.button_Hidden_Features_Two_Axis_Positioning.Text = "兩軸定位";
            this.button_Hidden_Features_Two_Axis_Positioning.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Two_Axis_Positioning.Click += new System.EventHandler(this.button_Hidden_Features_Two_Axis_Positioning_Click);
            // 
            // button_Hidden_Features_Continuous
            // 
            this.button_Hidden_Features_Continuous.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Continuous.Location = new System.Drawing.Point(599, 520);
            this.button_Hidden_Features_Continuous.Name = "button_Hidden_Features_Continuous";
            this.button_Hidden_Features_Continuous.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Continuous.TabIndex = 35;
            this.button_Hidden_Features_Continuous.Text = "連續";
            this.button_Hidden_Features_Continuous.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Continuous.Click += new System.EventHandler(this.button_Hidden_Features_Continuous_Click);
            // 
            // button_Hidden_Features_Knife_Cycle
            // 
            this.button_Hidden_Features_Knife_Cycle.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Knife_Cycle.Location = new System.Drawing.Point(316, 519);
            this.button_Hidden_Features_Knife_Cycle.Name = "button_Hidden_Features_Knife_Cycle";
            this.button_Hidden_Features_Knife_Cycle.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Knife_Cycle.TabIndex = 35;
            this.button_Hidden_Features_Knife_Cycle.Text = "刀一循環";
            this.button_Hidden_Features_Knife_Cycle.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Knife_Cycle.Click += new System.EventHandler(this.button_Hidden_Features_Knife_Cycle_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(31, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 65);
            this.button4.TabIndex = 35;
            this.button4.Text = "原點復歸";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_Hidden_Features_Tool_JOG
            // 
            this.button_Hidden_Features_Tool_JOG.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Tool_JOG.Location = new System.Drawing.Point(874, 262);
            this.button_Hidden_Features_Tool_JOG.Name = "button_Hidden_Features_Tool_JOG";
            this.button_Hidden_Features_Tool_JOG.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Tool_JOG.TabIndex = 35;
            this.button_Hidden_Features_Tool_JOG.Text = "刀具JOG";
            this.button_Hidden_Features_Tool_JOG.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Tool_JOG.Click += new System.EventHandler(this.button_Hidden_Features_Tool_JOG_Click);
            // 
            // button_Hidden_Features_Turntable_Inversion
            // 
            this.button_Hidden_Features_Turntable_Inversion.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Turntable_Inversion.Location = new System.Drawing.Point(599, 263);
            this.button_Hidden_Features_Turntable_Inversion.Name = "button_Hidden_Features_Turntable_Inversion";
            this.button_Hidden_Features_Turntable_Inversion.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Turntable_Inversion.TabIndex = 35;
            this.button_Hidden_Features_Turntable_Inversion.Text = "轉盤反轉";
            this.button_Hidden_Features_Turntable_Inversion.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Turntable_Inversion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Turntable_Inversion_MouseDown);
            this.button_Hidden_Features_Turntable_Inversion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Turntable_Inversion_MouseUp);
            // 
            // button_Hidden_Features_Screw_Synchronization
            // 
            this.button_Hidden_Features_Screw_Synchronization.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Screw_Synchronization.Location = new System.Drawing.Point(316, 390);
            this.button_Hidden_Features_Screw_Synchronization.Name = "button_Hidden_Features_Screw_Synchronization";
            this.button_Hidden_Features_Screw_Synchronization.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Screw_Synchronization.TabIndex = 35;
            this.button_Hidden_Features_Screw_Synchronization.Text = "螺桿同步";
            this.button_Hidden_Features_Screw_Synchronization.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Screw_Synchronization.Click += new System.EventHandler(this.button_Hidden_Features_Screw_Synchronization_Click);
            // 
            // button_Hidden_Features_Reverse_Fixture
            // 
            this.button_Hidden_Features_Reverse_Fixture.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Reverse_Fixture.Location = new System.Drawing.Point(316, 262);
            this.button_Hidden_Features_Reverse_Fixture.Name = "button_Hidden_Features_Reverse_Fixture";
            this.button_Hidden_Features_Reverse_Fixture.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Reverse_Fixture.TabIndex = 35;
            this.button_Hidden_Features_Reverse_Fixture.Text = "夾具反轉";
            this.button_Hidden_Features_Reverse_Fixture.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Reverse_Fixture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Reverse_Fixture_MouseDown);
            this.button_Hidden_Features_Reverse_Fixture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Reverse_Fixture_MouseUp);
            // 
            // button_Hidden_Features_Screw_Decline
            // 
            this.button_Hidden_Features_Screw_Decline.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Screw_Decline.Location = new System.Drawing.Point(31, 262);
            this.button_Hidden_Features_Screw_Decline.Name = "button_Hidden_Features_Screw_Decline";
            this.button_Hidden_Features_Screw_Decline.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Screw_Decline.TabIndex = 35;
            this.button_Hidden_Features_Screw_Decline.Text = "螺桿下降";
            this.button_Hidden_Features_Screw_Decline.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Screw_Decline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Screw_Decline_MouseDown);
            this.button_Hidden_Features_Screw_Decline.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Screw_Decline_MouseUp);
            // 
            // button_Hidden_Features_Tool_Rotation
            // 
            this.button_Hidden_Features_Tool_Rotation.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Tool_Rotation.Location = new System.Drawing.Point(874, 138);
            this.button_Hidden_Features_Tool_Rotation.Name = "button_Hidden_Features_Tool_Rotation";
            this.button_Hidden_Features_Tool_Rotation.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Tool_Rotation.TabIndex = 35;
            this.button_Hidden_Features_Tool_Rotation.Text = "刀具旋轉";
            this.button_Hidden_Features_Tool_Rotation.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Tool_Rotation.Click += new System.EventHandler(this.button_Hidden_Features_Tool_Rotation_Click);
            // 
            // button_Hidden_Features_Forward_Wheel
            // 
            this.button_Hidden_Features_Forward_Wheel.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Forward_Wheel.Location = new System.Drawing.Point(599, 139);
            this.button_Hidden_Features_Forward_Wheel.Name = "button_Hidden_Features_Forward_Wheel";
            this.button_Hidden_Features_Forward_Wheel.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Forward_Wheel.TabIndex = 35;
            this.button_Hidden_Features_Forward_Wheel.Text = "轉盤正轉";
            this.button_Hidden_Features_Forward_Wheel.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Forward_Wheel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Forward_Wheel_MouseDown);
            this.button_Hidden_Features_Forward_Wheel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Forward_Wheel_MouseUp);
            // 
            // button_Hidden_Features_Fixture_Forward
            // 
            this.button_Hidden_Features_Fixture_Forward.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Fixture_Forward.Location = new System.Drawing.Point(316, 138);
            this.button_Hidden_Features_Fixture_Forward.Name = "button_Hidden_Features_Fixture_Forward";
            this.button_Hidden_Features_Fixture_Forward.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Fixture_Forward.TabIndex = 35;
            this.button_Hidden_Features_Fixture_Forward.Text = "夾具正轉";
            this.button_Hidden_Features_Fixture_Forward.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Fixture_Forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Fixture_Forward_MouseDown);
            this.button_Hidden_Features_Fixture_Forward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Fixture_Forward_MouseUp);
            // 
            // button_Hidden_Features_Screw_Rise
            // 
            this.button_Hidden_Features_Screw_Rise.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Screw_Rise.Location = new System.Drawing.Point(31, 138);
            this.button_Hidden_Features_Screw_Rise.Name = "button_Hidden_Features_Screw_Rise";
            this.button_Hidden_Features_Screw_Rise.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Screw_Rise.TabIndex = 35;
            this.button_Hidden_Features_Screw_Rise.Text = "螺桿上升";
            this.button_Hidden_Features_Screw_Rise.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Screw_Rise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Screw_Rise_MouseDown);
            this.button_Hidden_Features_Screw_Rise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Hidden_Features_Screw_Rise_MouseUp);
            // 
            // button_Hidden_Features_Fixture_Synchronization
            // 
            this.button_Hidden_Features_Fixture_Synchronization.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Fixture_Synchronization.Location = new System.Drawing.Point(599, 387);
            this.button_Hidden_Features_Fixture_Synchronization.Name = "button_Hidden_Features_Fixture_Synchronization";
            this.button_Hidden_Features_Fixture_Synchronization.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Fixture_Synchronization.TabIndex = 35;
            this.button_Hidden_Features_Fixture_Synchronization.Text = "夾具同步";
            this.button_Hidden_Features_Fixture_Synchronization.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Fixture_Synchronization.Click += new System.EventHandler(this.button_Hidden_Features_Fixture_Synchronization_Click);
            // 
            // button_Hidden_Features_Tool_Relax
            // 
            this.button_Hidden_Features_Tool_Relax.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Tool_Relax.Location = new System.Drawing.Point(599, 27);
            this.button_Hidden_Features_Tool_Relax.Name = "button_Hidden_Features_Tool_Relax";
            this.button_Hidden_Features_Tool_Relax.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Tool_Relax.TabIndex = 35;
            this.button_Hidden_Features_Tool_Relax.Text = "刀具放鬆";
            this.button_Hidden_Features_Tool_Relax.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Tool_Relax.Click += new System.EventHandler(this.button_Hidden_Features_Tool_Relax_Click);
            // 
            // button_Hidden_Features_PASS_Bottom_Dead
            // 
            this.button_Hidden_Features_PASS_Bottom_Dead.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_PASS_Bottom_Dead.Location = new System.Drawing.Point(316, 26);
            this.button_Hidden_Features_PASS_Bottom_Dead.Name = "button_Hidden_Features_PASS_Bottom_Dead";
            this.button_Hidden_Features_PASS_Bottom_Dead.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_PASS_Bottom_Dead.TabIndex = 35;
            this.button_Hidden_Features_PASS_Bottom_Dead.Text = "PASS下死";
            this.button_Hidden_Features_PASS_Bottom_Dead.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_PASS_Bottom_Dead.Click += new System.EventHandler(this.button_Hidden_Features_PASS_Bottom_Dead_Click);
            // 
            // button_Hidden_Features_Motor_Start
            // 
            this.button_Hidden_Features_Motor_Start.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Hidden_Features_Motor_Start.Location = new System.Drawing.Point(31, 26);
            this.button_Hidden_Features_Motor_Start.Name = "button_Hidden_Features_Motor_Start";
            this.button_Hidden_Features_Motor_Start.Size = new System.Drawing.Size(199, 65);
            this.button_Hidden_Features_Motor_Start.TabIndex = 35;
            this.button_Hidden_Features_Motor_Start.Text = "馬達啟動";
            this.button_Hidden_Features_Motor_Start.UseVisualStyleBackColor = true;
            this.button_Hidden_Features_Motor_Start.Click += new System.EventHandler(this.button_Hidden_Features_Motor_Start_Click);
            // 
            // panel_I_O_Table
            // 
            this.panel_I_O_Table.Controls.Add(this.button_I_O_Table_Switching);
            this.panel_I_O_Table.Controls.Add(this.button_I_O_Table_Main);
            this.panel_I_O_Table.Controls.Add(this.panel_I_O_Table_Y);
            this.panel_I_O_Table.Controls.Add(this.panel_I_O_Table_X);
            this.panel_I_O_Table.Location = new System.Drawing.Point(24, 12);
            this.panel_I_O_Table.Name = "panel_I_O_Table";
            this.panel_I_O_Table.Size = new System.Drawing.Size(1148, 638);
            this.panel_I_O_Table.TabIndex = 35;
            this.panel_I_O_Table.Visible = false;
            // 
            // button_I_O_Table_Switching
            // 
            this.button_I_O_Table_Switching.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_I_O_Table_Switching.Location = new System.Drawing.Point(753, 566);
            this.button_I_O_Table_Switching.Name = "button_I_O_Table_Switching";
            this.button_I_O_Table_Switching.Size = new System.Drawing.Size(227, 69);
            this.button_I_O_Table_Switching.TabIndex = 37;
            this.button_I_O_Table_Switching.Text = "下一頁(Y點位)";
            this.button_I_O_Table_Switching.UseVisualStyleBackColor = true;
            this.button_I_O_Table_Switching.Click += new System.EventHandler(this.button_I_O_Table_Switching_Click);
            // 
            // button_I_O_Table_Main
            // 
            this.button_I_O_Table_Main.Font = new System.Drawing.Font("PMingLiU", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_I_O_Table_Main.Location = new System.Drawing.Point(411, 565);
            this.button_I_O_Table_Main.Name = "button_I_O_Table_Main";
            this.button_I_O_Table_Main.Size = new System.Drawing.Size(204, 69);
            this.button_I_O_Table_Main.TabIndex = 36;
            this.button_I_O_Table_Main.Text = "回主畫面";
            this.button_I_O_Table_Main.UseVisualStyleBackColor = true;
            this.button_I_O_Table_Main.Click += new System.EventHandler(this.button_I_O_Table_Main_Click);
            // 
            // panel_I_O_Table_Y
            // 
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y101);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y100);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y112);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y012);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y104);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y004);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y111);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y011);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y103);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y003);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y115);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y015);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y107);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y007);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y110);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y010);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y102);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y002);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y114);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y014);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y106);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y006);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y109);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y009);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y001);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y113);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y013);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y105);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y005);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y108);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y008);
            this.panel_I_O_Table_Y.Controls.Add(this.checkBox_Y000);
            this.panel_I_O_Table_Y.Location = new System.Drawing.Point(6, 14);
            this.panel_I_O_Table_Y.Name = "panel_I_O_Table_Y";
            this.panel_I_O_Table_Y.Size = new System.Drawing.Size(1139, 548);
            this.panel_I_O_Table_Y.TabIndex = 27;
            this.panel_I_O_Table_Y.Visible = false;
            // 
            // checkBox_Y101
            // 
            this.checkBox_Y101.AllowDrop = true;
            this.checkBox_Y101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y101.AutoCheck = false;
            this.checkBox_Y101.AutoSize = true;
            this.checkBox_Y101.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y101.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y101.Location = new System.Drawing.Point(580, 78);
            this.checkBox_Y101.Name = "checkBox_Y101";
            this.checkBox_Y101.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y101.TabIndex = 61;
            this.checkBox_Y101.Text = "Y101";
            this.checkBox_Y101.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y100
            // 
            this.checkBox_Y100.AllowDrop = true;
            this.checkBox_Y100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y100.AutoCheck = false;
            this.checkBox_Y100.AutoSize = true;
            this.checkBox_Y100.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y100.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y100.Location = new System.Drawing.Point(580, 8);
            this.checkBox_Y100.Name = "checkBox_Y100";
            this.checkBox_Y100.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y100.TabIndex = 69;
            this.checkBox_Y100.Text = "Y100";
            this.checkBox_Y100.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y112
            // 
            this.checkBox_Y112.AllowDrop = true;
            this.checkBox_Y112.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y112.AutoCheck = false;
            this.checkBox_Y112.AutoSize = true;
            this.checkBox_Y112.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y112.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y112.Location = new System.Drawing.Point(866, 288);
            this.checkBox_Y112.Name = "checkBox_Y112";
            this.checkBox_Y112.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y112.TabIndex = 79;
            this.checkBox_Y112.Text = "Y112";
            this.checkBox_Y112.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y012
            // 
            this.checkBox_Y012.AllowDrop = true;
            this.checkBox_Y012.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y012.AutoCheck = false;
            this.checkBox_Y012.AutoSize = true;
            this.checkBox_Y012.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y012.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y012.Location = new System.Drawing.Point(295, 288);
            this.checkBox_Y012.Name = "checkBox_Y012";
            this.checkBox_Y012.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y012.TabIndex = 78;
            this.checkBox_Y012.Text = "Y012";
            this.checkBox_Y012.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y104
            // 
            this.checkBox_Y104.AllowDrop = true;
            this.checkBox_Y104.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y104.AutoCheck = false;
            this.checkBox_Y104.AutoSize = true;
            this.checkBox_Y104.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y104.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y104.Location = new System.Drawing.Point(580, 288);
            this.checkBox_Y104.Name = "checkBox_Y104";
            this.checkBox_Y104.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y104.TabIndex = 81;
            this.checkBox_Y104.Text = "Y104";
            this.checkBox_Y104.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y004
            // 
            this.checkBox_Y004.AllowDrop = true;
            this.checkBox_Y004.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y004.AutoCheck = false;
            this.checkBox_Y004.AutoSize = true;
            this.checkBox_Y004.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y004.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y004.Location = new System.Drawing.Point(10, 288);
            this.checkBox_Y004.Name = "checkBox_Y004";
            this.checkBox_Y004.Size = new System.Drawing.Size(190, 28);
            this.checkBox_Y004.TabIndex = 80;
            this.checkBox_Y004.Text = "Y004三色燈(黃)";
            this.checkBox_Y004.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y111
            // 
            this.checkBox_Y111.AllowDrop = true;
            this.checkBox_Y111.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y111.AutoCheck = false;
            this.checkBox_Y111.AutoSize = true;
            this.checkBox_Y111.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y111.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y111.Location = new System.Drawing.Point(866, 218);
            this.checkBox_Y111.Name = "checkBox_Y111";
            this.checkBox_Y111.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y111.TabIndex = 75;
            this.checkBox_Y111.Text = "Y111";
            this.checkBox_Y111.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y011
            // 
            this.checkBox_Y011.AllowDrop = true;
            this.checkBox_Y011.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y011.AutoCheck = false;
            this.checkBox_Y011.AutoSize = true;
            this.checkBox_Y011.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y011.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y011.Location = new System.Drawing.Point(295, 218);
            this.checkBox_Y011.Name = "checkBox_Y011";
            this.checkBox_Y011.Size = new System.Drawing.Size(199, 28);
            this.checkBox_Y011.TabIndex = 74;
            this.checkBox_Y011.Text = "Y011空壓電磁閥";
            this.checkBox_Y011.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y103
            // 
            this.checkBox_Y103.AllowDrop = true;
            this.checkBox_Y103.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y103.AutoCheck = false;
            this.checkBox_Y103.AutoSize = true;
            this.checkBox_Y103.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y103.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y103.Location = new System.Drawing.Point(580, 218);
            this.checkBox_Y103.Name = "checkBox_Y103";
            this.checkBox_Y103.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y103.TabIndex = 77;
            this.checkBox_Y103.Text = "Y103";
            this.checkBox_Y103.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y003
            // 
            this.checkBox_Y003.AllowDrop = true;
            this.checkBox_Y003.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y003.AutoCheck = false;
            this.checkBox_Y003.AutoSize = true;
            this.checkBox_Y003.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y003.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y003.Location = new System.Drawing.Point(10, 218);
            this.checkBox_Y003.Name = "checkBox_Y003";
            this.checkBox_Y003.Size = new System.Drawing.Size(190, 28);
            this.checkBox_Y003.TabIndex = 76;
            this.checkBox_Y003.Text = "Y003三色燈(紅)";
            this.checkBox_Y003.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y115
            // 
            this.checkBox_Y115.AllowDrop = true;
            this.checkBox_Y115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y115.AutoCheck = false;
            this.checkBox_Y115.AutoSize = true;
            this.checkBox_Y115.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y115.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y115.Location = new System.Drawing.Point(866, 498);
            this.checkBox_Y115.Name = "checkBox_Y115";
            this.checkBox_Y115.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y115.TabIndex = 87;
            this.checkBox_Y115.Text = "Y115";
            this.checkBox_Y115.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y015
            // 
            this.checkBox_Y015.AllowDrop = true;
            this.checkBox_Y015.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y015.AutoCheck = false;
            this.checkBox_Y015.AutoSize = true;
            this.checkBox_Y015.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y015.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y015.Location = new System.Drawing.Point(295, 498);
            this.checkBox_Y015.Name = "checkBox_Y015";
            this.checkBox_Y015.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y015.TabIndex = 86;
            this.checkBox_Y015.Text = "Y015";
            this.checkBox_Y015.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y107
            // 
            this.checkBox_Y107.AllowDrop = true;
            this.checkBox_Y107.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y107.AutoCheck = false;
            this.checkBox_Y107.AutoSize = true;
            this.checkBox_Y107.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y107.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y107.Location = new System.Drawing.Point(580, 498);
            this.checkBox_Y107.Name = "checkBox_Y107";
            this.checkBox_Y107.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y107.TabIndex = 89;
            this.checkBox_Y107.Text = "Y107";
            this.checkBox_Y107.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y007
            // 
            this.checkBox_Y007.AllowDrop = true;
            this.checkBox_Y007.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y007.AutoCheck = false;
            this.checkBox_Y007.AutoSize = true;
            this.checkBox_Y007.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y007.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y007.Location = new System.Drawing.Point(10, 498);
            this.checkBox_Y007.Name = "checkBox_Y007";
            this.checkBox_Y007.Size = new System.Drawing.Size(291, 28);
            this.checkBox_Y007.TabIndex = 88;
            this.checkBox_Y007.Text = "Y007轉盤馬達電磁接觸器";
            this.checkBox_Y007.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y110
            // 
            this.checkBox_Y110.AllowDrop = true;
            this.checkBox_Y110.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y110.AutoCheck = false;
            this.checkBox_Y110.AutoSize = true;
            this.checkBox_Y110.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y110.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y110.Location = new System.Drawing.Point(866, 148);
            this.checkBox_Y110.Name = "checkBox_Y110";
            this.checkBox_Y110.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y110.TabIndex = 83;
            this.checkBox_Y110.Text = "Y110";
            this.checkBox_Y110.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y010
            // 
            this.checkBox_Y010.AllowDrop = true;
            this.checkBox_Y010.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y010.AutoCheck = false;
            this.checkBox_Y010.AutoSize = true;
            this.checkBox_Y010.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y010.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y010.Location = new System.Drawing.Point(295, 148);
            this.checkBox_Y010.Name = "checkBox_Y010";
            this.checkBox_Y010.Size = new System.Drawing.Size(245, 28);
            this.checkBox_Y010.TabIndex = 82;
            this.checkBox_Y010.Text = "Y010震動盤電磁開關";
            this.checkBox_Y010.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y102
            // 
            this.checkBox_Y102.AllowDrop = true;
            this.checkBox_Y102.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y102.AutoCheck = false;
            this.checkBox_Y102.AutoSize = true;
            this.checkBox_Y102.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y102.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y102.Location = new System.Drawing.Point(580, 148);
            this.checkBox_Y102.Name = "checkBox_Y102";
            this.checkBox_Y102.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y102.TabIndex = 85;
            this.checkBox_Y102.Text = "Y102";
            this.checkBox_Y102.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y002
            // 
            this.checkBox_Y002.AllowDrop = true;
            this.checkBox_Y002.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y002.AutoCheck = false;
            this.checkBox_Y002.AutoSize = true;
            this.checkBox_Y002.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y002.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y002.Location = new System.Drawing.Point(10, 148);
            this.checkBox_Y002.Name = "checkBox_Y002";
            this.checkBox_Y002.Size = new System.Drawing.Size(153, 28);
            this.checkBox_Y002.TabIndex = 84;
            this.checkBox_Y002.Text = "Y002蜂鳴器";
            this.checkBox_Y002.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y114
            // 
            this.checkBox_Y114.AllowDrop = true;
            this.checkBox_Y114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y114.AutoCheck = false;
            this.checkBox_Y114.AutoSize = true;
            this.checkBox_Y114.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y114.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y114.Location = new System.Drawing.Point(866, 428);
            this.checkBox_Y114.Name = "checkBox_Y114";
            this.checkBox_Y114.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y114.TabIndex = 63;
            this.checkBox_Y114.Text = "Y114";
            this.checkBox_Y114.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y014
            // 
            this.checkBox_Y014.AllowDrop = true;
            this.checkBox_Y014.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y014.AutoCheck = false;
            this.checkBox_Y014.AutoSize = true;
            this.checkBox_Y014.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y014.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y014.Location = new System.Drawing.Point(295, 428);
            this.checkBox_Y014.Name = "checkBox_Y014";
            this.checkBox_Y014.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y014.TabIndex = 62;
            this.checkBox_Y014.Text = "Y014";
            this.checkBox_Y014.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y106
            // 
            this.checkBox_Y106.AllowDrop = true;
            this.checkBox_Y106.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y106.AutoCheck = false;
            this.checkBox_Y106.AutoSize = true;
            this.checkBox_Y106.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y106.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y106.Location = new System.Drawing.Point(580, 428);
            this.checkBox_Y106.Name = "checkBox_Y106";
            this.checkBox_Y106.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y106.TabIndex = 65;
            this.checkBox_Y106.Text = "Y106";
            this.checkBox_Y106.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y006
            // 
            this.checkBox_Y006.AllowDrop = true;
            this.checkBox_Y006.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y006.AutoCheck = false;
            this.checkBox_Y006.AutoSize = true;
            this.checkBox_Y006.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y006.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y006.Location = new System.Drawing.Point(10, 428);
            this.checkBox_Y006.Name = "checkBox_Y006";
            this.checkBox_Y006.Size = new System.Drawing.Size(291, 28);
            this.checkBox_Y006.TabIndex = 64;
            this.checkBox_Y006.Text = "Y006刀具馬達電磁接觸器";
            this.checkBox_Y006.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y109
            // 
            this.checkBox_Y109.AllowDrop = true;
            this.checkBox_Y109.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y109.AutoCheck = false;
            this.checkBox_Y109.AutoSize = true;
            this.checkBox_Y109.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y109.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y109.Location = new System.Drawing.Point(866, 78);
            this.checkBox_Y109.Name = "checkBox_Y109";
            this.checkBox_Y109.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y109.TabIndex = 59;
            this.checkBox_Y109.Text = "Y109";
            this.checkBox_Y109.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y009
            // 
            this.checkBox_Y009.AllowDrop = true;
            this.checkBox_Y009.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y009.AutoCheck = false;
            this.checkBox_Y009.AutoSize = true;
            this.checkBox_Y009.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y009.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y009.Location = new System.Drawing.Point(295, 78);
            this.checkBox_Y009.Name = "checkBox_Y009";
            this.checkBox_Y009.Size = new System.Drawing.Size(291, 28);
            this.checkBox_Y009.TabIndex = 58;
            this.checkBox_Y009.Text = "Y009夾具馬達電磁接觸器";
            this.checkBox_Y009.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y001
            // 
            this.checkBox_Y001.AllowDrop = true;
            this.checkBox_Y001.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y001.AutoCheck = false;
            this.checkBox_Y001.AutoSize = true;
            this.checkBox_Y001.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y001.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y001.Location = new System.Drawing.Point(10, 78);
            this.checkBox_Y001.Name = "checkBox_Y001";
            this.checkBox_Y001.Size = new System.Drawing.Size(199, 28);
            this.checkBox_Y001.TabIndex = 60;
            this.checkBox_Y001.Text = "Y001停止按鈕燈";
            this.checkBox_Y001.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y113
            // 
            this.checkBox_Y113.AllowDrop = true;
            this.checkBox_Y113.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y113.AutoCheck = false;
            this.checkBox_Y113.AutoSize = true;
            this.checkBox_Y113.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y113.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y113.Location = new System.Drawing.Point(866, 358);
            this.checkBox_Y113.Name = "checkBox_Y113";
            this.checkBox_Y113.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y113.TabIndex = 71;
            this.checkBox_Y113.Text = "Y113";
            this.checkBox_Y113.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y013
            // 
            this.checkBox_Y013.AllowDrop = true;
            this.checkBox_Y013.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y013.AutoCheck = false;
            this.checkBox_Y013.AutoSize = true;
            this.checkBox_Y013.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y013.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y013.Location = new System.Drawing.Point(295, 358);
            this.checkBox_Y013.Name = "checkBox_Y013";
            this.checkBox_Y013.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y013.TabIndex = 70;
            this.checkBox_Y013.Text = "Y013";
            this.checkBox_Y013.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y105
            // 
            this.checkBox_Y105.AllowDrop = true;
            this.checkBox_Y105.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y105.AutoCheck = false;
            this.checkBox_Y105.AutoSize = true;
            this.checkBox_Y105.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y105.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y105.Location = new System.Drawing.Point(580, 358);
            this.checkBox_Y105.Name = "checkBox_Y105";
            this.checkBox_Y105.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y105.TabIndex = 73;
            this.checkBox_Y105.Text = "Y105";
            this.checkBox_Y105.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y005
            // 
            this.checkBox_Y005.AllowDrop = true;
            this.checkBox_Y005.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y005.AutoCheck = false;
            this.checkBox_Y005.AutoSize = true;
            this.checkBox_Y005.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y005.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y005.Location = new System.Drawing.Point(10, 358);
            this.checkBox_Y005.Name = "checkBox_Y005";
            this.checkBox_Y005.Size = new System.Drawing.Size(190, 28);
            this.checkBox_Y005.TabIndex = 72;
            this.checkBox_Y005.Text = "Y005三色燈(綠)";
            this.checkBox_Y005.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y108
            // 
            this.checkBox_Y108.AllowDrop = true;
            this.checkBox_Y108.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y108.AutoCheck = false;
            this.checkBox_Y108.AutoSize = true;
            this.checkBox_Y108.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y108.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y108.Location = new System.Drawing.Point(866, 8);
            this.checkBox_Y108.Name = "checkBox_Y108";
            this.checkBox_Y108.Size = new System.Drawing.Size(84, 28);
            this.checkBox_Y108.TabIndex = 67;
            this.checkBox_Y108.Text = "Y108";
            this.checkBox_Y108.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y008
            // 
            this.checkBox_Y008.AllowDrop = true;
            this.checkBox_Y008.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y008.AutoCheck = false;
            this.checkBox_Y008.AutoSize = true;
            this.checkBox_Y008.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y008.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y008.Location = new System.Drawing.Point(295, 8);
            this.checkBox_Y008.Name = "checkBox_Y008";
            this.checkBox_Y008.Size = new System.Drawing.Size(291, 28);
            this.checkBox_Y008.TabIndex = 66;
            this.checkBox_Y008.Text = "Y008螺桿馬達電磁接觸器";
            this.checkBox_Y008.UseVisualStyleBackColor = true;
            // 
            // checkBox_Y000
            // 
            this.checkBox_Y000.AllowDrop = true;
            this.checkBox_Y000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_Y000.AutoCheck = false;
            this.checkBox_Y000.AutoSize = true;
            this.checkBox_Y000.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Y000.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_Y000.Location = new System.Drawing.Point(10, 8);
            this.checkBox_Y000.Name = "checkBox_Y000";
            this.checkBox_Y000.Size = new System.Drawing.Size(199, 28);
            this.checkBox_Y000.TabIndex = 68;
            this.checkBox_Y000.Text = "Y000啟動按鈕燈";
            this.checkBox_Y000.UseVisualStyleBackColor = true;
            // 
            // panel_I_O_Table_X
            // 
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X112);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X012);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X104);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X004);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X111);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X011);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X103);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X003);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X115);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X015);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X107);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X007);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X110);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X010);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X102);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X002);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X114);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X014);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X106);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X006);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X109);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X009);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X101);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X001);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X113);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X013);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X105);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X005);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X108);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X008);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X100);
            this.panel_I_O_Table_X.Controls.Add(this.checkBox_X000);
            this.panel_I_O_Table_X.Location = new System.Drawing.Point(6, 14);
            this.panel_I_O_Table_X.Name = "panel_I_O_Table_X";
            this.panel_I_O_Table_X.Size = new System.Drawing.Size(1139, 548);
            this.panel_I_O_Table_X.TabIndex = 26;
            // 
            // checkBox_X112
            // 
            this.checkBox_X112.AllowDrop = true;
            this.checkBox_X112.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X112.AutoCheck = false;
            this.checkBox_X112.AutoSize = true;
            this.checkBox_X112.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X112.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X112.Location = new System.Drawing.Point(865, 288);
            this.checkBox_X112.Name = "checkBox_X112";
            this.checkBox_X112.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X112.TabIndex = 47;
            this.checkBox_X112.Text = "X112";
            this.checkBox_X112.UseVisualStyleBackColor = true;
            // 
            // checkBox_X012
            // 
            this.checkBox_X012.AllowDrop = true;
            this.checkBox_X012.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X012.AutoCheck = false;
            this.checkBox_X012.AutoSize = true;
            this.checkBox_X012.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X012.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X012.Location = new System.Drawing.Point(295, 288);
            this.checkBox_X012.Name = "checkBox_X012";
            this.checkBox_X012.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X012.TabIndex = 46;
            this.checkBox_X012.Text = "X012";
            this.checkBox_X012.UseVisualStyleBackColor = true;
            // 
            // checkBox_X104
            // 
            this.checkBox_X104.AllowDrop = true;
            this.checkBox_X104.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X104.AutoCheck = false;
            this.checkBox_X104.AutoSize = true;
            this.checkBox_X104.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X104.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X104.Location = new System.Drawing.Point(580, 288);
            this.checkBox_X104.Name = "checkBox_X104";
            this.checkBox_X104.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X104.TabIndex = 49;
            this.checkBox_X104.Text = "X104";
            this.checkBox_X104.UseVisualStyleBackColor = true;
            // 
            // checkBox_X004
            // 
            this.checkBox_X004.AllowDrop = true;
            this.checkBox_X004.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X004.AutoCheck = false;
            this.checkBox_X004.AutoSize = true;
            this.checkBox_X004.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X004.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X004.Location = new System.Drawing.Point(10, 288);
            this.checkBox_X004.Name = "checkBox_X004";
            this.checkBox_X004.Size = new System.Drawing.Size(199, 28);
            this.checkBox_X004.TabIndex = 48;
            this.checkBox_X004.Text = "X004無料感測器";
            this.checkBox_X004.UseVisualStyleBackColor = true;
            // 
            // checkBox_X111
            // 
            this.checkBox_X111.AllowDrop = true;
            this.checkBox_X111.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X111.AutoCheck = false;
            this.checkBox_X111.AutoSize = true;
            this.checkBox_X111.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X111.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X111.Location = new System.Drawing.Point(865, 218);
            this.checkBox_X111.Name = "checkBox_X111";
            this.checkBox_X111.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X111.TabIndex = 43;
            this.checkBox_X111.Text = "X111";
            this.checkBox_X111.UseVisualStyleBackColor = true;
            // 
            // checkBox_X011
            // 
            this.checkBox_X011.AllowDrop = true;
            this.checkBox_X011.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X011.AutoCheck = false;
            this.checkBox_X011.AutoSize = true;
            this.checkBox_X011.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X011.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X011.Location = new System.Drawing.Point(295, 218);
            this.checkBox_X011.Name = "checkBox_X011";
            this.checkBox_X011.Size = new System.Drawing.Size(199, 28);
            this.checkBox_X011.TabIndex = 42;
            this.checkBox_X011.Text = "X011空壓感測器";
            this.checkBox_X011.UseVisualStyleBackColor = true;
            // 
            // checkBox_X103
            // 
            this.checkBox_X103.AllowDrop = true;
            this.checkBox_X103.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X103.AutoCheck = false;
            this.checkBox_X103.AutoSize = true;
            this.checkBox_X103.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X103.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X103.Location = new System.Drawing.Point(580, 218);
            this.checkBox_X103.Name = "checkBox_X103";
            this.checkBox_X103.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X103.TabIndex = 45;
            this.checkBox_X103.Text = "X103";
            this.checkBox_X103.UseVisualStyleBackColor = true;
            // 
            // checkBox_X003
            // 
            this.checkBox_X003.AllowDrop = true;
            this.checkBox_X003.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X003.AutoCheck = false;
            this.checkBox_X003.AutoSize = true;
            this.checkBox_X003.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X003.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X003.Location = new System.Drawing.Point(10, 218);
            this.checkBox_X003.Name = "checkBox_X003";
            this.checkBox_X003.Size = new System.Drawing.Size(199, 28);
            this.checkBox_X003.TabIndex = 44;
            this.checkBox_X003.Text = "X003滿料感測器";
            this.checkBox_X003.UseVisualStyleBackColor = true;
            // 
            // checkBox_X115
            // 
            this.checkBox_X115.AllowDrop = true;
            this.checkBox_X115.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X115.AutoCheck = false;
            this.checkBox_X115.AutoSize = true;
            this.checkBox_X115.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X115.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X115.Location = new System.Drawing.Point(865, 498);
            this.checkBox_X115.Name = "checkBox_X115";
            this.checkBox_X115.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X115.TabIndex = 55;
            this.checkBox_X115.Text = "X115";
            this.checkBox_X115.UseVisualStyleBackColor = true;
            // 
            // checkBox_X015
            // 
            this.checkBox_X015.AllowDrop = true;
            this.checkBox_X015.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X015.AutoCheck = false;
            this.checkBox_X015.AutoSize = true;
            this.checkBox_X015.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X015.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X015.Location = new System.Drawing.Point(295, 498);
            this.checkBox_X015.Name = "checkBox_X015";
            this.checkBox_X015.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X015.TabIndex = 54;
            this.checkBox_X015.Text = "X015";
            this.checkBox_X015.UseVisualStyleBackColor = true;
            // 
            // checkBox_X107
            // 
            this.checkBox_X107.AllowDrop = true;
            this.checkBox_X107.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X107.AutoCheck = false;
            this.checkBox_X107.AutoSize = true;
            this.checkBox_X107.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X107.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X107.Location = new System.Drawing.Point(580, 498);
            this.checkBox_X107.Name = "checkBox_X107";
            this.checkBox_X107.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X107.TabIndex = 57;
            this.checkBox_X107.Text = "X107";
            this.checkBox_X107.UseVisualStyleBackColor = true;
            // 
            // checkBox_X007
            // 
            this.checkBox_X007.AllowDrop = true;
            this.checkBox_X007.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X007.AutoCheck = false;
            this.checkBox_X007.AutoSize = true;
            this.checkBox_X007.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X007.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X007.Location = new System.Drawing.Point(10, 498);
            this.checkBox_X007.Name = "checkBox_X007";
            this.checkBox_X007.Size = new System.Drawing.Size(268, 28);
            this.checkBox_X007.TabIndex = 56;
            this.checkBox_X007.Text = "X007夾具後死點感測器";
            this.checkBox_X007.UseVisualStyleBackColor = true;
            // 
            // checkBox_X110
            // 
            this.checkBox_X110.AllowDrop = true;
            this.checkBox_X110.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X110.AutoCheck = false;
            this.checkBox_X110.AutoSize = true;
            this.checkBox_X110.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X110.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X110.Location = new System.Drawing.Point(865, 148);
            this.checkBox_X110.Name = "checkBox_X110";
            this.checkBox_X110.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X110.TabIndex = 51;
            this.checkBox_X110.Text = "X110";
            this.checkBox_X110.UseVisualStyleBackColor = true;
            // 
            // checkBox_X010
            // 
            this.checkBox_X010.AllowDrop = true;
            this.checkBox_X010.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X010.AutoCheck = false;
            this.checkBox_X010.AutoSize = true;
            this.checkBox_X010.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X010.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X010.Location = new System.Drawing.Point(295, 148);
            this.checkBox_X010.Name = "checkBox_X010";
            this.checkBox_X010.Size = new System.Drawing.Size(245, 28);
            this.checkBox_X010.TabIndex = 50;
            this.checkBox_X010.Text = "X010轉盤原點感測器";
            this.checkBox_X010.UseVisualStyleBackColor = true;
            // 
            // checkBox_X102
            // 
            this.checkBox_X102.AllowDrop = true;
            this.checkBox_X102.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X102.AutoCheck = false;
            this.checkBox_X102.AutoSize = true;
            this.checkBox_X102.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X102.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X102.Location = new System.Drawing.Point(580, 148);
            this.checkBox_X102.Name = "checkBox_X102";
            this.checkBox_X102.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X102.TabIndex = 53;
            this.checkBox_X102.Text = "X102";
            this.checkBox_X102.UseVisualStyleBackColor = true;
            // 
            // checkBox_X002
            // 
            this.checkBox_X002.AllowDrop = true;
            this.checkBox_X002.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X002.AutoCheck = false;
            this.checkBox_X002.AutoSize = true;
            this.checkBox_X002.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X002.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X002.Location = new System.Drawing.Point(10, 148);
            this.checkBox_X002.Name = "checkBox_X002";
            this.checkBox_X002.Size = new System.Drawing.Size(227, 28);
            this.checkBox_X002.TabIndex = 52;
            this.checkBox_X002.Text = "X002即停按鈕(B接)";
            this.checkBox_X002.UseVisualStyleBackColor = true;
            // 
            // checkBox_X114
            // 
            this.checkBox_X114.AllowDrop = true;
            this.checkBox_X114.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X114.AutoCheck = false;
            this.checkBox_X114.AutoSize = true;
            this.checkBox_X114.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X114.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X114.Location = new System.Drawing.Point(865, 428);
            this.checkBox_X114.Name = "checkBox_X114";
            this.checkBox_X114.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X114.TabIndex = 31;
            this.checkBox_X114.Text = "X114";
            this.checkBox_X114.UseVisualStyleBackColor = true;
            // 
            // checkBox_X014
            // 
            this.checkBox_X014.AllowDrop = true;
            this.checkBox_X014.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X014.AutoCheck = false;
            this.checkBox_X014.AutoSize = true;
            this.checkBox_X014.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X014.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X014.Location = new System.Drawing.Point(295, 428);
            this.checkBox_X014.Name = "checkBox_X014";
            this.checkBox_X014.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X014.TabIndex = 30;
            this.checkBox_X014.Text = "X014";
            this.checkBox_X014.UseVisualStyleBackColor = true;
            // 
            // checkBox_X106
            // 
            this.checkBox_X106.AllowDrop = true;
            this.checkBox_X106.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X106.AutoCheck = false;
            this.checkBox_X106.AutoSize = true;
            this.checkBox_X106.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X106.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X106.Location = new System.Drawing.Point(580, 428);
            this.checkBox_X106.Name = "checkBox_X106";
            this.checkBox_X106.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X106.TabIndex = 33;
            this.checkBox_X106.Text = "X106";
            this.checkBox_X106.UseVisualStyleBackColor = true;
            // 
            // checkBox_X006
            // 
            this.checkBox_X006.AllowDrop = true;
            this.checkBox_X006.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X006.AutoCheck = false;
            this.checkBox_X006.AutoSize = true;
            this.checkBox_X006.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X006.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X006.Location = new System.Drawing.Point(10, 428);
            this.checkBox_X006.Name = "checkBox_X006";
            this.checkBox_X006.Size = new System.Drawing.Size(268, 28);
            this.checkBox_X006.TabIndex = 32;
            this.checkBox_X006.Text = "X006夾具前死點感測器";
            this.checkBox_X006.UseVisualStyleBackColor = true;
            // 
            // checkBox_X109
            // 
            this.checkBox_X109.AllowDrop = true;
            this.checkBox_X109.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X109.AutoCheck = false;
            this.checkBox_X109.AutoSize = true;
            this.checkBox_X109.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X109.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X109.Location = new System.Drawing.Point(865, 78);
            this.checkBox_X109.Name = "checkBox_X109";
            this.checkBox_X109.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X109.TabIndex = 27;
            this.checkBox_X109.Text = "X109";
            this.checkBox_X109.UseVisualStyleBackColor = true;
            // 
            // checkBox_X009
            // 
            this.checkBox_X009.AllowDrop = true;
            this.checkBox_X009.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X009.AutoCheck = false;
            this.checkBox_X009.AutoSize = true;
            this.checkBox_X009.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X009.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X009.Location = new System.Drawing.Point(295, 78);
            this.checkBox_X009.Name = "checkBox_X009";
            this.checkBox_X009.Size = new System.Drawing.Size(268, 28);
            this.checkBox_X009.TabIndex = 26;
            this.checkBox_X009.Text = "X009螺桿下死點感測器";
            this.checkBox_X009.UseVisualStyleBackColor = true;
            // 
            // checkBox_X101
            // 
            this.checkBox_X101.AllowDrop = true;
            this.checkBox_X101.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X101.AutoCheck = false;
            this.checkBox_X101.AutoSize = true;
            this.checkBox_X101.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X101.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X101.Location = new System.Drawing.Point(580, 78);
            this.checkBox_X101.Name = "checkBox_X101";
            this.checkBox_X101.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X101.TabIndex = 29;
            this.checkBox_X101.Text = "X101";
            this.checkBox_X101.UseVisualStyleBackColor = true;
            // 
            // checkBox_X001
            // 
            this.checkBox_X001.AllowDrop = true;
            this.checkBox_X001.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X001.AutoCheck = false;
            this.checkBox_X001.AutoSize = true;
            this.checkBox_X001.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X001.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X001.Location = new System.Drawing.Point(10, 78);
            this.checkBox_X001.Name = "checkBox_X001";
            this.checkBox_X001.Size = new System.Drawing.Size(176, 28);
            this.checkBox_X001.TabIndex = 28;
            this.checkBox_X001.Text = "X001停止按鈕";
            this.checkBox_X001.UseVisualStyleBackColor = true;
            // 
            // checkBox_X113
            // 
            this.checkBox_X113.AllowDrop = true;
            this.checkBox_X113.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X113.AutoCheck = false;
            this.checkBox_X113.AutoSize = true;
            this.checkBox_X113.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X113.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X113.Location = new System.Drawing.Point(865, 358);
            this.checkBox_X113.Name = "checkBox_X113";
            this.checkBox_X113.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X113.TabIndex = 39;
            this.checkBox_X113.Text = "X113";
            this.checkBox_X113.UseVisualStyleBackColor = true;
            // 
            // checkBox_X013
            // 
            this.checkBox_X013.AllowDrop = true;
            this.checkBox_X013.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X013.AutoCheck = false;
            this.checkBox_X013.AutoSize = true;
            this.checkBox_X013.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X013.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X013.Location = new System.Drawing.Point(295, 358);
            this.checkBox_X013.Name = "checkBox_X013";
            this.checkBox_X013.Size = new System.Drawing.Size(199, 28);
            this.checkBox_X013.TabIndex = 38;
            this.checkBox_X013.Text = "X013定位感測器";
            this.checkBox_X013.UseVisualStyleBackColor = true;
            // 
            // checkBox_X105
            // 
            this.checkBox_X105.AllowDrop = true;
            this.checkBox_X105.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X105.AutoCheck = false;
            this.checkBox_X105.AutoSize = true;
            this.checkBox_X105.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X105.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X105.Location = new System.Drawing.Point(580, 358);
            this.checkBox_X105.Name = "checkBox_X105";
            this.checkBox_X105.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X105.TabIndex = 41;
            this.checkBox_X105.Text = "X105";
            this.checkBox_X105.UseVisualStyleBackColor = true;
            // 
            // checkBox_X005
            // 
            this.checkBox_X005.AllowDrop = true;
            this.checkBox_X005.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X005.AutoCheck = false;
            this.checkBox_X005.AutoSize = true;
            this.checkBox_X005.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X005.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X005.Location = new System.Drawing.Point(10, 358);
            this.checkBox_X005.Name = "checkBox_X005";
            this.checkBox_X005.Size = new System.Drawing.Size(222, 28);
            this.checkBox_X005.TabIndex = 40;
            this.checkBox_X005.Text = "X005入料口感測器";
            this.checkBox_X005.UseVisualStyleBackColor = true;
            // 
            // checkBox_X108
            // 
            this.checkBox_X108.AllowDrop = true;
            this.checkBox_X108.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X108.AutoCheck = false;
            this.checkBox_X108.AutoSize = true;
            this.checkBox_X108.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X108.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X108.Location = new System.Drawing.Point(865, 8);
            this.checkBox_X108.Name = "checkBox_X108";
            this.checkBox_X108.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X108.TabIndex = 35;
            this.checkBox_X108.Text = "X108";
            this.checkBox_X108.UseVisualStyleBackColor = true;
            // 
            // checkBox_X008
            // 
            this.checkBox_X008.AllowDrop = true;
            this.checkBox_X008.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X008.AutoCheck = false;
            this.checkBox_X008.AutoSize = true;
            this.checkBox_X008.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X008.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X008.Location = new System.Drawing.Point(295, 8);
            this.checkBox_X008.Name = "checkBox_X008";
            this.checkBox_X008.Size = new System.Drawing.Size(268, 28);
            this.checkBox_X008.TabIndex = 34;
            this.checkBox_X008.Text = "X008螺桿上死點感測器";
            this.checkBox_X008.UseVisualStyleBackColor = true;
            // 
            // checkBox_X100
            // 
            this.checkBox_X100.AllowDrop = true;
            this.checkBox_X100.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X100.AutoCheck = false;
            this.checkBox_X100.AutoSize = true;
            this.checkBox_X100.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X100.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X100.Location = new System.Drawing.Point(580, 8);
            this.checkBox_X100.Name = "checkBox_X100";
            this.checkBox_X100.Size = new System.Drawing.Size(84, 28);
            this.checkBox_X100.TabIndex = 37;
            this.checkBox_X100.Text = "X100";
            this.checkBox_X100.UseVisualStyleBackColor = true;
            // 
            // checkBox_X000
            // 
            this.checkBox_X000.AllowDrop = true;
            this.checkBox_X000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_X000.AutoCheck = false;
            this.checkBox_X000.AutoSize = true;
            this.checkBox_X000.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_X000.Font = new System.Drawing.Font("PMingLiU", 17F);
            this.checkBox_X000.Location = new System.Drawing.Point(10, 8);
            this.checkBox_X000.Name = "checkBox_X000";
            this.checkBox_X000.Size = new System.Drawing.Size(176, 28);
            this.checkBox_X000.TabIndex = 36;
            this.checkBox_X000.Text = "X000啟動按鈕";
            this.checkBox_X000.UseVisualStyleBackColor = true;
            // 
            // btn_Program_New_Start
            // 
            this.btn_Program_New_Start.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Program_New_Start.Location = new System.Drawing.Point(1178, 90);
            this.btn_Program_New_Start.Name = "btn_Program_New_Start";
            this.btn_Program_New_Start.Size = new System.Drawing.Size(96, 50);
            this.btn_Program_New_Start.TabIndex = 6;
            this.btn_Program_New_Start.Text = "程式從開";
            this.btn_Program_New_Start.UseVisualStyleBackColor = true;
            this.btn_Program_New_Start.Click += new System.EventHandler(this.btn_Program_New_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1274, 775);
            this.ControlBox = false;
            this.Controls.Add(this.lab_HideButton);
            this.Controls.Add(this.lab_SystemStatus);
            this.Controls.Add(this.lab_Progress);
            this.Controls.Add(this.btn_Shutdown);
            this.Controls.Add(this.btn_Program_New_Start);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.axDBCommManager1);
            this.Controls.Add(this.panel_CloseProgram);
            this.Controls.Add(this.panel_Shutdown);
            this.Controls.Add(this.panel_Error_Message);
            this.Controls.Add(this.panel_I_O_Table);
            this.Controls.Add(this.panel_Hidden_Features);
            this.Controls.Add(this.panel_Screw_Correction_Guide);
            this.Controls.Add(this.panel_Empty_Disk);
            this.Controls.Add(this.panel_Calibration_Fixture);
            this.Controls.Add(this.panel_Turntable_Correction);
            this.Controls.Add(this.panel_Manual_Mode);
            this.Controls.Add(this.panel_WorkingSpeed);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Operation_Guide5);
            this.Controls.Add(this.panel_Operation_Guide4);
            this.Controls.Add(this.panel_Operation_Guide3);
            this.Controls.Add(this.panel_Operation_Guide2);
            this.Controls.Add(this.panel_Operation_Guide1);
            this.Controls.Add(this.panel_High_Speed_Cutting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(161, 42);
            this.Name = "Form1";
            this.Text = "高速割尾機";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.axDBCommManager1)).EndInit();
            this.panel_High_Speed_Cutting.ResumeLayout(false);
            this.panel_High_Speed_Cutting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Boltun_Logo)).EndInit();
            this.panel_Shutdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel_CloseProgram.ResumeLayout(false);
            this.panel_CloseProgram.PerformLayout();
            this.panel_Operation_Guide1.ResumeLayout(false);
            this.panel_Operation_Guide1.PerformLayout();
            this.panel_Operation_Guide2.ResumeLayout(false);
            this.panel_Operation_Guide2.PerformLayout();
            this.panel_Operation_Guide3.ResumeLayout(false);
            this.panel_Operation_Guide3.PerformLayout();
            this.panel_Operation_Guide4.ResumeLayout(false);
            this.panel_Operation_Guide4.PerformLayout();
            this.panel_Machine_OPR2.ResumeLayout(false);
            this.panel_Machine_OPR2.PerformLayout();
            this.panel_Machine_OPR1.ResumeLayout(false);
            this.panel_Machine_OPR1.PerformLayout();
            this.panel_Operation_Guide5.ResumeLayout(false);
            this.panel_Operation_Guide5.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.panel_Hide_Password_Function.ResumeLayout(false);
            this.panel_Hide_Password_Function.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Boltun_Main)).EndInit();
            this.panel_WorkingSpeed.ResumeLayout(false);
            this.panel_Counting_System.ResumeLayout(false);
            this.panel_Counting_System.PerformLayout();
            this.panel_WorkingSpeedSetting.ResumeLayout(false);
            this.panel_WorkingSpeedSetting.PerformLayout();
            this.panel_Manual_Mode.ResumeLayout(false);
            this.panel_OPR.ResumeLayout(false);
            this.panel_OPR.PerformLayout();
            this.panel_Close_Electronic_Handwheel1.ResumeLayout(false);
            this.panel_Close_Electronic_Handwheel1.PerformLayout();
            this.panel_Turntable_Correction.ResumeLayout(false);
            this.panel_Turntable_Correction.PerformLayout();
            this.panel_Turntable_Correction_Determine_Disk.ResumeLayout(false);
            this.panel_Turntable_Correction_Determine_Disk.PerformLayout();
            this.panel_Correction_Boot_Disk2.ResumeLayout(false);
            this.panel_Correction_Boot_Disk2.PerformLayout();
            this.panel_Correction_Boot_Disk1.ResumeLayout(false);
            this.panel_Correction_Boot_Disk1.PerformLayout();
            this.panel_Calibration_Fixture.ResumeLayout(false);
            this.panel_Calibration_Fixture.PerformLayout();
            this.panel_Turntable_Correction_Determine_Fixture.ResumeLayout(false);
            this.panel_Turntable_Correction_Determine_Fixture.PerformLayout();
            this.panel_Correcting_Jig_Guide2.ResumeLayout(false);
            this.panel_Correcting_Jig_Guide2.PerformLayout();
            this.panel_Correcting_Jig_Guide1.ResumeLayout(false);
            this.panel_Correcting_Jig_Guide1.PerformLayout();
            this.panel_Empty_Disk.ResumeLayout(false);
            this.panel_Empty_Disk.PerformLayout();
            this.panel_Start_Empty_Disk.ResumeLayout(false);
            this.panel_Start_Empty_Disk.PerformLayout();
            this.panel_Screw_Correction_Guide.ResumeLayout(false);
            this.panel_Screw_Correction_Guide.PerformLayout();
            this.panel_Turntable_Correction_Determine_Screw.ResumeLayout(false);
            this.panel_Turntable_Correction_Determine_Screw.PerformLayout();
            this.panel_Screw_Correction_Guide2.ResumeLayout(false);
            this.panel_Screw_Correction_Guide2.PerformLayout();
            this.panel_Screw_Correction_Guide1.ResumeLayout(false);
            this.panel_Screw_Correction_Guide1.PerformLayout();
            this.panel_Error_Message.ResumeLayout(false);
            this.panel_Error_Message.PerformLayout();
            this.panel_Hidden_Features.ResumeLayout(false);
            this.panel_Hidden_Features.PerformLayout();
            this.panel_I_O_Table.ResumeLayout(false);
            this.panel_I_O_Table_Y.ResumeLayout(false);
            this.panel_I_O_Table_Y.PerformLayout();
            this.panel_I_O_Table_X.ResumeLayout(false);
            this.panel_I_O_Table_X.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private AxDATABUILDERAXLibLB.AxDBCommManager axDBCommManager1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel_High_Speed_Cutting;
        private System.Windows.Forms.Button btn_Shutdown;
        private System.Windows.Forms.Panel panel_Shutdown;
        private System.Windows.Forms.Button btn_Reboot;
        private System.Windows.Forms.Button btn_Shutdown_close;
        private System.Windows.Forms.Button btn_Cancel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lab_Progress;
        private System.Windows.Forms.Label lab_SystemStatus;
        private System.Windows.Forms.Label lab_HideButton;
        private System.Windows.Forms.Panel panel_CloseProgram;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn__7;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_CancelClose;
        private System.Windows.Forms.Button btn_OK_Close;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label_Enter_Password_Close;
        private System.Windows.Forms.Button btn_Operation_Guide;
        private System.Windows.Forms.Label label_High_Speed_Cutting;
        private System.Windows.Forms.Panel panel_Operation_Guide1;
        private System.Windows.Forms.Button btn_Next1;
        private System.Windows.Forms.CheckBox checkBox_Full_Material_Sensor;
        private System.Windows.Forms.Label label_Confirm_Machine_Sensors;
        private System.Windows.Forms.CheckBox checkBox_Screw_Below_Dead_Point_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Screw_Dead_Top_Center_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Feeding_Confirm_Sensor;
        private System.Windows.Forms.CheckBox checkBox_No_Material_Sensor;
        private System.Windows.Forms.Panel panel_Operation_Guide2;
        private System.Windows.Forms.CheckBox checkBox_None_Workpiece_Turntable;
        private System.Windows.Forms.Button button_None_Workpiece_Turntable;
        private System.Windows.Forms.Panel panel_Operation_Guide3;
        private System.Windows.Forms.Button button_Hair_Shock_On_Track;
        private System.Windows.Forms.Button button_Pneumatic_Adequate_Machine;
        private System.Windows.Forms.CheckBox checkBox_Hair_Shock_On_Track;
        private System.Windows.Forms.CheckBox checkBox_Pneumatic_Adequate_Machine;
        private System.Windows.Forms.Label label_Confirm_Before_Running_Machine;
        private System.Windows.Forms.Button btn_Next3;
        private System.Windows.Forms.Button button_Machine_Table_No_Foreign_Body;
        private System.Windows.Forms.Button button_Track_No_Material_Discharge_Port;
        private System.Windows.Forms.CheckBox checkBox_Machine_Table_No_Foreign_Body;
        private System.Windows.Forms.CheckBox checkBox_Track_No_Material_Discharge_Port;
        private System.Windows.Forms.Label label_Confirm_Machine_Workpiece;
        private System.Windows.Forms.Button btn_Next2;
        private System.Windows.Forms.Label label_Operation_Guide1;
        private System.Windows.Forms.Label label_Operation_Guide3;
        private System.Windows.Forms.Label label_Operation_Guide2;
        private System.Windows.Forms.Panel panel_Operation_Guide4;
        private System.Windows.Forms.Label label_Machine_OPR;
        private System.Windows.Forms.Panel panel_Machine_OPR2;
        private System.Windows.Forms.Panel panel_Machine_OPR1;
        private System.Windows.Forms.Button button_OPR;
        private System.Windows.Forms.Button button_Motor_Start;
        private System.Windows.Forms.CheckBox checkBox_Positioning_Completed;
        private System.Windows.Forms.Button btn_Next4;
        private System.Windows.Forms.Button button_Sensor_Normal;
        private System.Windows.Forms.CheckBox checkBox_Sensor_Normal;
        private System.Windows.Forms.Label label_Confirm_Screw;
        private System.Windows.Forms.Panel panel_Operation_Guide5;
        private System.Windows.Forms.Button button_Screw_Synchronization;
        private System.Windows.Forms.CheckBox checkBox_Xaxis;
        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Label label_Operation_Guide5;
        private System.Windows.Forms.Label label_Tool_Positioning_Screw_Start;
        private System.Windows.Forms.Label label_Operation_Guide4;
        private System.Windows.Forms.Button button_Tool_Rotation;
        private System.Windows.Forms.Label label_Screw_Position_Value;
        private System.Windows.Forms.Label label_Screw_Position;
        private System.Windows.Forms.Label label_Tool_Rotation;
        private System.Windows.Forms.Label label_Screw_Synchronization;
        private System.Windows.Forms.Label label_Screw_Synchronous_Starting_Point;
        private System.Windows.Forms.Label label_Xaxis_Hand_Wheel_Knob;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Button button_Speed_Setting;
        private System.Windows.Forms.Button button_Analog_Operation;
        private System.Windows.Forms.Button button_Machine_Stop;
        private System.Windows.Forms.Button button_Input_Output_List;
        private System.Windows.Forms.Button button_Machine_Start;
        private System.Windows.Forms.Button button_Error_Message;
        private System.Windows.Forms.Button button_Counting_System;
        private System.Windows.Forms.Button button_Manual_Mode;
        private System.Windows.Forms.Panel panel_WorkingSpeed;
        private System.Windows.Forms.Panel panel_Counting_System;
        private System.Windows.Forms.Panel panel_WorkingSpeedSetting;
        private System.Windows.Forms.Button buttonBackToMainScreen_WorkingSpeed;
        private System.Windows.Forms.Button button_Count_OR_Speed;
        private System.Windows.Forms.TextBox textBox_SpeedSetting;
        private System.Windows.Forms.TextBox textBox_CurrentSpeed;
        private System.Windows.Forms.Label label_SpeedSetting;
        private System.Windows.Forms.Label label_CurrentSpeed;
        private System.Windows.Forms.CheckBox checkBox_Positioning_Completed1;
        private System.Windows.Forms.CheckBox checkBox_FullMaterial_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Nomaterial_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Screw_Down_Dead;
        private System.Windows.Forms.CheckBox checkBox_Discharge_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Screw_Up_Dead;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_Modify;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_Delete;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_0;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_9;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_6;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_3;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_8;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_5;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_2;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_7;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_4;
        private System.Windows.Forms.Button btn_WorkingSpeedSetting_1;
        private System.Windows.Forms.Button button_Write_Speed_Value;
        private System.Windows.Forms.Label label_Counting_System;
        private System.Windows.Forms.Label label_Speed_Setting;
        private System.Windows.Forms.TextBox textBox_Stroke_Rate;
        private System.Windows.Forms.TextBox textBox_Total_Number_Actions;
        private System.Windows.Forms.Label label_Stroke_Rate;
        private System.Windows.Forms.Label label_Total_Number_Actions;
        private System.Windows.Forms.Label label_Stroke_Rate_Count;
        private System.Windows.Forms.Label label_Total_Number_Actions_Count;
        private System.Windows.Forms.Panel panel_Manual_Mode;
        private System.Windows.Forms.Button button_Main_Manual_Mode;
        private System.Windows.Forms.Button button_A_Loop;
        private System.Windows.Forms.Button button_JOG;
        private System.Windows.Forms.Button button_Continuous_Action;
        private System.Windows.Forms.Button button_OPR_Run;
        private System.Windows.Forms.Button button_Tool_Rotation_Run;
        private System.Windows.Forms.Button button_Calibration_Screw;
        private System.Windows.Forms.Button button_Tool_Containing_A_Loop;
        private System.Windows.Forms.Button button_Motor_Start_Run;
        private System.Windows.Forms.Button button_Calibration_Fixture;
        private System.Windows.Forms.Button button_Empty_Disk;
        private System.Windows.Forms.Button button_Turn_Handwheel;
        private System.Windows.Forms.Button button_Turn_Vibration_Plate;
        private System.Windows.Forms.Button button_Turntable_Correction;
        private System.Windows.Forms.Button button_Manual_Mode_Run;
        private System.Windows.Forms.Panel panel_Turntable_Correction;
        private System.Windows.Forms.Label label_Correction_Boot_Disk;
        private System.Windows.Forms.Panel panel_Turntable_Correction_Determine_Disk;
        private System.Windows.Forms.Label label_Handwheel_Shaft_Torsional_Choose_OFF_Disk;
        private System.Windows.Forms.CheckBox checkBox_OFF_State_Disk;
        private System.Windows.Forms.Button button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine;
        private System.Windows.Forms.Panel panel_Correction_Boot_Disk1;
        private System.Windows.Forms.Panel panel_Correction_Boot_Disk2;
        private System.Windows.Forms.CheckBox checkBox_Screw_Mechanism_Away_Dead_Point_Sensor;
        private System.Windows.Forms.Button button_Turntable_Correction_Complete;
        private System.Windows.Forms.Button button_panel_Correction_Boot_Disk2_Determine;
        private System.Windows.Forms.Label label_Press_Done_Complete_Disk_Surface_Correction;
        private System.Windows.Forms.Label label_Screw_Mechanism_Away_From_Lower_Dead_Point;
        private System.Windows.Forms.Label label_Press_Confirm_Disk_Rotates_Clockwise_After_Correction_Holes;
        private System.Windows.Forms.CheckBox checkBox_OPR_Complete_Disk;
        private System.Windows.Forms.CheckBox checkBox_Disk_OPR_Point;
        private System.Windows.Forms.CheckBox checkBox_After_Clamp_Mechanism_Dead_Point_Sensor;
        private System.Windows.Forms.CheckBox checkBox_Screw_Mechanism_Dead_Point_Sensor;
        private System.Windows.Forms.Button button_Turntable_Correction_Next;
        private System.Windows.Forms.Button button_Turntable_Correction_Determine;
        private System.Windows.Forms.Label label_OPR_Performed_After_Confirmation;
        private System.Windows.Forms.Label label_Go_Disk_OPR_Point;
        private System.Windows.Forms.Label label_Clamp_Mechanism_Moved_After_Dead_Point;
        private System.Windows.Forms.Label label_Screw_Mechanism_Moves_Bottom_Dead_Center;
        private System.Windows.Forms.Panel panel_OPR;
        private System.Windows.Forms.Panel panel_Close_Electronic_Handwheel1;
        private System.Windows.Forms.Label label_Close_Electronic_Handwheel;
        private System.Windows.Forms.Button button_Close_Electronic_Handwheel;
        private System.Windows.Forms.Button button_OPR_Cancel;
        private System.Windows.Forms.Button button_OPR_Confirmation;
        private System.Windows.Forms.Label label_OPR;
        private System.Windows.Forms.Panel panel_Calibration_Fixture;
        private System.Windows.Forms.Panel panel_Correcting_Jig_Guide2;
        private System.Windows.Forms.Button button_Correcting_Jig_Guide_Determine_Complete;
        private System.Windows.Forms.Button button_Correcting_Jig_Guide_Determine2;
        private System.Windows.Forms.Label label_Press_Done_Complete_Correction_Jig;
        private System.Windows.Forms.Label label_Press_Confirm_Safety_Position_Jaw_Clockwise_Rotation;
        private System.Windows.Forms.Panel panel_Correcting_Jig_Guide1;
        private System.Windows.Forms.CheckBox checkBox_OPR_Completed_Jig;
        private System.Windows.Forms.CheckBox checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise;
        private System.Windows.Forms.Button button_Correcting_Jig_Guide_Next;
        private System.Windows.Forms.Button button_Correcting_Jig_Guide_Determine1;
        private System.Windows.Forms.Label label_After_Confirmation_Performed_OPR;
        private System.Windows.Forms.Label label_Clamp_Mechanism_Moved_After_Dead_Point_Fixture;
        private System.Windows.Forms.Label label_Correcting_Jig_Guide;
        private System.Windows.Forms.Panel panel_Turntable_Correction_Determine_Fixture;
        private System.Windows.Forms.CheckBox checkBox_OFF_State_Fixture;
        private System.Windows.Forms.Button button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine;
        private System.Windows.Forms.Label label_Handwheel_Shaft_Torsional_Choose_OFF_Fixture;
        private System.Windows.Forms.Panel panel_Empty_Disk;
        private System.Windows.Forms.CheckBox checkBox_Disk_Empty;
        private System.Windows.Forms.CheckBox checkBox_Machine_Can_Turned_Off;
        private System.Windows.Forms.Button button_Empty_Disk_Complete;
        private System.Windows.Forms.Button button_label_Start_Empty_Disk_Confirm;
        private System.Windows.Forms.Button button_Start_Empty_Ramp_Confirm;
        private System.Windows.Forms.Label label_Start_Empty_Disk;
        private System.Windows.Forms.Label label_Start_Empty_Ramp;
        private System.Windows.Forms.Label label_Empty_Disk;
        private System.Windows.Forms.CheckBox checkBox_Empty_Disk;
        private System.Windows.Forms.Panel panel_Start_Empty_Disk;
        private System.Windows.Forms.Button button_Start_Empty_Disk_Confirm;
        private System.Windows.Forms.Label label_Note_Machine_About_Run;
        private System.Windows.Forms.Label label_Please_Confirm_Again_Do_Not_Close_Turntable;
        private System.Windows.Forms.Panel panel_Screw_Correction_Guide;
        private System.Windows.Forms.Panel panel_Turntable_Correction_Determine_Screw;
        private System.Windows.Forms.CheckBox checkBox_OFF_State_Screw;
        private System.Windows.Forms.Button button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine;
        private System.Windows.Forms.Label label_Handwheel_Shaft_Torsional_Choose_OFF_Screw;
        private System.Windows.Forms.Panel panel_Screw_Correction_Guide2;
        private System.Windows.Forms.Button button_Screw_Correction_Guide_Complete;
        private System.Windows.Forms.Button button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm;
        private System.Windows.Forms.Label label_Screw_Mechanism_Away_Lower_Dead_Point;
        private System.Windows.Forms.Label label_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction;
        private System.Windows.Forms.Panel panel_Screw_Correction_Guide1;
        private System.Windows.Forms.CheckBox checkBox_Screw_OPR_Completed;
        private System.Windows.Forms.CheckBox checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1;
        private System.Windows.Forms.Button button_Screw_Correction_Guide_Next;
        private System.Windows.Forms.Button button_OPR_Performed_After_Confirmation_Screw_Confirm;
        private System.Windows.Forms.Label label_OPR_Performed_After_Confirmation_Screw;
        private System.Windows.Forms.Label label_Screw_Mechanism_Moves_Bottom_Dead_Center_Screw;
        private System.Windows.Forms.Label label_Screw_Correction_Guide;
        private System.Windows.Forms.Label label_Press_Done_Complete_Correction_Screw;
        private System.Windows.Forms.CheckBox checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2;
        private System.Windows.Forms.Panel panel_Error_Message;
        private System.Windows.Forms.Label label_Error_Message;
        private System.Windows.Forms.Button button_Error_Message_Main;
        private System.Windows.Forms.Button button_Error_Message_Manual_Mode;
        private System.Windows.Forms.TextBox textBox_Error_Message;
        private System.Windows.Forms.Button button_Error_Message_Speed_Setting;
        private System.Windows.Forms.PictureBox pictureBox_Boltun_Main;
        private System.Windows.Forms.PictureBox pictureBox_Boltun_Logo;
        private System.Windows.Forms.Panel panel_Hide_Password_Function;
        private System.Windows.Forms.Label label_Hidden_Features_Password;
        private System.Windows.Forms.Button button_Hidden_Features_Return;
        private System.Windows.Forms.Button button_Hidden_Features_Delete;
        private System.Windows.Forms.TextBox textBox_Hidden_Features_Password;
        private System.Windows.Forms.Button button_Hidden_Features_9;
        private System.Windows.Forms.Button button_Hidden_Features_6;
        private System.Windows.Forms.Button button_Hidden_Features_3;
        private System.Windows.Forms.Button button_Hidden_Features_8;
        private System.Windows.Forms.Button button_Hidden_Features_5;
        private System.Windows.Forms.Button button_Hidden_Features_2;
        private System.Windows.Forms.Button button_Hidden_Features_7;
        private System.Windows.Forms.Button button_Hidden_Features_4;
        private System.Windows.Forms.Button button_Hidden_Features_Cancel;
        private System.Windows.Forms.Button button_Hidden_Features_OK;
        private System.Windows.Forms.Button button_Hidden_Features_0;
        private System.Windows.Forms.Button button_Hidden_Features_1;
        private System.Windows.Forms.Panel panel_Hidden_Features;
        private System.Windows.Forms.Label label_Hidden_Features_Screw_Position_Count;
        private System.Windows.Forms.Label label_Hidden_Features_Screw_Position;
        private System.Windows.Forms.Button button_Hidden_Features_Two_Axis_Positioning;
        private System.Windows.Forms.Button button_Hidden_Features_Continuous;
        private System.Windows.Forms.Button button_Hidden_Features_Knife_Cycle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Hidden_Features_Tool_JOG;
        private System.Windows.Forms.Button button_Hidden_Features_Turntable_Inversion;
        private System.Windows.Forms.Button button_Hidden_Features_Reverse_Fixture;
        private System.Windows.Forms.Button button_Hidden_Features_Screw_Decline;
        private System.Windows.Forms.Button button_Hidden_Features_Tool_Rotation;
        private System.Windows.Forms.Button button_Hidden_Features_Forward_Wheel;
        private System.Windows.Forms.Button button_Hidden_Features_Fixture_Forward;
        private System.Windows.Forms.Button button_Hidden_Features_Screw_Rise;
        private System.Windows.Forms.Button button_Hidden_Features_Fixture_Synchronization;
        private System.Windows.Forms.Button button_Hidden_Features_Tool_Relax;
        private System.Windows.Forms.Button button_Hidden_Features_PASS_Bottom_Dead;
        private System.Windows.Forms.Button button_Hidden_Features_Motor_Start;
        private System.Windows.Forms.Label label_Hidden_Features_Tool_Speed_Count;
        private System.Windows.Forms.Label label_Hidden_Features_Operating_Speed_Count;
        private System.Windows.Forms.Label label_Hidden_Features_Tool_Speed;
        private System.Windows.Forms.Label label_Hidden_Features_Operating_Speed;
        private System.Windows.Forms.Button button_Hidden_Features_Screw_Synchronization;
        private System.Windows.Forms.Button button_Error_Message_Exclusion_Mistake;
        private System.Windows.Forms.Panel panel_I_O_Table;
        private System.Windows.Forms.Panel panel_I_O_Table_X;
        private System.Windows.Forms.CheckBox checkBox_X112;
        private System.Windows.Forms.CheckBox checkBox_X012;
        private System.Windows.Forms.CheckBox checkBox_X104;
        private System.Windows.Forms.CheckBox checkBox_X004;
        private System.Windows.Forms.CheckBox checkBox_X111;
        private System.Windows.Forms.CheckBox checkBox_X011;
        private System.Windows.Forms.CheckBox checkBox_X103;
        private System.Windows.Forms.CheckBox checkBox_X003;
        private System.Windows.Forms.CheckBox checkBox_X115;
        private System.Windows.Forms.CheckBox checkBox_X015;
        private System.Windows.Forms.CheckBox checkBox_X107;
        private System.Windows.Forms.CheckBox checkBox_X007;
        private System.Windows.Forms.CheckBox checkBox_X110;
        private System.Windows.Forms.CheckBox checkBox_X010;
        private System.Windows.Forms.CheckBox checkBox_X102;
        private System.Windows.Forms.CheckBox checkBox_X002;
        private System.Windows.Forms.CheckBox checkBox_X114;
        private System.Windows.Forms.CheckBox checkBox_X014;
        private System.Windows.Forms.CheckBox checkBox_X106;
        private System.Windows.Forms.CheckBox checkBox_X006;
        private System.Windows.Forms.CheckBox checkBox_X109;
        private System.Windows.Forms.CheckBox checkBox_X009;
        private System.Windows.Forms.CheckBox checkBox_X101;
        private System.Windows.Forms.CheckBox checkBox_X001;
        private System.Windows.Forms.CheckBox checkBox_X113;
        private System.Windows.Forms.CheckBox checkBox_X013;
        private System.Windows.Forms.CheckBox checkBox_X105;
        private System.Windows.Forms.CheckBox checkBox_X005;
        private System.Windows.Forms.CheckBox checkBox_X108;
        private System.Windows.Forms.CheckBox checkBox_X008;
        private System.Windows.Forms.CheckBox checkBox_X100;
        private System.Windows.Forms.CheckBox checkBox_X000;
        private System.Windows.Forms.Panel panel_I_O_Table_Y;
        private System.Windows.Forms.CheckBox checkBox_Y112;
        private System.Windows.Forms.CheckBox checkBox_Y012;
        private System.Windows.Forms.CheckBox checkBox_Y104;
        private System.Windows.Forms.CheckBox checkBox_Y004;
        private System.Windows.Forms.CheckBox checkBox_Y111;
        private System.Windows.Forms.CheckBox checkBox_Y011;
        private System.Windows.Forms.CheckBox checkBox_Y103;
        private System.Windows.Forms.CheckBox checkBox_Y003;
        private System.Windows.Forms.CheckBox checkBox_Y115;
        private System.Windows.Forms.CheckBox checkBox_Y015;
        private System.Windows.Forms.CheckBox checkBox_Y107;
        private System.Windows.Forms.CheckBox checkBox_Y007;
        private System.Windows.Forms.CheckBox checkBox_Y110;
        private System.Windows.Forms.CheckBox checkBox_Y010;
        private System.Windows.Forms.CheckBox checkBox_Y102;
        private System.Windows.Forms.CheckBox checkBox_Y002;
        private System.Windows.Forms.CheckBox checkBox_Y114;
        private System.Windows.Forms.CheckBox checkBox_Y014;
        private System.Windows.Forms.CheckBox checkBox_Y106;
        private System.Windows.Forms.CheckBox checkBox_Y006;
        private System.Windows.Forms.CheckBox checkBox_Y109;
        private System.Windows.Forms.CheckBox checkBox_Y009;
        private System.Windows.Forms.CheckBox checkBox_Y101;
        private System.Windows.Forms.CheckBox checkBox_Y001;
        private System.Windows.Forms.CheckBox checkBox_Y113;
        private System.Windows.Forms.CheckBox checkBox_Y013;
        private System.Windows.Forms.CheckBox checkBox_Y105;
        private System.Windows.Forms.CheckBox checkBox_Y005;
        private System.Windows.Forms.CheckBox checkBox_Y108;
        private System.Windows.Forms.CheckBox checkBox_Y008;
        private System.Windows.Forms.CheckBox checkBox_Y100;
        private System.Windows.Forms.CheckBox checkBox_Y000;
        private System.Windows.Forms.Button button_I_O_Table_Switching;
        private System.Windows.Forms.Button button_I_O_Table_Main;
        private System.Windows.Forms.Panel panel_Close_Electronic_Handwheel2;
        private System.Windows.Forms.Panel panel_Close_Electronic_Handwheel3;
        private System.Windows.Forms.Button button_Close_Cancel_Handwheel;
        private System.Windows.Forms.Button btn_Program_New_Start;
    }
}

