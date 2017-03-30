namespace UAVXGUI
{
    partial class FormMain
    {
       
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
               components.Dispose();
            }
            base.Dispose(disposing);
        }
         * */

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RollAngle = new System.Windows.Forms.TextBox();
            this.PitchAngle = new System.Windows.Forms.TextBox();
            this.BatteryVolts = new System.Windows.Forms.TextBox();
            this.BatteryCurrent = new System.Windows.Forms.TextBox();
            this.RCGlitches = new System.Windows.Forms.TextBox();
            this.DesiredThrottle = new System.Windows.Forms.TextBox();
            this.DesiredRoll = new System.Windows.Forms.TextBox();
            this.DesiredPitch = new System.Windows.Forms.TextBox();
            this.DesiredYaw = new System.Windows.Forms.TextBox();
            this.YawGyro = new System.Windows.Forms.TextBox();
            this.PitchRate = new System.Windows.Forms.TextBox();
            this.RollRate = new System.Windows.Forms.TextBox();
            this.LRAcc = new System.Windows.Forms.TextBox();
            this.YawAngleError = new System.Windows.Forms.TextBox();
            this.DUAcc = new System.Windows.Forms.TextBox();
            this.FBAcc = new System.Windows.Forms.TextBox();
            this.VoltsLabel = new System.Windows.Forms.Label();
            this.LRAccLabel = new System.Windows.Forms.Label();
            this.FBAccLabel = new System.Windows.Forms.Label();
            this.DUAccLabel = new System.Windows.Forms.Label();
            this.DesiredYawLabel = new System.Windows.Forms.Label();
            this.DesiredPitchLabel = new System.Windows.Forms.Label();
            this.DesiredRollLabel = new System.Windows.Forms.Label();
            this.DesiredThrottleLabel = new System.Windows.Forms.Label();
            this.RCGlitchesLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.GPShAcc = new System.Windows.Forms.TextBox();
            this.RangefinderAltitude = new System.Windows.Forms.TextBox();
            this.BaroAltitude = new System.Windows.Forms.TextBox();
            this.GPSFix = new System.Windows.Forms.TextBox();
            this.ROC = new System.Windows.Forms.TextBox();
            this.GPSNoOfSats = new System.Windows.Forms.TextBox();
            this.FailState = new System.Windows.Forms.TextBox();
            this.GPSAltitude = new System.Windows.Forms.TextBox();
            this.ROCLabel = new System.Windows.Forms.Label();
            this.hAccLabel = new System.Windows.Forms.Label();
            this.RangefinderAltLabel = new System.Windows.Forms.Label();
            this.GPSFixLabel = new System.Windows.Forms.Label();
            this.GPSNoOfSatsLabel = new System.Windows.Forms.Label();
            this.FailStateLabel = new System.Windows.Forms.Label();
            this.GPSAltLabel = new System.Windows.Forms.Label();
            this.BaroAltitudeLabel = new System.Windows.Forms.Label();
            this.YawGyroLabel = new System.Windows.Forms.Label();
            this.PitchRateLabel = new System.Windows.Forms.Label();
            this.RollRateLabel = new System.Windows.Forms.Label();
            this.RxTypeErr = new System.Windows.Forms.TextBox();
            this.RxCSumErr = new System.Windows.Forms.TextBox();
            this.RxLenErr = new System.Windows.Forms.TextBox();
            this.RxTypeLabel = new System.Windows.Forms.Label();
            this.RxCSumLabel = new System.Windows.Forms.Label();
            this.RxLenLabel = new System.Windows.Forms.Label();
            this.FlightState = new System.Windows.Forms.TextBox();
            this.GyroGroupBox = new System.Windows.Forms.GroupBox();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.AttitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.AccConfidenceLabel = new System.Windows.Forms.Label();
            this.YawLabel = new System.Windows.Forms.Label();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.AccConfidence = new System.Windows.Forms.TextBox();
            this.RollLabel = new System.Windows.Forms.Label();
            this.AccelerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnvGroupBox = new System.Windows.Forms.GroupBox();
            this.SensorTemp = new System.Windows.Forms.TextBox();
            this.SensorTempLabel = new System.Windows.Forms.Label();
            this.BatteryGroupBox = new System.Windows.Forms.GroupBox();
            this.BatteryCharge = new System.Windows.Forms.TextBox();
            this.BatteryChargeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AltHoldBox = new System.Windows.Forms.TextBox();
            this.TurnToPOIBox = new System.Windows.Forms.TextBox();
            this.UseRTHAutoDescendBox = new System.Windows.Forms.TextBox();
            this.BaroAltValidBox = new System.Windows.Forms.TextBox();
            this.RangefinderAltValidBox = new System.Windows.Forms.TextBox();
            this.GPSValidBox = new System.Windows.Forms.TextBox();
            this.NavValidBox = new System.Windows.Forms.TextBox();
            this.SticksFrozenBox = new System.Windows.Forms.TextBox();
            this.LowBatteryBox = new System.Windows.Forms.TextBox();
            this.ThrottleMovingBox = new System.Windows.Forms.TextBox();
            this.HoldingAltBox = new System.Windows.Forms.TextBox();
            this.AttitudeHoldBox = new System.Windows.Forms.TextBox();
            this.NearLevelBox = new System.Windows.Forms.TextBox();
            this.BypassBox = new System.Windows.Forms.TextBox();
            this.NavigateBox = new System.Windows.Forms.TextBox();
            this.RateControlBox = new System.Windows.Forms.TextBox();
            this.UsingRangefinderBox = new System.Windows.Forms.TextBox();
            this.CloseProximityBox = new System.Windows.Forms.TextBox();
            this.ProximityBox = new System.Windows.Forms.TextBox();
            this.IMUFailBox = new System.Windows.Forms.TextBox();
            this.MagFailBox = new System.Windows.Forms.TextBox();
            this.MagLockedBox = new System.Windows.Forms.TextBox();
            this.BaroFailBox = new System.Windows.Forms.TextBox();
            this.GPSFailBox = new System.Windows.Forms.TextBox();
            this.LostModelBox = new System.Windows.Forms.TextBox();
            this.UsingUplinkFlagBox = new System.Windows.Forms.TextBox();
            this.FrSkyBox = new System.Windows.Forms.GroupBox();
            this.FrSkyErrLabel = new System.Windows.Forms.Label();
            this.RxFrSkyErr = new System.Windows.Forms.TextBox();
            this.FrSkyCheckBox = new System.Windows.Forms.CheckBox();
            this.FrSkyLQLabel = new System.Windows.Forms.Label();
            this.FrSkyA2Label = new System.Windows.Forms.Label();
            this.FrSkyALabel = new System.Windows.Forms.Label();
            this.FrSkyLQ = new System.Windows.Forms.TextBox();
            this.FrSkyA2 = new System.Windows.Forms.TextBox();
            this.FrSkyA1 = new System.Windows.Forms.TextBox();
            this.FlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.GPSStatBox = new System.Windows.Forms.GroupBox();
            this.AltitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BaroPressure = new System.Windows.Forms.TextBox();
            this.BaroTemperature = new System.Windows.Forms.TextBox();
            this.WayHeadingLabel = new System.Windows.Forms.Label();
            this.GPSLongitudeLabel = new System.Windows.Forms.Label();
            this.GPSLatitudeLabel = new System.Windows.Forms.Label();
            this.NavStateLabel = new System.Windows.Forms.Label();
            this.GPSVelLabel = new System.Windows.Forms.Label();
            this.CurrWPLabel = new System.Windows.Forms.Label();
            this.GPSLatitude = new System.Windows.Forms.TextBox();
            this.GPSLongitude = new System.Windows.Forms.TextBox();
            this.NavState = new System.Windows.Forms.TextBox();
            this.CurrWP = new System.Windows.Forms.TextBox();
            this.WayHeading = new System.Windows.Forms.TextBox();
            this.WPAltitude = new System.Windows.Forms.Label();
            this.GPSVel = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.AltitudeError = new System.Windows.Forms.TextBox();
            this.Heading = new System.Windows.Forms.TextBox();
            this.WPDistanceLabel = new System.Windows.Forms.Label();
            this.DistanceToDesired = new System.Windows.Forms.TextBox();
            this.NavGroupBox = new System.Windows.Forms.GroupBox();
            this.CrossTrackErrorLabel = new System.Windows.Forms.Label();
            this.CrossTrackError = new System.Windows.Forms.TextBox();
            this.GPSHeadingLabel = new System.Windows.Forms.Label();
            this.GPSHeading = new System.Windows.Forms.TextBox();
            this.NavStateTimeoutLabel = new System.Windows.Forms.Label();
            this.NavStateTimeout = new System.Windows.Forms.TextBox();
            this.CurrentAltitude = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AltitudeSource = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.GroupBox();
            this.WhereDistance = new System.Windows.Forms.TextBox();
            this.WhereBearing = new System.Windows.Forms.TextBox();
            this.WhereBearingLabel = new System.Windows.Forms.Label();
            this.WhereDistanceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BattFFLabel = new System.Windows.Forms.Label();
            this.BattFFComp = new System.Windows.Forms.TextBox();
            this.CruiseThrottleLabel = new System.Windows.Forms.Label();
            this.CruiseThrottle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AltComp = new System.Windows.Forms.TextBox();
            this.TiltFFComp = new System.Windows.Forms.TextBox();
            this.TiltFFCompLabel = new System.Windows.Forms.Label();
            this.AltCompLabel = new System.Windows.Forms.Label();
            this.EmulationTextBox = new System.Windows.Forms.TextBox();
            this.BaroStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxTempS = new System.Windows.Forms.Label();
            this.TempSLabel = new System.Windows.Forms.Label();
            this.MinTempS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaroMaxROCS = new System.Windows.Forms.Label();
            this.RelBaroAltitudeLabel = new System.Windows.Forms.Label();
            this.BaroRelAltitudeS = new System.Windows.Forms.Label();
            this.BaroMinROCS = new System.Windows.Forms.Label();
            this.GPSStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GPSMaxhAccS = new System.Windows.Forms.Label();
            this.GPSMinhAccS = new System.Windows.Forms.Label();
            this.GPSAltitudeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GPSMaxVelS = new System.Windows.Forms.Label();
            this.GPSAltitudeS = new System.Windows.Forms.Label();
            this.SatsLabel = new System.Windows.Forms.Label();
            this.GPSMinSatS = new System.Windows.Forms.Label();
            this.GPSMaxSatS = new System.Windows.Forms.Label();
            this.ErrorStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.ErrNoS = new System.Windows.Forms.Label();
            this.ErrNoSLabel = new System.Windows.Forms.Label();
            this.RawCheckBox = new System.Windows.Forms.CheckBox();
            this.BadS = new System.Windows.Forms.Label();
            this.BadSLabel = new System.Windows.Forms.Label();
            this.FailsafeSLabel = new System.Windows.Forms.Label();
            this.GyroSLabel = new System.Windows.Forms.Label();
            this.RCFailSafeS = new System.Windows.Forms.Label();
            this.I2CESCFailS = new System.Windows.Forms.Label();
            this.GPSInvalidSLabel = new System.Windows.Forms.Label();
            this.GPSFailS = new System.Windows.Forms.Label();
            this.ESCSLabel = new System.Windows.Forms.Label();
            this.GyroFailS = new System.Windows.Forms.Label();
            this.AccFailLabel = new System.Windows.Forms.Label();
            this.AccFailS = new System.Windows.Forms.Label();
            this.I2CSIOFailLabel = new System.Windows.Forms.Label();
            this.CompassFailLabel = new System.Windows.Forms.Label();
            this.I2CSIOFailS = new System.Windows.Forms.Label();
            this.CompassFailS = new System.Windows.Forms.Label();
            this.BaroFailLabel = new System.Windows.Forms.Label();
            this.BaroFailS = new System.Windows.Forms.Label();
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.COMSelectComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.COMBaudRateComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.ReplayProgressBar = new System.Windows.Forms.ProgressBar();
            this.Airframe = new System.Windows.Forms.TextBox();
            this.ReplayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NavCompBox = new System.Windows.Forms.GroupBox();
            this.NavSensitivity = new System.Windows.Forms.TextBox();
            this.NavSensitivityLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NavYCorr = new System.Windows.Forms.TextBox();
            this.NavRCorr = new System.Windows.Forms.TextBox();
            this.NavPCorr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SpeechGroupBox = new System.Windows.Forms.GroupBox();
            this.SpeakVarioCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakIntervalLabel = new System.Windows.Forms.Label();
            this.SpeakIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeechEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakNavCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakAltitudeCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakWhereCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeakVoltsCheckBox = new System.Windows.Forms.CheckBox();
            this.timer_announce = new System.Windows.Forms.Timer(this.components);
            this.timer_telemetry = new System.Windows.Forms.Timer(this.components);
            this.StartNavigationButton = new System.Windows.Forms.Button();
            this.StartParametersButton = new System.Windows.Forms.Button();
            this.CalibrateIMUButton = new System.Windows.Forms.Button();
            this.CalibrateMagButton = new System.Windows.Forms.Button();
            this.DrivesGroupBox = new System.Windows.Forms.GroupBox();
            this.PWMT9 = new System.Windows.Forms.TextBox();
            this.PWMT8 = new System.Windows.Forms.TextBox();
            this.PWMT7 = new System.Windows.Forms.TextBox();
            this.PWMT6 = new System.Windows.Forms.TextBox();
            this.PWMT5 = new System.Windows.Forms.TextBox();
            this.PWMT4 = new System.Windows.Forms.TextBox();
            this.PWMT3 = new System.Windows.Forms.TextBox();
            this.PWMT2 = new System.Windows.Forms.TextBox();
            this.PWMT1 = new System.Windows.Forms.TextBox();
            this.PWMT0 = new System.Windows.Forms.TextBox();
            this.PWMT0ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT6ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT9ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT5ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT8ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT7ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT4ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PWMT3ProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.MissionTimeTextBox = new System.Windows.Forms.TextBox();
            this.WarningPictureBox = new System.Windows.Forms.PictureBox();
            this.BurnFirmwareButton = new System.Windows.Forms.Button();
            this.TestCalGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgEscButton = new System.Windows.Forms.Button();
            this.SpectraGroupBox = new System.Windows.Forms.GroupBox();
            this.DFTBar1 = new System.Windows.Forms.ProgressBar();
            this.DFTBar7 = new System.Windows.Forms.ProgressBar();
            this.DFTBar2 = new System.Windows.Forms.ProgressBar();
            this.DFTBar6 = new System.Windows.Forms.ProgressBar();
            this.DFTBar3 = new System.Windows.Forms.ProgressBar();
            this.DFTBar8 = new System.Windows.Forms.ProgressBar();
            this.DFTBar5 = new System.Windows.Forms.ProgressBar();
            this.DFTBar4 = new System.Windows.Forms.ProgressBar();
            this.DumpBBButton = new System.Windows.Forms.Button();
            this.AlarmsButton = new System.Windows.Forms.Button();
            this.UtilisationLabel = new System.Windows.Forms.Label();
            this.UtilisationProgressBar = new System.Windows.Forms.ProgressBar();
            this.CalibrationGroupBox = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MZCalBiasLabel = new System.Windows.Forms.Label();
            this.MYCalBiasLabel = new System.Windows.Forms.Label();
            this.MXCalBiasLabel = new System.Windows.Forms.Label();
            this.MZBiasLabel = new System.Windows.Forms.Label();
            this.MXBiasLabel = new System.Windows.Forms.Label();
            this.MYBiasLabel = new System.Windows.Forms.Label();
            this.MZScaleLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MXScaleLabel = new System.Windows.Forms.Label();
            this.MYScaleLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CalOffsetLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CalTRefLabel = new System.Windows.Forms.Label();
            this.UDAccMLabel = new System.Windows.Forms.Label();
            this.BFAccMLabel = new System.Windows.Forms.Label();
            this.LRAccMLabel = new System.Windows.Forms.Label();
            this.UDAccCLabel = new System.Windows.Forms.Label();
            this.BFAccCLabel = new System.Windows.Forms.Label();
            this.LRAccCLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.YawGyroCLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RollGyroCLabel = new System.Windows.Forms.Label();
            this.YawGyroMLabel = new System.Windows.Forms.Label();
            this.YawCalLabel = new System.Windows.Forms.Label();
            this.PitchGyroCLabel = new System.Windows.Forms.Label();
            this.PitchCalLabel = new System.Windows.Forms.Label();
            this.RollCalLabel = new System.Windows.Forms.Label();
            this.RollGyroMLabel = new System.Windows.Forms.Label();
            this.PitchGyroMLabel = new System.Windows.Forms.Label();
            this.headingIndicatorInstrumentControl1 = new Instruments.HeadingIndicatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new Instruments.AttitudeIndicatorInstrumentControl();
            this.PlotButton = new System.Windows.Forms.Button();
            this.GyroGroupBox.SuspendLayout();
            this.ControlsGroupBox.SuspendLayout();
            this.AttitudeGroupBox.SuspendLayout();
            this.AccelerationsGroupBox.SuspendLayout();
            this.CommsGroupBox.SuspendLayout();
            this.EnvGroupBox.SuspendLayout();
            this.BatteryGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.FrSkyBox.SuspendLayout();
            this.FlagsGroupBox.SuspendLayout();
            this.GPSStatBox.SuspendLayout();
            this.AltitudeGroupBox.SuspendLayout();
            this.NavGroupBox.SuspendLayout();
            this.LocationBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BaroStatsGroupBox.SuspendLayout();
            this.GPSStatsGroupBox.SuspendLayout();
            this.ErrorStatsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayNumericUpDown)).BeginInit();
            this.NavCompBox.SuspendLayout();
            this.SpeechGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakIntervalNumericUpDown)).BeginInit();
            this.DrivesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).BeginInit();
            this.TestCalGroupBox.SuspendLayout();
            this.SpectraGroupBox.SuspendLayout();
            this.CalibrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Red;
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectButton.Location = new System.Drawing.Point(171, 0);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(85, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Disconnected";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RollAngle
            // 
            this.RollAngle.Location = new System.Drawing.Point(45, 45);
            this.RollAngle.Name = "RollAngle";
            this.RollAngle.ReadOnly = true;
            this.RollAngle.Size = new System.Drawing.Size(25, 20);
            this.RollAngle.TabIndex = 5;
            this.RollAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PitchAngle
            // 
            this.PitchAngle.Location = new System.Drawing.Point(45, 71);
            this.PitchAngle.Name = "PitchAngle";
            this.PitchAngle.ReadOnly = true;
            this.PitchAngle.Size = new System.Drawing.Size(25, 20);
            this.PitchAngle.TabIndex = 6;
            this.PitchAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryVolts
            // 
            this.BatteryVolts.Location = new System.Drawing.Point(53, 19);
            this.BatteryVolts.Name = "BatteryVolts";
            this.BatteryVolts.ReadOnly = true;
            this.BatteryVolts.Size = new System.Drawing.Size(32, 20);
            this.BatteryVolts.TabIndex = 8;
            this.BatteryVolts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryCurrent
            // 
            this.BatteryCurrent.BackColor = System.Drawing.SystemColors.Control;
            this.BatteryCurrent.Location = new System.Drawing.Point(53, 45);
            this.BatteryCurrent.Name = "BatteryCurrent";
            this.BatteryCurrent.ReadOnly = true;
            this.BatteryCurrent.Size = new System.Drawing.Size(32, 20);
            this.BatteryCurrent.TabIndex = 9;
            this.BatteryCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RCGlitches
            // 
            this.RCGlitches.Location = new System.Drawing.Point(216, 52);
            this.RCGlitches.Name = "RCGlitches";
            this.RCGlitches.ReadOnly = true;
            this.RCGlitches.Size = new System.Drawing.Size(51, 20);
            this.RCGlitches.TabIndex = 10;
            this.RCGlitches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredThrottle
            // 
            this.DesiredThrottle.Location = new System.Drawing.Point(40, 19);
            this.DesiredThrottle.Name = "DesiredThrottle";
            this.DesiredThrottle.ReadOnly = true;
            this.DesiredThrottle.Size = new System.Drawing.Size(32, 20);
            this.DesiredThrottle.TabIndex = 11;
            this.DesiredThrottle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredRoll
            // 
            this.DesiredRoll.Location = new System.Drawing.Point(40, 45);
            this.DesiredRoll.Name = "DesiredRoll";
            this.DesiredRoll.ReadOnly = true;
            this.DesiredRoll.Size = new System.Drawing.Size(32, 20);
            this.DesiredRoll.TabIndex = 12;
            this.DesiredRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredPitch
            // 
            this.DesiredPitch.Location = new System.Drawing.Point(40, 71);
            this.DesiredPitch.Name = "DesiredPitch";
            this.DesiredPitch.ReadOnly = true;
            this.DesiredPitch.Size = new System.Drawing.Size(32, 20);
            this.DesiredPitch.TabIndex = 13;
            this.DesiredPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DesiredYaw
            // 
            this.DesiredYaw.Location = new System.Drawing.Point(40, 97);
            this.DesiredYaw.Name = "DesiredYaw";
            this.DesiredYaw.ReadOnly = true;
            this.DesiredYaw.Size = new System.Drawing.Size(32, 20);
            this.DesiredYaw.TabIndex = 14;
            this.DesiredYaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YawGyro
            // 
            this.YawGyro.Location = new System.Drawing.Point(37, 71);
            this.YawGyro.Name = "YawGyro";
            this.YawGyro.ReadOnly = true;
            this.YawGyro.Size = new System.Drawing.Size(35, 20);
            this.YawGyro.TabIndex = 17;
            this.YawGyro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PitchRate
            // 
            this.PitchRate.Location = new System.Drawing.Point(37, 45);
            this.PitchRate.Name = "PitchRate";
            this.PitchRate.ReadOnly = true;
            this.PitchRate.Size = new System.Drawing.Size(35, 20);
            this.PitchRate.TabIndex = 16;
            this.PitchRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RollRate
            // 
            this.RollRate.Location = new System.Drawing.Point(37, 16);
            this.RollRate.Name = "RollRate";
            this.RollRate.ReadOnly = true;
            this.RollRate.Size = new System.Drawing.Size(35, 20);
            this.RollRate.TabIndex = 15;
            this.RollRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LRAcc
            // 
            this.LRAcc.Location = new System.Drawing.Point(38, 45);
            this.LRAcc.Name = "LRAcc";
            this.LRAcc.ReadOnly = true;
            this.LRAcc.Size = new System.Drawing.Size(32, 20);
            this.LRAcc.TabIndex = 21;
            this.LRAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YawAngleError
            // 
            this.YawAngleError.Location = new System.Drawing.Point(45, 97);
            this.YawAngleError.Name = "YawAngleError";
            this.YawAngleError.ReadOnly = true;
            this.YawAngleError.Size = new System.Drawing.Size(25, 20);
            this.YawAngleError.TabIndex = 20;
            this.YawAngleError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DUAcc
            // 
            this.DUAcc.Location = new System.Drawing.Point(39, 71);
            this.DUAcc.Name = "DUAcc";
            this.DUAcc.ReadOnly = true;
            this.DUAcc.Size = new System.Drawing.Size(32, 20);
            this.DUAcc.TabIndex = 19;
            this.DUAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FBAcc
            // 
            this.FBAcc.Location = new System.Drawing.Point(39, 16);
            this.FBAcc.Name = "FBAcc";
            this.FBAcc.ReadOnly = true;
            this.FBAcc.Size = new System.Drawing.Size(32, 20);
            this.FBAcc.TabIndex = 18;
            this.FBAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VoltsLabel
            // 
            this.VoltsLabel.AutoSize = true;
            this.VoltsLabel.Location = new System.Drawing.Point(6, 22);
            this.VoltsLabel.Name = "VoltsLabel";
            this.VoltsLabel.Size = new System.Drawing.Size(30, 13);
            this.VoltsLabel.TabIndex = 22;
            this.VoltsLabel.Text = "Volts";
            // 
            // LRAccLabel
            // 
            this.LRAccLabel.AutoSize = true;
            this.LRAccLabel.Location = new System.Drawing.Point(6, 48);
            this.LRAccLabel.Name = "LRAccLabel";
            this.LRAccLabel.Size = new System.Drawing.Size(21, 13);
            this.LRAccLabel.TabIndex = 26;
            this.LRAccLabel.Text = "LR";
            // 
            // FBAccLabel
            // 
            this.FBAccLabel.AutoSize = true;
            this.FBAccLabel.Location = new System.Drawing.Point(6, 19);
            this.FBAccLabel.Name = "FBAccLabel";
            this.FBAccLabel.Size = new System.Drawing.Size(20, 13);
            this.FBAccLabel.TabIndex = 27;
            this.FBAccLabel.Text = "BF";
            // 
            // DUAccLabel
            // 
            this.DUAccLabel.AutoSize = true;
            this.DUAccLabel.Location = new System.Drawing.Point(6, 74);
            this.DUAccLabel.Name = "DUAccLabel";
            this.DUAccLabel.Size = new System.Drawing.Size(23, 13);
            this.DUAccLabel.TabIndex = 28;
            this.DUAccLabel.Text = "UD";
            // 
            // DesiredYawLabel
            // 
            this.DesiredYawLabel.AutoSize = true;
            this.DesiredYawLabel.Location = new System.Drawing.Point(6, 100);
            this.DesiredYawLabel.Name = "DesiredYawLabel";
            this.DesiredYawLabel.Size = new System.Drawing.Size(28, 13);
            this.DesiredYawLabel.TabIndex = 34;
            this.DesiredYawLabel.Text = "Yaw";
            // 
            // DesiredPitchLabel
            // 
            this.DesiredPitchLabel.AutoSize = true;
            this.DesiredPitchLabel.Location = new System.Drawing.Point(6, 74);
            this.DesiredPitchLabel.Name = "DesiredPitchLabel";
            this.DesiredPitchLabel.Size = new System.Drawing.Size(31, 13);
            this.DesiredPitchLabel.TabIndex = 33;
            this.DesiredPitchLabel.Text = "Pitch";
            // 
            // DesiredRollLabel
            // 
            this.DesiredRollLabel.AutoSize = true;
            this.DesiredRollLabel.Location = new System.Drawing.Point(6, 48);
            this.DesiredRollLabel.Name = "DesiredRollLabel";
            this.DesiredRollLabel.Size = new System.Drawing.Size(25, 13);
            this.DesiredRollLabel.TabIndex = 32;
            this.DesiredRollLabel.Text = "Roll";
            // 
            // DesiredThrottleLabel
            // 
            this.DesiredThrottleLabel.AutoSize = true;
            this.DesiredThrottleLabel.Location = new System.Drawing.Point(6, 22);
            this.DesiredThrottleLabel.Name = "DesiredThrottleLabel";
            this.DesiredThrottleLabel.Size = new System.Drawing.Size(26, 13);
            this.DesiredThrottleLabel.TabIndex = 31;
            this.DesiredThrottleLabel.Text = "Thr.";
            // 
            // RCGlitchesLabel
            // 
            this.RCGlitchesLabel.AutoSize = true;
            this.RCGlitchesLabel.Location = new System.Drawing.Point(153, 56);
            this.RCGlitchesLabel.Name = "RCGlitchesLabel";
            this.RCGlitchesLabel.Size = new System.Drawing.Size(45, 13);
            this.RCGlitchesLabel.TabIndex = 30;
            this.RCGlitchesLabel.Text = "Glitches";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Location = new System.Drawing.Point(6, 48);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(33, 13);
            this.CurrentLabel.TabIndex = 29;
            this.CurrentLabel.Text = "Amps";
            // 
            // GPShAcc
            // 
            this.GPShAcc.Location = new System.Drawing.Point(52, 71);
            this.GPShAcc.Name = "GPShAcc";
            this.GPShAcc.ReadOnly = true;
            this.GPShAcc.Size = new System.Drawing.Size(32, 20);
            this.GPShAcc.TabIndex = 44;
            this.GPShAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RangefinderAltitude
            // 
            this.RangefinderAltitude.Location = new System.Drawing.Point(113, 28);
            this.RangefinderAltitude.Name = "RangefinderAltitude";
            this.RangefinderAltitude.ReadOnly = true;
            this.RangefinderAltitude.Size = new System.Drawing.Size(40, 20);
            this.RangefinderAltitude.TabIndex = 43;
            this.RangefinderAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BaroAltitude
            // 
            this.BaroAltitude.Location = new System.Drawing.Point(59, 28);
            this.BaroAltitude.Name = "BaroAltitude";
            this.BaroAltitude.ReadOnly = true;
            this.BaroAltitude.Size = new System.Drawing.Size(48, 20);
            this.BaroAltitude.TabIndex = 46;
            this.BaroAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSFix
            // 
            this.GPSFix.Location = new System.Drawing.Point(52, 45);
            this.GPSFix.Name = "GPSFix";
            this.GPSFix.ReadOnly = true;
            this.GPSFix.Size = new System.Drawing.Size(32, 20);
            this.GPSFix.TabIndex = 51;
            this.GPSFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ROC
            // 
            this.ROC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ROC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROC.Location = new System.Drawing.Point(512, 73);
            this.ROC.Name = "ROC";
            this.ROC.ReadOnly = true;
            this.ROC.Size = new System.Drawing.Size(54, 23);
            this.ROC.TabIndex = 49;
            this.ROC.Text = "0";
            this.ROC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSNoOfSats
            // 
            this.GPSNoOfSats.Location = new System.Drawing.Point(52, 19);
            this.GPSNoOfSats.Name = "GPSNoOfSats";
            this.GPSNoOfSats.ReadOnly = true;
            this.GPSNoOfSats.Size = new System.Drawing.Size(32, 20);
            this.GPSNoOfSats.TabIndex = 54;
            this.GPSNoOfSats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FailState
            // 
            this.FailState.Location = new System.Drawing.Point(125, 30);
            this.FailState.Name = "FailState";
            this.FailState.ReadOnly = true;
            this.FailState.Size = new System.Drawing.Size(73, 20);
            this.FailState.TabIndex = 53;
            this.FailState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSAltitude
            // 
            this.GPSAltitude.Location = new System.Drawing.Point(6, 28);
            this.GPSAltitude.Name = "GPSAltitude";
            this.GPSAltitude.ReadOnly = true;
            this.GPSAltitude.Size = new System.Drawing.Size(47, 20);
            this.GPSAltitude.TabIndex = 58;
            this.GPSAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ROCLabel
            // 
            this.ROCLabel.AutoSize = true;
            this.ROCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROCLabel.Location = new System.Drawing.Point(536, 57);
            this.ROCLabel.Name = "ROCLabel";
            this.ROCLabel.Size = new System.Drawing.Size(33, 13);
            this.ROCLabel.TabIndex = 65;
            this.ROCLabel.Text = "ROC";
            // 
            // hAccLabel
            // 
            this.hAccLabel.AutoSize = true;
            this.hAccLabel.Location = new System.Drawing.Point(6, 74);
            this.hAccLabel.Name = "hAccLabel";
            this.hAccLabel.Size = new System.Drawing.Size(32, 13);
            this.hAccLabel.TabIndex = 66;
            this.hAccLabel.Text = "hAcc";
            // 
            // RangefinderAltLabel
            // 
            this.RangefinderAltLabel.AutoSize = true;
            this.RangefinderAltLabel.Location = new System.Drawing.Point(125, 13);
            this.RangefinderAltLabel.Name = "RangefinderAltLabel";
            this.RangefinderAltLabel.Size = new System.Drawing.Size(21, 13);
            this.RangefinderAltLabel.TabIndex = 67;
            this.RangefinderAltLabel.Text = "RF";
            // 
            // GPSFixLabel
            // 
            this.GPSFixLabel.AutoSize = true;
            this.GPSFixLabel.Location = new System.Drawing.Point(6, 48);
            this.GPSFixLabel.Name = "GPSFixLabel";
            this.GPSFixLabel.Size = new System.Drawing.Size(20, 13);
            this.GPSFixLabel.TabIndex = 69;
            this.GPSFixLabel.Text = "Fix";
            // 
            // GPSNoOfSatsLabel
            // 
            this.GPSNoOfSatsLabel.AutoSize = true;
            this.GPSNoOfSatsLabel.Location = new System.Drawing.Point(6, 22);
            this.GPSNoOfSatsLabel.Name = "GPSNoOfSatsLabel";
            this.GPSNoOfSatsLabel.Size = new System.Drawing.Size(31, 13);
            this.GPSNoOfSatsLabel.TabIndex = 70;
            this.GPSNoOfSatsLabel.Text = "Sats.";
            // 
            // FailStateLabel
            // 
            this.FailStateLabel.AutoSize = true;
            this.FailStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailStateLabel.Location = new System.Drawing.Point(96, 33);
            this.FailStateLabel.Name = "FailStateLabel";
            this.FailStateLabel.Size = new System.Drawing.Size(23, 13);
            this.FailStateLabel.TabIndex = 71;
            this.FailStateLabel.Text = "Fail";
            // 
            // GPSAltLabel
            // 
            this.GPSAltLabel.AutoSize = true;
            this.GPSAltLabel.Location = new System.Drawing.Point(17, 13);
            this.GPSAltLabel.Name = "GPSAltLabel";
            this.GPSAltLabel.Size = new System.Drawing.Size(29, 13);
            this.GPSAltLabel.TabIndex = 74;
            this.GPSAltLabel.Text = "GPS";
            // 
            // BaroAltitudeLabel
            // 
            this.BaroAltitudeLabel.AutoSize = true;
            this.BaroAltitudeLabel.Location = new System.Drawing.Point(74, 13);
            this.BaroAltitudeLabel.Name = "BaroAltitudeLabel";
            this.BaroAltitudeLabel.Size = new System.Drawing.Size(29, 13);
            this.BaroAltitudeLabel.TabIndex = 75;
            this.BaroAltitudeLabel.Text = "Baro";
            // 
            // YawGyroLabel
            // 
            this.YawGyroLabel.AutoSize = true;
            this.YawGyroLabel.Location = new System.Drawing.Point(6, 74);
            this.YawGyroLabel.Name = "YawGyroLabel";
            this.YawGyroLabel.Size = new System.Drawing.Size(28, 13);
            this.YawGyroLabel.TabIndex = 78;
            this.YawGyroLabel.Text = "Yaw";
            // 
            // PitchRateLabel
            // 
            this.PitchRateLabel.AutoSize = true;
            this.PitchRateLabel.Location = new System.Drawing.Point(6, 48);
            this.PitchRateLabel.Name = "PitchRateLabel";
            this.PitchRateLabel.Size = new System.Drawing.Size(31, 13);
            this.PitchRateLabel.TabIndex = 77;
            this.PitchRateLabel.Text = "Pitch";
            // 
            // RollRateLabel
            // 
            this.RollRateLabel.AutoSize = true;
            this.RollRateLabel.Location = new System.Drawing.Point(6, 22);
            this.RollRateLabel.Name = "RollRateLabel";
            this.RollRateLabel.Size = new System.Drawing.Size(25, 13);
            this.RollRateLabel.TabIndex = 76;
            this.RollRateLabel.Text = "Roll";
            // 
            // RxTypeErr
            // 
            this.RxTypeErr.Location = new System.Drawing.Point(65, 18);
            this.RxTypeErr.Name = "RxTypeErr";
            this.RxTypeErr.ReadOnly = true;
            this.RxTypeErr.Size = new System.Drawing.Size(38, 20);
            this.RxTypeErr.TabIndex = 82;
            this.RxTypeErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxCSumErr
            // 
            this.RxCSumErr.Location = new System.Drawing.Point(65, 70);
            this.RxCSumErr.Name = "RxCSumErr";
            this.RxCSumErr.ReadOnly = true;
            this.RxCSumErr.Size = new System.Drawing.Size(38, 20);
            this.RxCSumErr.TabIndex = 83;
            this.RxCSumErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxLenErr
            // 
            this.RxLenErr.Location = new System.Drawing.Point(65, 44);
            this.RxLenErr.Name = "RxLenErr";
            this.RxLenErr.ReadOnly = true;
            this.RxLenErr.Size = new System.Drawing.Size(38, 20);
            this.RxLenErr.TabIndex = 84;
            this.RxLenErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RxTypeLabel
            // 
            this.RxTypeLabel.AutoSize = true;
            this.RxTypeLabel.Location = new System.Drawing.Point(6, 22);
            this.RxTypeLabel.Name = "RxTypeLabel";
            this.RxTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.RxTypeLabel.TabIndex = 85;
            this.RxTypeLabel.Text = "Type";
            // 
            // RxCSumLabel
            // 
            this.RxCSumLabel.AutoSize = true;
            this.RxCSumLabel.Location = new System.Drawing.Point(6, 73);
            this.RxCSumLabel.Name = "RxCSumLabel";
            this.RxCSumLabel.Size = new System.Drawing.Size(59, 13);
            this.RxCSumLabel.TabIndex = 86;
            this.RxCSumLabel.Text = "CheckSum";
            // 
            // RxLenLabel
            // 
            this.RxLenLabel.AutoSize = true;
            this.RxLenLabel.Location = new System.Drawing.Point(6, 48);
            this.RxLenLabel.Name = "RxLenLabel";
            this.RxLenLabel.Size = new System.Drawing.Size(40, 13);
            this.RxLenLabel.TabIndex = 87;
            this.RxLenLabel.Text = "Length";
            // 
            // FlightState
            // 
            this.FlightState.Location = new System.Drawing.Point(12, 30);
            this.FlightState.Name = "FlightState";
            this.FlightState.ReadOnly = true;
            this.FlightState.Size = new System.Drawing.Size(73, 20);
            this.FlightState.TabIndex = 89;
            this.FlightState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GyroGroupBox
            // 
            this.GyroGroupBox.Controls.Add(this.RollRate);
            this.GyroGroupBox.Controls.Add(this.PitchRate);
            this.GyroGroupBox.Controls.Add(this.YawGyro);
            this.GyroGroupBox.Controls.Add(this.RollRateLabel);
            this.GyroGroupBox.Controls.Add(this.PitchRateLabel);
            this.GyroGroupBox.Controls.Add(this.YawGyroLabel);
            this.GyroGroupBox.Location = new System.Drawing.Point(12, 187);
            this.GyroGroupBox.Name = "GyroGroupBox";
            this.GyroGroupBox.Size = new System.Drawing.Size(77, 99);
            this.GyroGroupBox.TabIndex = 92;
            this.GyroGroupBox.TabStop = false;
            this.GyroGroupBox.Text = "Gyros";
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.DesiredYaw);
            this.ControlsGroupBox.Controls.Add(this.DesiredRoll);
            this.ControlsGroupBox.Controls.Add(this.DesiredPitch);
            this.ControlsGroupBox.Controls.Add(this.DesiredRollLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredPitchLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredYawLabel);
            this.ControlsGroupBox.Controls.Add(this.DesiredThrottle);
            this.ControlsGroupBox.Controls.Add(this.DesiredThrottleLabel);
            this.ControlsGroupBox.Location = new System.Drawing.Point(12, 57);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(77, 124);
            this.ControlsGroupBox.TabIndex = 93;
            this.ControlsGroupBox.TabStop = false;
            this.ControlsGroupBox.Text = "Controls(%)";
            // 
            // AttitudeGroupBox
            // 
            this.AttitudeGroupBox.Controls.Add(this.AccConfidenceLabel);
            this.AttitudeGroupBox.Controls.Add(this.YawLabel);
            this.AttitudeGroupBox.Controls.Add(this.PitchLabel);
            this.AttitudeGroupBox.Controls.Add(this.AccConfidence);
            this.AttitudeGroupBox.Controls.Add(this.RollLabel);
            this.AttitudeGroupBox.Controls.Add(this.RollAngle);
            this.AttitudeGroupBox.Controls.Add(this.PitchAngle);
            this.AttitudeGroupBox.Controls.Add(this.YawAngleError);
            this.AttitudeGroupBox.Location = new System.Drawing.Point(95, 57);
            this.AttitudeGroupBox.Name = "AttitudeGroupBox";
            this.AttitudeGroupBox.Size = new System.Drawing.Size(77, 124);
            this.AttitudeGroupBox.TabIndex = 94;
            this.AttitudeGroupBox.TabStop = false;
            this.AttitudeGroupBox.Text = "Attitude";
            // 
            // AccConfidenceLabel
            // 
            this.AccConfidenceLabel.AutoSize = true;
            this.AccConfidenceLabel.Location = new System.Drawing.Point(5, 22);
            this.AccConfidenceLabel.Name = "AccConfidenceLabel";
            this.AccConfidenceLabel.Size = new System.Drawing.Size(40, 13);
            this.AccConfidenceLabel.TabIndex = 111;
            this.AccConfidenceLabel.Text = "Acc(%)";
            // 
            // YawLabel
            // 
            this.YawLabel.AutoSize = true;
            this.YawLabel.Location = new System.Drawing.Point(4, 100);
            this.YawLabel.Name = "YawLabel";
            this.YawLabel.Size = new System.Drawing.Size(35, 13);
            this.YawLabel.TabIndex = 109;
            this.YawLabel.Text = "YawE";
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(5, 74);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(31, 13);
            this.PitchLabel.TabIndex = 108;
            this.PitchLabel.Text = "Pitch";
            // 
            // AccConfidence
            // 
            this.AccConfidence.Location = new System.Drawing.Point(45, 19);
            this.AccConfidence.Name = "AccConfidence";
            this.AccConfidence.ReadOnly = true;
            this.AccConfidence.Size = new System.Drawing.Size(25, 20);
            this.AccConfidence.TabIndex = 110;
            this.AccConfidence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.Location = new System.Drawing.Point(5, 48);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(25, 13);
            this.RollLabel.TabIndex = 107;
            this.RollLabel.Text = "Roll";
            // 
            // AccelerationsGroupBox
            // 
            this.AccelerationsGroupBox.Controls.Add(this.LRAcc);
            this.AccelerationsGroupBox.Controls.Add(this.FBAcc);
            this.AccelerationsGroupBox.Controls.Add(this.DUAcc);
            this.AccelerationsGroupBox.Controls.Add(this.LRAccLabel);
            this.AccelerationsGroupBox.Controls.Add(this.FBAccLabel);
            this.AccelerationsGroupBox.Controls.Add(this.DUAccLabel);
            this.AccelerationsGroupBox.Location = new System.Drawing.Point(95, 187);
            this.AccelerationsGroupBox.Name = "AccelerationsGroupBox";
            this.AccelerationsGroupBox.Size = new System.Drawing.Size(77, 99);
            this.AccelerationsGroupBox.TabIndex = 95;
            this.AccelerationsGroupBox.TabStop = false;
            this.AccelerationsGroupBox.Text = "Accel. (G)";
            // 
            // CommsGroupBox
            // 
            this.CommsGroupBox.Controls.Add(this.RxTypeErr);
            this.CommsGroupBox.Controls.Add(this.RxCSumErr);
            this.CommsGroupBox.Controls.Add(this.RxLenErr);
            this.CommsGroupBox.Controls.Add(this.RxTypeLabel);
            this.CommsGroupBox.Controls.Add(this.RxCSumLabel);
            this.CommsGroupBox.Controls.Add(this.RxLenLabel);
            this.CommsGroupBox.Location = new System.Drawing.Point(12, 444);
            this.CommsGroupBox.Name = "CommsGroupBox";
            this.CommsGroupBox.Size = new System.Drawing.Size(109, 98);
            this.CommsGroupBox.TabIndex = 96;
            this.CommsGroupBox.TabStop = false;
            this.CommsGroupBox.Text = "Telemetry Errors";
            // 
            // EnvGroupBox
            // 
            this.EnvGroupBox.Controls.Add(this.SensorTemp);
            this.EnvGroupBox.Controls.Add(this.SensorTempLabel);
            this.EnvGroupBox.Location = new System.Drawing.Point(587, 33);
            this.EnvGroupBox.Name = "EnvGroupBox";
            this.EnvGroupBox.Size = new System.Drawing.Size(125, 43);
            this.EnvGroupBox.TabIndex = 97;
            this.EnvGroupBox.TabStop = false;
            this.EnvGroupBox.Text = "IMU";
            // 
            // SensorTemp
            // 
            this.SensorTemp.Location = new System.Drawing.Point(71, 14);
            this.SensorTemp.Name = "SensorTemp";
            this.SensorTemp.ReadOnly = true;
            this.SensorTemp.Size = new System.Drawing.Size(48, 20);
            this.SensorTemp.TabIndex = 161;
            this.SensorTemp.Text = "0.0";
            this.SensorTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SensorTempLabel
            // 
            this.SensorTempLabel.AutoSize = true;
            this.SensorTempLabel.Location = new System.Drawing.Point(6, 17);
            this.SensorTempLabel.Name = "SensorTempLabel";
            this.SensorTempLabel.Size = new System.Drawing.Size(53, 13);
            this.SensorTempLabel.TabIndex = 162;
            this.SensorTempLabel.Text = "Temp. (C)";
            // 
            // BatteryGroupBox
            // 
            this.BatteryGroupBox.Controls.Add(this.BatteryCharge);
            this.BatteryGroupBox.Controls.Add(this.BatteryChargeLabel);
            this.BatteryGroupBox.Controls.Add(this.BatteryVolts);
            this.BatteryGroupBox.Controls.Add(this.BatteryCurrent);
            this.BatteryGroupBox.Controls.Add(this.VoltsLabel);
            this.BatteryGroupBox.Controls.Add(this.CurrentLabel);
            this.BatteryGroupBox.Location = new System.Drawing.Point(227, 445);
            this.BatteryGroupBox.Name = "BatteryGroupBox";
            this.BatteryGroupBox.Size = new System.Drawing.Size(90, 97);
            this.BatteryGroupBox.TabIndex = 98;
            this.BatteryGroupBox.TabStop = false;
            this.BatteryGroupBox.Text = "Battery";
            // 
            // BatteryCharge
            // 
            this.BatteryCharge.BackColor = System.Drawing.SystemColors.Control;
            this.BatteryCharge.Location = new System.Drawing.Point(35, 71);
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.ReadOnly = true;
            this.BatteryCharge.Size = new System.Drawing.Size(50, 20);
            this.BatteryCharge.TabIndex = 30;
            this.BatteryCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BatteryChargeLabel
            // 
            this.BatteryChargeLabel.AutoSize = true;
            this.BatteryChargeLabel.Location = new System.Drawing.Point(6, 74);
            this.BatteryChargeLabel.Name = "BatteryChargeLabel";
            this.BatteryChargeLabel.Size = new System.Drawing.Size(30, 13);
            this.BatteryChargeLabel.TabIndex = 31;
            this.BatteryChargeLabel.Text = "mAH";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AltHoldBox);
            this.flowLayoutPanel1.Controls.Add(this.TurnToPOIBox);
            this.flowLayoutPanel1.Controls.Add(this.UseRTHAutoDescendBox);
            this.flowLayoutPanel1.Controls.Add(this.BaroAltValidBox);
            this.flowLayoutPanel1.Controls.Add(this.RangefinderAltValidBox);
            this.flowLayoutPanel1.Controls.Add(this.GPSValidBox);
            this.flowLayoutPanel1.Controls.Add(this.NavValidBox);
            this.flowLayoutPanel1.Controls.Add(this.SticksFrozenBox);
            this.flowLayoutPanel1.Controls.Add(this.LowBatteryBox);
            this.flowLayoutPanel1.Controls.Add(this.ThrottleMovingBox);
            this.flowLayoutPanel1.Controls.Add(this.HoldingAltBox);
            this.flowLayoutPanel1.Controls.Add(this.AttitudeHoldBox);
            this.flowLayoutPanel1.Controls.Add(this.NearLevelBox);
            this.flowLayoutPanel1.Controls.Add(this.BypassBox);
            this.flowLayoutPanel1.Controls.Add(this.NavigateBox);
            this.flowLayoutPanel1.Controls.Add(this.RateControlBox);
            this.flowLayoutPanel1.Controls.Add(this.UsingRangefinderBox);
            this.flowLayoutPanel1.Controls.Add(this.CloseProximityBox);
            this.flowLayoutPanel1.Controls.Add(this.ProximityBox);
            this.flowLayoutPanel1.Controls.Add(this.IMUFailBox);
            this.flowLayoutPanel1.Controls.Add(this.MagFailBox);
            this.flowLayoutPanel1.Controls.Add(this.MagLockedBox);
            this.flowLayoutPanel1.Controls.Add(this.BaroFailBox);
            this.flowLayoutPanel1.Controls.Add(this.GPSFailBox);
            this.flowLayoutPanel1.Controls.Add(this.LostModelBox);
            this.flowLayoutPanel1.Controls.Add(this.UsingUplinkFlagBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 336);
            this.flowLayoutPanel1.TabIndex = 99;
            // 
            // AltHoldBox
            // 
            this.AltHoldBox.AcceptsTab = true;
            this.AltHoldBox.BackColor = System.Drawing.SystemColors.Window;
            this.AltHoldBox.Location = new System.Drawing.Point(3, 3);
            this.AltHoldBox.Name = "AltHoldBox";
            this.AltHoldBox.ReadOnly = true;
            this.AltHoldBox.Size = new System.Drawing.Size(109, 20);
            this.AltHoldBox.TabIndex = 100;
            this.AltHoldBox.Text = "Alt Hold Enabled";
            this.AltHoldBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TurnToPOIBox
            // 
            this.TurnToPOIBox.BackColor = System.Drawing.SystemColors.Window;
            this.TurnToPOIBox.Location = new System.Drawing.Point(118, 3);
            this.TurnToPOIBox.Name = "TurnToPOIBox";
            this.TurnToPOIBox.ReadOnly = true;
            this.TurnToPOIBox.Size = new System.Drawing.Size(109, 20);
            this.TurnToPOIBox.TabIndex = 101;
            this.TurnToPOIBox.Text = "Turn to POI";
            this.TurnToPOIBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UseRTHAutoDescendBox
            // 
            this.UseRTHAutoDescendBox.BackColor = System.Drawing.SystemColors.Window;
            this.UseRTHAutoDescendBox.Location = new System.Drawing.Point(3, 29);
            this.UseRTHAutoDescendBox.Name = "UseRTHAutoDescendBox";
            this.UseRTHAutoDescendBox.ReadOnly = true;
            this.UseRTHAutoDescendBox.Size = new System.Drawing.Size(109, 20);
            this.UseRTHAutoDescendBox.TabIndex = 120;
            this.UseRTHAutoDescendBox.Text = "Using Auto Land";
            this.UseRTHAutoDescendBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaroAltValidBox
            // 
            this.BaroAltValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.BaroAltValidBox.Location = new System.Drawing.Point(118, 29);
            this.BaroAltValidBox.Name = "BaroAltValidBox";
            this.BaroAltValidBox.ReadOnly = true;
            this.BaroAltValidBox.Size = new System.Drawing.Size(109, 20);
            this.BaroAltValidBox.TabIndex = 121;
            this.BaroAltValidBox.Text = "Baro Alt Valid";
            this.BaroAltValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangefinderAltValidBox
            // 
            this.RangefinderAltValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.RangefinderAltValidBox.Location = new System.Drawing.Point(3, 55);
            this.RangefinderAltValidBox.Name = "RangefinderAltValidBox";
            this.RangefinderAltValidBox.ReadOnly = true;
            this.RangefinderAltValidBox.Size = new System.Drawing.Size(109, 20);
            this.RangefinderAltValidBox.TabIndex = 122;
            this.RangefinderAltValidBox.Text = "Rangefinder Valid";
            this.RangefinderAltValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSValidBox
            // 
            this.GPSValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.GPSValidBox.Location = new System.Drawing.Point(118, 55);
            this.GPSValidBox.Name = "GPSValidBox";
            this.GPSValidBox.ReadOnly = true;
            this.GPSValidBox.Size = new System.Drawing.Size(109, 20);
            this.GPSValidBox.TabIndex = 105;
            this.GPSValidBox.Text = "GPS Valid";
            this.GPSValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavValidBox
            // 
            this.NavValidBox.BackColor = System.Drawing.SystemColors.Window;
            this.NavValidBox.Location = new System.Drawing.Point(3, 81);
            this.NavValidBox.Name = "NavValidBox";
            this.NavValidBox.ReadOnly = true;
            this.NavValidBox.Size = new System.Drawing.Size(109, 20);
            this.NavValidBox.TabIndex = 107;
            this.NavValidBox.Text = "Origin Recorded";
            this.NavValidBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SticksFrozenBox
            // 
            this.SticksFrozenBox.AcceptsTab = true;
            this.SticksFrozenBox.BackColor = System.Drawing.SystemColors.Window;
            this.SticksFrozenBox.Location = new System.Drawing.Point(118, 81);
            this.SticksFrozenBox.Name = "SticksFrozenBox";
            this.SticksFrozenBox.ReadOnly = true;
            this.SticksFrozenBox.Size = new System.Drawing.Size(109, 20);
            this.SticksFrozenBox.TabIndex = 126;
            this.SticksFrozenBox.Text = "Sticks Frozen";
            this.SticksFrozenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LowBatteryBox
            // 
            this.LowBatteryBox.BackColor = System.Drawing.SystemColors.Window;
            this.LowBatteryBox.Location = new System.Drawing.Point(3, 107);
            this.LowBatteryBox.Name = "LowBatteryBox";
            this.LowBatteryBox.ReadOnly = true;
            this.LowBatteryBox.Size = new System.Drawing.Size(109, 20);
            this.LowBatteryBox.TabIndex = 106;
            this.LowBatteryBox.Text = "Low Battery";
            this.LowBatteryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThrottleMovingBox
            // 
            this.ThrottleMovingBox.BackColor = System.Drawing.SystemColors.Window;
            this.ThrottleMovingBox.Location = new System.Drawing.Point(118, 107);
            this.ThrottleMovingBox.Name = "ThrottleMovingBox";
            this.ThrottleMovingBox.ReadOnly = true;
            this.ThrottleMovingBox.Size = new System.Drawing.Size(109, 20);
            this.ThrottleMovingBox.TabIndex = 113;
            this.ThrottleMovingBox.Text = "Throttle Moving";
            this.ThrottleMovingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoldingAltBox
            // 
            this.HoldingAltBox.BackColor = System.Drawing.SystemColors.Window;
            this.HoldingAltBox.Location = new System.Drawing.Point(3, 133);
            this.HoldingAltBox.Name = "HoldingAltBox";
            this.HoldingAltBox.ReadOnly = true;
            this.HoldingAltBox.Size = new System.Drawing.Size(109, 20);
            this.HoldingAltBox.TabIndex = 114;
            this.HoldingAltBox.Text = "Holding Altitude";
            this.HoldingAltBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttitudeHoldBox
            // 
            this.AttitudeHoldBox.BackColor = System.Drawing.SystemColors.Window;
            this.AttitudeHoldBox.Location = new System.Drawing.Point(118, 133);
            this.AttitudeHoldBox.Name = "AttitudeHoldBox";
            this.AttitudeHoldBox.ReadOnly = true;
            this.AttitudeHoldBox.Size = new System.Drawing.Size(109, 20);
            this.AttitudeHoldBox.TabIndex = 112;
            this.AttitudeHoldBox.Text = "Holding Roll&Pitch";
            this.AttitudeHoldBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NearLevelBox
            // 
            this.NearLevelBox.BackColor = System.Drawing.SystemColors.Window;
            this.NearLevelBox.Location = new System.Drawing.Point(3, 159);
            this.NearLevelBox.Name = "NearLevelBox";
            this.NearLevelBox.ReadOnly = true;
            this.NearLevelBox.Size = new System.Drawing.Size(109, 20);
            this.NearLevelBox.TabIndex = 104;
            this.NearLevelBox.Text = "Near Level";
            this.NearLevelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BypassBox
            // 
            this.BypassBox.BackColor = System.Drawing.SystemColors.Window;
            this.BypassBox.Location = new System.Drawing.Point(118, 159);
            this.BypassBox.Name = "BypassBox";
            this.BypassBox.ReadOnly = true;
            this.BypassBox.Size = new System.Drawing.Size(109, 20);
            this.BypassBox.TabIndex = 125;
            this.BypassBox.Text = "Bypass";
            this.BypassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavigateBox
            // 
            this.NavigateBox.BackColor = System.Drawing.SystemColors.Window;
            this.NavigateBox.Location = new System.Drawing.Point(3, 185);
            this.NavigateBox.Name = "NavigateBox";
            this.NavigateBox.ReadOnly = true;
            this.NavigateBox.Size = new System.Drawing.Size(109, 20);
            this.NavigateBox.TabIndex = 115;
            this.NavigateBox.Text = "Transiting";
            this.NavigateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RateControlBox
            // 
            this.RateControlBox.BackColor = System.Drawing.SystemColors.Window;
            this.RateControlBox.Location = new System.Drawing.Point(118, 185);
            this.RateControlBox.Name = "RateControlBox";
            this.RateControlBox.ReadOnly = true;
            this.RateControlBox.Size = new System.Drawing.Size(109, 20);
            this.RateControlBox.TabIndex = 116;
            this.RateControlBox.Text = "Rate Control";
            this.RateControlBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsingRangefinderBox
            // 
            this.UsingRangefinderBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsingRangefinderBox.Location = new System.Drawing.Point(3, 211);
            this.UsingRangefinderBox.Name = "UsingRangefinderBox";
            this.UsingRangefinderBox.ReadOnly = true;
            this.UsingRangefinderBox.Size = new System.Drawing.Size(109, 20);
            this.UsingRangefinderBox.TabIndex = 123;
            this.UsingRangefinderBox.Text = "Using Rangefinder";
            this.UsingRangefinderBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseProximityBox
            // 
            this.CloseProximityBox.BackColor = System.Drawing.SystemColors.Window;
            this.CloseProximityBox.Location = new System.Drawing.Point(118, 211);
            this.CloseProximityBox.Name = "CloseProximityBox";
            this.CloseProximityBox.ReadOnly = true;
            this.CloseProximityBox.Size = new System.Drawing.Size(109, 20);
            this.CloseProximityBox.TabIndex = 118;
            this.CloseProximityBox.Text = "Centered";
            this.CloseProximityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProximityBox
            // 
            this.ProximityBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProximityBox.Location = new System.Drawing.Point(3, 237);
            this.ProximityBox.Name = "ProximityBox";
            this.ProximityBox.ReadOnly = true;
            this.ProximityBox.Size = new System.Drawing.Size(109, 20);
            this.ProximityBox.TabIndex = 117;
            this.ProximityBox.Text = "WP Achieved";
            this.ProximityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IMUFailBox
            // 
            this.IMUFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.IMUFailBox.Location = new System.Drawing.Point(118, 237);
            this.IMUFailBox.Name = "IMUFailBox";
            this.IMUFailBox.ReadOnly = true;
            this.IMUFailBox.Size = new System.Drawing.Size(109, 20);
            this.IMUFailBox.TabIndex = 109;
            this.IMUFailBox.Text = "IMU Error";
            this.IMUFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MagFailBox
            // 
            this.MagFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.MagFailBox.Location = new System.Drawing.Point(3, 263);
            this.MagFailBox.Name = "MagFailBox";
            this.MagFailBox.ReadOnly = true;
            this.MagFailBox.Size = new System.Drawing.Size(109, 20);
            this.MagFailBox.TabIndex = 110;
            this.MagFailBox.Text = "Mag Error";
            this.MagFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MagLockedBox
            // 
            this.MagLockedBox.BackColor = System.Drawing.SystemColors.Window;
            this.MagLockedBox.Location = new System.Drawing.Point(118, 263);
            this.MagLockedBox.Name = "MagLockedBox";
            this.MagLockedBox.ReadOnly = true;
            this.MagLockedBox.Size = new System.Drawing.Size(109, 20);
            this.MagLockedBox.TabIndex = 127;
            this.MagLockedBox.Text = "Mag Locked";
            this.MagLockedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaroFailBox
            // 
            this.BaroFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.BaroFailBox.Location = new System.Drawing.Point(3, 289);
            this.BaroFailBox.Name = "BaroFailBox";
            this.BaroFailBox.ReadOnly = true;
            this.BaroFailBox.Size = new System.Drawing.Size(109, 20);
            this.BaroFailBox.TabIndex = 108;
            this.BaroFailBox.Text = "Baro Error";
            this.BaroFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GPSFailBox
            // 
            this.GPSFailBox.BackColor = System.Drawing.SystemColors.Window;
            this.GPSFailBox.Location = new System.Drawing.Point(118, 289);
            this.GPSFailBox.Name = "GPSFailBox";
            this.GPSFailBox.ReadOnly = true;
            this.GPSFailBox.Size = new System.Drawing.Size(109, 20);
            this.GPSFailBox.TabIndex = 111;
            this.GPSFailBox.Text = "GPS Error";
            this.GPSFailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LostModelBox
            // 
            this.LostModelBox.BackColor = System.Drawing.SystemColors.Window;
            this.LostModelBox.Location = new System.Drawing.Point(3, 315);
            this.LostModelBox.Name = "LostModelBox";
            this.LostModelBox.ReadOnly = true;
            this.LostModelBox.Size = new System.Drawing.Size(109, 20);
            this.LostModelBox.TabIndex = 103;
            this.LostModelBox.Text = "Lost Model";
            this.LostModelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsingUplinkFlagBox
            // 
            this.UsingUplinkFlagBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsingUplinkFlagBox.Location = new System.Drawing.Point(118, 315);
            this.UsingUplinkFlagBox.Name = "UsingUplinkFlagBox";
            this.UsingUplinkFlagBox.ReadOnly = true;
            this.UsingUplinkFlagBox.Size = new System.Drawing.Size(109, 20);
            this.UsingUplinkFlagBox.TabIndex = 102;
            this.UsingUplinkFlagBox.Text = "Uplink Enabled";
            this.UsingUplinkFlagBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrSkyBox
            // 
            this.FrSkyBox.Controls.Add(this.FrSkyErrLabel);
            this.FrSkyBox.Controls.Add(this.RxFrSkyErr);
            this.FrSkyBox.Controls.Add(this.FrSkyCheckBox);
            this.FrSkyBox.Controls.Add(this.FrSkyLQLabel);
            this.FrSkyBox.Controls.Add(this.FrSkyA2Label);
            this.FrSkyBox.Controls.Add(this.FrSkyALabel);
            this.FrSkyBox.Controls.Add(this.FrSkyLQ);
            this.FrSkyBox.Controls.Add(this.FrSkyA2);
            this.FrSkyBox.Controls.Add(this.FrSkyA1);
            this.FrSkyBox.Location = new System.Drawing.Point(347, 235);
            this.FrSkyBox.Name = "FrSkyBox";
            this.FrSkyBox.Size = new System.Drawing.Size(174, 56);
            this.FrSkyBox.TabIndex = 169;
            this.FrSkyBox.TabStop = false;
            this.FrSkyBox.Text = "FrSky";
            this.FrSkyBox.Visible = false;
            // 
            // FrSkyErrLabel
            // 
            this.FrSkyErrLabel.AutoSize = true;
            this.FrSkyErrLabel.Location = new System.Drawing.Point(140, 12);
            this.FrSkyErrLabel.Name = "FrSkyErrLabel";
            this.FrSkyErrLabel.Size = new System.Drawing.Size(23, 13);
            this.FrSkyErrLabel.TabIndex = 75;
            this.FrSkyErrLabel.Text = "Err.";
            // 
            // RxFrSkyErr
            // 
            this.RxFrSkyErr.Location = new System.Drawing.Point(140, 28);
            this.RxFrSkyErr.Name = "RxFrSkyErr";
            this.RxFrSkyErr.ReadOnly = true;
            this.RxFrSkyErr.Size = new System.Drawing.Size(28, 20);
            this.RxFrSkyErr.TabIndex = 74;
            this.RxFrSkyErr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrSkyCheckBox
            // 
            this.FrSkyCheckBox.AutoSize = true;
            this.FrSkyCheckBox.Location = new System.Drawing.Point(6, 31);
            this.FrSkyCheckBox.Name = "FrSkyCheckBox";
            this.FrSkyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FrSkyCheckBox.TabIndex = 168;
            this.FrSkyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrSkyLQLabel
            // 
            this.FrSkyLQLabel.AutoSize = true;
            this.FrSkyLQLabel.Location = new System.Drawing.Point(23, 12);
            this.FrSkyLQLabel.Name = "FrSkyLQLabel";
            this.FrSkyLQLabel.Size = new System.Drawing.Size(39, 13);
            this.FrSkyLQLabel.TabIndex = 73;
            this.FrSkyLQLabel.Text = "LQ(db)";
            // 
            // FrSkyA2Label
            // 
            this.FrSkyA2Label.AutoSize = true;
            this.FrSkyA2Label.Location = new System.Drawing.Point(102, 12);
            this.FrSkyA2Label.Name = "FrSkyA2Label";
            this.FrSkyA2Label.Size = new System.Drawing.Size(33, 13);
            this.FrSkyA2Label.TabIndex = 71;
            this.FrSkyA2Label.Text = "A2(V)";
            // 
            // FrSkyALabel
            // 
            this.FrSkyALabel.AutoSize = true;
            this.FrSkyALabel.Location = new System.Drawing.Point(65, 11);
            this.FrSkyALabel.Name = "FrSkyALabel";
            this.FrSkyALabel.Size = new System.Drawing.Size(33, 13);
            this.FrSkyALabel.TabIndex = 68;
            this.FrSkyALabel.Text = "A1(V)";
            // 
            // FrSkyLQ
            // 
            this.FrSkyLQ.Location = new System.Drawing.Point(26, 28);
            this.FrSkyLQ.Name = "FrSkyLQ";
            this.FrSkyLQ.ReadOnly = true;
            this.FrSkyLQ.Size = new System.Drawing.Size(32, 20);
            this.FrSkyLQ.TabIndex = 46;
            this.FrSkyLQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrSkyA2
            // 
            this.FrSkyA2.Location = new System.Drawing.Point(102, 28);
            this.FrSkyA2.Name = "FrSkyA2";
            this.FrSkyA2.ReadOnly = true;
            this.FrSkyA2.Size = new System.Drawing.Size(32, 20);
            this.FrSkyA2.TabIndex = 45;
            this.FrSkyA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrSkyA1
            // 
            this.FrSkyA1.Location = new System.Drawing.Point(64, 28);
            this.FrSkyA1.Name = "FrSkyA1";
            this.FrSkyA1.ReadOnly = true;
            this.FrSkyA1.Size = new System.Drawing.Size(32, 20);
            this.FrSkyA1.TabIndex = 44;
            this.FrSkyA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FlagsGroupBox
            // 
            this.FlagsGroupBox.Controls.Add(this.flowLayoutPanel1);
            this.FlagsGroupBox.Location = new System.Drawing.Point(587, 104);
            this.FlagsGroupBox.Name = "FlagsGroupBox";
            this.FlagsGroupBox.Size = new System.Drawing.Size(249, 361);
            this.FlagsGroupBox.TabIndex = 100;
            this.FlagsGroupBox.TabStop = false;
            this.FlagsGroupBox.Text = "Flags";
            // 
            // GPSStatBox
            // 
            this.GPSStatBox.Controls.Add(this.GPSNoOfSats);
            this.GPSStatBox.Controls.Add(this.GPSFixLabel);
            this.GPSStatBox.Controls.Add(this.GPSNoOfSatsLabel);
            this.GPSStatBox.Controls.Add(this.GPSFix);
            this.GPSStatBox.Controls.Add(this.GPShAcc);
            this.GPSStatBox.Controls.Add(this.hAccLabel);
            this.GPSStatBox.Location = new System.Drawing.Point(128, 444);
            this.GPSStatBox.Name = "GPSStatBox";
            this.GPSStatBox.Size = new System.Drawing.Size(93, 98);
            this.GPSStatBox.TabIndex = 101;
            this.GPSStatBox.TabStop = false;
            this.GPSStatBox.Text = "GPS Status";
            // 
            // AltitudeGroupBox
            // 
            this.AltitudeGroupBox.Controls.Add(this.label11);
            this.AltitudeGroupBox.Controls.Add(this.label4);
            this.AltitudeGroupBox.Controls.Add(this.BaroPressure);
            this.AltitudeGroupBox.Controls.Add(this.BaroTemperature);
            this.AltitudeGroupBox.Controls.Add(this.RangefinderAltitude);
            this.AltitudeGroupBox.Controls.Add(this.GPSAltitude);
            this.AltitudeGroupBox.Controls.Add(this.BaroAltitude);
            this.AltitudeGroupBox.Controls.Add(this.GPSAltLabel);
            this.AltitudeGroupBox.Controls.Add(this.BaroAltitudeLabel);
            this.AltitudeGroupBox.Controls.Add(this.RangefinderAltLabel);
            this.AltitudeGroupBox.Location = new System.Drawing.Point(12, 292);
            this.AltitudeGroupBox.Name = "AltitudeGroupBox";
            this.AltitudeGroupBox.Size = new System.Drawing.Size(160, 83);
            this.AltitudeGroupBox.TabIndex = 102;
            this.AltitudeGroupBox.TabStop = false;
            this.AltitudeGroupBox.Text = "Altitude";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "mBar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "C";
            // 
            // BaroPressure
            // 
            this.BaroPressure.Location = new System.Drawing.Point(102, 54);
            this.BaroPressure.Name = "BaroPressure";
            this.BaroPressure.ReadOnly = true;
            this.BaroPressure.Size = new System.Drawing.Size(51, 20);
            this.BaroPressure.TabIndex = 76;
            this.BaroPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BaroTemperature
            // 
            this.BaroTemperature.Location = new System.Drawing.Point(18, 54);
            this.BaroTemperature.Name = "BaroTemperature";
            this.BaroTemperature.ReadOnly = true;
            this.BaroTemperature.Size = new System.Drawing.Size(41, 20);
            this.BaroTemperature.TabIndex = 77;
            this.BaroTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WayHeadingLabel
            // 
            this.WayHeadingLabel.AutoSize = true;
            this.WayHeadingLabel.Location = new System.Drawing.Point(6, 161);
            this.WayHeadingLabel.Name = "WayHeadingLabel";
            this.WayHeadingLabel.Size = new System.Drawing.Size(72, 13);
            this.WayHeadingLabel.TabIndex = 64;
            this.WayHeadingLabel.Text = "Course (Deg.)";
            // 
            // GPSLongitudeLabel
            // 
            this.GPSLongitudeLabel.AutoSize = true;
            this.GPSLongitudeLabel.Location = new System.Drawing.Point(6, 293);
            this.GPSLongitudeLabel.Name = "GPSLongitudeLabel";
            this.GPSLongitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.GPSLongitudeLabel.TabIndex = 63;
            this.GPSLongitudeLabel.Text = "Longitude";
            // 
            // GPSLatitudeLabel
            // 
            this.GPSLatitudeLabel.AutoSize = true;
            this.GPSLatitudeLabel.Location = new System.Drawing.Point(6, 266);
            this.GPSLatitudeLabel.Name = "GPSLatitudeLabel";
            this.GPSLatitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.GPSLatitudeLabel.TabIndex = 61;
            this.GPSLatitudeLabel.Text = "Latitude";
            // 
            // NavStateLabel
            // 
            this.NavStateLabel.AutoSize = true;
            this.NavStateLabel.Location = new System.Drawing.Point(211, 33);
            this.NavStateLabel.Name = "NavStateLabel";
            this.NavStateLabel.Size = new System.Drawing.Size(27, 13);
            this.NavStateLabel.TabIndex = 72;
            this.NavStateLabel.Text = "Nav";
            // 
            // GPSVelLabel
            // 
            this.GPSVelLabel.AutoSize = true;
            this.GPSVelLabel.Location = new System.Drawing.Point(6, 135);
            this.GPSVelLabel.Name = "GPSVelLabel";
            this.GPSVelLabel.Size = new System.Drawing.Size(47, 13);
            this.GPSVelLabel.TabIndex = 60;
            this.GPSVelLabel.Text = "GPS Vel";
            // 
            // CurrWPLabel
            // 
            this.CurrWPLabel.AutoSize = true;
            this.CurrWPLabel.Location = new System.Drawing.Point(6, 76);
            this.CurrWPLabel.Name = "CurrWPLabel";
            this.CurrWPLabel.Size = new System.Drawing.Size(32, 13);
            this.CurrWPLabel.TabIndex = 73;
            this.CurrWPLabel.Text = "WP#";
            // 
            // GPSLatitude
            // 
            this.GPSLatitude.Location = new System.Drawing.Point(61, 264);
            this.GPSLatitude.Name = "GPSLatitude";
            this.GPSLatitude.ReadOnly = true;
            this.GPSLatitude.Size = new System.Drawing.Size(73, 20);
            this.GPSLatitude.TabIndex = 57;
            this.GPSLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSLongitude
            // 
            this.GPSLongitude.Location = new System.Drawing.Point(61, 290);
            this.GPSLongitude.Name = "GPSLongitude";
            this.GPSLongitude.ReadOnly = true;
            this.GPSLongitude.Size = new System.Drawing.Size(73, 20);
            this.GPSLongitude.TabIndex = 56;
            this.GPSLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavState
            // 
            this.NavState.Location = new System.Drawing.Point(244, 30);
            this.NavState.Name = "NavState";
            this.NavState.ReadOnly = true;
            this.NavState.Size = new System.Drawing.Size(73, 20);
            this.NavState.TabIndex = 52;
            this.NavState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrWP
            // 
            this.CurrWP.Location = new System.Drawing.Point(96, 71);
            this.CurrWP.Name = "CurrWP";
            this.CurrWP.ReadOnly = true;
            this.CurrWP.Size = new System.Drawing.Size(37, 20);
            this.CurrWP.TabIndex = 50;
            this.CurrWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WayHeading
            // 
            this.WayHeading.Location = new System.Drawing.Point(96, 156);
            this.WayHeading.Name = "WayHeading";
            this.WayHeading.ReadOnly = true;
            this.WayHeading.Size = new System.Drawing.Size(37, 20);
            this.WayHeading.TabIndex = 48;
            this.WayHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WPAltitude
            // 
            this.WPAltitude.AutoSize = true;
            this.WPAltitude.Location = new System.Drawing.Point(6, 237);
            this.WPAltitude.Name = "WPAltitude";
            this.WPAltitude.Size = new System.Drawing.Size(47, 13);
            this.WPAltitude.TabIndex = 77;
            this.WPAltitude.Text = "Alt. Error";
            // 
            // GPSVel
            // 
            this.GPSVel.Location = new System.Drawing.Point(96, 130);
            this.GPSVel.Name = "GPSVel";
            this.GPSVel.ReadOnly = true;
            this.GPSVel.Size = new System.Drawing.Size(37, 20);
            this.GPSVel.TabIndex = 45;
            this.GPSVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(6, 50);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(79, 13);
            this.HeadingLabel.TabIndex = 41;
            this.HeadingLabel.Text = "Heading (Deg.)";
            // 
            // AltitudeError
            // 
            this.AltitudeError.Location = new System.Drawing.Point(96, 234);
            this.AltitudeError.Name = "AltitudeError";
            this.AltitudeError.ReadOnly = true;
            this.AltitudeError.Size = new System.Drawing.Size(37, 20);
            this.AltitudeError.TabIndex = 76;
            this.AltitudeError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Heading
            // 
            this.Heading.Location = new System.Drawing.Point(96, 45);
            this.Heading.Name = "Heading";
            this.Heading.ReadOnly = true;
            this.Heading.Size = new System.Drawing.Size(37, 20);
            this.Heading.TabIndex = 7;
            this.Heading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WPDistanceLabel
            // 
            this.WPDistanceLabel.AutoSize = true;
            this.WPDistanceLabel.Location = new System.Drawing.Point(6, 211);
            this.WPDistanceLabel.Name = "WPDistanceLabel";
            this.WPDistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.WPDistanceLabel.TabIndex = 75;
            this.WPDistanceLabel.Text = "Distance";
            // 
            // DistanceToDesired
            // 
            this.DistanceToDesired.Location = new System.Drawing.Point(96, 208);
            this.DistanceToDesired.Name = "DistanceToDesired";
            this.DistanceToDesired.ReadOnly = true;
            this.DistanceToDesired.Size = new System.Drawing.Size(37, 20);
            this.DistanceToDesired.TabIndex = 74;
            this.DistanceToDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavGroupBox
            // 
            this.NavGroupBox.Controls.Add(this.CrossTrackErrorLabel);
            this.NavGroupBox.Controls.Add(this.CrossTrackError);
            this.NavGroupBox.Controls.Add(this.GPSHeadingLabel);
            this.NavGroupBox.Controls.Add(this.GPSHeading);
            this.NavGroupBox.Controls.Add(this.NavStateTimeoutLabel);
            this.NavGroupBox.Controls.Add(this.NavStateTimeout);
            this.NavGroupBox.Controls.Add(this.DistanceToDesired);
            this.NavGroupBox.Controls.Add(this.WayHeadingLabel);
            this.NavGroupBox.Controls.Add(this.WPDistanceLabel);
            this.NavGroupBox.Controls.Add(this.GPSLongitudeLabel);
            this.NavGroupBox.Controls.Add(this.GPSLatitudeLabel);
            this.NavGroupBox.Controls.Add(this.Heading);
            this.NavGroupBox.Controls.Add(this.GPSVelLabel);
            this.NavGroupBox.Controls.Add(this.AltitudeError);
            this.NavGroupBox.Controls.Add(this.CurrWPLabel);
            this.NavGroupBox.Controls.Add(this.GPSLatitude);
            this.NavGroupBox.Controls.Add(this.GPSLongitude);
            this.NavGroupBox.Controls.Add(this.CurrWP);
            this.NavGroupBox.Controls.Add(this.HeadingLabel);
            this.NavGroupBox.Controls.Add(this.GPSVel);
            this.NavGroupBox.Controls.Add(this.WayHeading);
            this.NavGroupBox.Controls.Add(this.WPAltitude);
            this.NavGroupBox.Location = new System.Drawing.Point(178, 57);
            this.NavGroupBox.Name = "NavGroupBox";
            this.NavGroupBox.Size = new System.Drawing.Size(139, 318);
            this.NavGroupBox.TabIndex = 91;
            this.NavGroupBox.TabStop = false;
            this.NavGroupBox.Text = "Nav";
            // 
            // CrossTrackErrorLabel
            // 
            this.CrossTrackErrorLabel.AutoSize = true;
            this.CrossTrackErrorLabel.Location = new System.Drawing.Point(6, 185);
            this.CrossTrackErrorLabel.Name = "CrossTrackErrorLabel";
            this.CrossTrackErrorLabel.Size = new System.Drawing.Size(64, 13);
            this.CrossTrackErrorLabel.TabIndex = 157;
            this.CrossTrackErrorLabel.Text = "Cross Track";
            // 
            // CrossTrackError
            // 
            this.CrossTrackError.Location = new System.Drawing.Point(96, 182);
            this.CrossTrackError.Name = "CrossTrackError";
            this.CrossTrackError.ReadOnly = true;
            this.CrossTrackError.Size = new System.Drawing.Size(37, 20);
            this.CrossTrackError.TabIndex = 156;
            this.CrossTrackError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GPSHeadingLabel
            // 
            this.GPSHeadingLabel.AutoSize = true;
            this.GPSHeadingLabel.Location = new System.Drawing.Point(6, 102);
            this.GPSHeadingLabel.Name = "GPSHeadingLabel";
            this.GPSHeadingLabel.Size = new System.Drawing.Size(61, 13);
            this.GPSHeadingLabel.TabIndex = 155;
            this.GPSHeadingLabel.Text = "GPS (Deg.)";
            // 
            // GPSHeading
            // 
            this.GPSHeading.Location = new System.Drawing.Point(96, 97);
            this.GPSHeading.Name = "GPSHeading";
            this.GPSHeading.ReadOnly = true;
            this.GPSHeading.Size = new System.Drawing.Size(37, 20);
            this.GPSHeading.TabIndex = 154;
            this.GPSHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavStateTimeoutLabel
            // 
            this.NavStateTimeoutLabel.AutoSize = true;
            this.NavStateTimeoutLabel.Location = new System.Drawing.Point(6, 23);
            this.NavStateTimeoutLabel.Name = "NavStateTimeoutLabel";
            this.NavStateTimeoutLabel.Size = new System.Drawing.Size(60, 13);
            this.NavStateTimeoutLabel.TabIndex = 153;
            this.NavStateTimeoutLabel.Text = "Delay Time";
            // 
            // NavStateTimeout
            // 
            this.NavStateTimeout.Location = new System.Drawing.Point(96, 19);
            this.NavStateTimeout.Name = "NavStateTimeout";
            this.NavStateTimeout.ReadOnly = true;
            this.NavStateTimeout.Size = new System.Drawing.Size(37, 20);
            this.NavStateTimeout.TabIndex = 153;
            this.NavStateTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CurrentAltitude
            // 
            this.CurrentAltitude.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentAltitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAltitude.Location = new System.Drawing.Point(378, 57);
            this.CurrentAltitude.Name = "CurrentAltitude";
            this.CurrentAltitude.Size = new System.Drawing.Size(141, 46);
            this.CurrentAltitude.TabIndex = 103;
            this.CurrentAltitude.Text = "-1";
            this.CurrentAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(352, 380);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(200, 13);
            this.MainLabel.TabIndex = 104;
            this.MainLabel.Text = "UAVX Groundstation (C) G.K. Egan 2010";
            // 
            // AltitudeSource
            // 
            this.AltitudeSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AltitudeSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltitudeSource.Location = new System.Drawing.Point(389, 47);
            this.AltitudeSource.Name = "AltitudeSource";
            this.AltitudeSource.ReadOnly = true;
            this.AltitudeSource.Size = new System.Drawing.Size(121, 13);
            this.AltitudeSource.TabIndex = 107;
            this.AltitudeSource.Text = "Barometer";
            this.AltitudeSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationBox
            // 
            this.LocationBox.Controls.Add(this.WhereDistance);
            this.LocationBox.Controls.Add(this.WhereBearing);
            this.LocationBox.Controls.Add(this.WhereBearingLabel);
            this.LocationBox.Controls.Add(this.WhereDistanceLabel);
            this.LocationBox.Location = new System.Drawing.Point(718, 33);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(118, 69);
            this.LocationBox.TabIndex = 152;
            this.LocationBox.TabStop = false;
            this.LocationBox.Text = "Where?";
            // 
            // WhereDistance
            // 
            this.WhereDistance.Location = new System.Drawing.Point(73, 40);
            this.WhereDistance.Name = "WhereDistance";
            this.WhereDistance.ReadOnly = true;
            this.WhereDistance.Size = new System.Drawing.Size(39, 20);
            this.WhereDistance.TabIndex = 165;
            this.WhereDistance.Text = "0";
            this.WhereDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WhereBearing
            // 
            this.WhereBearing.Location = new System.Drawing.Point(73, 14);
            this.WhereBearing.Name = "WhereBearing";
            this.WhereBearing.ReadOnly = true;
            this.WhereBearing.Size = new System.Drawing.Size(39, 20);
            this.WhereBearing.TabIndex = 164;
            this.WhereBearing.Text = "0";
            this.WhereBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WhereBearingLabel
            // 
            this.WhereBearingLabel.AutoSize = true;
            this.WhereBearingLabel.Location = new System.Drawing.Point(6, 17);
            this.WhereBearingLabel.Name = "WhereBearingLabel";
            this.WhereBearingLabel.Size = new System.Drawing.Size(43, 13);
            this.WhereBearingLabel.TabIndex = 54;
            this.WhereBearingLabel.Text = "Bearing";
            // 
            // WhereDistanceLabel
            // 
            this.WhereDistanceLabel.AutoSize = true;
            this.WhereDistanceLabel.Location = new System.Drawing.Point(6, 43);
            this.WhereDistanceLabel.Name = "WhereDistanceLabel";
            this.WhereDistanceLabel.Size = new System.Drawing.Size(49, 13);
            this.WhereDistanceLabel.TabIndex = 53;
            this.WhereDistanceLabel.Text = "Distance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BattFFLabel);
            this.groupBox1.Controls.Add(this.BattFFComp);
            this.groupBox1.Controls.Add(this.CruiseThrottleLabel);
            this.groupBox1.Controls.Add(this.CruiseThrottle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AltComp);
            this.groupBox1.Controls.Add(this.TiltFFComp);
            this.groupBox1.Controls.Add(this.TiltFFCompLabel);
            this.groupBox1.Controls.Add(this.AltCompLabel);
            this.groupBox1.Location = new System.Drawing.Point(164, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 57);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compensation";
            // 
            // BattFFLabel
            // 
            this.BattFFLabel.AutoSize = true;
            this.BattFFLabel.Location = new System.Drawing.Point(43, 13);
            this.BattFFLabel.Name = "BattFFLabel";
            this.BattFFLabel.Size = new System.Drawing.Size(28, 13);
            this.BattFFLabel.TabIndex = 220;
            this.BattFFLabel.Text = "xBat";
            // 
            // BattFFComp
            // 
            this.BattFFComp.Location = new System.Drawing.Point(42, 31);
            this.BattFFComp.Name = "BattFFComp";
            this.BattFFComp.ReadOnly = true;
            this.BattFFComp.Size = new System.Drawing.Size(30, 20);
            this.BattFFComp.TabIndex = 78;
            this.BattFFComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CruiseThrottleLabel
            // 
            this.CruiseThrottleLabel.AutoSize = true;
            this.CruiseThrottleLabel.Location = new System.Drawing.Point(110, 13);
            this.CruiseThrottleLabel.Name = "CruiseThrottleLabel";
            this.CruiseThrottleLabel.Size = new System.Drawing.Size(43, 13);
            this.CruiseThrottleLabel.TabIndex = 77;
            this.CruiseThrottleLabel.Text = "Hold(%)";
            // 
            // CruiseThrottle
            // 
            this.CruiseThrottle.Location = new System.Drawing.Point(114, 31);
            this.CruiseThrottle.Name = "CruiseThrottle";
            this.CruiseThrottle.ReadOnly = true;
            this.CruiseThrottle.Size = new System.Drawing.Size(30, 20);
            this.CruiseThrottle.TabIndex = 76;
            this.CruiseThrottle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 62;
            // 
            // AltComp
            // 
            this.AltComp.Location = new System.Drawing.Point(78, 31);
            this.AltComp.Name = "AltComp";
            this.AltComp.ReadOnly = true;
            this.AltComp.Size = new System.Drawing.Size(30, 20);
            this.AltComp.TabIndex = 43;
            this.AltComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TiltFFComp
            // 
            this.TiltFFComp.Location = new System.Drawing.Point(6, 31);
            this.TiltFFComp.Name = "TiltFFComp";
            this.TiltFFComp.ReadOnly = true;
            this.TiltFFComp.Size = new System.Drawing.Size(30, 20);
            this.TiltFFComp.TabIndex = 46;
            this.TiltFFComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TiltFFCompLabel
            // 
            this.TiltFFCompLabel.AutoSize = true;
            this.TiltFFCompLabel.Location = new System.Drawing.Point(10, 13);
            this.TiltFFCompLabel.Name = "TiltFFCompLabel";
            this.TiltFFCompLabel.Size = new System.Drawing.Size(26, 13);
            this.TiltFFCompLabel.TabIndex = 75;
            this.TiltFFCompLabel.Text = "xTilt";
            // 
            // AltCompLabel
            // 
            this.AltCompLabel.AutoSize = true;
            this.AltCompLabel.Location = new System.Drawing.Point(77, 13);
            this.AltCompLabel.Name = "AltCompLabel";
            this.AltCompLabel.Size = new System.Drawing.Size(36, 13);
            this.AltCompLabel.TabIndex = 67;
            this.AltCompLabel.Text = "Alt (%)";
            // 
            // EmulationTextBox
            // 
            this.EmulationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmulationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmulationTextBox.Location = new System.Drawing.Point(389, 28);
            this.EmulationTextBox.Name = "EmulationTextBox";
            this.EmulationTextBox.ReadOnly = true;
            this.EmulationTextBox.Size = new System.Drawing.Size(121, 13);
            this.EmulationTextBox.TabIndex = 154;
            this.EmulationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaroStatsGroupBox
            // 
            this.BaroStatsGroupBox.Controls.Add(this.MaxTempS);
            this.BaroStatsGroupBox.Controls.Add(this.TempSLabel);
            this.BaroStatsGroupBox.Controls.Add(this.MinTempS);
            this.BaroStatsGroupBox.Controls.Add(this.label2);
            this.BaroStatsGroupBox.Controls.Add(this.BaroMaxROCS);
            this.BaroStatsGroupBox.Controls.Add(this.RelBaroAltitudeLabel);
            this.BaroStatsGroupBox.Controls.Add(this.BaroRelAltitudeS);
            this.BaroStatsGroupBox.Controls.Add(this.BaroMinROCS);
            this.BaroStatsGroupBox.Controls.Add(this.GPSStatsGroupBox);
            this.BaroStatsGroupBox.Location = new System.Drawing.Point(41, 29);
            this.BaroStatsGroupBox.Name = "BaroStatsGroupBox";
            this.BaroStatsGroupBox.Size = new System.Drawing.Size(121, 78);
            this.BaroStatsGroupBox.TabIndex = 159;
            this.BaroStatsGroupBox.TabStop = false;
            this.BaroStatsGroupBox.Text = "Baro Stats";
            this.BaroStatsGroupBox.Visible = false;
            // 
            // MaxTempS
            // 
            this.MaxTempS.Location = new System.Drawing.Point(83, 56);
            this.MaxTempS.Name = "MaxTempS";
            this.MaxTempS.Size = new System.Drawing.Size(31, 13);
            this.MaxTempS.TabIndex = 70;
            this.MaxTempS.Text = "0";
            this.MaxTempS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TempSLabel
            // 
            this.TempSLabel.AutoSize = true;
            this.TempSLabel.Location = new System.Drawing.Point(7, 56);
            this.TempSLabel.Name = "TempSLabel";
            this.TempSLabel.Size = new System.Drawing.Size(37, 13);
            this.TempSLabel.TabIndex = 69;
            this.TempSLabel.Text = "Temp:";
            // 
            // MinTempS
            // 
            this.MinTempS.Location = new System.Drawing.Point(49, 56);
            this.MinTempS.Name = "MinTempS";
            this.MinTempS.Size = new System.Drawing.Size(31, 13);
            this.MinTempS.TabIndex = 68;
            this.MinTempS.Text = "0";
            this.MinTempS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "ROC:";
            // 
            // BaroMaxROCS
            // 
            this.BaroMaxROCS.Location = new System.Drawing.Point(86, 36);
            this.BaroMaxROCS.Name = "BaroMaxROCS";
            this.BaroMaxROCS.Size = new System.Drawing.Size(29, 13);
            this.BaroMaxROCS.TabIndex = 52;
            this.BaroMaxROCS.Text = "0";
            this.BaroMaxROCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RelBaroAltitudeLabel
            // 
            this.RelBaroAltitudeLabel.AutoSize = true;
            this.RelBaroAltitudeLabel.Location = new System.Drawing.Point(7, 16);
            this.RelBaroAltitudeLabel.Name = "RelBaroAltitudeLabel";
            this.RelBaroAltitudeLabel.Size = new System.Drawing.Size(22, 13);
            this.RelBaroAltitudeLabel.TabIndex = 49;
            this.RelBaroAltitudeLabel.Text = "Alt:";
            // 
            // BaroRelAltitudeS
            // 
            this.BaroRelAltitudeS.Location = new System.Drawing.Point(46, 16);
            this.BaroRelAltitudeS.Name = "BaroRelAltitudeS";
            this.BaroRelAltitudeS.Size = new System.Drawing.Size(34, 13);
            this.BaroRelAltitudeS.TabIndex = 48;
            this.BaroRelAltitudeS.Text = "0";
            this.BaroRelAltitudeS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaroMinROCS
            // 
            this.BaroMinROCS.Location = new System.Drawing.Point(38, 36);
            this.BaroMinROCS.Name = "BaroMinROCS";
            this.BaroMinROCS.Size = new System.Drawing.Size(42, 13);
            this.BaroMinROCS.TabIndex = 51;
            this.BaroMinROCS.Text = "0";
            this.BaroMinROCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSStatsGroupBox
            // 
            this.GPSStatsGroupBox.Controls.Add(this.label9);
            this.GPSStatsGroupBox.Controls.Add(this.GPSMaxhAccS);
            this.GPSStatsGroupBox.Controls.Add(this.GPSMinhAccS);
            this.GPSStatsGroupBox.Controls.Add(this.GPSAltitudeLabel);
            this.GPSStatsGroupBox.Controls.Add(this.label10);
            this.GPSStatsGroupBox.Controls.Add(this.GPSMaxVelS);
            this.GPSStatsGroupBox.Controls.Add(this.GPSAltitudeS);
            this.GPSStatsGroupBox.Controls.Add(this.SatsLabel);
            this.GPSStatsGroupBox.Controls.Add(this.GPSMinSatS);
            this.GPSStatsGroupBox.Controls.Add(this.GPSMaxSatS);
            this.GPSStatsGroupBox.Location = new System.Drawing.Point(6, 9);
            this.GPSStatsGroupBox.Name = "GPSStatsGroupBox";
            this.GPSStatsGroupBox.Size = new System.Drawing.Size(129, 79);
            this.GPSStatsGroupBox.TabIndex = 157;
            this.GPSStatsGroupBox.TabStop = false;
            this.GPSStatsGroupBox.Text = "GPS Stats";
            this.GPSStatsGroupBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "hAcc";
            // 
            // GPSMaxhAccS
            // 
            this.GPSMaxhAccS.Location = new System.Drawing.Point(86, 57);
            this.GPSMaxhAccS.Name = "GPSMaxhAccS";
            this.GPSMaxhAccS.Size = new System.Drawing.Size(37, 15);
            this.GPSMaxhAccS.TabIndex = 61;
            this.GPSMaxhAccS.Text = "0";
            this.GPSMaxhAccS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSMinhAccS
            // 
            this.GPSMinhAccS.Location = new System.Drawing.Point(51, 57);
            this.GPSMinhAccS.Name = "GPSMinhAccS";
            this.GPSMinhAccS.Size = new System.Drawing.Size(33, 14);
            this.GPSMinhAccS.TabIndex = 62;
            this.GPSMinhAccS.Text = "0";
            this.GPSMinhAccS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSAltitudeLabel
            // 
            this.GPSAltitudeLabel.AutoSize = true;
            this.GPSAltitudeLabel.Location = new System.Drawing.Point(6, 16);
            this.GPSAltitudeLabel.Name = "GPSAltitudeLabel";
            this.GPSAltitudeLabel.Size = new System.Drawing.Size(22, 13);
            this.GPSAltitudeLabel.TabIndex = 50;
            this.GPSAltitudeLabel.Text = "Alt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Vel.:";
            // 
            // GPSMaxVelS
            // 
            this.GPSMaxVelS.Location = new System.Drawing.Point(89, 16);
            this.GPSMaxVelS.Name = "GPSMaxVelS";
            this.GPSMaxVelS.Size = new System.Drawing.Size(35, 13);
            this.GPSMaxVelS.TabIndex = 48;
            this.GPSMaxVelS.Text = "0";
            this.GPSMaxVelS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSAltitudeS
            // 
            this.GPSAltitudeS.Location = new System.Drawing.Point(30, 16);
            this.GPSAltitudeS.Name = "GPSAltitudeS";
            this.GPSAltitudeS.Size = new System.Drawing.Size(29, 13);
            this.GPSAltitudeS.TabIndex = 47;
            this.GPSAltitudeS.Text = "0";
            this.GPSAltitudeS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SatsLabel
            // 
            this.SatsLabel.AutoSize = true;
            this.SatsLabel.Location = new System.Drawing.Point(6, 37);
            this.SatsLabel.Name = "SatsLabel";
            this.SatsLabel.Size = new System.Drawing.Size(34, 13);
            this.SatsLabel.TabIndex = 57;
            this.SatsLabel.Text = "Sats.:";
            // 
            // GPSMinSatS
            // 
            this.GPSMinSatS.Location = new System.Drawing.Point(51, 37);
            this.GPSMinSatS.Name = "GPSMinSatS";
            this.GPSMinSatS.Size = new System.Drawing.Size(33, 13);
            this.GPSMinSatS.TabIndex = 56;
            this.GPSMinSatS.Text = "0";
            this.GPSMinSatS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSMaxSatS
            // 
            this.GPSMaxSatS.Location = new System.Drawing.Point(86, 36);
            this.GPSMaxSatS.Name = "GPSMaxSatS";
            this.GPSMaxSatS.Size = new System.Drawing.Size(38, 14);
            this.GPSMaxSatS.TabIndex = 55;
            this.GPSMaxSatS.Text = "0";
            this.GPSMaxSatS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ErrorStatsGroupBox
            // 
            this.ErrorStatsGroupBox.Controls.Add(this.ErrNoS);
            this.ErrorStatsGroupBox.Controls.Add(this.ErrNoSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.RawCheckBox);
            this.ErrorStatsGroupBox.Controls.Add(this.RCGlitches);
            this.ErrorStatsGroupBox.Controls.Add(this.BadS);
            this.ErrorStatsGroupBox.Controls.Add(this.RCGlitchesLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.BadSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.FailsafeSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.GyroSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.RCFailSafeS);
            this.ErrorStatsGroupBox.Controls.Add(this.I2CESCFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.GPSInvalidSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.GPSFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.ESCSLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.GyroFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.AccFailLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.AccFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.I2CSIOFailLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.CompassFailLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.I2CSIOFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.CompassFailS);
            this.ErrorStatsGroupBox.Controls.Add(this.BaroFailLabel);
            this.ErrorStatsGroupBox.Controls.Add(this.BaroFailS);
            this.ErrorStatsGroupBox.Location = new System.Drawing.Point(12, 548);
            this.ErrorStatsGroupBox.Name = "ErrorStatsGroupBox";
            this.ErrorStatsGroupBox.Size = new System.Drawing.Size(307, 80);
            this.ErrorStatsGroupBox.TabIndex = 158;
            this.ErrorStatsGroupBox.TabStop = false;
            this.ErrorStatsGroupBox.Text = "Error Stats";
            // 
            // ErrNoS
            // 
            this.ErrNoS.Location = new System.Drawing.Point(269, 36);
            this.ErrNoS.Name = "ErrNoS";
            this.ErrNoS.Size = new System.Drawing.Size(32, 13);
            this.ErrNoS.TabIndex = 171;
            this.ErrNoS.Text = "0";
            this.ErrNoS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ErrNoSLabel
            // 
            this.ErrNoSLabel.AutoSize = true;
            this.ErrNoSLabel.Location = new System.Drawing.Point(235, 36);
            this.ErrNoSLabel.Name = "ErrNoSLabel";
            this.ErrNoSLabel.Size = new System.Drawing.Size(33, 13);
            this.ErrNoSLabel.TabIndex = 170;
            this.ErrNoSLabel.Text = "ERR:";
            // 
            // RawCheckBox
            // 
            this.RawCheckBox.AutoSize = true;
            this.RawCheckBox.Location = new System.Drawing.Point(286, 55);
            this.RawCheckBox.Name = "RawCheckBox";
            this.RawCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RawCheckBox.TabIndex = 169;
            this.RawCheckBox.UseVisualStyleBackColor = true;
            // 
            // BadS
            // 
            this.BadS.Location = new System.Drawing.Point(269, 15);
            this.BadS.Name = "BadS";
            this.BadS.Size = new System.Drawing.Size(32, 13);
            this.BadS.TabIndex = 77;
            this.BadS.Text = "0";
            this.BadS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BadSLabel
            // 
            this.BadSLabel.AutoSize = true;
            this.BadSLabel.Location = new System.Drawing.Point(235, 15);
            this.BadSLabel.Name = "BadSLabel";
            this.BadSLabel.Size = new System.Drawing.Size(32, 13);
            this.BadSLabel.TabIndex = 76;
            this.BadSLabel.Text = "GKE:";
            // 
            // FailsafeSLabel
            // 
            this.FailsafeSLabel.AutoSize = true;
            this.FailsafeSLabel.Location = new System.Drawing.Point(153, 35);
            this.FailsafeSLabel.Name = "FailsafeSLabel";
            this.FailsafeSLabel.Size = new System.Drawing.Size(38, 13);
            this.FailsafeSLabel.TabIndex = 75;
            this.FailsafeSLabel.Text = "FSafe:";
            // 
            // GyroSLabel
            // 
            this.GyroSLabel.AutoSize = true;
            this.GyroSLabel.Location = new System.Drawing.Point(75, 15);
            this.GyroSLabel.Name = "GyroSLabel";
            this.GyroSLabel.Size = new System.Drawing.Size(35, 13);
            this.GyroSLabel.TabIndex = 69;
            this.GyroSLabel.Text = "Gyro.:";
            // 
            // RCFailSafeS
            // 
            this.RCFailSafeS.Location = new System.Drawing.Point(194, 35);
            this.RCFailSafeS.Name = "RCFailSafeS";
            this.RCFailSafeS.Size = new System.Drawing.Size(35, 13);
            this.RCFailSafeS.TabIndex = 74;
            this.RCFailSafeS.Text = "0";
            this.RCFailSafeS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // I2CESCFailS
            // 
            this.I2CESCFailS.Location = new System.Drawing.Point(187, 14);
            this.I2CESCFailS.Name = "I2CESCFailS";
            this.I2CESCFailS.Size = new System.Drawing.Size(42, 14);
            this.I2CESCFailS.TabIndex = 65;
            this.I2CESCFailS.Text = "0";
            this.I2CESCFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPSInvalidSLabel
            // 
            this.GPSInvalidSLabel.AutoSize = true;
            this.GPSInvalidSLabel.Location = new System.Drawing.Point(6, 35);
            this.GPSInvalidSLabel.Name = "GPSInvalidSLabel";
            this.GPSInvalidSLabel.Size = new System.Drawing.Size(32, 13);
            this.GPSInvalidSLabel.TabIndex = 67;
            this.GPSInvalidSLabel.Text = "GPS:";
            // 
            // GPSFailS
            // 
            this.GPSFailS.Location = new System.Drawing.Point(37, 35);
            this.GPSFailS.Name = "GPSFailS";
            this.GPSFailS.Size = new System.Drawing.Size(32, 13);
            this.GPSFailS.TabIndex = 66;
            this.GPSFailS.Text = "0";
            this.GPSFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ESCSLabel
            // 
            this.ESCSLabel.AutoSize = true;
            this.ESCSLabel.Location = new System.Drawing.Point(153, 15);
            this.ESCSLabel.Name = "ESCSLabel";
            this.ESCSLabel.Size = new System.Drawing.Size(31, 13);
            this.ESCSLabel.TabIndex = 52;
            this.ESCSLabel.Text = "ESC:";
            // 
            // GyroFailS
            // 
            this.GyroFailS.Location = new System.Drawing.Point(112, 16);
            this.GyroFailS.Name = "GyroFailS";
            this.GyroFailS.Size = new System.Drawing.Size(35, 13);
            this.GyroFailS.TabIndex = 68;
            this.GyroFailS.Text = "0";
            this.GyroFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccFailLabel
            // 
            this.AccFailLabel.AutoSize = true;
            this.AccFailLabel.Location = new System.Drawing.Point(6, 55);
            this.AccFailLabel.Name = "AccFailLabel";
            this.AccFailLabel.Size = new System.Drawing.Size(32, 13);
            this.AccFailLabel.TabIndex = 60;
            this.AccFailLabel.Text = "Acc.:";
            // 
            // AccFailS
            // 
            this.AccFailS.Location = new System.Drawing.Point(37, 55);
            this.AccFailS.Name = "AccFailS";
            this.AccFailS.Size = new System.Drawing.Size(32, 13);
            this.AccFailS.TabIndex = 51;
            this.AccFailS.Text = "0";
            this.AccFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // I2CSIOFailLabel
            // 
            this.I2CSIOFailLabel.AutoSize = true;
            this.I2CSIOFailLabel.Location = new System.Drawing.Point(6, 15);
            this.I2CSIOFailLabel.Name = "I2CSIOFailLabel";
            this.I2CSIOFailLabel.Size = new System.Drawing.Size(28, 13);
            this.I2CSIOFailLabel.TabIndex = 71;
            this.I2CSIOFailLabel.Text = "SIO:";
            // 
            // CompassFailLabel
            // 
            this.CompassFailLabel.AutoSize = true;
            this.CompassFailLabel.Location = new System.Drawing.Point(75, 36);
            this.CompassFailLabel.Name = "CompassFailLabel";
            this.CompassFailLabel.Size = new System.Drawing.Size(40, 13);
            this.CompassFailLabel.TabIndex = 60;
            this.CompassFailLabel.Text = "Comp.:";
            // 
            // I2CSIOFailS
            // 
            this.I2CSIOFailS.Location = new System.Drawing.Point(40, 15);
            this.I2CSIOFailS.Name = "I2CSIOFailS";
            this.I2CSIOFailS.Size = new System.Drawing.Size(29, 13);
            this.I2CSIOFailS.TabIndex = 70;
            this.I2CSIOFailS.Text = "0";
            this.I2CSIOFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompassFailS
            // 
            this.CompassFailS.BackColor = System.Drawing.SystemColors.Control;
            this.CompassFailS.Location = new System.Drawing.Point(121, 36);
            this.CompassFailS.Name = "CompassFailS";
            this.CompassFailS.Size = new System.Drawing.Size(26, 13);
            this.CompassFailS.TabIndex = 59;
            this.CompassFailS.Text = "0";
            this.CompassFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaroFailLabel
            // 
            this.BaroFailLabel.AutoSize = true;
            this.BaroFailLabel.Location = new System.Drawing.Point(75, 55);
            this.BaroFailLabel.Name = "BaroFailLabel";
            this.BaroFailLabel.Size = new System.Drawing.Size(35, 13);
            this.BaroFailLabel.TabIndex = 58;
            this.BaroFailLabel.Text = "Baro.:";
            // 
            // BaroFailS
            // 
            this.BaroFailS.Location = new System.Drawing.Point(118, 56);
            this.BaroFailS.Name = "BaroFailS";
            this.BaroFailS.Size = new System.Drawing.Size(29, 13);
            this.BaroFailS.TabIndex = 55;
            this.BaroFailS.Text = "0";
            this.BaroFailS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OpenLogFileDialog
            // 
            this.OpenLogFileDialog.FileName = "UAVX.log";
            // 
            // COMSelectComboBox
            // 
            this.COMSelectComboBox.Name = "COMSelectComboBox";
            this.COMSelectComboBox.Size = new System.Drawing.Size(75, 21);
            this.COMSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.COMSelectComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COMSelectComboBox,
            this.COMBaudRateComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 25);
            this.menuStrip1.TabIndex = 153;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // COMBaudRateComboBox
            // 
            this.COMBaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.COMBaudRateComboBox.Name = "COMBaudRateComboBox";
            this.COMBaudRateComboBox.Size = new System.Drawing.Size(75, 21);
            this.COMBaudRateComboBox.Text = "115200";
            this.COMBaudRateComboBox.SelectedIndexChanged += new System.EventHandler(this.COMBaudRateComboBox_SelectedIndexChanged);
            // 
            // ReplayButton
            // 
            this.ReplayButton.Location = new System.Drawing.Point(712, 0);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(75, 23);
            this.ReplayButton.TabIndex = 164;
            this.ReplayButton.Text = "Replay";
            this.ReplayButton.UseVisualStyleBackColor = true;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButton_Click);
            // 
            // ReplayProgressBar
            // 
            this.ReplayProgressBar.Location = new System.Drawing.Point(792, 0);
            this.ReplayProgressBar.Name = "ReplayProgressBar";
            this.ReplayProgressBar.Size = new System.Drawing.Size(160, 23);
            this.ReplayProgressBar.TabIndex = 165;
            // 
            // Airframe
            // 
            this.Airframe.BackColor = System.Drawing.SystemColors.Control;
            this.Airframe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Airframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airframe.Location = new System.Drawing.Point(596, 82);
            this.Airframe.Name = "Airframe";
            this.Airframe.Size = new System.Drawing.Size(116, 13);
            this.Airframe.TabIndex = 166;
            this.Airframe.Text = "Quadrocopter";
            // 
            // ReplayNumericUpDown
            // 
            this.ReplayNumericUpDown.Location = new System.Drawing.Point(958, 2);
            this.ReplayNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ReplayNumericUpDown.Name = "ReplayNumericUpDown";
            this.ReplayNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.ReplayNumericUpDown.TabIndex = 167;
            this.ReplayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReplayNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ReplayNumericUpDown.ValueChanged += new System.EventHandler(this.ReplayNumericUpDown_Changed);
            // 
            // NavCompBox
            // 
            this.NavCompBox.Controls.Add(this.NavSensitivity);
            this.NavCompBox.Controls.Add(this.NavSensitivityLabel);
            this.NavCompBox.Controls.Add(this.label5);
            this.NavCompBox.Controls.Add(this.NavYCorr);
            this.NavCompBox.Controls.Add(this.NavRCorr);
            this.NavCompBox.Controls.Add(this.NavPCorr);
            this.NavCompBox.Controls.Add(this.label6);
            this.NavCompBox.Controls.Add(this.label7);
            this.NavCompBox.Controls.Add(this.label8);
            this.NavCompBox.Location = new System.Drawing.Point(12, 381);
            this.NavCompBox.Name = "NavCompBox";
            this.NavCompBox.Size = new System.Drawing.Size(146, 57);
            this.NavCompBox.TabIndex = 104;
            this.NavCompBox.TabStop = false;
            this.NavCompBox.Text = "Nav";
            // 
            // NavSensitivity
            // 
            this.NavSensitivity.Location = new System.Drawing.Point(6, 29);
            this.NavSensitivity.Name = "NavSensitivity";
            this.NavSensitivity.ReadOnly = true;
            this.NavSensitivity.Size = new System.Drawing.Size(25, 20);
            this.NavSensitivity.TabIndex = 59;
            this.NavSensitivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavSensitivityLabel
            // 
            this.NavSensitivityLabel.AutoSize = true;
            this.NavSensitivityLabel.Location = new System.Drawing.Point(9, 13);
            this.NavSensitivityLabel.Name = "NavSensitivityLabel";
            this.NavSensitivityLabel.Size = new System.Drawing.Size(34, 13);
            this.NavSensitivityLabel.TabIndex = 65;
            this.NavSensitivityLabel.Text = "Sens.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 62;
            // 
            // NavYCorr
            // 
            this.NavYCorr.Location = new System.Drawing.Point(109, 29);
            this.NavYCorr.Name = "NavYCorr";
            this.NavYCorr.ReadOnly = true;
            this.NavYCorr.Size = new System.Drawing.Size(30, 20);
            this.NavYCorr.TabIndex = 43;
            this.NavYCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavRCorr
            // 
            this.NavRCorr.Location = new System.Drawing.Point(37, 29);
            this.NavRCorr.Name = "NavRCorr";
            this.NavRCorr.ReadOnly = true;
            this.NavRCorr.Size = new System.Drawing.Size(30, 20);
            this.NavRCorr.TabIndex = 58;
            this.NavRCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NavPCorr
            // 
            this.NavPCorr.Location = new System.Drawing.Point(73, 29);
            this.NavPCorr.Name = "NavPCorr";
            this.NavPCorr.ReadOnly = true;
            this.NavPCorr.Size = new System.Drawing.Size(30, 20);
            this.NavPCorr.TabIndex = 46;
            this.NavPCorr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Roll";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Pitch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Yaw";
            // 
            // SpeechGroupBox
            // 
            this.SpeechGroupBox.Controls.Add(this.SpeakVarioCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakIntervalLabel);
            this.SpeechGroupBox.Controls.Add(this.SpeakIntervalNumericUpDown);
            this.SpeechGroupBox.Controls.Add(this.SpeechEnableCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakNavCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakAltitudeCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakWhereCheckBox);
            this.SpeechGroupBox.Controls.Add(this.SpeakVoltsCheckBox);
            this.SpeechGroupBox.Location = new System.Drawing.Point(842, 527);
            this.SpeechGroupBox.Name = "SpeechGroupBox";
            this.SpeechGroupBox.Size = new System.Drawing.Size(162, 101);
            this.SpeechGroupBox.TabIndex = 183;
            this.SpeechGroupBox.TabStop = false;
            this.SpeechGroupBox.Text = "Speech";
            // 
            // SpeakVarioCheckBox
            // 
            this.SpeakVarioCheckBox.AutoSize = true;
            this.SpeakVarioCheckBox.Location = new System.Drawing.Point(86, 33);
            this.SpeakVarioCheckBox.Name = "SpeakVarioCheckBox";
            this.SpeakVarioCheckBox.Size = new System.Drawing.Size(50, 17);
            this.SpeakVarioCheckBox.TabIndex = 190;
            this.SpeakVarioCheckBox.Text = "Vario";
            this.SpeakVarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakIntervalLabel
            // 
            this.SpeakIntervalLabel.AutoSize = true;
            this.SpeakIntervalLabel.Location = new System.Drawing.Point(6, 17);
            this.SpeakIntervalLabel.Name = "SpeakIntervalLabel";
            this.SpeakIntervalLabel.Size = new System.Drawing.Size(42, 13);
            this.SpeakIntervalLabel.TabIndex = 189;
            this.SpeakIntervalLabel.Text = "Interval";
            // 
            // SpeakIntervalNumericUpDown
            // 
            this.SpeakIntervalNumericUpDown.Location = new System.Drawing.Point(86, 10);
            this.SpeakIntervalNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Name = "SpeakIntervalNumericUpDown";
            this.SpeakIntervalNumericUpDown.ReadOnly = true;
            this.SpeakIntervalNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.SpeakIntervalNumericUpDown.TabIndex = 188;
            this.SpeakIntervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeakIntervalNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SpeakIntervalNumericUpDown.Click += new System.EventHandler(this.SpeakIntervalNumericUpDown_Click);
            // 
            // SpeechEnableCheckBox
            // 
            this.SpeechEnableCheckBox.AutoSize = true;
            this.SpeechEnableCheckBox.Checked = true;
            this.SpeechEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeechEnableCheckBox.Location = new System.Drawing.Point(11, 33);
            this.SpeechEnableCheckBox.Name = "SpeechEnableCheckBox";
            this.SpeechEnableCheckBox.Size = new System.Drawing.Size(59, 17);
            this.SpeechEnableCheckBox.TabIndex = 181;
            this.SpeechEnableCheckBox.Text = "Enable";
            this.SpeechEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakNavCheckBox
            // 
            this.SpeakNavCheckBox.AutoSize = true;
            this.SpeakNavCheckBox.Checked = true;
            this.SpeakNavCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeakNavCheckBox.Location = new System.Drawing.Point(11, 53);
            this.SpeakNavCheckBox.Name = "SpeakNavCheckBox";
            this.SpeakNavCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SpeakNavCheckBox.TabIndex = 187;
            this.SpeakNavCheckBox.Text = "Nav.";
            this.SpeakNavCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakAltitudeCheckBox
            // 
            this.SpeakAltitudeCheckBox.AutoSize = true;
            this.SpeakAltitudeCheckBox.Location = new System.Drawing.Point(86, 52);
            this.SpeakAltitudeCheckBox.Name = "SpeakAltitudeCheckBox";
            this.SpeakAltitudeCheckBox.Size = new System.Drawing.Size(41, 17);
            this.SpeakAltitudeCheckBox.TabIndex = 184;
            this.SpeakAltitudeCheckBox.Text = "Alt.";
            this.SpeakAltitudeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakWhereCheckBox
            // 
            this.SpeakWhereCheckBox.AutoSize = true;
            this.SpeakWhereCheckBox.Location = new System.Drawing.Point(86, 75);
            this.SpeakWhereCheckBox.Name = "SpeakWhereCheckBox";
            this.SpeakWhereCheckBox.Size = new System.Drawing.Size(58, 17);
            this.SpeakWhereCheckBox.TabIndex = 186;
            this.SpeakWhereCheckBox.Text = "Where";
            this.SpeakWhereCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpeakVoltsCheckBox
            // 
            this.SpeakVoltsCheckBox.AutoSize = true;
            this.SpeakVoltsCheckBox.Checked = true;
            this.SpeakVoltsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeakVoltsCheckBox.Location = new System.Drawing.Point(11, 75);
            this.SpeakVoltsCheckBox.Name = "SpeakVoltsCheckBox";
            this.SpeakVoltsCheckBox.Size = new System.Drawing.Size(49, 17);
            this.SpeakVoltsCheckBox.TabIndex = 185;
            this.SpeakVoltsCheckBox.Text = "Volts";
            this.SpeakVoltsCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer_announce
            // 
            this.timer_announce.Enabled = true;
            this.timer_announce.Interval = 20000;
            this.timer_announce.Tick += new System.EventHandler(this.timer_announce_Tick);
            // 
            // timer_telemetry
            // 
            this.timer_telemetry.Enabled = true;
            this.timer_telemetry.Interval = 5000;
            this.timer_telemetry.Tick += new System.EventHandler(this.timer_telemetry_Tick);
            // 
            // StartNavigationButton
            // 
            this.StartNavigationButton.BackColor = System.Drawing.Color.Green;
            this.StartNavigationButton.Location = new System.Drawing.Point(851, 76);
            this.StartNavigationButton.Name = "StartNavigationButton";
            this.StartNavigationButton.Size = new System.Drawing.Size(67, 23);
            this.StartNavigationButton.TabIndex = 184;
            this.StartNavigationButton.Text = "Navigation";
            this.StartNavigationButton.UseVisualStyleBackColor = false;
            this.StartNavigationButton.Click += new System.EventHandler(this.StartNavigationButton_Click);
            // 
            // StartParametersButton
            // 
            this.StartParametersButton.BackColor = System.Drawing.Color.Green;
            this.StartParametersButton.Location = new System.Drawing.Point(924, 76);
            this.StartParametersButton.Name = "StartParametersButton";
            this.StartParametersButton.Size = new System.Drawing.Size(67, 23);
            this.StartParametersButton.TabIndex = 185;
            this.StartParametersButton.Text = "Parameters";
            this.StartParametersButton.UseVisualStyleBackColor = false;
            this.StartParametersButton.Click += new System.EventHandler(this.StartParametersButton_Click);
            // 
            // CalibrateIMUButton
            // 
            this.CalibrateIMUButton.Location = new System.Drawing.Point(134, 16);
            this.CalibrateIMUButton.Name = "CalibrateIMUButton";
            this.CalibrateIMUButton.Size = new System.Drawing.Size(50, 23);
            this.CalibrateIMUButton.TabIndex = 199;
            this.CalibrateIMUButton.Text = "IMU";
            this.CalibrateIMUButton.UseVisualStyleBackColor = true;
            this.CalibrateIMUButton.Click += new System.EventHandler(this.CalibrateIMUButton_Click);
            // 
            // CalibrateMagButton
            // 
            this.CalibrateMagButton.Location = new System.Drawing.Point(190, 16);
            this.CalibrateMagButton.Name = "CalibrateMagButton";
            this.CalibrateMagButton.Size = new System.Drawing.Size(50, 23);
            this.CalibrateMagButton.TabIndex = 201;
            this.CalibrateMagButton.Text = "Mag";
            this.CalibrateMagButton.UseVisualStyleBackColor = true;
            this.CalibrateMagButton.Click += new System.EventHandler(this.CalibrateMagButton_Click);
            // 
            // DrivesGroupBox
            // 
            this.DrivesGroupBox.Controls.Add(this.PWMT9);
            this.DrivesGroupBox.Controls.Add(this.PWMT8);
            this.DrivesGroupBox.Controls.Add(this.PWMT7);
            this.DrivesGroupBox.Controls.Add(this.PWMT6);
            this.DrivesGroupBox.Controls.Add(this.PWMT5);
            this.DrivesGroupBox.Controls.Add(this.PWMT4);
            this.DrivesGroupBox.Controls.Add(this.PWMT3);
            this.DrivesGroupBox.Controls.Add(this.PWMT2);
            this.DrivesGroupBox.Controls.Add(this.PWMT1);
            this.DrivesGroupBox.Controls.Add(this.PWMT0);
            this.DrivesGroupBox.Controls.Add(this.PWMT0ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT6ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT1ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT9ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT5ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT8ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT2ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT7ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT4ProgressBar);
            this.DrivesGroupBox.Controls.Add(this.PWMT3ProgressBar);
            this.DrivesGroupBox.Location = new System.Drawing.Point(842, 344);
            this.DrivesGroupBox.Name = "DrivesGroupBox";
            this.DrivesGroupBox.Size = new System.Drawing.Size(162, 180);
            this.DrivesGroupBox.TabIndex = 210;
            this.DrivesGroupBox.TabStop = false;
            this.DrivesGroupBox.Text = "Motors/Servos (%)";
            // 
            // PWMT9
            // 
            this.PWMT9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT9.Location = new System.Drawing.Point(12, 157);
            this.PWMT9.Name = "PWMT9";
            this.PWMT9.ReadOnly = true;
            this.PWMT9.Size = new System.Drawing.Size(25, 13);
            this.PWMT9.TabIndex = 207;
            this.PWMT9.Text = "0";
            this.PWMT9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT8
            // 
            this.PWMT8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT8.Location = new System.Drawing.Point(12, 141);
            this.PWMT8.Name = "PWMT8";
            this.PWMT8.ReadOnly = true;
            this.PWMT8.Size = new System.Drawing.Size(25, 13);
            this.PWMT8.TabIndex = 206;
            this.PWMT8.Text = "0";
            this.PWMT8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT7
            // 
            this.PWMT7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT7.Location = new System.Drawing.Point(12, 125);
            this.PWMT7.Name = "PWMT7";
            this.PWMT7.ReadOnly = true;
            this.PWMT7.Size = new System.Drawing.Size(25, 13);
            this.PWMT7.TabIndex = 205;
            this.PWMT7.Text = "0";
            this.PWMT7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT6
            // 
            this.PWMT6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT6.Location = new System.Drawing.Point(12, 109);
            this.PWMT6.Name = "PWMT6";
            this.PWMT6.ReadOnly = true;
            this.PWMT6.Size = new System.Drawing.Size(25, 13);
            this.PWMT6.TabIndex = 204;
            this.PWMT6.Text = "0";
            this.PWMT6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT5
            // 
            this.PWMT5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT5.Location = new System.Drawing.Point(12, 93);
            this.PWMT5.Name = "PWMT5";
            this.PWMT5.ReadOnly = true;
            this.PWMT5.Size = new System.Drawing.Size(25, 13);
            this.PWMT5.TabIndex = 203;
            this.PWMT5.Text = "0";
            this.PWMT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT4
            // 
            this.PWMT4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT4.Location = new System.Drawing.Point(12, 77);
            this.PWMT4.Name = "PWMT4";
            this.PWMT4.ReadOnly = true;
            this.PWMT4.Size = new System.Drawing.Size(25, 13);
            this.PWMT4.TabIndex = 202;
            this.PWMT4.Text = "0";
            this.PWMT4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT3
            // 
            this.PWMT3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT3.Location = new System.Drawing.Point(12, 61);
            this.PWMT3.Name = "PWMT3";
            this.PWMT3.ReadOnly = true;
            this.PWMT3.Size = new System.Drawing.Size(25, 13);
            this.PWMT3.TabIndex = 201;
            this.PWMT3.Text = "0";
            this.PWMT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT2
            // 
            this.PWMT2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT2.Location = new System.Drawing.Point(12, 45);
            this.PWMT2.Name = "PWMT2";
            this.PWMT2.ReadOnly = true;
            this.PWMT2.Size = new System.Drawing.Size(25, 13);
            this.PWMT2.TabIndex = 200;
            this.PWMT2.Text = "0";
            this.PWMT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT1
            // 
            this.PWMT1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT1.Location = new System.Drawing.Point(12, 29);
            this.PWMT1.Name = "PWMT1";
            this.PWMT1.ReadOnly = true;
            this.PWMT1.Size = new System.Drawing.Size(25, 13);
            this.PWMT1.TabIndex = 199;
            this.PWMT1.Text = "0";
            this.PWMT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT0
            // 
            this.PWMT0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWMT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMT0.Location = new System.Drawing.Point(12, 13);
            this.PWMT0.Name = "PWMT0";
            this.PWMT0.ReadOnly = true;
            this.PWMT0.Size = new System.Drawing.Size(25, 13);
            this.PWMT0.TabIndex = 198;
            this.PWMT0.Text = "0";
            this.PWMT0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PWMT0ProgressBar
            // 
            this.PWMT0ProgressBar.Location = new System.Drawing.Point(42, 15);
            this.PWMT0ProgressBar.Maximum = 1000;
            this.PWMT0ProgressBar.Name = "PWMT0ProgressBar";
            this.PWMT0ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT0ProgressBar.Step = 1;
            this.PWMT0ProgressBar.TabIndex = 191;
            // 
            // PWMT6ProgressBar
            // 
            this.PWMT6ProgressBar.Location = new System.Drawing.Point(42, 111);
            this.PWMT6ProgressBar.Maximum = 1000;
            this.PWMT6ProgressBar.Name = "PWMT6ProgressBar";
            this.PWMT6ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT6ProgressBar.Step = 1;
            this.PWMT6ProgressBar.TabIndex = 197;
            // 
            // PWMT1ProgressBar
            // 
            this.PWMT1ProgressBar.Location = new System.Drawing.Point(42, 31);
            this.PWMT1ProgressBar.Maximum = 1000;
            this.PWMT1ProgressBar.Name = "PWMT1ProgressBar";
            this.PWMT1ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT1ProgressBar.Step = 1;
            this.PWMT1ProgressBar.TabIndex = 192;
            // 
            // PWMT9ProgressBar
            // 
            this.PWMT9ProgressBar.Location = new System.Drawing.Point(42, 159);
            this.PWMT9ProgressBar.Maximum = 1000;
            this.PWMT9ProgressBar.Name = "PWMT9ProgressBar";
            this.PWMT9ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT9ProgressBar.Step = 1;
            this.PWMT9ProgressBar.TabIndex = 188;
            // 
            // PWMT5ProgressBar
            // 
            this.PWMT5ProgressBar.Location = new System.Drawing.Point(42, 95);
            this.PWMT5ProgressBar.Maximum = 1000;
            this.PWMT5ProgressBar.Name = "PWMT5ProgressBar";
            this.PWMT5ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT5ProgressBar.Step = 1;
            this.PWMT5ProgressBar.TabIndex = 196;
            // 
            // PWMT8ProgressBar
            // 
            this.PWMT8ProgressBar.Location = new System.Drawing.Point(42, 143);
            this.PWMT8ProgressBar.Maximum = 1000;
            this.PWMT8ProgressBar.Name = "PWMT8ProgressBar";
            this.PWMT8ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT8ProgressBar.Step = 1;
            this.PWMT8ProgressBar.TabIndex = 187;
            // 
            // PWMT2ProgressBar
            // 
            this.PWMT2ProgressBar.Location = new System.Drawing.Point(42, 47);
            this.PWMT2ProgressBar.Maximum = 1000;
            this.PWMT2ProgressBar.Name = "PWMT2ProgressBar";
            this.PWMT2ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT2ProgressBar.Step = 1;
            this.PWMT2ProgressBar.TabIndex = 193;
            // 
            // PWMT7ProgressBar
            // 
            this.PWMT7ProgressBar.Location = new System.Drawing.Point(42, 127);
            this.PWMT7ProgressBar.Maximum = 1000;
            this.PWMT7ProgressBar.Name = "PWMT7ProgressBar";
            this.PWMT7ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT7ProgressBar.Step = 1;
            this.PWMT7ProgressBar.TabIndex = 186;
            // 
            // PWMT4ProgressBar
            // 
            this.PWMT4ProgressBar.Location = new System.Drawing.Point(42, 79);
            this.PWMT4ProgressBar.Maximum = 1000;
            this.PWMT4ProgressBar.Name = "PWMT4ProgressBar";
            this.PWMT4ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT4ProgressBar.Step = 1;
            this.PWMT4ProgressBar.TabIndex = 195;
            // 
            // PWMT3ProgressBar
            // 
            this.PWMT3ProgressBar.Location = new System.Drawing.Point(42, 63);
            this.PWMT3ProgressBar.Maximum = 1000;
            this.PWMT3ProgressBar.Name = "PWMT3ProgressBar";
            this.PWMT3ProgressBar.Size = new System.Drawing.Size(108, 10);
            this.PWMT3ProgressBar.Step = 1;
            this.PWMT3ProgressBar.TabIndex = 194;
            // 
            // MissionTimeTextBox
            // 
            this.MissionTimeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MissionTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissionTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionTimeTextBox.Location = new System.Drawing.Point(857, 24);
            this.MissionTimeTextBox.Name = "MissionTimeTextBox";
            this.MissionTimeTextBox.Size = new System.Drawing.Size(130, 46);
            this.MissionTimeTextBox.TabIndex = 211;
            this.MissionTimeTextBox.Text = "-1";
            this.MissionTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WarningPictureBox
            // 
            this.WarningPictureBox.Image = global::UAVXGUI.Properties.Resources.Warning_Stripe_Black_Yellow;
            this.WarningPictureBox.Location = new System.Drawing.Point(323, 28);
            this.WarningPictureBox.Name = "WarningPictureBox";
            this.WarningPictureBox.Size = new System.Drawing.Size(258, 13);
            this.WarningPictureBox.TabIndex = 212;
            this.WarningPictureBox.TabStop = false;
            // 
            // BurnFirmwareButton
            // 
            this.BurnFirmwareButton.Location = new System.Drawing.Point(7, 128);
            this.BurnFirmwareButton.Name = "BurnFirmwareButton";
            this.BurnFirmwareButton.Size = new System.Drawing.Size(57, 23);
            this.BurnFirmwareButton.TabIndex = 213;
            this.BurnFirmwareButton.Text = "Burn";
            this.BurnFirmwareButton.UseVisualStyleBackColor = true;
            this.BurnFirmwareButton.Visible = false;
            this.BurnFirmwareButton.Click += new System.EventHandler(this.LegacyButton_Click);
            // 
            // TestCalGroupBox
            // 
            this.TestCalGroupBox.Controls.Add(this.ProgEscButton);
            this.TestCalGroupBox.Controls.Add(this.BurnFirmwareButton);
            this.TestCalGroupBox.Controls.Add(this.BaroStatsGroupBox);
            this.TestCalGroupBox.Location = new System.Drawing.Point(337, 67);
            this.TestCalGroupBox.Name = "TestCalGroupBox";
            this.TestCalGroupBox.Size = new System.Drawing.Size(69, 157);
            this.TestCalGroupBox.TabIndex = 214;
            this.TestCalGroupBox.TabStop = false;
            this.TestCalGroupBox.Text = "Test/Cal";
            this.TestCalGroupBox.Visible = false;
            // 
            // ProgEscButton
            // 
            this.ProgEscButton.Location = new System.Drawing.Point(7, 99);
            this.ProgEscButton.Name = "ProgEscButton";
            this.ProgEscButton.Size = new System.Drawing.Size(58, 23);
            this.ProgEscButton.TabIndex = 214;
            this.ProgEscButton.Text = "ProgESC";
            this.ProgEscButton.UseVisualStyleBackColor = true;
            this.ProgEscButton.Visible = false;
            this.ProgEscButton.Click += new System.EventHandler(this.ProgEscButton_Click);
            // 
            // SpectraGroupBox
            // 
            this.SpectraGroupBox.Controls.Add(this.DFTBar1);
            this.SpectraGroupBox.Controls.Add(this.DFTBar7);
            this.SpectraGroupBox.Controls.Add(this.DFTBar2);
            this.SpectraGroupBox.Controls.Add(this.DFTBar6);
            this.SpectraGroupBox.Controls.Add(this.DFTBar3);
            this.SpectraGroupBox.Controls.Add(this.DFTBar8);
            this.SpectraGroupBox.Controls.Add(this.DFTBar5);
            this.SpectraGroupBox.Controls.Add(this.DFTBar4);
            this.SpectraGroupBox.Location = new System.Drawing.Point(843, 105);
            this.SpectraGroupBox.Name = "SpectraGroupBox";
            this.SpectraGroupBox.Size = new System.Drawing.Size(161, 147);
            this.SpectraGroupBox.TabIndex = 215;
            this.SpectraGroupBox.TabStop = false;
            this.SpectraGroupBox.Text = "Vibration Spectra (0.1G FS)";
            // 
            // DFTBar1
            // 
            this.DFTBar1.Location = new System.Drawing.Point(6, 17);
            this.DFTBar1.Name = "DFTBar1";
            this.DFTBar1.Size = new System.Drawing.Size(150, 10);
            this.DFTBar1.Step = 1;
            this.DFTBar1.TabIndex = 191;
            // 
            // DFTBar7
            // 
            this.DFTBar7.Location = new System.Drawing.Point(6, 113);
            this.DFTBar7.Name = "DFTBar7";
            this.DFTBar7.Size = new System.Drawing.Size(150, 10);
            this.DFTBar7.Step = 1;
            this.DFTBar7.TabIndex = 197;
            // 
            // DFTBar2
            // 
            this.DFTBar2.Location = new System.Drawing.Point(6, 33);
            this.DFTBar2.Name = "DFTBar2";
            this.DFTBar2.Size = new System.Drawing.Size(150, 10);
            this.DFTBar2.Step = 1;
            this.DFTBar2.TabIndex = 192;
            // 
            // DFTBar6
            // 
            this.DFTBar6.Location = new System.Drawing.Point(6, 97);
            this.DFTBar6.Name = "DFTBar6";
            this.DFTBar6.Size = new System.Drawing.Size(150, 10);
            this.DFTBar6.Step = 1;
            this.DFTBar6.TabIndex = 196;
            // 
            // DFTBar3
            // 
            this.DFTBar3.Location = new System.Drawing.Point(6, 49);
            this.DFTBar3.Name = "DFTBar3";
            this.DFTBar3.Size = new System.Drawing.Size(150, 10);
            this.DFTBar3.Step = 1;
            this.DFTBar3.TabIndex = 193;
            // 
            // DFTBar8
            // 
            this.DFTBar8.Location = new System.Drawing.Point(6, 130);
            this.DFTBar8.Name = "DFTBar8";
            this.DFTBar8.Size = new System.Drawing.Size(150, 10);
            this.DFTBar8.Step = 1;
            this.DFTBar8.TabIndex = 186;
            // 
            // DFTBar5
            // 
            this.DFTBar5.Location = new System.Drawing.Point(6, 81);
            this.DFTBar5.Name = "DFTBar5";
            this.DFTBar5.Size = new System.Drawing.Size(150, 10);
            this.DFTBar5.Step = 1;
            this.DFTBar5.TabIndex = 195;
            // 
            // DFTBar4
            // 
            this.DFTBar4.Location = new System.Drawing.Point(6, 65);
            this.DFTBar4.Name = "DFTBar4";
            this.DFTBar4.Size = new System.Drawing.Size(150, 10);
            this.DFTBar4.Step = 1;
            this.DFTBar4.TabIndex = 194;
            // 
            // DumpBBButton
            // 
            this.DumpBBButton.Location = new System.Drawing.Point(630, 0);
            this.DumpBBButton.Name = "DumpBBButton";
            this.DumpBBButton.Size = new System.Drawing.Size(75, 23);
            this.DumpBBButton.TabIndex = 216;
            this.DumpBBButton.Text = "Black Box";
            this.DumpBBButton.UseVisualStyleBackColor = true;
            this.DumpBBButton.Click += new System.EventHandler(this.DumpBBButton_Click);
            // 
            // AlarmsButton
            // 
            this.AlarmsButton.Location = new System.Drawing.Point(549, 0);
            this.AlarmsButton.Name = "AlarmsButton";
            this.AlarmsButton.Size = new System.Drawing.Size(75, 23);
            this.AlarmsButton.TabIndex = 217;
            this.AlarmsButton.Text = "Say Alarms";
            this.AlarmsButton.UseVisualStyleBackColor = true;
            this.AlarmsButton.Click += new System.EventHandler(this.AlarmsButton_Click);
            // 
            // UtilisationLabel
            // 
            this.UtilisationLabel.AutoSize = true;
            this.UtilisationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilisationLabel.Location = new System.Drawing.Point(334, 3);
            this.UtilisationLabel.Name = "UtilisationLabel";
            this.UtilisationLabel.Size = new System.Drawing.Size(29, 16);
            this.UtilisationLabel.TabIndex = 218;
            this.UtilisationLabel.Text = "0%";
            // 
            // UtilisationProgressBar
            // 
            this.UtilisationProgressBar.Location = new System.Drawing.Point(369, 3);
            this.UtilisationProgressBar.Name = "UtilisationProgressBar";
            this.UtilisationProgressBar.Size = new System.Drawing.Size(172, 19);
            this.UtilisationProgressBar.Step = 1;
            this.UtilisationProgressBar.TabIndex = 219;
            // 
            // CalibrationGroupBox
            // 
            this.CalibrationGroupBox.Controls.Add(this.label23);
            this.CalibrationGroupBox.Controls.Add(this.label21);
            this.CalibrationGroupBox.Controls.Add(this.label22);
            this.CalibrationGroupBox.Controls.Add(this.MZCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MXCalBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MZBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MXBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYBiasLabel);
            this.CalibrationGroupBox.Controls.Add(this.MZScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.label13);
            this.CalibrationGroupBox.Controls.Add(this.label15);
            this.CalibrationGroupBox.Controls.Add(this.MXScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.MYScaleLabel);
            this.CalibrationGroupBox.Controls.Add(this.label16);
            this.CalibrationGroupBox.Controls.Add(this.CalOffsetLabel);
            this.CalibrationGroupBox.Controls.Add(this.CalibrateIMUButton);
            this.CalibrationGroupBox.Controls.Add(this.CalibrateMagButton);
            this.CalibrationGroupBox.Controls.Add(this.label12);
            this.CalibrationGroupBox.Controls.Add(this.CalTRefLabel);
            this.CalibrationGroupBox.Controls.Add(this.UDAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.BFAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.LRAccMLabel);
            this.CalibrationGroupBox.Controls.Add(this.UDAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.BFAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.LRAccCLabel);
            this.CalibrationGroupBox.Controls.Add(this.label18);
            this.CalibrationGroupBox.Controls.Add(this.label19);
            this.CalibrationGroupBox.Controls.Add(this.label20);
            this.CalibrationGroupBox.Controls.Add(this.label14);
            this.CalibrationGroupBox.Controls.Add(this.YawGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.label17);
            this.CalibrationGroupBox.Controls.Add(this.RollGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.YawGyroMLabel);
            this.CalibrationGroupBox.Controls.Add(this.YawCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchGyroCLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.RollCalLabel);
            this.CalibrationGroupBox.Controls.Add(this.RollGyroMLabel);
            this.CalibrationGroupBox.Controls.Add(this.PitchGyroMLabel);
            this.CalibrationGroupBox.Location = new System.Drawing.Point(586, 471);
            this.CalibrationGroupBox.Name = "CalibrationGroupBox";
            this.CalibrationGroupBox.Size = new System.Drawing.Size(250, 157);
            this.CalibrationGroupBox.TabIndex = 220;
            this.CalibrationGroupBox.TabStop = false;
            this.CalibrationGroupBox.Text = "Calibration (G, Deg)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(149, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(47, 13);
            this.label23.TabIndex = 216;
            this.label23.Text = "TRef (C)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(217, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 215;
            this.label21.Text = "Bias";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(162, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 214;
            this.label22.Text = "Scale";
            // 
            // MZCalBiasLabel
            // 
            this.MZCalBiasLabel.AutoSize = true;
            this.MZCalBiasLabel.Location = new System.Drawing.Point(138, 136);
            this.MZCalBiasLabel.Name = "MZCalBiasLabel";
            this.MZCalBiasLabel.Size = new System.Drawing.Size(23, 13);
            this.MZCalBiasLabel.TabIndex = 213;
            this.MZCalBiasLabel.Text = "MZ";
            // 
            // MYCalBiasLabel
            // 
            this.MYCalBiasLabel.AutoSize = true;
            this.MYCalBiasLabel.Location = new System.Drawing.Point(138, 117);
            this.MYCalBiasLabel.Name = "MYCalBiasLabel";
            this.MYCalBiasLabel.Size = new System.Drawing.Size(23, 13);
            this.MYCalBiasLabel.TabIndex = 212;
            this.MYCalBiasLabel.Text = "MY";
            // 
            // MXCalBiasLabel
            // 
            this.MXCalBiasLabel.AutoSize = true;
            this.MXCalBiasLabel.Location = new System.Drawing.Point(138, 97);
            this.MXCalBiasLabel.Name = "MXCalBiasLabel";
            this.MXCalBiasLabel.Size = new System.Drawing.Size(23, 13);
            this.MXCalBiasLabel.TabIndex = 211;
            this.MXCalBiasLabel.Text = "MX";
            // 
            // MZBiasLabel
            // 
            this.MZBiasLabel.Location = new System.Drawing.Point(202, 136);
            this.MZBiasLabel.Name = "MZBiasLabel";
            this.MZBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MZBiasLabel.TabIndex = 210;
            this.MZBiasLabel.Text = "0";
            this.MZBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MXBiasLabel
            // 
            this.MXBiasLabel.Location = new System.Drawing.Point(202, 97);
            this.MXBiasLabel.Name = "MXBiasLabel";
            this.MXBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MXBiasLabel.TabIndex = 209;
            this.MXBiasLabel.Text = "0";
            this.MXBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MYBiasLabel
            // 
            this.MYBiasLabel.Location = new System.Drawing.Point(202, 117);
            this.MYBiasLabel.Name = "MYBiasLabel";
            this.MYBiasLabel.Size = new System.Drawing.Size(40, 13);
            this.MYBiasLabel.TabIndex = 208;
            this.MYBiasLabel.Text = "0";
            this.MYBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MZScaleLabel
            // 
            this.MZScaleLabel.Location = new System.Drawing.Point(156, 136);
            this.MZScaleLabel.Name = "MZScaleLabel";
            this.MZScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MZScaleLabel.TabIndex = 207;
            this.MZScaleLabel.Text = "0";
            this.MZScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 204;
            this.label13.Text = "UD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 203;
            this.label15.Text = "LR";
            // 
            // MXScaleLabel
            // 
            this.MXScaleLabel.Location = new System.Drawing.Point(156, 97);
            this.MXScaleLabel.Name = "MXScaleLabel";
            this.MXScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MXScaleLabel.TabIndex = 206;
            this.MXScaleLabel.Text = "0";
            this.MXScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MYScaleLabel
            // 
            this.MYScaleLabel.Location = new System.Drawing.Point(156, 117);
            this.MYScaleLabel.Name = "MYScaleLabel";
            this.MYScaleLabel.Size = new System.Drawing.Size(40, 13);
            this.MYScaleLabel.TabIndex = 205;
            this.MYScaleLabel.Text = "0";
            this.MYScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 202;
            this.label16.Text = "BF";
            // 
            // CalOffsetLabel
            // 
            this.CalOffsetLabel.AutoSize = true;
            this.CalOffsetLabel.Location = new System.Drawing.Point(94, 22);
            this.CalOffsetLabel.Name = "CalOffsetLabel";
            this.CalOffsetLabel.Size = new System.Drawing.Size(27, 13);
            this.CalOffsetLabel.TabIndex = 86;
            this.CalOffsetLabel.Text = "Bias";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "/C";
            // 
            // CalTRefLabel
            // 
            this.CalTRefLabel.Location = new System.Drawing.Point(187, 58);
            this.CalTRefLabel.Name = "CalTRefLabel";
            this.CalTRefLabel.Size = new System.Drawing.Size(40, 13);
            this.CalTRefLabel.TabIndex = 84;
            this.CalTRefLabel.Text = "0";
            this.CalTRefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UDAccMLabel
            // 
            this.UDAccMLabel.Location = new System.Drawing.Point(35, 136);
            this.UDAccMLabel.Name = "UDAccMLabel";
            this.UDAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.UDAccMLabel.TabIndex = 83;
            this.UDAccMLabel.Text = "0";
            this.UDAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BFAccMLabel
            // 
            this.BFAccMLabel.Location = new System.Drawing.Point(35, 97);
            this.BFAccMLabel.Name = "BFAccMLabel";
            this.BFAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.BFAccMLabel.TabIndex = 82;
            this.BFAccMLabel.Text = "0";
            this.BFAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRAccMLabel
            // 
            this.LRAccMLabel.Location = new System.Drawing.Point(35, 117);
            this.LRAccMLabel.Name = "LRAccMLabel";
            this.LRAccMLabel.Size = new System.Drawing.Size(40, 13);
            this.LRAccMLabel.TabIndex = 81;
            this.LRAccMLabel.Text = "0";
            this.LRAccMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UDAccCLabel
            // 
            this.UDAccCLabel.Location = new System.Drawing.Point(81, 136);
            this.UDAccCLabel.Name = "UDAccCLabel";
            this.UDAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.UDAccCLabel.TabIndex = 80;
            this.UDAccCLabel.Text = "0";
            this.UDAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BFAccCLabel
            // 
            this.BFAccCLabel.Location = new System.Drawing.Point(81, 97);
            this.BFAccCLabel.Name = "BFAccCLabel";
            this.BFAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.BFAccCLabel.TabIndex = 79;
            this.BFAccCLabel.Text = "0";
            this.BFAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRAccCLabel
            // 
            this.LRAccCLabel.Location = new System.Drawing.Point(81, 117);
            this.LRAccCLabel.Name = "LRAccCLabel";
            this.LRAccCLabel.Size = new System.Drawing.Size(40, 13);
            this.LRAccCLabel.TabIndex = 78;
            this.LRAccCLabel.Text = "0";
            this.LRAccCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(343, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 77;
            this.label18.Text = "0";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(312, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "0";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(372, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 75;
            this.label20.Text = "0";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(254, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 74;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawGyroCLabel
            // 
            this.YawGyroCLabel.Location = new System.Drawing.Point(81, 77);
            this.YawGyroCLabel.Name = "YawGyroCLabel";
            this.YawGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.YawGyroCLabel.TabIndex = 73;
            this.YawGyroCLabel.Text = "0";
            this.YawGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(283, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "0";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RollGyroCLabel
            // 
            this.RollGyroCLabel.Location = new System.Drawing.Point(81, 38);
            this.RollGyroCLabel.Name = "RollGyroCLabel";
            this.RollGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.RollGyroCLabel.TabIndex = 71;
            this.RollGyroCLabel.Text = "0";
            this.RollGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawGyroMLabel
            // 
            this.YawGyroMLabel.Location = new System.Drawing.Point(35, 77);
            this.YawGyroMLabel.Name = "YawGyroMLabel";
            this.YawGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.YawGyroMLabel.TabIndex = 70;
            this.YawGyroMLabel.Text = "0";
            this.YawGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YawCalLabel
            // 
            this.YawCalLabel.AutoSize = true;
            this.YawCalLabel.Location = new System.Drawing.Point(13, 77);
            this.YawCalLabel.Name = "YawCalLabel";
            this.YawCalLabel.Size = new System.Drawing.Size(28, 13);
            this.YawCalLabel.TabIndex = 69;
            this.YawCalLabel.Text = "Yaw";
            // 
            // PitchGyroCLabel
            // 
            this.PitchGyroCLabel.Location = new System.Drawing.Point(81, 58);
            this.PitchGyroCLabel.Name = "PitchGyroCLabel";
            this.PitchGyroCLabel.Size = new System.Drawing.Size(40, 13);
            this.PitchGyroCLabel.TabIndex = 68;
            this.PitchGyroCLabel.Text = "0";
            this.PitchGyroCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PitchCalLabel
            // 
            this.PitchCalLabel.AutoSize = true;
            this.PitchCalLabel.Location = new System.Drawing.Point(13, 58);
            this.PitchCalLabel.Name = "PitchCalLabel";
            this.PitchCalLabel.Size = new System.Drawing.Size(31, 13);
            this.PitchCalLabel.TabIndex = 53;
            this.PitchCalLabel.Text = "Pitch";
            // 
            // RollCalLabel
            // 
            this.RollCalLabel.AutoSize = true;
            this.RollCalLabel.Location = new System.Drawing.Point(13, 38);
            this.RollCalLabel.Name = "RollCalLabel";
            this.RollCalLabel.Size = new System.Drawing.Size(25, 13);
            this.RollCalLabel.TabIndex = 49;
            this.RollCalLabel.Text = "Roll";
            // 
            // RollGyroMLabel
            // 
            this.RollGyroMLabel.Location = new System.Drawing.Point(35, 39);
            this.RollGyroMLabel.Name = "RollGyroMLabel";
            this.RollGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.RollGyroMLabel.TabIndex = 48;
            this.RollGyroMLabel.Text = "0";
            this.RollGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PitchGyroMLabel
            // 
            this.PitchGyroMLabel.Location = new System.Drawing.Point(35, 58);
            this.PitchGyroMLabel.Name = "PitchGyroMLabel";
            this.PitchGyroMLabel.Size = new System.Drawing.Size(40, 13);
            this.PitchGyroMLabel.TabIndex = 51;
            this.PitchGyroMLabel.Text = "0";
            this.PitchGyroMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(347, 403);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(210, 218);
            this.headingIndicatorInstrumentControl1.TabIndex = 4;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(323, 115);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(258, 257);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 3;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // PlotButton
            // 
            this.PlotButton.BackColor = System.Drawing.Color.Green;
            this.PlotButton.Location = new System.Drawing.Point(891, 288);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(67, 23);
            this.PlotButton.TabIndex = 221;
            this.PlotButton.Text = "Plot";
            this.PlotButton.UseVisualStyleBackColor = false;
            this.PlotButton.Visible = false;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.PlotButton);
            this.Controls.Add(this.CalibrationGroupBox);
            this.Controls.Add(this.UtilisationProgressBar);
            this.Controls.Add(this.UtilisationLabel);
            this.Controls.Add(this.AlarmsButton);
            this.Controls.Add(this.DumpBBButton);
            this.Controls.Add(this.SpectraGroupBox);
            this.Controls.Add(this.WarningPictureBox);
            this.Controls.Add(this.MissionTimeTextBox);
            this.Controls.Add(this.DrivesGroupBox);
            this.Controls.Add(this.TestCalGroupBox);
            this.Controls.Add(this.AltitudeGroupBox);
            this.Controls.Add(this.FrSkyBox);
            this.Controls.Add(this.StartParametersButton);
            this.Controls.Add(this.StartNavigationButton);
            this.Controls.Add(this.SpeechGroupBox);
            this.Controls.Add(this.ROCLabel);
            this.Controls.Add(this.ROC);
            this.Controls.Add(this.NavCompBox);
            this.Controls.Add(this.NavState);
            this.Controls.Add(this.ReplayNumericUpDown);
            this.Controls.Add(this.Airframe);
            this.Controls.Add(this.ReplayProgressBar);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.NavStateLabel);
            this.Controls.Add(this.FlightState);
            this.Controls.Add(this.FailStateLabel);
            this.Controls.Add(this.ErrorStatsGroupBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.EmulationTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AltitudeSource);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.CurrentAltitude);
            this.Controls.Add(this.GPSStatBox);
            this.Controls.Add(this.FlagsGroupBox);
            this.Controls.Add(this.FailState);
            this.Controls.Add(this.BatteryGroupBox);
            this.Controls.Add(this.EnvGroupBox);
            this.Controls.Add(this.AccelerationsGroupBox);
            this.Controls.Add(this.AttitudeGroupBox);
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.GyroGroupBox);
            this.Controls.Add(this.CommsGroupBox);
            this.Controls.Add(this.NavGroupBox);
            this.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.RightToLeftLayout = true;
            this.Text = "UAVXGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GyroGroupBox.ResumeLayout(false);
            this.GyroGroupBox.PerformLayout();
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.AttitudeGroupBox.ResumeLayout(false);
            this.AttitudeGroupBox.PerformLayout();
            this.AccelerationsGroupBox.ResumeLayout(false);
            this.AccelerationsGroupBox.PerformLayout();
            this.CommsGroupBox.ResumeLayout(false);
            this.CommsGroupBox.PerformLayout();
            this.EnvGroupBox.ResumeLayout(false);
            this.EnvGroupBox.PerformLayout();
            this.BatteryGroupBox.ResumeLayout(false);
            this.BatteryGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.FrSkyBox.ResumeLayout(false);
            this.FrSkyBox.PerformLayout();
            this.FlagsGroupBox.ResumeLayout(false);
            this.GPSStatBox.ResumeLayout(false);
            this.GPSStatBox.PerformLayout();
            this.AltitudeGroupBox.ResumeLayout(false);
            this.AltitudeGroupBox.PerformLayout();
            this.NavGroupBox.ResumeLayout(false);
            this.NavGroupBox.PerformLayout();
            this.LocationBox.ResumeLayout(false);
            this.LocationBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BaroStatsGroupBox.ResumeLayout(false);
            this.BaroStatsGroupBox.PerformLayout();
            this.GPSStatsGroupBox.ResumeLayout(false);
            this.GPSStatsGroupBox.PerformLayout();
            this.ErrorStatsGroupBox.ResumeLayout(false);
            this.ErrorStatsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayNumericUpDown)).EndInit();
            this.NavCompBox.ResumeLayout(false);
            this.NavCompBox.PerformLayout();
            this.SpeechGroupBox.ResumeLayout(false);
            this.SpeechGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakIntervalNumericUpDown)).EndInit();
            this.DrivesGroupBox.ResumeLayout(false);
            this.DrivesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).EndInit();
            this.TestCalGroupBox.ResumeLayout(false);
            this.SpectraGroupBox.ResumeLayout(false);
            this.CalibrationGroupBox.ResumeLayout(false);
            this.CalibrationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private Instruments.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private Instruments.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private System.Windows.Forms.TextBox RollAngle;
        private System.Windows.Forms.TextBox PitchAngle;
        private System.Windows.Forms.TextBox BatteryVolts;
        private System.Windows.Forms.TextBox BatteryCurrent;
        private System.Windows.Forms.TextBox RCGlitches;
        private System.Windows.Forms.TextBox DesiredThrottle;
        private System.Windows.Forms.TextBox DesiredRoll;
        private System.Windows.Forms.TextBox DesiredPitch;
        private System.Windows.Forms.TextBox DesiredYaw;
        private System.Windows.Forms.TextBox YawGyro;
        private System.Windows.Forms.TextBox PitchRate;
        private System.Windows.Forms.TextBox RollRate;
        private System.Windows.Forms.TextBox LRAcc;
        private System.Windows.Forms.TextBox YawAngleError;
        private System.Windows.Forms.TextBox DUAcc;
        private System.Windows.Forms.TextBox FBAcc;
        private System.Windows.Forms.Label VoltsLabel;
        private System.Windows.Forms.Label LRAccLabel;
        private System.Windows.Forms.Label FBAccLabel;
        private System.Windows.Forms.Label DUAccLabel;
        private System.Windows.Forms.Label DesiredYawLabel;
        private System.Windows.Forms.Label DesiredPitchLabel;
        private System.Windows.Forms.Label DesiredRollLabel;
        private System.Windows.Forms.Label DesiredThrottleLabel;
        private System.Windows.Forms.Label RCGlitchesLabel;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.TextBox GPShAcc;
        private System.Windows.Forms.TextBox RangefinderAltitude;
        private System.Windows.Forms.TextBox BaroAltitude;
        private System.Windows.Forms.TextBox GPSFix;
        private System.Windows.Forms.TextBox ROC;
        private System.Windows.Forms.TextBox GPSNoOfSats;
        private System.Windows.Forms.TextBox FailState;
        private System.Windows.Forms.TextBox GPSAltitude;
        private System.Windows.Forms.Label ROCLabel;
        private System.Windows.Forms.Label hAccLabel;
        private System.Windows.Forms.Label RangefinderAltLabel;
        private System.Windows.Forms.Label GPSFixLabel;
        private System.Windows.Forms.Label GPSNoOfSatsLabel;
        private System.Windows.Forms.Label FailStateLabel;
        private System.Windows.Forms.Label GPSAltLabel;
        private System.Windows.Forms.Label BaroAltitudeLabel;
        private System.Windows.Forms.Label YawGyroLabel;
        private System.Windows.Forms.Label PitchRateLabel;
        private System.Windows.Forms.Label RollRateLabel;
        private System.Windows.Forms.TextBox RxTypeErr;
        private System.Windows.Forms.TextBox RxCSumErr;
        private System.Windows.Forms.TextBox RxLenErr;
        private System.Windows.Forms.Label RxTypeLabel;
        private System.Windows.Forms.Label RxCSumLabel;
        private System.Windows.Forms.Label RxLenLabel;
        private System.Windows.Forms.TextBox FlightState;
        private System.Windows.Forms.GroupBox GyroGroupBox;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.GroupBox AttitudeGroupBox;
        private System.Windows.Forms.GroupBox AccelerationsGroupBox;
        private System.Windows.Forms.GroupBox CommsGroupBox;
        private System.Windows.Forms.GroupBox EnvGroupBox;
        private System.Windows.Forms.GroupBox BatteryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox AltHoldBox;
        private System.Windows.Forms.TextBox TurnToPOIBox;
        private System.Windows.Forms.TextBox UsingUplinkFlagBox;
        private System.Windows.Forms.TextBox LostModelBox;
        private System.Windows.Forms.TextBox NearLevelBox;
        private System.Windows.Forms.TextBox LowBatteryBox;
        private System.Windows.Forms.TextBox GPSValidBox;
        private System.Windows.Forms.TextBox NavValidBox;
        private System.Windows.Forms.TextBox BaroFailBox;
        private System.Windows.Forms.TextBox IMUFailBox;
        private System.Windows.Forms.TextBox MagFailBox;
        private System.Windows.Forms.TextBox GPSFailBox;
        private System.Windows.Forms.TextBox AttitudeHoldBox;
        private System.Windows.Forms.TextBox ThrottleMovingBox;
        private System.Windows.Forms.TextBox HoldingAltBox;
        private System.Windows.Forms.TextBox NavigateBox;
        private System.Windows.Forms.TextBox RateControlBox;
        private System.Windows.Forms.TextBox ProximityBox;
        private System.Windows.Forms.TextBox CloseProximityBox;
        private System.Windows.Forms.TextBox UseRTHAutoDescendBox;
        private System.Windows.Forms.TextBox BaroAltValidBox;
        private System.Windows.Forms.TextBox RangefinderAltValidBox;
        private System.Windows.Forms.TextBox UsingRangefinderBox;
        private System.Windows.Forms.GroupBox FlagsGroupBox;
        private System.Windows.Forms.GroupBox GPSStatBox;
        private System.Windows.Forms.GroupBox AltitudeGroupBox;
        private System.Windows.Forms.Label WayHeadingLabel;
        private System.Windows.Forms.Label GPSLongitudeLabel;
        private System.Windows.Forms.Label GPSLatitudeLabel;
        private System.Windows.Forms.Label NavStateLabel;
        private System.Windows.Forms.Label GPSVelLabel;
        private System.Windows.Forms.Label CurrWPLabel;
        private System.Windows.Forms.TextBox GPSLatitude;
        private System.Windows.Forms.TextBox GPSLongitude;
        private System.Windows.Forms.TextBox NavState;
        private System.Windows.Forms.TextBox CurrWP;
        private System.Windows.Forms.TextBox WayHeading;
        private System.Windows.Forms.Label WPAltitude;
        private System.Windows.Forms.TextBox GPSVel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.TextBox AltitudeError;
        private System.Windows.Forms.TextBox Heading;
        private System.Windows.Forms.Label WPDistanceLabel;
        private System.Windows.Forms.TextBox DistanceToDesired;
        private System.Windows.Forms.GroupBox NavGroupBox;
        private System.Windows.Forms.TextBox CurrentAltitude;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox AltitudeSource;
        private System.Windows.Forms.GroupBox LocationBox;
        private System.Windows.Forms.Label WhereBearingLabel;
        private System.Windows.Forms.Label WhereDistanceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AltComp;
        private System.Windows.Forms.TextBox TiltFFComp;
        private System.Windows.Forms.Label TiltFFCompLabel;
        private System.Windows.Forms.Label AltCompLabel;
        private System.Windows.Forms.Label NavStateTimeoutLabel;
        private System.Windows.Forms.TextBox NavStateTimeout;
        private System.Windows.Forms.TextBox BatteryCharge;
        private System.Windows.Forms.Label BatteryChargeLabel;
        private System.Windows.Forms.TextBox EmulationTextBox;
        private System.Windows.Forms.GroupBox BaroStatsGroupBox;
        private System.Windows.Forms.Label TempSLabel;
        private System.Windows.Forms.Label MinTempS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BaroMaxROCS;
        private System.Windows.Forms.Label RelBaroAltitudeLabel;
        private System.Windows.Forms.Label BaroRelAltitudeS;
        private System.Windows.Forms.Label BaroMinROCS;
        private System.Windows.Forms.GroupBox ErrorStatsGroupBox;
        private System.Windows.Forms.Label GyroSLabel;
        private System.Windows.Forms.Label GyroFailS;
        private System.Windows.Forms.Label GPSInvalidSLabel;
        private System.Windows.Forms.Label GPSFailS;
        private System.Windows.Forms.Label I2CESCFailS;
        private System.Windows.Forms.Label CompassFailLabel;
        private System.Windows.Forms.Label AccFailLabel;
        private System.Windows.Forms.Label CompassFailS;
        private System.Windows.Forms.Label BaroFailLabel;
        private System.Windows.Forms.Label BaroFailS;
        private System.Windows.Forms.Label ESCSLabel;
        private System.Windows.Forms.Label AccFailS;
        private System.Windows.Forms.GroupBox GPSStatsGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GPSMaxhAccS;
        private System.Windows.Forms.Label GPSMinhAccS;
        private System.Windows.Forms.Label GPSAltitudeLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label GPSMaxVelS;
        private System.Windows.Forms.Label GPSAltitudeS;
        private System.Windows.Forms.Label SatsLabel;
        private System.Windows.Forms.Label GPSMinSatS;
        private System.Windows.Forms.Label GPSMaxSatS;
        private System.Windows.Forms.Label FailsafeSLabel;
        private System.Windows.Forms.Label RCFailSafeS;
        private System.Windows.Forms.Label I2CSIOFailLabel;
        private System.Windows.Forms.Label I2CSIOFailS;
        private System.Windows.Forms.Label MaxTempS;
        private System.Windows.Forms.Label BadS;
        private System.Windows.Forms.Label BadSLabel;
        private System.Windows.Forms.OpenFileDialog OpenLogFileDialog;
        private System.Windows.Forms.ToolStripComboBox COMSelectComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox COMBaudRateComboBox;
        private System.Windows.Forms.TextBox SensorTemp;
        private System.Windows.Forms.Label SensorTempLabel;
        private System.Windows.Forms.TextBox WhereDistance;
        private System.Windows.Forms.TextBox WhereBearing;
        private System.Windows.Forms.Button ReplayButton;
        public System.Windows.Forms.ProgressBar ReplayProgressBar;
        private System.Windows.Forms.Label YawLabel;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.Label RollLabel;
        private System.Windows.Forms.TextBox BypassBox;
        private System.Windows.Forms.TextBox Airframe;
        private System.Windows.Forms.NumericUpDown ReplayNumericUpDown;
        private System.Windows.Forms.TextBox SticksFrozenBox;
        private System.Windows.Forms.GroupBox NavCompBox;
        private System.Windows.Forms.TextBox NavSensitivity;
        private System.Windows.Forms.Label NavSensitivityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NavYCorr;
        private System.Windows.Forms.TextBox NavRCorr;
        private System.Windows.Forms.TextBox NavPCorr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GPSHeadingLabel;
        private System.Windows.Forms.TextBox GPSHeading;
        private System.Windows.Forms.CheckBox FrSkyCheckBox;
        private System.Windows.Forms.GroupBox FrSkyBox;
        private System.Windows.Forms.Label FrSkyLQLabel;
        private System.Windows.Forms.Label FrSkyA2Label;
        private System.Windows.Forms.Label FrSkyALabel;
        private System.Windows.Forms.TextBox FrSkyLQ;
        private System.Windows.Forms.TextBox FrSkyA2;
        private System.Windows.Forms.TextBox FrSkyA1;
        private System.Windows.Forms.Label FrSkyErrLabel;
        private System.Windows.Forms.TextBox RxFrSkyErr;
        private System.Windows.Forms.CheckBox RawCheckBox;
        private System.Windows.Forms.Label ErrNoS;
        private System.Windows.Forms.Label ErrNoSLabel;
        private System.Windows.Forms.Label AccConfidenceLabel;
        private System.Windows.Forms.TextBox AccConfidence;
        private System.Windows.Forms.Label CrossTrackErrorLabel;
        private System.Windows.Forms.TextBox CrossTrackError;
        private System.Windows.Forms.GroupBox SpeechGroupBox;
        private System.Windows.Forms.NumericUpDown SpeakIntervalNumericUpDown;
        private System.Windows.Forms.CheckBox SpeechEnableCheckBox;
        private System.Windows.Forms.CheckBox SpeakNavCheckBox;
        private System.Windows.Forms.CheckBox SpeakAltitudeCheckBox;
        private System.Windows.Forms.CheckBox SpeakWhereCheckBox;
        private System.Windows.Forms.CheckBox SpeakVoltsCheckBox;
        private System.Windows.Forms.Timer timer_announce;
        private System.Windows.Forms.Timer timer_telemetry;
        private System.Windows.Forms.Button StartParametersButton;
        private System.Windows.Forms.Button CalibrateIMUButton;
        private System.Windows.Forms.Button CalibrateMagButton;
        private System.Windows.Forms.Label SpeakIntervalLabel;
        private System.Windows.Forms.GroupBox DrivesGroupBox;
        private System.Windows.Forms.TextBox PWMT9;
        private System.Windows.Forms.TextBox PWMT8;
        private System.Windows.Forms.TextBox PWMT7;
        private System.Windows.Forms.TextBox PWMT6;
        private System.Windows.Forms.TextBox PWMT5;
        private System.Windows.Forms.TextBox PWMT4;
        private System.Windows.Forms.TextBox PWMT3;
        private System.Windows.Forms.TextBox PWMT2;
        private System.Windows.Forms.TextBox PWMT1;
        private System.Windows.Forms.TextBox PWMT0;
        private System.Windows.Forms.ProgressBar PWMT0ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT6ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT1ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT9ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT5ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT8ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT2ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT7ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT4ProgressBar;
        private System.Windows.Forms.ProgressBar PWMT3ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.Windows.Forms.TextBox MissionTimeTextBox;
        public System.Windows.Forms.Button StartNavigationButton;
        private System.Windows.Forms.PictureBox WarningPictureBox;
        public static System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BurnFirmwareButton;
        private System.Windows.Forms.GroupBox TestCalGroupBox;
        private System.Windows.Forms.CheckBox SpeakVarioCheckBox;
        private System.Windows.Forms.GroupBox SpectraGroupBox;
        private System.Windows.Forms.ProgressBar DFTBar1;
        private System.Windows.Forms.ProgressBar DFTBar7;
        private System.Windows.Forms.ProgressBar DFTBar2;
        private System.Windows.Forms.ProgressBar DFTBar6;
        private System.Windows.Forms.ProgressBar DFTBar3;
        private System.Windows.Forms.ProgressBar DFTBar8;
        private System.Windows.Forms.ProgressBar DFTBar5;
        private System.Windows.Forms.ProgressBar DFTBar4;
        private System.Windows.Forms.Button DumpBBButton;
        private System.Windows.Forms.Button AlarmsButton;
        private System.Windows.Forms.Label UtilisationLabel;
        private System.Windows.Forms.TextBox BaroPressure;
        private System.Windows.Forms.TextBox BaroTemperature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CruiseThrottleLabel;
        private System.Windows.Forms.TextBox CruiseThrottle;
        private System.Windows.Forms.ProgressBar UtilisationProgressBar;
        private System.Windows.Forms.Button ProgEscButton;
        private System.Windows.Forms.Label BattFFLabel;
        private System.Windows.Forms.TextBox BattFFComp;
        private System.Windows.Forms.GroupBox CalibrationGroupBox;
        private System.Windows.Forms.Label UDAccMLabel;
        private System.Windows.Forms.Label BFAccMLabel;
        private System.Windows.Forms.Label LRAccMLabel;
        private System.Windows.Forms.Label UDAccCLabel;
        private System.Windows.Forms.Label BFAccCLabel;
        private System.Windows.Forms.Label LRAccCLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label YawGyroCLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label RollGyroCLabel;
        private System.Windows.Forms.Label YawGyroMLabel;
        private System.Windows.Forms.Label YawCalLabel;
        private System.Windows.Forms.Label PitchGyroCLabel;
        private System.Windows.Forms.Label PitchCalLabel;
        private System.Windows.Forms.Label RollCalLabel;
        private System.Windows.Forms.Label RollGyroMLabel;
        private System.Windows.Forms.Label PitchGyroMLabel;
        private System.Windows.Forms.Label CalTRefLabel;
        private System.Windows.Forms.Label MZCalBiasLabel;
        private System.Windows.Forms.Label MYCalBiasLabel;
        private System.Windows.Forms.Label MXCalBiasLabel;
        private System.Windows.Forms.Label MZBiasLabel;
        private System.Windows.Forms.Label MXBiasLabel;
        private System.Windows.Forms.Label MYBiasLabel;
        private System.Windows.Forms.Label MZScaleLabel;
        private System.Windows.Forms.Label MXScaleLabel;
        private System.Windows.Forms.Label MYScaleLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CalOffsetLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox MagLockedBox;
        private System.Windows.Forms.Button PlotButton;
    }
}
