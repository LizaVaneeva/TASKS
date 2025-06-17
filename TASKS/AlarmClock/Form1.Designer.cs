namespace AlarmClock
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.chkAlarm = new System.Windows.Forms.CheckBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(102, 58);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(109, 29);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Сейчас:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сигнал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "час.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "мин.";
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(107, 151);
            this.nudHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(60, 22);
            this.nudHour.TabIndex = 4;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(107, 192);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(60, 22);
            this.nudMinute.TabIndex = 5;
            // 
            // chkAlarm
            // 
            this.chkAlarm.AutoSize = true;
            this.chkAlarm.Location = new System.Drawing.Point(107, 244);
            this.chkAlarm.Name = "chkAlarm";
            this.chkAlarm.Size = new System.Drawing.Size(94, 20);
            this.chkAlarm.TabIndex = 6;
            this.chkAlarm.Text = "вкл./выкл.";
            this.chkAlarm.UseVisualStyleBackColor = true;
            this.chkAlarm.CheckedChanged += new System.EventHandler(this.chkAlarm_CheckedChanged);

            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(149, 297);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "Скрыть";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Будильник";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestore,
            this.tsmiMove,
            this.tsmiSize,
            this.tsmiMinimize,
            this.tsmiMaximize,
            this.tsmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 148);
            // 
            // tsmiRestore
            // 
            this.tsmiRestore.Enabled = false;
            this.tsmiRestore.Name = "tsmiRestore";
            this.tsmiRestore.Size = new System.Drawing.Size(173, 24);
            this.tsmiRestore.Text = "Восстановить";
            this.tsmiRestore.Click += new System.EventHandler(this.tsmiRestore_Click);
            // 
            // tsmiMove
            // 
            this.tsmiMove.Name = "tsmiMove";
            this.tsmiMove.Size = new System.Drawing.Size(173, 24);
            this.tsmiMove.Text = "Переместить";
            this.tsmiMove.Click += new System.EventHandler(this.tsmiMove_Click);
            // 
            // tsmiSize
            // 
            this.tsmiSize.Enabled = false;
            this.tsmiSize.Name = "tsmiSize";
            this.tsmiSize.Size = new System.Drawing.Size(173, 24);
            this.tsmiSize.Text = "Размер";
            this.tsmiSize.Click += new System.EventHandler(this.tsmiSize_Click);
            // 
            // tsmiMinimize
            // 
            this.tsmiMinimize.Name = "tsmiMinimize";
            this.tsmiMinimize.Size = new System.Drawing.Size(173, 24);
            this.tsmiMinimize.Text = "Свернуть";
            this.tsmiMinimize.Click += new System.EventHandler(this.tsmiMinimize_Click);
            // 
            // tsmiMaximize
            // 
            this.tsmiMaximize.Enabled = false;
            this.tsmiMaximize.Name = "tsmiMaximize";
            this.tsmiMaximize.Size = new System.Drawing.Size(173, 24);
            this.tsmiMaximize.Text = "Развернуть";
            this.tsmiMaximize.Click += new System.EventHandler(this.tsmiMaximize_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(173, 24);
            this.tsmiExit.Text = "Закрыть";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 397);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.chkAlarm);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Будильник";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.CheckBox chkAlarm;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestore;
        private System.Windows.Forms.ToolStripMenuItem tsmiMove;
        private System.Windows.Forms.ToolStripMenuItem tsmiSize;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinimize;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaximize;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

