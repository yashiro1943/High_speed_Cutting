﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Threading;
using System.Drawing.Drawing2D;

namespace PLC_Control
{
    public partial class Form1 : Form
    {
        ObjectPLC_KV obj_PLC;

        int Test_Operation = 0;//判斷是否為測試(0：非測試、1：測試)

        //主畫面用
        public int MR_2001, MR_2002, MR_2003, MR_2004, MR_2005, MR_2006;
        public int MR_2007, MR_2008, MR_2009, MR_2010;
        public int MR_2100, MR_2101, MR_2103;
        public int MR_0, MR_104, MR_2015;
        public int MR_300;
        public int RLY_40005, RLY_40006, RLY_40004, RLY_40008, RLY_40009, DM_90, DM_95, DM_97, DM_12;
        public int MR_12, MR_4;//無讀取
        public int MR_14, MR_15, MR_5, MR_6, MR_705, MR_607;//用來判斷手動模式按鈕是否能按
        public int MR_404, MR_2, MR_11;//無讀取//轉盤校正
        public int RLY_40007, RLY_40010, MR_2506, MR_2505, MR_2507, MR_408; //RLY_40009已有命名過   //MR_2505, MR_2507,MR_408, MR_15只寫入
        public int MR_206, MR_209, MR_207;
        public int MR_2502;
        public int MR_410, C_6, MR_413;
        public int MR_2511;
        public int DM_600, DM_200, DM_20006, RLY_34602, RLY_35402, DM_600_Ten, DM_600_Decimal;//隱藏頁面用
        public int R_X000, R_X001, R_X002, R_X003, R_X004, R_X005, R_X006, R_X007, R_X008, R_X009, R_X010, R_X011, R_X012, R_X013, R_X014, R_X015,
                   R_X100, R_X101, R_X102, R_X103, R_X104, R_X105, R_X106, R_X107, R_X108, R_X109, R_X110, R_X111, R_X112, R_X113, R_X114, R_X115;
        public int R_Y000, R_Y001, R_Y002, R_Y003, R_Y004, R_Y005, R_Y006, R_Y007, R_Y008, R_Y009, R_Y010, R_Y011, R_Y012, R_Y013, R_Y014, R_Y015,
                   R_Y100, R_Y101, R_Y102, R_Y103, R_Y104, R_Y105, R_Y106, R_Y107, R_Y108, R_Y109, R_Y110, R_Y111, R_Y112, R_Y113, R_Y114, R_Y115;
        public string Error_Message;

        //錯誤訊息用
        public int MR_1500, MR_1501, MR_1502, MR_1503, MR_1504, MR_1505, MR_1506, MR_1507, MR_1508, MR_1509,
                   MR_1510, MR_1511, MR_1512, MR_1513, MR_1514, MR_1515, MR_1600, MR_1601, MR_1602, MR_1603;
        int Error_Message_Timely = 0;

        //畫新按鈕圖示用
        System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
        System.Drawing.Drawing2D.GraphicsPath aCircle_Off = new System.Drawing.Drawing2D.GraphicsPath();
        System.Drawing.Drawing2D.GraphicsPath aCircle_On = new System.Drawing.Drawing2D.GraphicsPath();

        //執行緒
        Thread thread;
        public int Thread_Switch = 0;//是否讓執行緒內容執行(0不執行、1執行)
        int Running = 1; //執行緒打開(程式關閉才會清空)
        int Skip_Once = 0; //只允許跳過一次(不設定前面 直接跳進Main)

        //int AbnormalReturn_Count = 0; //顯示畫面用(異常指示燈使用)
        int Now_Second, Now_Second_Five_Seconds_Interval, Now_Minute_Interval_Error, Now_Minute; //計算秒差用(當下秒數 五秒後)

        public Form1()
        {
            InitializeComponent();
            obj_PLC = new ObjectPLC_KV();
            obj_PLC.axDBCommManager = axDBCommManager1;

            lab_Progress.Text = "PLC尚未連線";

            //尚未連線 將斷線及寫入先鎖定
            /*btnDisConnect.Enabled = false;
            btnSend.Enabled = false;*/

            //先將所有Panel都隱藏 只留最原始的
            //panel_Operation_Guide1.Visible = false;
            /*panel_WorkingSpeedSetting.Visible = false;
            panel_Abnormal_Lamp.Visible = false;
            panel_Counter.Visible = false;
            panel_FallSpeed.Visible = false;
            panel_Shutdown.Visible = false;
            panel_CloseProgram.Visible = false;*/

            //buttonPowerIndicator.Size = new Size(78, 52);108, 56
            //將按鈕變成圓形(關閉)252, 224
            /*aCircle_Off = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle_Off.AddEllipse(new Rectangle(2, 2, 246, 246));
            aCircle_Off.AddEllipse(new Rectangle(50, 180, 30, 30));

            //將按鈕變成圓形(開啟)
            aCircle_On = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle_On.AddEllipse(new Rectangle(2, 2, 246, 246));
            aCircle_On.AddEllipse(new Rectangle(170, 180, 30, 30));

            aCircle = new System.Drawing.Drawing2D.GraphicsPath();
            aCircle.AddEllipse(new Rectangle(2, 2, 196, 196));*/

            /*btn_NylonTrack.Region = new Region(aCircle_Off);
            btn_LubricatingOil.Region = new Region(aCircle_Off);
            btn_VibrationPlate.Region = new Region(aCircle_Off);
            btn_NutsRunway.Region = new Region(aCircle_Off);
            btn_LubricantContinuousAction.Region = new Region(aCircle_Off);*/

            /*buttonPowerIndicator.Region = new Region(aCircle);
            buttonMotorOverloadLights.Region = new Region(aCircle);
            buttonRunwayNoNuts.Region = new Region(aCircle);
            buttonAbnormalPressure.Region = new Region(aCircle);
            buttonEmergencyStop.Region = new Region(aCircle);
            buttonLubricatingOil.Region = new Region(aCircle);
            buttonHydraulicMotorOverload.Region = new Region(aCircle);
            buttonNoNylonRoad.Region = new Region(aCircle);
            buttonRangingSensor.Region = new Region(aCircle);
            buttonAbnormalReturn.Region = new Region(aCircle);
            buttonNoPressMadeOfNylon.Region = new Region(aCircle);
            buttonConveyor.Region = new Region(aCircle);*/

            Form.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(TimerProcessFunc_Form1); //啟動Thread
            thread.Start();

            //有需要改按鈕顏色的
            //主畫面內
            button_Machine_Stop.BackColor = Color.Red;
            
            //操作引導內
            button_Motor_Start.BackColor = Color.Transparent;
            button_Screw_Synchronization.BackColor = Color.Transparent;//螺桿同步
            button_Tool_Rotation.BackColor = Color.Transparent;//刀具旋轉

            //手動模式內
            button_Manual_Mode_Run.BackColor = Color.Transparent;//手動模式
            button_Turn_Vibration_Plate.BackColor = Color.Transparent;//開啟震動盤
            button_Tool_Rotation_Run.BackColor = Color.Transparent;//刀具旋轉
            button_Continuous_Action.BackColor = Color.Transparent;//連續動作
            button_Motor_Start_Run.BackColor = Color.Transparent;//馬達啟動
            button_A_Loop.BackColor = Color.Transparent;//一循環

            //隱藏功能內
            button_Hidden_Features_Motor_Start.BackColor = Color.Transparent;//馬達啟動
            button_Hidden_Features_PASS_Bottom_Dead.BackColor = Color.Transparent;//PASS下死
            button_Hidden_Features_Screw_Synchronization.BackColor = Color.Transparent;//螺桿同步
            button_Hidden_Features_Fixture_Synchronization.BackColor = Color.Transparent;//夾具同步
            button_Hidden_Features_Continuous.BackColor = Color.Transparent;//連續
            button_Hidden_Features_Tool_Rotation.BackColor = Color.Transparent;//刀具旋轉
            button_Hidden_Features_Two_Axis_Positioning.BackColor = Color.Transparent;//兩軸定位

            //測試方便使用
            /*this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.TopMost = false;
            this.WindowState = FormWindowState.Normal;*/

            //程式一開啟就先連線(若是測試模式則將關閉程式鈕顯示出來)
            if (Test_Operation < 1)
            {
                if (obj_PLC.doMoniter() == false)
                {
                    lab_Progress.Text = "PLC連線失敗";
                    //尚未連線 使用者無法使用按鈕

                    Thread_Switch = 0;//關閉執行緒
                    lab_Progress.Text = "PLC連線失敗";
                    return;
                }
            }
            else
            {
                btn_Close.Visible = true;
            }

            if (Test_Operation == 1)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
                btn_Close.Visible = true;
            }
            //連線成功 將按鈕斷線及寫入開啟 連線則關閉
            btn_Operation_Guide.Enabled = true;
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "PLC連線成功";
            Thread_Switch = 1;//開啟執行緒

            /*btnConnect.Enabled = false;
            btnDisConnect.Enabled = true;
            btnSend.Enabled = true;

            //連線成功 將按鈕提供給使用者使用
            btn_NylonTrack.Enabled = true;
            btn_LubricatingOil.Enabled = true;
            btn_VibrationPlate.Enabled = true;
            btn_WorkingSpeedSetting.Enabled = true;
            btn_NutsRunway.Enabled = true;
            btn_LubricantContinuousAction.Enabled = true;
            btn_Abnormal_Lamp.Enabled = true;
            btn_Counter.Enabled = true;
            Crawl_PLC_Information();
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "PLC連線成功";
            Thread_Switch = 1;//開啟執行緒*/
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            /*if (TimePLCProcess_Form1.Enabled == false)//開啟timer
            {
                if (TimePLCProcess_Form1.Interval != 50)
                {
                    TimePLCProcess_Form1.Interval = 50;
                    TimePLCProcess_Form1.Elapsed += new System.Timers.ElapsedEventHandler(TimerProcessFunc_Form1);
                }
                TimePLCProcess_Form1.Enabled = true;
            }*/
        }

        //public void TimerProcessFunc_Form1(object sender, System.EventArgs e)
        public void TimerProcessFunc_Form1()
        {
            while (Running == 1)
            {
                if (Thread_Switch == 0)//尚未連線時
                {
                    Now_Second = System.DateTime.Now.AddSeconds(0).Second;//抓取當下秒數
                    if (Now_Second_Five_Seconds_Interval > 55)//防止秒數高於55
                    {
                        Now_Second_Five_Seconds_Interval = 0;
                    }
                    if (Now_Second - Now_Second_Five_Seconds_Interval > 0)//判斷五秒過後要將系統狀態更改
                    {
                        lab_Progress.Text = "PLC尚未連線";
                    }
                }
                else if (Thread_Switch == 1)//連線時
                {
                    Now_Second = System.DateTime.Now.AddSeconds(0).Second;//抓取當下秒數
                    Now_Minute = System.DateTime.Now.AddSeconds(0).Minute;//抓取當下分數
                    if (Now_Second_Five_Seconds_Interval > 55)//防止秒數高於55
                    {
                        Now_Second_Five_Seconds_Interval = 0;
                    }
                    if (Now_Second - Now_Second_Five_Seconds_Interval > 0)//判斷五秒過後要將系統狀態更改
                    {
                        lab_Progress.Text = "PLC連線";
                    }

                    //操作指南1
                    if (panel_Operation_Guide1.Visible == true)
                    {
                        MR_2001 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2001"); //讀取MR2001
                        MR_2002 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2002"); //讀取MR2002
                        MR_2003 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2003"); //讀取MR2003
                        MR_2004 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2004"); //讀取MR2004
                        MR_2005 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2005"); //讀取MR2005
                        MR_2006 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2006"); //讀取MR2006

                        //滿料感測器
                        if (MR_2001 >= 1)
                        {
                            checkBox_Full_Material_Sensor.Checked = true;
                            checkBox_Full_Material_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Full_Material_Sensor.Checked = false;
                        }

                        //無料感測器
                        if (MR_2002 >= 1)
                        {
                            checkBox_No_Material_Sensor.Checked = true;
                            checkBox_No_Material_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_No_Material_Sensor.Checked = false;
                        }

                        //入料確認感測器
                        if (MR_2003 >= 1)
                        {
                            checkBox_Feeding_Confirm_Sensor.Checked = true;
                            checkBox_Feeding_Confirm_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Feeding_Confirm_Sensor.Checked = false;
                        }

                        //螺桿上死點感測器
                        if (MR_2004 >= 1)
                        {
                            checkBox_Screw_Dead_Top_Center_Sensor.Checked = true;
                            checkBox_Screw_Dead_Top_Center_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Screw_Dead_Top_Center_Sensor.Checked = false;
                        }

                        //螺桿下死點感測器
                        if (MR_2005 >= 1)
                        {
                            checkBox_Screw_Below_Dead_Point_Sensor.Checked = true;
                            checkBox_Screw_Below_Dead_Point_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Screw_Below_Dead_Point_Sensor.Checked = false;
                        }

                        if (Test_Operation == 1)//測試用
                        {
                            MR_2006 = 1;
                        }
                        //下一頁 是否可按
                        if (MR_2006 >= 1)
                        {
                            btn_Next1.Enabled = true;
                        }
                        else
                        {
                            btn_Next1.Enabled = false;
                        }
                    }
                    //操作指南2
                    if (panel_Operation_Guide2.Visible == true)
                    {
                        MR_2007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2007"); //讀取MR2007
                        MR_2008 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2008"); //讀取MR2008
                        MR_2009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2009"); //讀取MR2009
                        MR_2010 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2010"); //讀取MR2010

                        //軌道出料口無料
                        if (MR_2007 >= 1)
                        {
                            checkBox_Track_No_Material_Discharge_Port.Checked = true;
                            checkBox_Track_No_Material_Discharge_Port.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Track_No_Material_Discharge_Port.Checked = false;
                        }

                        //機台上無異物
                        if (MR_2008 >= 1)
                        {
                            checkBox_Machine_Table_No_Foreign_Body.Checked = true;
                            checkBox_Machine_Table_No_Foreign_Body.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Machine_Table_No_Foreign_Body.Checked = false;
                        }

                        //轉盤上無工件
                        if (MR_2009 >= 1)
                        {
                            checkBox_None_Workpiece_Turntable.Checked = true;
                            checkBox_None_Workpiece_Turntable.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_None_Workpiece_Turntable.Checked = false;
                        }

                        if (Test_Operation == 1)//測試用
                        {
                            MR_2010 = 1;
                        }
                        
                        //下一頁 是否可按
                        if (MR_2010 >= 1)
                        {
                            btn_Next2.Enabled = true;
                        }
                        else
                        {
                            btn_Next2.Enabled = false;
                        }
                    }
                    //操作指南3
                    if (panel_Operation_Guide3.Visible == true)
                    {
                        MR_2100 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2100"); //讀取MR2100
                        MR_2101 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2101"); //讀取MR2101
                        MR_2103 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2103"); //讀取MR2103

                        //機台空壓充足
                        if (MR_2100 >= 1)
                        {
                            checkBox_Pneumatic_Adequate_Machine.Checked = true;
                            checkBox_Pneumatic_Adequate_Machine.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Pneumatic_Adequate_Machine.Checked = false;
                        }

                        //轉盤上無工件
                        if (MR_2101 >= 1)
                        {
                            checkBox_Hair_Shock_On_Track.Checked = true;
                            checkBox_Hair_Shock_On_Track.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Hair_Shock_On_Track.Checked = false;
                        }

                        if (Test_Operation == 1)//測試用
                        {
                            MR_2103 = 1;
                        }
                        //下一頁 是否可按
                        if (MR_2103 >= 1)
                        {
                            btn_Next3.Enabled = true;
                        }
                        else
                        {
                            btn_Next3.Enabled = false;
                        }
                    }
                    //操作指南4
                    if (panel_Operation_Guide4.Visible == true)
                    {
                        MR_104 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "104"); //讀取MR_104
                        MR_2103 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2103"); //讀取MR_2103
                        MR_2015 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2015"); //讀取MR_2015

                        //轉盤上無工件
                        if (MR_104 >= 1)
                        {
                            checkBox_Positioning_Completed.Checked = true;
                            checkBox_Positioning_Completed.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Positioning_Completed.Checked = false;
                        }

                        if (Test_Operation == 1)//測試用
                        {
                            MR_2103 = 1;
                            MR_2015 = 1;
                        }
                        
                        //下一頁 是否可按
                        if (MR_2103 >= 1 && MR_2015 >= 1)
                        {
                            btn_Next4.Enabled = true;
                        }
                        else
                        {
                            btn_Next4.Enabled = false;
                        }
                    }
                    //操作指南5
                    if (panel_Operation_Guide5.Visible == true)
                    {
                        MR_300 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "300"); //讀取MR_300
                        MR_2103 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2103"); //讀取MR_2103
                        DM_600 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "600"); //讀取DM_600

                        //X軸
                        if (MR_300 >= 1)
                        {
                            checkBox_Xaxis.Checked = true;
                            checkBox_Xaxis.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Xaxis.Checked = false;
                        }

                        //螺桿位置
                        if (DM_600 >= 0)
                        {
                            DM_600_Ten = DM_600 / 10;
                            DM_600_Decimal = DM_600 % 10;
                            label_Screw_Position_Value.Text = DM_600_Ten.ToString() + "." + DM_600_Decimal.ToString();
                        }
                        else
                        {
                            label_Screw_Position_Value.Text = DM_600.ToString();
                        }                       
                    }

                    //進入主畫面後 如果出現錯誤
                    if (Error_Message_Timely == 1)
                    {
                        MR_1500 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1500"); //讀取MR_1500
                        MR_1501 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1501"); //讀取MR_1501
                        MR_1502 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1502"); //讀取MR_1502
                        MR_1503 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1503"); //讀取MR_1503
                        MR_1504 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1504"); //讀取MR_1504
                        MR_1505 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1505"); //讀取MR_1505
                        MR_1506 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1506"); //讀取MR_1506
                        MR_1507 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1507"); //讀取MR_1507
                        MR_1508 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1508"); //讀取MR_1508
                        MR_1509 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1509"); //讀取MR_1509
                        MR_1510 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1510"); //讀取MR_1510
                        MR_1511 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1511"); //讀取MR_1511
                        MR_1512 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1512"); //讀取MR_1512
                        MR_1513 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1513"); //讀取MR_1513
                        MR_1514 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1514"); //讀取MR_1514
                        MR_1515 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1515"); //讀取MR_1515
                        MR_1600 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1600"); //讀取MR_1600
                        MR_1601 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1601"); //讀取MR_1601
                        MR_1602 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1602"); //讀取MR_1602
                        //MR_1603 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1603"); //讀取MR_1603

                        Error_Message = "";
                        //MR_1505 = 1;
                        #region 錯誤訊息顯示(MR_1500~MR_1515和MR_1600~MR_1603)
                        if (MR_1500 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1500" + "\r\n";
                        }
                        if (MR_1501 >= 1)
                        {
                            Error_Message = Error_Message + "入料軌道上工件不足" + "\r\n";
                        }
                        if (MR_1502 >= 1)
                        {
                            Error_Message = Error_Message + "原點復歸時間過長" + "\r\n";
                        }
                        if (MR_1503 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1503" + "\r\n";
                        }
                        if (MR_1504 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1504" + "\r\n";
                        }
                        if (MR_1505 >= 1)
                        {
                            Error_Message = Error_Message + "入料口異常" + "\r\n";
                        }
                        if (MR_1506 >= 1)
                        {
                            Error_Message = Error_Message + "入料口無料" + "\r\n";
                        }
                        if (MR_1507 >= 1)
                        {
                            Error_Message = Error_Message + "上升機構錯誤" + "\r\n";
                        }
                        if (MR_1508 >= 1)
                        {
                            Error_Message = Error_Message + "夾具機構錯誤" + "\r\n";
                        }
                        if (MR_1509 >= 1)
                        {
                            Error_Message = Error_Message + "手動模式開啟無法啟動" + "\r\n";
                        }
                        if (MR_1510 >= 1)
                        {
                            Error_Message = Error_Message + "轉盤錯誤" + "\r\n";
                        }
                        if (MR_1511 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1511" + "\r\n";
                        }
                        if (MR_1512 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1512" + "\r\n";
                        }
                        if (MR_1513 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1513" + "\r\n";
                        }
                        if (MR_1514 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1514" + "\r\n";
                        }
                        if (MR_1515 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1515" + "\r\n";
                        }

                        if (MR_1600 >= 1)
                        {
                            Error_Message = Error_Message + "到達下死點" + "\r\n";
                        }
                        if (MR_1601 >= 1)
                        {
                            Error_Message = Error_Message + "到達上死點" + "\r\n";
                        }
                        if (MR_1602 >= 1)
                        {
                            Error_Message = Error_Message + "尚未原點復歸" + "\r\n";
                        }
                        if (MR_1603 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1603" + "\r\n";
                        }
                        #endregion


                        if (MR_1500 >= 1 || MR_1502 >= 1 || MR_1503 >= 1 || MR_1504 >= 1 ||
                            MR_1505 >= 1 || MR_1507 >= 1 || MR_1508 >= 1 || MR_1509 >= 1 ||
                            MR_1510 >= 1 || MR_1511 >= 1 || MR_1512 >= 1 || MR_1513 >= 1 ||
                            MR_1514 >= 1 || MR_1515 >= 1 || MR_1602 >= 1
                            && Now_Minute - Now_Minute_Interval_Error > 0)
                        {
                            textBox_Error_Message.Text = Error_Message;
                            panel_Error_Message.Visible = true;
                        }
                    }
                    //畫面為速度設定時
                    if (panel_WorkingSpeed.Visible == true)
                    {
                        MR_104 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "104"); //讀取MR104
                        RLY_40005 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40005"); //讀取MR40005
                        RLY_40006 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40006"); //讀取MR40006
                        RLY_40004 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40004"); //讀取MR40004
                        RLY_40008 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40008"); //讀取MR40008
                        RLY_40009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取MR40009

                        DM_90 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "90"); //讀取DM90
                        textBox_CurrentSpeed.Text = DM_90.ToString();

                        //定位完成
                        if (MR_104 >= 1)
                        {
                            checkBox_Positioning_Completed1.Checked = true;
                            checkBox_Positioning_Completed1.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Positioning_Completed1.Checked = false;
                        }

                        //螺桿 上死點
                        if (RLY_40005 >= 1)
                        {
                            checkBox_Screw_Up_Dead.Checked = true;
                            checkBox_Screw_Up_Dead.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Screw_Up_Dead.Checked = false;
                        }

                        //螺桿 下死點
                        if (RLY_40004 >= 1)
                        {
                            checkBox_Screw_Down_Dead.Checked = true;
                            checkBox_Screw_Down_Dead.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Screw_Down_Dead.Checked = false;
                        }

                        //出料 sensor
                        if (RLY_40006 >= 1)
                        {
                            checkBox_Discharge_Sensor.Checked = true;
                            checkBox_Discharge_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Discharge_Sensor.Checked = false;
                        }

                        //無料 sensor
                        if (RLY_40008 >= 1)
                        {
                            checkBox_Nomaterial_Sensor.Checked = true;
                            checkBox_Nomaterial_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Nomaterial_Sensor.Checked = false;
                        }

                        //滿料 sensor
                        if (RLY_40009 >= 1)
                        {
                            checkBox_FullMaterial_Sensor.Checked = true;
                            checkBox_FullMaterial_Sensor.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_FullMaterial_Sensor.Checked = false;
                        }
                    }
                    //畫面為系統計數時
                    if (panel_Counting_System.Visible == true)
                    {
                        DM_97 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "97"); //讀取DM97
                        DM_12 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "12"); //讀取DM12

                        textBox_Total_Number_Actions.Text = DM_97.ToString();
                        textBox_Stroke_Rate.Text = DM_12.ToString();
                    }

                    //畫面為手動模式時
                    if (panel_Manual_Mode.Visible == true)
                    {
                        //原點復歸
                        if (panel_OPR.Visible == true)
                        {
                            MR_0 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0"); //讀取MR0

                            if (Test_Operation == 1)//測試用
                            {
                                MR_0 = 1;
                            }

                            if (MR_0 >= 1)
                            {
                                button_OPR_Confirmation.Enabled = true;
                            }
                            else
                            {
                                button_OPR_Confirmation.Enabled = false;
                            }
 
                        }
                        MR_14 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "14"); //讀取MR14
                        MR_15 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15"); //讀取MR15
                        //MR_5 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "5"); //讀取MR5

                        if (Test_Operation == 1)//測試用
                        {
                            MR_14 = 1;
                            MR_15 = 1;
                            //MR_5 = 1;
                        }
                        
                        //手動模式情形
                        if (MR_14 >= 1)
                        {
                            button_Manual_Mode_Run.BackColor = Color.GreenYellow;//手動模式
                            button_Turn_Handwheel.Enabled = true;
                            button_Turn_Vibration_Plate.Enabled = true;
                            button_Tool_Rotation_Run.Enabled = true;
                            button_Empty_Disk.Enabled = true;
                            button_Continuous_Action.Enabled = true;
                            button_Motor_Start_Run.Enabled = true;
                            button_OPR_Run.Enabled = true;
                        }
                        else
                        {
                            button_Manual_Mode_Run.BackColor = Color.Transparent;//手動模式
                            button_Turn_Handwheel.Enabled = false;
                            button_Turn_Vibration_Plate.Enabled = false;
                            button_Tool_Rotation_Run.Enabled = false;
                            button_Empty_Disk.Enabled = false;
                            button_Continuous_Action.Enabled = false;
                            button_Motor_Start_Run.Enabled = false;
                            button_OPR_Run.Enabled = false;
                        }

                        //手輪開啟情形
                        if (MR_15 >= 1)
                        {
                            button_Turn_Handwheel.BackColor = Color.GreenYellow;//手輪開啟
                            button_Turntable_Correction.Enabled = true;
                            button_Calibration_Fixture.Enabled = true;
                            button_Calibration_Screw.Enabled = true;
                        }
                        else
                        {
                            button_Turn_Handwheel.BackColor = Color.Transparent;//手輪開啟
                            button_Turntable_Correction.Enabled = false;
                            button_Calibration_Fixture.Enabled = false;
                            button_Calibration_Screw.Enabled = false;
                        }

                        /*if (MR_5 >= 1)
                        {
                            button_A_Loop.Enabled = true;
                        }
                        else
                        {
                            button_A_Loop.Enabled = false;
                        }*/

                        //開啟震動盤
                        MR_209 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "209"); //讀取MR209
                        if (MR_209 >= 1)
                        {
                            button_Turn_Vibration_Plate.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Turn_Vibration_Plate.BackColor = Color.Transparent;
                        }

                        //刀具旋轉
                        MR_207 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207"); //讀取MR207
                        if (MR_207 >= 1)
                        {
                            button_Tool_Rotation_Run.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Tool_Rotation_Run.BackColor = Color.Transparent;
                        }

                        //連續動作
                        MR_6 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6"); //讀取MR6
                        if (MR_6 >= 1)
                        {
                            button_Continuous_Action.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Continuous_Action.BackColor = Color.Transparent;
                        }

                        //馬達啟動
                        MR_0 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0"); //讀取MR0
                        if (MR_0 >= 1)
                        {
                            button_Motor_Start_Run.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Motor_Start_Run.BackColor = Color.Transparent;
                        }

                        //一循環
                        MR_5 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "5"); //讀取MR5
                        if (MR_5 >= 1)
                        {
                            button_A_Loop.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_A_Loop.BackColor = Color.Transparent;
                        }
                    }

                    //畫面為轉盤校正時
                    if (panel_Turntable_Correction.Visible == true)
                    {
                        //畫面開啟
                        if (panel_Turntable_Correction_Determine_Disk.Visible == true)
                        {
                            MR_300 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "300"); //讀取MR_300

                            if (Test_Operation == 1)//測試用
                            {
                                MR_300 = 0;
                            }
                            
                            if (MR_300 >= 1)
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Enabled = false;
                                checkBox_OFF_State_Disk.Checked = false;
                            }
                            else
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Disk_Determine.Enabled = true;
                                checkBox_OFF_State_Disk.Checked = true;
                                checkBox_OFF_State_Disk.CheckState = CheckState.Indeterminate;
                            }
                        }
                        else if (panel_Correction_Boot_Disk1.Visible == true)
                        {
                            RLY_40007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40007"); //讀取RLY_40007
                            RLY_40009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取RLY_40009
                            RLY_40010 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40010"); //讀取RLY_40010
                            MR_2506 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2506"); //讀取MR_2506

                            if (Test_Operation == 1)//測試用
                            {
                                RLY_40009 = 1;
                                MR_2506 = 1;
                            }
                            
                            //螺桿機構下死點感測器
                            if (RLY_40009 >= 1)
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor.Checked = true;
                                checkBox_Screw_Mechanism_Dead_Point_Sensor.CheckState = CheckState.Indeterminate;
                                button_Turntable_Correction_Determine.Enabled = true;
                            }
                            else
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor.Checked = false;
                                button_Turntable_Correction_Determine.Enabled = false;
                            }

                            //夾具機構後死點感測器
                            if (RLY_40007 >= 1)
                            {
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Checked = true;
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor.Checked = false;
                            }

                            //盤面原點復歸點
                            if (RLY_40010 >= 1)
                            {
                                checkBox_Disk_OPR_Point.Checked = true;
                                checkBox_Disk_OPR_Point.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Disk_OPR_Point.Checked = false;
                            }
                            
                            //盤面原點復歸完畢
                            if (MR_2506 >= 1)
                            {
                                checkBox_OPR_Complete_Disk.Checked = true;
                                checkBox_OPR_Complete_Disk.CheckState = CheckState.Indeterminate;
                                button_Turntable_Correction_Next.Enabled = true;
                            }
                            else
                            {
                                checkBox_OPR_Complete_Disk.Checked = false;
                                button_Turntable_Correction_Next.Enabled = false;
                            }
                        }
                        else if(panel_Correction_Boot_Disk2.Visible == true)
                        {
                            RLY_40009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取RLY_40009

                            if (Test_Operation == 1)//測試用
                            {
                                RLY_40009 = 0;
                                MR_2506 = 1;
                            }
                            
                            //螺桿機構下死點感測器
                            if (RLY_40009 >= 1)
                            {
                                checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Checked = false;
                                button_Turntable_Correction_Complete.Enabled = false;
                            }
                            else
                            {
                                checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.Checked = true;
                                checkBox_Screw_Mechanism_Away_Dead_Point_Sensor.CheckState = CheckState.Indeterminate;
                                button_Turntable_Correction_Complete.Enabled = true;
                            }                       
                        }
                    }
                    //夾具夾具補正引導頁面
                    if (panel_Calibration_Fixture.Visible == true)
                    {
                        if (panel_Turntable_Correction_Determine_Fixture.Visible == true)
                        {
                            MR_300 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "300"); //讀取MR_300

                            if (Test_Operation == 1)//測試用
                            {
                                MR_300 = 0;
                            }
                            
                            if (MR_300 >= 1)
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Enabled = false;
                                checkBox_OFF_State_Fixture.Checked = false;
                            }
                            else
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine.Enabled = true;
                                checkBox_OFF_State_Fixture.Checked = true;
                                checkBox_OFF_State_Fixture.CheckState = CheckState.Indeterminate;  
                            }
                        }
                        else if (panel_Correcting_Jig_Guide1.Visible == true)
                        {
                            RLY_40007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40007"); //讀取RLY_40007
                            MR_2502 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2502"); //讀取MR_2502

                            if (Test_Operation == 1)//測試用
                            {
                                RLY_40007 = 1;
                                MR_2502 = 1;
                            }

                            //夾具機構後死點感測器(順時針)
                            if (RLY_40007 >= 1)
                            {
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Checked = true;
                                button_Correcting_Jig_Guide_Determine1.Enabled = true;
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                button_Correcting_Jig_Guide_Determine1.Enabled = false;
                                checkBox_After_Clamp_Mechanism_Dead_Point_Sensor_clockwise.Checked = false;
                            }

                            //夾具原點復歸完畢
                            if (MR_2502 >= 1)
                            {
                                checkBox_OPR_Completed_Jig.Checked = true;
                                checkBox_OPR_Completed_Jig.CheckState = CheckState.Indeterminate;
                                button_Correcting_Jig_Guide_Next.Enabled = true;
                            }
                            else
                            {
                                checkBox_OPR_Completed_Jig.Checked = false;
                                button_Correcting_Jig_Guide_Next.Enabled = false;
                            }
                        }
                    }
                    //清空盤面頁面
                    if (panel_Empty_Disk.Visible == true)
                    {
                        MR_410 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "410"); //讀取MR_410
                        C_6 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_C, "6"); //讀取C_6
                        MR_413 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "413"); //讀取MR_413

                        if (Test_Operation == 1)//測試用
                        {
                            MR_410 = 1;
                        }
                        
                        if (MR_410 >= 1)
                        {
                            button_label_Start_Empty_Disk_Confirm.Enabled = true;
                        }
                        else
                        {
                            button_label_Start_Empty_Disk_Confirm.Enabled = false;
                        }

                        if (C_6 >= 1)
                        {
                            checkBox_Disk_Empty.Checked = true;
                            checkBox_Disk_Empty.CheckState = CheckState.Indeterminate;
                            checkBox_Machine_Can_Turned_Off.Checked = true;
                            checkBox_Machine_Can_Turned_Off.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Disk_Empty.Checked = false;
                            checkBox_Machine_Can_Turned_Off.Checked = false;
                        }
                        if (MR_413 >= 1)
                        {
                            checkBox_Empty_Disk.Checked = true;
                            checkBox_Empty_Disk.CheckState = CheckState.Indeterminate;
                        }
                        else
                        {
                            checkBox_Empty_Disk.Checked = false;
                        }
                    }
                    //畫面為螺桿補正時
                    if (panel_Screw_Correction_Guide.Visible == true)
                    {
                        if (panel_Turntable_Correction_Determine_Screw.Visible == true)
                        {
                            MR_300 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "300"); //讀取MR_300
                            
                            if (Test_Operation == 1)//測試用
                            {
                                MR_300 = 1;
                            }

                            if (MR_300 >= 1)
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Enabled = true;
                                checkBox_OFF_State_Screw.Checked = true;
                                checkBox_OFF_State_Screw.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine.Enabled = false;
                                checkBox_OFF_State_Screw.Checked = false;
                            }
                        }
                        else if (panel_Screw_Correction_Guide1.Visible == true)
                        {
                            RLY_40009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取RLY_40009
                            MR_2511 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2502"); //讀取MR_2511

                            if (Test_Operation == 1)//測試用
                            {
                                RLY_40009 = 1;
                                MR_2511 = 1;
                            }
                            
                            //螺桿機構下死點感測器
                            if (RLY_40009 >= 1)
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Checked = true;
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.CheckState = CheckState.Indeterminate;
                                button_OPR_Performed_After_Confirmation_Screw_Confirm.Enabled = true;
                            }
                            else
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw1.Checked = false;
                                button_OPR_Performed_After_Confirmation_Screw_Confirm.Enabled = false;
                            }
                            
                            if (MR_2511 >= 1)
                            {
                                checkBox_Screw_OPR_Completed.Checked = true;
                                checkBox_Screw_OPR_Completed.CheckState = CheckState.Indeterminate;
                                button_Screw_Correction_Guide_Next.Enabled = true;
                            }
                            else
                            {
                                checkBox_Screw_OPR_Completed.Checked = false;
                                button_Screw_Correction_Guide_Next.Enabled = false;
                            }
                        }
                        else if (panel_Screw_Correction_Guide2.Visible == true)
                        {
                            RLY_40009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取RLY_40009

                            if (Test_Operation == 1)//測試用
                            {
                                RLY_40009 = 1;
                            }
                            
                            //螺桿機構下死點感測器
                            if (RLY_40009 >= 1)
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Checked = true;
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.CheckState = CheckState.Indeterminate;
                                //button_Screw_Correction_Guide_Complete.Enabled = true;
                            }
                            else
                            {
                                checkBox_Screw_Mechanism_Dead_Point_Sensor_Screw2.Checked = false;
                                //button_Screw_Correction_Guide_Complete.Enabled = false;
                            }
                        }
                    }

                    //畫面為錯誤訊息時
                    if (panel_Error_Message.Visible == true)
                    {
                        MR_1500 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1500"); //讀取MR_1500
                        MR_1501 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1501"); //讀取MR_1501
                        MR_1502 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1502"); //讀取MR_1502
                        MR_1503 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1503"); //讀取MR_1503
                        MR_1504 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1504"); //讀取MR_1504
                        MR_1505 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1505"); //讀取MR_1505
                        MR_1506 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1506"); //讀取MR_1506
                        MR_1507 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1507"); //讀取MR_1507
                        MR_1508 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1508"); //讀取MR_1508
                        MR_1509 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1509"); //讀取MR_1509
                        MR_1510 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1510"); //讀取MR_1510
                        MR_1511 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1511"); //讀取MR_1511
                        MR_1512 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1512"); //讀取MR_1512
                        MR_1513 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1513"); //讀取MR_1513
                        MR_1514 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1514"); //讀取MR_1514
                        MR_1515 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1515"); //讀取MR_1515
                        MR_1600 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1600"); //讀取MR_1600
                        MR_1601 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1601"); //讀取MR_1601
                        MR_1602 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1602"); //讀取MR_1602
                        MR_1603 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "1603"); //讀取MR_1603

                        Error_Message = "";

                        #region 錯誤訊息顯示(MR_1500~MR_1515和MR_1600~MR_1603)
                        if (MR_1500 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1500" + "\r\n";
                        }
                        if (MR_1501 >= 1)
                        {
                            Error_Message = Error_Message + "入料軌道上工件不足" + "\r\n";
                        }
                        if (MR_1502 >= 1)
                        {
                            Error_Message = Error_Message + "原點復歸時間過長" + "\r\n";
                        }
                        if (MR_1503 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1503" + "\r\n";
                        }
                        if (MR_1504 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1504" + "\r\n";
                        }
                        if (MR_1505 >= 1)
                        {
                            Error_Message = Error_Message + "入料口異常" + "\r\n";
                        }
                        if (MR_1506 >= 1)
                        {
                            Error_Message = Error_Message + "入料口無料" + "\r\n";
                        }
                        if (MR_1507 >= 1)
                        {
                            Error_Message = Error_Message + "上升機構錯誤" + "\r\n";
                        }
                        if (MR_1508 >= 1)
                        {
                            Error_Message = Error_Message + "夾具機構錯誤" + "\r\n";
                        }
                        if (MR_1509 >= 1)
                        {
                            Error_Message = Error_Message + "手動模式開啟無法啟動" + "\r\n";
                        }
                        if (MR_1510 >= 1)
                        {
                            Error_Message = Error_Message + "轉盤錯誤" + "\r\n";
                        }
                        if (MR_1511 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1511" + "\r\n";
                        }
                        if (MR_1512 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1512" + "\r\n";
                        }
                        if (MR_1513 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1513" + "\r\n";
                        }
                        if (MR_1514 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1514" + "\r\n";
                        }
                        if (MR_1515 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1515" + "\r\n";
                        }

                        if (MR_1600 >= 1)
                        {
                            Error_Message = Error_Message + "到達下死點" + "\r\n";
                        }
                        if (MR_1601 >= 1)
                        {
                            Error_Message = Error_Message + "到達上死點" + "\r\n";
                        }
                        if (MR_1602 >= 1)
                        {
                            Error_Message = Error_Message + "尚未原點復歸" + "\r\n";
                        }
                        if (MR_1603 >= 1)
                        {
                            Error_Message = Error_Message + "MR_1603" + "\r\n";
                        }
                        #endregion

                        textBox_Error_Message.Text = Error_Message;
                    }

                    //畫面為I/O時
                    if (panel_I_O_Table.Visible == true)
                    {
                        if (panel_I_O_Table_X.Visible == true)
                        {
                            R_X000 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40000"); //讀取R_X000
                            R_X001 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40001"); //讀取R_X001
                            R_X002 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40002"); //讀取R_X002
                            R_X003 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40003"); //讀取R_X003
                            R_X004 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40004"); //讀取R_X004
                            R_X005 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40005"); //讀取R_X005
                            R_X006 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40006"); //讀取R_X006
                            R_X007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40007"); //讀取R_X007
                            R_X008 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40008"); //讀取R_X008
                            R_X009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40009"); //讀取R_X009
                            R_X010 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40010"); //讀取R_X010
                            R_X011 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40011"); //讀取R_X011
                            R_X012 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40012"); //讀取R_X012
                            R_X013 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40013"); //讀取R_X013
                            R_X014 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40014"); //讀取R_X014
                            R_X015 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40015"); //讀取R_X015
                            #region I/O顯示(R_X000~R_X015)
                            if (R_X000 >= 1)//R_X000
                            {
                                checkBox_X000.Checked = true;
                                checkBox_X000.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X000.Checked = false;
                            }

                            if (R_X001 >= 1)//R_X001
                            {
                                checkBox_X001.Checked = true;
                                checkBox_X001.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X001.Checked = false;
                            }

                            if (R_X002 >= 1)//R_X002
                            {
                                checkBox_X002.Checked = true;
                                checkBox_X002.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X002.Checked = false;
                            }

                            if (R_X003 >= 1)//R_X003
                            {
                                checkBox_X003.Checked = true;
                                checkBox_X003.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X003.Checked = false;
                            }

                            if (R_X004 >= 1)//R_X004
                            {
                                checkBox_X004.Checked = true;
                                checkBox_X004.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X004.Checked = false;
                            }

                            if (R_X005 >= 1)//R_X005
                            {
                                checkBox_X005.Checked = true;
                                checkBox_X005.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X005.Checked = false;
                            }

                            if (R_X006 >= 1)//R_X006
                            {
                                checkBox_X006.Checked = true;
                                checkBox_X006.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X006.Checked = false;
                            }

                            if (R_X007 >= 1)//R_X007
                            {
                                checkBox_X007.Checked = true;
                                checkBox_X007.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X007.Checked = false;
                            }

                            if (R_X008 >= 1)//R_X008
                            {
                                checkBox_X008.Checked = true;
                                checkBox_X008.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X008.Checked = false;
                            }

                            if (R_X009 >= 1)//R_X009
                            {
                                checkBox_X009.Checked = true;
                                checkBox_X009.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X009.Checked = false;
                            }

                            if (R_X010 >= 1)//R_X010
                            {
                                checkBox_X010.Checked = true;
                                checkBox_X010.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X010.Checked = false;
                            }

                            if (R_X011 >= 1)//R_X011
                            {
                                checkBox_X011.Checked = true;
                                checkBox_X011.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X011.Checked = false;
                            }

                            if (R_X012 >= 1)//R_X012
                            {
                                checkBox_X012.Checked = true;
                                checkBox_X012.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X012.Checked = false;
                            }

                            if (R_X013 >= 1)//R_X013
                            {
                                checkBox_X013.Checked = true;
                                checkBox_X013.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X013.Checked = false;
                            }

                            if (R_X014 >= 1)//R_X014
                            {
                                checkBox_X014.Checked = true;
                                checkBox_X014.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X014.Checked = false;
                            }

                            if (R_X015 >= 1)//R_X015
                            {
                                checkBox_X015.Checked = true;
                                checkBox_X015.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X015.Checked = false;
                            }
                            #endregion

                            R_X100 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40100"); //讀取R_X100
                            R_X101 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40101"); //讀取R_X101
                            R_X102 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40102"); //讀取R_X102
                            R_X103 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40103"); //讀取R_X103
                            R_X104 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40104"); //讀取R_X104
                            R_X105 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40105"); //讀取R_X105
                            R_X106 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40106"); //讀取R_X106
                            R_X107 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40107"); //讀取R_X107
                            R_X108 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40108"); //讀取R_X108
                            R_X109 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40109"); //讀取R_X109
                            R_X110 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40110"); //讀取R_X110
                            R_X111 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40111"); //讀取R_X111
                            R_X112 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40112"); //讀取R_X112
                            R_X113 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40113"); //讀取R_X113
                            R_X114 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40114"); //讀取R_X114
                            R_X115 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40115"); //讀取R_X115
                            #region I/O顯示(R_X100~R_X115)
                            if (R_X100 >= 1)//R_X100
                            {
                                checkBox_X100.Checked = true;
                                checkBox_X100.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X100.Checked = false;
                            }

                            if (R_X101 >= 1)//R_X101
                            {
                                checkBox_X101.Checked = true;
                                checkBox_X101.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X101.Checked = false;
                            }

                            if (R_X102 >= 1)//R_X102
                            {
                                checkBox_X102.Checked = true;
                                checkBox_X102.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X102.Checked = false;
                            }

                            if (R_X103 >= 1)//R_X103
                            {
                                checkBox_X103.Checked = true;
                                checkBox_X103.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X103.Checked = false;
                            }

                            if (R_X104 >= 1)//R_X104
                            {
                                checkBox_X104.Checked = true;
                                checkBox_X104.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X104.Checked = false;
                            }

                            if (R_X105 >= 1)//R_X105
                            {
                                checkBox_X105.Checked = true;
                                checkBox_X105.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X105.Checked = false;
                            }

                            if (R_X106 >= 1)//R_X106
                            {
                                checkBox_X106.Checked = true;
                                checkBox_X106.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X106.Checked = false;
                            }

                            if (R_X107 >= 1)//R_X107
                            {
                                checkBox_X107.Checked = true;
                                checkBox_X107.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X107.Checked = false;
                            }

                            if (R_X108 >= 1)//R_X108
                            {
                                checkBox_X108.Checked = true;
                                checkBox_X108.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X108.Checked = false;
                            }

                            if (R_X109 >= 1)//R_X109
                            {
                                checkBox_X109.Checked = true;
                                checkBox_X109.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X109.Checked = false;
                            }

                            if (R_X110 >= 1)//R_X110
                            {
                                checkBox_X110.Checked = true;
                                checkBox_X110.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X110.Checked = false;
                            }

                            if (R_X111 >= 1)//R_X111
                            {
                                checkBox_X111.Checked = true;
                                checkBox_X111.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X111.Checked = false;
                            }

                            if (R_X112 >= 1)//R_X112
                            {
                                checkBox_X112.Checked = true;
                                checkBox_X112.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X112.Checked = false;
                            }

                            if (R_X113 >= 1)//R_X113
                            {
                                checkBox_X113.Checked = true;
                                checkBox_X113.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X113.Checked = false;
                            }

                            if (R_X114 >= 1)//R_X114
                            {
                                checkBox_X114.Checked = true;
                                checkBox_X114.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X114.Checked = false;
                            }

                            if (R_X115 >= 1)//R_X115
                            {
                                checkBox_X115.Checked = true;
                                checkBox_X115.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_X115.Checked = false;
                            }
                            #endregion
                        }
                        else if (panel_I_O_Table_Y.Visible == true)
                        {
                            R_Y000 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40200"); //讀取R_Y000
                            R_Y001 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40201"); //讀取R_Y001
                            R_Y002 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40202"); //讀取R_Y002
                            R_Y003 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40203"); //讀取R_Y003
                            R_Y004 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40204"); //讀取R_Y004
                            R_Y005 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40205"); //讀取R_Y005
                            R_Y006 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40206"); //讀取R_Y006
                            R_Y007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40207"); //讀取R_Y007
                            R_Y008 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40208"); //讀取R_Y008
                            R_Y009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40209"); //讀取R_Y009
                            R_Y010 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40210"); //讀取R_Y010
                            R_Y011 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40211"); //讀取R_Y011
                            R_Y012 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40212"); //讀取R_Y012
                            R_Y013 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40213"); //讀取R_Y013
                            R_Y014 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40214"); //讀取R_Y014
                            R_Y015 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40215"); //讀取R_Y015
                            #region I/O顯示(R_Y000~R_Y015)
                            if (R_Y000 >= 1)//R_Y000
                            {
                                checkBox_Y000.Checked = true;
                                checkBox_Y000.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y000.Checked = false;
                            }

                            if (R_Y001 >= 1)//R_Y001
                            {
                                checkBox_Y001.Checked = true;
                                checkBox_Y001.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y001.Checked = false;
                            }

                            if (R_Y002 >= 1)//R_Y002
                            {
                                checkBox_Y002.Checked = true;
                                checkBox_Y002.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y002.Checked = false;
                            }

                            if (R_Y003 >= 1)//R_Y003
                            {
                                checkBox_Y003.Checked = true;
                                checkBox_Y003.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y003.Checked = false;
                            }

                            if (R_Y004 >= 1)//R_Y004
                            {
                                checkBox_Y004.Checked = true;
                                checkBox_Y004.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y004.Checked = false;
                            }

                            if (R_Y005 >= 1)//R_Y005
                            {
                                checkBox_Y005.Checked = true;
                                checkBox_Y005.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y005.Checked = false;
                            }

                            if (R_Y006 >= 1)//R_Y006
                            {
                                checkBox_Y006.Checked = true;
                                checkBox_Y006.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y006.Checked = false;
                            }

                            if (R_Y007 >= 1)//R_Y007
                            {
                                checkBox_Y007.Checked = true;
                                checkBox_Y007.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y007.Checked = false;
                            }

                            if (R_Y008 >= 1)//R_Y008
                            {
                                checkBox_Y008.Checked = true;
                                checkBox_Y008.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y008.Checked = false;
                            }

                            if (R_Y009 >= 1)//R_Y009
                            {
                                checkBox_Y009.Checked = true;
                                checkBox_Y009.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y009.Checked = false;
                            }

                            if (R_Y010 >= 1)//R_Y010
                            {
                                checkBox_Y010.Checked = true;
                                checkBox_Y010.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y010.Checked = false;
                            }

                            if (R_Y011 >= 1)//R_Y011
                            {
                                checkBox_Y011.Checked = true;
                                checkBox_Y011.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y011.Checked = false;
                            }

                            if (R_Y012 >= 1)//R_Y012
                            {
                                checkBox_Y012.Checked = true;
                                checkBox_Y012.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y012.Checked = false;
                            }

                            if (R_Y013 >= 1)//R_Y013
                            {
                                checkBox_Y013.Checked = true;
                                checkBox_Y013.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y013.Checked = false;
                            }

                            if (R_Y014 >= 1)//R_Y014
                            {
                                checkBox_Y014.Checked = true;
                                checkBox_Y014.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y014.Checked = false;
                            }

                            if (R_Y015 >= 1)//R_Y015
                            {
                                checkBox_Y015.Checked = true;
                                checkBox_Y015.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y015.Checked = false;
                            }
                            #endregion

                            R_Y100 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40300"); //讀取R_Y100
                            R_Y101 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40301"); //讀取R_Y101
                            R_Y102 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40302"); //讀取R_Y102
                            R_Y103 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40303"); //讀取R_Y103
                            R_Y104 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40304"); //讀取R_Y104
                            R_Y105 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40305"); //讀取R_Y105
                            R_Y106 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40306"); //讀取R_Y106
                            R_Y107 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40307"); //讀取R_Y107
                            R_Y108 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40308"); //讀取R_Y108
                            R_Y109 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40309"); //讀取R_Y109
                            R_Y110 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40310"); //讀取R_Y110
                            R_Y111 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40311"); //讀取R_Y111
                            R_Y112 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40312"); //讀取R_Y112
                            R_Y113 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40313"); //讀取R_Y113
                            R_Y114 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40314"); //讀取R_Y114
                            R_Y115 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "40315"); //讀取R_Y115
                            #region I/O顯示(R_Y100~R_Y115)
                            if (R_Y100 >= 1)//R_Y100
                            {
                                checkBox_Y100.Checked = true;
                                checkBox_Y100.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y100.Checked = false;
                            }

                            if (R_Y101 >= 1)//R_Y101
                            {
                                checkBox_Y101.Checked = true;
                                checkBox_Y101.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y101.Checked = false;
                            }

                            if (R_Y102 >= 1)//R_Y102
                            {
                                checkBox_Y102.Checked = true;
                                checkBox_Y102.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y102.Checked = false;
                            }

                            if (R_Y103 >= 1)//R_Y103
                            {
                                checkBox_Y103.Checked = true;
                                checkBox_Y103.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y103.Checked = false;
                            }

                            if (R_Y104 >= 1)//R_Y104
                            {
                                checkBox_Y104.Checked = true;
                                checkBox_Y104.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y104.Checked = false;
                            }

                            if (R_Y105 >= 1)//R_Y105
                            {
                                checkBox_Y105.Checked = true;
                                checkBox_Y105.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y105.Checked = false;
                            }

                            if (R_Y106 >= 1)//R_Y106
                            {
                                checkBox_Y106.Checked = true;
                                checkBox_Y106.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y106.Checked = false;
                            }

                            if (R_Y107 >= 1)//R_Y107
                            {
                                checkBox_Y107.Checked = true;
                                checkBox_Y107.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y107.Checked = false;
                            }

                            if (R_Y108 >= 1)//R_Y108
                            {
                                checkBox_Y108.Checked = true;
                                checkBox_Y108.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y108.Checked = false;
                            }

                            if (R_Y109 >= 1)//R_Y109
                            {
                                checkBox_Y109.Checked = true;
                                checkBox_Y109.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y109.Checked = false;
                            }

                            if (R_Y110 >= 1)//R_Y110
                            {
                                checkBox_Y110.Checked = true;
                                checkBox_Y110.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y110.Checked = false;
                            }

                            if (R_Y111 >= 1)//R_Y111
                            {
                                checkBox_Y111.Checked = true;
                                checkBox_Y111.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y111.Checked = false;
                            }

                            if (R_Y112 >= 1)//R_Y112
                            {
                                checkBox_Y112.Checked = true;
                                checkBox_Y112.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y112.Checked = false;
                            }

                            if (R_Y113 >= 1)//R_Y113
                            {
                                checkBox_Y113.Checked = true;
                                checkBox_Y113.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y113.Checked = false;
                            }

                            if (R_Y114 >= 1)//R_Y114
                            {
                                checkBox_Y114.Checked = true;
                                checkBox_Y114.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y114.Checked = false;
                            }

                            if (R_Y115 >= 1)//R_Y115
                            {
                                checkBox_Y115.Checked = true;
                                checkBox_Y115.CheckState = CheckState.Indeterminate;
                            }
                            else
                            {
                                checkBox_Y115.Checked = false;
                            }
                            #endregion
                        }
                    }

                    //畫面為隱藏頁面開啟時
                    if (panel_Hidden_Features.Visible == true)
                    {
                        DM_600 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "600"); //讀取DM_600
                        DM_200 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "200"); //讀取DM_200
                        DM_20006 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "20006"); //讀取DM_20006
                        label_Hidden_Features_Tool_Speed_Count.Text = DM_200.ToString();
                        label_Hidden_Features_Operating_Speed_Count.Text = DM_20006.ToString();

                        if (DM_600 >= 0)
                        {
                            DM_600_Ten = DM_600 / 10;
                            DM_600_Decimal = DM_600 % 10;

                            label_Hidden_Features_Screw_Position_Count.Text = DM_600_Ten.ToString() + "." + DM_600_Decimal.ToString();

                        }
                        else
                        {
                            label_Hidden_Features_Screw_Position_Count.Text = DM_600.ToString();
                        }

                        ///一直判斷狀態是否改變
                        //馬達啟動
                        MR_0 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0"); //讀取MR0
                        if (MR_0 >= 1)
                        {
                            button_Hidden_Features_Motor_Start.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Motor_Start.BackColor = Color.Transparent;
                        }

                        //螺桿同步
                        RLY_34602 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "34602"); //讀取RLY34602
                        if (RLY_34602 >= 1)
                        {
                            button_Hidden_Features_Screw_Synchronization.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Screw_Synchronization.BackColor = Color.Transparent;
                        }

                        //夾具同步
                        RLY_35402 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_RLY_B, "35402"); //讀取RLY35402
                        if (RLY_35402 >= 1)
                        {
                            button_Hidden_Features_Fixture_Synchronization.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Fixture_Synchronization.BackColor = Color.Transparent;
                        }

                        //連續
                        MR_6 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6"); //讀取MR6
                        if (MR_6 >= 1)
                        {
                            button_Hidden_Features_Continuous.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Continuous.BackColor = Color.Transparent;
                        }

                        //刀具旋轉
                        MR_207 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207"); //讀取MR207
                        if (MR_207 >= 1)
                        {
                            button_Hidden_Features_Tool_Rotation.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Tool_Rotation.BackColor = Color.Transparent;
                        }

                        //兩軸定位
                        MR_104 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "104"); //讀取MR104
                        if (MR_104 >= 1)
                        {
                            button_Hidden_Features_Two_Axis_Positioning.BackColor = Color.GreenYellow;
                        }
                        else
                        {
                            button_Hidden_Features_Two_Axis_Positioning.BackColor = Color.Transparent;
                        }
                    }
                }
                Thread.Sleep(500);
            }
        }

        public void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (obj_PLC.checkConnect(true, false) == true)
            {
                //已連線，進行斷線
                obj_PLC.doDeMoniter();
            }
            else
            {
                //return;
            }
            //關閉執行緒
            Thread_Switch = 0;
            Running = 0;
            //thread.Abort();//執行續強制停止

            //關閉程式時將Timer關閉
            //TimePLCProcess_Form1.Enabled = false;
        }

        //PLC連線
        public void btnConnect_Click(object sender, EventArgs e)
        {
            if (obj_PLC.checkConnect(true, false) == true)
            {
                //連線成功 將按鈕斷線及寫入開啟 連線則關閉
                /*btnConnect.Enabled = false;
                btnDisConnect.Enabled = true;
                btnSend.Enabled = true;*/

                //連線成功 將按鈕提供給使用者使用
                btn_Operation_Guide.Enabled = true;
                /*btn_NylonTrack.Enabled = true;
                btn_LubricatingOil.Enabled = true;
                btn_VibrationPlate.Enabled = true;
                btn_WorkingSpeedSetting.Enabled = true;
                btn_NutsRunway.Enabled = true;
                btn_LubricantContinuousAction.Enabled = true;
                btn_Abnormal_Lamp.Enabled = true;
                btn_Counter.Enabled = true;*/
                //Crawl_PLC_Information();
                Thread_Switch = 1;//開啟執行緒
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "PLC已連線";
                //MessageBox.Show("已連線");
                return;
            }
            else
            {
                //未連線，進行連線
                if (obj_PLC.doMoniter() == false)
                {
                    //Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(5).Second;//五秒後要更改系統狀態
                    lab_Progress.Text = "PLC連線失敗";
                    return;
                }
                //連線成功 將按鈕斷線及寫入開啟 連線則關閉
                /*btnConnect.Enabled = false;
                btnDisConnect.Enabled = true;
                btnSend.Enabled = true;*/

                //連線成功 將按鈕提供給使用者使用
                /*btn_NylonTrack.Enabled = true;
                btn_LubricatingOil.Enabled = true;
                btn_VibrationPlate.Enabled = true;
                btn_WorkingSpeedSetting.Enabled = true;
                btn_NutsRunway.Enabled = true;
                btn_LubricantContinuousAction.Enabled = true;
                btn_Abnormal_Lamp.Enabled = true;
                btn_Counter.Enabled = true;*/
                //Crawl_PLC_Information();
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "PLC連線成功";
                Thread_Switch = 1;//開啟執行緒
            }
        }

        //PLC斷線
        public void btnDisConnect_Click(object sender, EventArgs e)
        {
            if (obj_PLC.checkConnect(true, false) == true)
            {
                //已連線，進行斷線
                obj_PLC.doDeMoniter();

                //斷開連線 將按鈕連線開啟 斷線及寫入則關閉
                btn_Connect.Enabled = true;
                btnDisConnect.Enabled = false;
                btnSend.Enabled = false;

                //斷開後將所有Panel都隱藏 只留最原始的
                panel_High_Speed_Cutting.Visible = true;
                /*panel_WorkingSpeedSetting.Visible = false;
                panel_Abnormal_Lamp.Visible = false;
                panel_Counter.Visible = false;
                panel_FallSpeed.Visible = false;
                panel_Shutdown.Visible = false;*/

                //尚未連線 使用者無法使用按鈕
                /*btn_NylonTrack.Enabled = false;
                btn_LubricatingOil.Enabled = false;
                btn_VibrationPlate.Enabled = false;
                btn_WorkingSpeedSetting.Enabled = false;
                btn_NutsRunway.Enabled = false;
                btn_LubricantContinuousAction.Enabled = false;
                btn_Abnormal_Lamp.Enabled = false;
                btn_Counter.Enabled = false;*/
                lab_Progress.Text = "PLC斷線";
                Thread_Switch = 0; //關閉執行緒
            }
            else
            {              
                lab_Progress.Text = "PLC已斷線";
                Thread_Switch = 0; //關閉執行緒
                //MessageBox.Show("已斷線");
                return;
            }
        }

        //沒用到--------Start--------------
        public void btnSend_Click(object sender, EventArgs e)
        {
            //kv - N40dt;
            //寫入跟讀取PLC的範例
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR, "5002", 1);    //寫入MR
            int SpeedRight_MR = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR, "52"); //讀取MR
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_DM, "5", 1600);    //寫入DM
            int SpeedRight_DM = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_DM, "52"); //讀取DM
        }
        //沒用到---------End---------------

        
        //string value;
        //關閉程式
        private void btn_Close_Click(object sender, EventArgs e)
        {
            /*if (Form1.InputBox("確定要關閉程式？", "請輸入密碼:", ref value) == DialogResult.OK)
            {
                if (value == "0126")
                {
                    //MessageBox.Show("密碼正確，修改成功");*/
                    this.Close();
                    /*return;
                }
                else
                {
                    MessageBox.Show("密碼錯誤，修改失敗");
                    return;
                }
            }*/
        }

        //關機指令
        private void btn_Shutdown_Click(object sender, EventArgs e)
        {
            /*panel_WorkingSpeedSetting.Visible = false;
            panel_Abnormal_Lamp.Visible = false;
            panel_Counter.Visible = false;
            panel_FallSpeed.Visible = false;
            panel_MainScreen.Visible = false;
            panel_CloseProgram.Visible = false;*/

            panel_Shutdown.Visible = true;

            /*//關機
            System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\shutdown.exe", "-f -s -t 0");

            //登出
            System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\shutdown.exe", "-l");

            //休眠
            System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\rundll32.exe", "powrprof.dll,SetSuspendState");

            //重新開機
            System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\shutdown.exe", "-f -r -t 0");*/
        }

        //關機
        private void btn_Shutdown_close_Click(object sender, EventArgs e)
        {
            /*if (Form1.InputBox("確定要關機？", "請輸入密碼:", ref value) == DialogResult.OK)
            {
                if (value == "0126")
                {*/
                    //MessageBox.Show("密碼正確，修改成功");
                    //TimePLCProcess_Form1.Enabled = false;
                    System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\shutdown.exe", "-f -s -t 0");
                    this.Close();
                    /*return;
                }
                else
                {
                    MessageBox.Show("密碼錯誤，修改失敗");
                    return;
                }
            }*/
        }

        //重新開機
        private void btn_Reboot_Click(object sender, EventArgs e)
        {
            /*if (Form1.InputBox("確定要重新開機？", "請輸入密碼:", ref value) == DialogResult.OK)
            {
                if (value == "0126")
                {*/
                    //MessageBox.Show("密碼正確，修改成功");
                    //TimePLCProcess_Form1.Enabled = false;
                    System.Diagnostics.Process.Start("C:\\WINDOWS\\system32\\shutdown.exe", "-f -r -t 0");
                    this.Close();
                    /*return;
                }
                else
                {
                    MessageBox.Show("密碼錯誤，修改失敗");
                    return;
                }
            }*/
        }

        //關閉程式用-------------------Start-------------------
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panel_High_Speed_Cutting.Visible = true;
            panel_Shutdown.Visible = false;
        }

        private void lab_HideButton_DoubleClick(object sender, EventArgs e)
        {
            textBox_Password.Text = "";
            panel_CloseProgram.Visible = true;
        }

        private void btn_CancelClose_Click(object sender, EventArgs e)
        {
            panel_CloseProgram.Visible = false;
        }

        private void btn_OK_Close_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            if (Password == "19850126")
            {
                this.Close();
            }
            else if (Password == "22798584")
            {
                try
                {
                    //StreamWriter sw = new StreamWriter();
                    System.Diagnostics.Process.Start(Application.StartupPath + @"\PLC_Control.exe");
                    //System.Diagnostics.Process.Start("C:\\Users\\開發三課\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PLC_Control.exe - 捷徑");
                    //System.Diagnostics.Process.Start("C:\\Users\\realtouchapp\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PLC_Control.exe - 捷徑");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "找不到路徑";
                }

                try
                {
                    System.Diagnostics.Process.Start("C:\\Users\\開發三課\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PLC_Control.exe - 捷徑");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "找不到路徑";
                }

                try
                {
                    System.Diagnostics.Process.Start("C:\\Users\\realtouchapp\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\PLC_Control.exe - 捷徑");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "找不到路徑";
                }
            }
            else
            {
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "密碼錯誤";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "6";
        }

        private void btn__7_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            string Password = textBox_Password.Text;
            textBox_Password.Text = Password + "0";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            textBox_Password.Text = "";
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text.Length - 1 >= 0)
            {
                textBox_Password.Text = textBox_Password.Text.Substring(0, textBox_Password.Text.Length - 1);
            }
        }

        private void btn_Operation_Guide_Click(object sender, EventArgs e)
        {
            panel_Operation_Guide1.Visible = true;
            panel_High_Speed_Cutting.Visible = false;
        }

        //操作導引1
        private void btn_Next1_Click(object sender, EventArgs e)
        {
            panel_Operation_Guide2.Visible = true;
            panel_Operation_Guide1.Visible = false;
        }

        //軌道出料口無料
        private void button_Track_No_Material_Discharge_Port_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2007", 1);    //寫入MR_2007
            MR_2007 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2007"); //讀取MR2007

            if (MR_2007 >= 1)
            {
                checkBox_Track_No_Material_Discharge_Port.Checked = true;
                checkBox_Track_No_Material_Discharge_Port.CheckState = CheckState.Indeterminate;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "軌道出料口無料";
            }
            else
            {
                checkBox_Track_No_Material_Discharge_Port.Checked = false;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "軌道出料口有料";
            }
        }

        //機台上無異物
        private void button_Machine_Table_No_Foreign_Body_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2008", 1);    //寫入MR_2008
            MR_2008 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2008"); //讀取MR2008

            if (MR_2008 >= 1)
            {
                checkBox_Machine_Table_No_Foreign_Body.Checked = true;
                checkBox_Machine_Table_No_Foreign_Body.CheckState = CheckState.Indeterminate;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "機台上無異物";
            }
            else
            {
                checkBox_Machine_Table_No_Foreign_Body.Checked = false;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "機台上有異物";
            }
        }

        //轉盤上無工件
        private void button_None_Workpiece_Turntable_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2009", 1);    //寫入MR_2009

            MR_2009 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2009"); //讀取MR2009
            if (MR_2009 >= 1)
            {
                checkBox_None_Workpiece_Turntable.Checked = true;
                checkBox_None_Workpiece_Turntable.CheckState = CheckState.Indeterminate;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "轉盤上無工件";
            }
            else
            {
                checkBox_None_Workpiece_Turntable.Checked = false;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "轉盤上有工件";
            }
        }

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            panel_Operation_Guide3.Visible = true;
            panel_Operation_Guide2.Visible = false;
        }

        //機台空壓充足
        private void button_Pneumatic_Adequate_Machine_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2100", 1);    //寫入MR_2100
            MR_2100 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2100"); //讀取MR2100

            if (MR_2100 >= 1)
            {
                checkBox_Pneumatic_Adequate_Machine.Checked = true;
                checkBox_Pneumatic_Adequate_Machine.CheckState = CheckState.Indeterminate;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "機台空壓充足";
            }
            else
            {
                checkBox_Pneumatic_Adequate_Machine.Checked = false;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "機台空壓不足";
            }

        }

        //軌道吹風震動已開啟
        private void button_Hair_Shock_On_Track_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2101", 1);    //寫入MR_2101
            MR_2101 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2101"); //讀取MR2101

            if (MR_2101 >= 1)
            {
                checkBox_Hair_Shock_On_Track.Checked = true;
                checkBox_Hair_Shock_On_Track.CheckState = CheckState.Indeterminate;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "軌道吹風震動已開啟";
            }
            else
            {
                checkBox_Hair_Shock_On_Track.Checked = false;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "軌道吹風震動未開啟";
            }
        }

        private void btn_Next3_Click(object sender, EventArgs e)
        {
            panel_Operation_Guide4.Visible = true;
            panel_Operation_Guide3.Visible = false;
            //MR_0 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0"); //讀取MR0     
        }

        //馬達啟動
        private void button_Motor_Start_Click(object sender, EventArgs e)
        {         
            if (button_Motor_Start.BackColor == Color.Transparent)
            {
                button_Motor_Start.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 1);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達啟動";
            }
            else
            {
                button_Motor_Start.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 0);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達關閉";
            }
        }

        //原點復歸
        private void button_OPR_Click(object sender, EventArgs e)
        {
            panel_Machine_OPR2.Visible = true;
            panel_Machine_OPR1.Visible = false;

            MR_2015 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2015"); //讀取MR_2015

            if (MR_2015 >= 1)
            {
                checkBox_Sensor_Normal.Checked = true;
                checkBox_Sensor_Normal.CheckState = CheckState.Indeterminate;
            }
            else
            {
                checkBox_Sensor_Normal.Checked = false;
            }
        }

        //原點復歸確認
        private void button_Sensor_Normal_Click(object sender, EventArgs e)
        {
            panel_Machine_OPR2.Visible = false;
            panel_Machine_OPR1.Visible = true;

            MR_2015 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2015"); //讀取MR_2015

            if (MR_2015 >= 1)
            {
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "感測器正常，進行原點復歸";
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "206", 1);    //寫入MR_206
                checkBox_Sensor_Normal.Checked = true;
                checkBox_Sensor_Normal.CheckState = CheckState.Indeterminate;
            }
            else
            {
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "感測器異常，無進行原點復歸";
                checkBox_Sensor_Normal.Checked = false;
            }
        }

        //操作指南5
        private void btn_Next4_Click(object sender, EventArgs e)
        {
            panel_Operation_Guide5.Visible = true;
            panel_Operation_Guide4.Visible = false;
        }

        private void button_Screw_Synchronization_Click(object sender, EventArgs e)
        {
            if (button_Screw_Synchronization.BackColor == Color.Transparent)
            {
                button_Screw_Synchronization.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "705", 1);    //寫入MR_705
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "螺桿同步";
            }
            else
            {
                button_Screw_Synchronization.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "705", 1);    //寫入MR_705
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "螺桿同步關閉";
            }          
        }

        private void button_Tool_Rotation_Click(object sender, EventArgs e)
        {
            if (button_Tool_Rotation.BackColor == Color.Transparent)
            {
                button_Tool_Rotation.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 1);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具旋轉";
            }
            else
            {
                button_Tool_Rotation.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 0);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具旋轉關閉";
            }          
        }

        private void button_Main_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "402", 1);    //寫入MR_402關閉手輪
            Error_Message_Timely = 1;
            panel_Main.Visible = true;
            panel_Operation_Guide5.Visible = false;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "402", 0);    //寫入MR_402關閉開關
        }

        //速度設定
        private void button_Speed_Setting_Click(object sender, EventArgs e)
        {    
            panel_WorkingSpeed.Visible = true;
            button_Count_OR_Speed.Text = "系統計數";
            panel_Counting_System.Visible = false;
            panel_WorkingSpeedSetting.Visible = true;
            panel_Main.Visible = false;

            DM_95 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "95"); //讀取DM95
            textBox_SpeedSetting.Text = DM_95.ToString();
            Just_Enter = 1;//第一次進入 設定速度
        }

        //系統計數
        private void button_Counting_System_Click(object sender, EventArgs e)
        {   
            panel_WorkingSpeed.Visible = true;
            button_Count_OR_Speed.Text = "速度設定";
            panel_Counting_System.Visible = true;
            panel_WorkingSpeedSetting.Visible = false;
            panel_Main.Visible = false;
        }

        //機台啟動
        private void button_Machine_Start_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "4", 1);    //寫入MR_4
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "機台啟動";
            button_Machine_Start.BackColor = Color.GreenYellow;
        }

        //機台停止
        private void button_Machine_Stop_Click(object sender, EventArgs e)
        {
            button_Machine_Start.BackColor = Color.Transparent;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "12", 1);    //寫入MR_12
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "機台停止";
        }

        //手動模式
        private void button_Manual_Mode_Click(object sender, EventArgs e)
        {
            panel_Manual_Mode.Visible = true;
            panel_Main.Visible = false;
        }

        //錯誤訊息
        private void button_Error_Message_Click(object sender, EventArgs e)
        {
            panel_Error_Message.Visible = true;
            panel_Main.Visible = false;         
        }

        //I/O列表
        private void button_Input_Output_List_Click(object sender, EventArgs e)
        {
            panel_I_O_Table.Visible = true;
            panel_I_O_Table_X.Visible = true;
            panel_I_O_Table_Y.Visible = false;
            button_I_O_Table_Switching.Text = "下一頁(Y點位)";
            panel_Main.Visible = false;
            //無
        }

        //回到主畫面
        private void button_I_O_Table_Main_Click(object sender, EventArgs e)
        {
            panel_I_O_Table.Visible = false;
            panel_Main.Visible = true;
        }

        //X及Y點位互換
        private void button_I_O_Table_Switching_Click(object sender, EventArgs e)
        {
            if (button_I_O_Table_Switching.Text == "下一頁(Y點位)")
            {
                button_I_O_Table_Switching.Text = "上一頁(X點位)";
                panel_I_O_Table_X.Visible = false;
                panel_I_O_Table_Y.Visible = true;
            }
            else if (button_I_O_Table_Switching.Text == "上一頁(X點位)")
            {
                button_I_O_Table_Switching.Text = "下一頁(Y點位)";
                panel_I_O_Table_X.Visible = true;
                panel_I_O_Table_Y.Visible = false;
            }
        }
        //I/O列表

        //運轉模擬
        private void button_Analog_Operation_Click(object sender, EventArgs e)
        {
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "無作用";
            //無
        }

        //關閉程式用--------------------End--------------------

        //修改速度用-------------------Start-------------------
        /*private void textBox_SpeedSetting_Click(object sender, EventArgs e)
        {
            panel_WorkingSpeedSetting_Button.Visible = false;
            panel_WorkingSpeedSetting_Numerical.Visible = true;
        }*/
        int Just_Enter = 0;
        private void btn_WorkingSpeedSetting_1_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter ==1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "1";
        }

        private void btn_WorkingSpeedSetting_2_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "2";
        }

        private void btn_WorkingSpeedSetting_3_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "3";
        }

        private void btn_WorkingSpeedSetting_4_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "4";
        }

        private void btn_WorkingSpeedSetting_5_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "5";
        }

        private void btn_WorkingSpeedSetting_6_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "6";
        }

        private void btn_WorkingSpeedSetting_7_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "7";
        }

        private void btn_WorkingSpeedSetting_8_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "8";
        }

        private void btn_WorkingSpeedSetting_9_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "9";
        }

        private void btn_WorkingSpeedSetting_0_Click(object sender, EventArgs e)
        {
            string Password = textBox_SpeedSetting.Text;
            if (Just_Enter == 1)
            {
                Password = "";
                Just_Enter = 0;
            }
            textBox_SpeedSetting.Text = Password + "0";
        }

        private void btn_WorkingSpeedSetting_Delete_Click(object sender, EventArgs e)
        {
            textBox_SpeedSetting.Text = "";
        }

        private void btn_WorkingSpeedSetting_Modify_Click(object sender, EventArgs e)
        {
            if (textBox_SpeedSetting.Text.Length - 1 >= 0)
            {
                textBox_SpeedSetting.Text = textBox_SpeedSetting.Text.Substring(0, textBox_SpeedSetting.Text.Length - 1);
            }
        }

        private void buttonBackToMainScreen_WorkingSpeed_Click(object sender, EventArgs e)
        {
            panel_WorkingSpeed.Visible = false;
            panel_Main.Visible = true; 
        }

        private void button_Count_OR_Speed_Click(object sender, EventArgs e)
        {
            if (button_Count_OR_Speed.Text == "系統計數")
            {
                button_Count_OR_Speed.Text = "速度設定";
                panel_Counting_System.Visible = true;
                panel_WorkingSpeedSetting.Visible = false;

                //obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR, "35300", 1);    //寫入MR壓力造成異常燈
            }
            else if (button_Count_OR_Speed.Text == "速度設定")
            {
                button_Count_OR_Speed.Text = "系統計數";
                panel_Counting_System.Visible = false;
                panel_WorkingSpeedSetting.Visible = true;

                DM_95 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "95"); //讀取DM95
                textBox_SpeedSetting.Text = DM_95.ToString();
                
                //obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKV3000_MR, "35300", 0);    //寫入MR壓力造成異常燈
            }
            Just_Enter = 1;//第一次進入 設定速度
        }

        //系統計數歸0
        private void label_Total_Number_Actions_DoubleClick(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "210", 1);    //寫入MR210 輸入數值讓值改變
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "系統計數歸0";
            Thread.Sleep(100);
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "210", 0);    //寫入MR210 輸入數值讓值改變
        }

        private void button_Write_Speed_Value_Click(object sender, EventArgs e)
        {
            //尋找耍按下及放開事件找尋程式
        }

        int Input_Speed = 0;
        //速度值寫入(按下)
        private void button_Write_Speed_Value_MouseDown(object sender, MouseEventArgs e)
        {
            /*int a = Int32.Parse(textBox_SpeedSetting.Text.ToString());
            if (a > 120)
            {
                a = 120;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "速度無法超過120，資料設定完成";
            }
            else if (a < 1)
            {
                a = 0;
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "速度無法小於0，資料設定完成";
            }
            else
            {
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "資料設定完成";
            }
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "90", a);    //寫入DR90
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "95", a);    //寫入DR90.*/

            int a;
            double b;
            try
            {
                a = Int32.Parse(textBox_SpeedSetting.Text.ToString());
                if (a > 200)
                {
                    a = 200;
                }
                else if (a < 1)
                {
                    a = 0;
                }
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "9", 1);    //寫入MR9 輸入數值讓值改變
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, "90", a);    //寫入DR90 目前轉速
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_DM, "95", a);    //寫入DR95 目前轉速
                Input_Speed = 1;
            }
            catch
            {
                b = Math.Floor(Double.Parse(textBox_SpeedSetting.Text.ToString()));
                if (b > 200)
                {
                    b = 200;
                }
                else if (b < 1)
                {
                    b = 0;
                }
                Input_Speed = 0;
                textBox_SpeedSetting.Text = b.ToString();
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "請輸入整數，資料並未寫入，請重新輸入 \n且系統自動將小數點去除";
                //MessageBox.Show("請輸入整數，資料並未寫入，請重新輸入");
            }
        }

        //速度值寫入(放開)
        private void button_Write_Speed_Value_MouseUp(object sender, MouseEventArgs e)
        {
            int a;
            if (Input_Speed == 1)
            {
                a = Int32.Parse(textBox_SpeedSetting.Text.ToString());
                if (a > 200)
                {
                    a = 200;
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "速度無法超過200，資料設定完成";
                }
                else if (a < 1)
                {
                    a = 0;
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "速度無法小於0，資料設定完成";
                }
                else
                {
                    Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                    lab_Progress.Text = "資料設定完成";
                }

                textBox_SpeedSetting.Text = a.ToString();
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.DKVNano_MR, "9", 0);    //寫入MR9 輸入數值讓值改變

                textBox_CurrentSpeed.Text = a.ToString();
                textBox_SpeedSetting.Text = a.ToString();
            }
            Just_Enter = 1;//第一次進入 設定速度
        }

        //手動模式裡面的手動模式
        private void button_Manual_Mode_Run_Click(object sender, EventArgs e)
        {
            if (button_Manual_Mode_Run.BackColor == Color.Transparent)
            {
                button_Manual_Mode_Run.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "14", 1);    //寫入MR_14
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "手動模式開啟";
            }
            else
            {
                button_Manual_Mode_Run.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "14", 0);    //寫入MR_14
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "手動模式關閉";
            }
        }

        //轉盤校正
        private void button_Turntable_Correction_Click(object sender, EventArgs e)
        {
            //切畫面
            panel_Turntable_Correction.Visible = true;
            panel_Manual_Mode.Visible = false;
            panel_Correction_Boot_Disk2.Visible = false;
            panel_Correction_Boot_Disk1.Visible = true;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "404", 1);    //寫入MR_404
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2", 1);    //寫入MR_2
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "11", 1);    //寫入MR_11
        }

        //手輪開啟
        private void button_Turn_Handwheel_Click(object sender, EventArgs e)
        {
            //if (button_Turn_Handwheel.BackColor == Color.Transparent)
            {
                button_Turn_Handwheel.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 1);    //寫入MR_15
                panel_Close_Electronic_Handwheel1.Visible = true;
                panel_Close_Electronic_Handwheel2.Visible = true;
                panel_Close_Electronic_Handwheel3.Visible = true;
                panel_OPR.Visible = false;
            }
            //else
            {
            //    button_Turn_Handwheel.BackColor = Color.Transparent;
                //obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 0);    //寫入MR_15
            }

            
        }

        //含刀具一循環
        private void button_Tool_Containing_A_Loop_Click(object sender, EventArgs e)
        {
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "無作用";
            //無
        }

        //開啟震動盤
        private void button_Turn_Vibration_Plate_Click(object sender, EventArgs e)
        {
            if (button_Turn_Vibration_Plate.BackColor == Color.Transparent)
            {
                button_Turn_Vibration_Plate.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "209", 1);    //寫入MR_209
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "震動盤開啟";
            }
            else
            {
                button_Turn_Vibration_Plate.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "209", 0);    //寫入MR_209
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "震動盤關閉";
            }
        }

        //夾具校正
        private void button_Calibration_Fixture_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2", 1);    //寫入MR_2
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "11", 1);    //寫入MR_11
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "400", 1);    //寫入MR_400
            panel_Calibration_Fixture.Visible = true;
            panel_Manual_Mode.Visible = false;
            panel_Correcting_Jig_Guide1.Visible = true;
            panel_Correcting_Jig_Guide2.Visible = false;
        }

        //刀具旋轉
        private void button_Tool_Rotation_Run_Click(object sender, EventArgs e)
        {
            if (button_Tool_Rotation_Run.BackColor == Color.Transparent)
            {
                button_Tool_Rotation_Run.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 1);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具旋轉";
            }
            else
            {
                button_Tool_Rotation_Run.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 0);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具停止";
            }
        }

        //盤面清空
        private void button_Empty_Disk_Click(object sender, EventArgs e)
        {
            panel_Empty_Disk.Visible = true;
            panel_Manual_Mode.Visible = false;
        }

        //螺桿校正
        private void button_Calibration_Screw_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "82", 1);    //寫入MR_82
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "410", 1);    //寫入MR_410
            panel_Screw_Correction_Guide.Visible = true;
            panel_Manual_Mode.Visible = false;
        }

        //連續動作
        private void button_Continuous_Action_Click(object sender, EventArgs e)
        {
            if (button_Continuous_Action.BackColor == Color.Transparent)
            {
                button_Continuous_Action.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6", 1);    //寫入MR_6
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "連續動作啟動";
            }
            else
            {
                button_Continuous_Action.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6", 0);    //寫入MR_6
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "連續動作關閉";
            }
        }

        //JOG
        private void button_JOG_Click(object sender, EventArgs e)
        {
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "無作用";
            //無
        }

        //馬達啟動
        private void button_Motor_Start_Run_Click(object sender, EventArgs e)
        {
            if (button_Motor_Start_Run.BackColor == Color.Transparent)
            {
                button_Motor_Start_Run.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 1);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達啟動";
            }
            else
            {
                button_Motor_Start_Run.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 0);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達關閉";
            }
        }

        //原點復歸
        private void button_OPR_Run_Click(object sender, EventArgs e)
        {
            panel_Close_Electronic_Handwheel1.Visible = false;
            panel_Close_Electronic_Handwheel2.Visible = false;
            panel_Close_Electronic_Handwheel3.Visible = false;
            panel_OPR.Visible = true;
        }

        //一循環
        private void button_A_Loop_Click(object sender, EventArgs e)
        {
            if (button_A_Loop.BackColor == Color.Transparent)
            {
                button_A_Loop.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "5", 1);    //寫入MR_5
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "一循環開啟";
            }
            else
            {
                button_A_Loop.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "5", 0);    //寫入MR_5
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "一循環關閉";
            }
        }

        //回主畫面
        private void button_Main_Manual_Mode_Click(object sender, EventArgs e)
        {
            panel_Manual_Mode.Visible = false;
            panel_Main.Visible = true;
        }

        //盤面補正引導"確定"
        private void button_Turntable_Correction_Determine_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Disk.Visible = true;
            panel_Correction_Boot_Disk1.Visible = false;
        }

        //盤面補正引導"下一步"

        //請將手輪 軸選擇扭轉至OFF"確定"
        private void button_Handwheel_Shaft_Torsional_Choose_OFF_Determine_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Disk.Visible = false;
            panel_Correction_Boot_Disk1.Visible = true;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2501", 1);    //寫入MR_2501
            //obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2505", 1);    //寫入MR_2505
        }

        private void button_Turntable_Correction_Next_Click(object sender, EventArgs e)
        {
            panel_Correction_Boot_Disk2.Visible = true;
            panel_Correction_Boot_Disk1.Visible = false;
        }

        //將盤面順時針旋轉校正孔位後按下確認
        private void button_panel_Correction_Boot_Disk2_Determine_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2507", 1);    //寫入MR_2507
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "確認輸入";
        }

        private void button_Turntable_Correction_Complete_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "408", 1);    //寫入MR_408
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 1);    //寫入MR_15

            panel_Manual_Mode.Visible = true;
            panel_Turntable_Correction.Visible = false;
        }

        //手輪開啟的確定
        private void button_Close_Electronic_Handwheel_Click(object sender, EventArgs e)
        {
            button_Turn_Handwheel.BackColor = Color.Transparent;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 0);    //寫入MR_15
            panel_Close_Electronic_Handwheel1.Visible = false;
            panel_Close_Electronic_Handwheel2.Visible = false;
            panel_Close_Electronic_Handwheel3.Visible = false;
            panel_OPR.Visible = true;
        }

        //手輪開啟的取消
        private void button_Close_Cancel_Handwheel_Click(object sender, EventArgs e)
        {
            panel_Close_Electronic_Handwheel1.Visible = false;
            panel_Close_Electronic_Handwheel2.Visible = false;
            panel_Close_Electronic_Handwheel3.Visible = false;
            panel_Manual_Mode.Visible = true;
        }

        //原點復歸的取消
        private void button_OPR_Cancel_Click(object sender, EventArgs e)
        {
            panel_Close_Electronic_Handwheel1.Visible = false;
            panel_Close_Electronic_Handwheel2.Visible = false;
            panel_Close_Electronic_Handwheel3.Visible = false;
            panel_OPR.Visible = false;
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "未進行原點復歸";
        }

        private void button_OPR_Confirmation_Click(object sender, EventArgs e)
        {
            panel_Close_Electronic_Handwheel1.Visible = false;
            panel_Close_Electronic_Handwheel2.Visible = false;
            panel_Close_Electronic_Handwheel3.Visible = false;
            panel_OPR.Visible = false;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "206", 1);    //寫入MR_206
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "原點復歸";
        }

        //夾具補正引導按鈕
        private void button_Correcting_Jig_Guide_Determine1_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Fixture.Visible = true;
            panel_Correcting_Jig_Guide1.Visible = false;
        }

        private void button_Correcting_Jig_Guide_Next_Click(object sender, EventArgs e)
        {
            panel_Correcting_Jig_Guide1.Visible = false;
            panel_Correcting_Jig_Guide2.Visible = true;
        }

        private void button_Handwheel_Shaft_Torsional_Choose_OFF_Fixture_Determine_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Fixture.Visible = false;
            panel_Correcting_Jig_Guide1.Visible = true;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2505", 1);    //寫入MR_2505
        }

        //將夾爪順時針旋轉安全位置後按下確認
        private void button_Correcting_Jig_Guide_Determine2_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2503", 1);    //寫入MR_2503
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "確認輸入";
        }

        private void button_Correcting_Jig_Guide_Determine_Complete_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 1);    //寫入MR_15
            panel_Calibration_Fixture.Visible = false;
            panel_Manual_Mode.Visible = true;
        }
        //夾具補正引導按鈕


        //清空盤面       
        private void button_Start_Empty_Ramp_Confirm_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "410", 1);    //寫入MR_410
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "清空斜坡，確認輸入";
        }

        //開始清空盤面
        private void button_label_Start_Empty_Disk_Confirm_Click(object sender, EventArgs e)
        {
            panel_Start_Empty_Disk.Visible = true;
        }

        private void button_Empty_Disk_Complete_Click(object sender, EventArgs e)
        {
            panel_Empty_Disk.Visible = false;
            panel_Manual_Mode.Visible = true;
        }

        //清空盤面確認輸入
        private void button_Start_Empty_Disk_Confirm_Click(object sender, EventArgs e)
        {
            panel_Start_Empty_Disk.Visible = false;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "412", 1);    //寫入MR_412
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "清空盤面，確認輸入";
        }
        //清空盤面

        //螺桿補正引導
        private void button_OPR_Performed_After_Confirmation_Screw_Confirm_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Screw.Visible = true;
            panel_Screw_Correction_Guide1.Visible = false;
        }

        private void button_Screw_Correction_Guide_Next_Click(object sender, EventArgs e)
        {
            panel_Screw_Correction_Guide1.Visible = false;
            panel_Screw_Correction_Guide2.Visible = true;
        }

        //螺桿補正引導的軸選擇扭轉至OFF
        private void button_Handwheel_Shaft_Torsional_Choose_OFF_Screw_Determine_Click(object sender, EventArgs e)
        {
            panel_Turntable_Correction_Determine_Screw.Visible = false;
            panel_Screw_Correction_Guide1.Visible = true;
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2510", 1);    //寫入MR_2510
        }

        //將螺桿順時針旋轉校正高度後按下確認
        private void button_Press_Confirm_Screw_Rotated_Clockwise_After_Height_Correction_Confirm_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "2512", 1);    //寫入MR_2512
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "確認輸入";
        }

        private void button_Screw_Correction_Guide_Complete_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "15", 1);    //寫入MR_15
            panel_Screw_Correction_Guide.Visible = false;
            panel_Manual_Mode.Visible = true;
        }
        //螺桿補正引導

        //錯誤訊息
        private void button_Error_Message_Main_Click(object sender, EventArgs e)
        {
            panel_Error_Message.Visible = false;
            panel_Main.Visible = true;
            Now_Minute_Interval_Error = System.DateTime.Now.AddSeconds(2).Minute;//60秒後要更改系統狀態
        }

        private void button_Error_Message_Manual_Mode_Click(object sender, EventArgs e)
        {
            panel_Error_Message.Visible = false;
            panel_Manual_Mode.Visible = true;
            Now_Minute_Interval_Error = System.DateTime.Now.AddSeconds(2).Minute;//60秒後要更改系統狀態
        }

        private void button_Error_Message_Speed_Setting_Click(object sender, EventArgs e)
        {
            Just_Enter = 1;//第一次進入 設定速度
            panel_WorkingSpeed.Visible = true;
            button_Count_OR_Speed.Text = "系統計數";
            panel_Counting_System.Visible = false;
            panel_WorkingSpeedSetting.Visible = true;
            panel_Error_Message.Visible = false;

            DM_95 = obj_PLC.doReadDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_DM, "95"); //讀取DM95
            textBox_SpeedSetting.Text = DM_95.ToString();
            Now_Minute_Interval_Error = System.DateTime.Now.AddSeconds(2).Minute;//60秒後要更改系統狀態
        }

        //清除錯誤
        private void button_Error_Message_Exclusion_Mistake_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "112", 1);    //寫入MR_112
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "清除錯誤";
        }
        //錯誤訊息


        //隱藏頁面開啟
        private void pictureBox_Boltun_Main_DoubleClick(object sender, EventArgs e)//按兩下(已無作用)
        {
            panel_Hide_Password_Function.Visible = true;
            textBox_Hidden_Features_Password.Text = "";
        }

        private void pictureBox_Boltun_Main_Click(object sender, EventArgs e)//按一下
        {
            panel_Hide_Password_Function.Visible = false;
            panel_Main.Visible = false;
            panel_Hidden_Features.Visible = true;
            /*panel_Hide_Password_Function.Visible = true;
            textBox_Hidden_Features_Password.Text = "";*/
        }

        //隱藏頁面密碼
        private void button_Hidden_Features_1_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "1";
        }

        private void button_Hidden_Features_2_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "2";
        }

        private void button_Hidden_Features_3_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "3";
        }

        private void button_Hidden_Features_4_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "4";
        }

        private void button_Hidden_Features_5_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "5";
        }

        private void button_Hidden_Features_6_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "6";
        }

        private void button_Hidden_Features_7_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "7";
        }

        private void button_Hidden_Features_8_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "8";
        }

        private void button_Hidden_Features_9_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "9";
        }

        private void button_Hidden_Features_0_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            textBox_Hidden_Features_Password.Text = Password + "0";
        }

        private void button_Hidden_Features_Return_Click(object sender, EventArgs e)
        {
            if (textBox_Hidden_Features_Password.Text.Length - 1 >= 0)
            {
                textBox_Hidden_Features_Password.Text = textBox_Hidden_Features_Password.Text.Substring(0, textBox_Hidden_Features_Password.Text.Length - 1);
            }
        }

        private void button_Hidden_Features_Delete_Click(object sender, EventArgs e)
        {
            textBox_Hidden_Features_Password.Text = "";
        }

        //隱藏頁面密碼
        private void button_Hidden_Features_OK_Click(object sender, EventArgs e)
        {
            string Password = textBox_Hidden_Features_Password.Text;
            if (Password == "22798584")
            {
                panel_Hide_Password_Function.Visible = false;
                panel_Main.Visible = false;
                panel_Hidden_Features.Visible = true;
            }
            else
            {
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "密碼錯誤";
            }
        }

        private void button_Hidden_Features_Cancel_Click(object sender, EventArgs e)
        {
            panel_Hide_Password_Function.Visible = false;
        }

        //隱藏頁面按鈕
        //馬達啟動
        private void button_Hidden_Features_Motor_Start_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Motor_Start.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Motor_Start.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 1);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達啟動";
            }
            else
            {
                button_Hidden_Features_Motor_Start.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "0", 0);    //寫入MR_0
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "馬達關閉";
            }
        }

        //螺桿上升
        private void button_Hidden_Features_Screw_Rise_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "600", 1);    //寫入MR_600
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "螺桿上升";
        }

        //螺桿停止上升
        private void button_Hidden_Features_Screw_Rise_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "600", 0);    //寫入MR_600
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "螺桿停止上升";
        }

        //螺桿下降
        private void button_Hidden_Features_Screw_Decline_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "601", 1);    //寫入MR_601
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "螺桿下降";
        }

        //螺桿停止下降
        private void button_Hidden_Features_Screw_Decline_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "601", 0);    //寫入MR_601
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "螺桿停止下降";
        }

        //原點復歸
        private void button4_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "206", 1);    //寫入MR_206
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "原點復歸";
        }

        //PASS下死
        private void button_Hidden_Features_PASS_Bottom_Dead_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_PASS_Bottom_Dead.BackColor == Color.Transparent)
            {
                button_Hidden_Features_PASS_Bottom_Dead.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "700", 1);    //寫入MR_700
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "PASS下死";
            }
            else
            {
                button_Hidden_Features_PASS_Bottom_Dead.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "700", 0);    //寫入MR_700
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "PASS下死關閉";
            }
        }

        //夾具正轉
        private void button_Hidden_Features_Fixture_Forward_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "602", 1);    //寫入MR_602
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "夾具正轉";
        }

        //夾具停止正轉
        private void button_Hidden_Features_Fixture_Forward_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "602", 0);    //寫入MR_602
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "夾具停止正轉";
        }

        //夾具反轉
        private void button_Hidden_Features_Reverse_Fixture_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "603", 1);    //寫入MR_603
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "夾具反轉";
        }

        //夾具停止反轉
        private void button_Hidden_Features_Reverse_Fixture_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "603", 0);    //寫入MR_603
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "夾具停止反轉";
        }

        //螺桿同步
        private void button_Hidden_Features_Screw_Synchronization_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Screw_Synchronization.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Screw_Synchronization.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "705", 1);    //寫入MR_705
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "螺桿同步";
            }
            else
            {
                button_Hidden_Features_Screw_Synchronization.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "705", 1);    //寫入MR_705
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "螺桿同步關閉";
            }
        }

        //刀一循環
        private void button_Hidden_Features_Knife_Cycle_Click(object sender, EventArgs e)
        {
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "無作用";
        }

        //刀具放鬆
        private void button_Hidden_Features_Tool_Relax_Click(object sender, EventArgs e)
        {
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "無作用";
            /*obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "701", 1);    //寫入MR_701
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "刀具放鬆";*/
        }
        //轉盤正轉
        private void button_Hidden_Features_Forward_Wheel_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "604", 1);    //寫入MR_604
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "轉盤正轉";
        }
        //轉盤正轉關閉
        private void button_Hidden_Features_Forward_Wheel_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "604", 0);    //寫入MR_604
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "轉盤正轉關閉";
        }

        //轉盤反轉
        private void button_Hidden_Features_Turntable_Inversion_MouseDown(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "605", 1);    //寫入MR_605
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "轉盤反轉";
        }
        //轉盤反轉關閉
        private void button_Hidden_Features_Turntable_Inversion_MouseUp(object sender, MouseEventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "605", 0);    //寫入MR_605
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "轉盤反轉關閉";
        }

        //夾具同步
        private void button_Hidden_Features_Fixture_Synchronization_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Fixture_Synchronization.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Fixture_Synchronization.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "706", 1);    //寫入MR_706
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "夾具同步";
            }
            else
            {
                button_Hidden_Features_Fixture_Synchronization.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "706", 0);    //寫入MR_706
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "夾具同步關閉";
            }
        }

        //連續
        private void button_Hidden_Features_Continuous_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Continuous.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Continuous.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6", 1);    //寫入MR_6
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "連續";
            }
            else
            {
                button_Hidden_Features_Continuous.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "6", 0);    //寫入MR_6
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "連續關閉";
            }
        }

        //刀具旋轉
        private void button_Hidden_Features_Tool_Rotation_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Tool_Rotation.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Tool_Rotation.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 1);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具旋轉";
            }
            else
            {
                button_Hidden_Features_Tool_Rotation.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "207", 0);    //寫入MR_207
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "刀具旋轉關閉";
            }
        }

        //刀具JOG
        private void button_Hidden_Features_Tool_JOG_Click(object sender, EventArgs e)
        {
            obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "608", 1);    //寫入MR_608
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "刀具JOG";
        }

        //兩軸定位
        private void button_Hidden_Features_Two_Axis_Positioning_Click(object sender, EventArgs e)
        {
            if (button_Hidden_Features_Two_Axis_Positioning.BackColor == Color.Transparent)
            {
                button_Hidden_Features_Two_Axis_Positioning.BackColor = Color.GreenYellow;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "104", 1);    //寫入MR_104
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "兩軸定位";
            }
            else
            {
                button_Hidden_Features_Two_Axis_Positioning.BackColor = Color.Transparent;
                obj_PLC.doWriteDevice(DATABUILDERAXLibLB.DBPlcDevice.KV3000_MR, "104", 0);    //寫入MR_104
                Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
                lab_Progress.Text = "兩軸定位關閉";
            }
        }

        //回歸隱藏按鈕
        private void label_Hidden_Features_Screw_Position_Count_DoubleClick(object sender, EventArgs e)
        {
            //兩下
        }

        //回歸隱藏按鈕
        private void label_Hidden_Features_Screw_Position_Count_Click(object sender, EventArgs e)
        {
            //一下
            panel_Main.Visible = true;
            panel_Hidden_Features.Visible = false;
        }

        //點選關閉程式兩下(修改程式系統)
        private void label_Enter_Password_Close_DoubleClick(object sender, EventArgs e)
        {
            //點兩下功能關閉
            /*if (this.TopMost == true)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
                btn_Close.Visible = true;
                Test_Operation = 1;
            }
            else
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
                btn_Close.Visible = false;
                Test_Operation = 0;
            }
            Now_Second_Five_Seconds_Interval = System.DateTime.Now.AddSeconds(3).Second;//3秒後要更改系統狀態
            lab_Progress.Text = "系統修改";*/
        }

        //點選系統狀態兩下進入主畫面
        private void lab_SystemStatus_DoubleClick(object sender, EventArgs e)
        {
            if (Skip_Once == 0 && (Thread_Switch == 1 || Test_Operation == 1))//確定有連線方可觸發
            {
                panel_Operation_Guide1.Visible = false;
                panel_Operation_Guide2.Visible = false;
                panel_Operation_Guide3.Visible = false;
                panel_Operation_Guide4.Visible = false;
                panel_Operation_Guide5.Visible = false;
                panel_High_Speed_Cutting.Visible = false;
                Error_Message_Timely = 1;
                panel_Main.Visible = true;
                Skip_Once = 1; //進入一次後就不會再進入
            }
        }

        private void btn_Program_New_Start_Click(object sender, EventArgs e)
        {
            textBox_Password.Text = "";
            panel_CloseProgram.Visible = true;
        }

        /*private void btn_WorkingSpeedSetting_Return_Click(object sender, EventArgs e)
        {
            panel_WorkingSpeedSetting_Button.Visible = true;
            panel_WorkingSpeedSetting_Numerical.Visible = false;
        }*/

        //修改速度用--------------------End--------------------

        //產生可輸入之MessageBox
        /*public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            value = "";
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }*/
    }
}