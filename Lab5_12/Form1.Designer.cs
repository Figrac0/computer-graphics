namespace Lab5_7
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rGroupBox = new System.Windows.Forms.GroupBox();
            this.rzTrackBar = new System.Windows.Forms.TrackBar();
            this.ryTrackBar = new System.Windows.Forms.TrackBar();
            this.rxTrackBar = new System.Windows.Forms.TrackBar();
            this.rzLabel = new System.Windows.Forms.Label();
            this.ryLabel = new System.Windows.Forms.Label();
            this.rxLabel = new System.Windows.Forms.Label();
            this.ofTroupBox = new System.Windows.Forms.GroupBox();
            this.ofzTrackBar = new System.Windows.Forms.TrackBar();
            this.ofyTrackBar = new System.Windows.Forms.TrackBar();
            this.ofxTrackBar = new System.Windows.Forms.TrackBar();
            this.ofzLabel = new System.Windows.Forms.Label();
            this.ofyLabel = new System.Windows.Forms.Label();
            this.ofxLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.rGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rzTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rxTrackBar)).BeginInit();
            this.ofTroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofzTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1070, 636);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // rGroupBox
            // 
            this.rGroupBox.Controls.Add(this.rzTrackBar);
            this.rGroupBox.Controls.Add(this.ryTrackBar);
            this.rGroupBox.Controls.Add(this.rxTrackBar);
            this.rGroupBox.Controls.Add(this.rzLabel);
            this.rGroupBox.Controls.Add(this.ryLabel);
            this.rGroupBox.Controls.Add(this.rxLabel);
            this.rGroupBox.Location = new System.Drawing.Point(1091, 273);
            this.rGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.rGroupBox.Name = "rGroupBox";
            this.rGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.rGroupBox.Size = new System.Drawing.Size(245, 251);
            this.rGroupBox.TabIndex = 1;
            this.rGroupBox.TabStop = false;
            this.rGroupBox.Text = "Повороты";
            // 
            // rzTrackBar
            // 
            this.rzTrackBar.Location = new System.Drawing.Point(9, 193);
            this.rzTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.rzTrackBar.Maximum = 360;
            this.rzTrackBar.Name = "rzTrackBar";
            this.rzTrackBar.Size = new System.Drawing.Size(228, 56);
            this.rzTrackBar.TabIndex = 1;
            // 
            // ryTrackBar
            // 
            this.ryTrackBar.Location = new System.Drawing.Point(9, 119);
            this.ryTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ryTrackBar.Maximum = 360;
            this.ryTrackBar.Name = "ryTrackBar";
            this.ryTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ryTrackBar.TabIndex = 1;
            // 
            // rxTrackBar
            // 
            this.rxTrackBar.Location = new System.Drawing.Point(9, 46);
            this.rxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.rxTrackBar.Maximum = 360;
            this.rxTrackBar.Name = "rxTrackBar";
            this.rxTrackBar.Size = new System.Drawing.Size(228, 56);
            this.rxTrackBar.TabIndex = 1;
            // 
            // rzLabel
            // 
            this.rzLabel.AutoSize = true;
            this.rzLabel.Location = new System.Drawing.Point(9, 172);
            this.rzLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rzLabel.Name = "rzLabel";
            this.rzLabel.Size = new System.Drawing.Size(62, 16);
            this.rzLabel.TabIndex = 0;
            this.rzLabel.Text = "По оси Z";
            // 
            // ryLabel
            // 
            this.ryLabel.AutoSize = true;
            this.ryLabel.Location = new System.Drawing.Point(9, 98);
            this.ryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ryLabel.Name = "ryLabel";
            this.ryLabel.Size = new System.Drawing.Size(63, 16);
            this.ryLabel.TabIndex = 0;
            this.ryLabel.Text = "По оси Y";
            // 
            // rxLabel
            // 
            this.rxLabel.AutoSize = true;
            this.rxLabel.Location = new System.Drawing.Point(9, 25);
            this.rxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rxLabel.Name = "rxLabel";
            this.rxLabel.Size = new System.Drawing.Size(62, 16);
            this.rxLabel.TabIndex = 0;
            this.rxLabel.Text = "По оси X";
            // 
            // ofTroupBox
            // 
            this.ofTroupBox.Controls.Add(this.ofzTrackBar);
            this.ofTroupBox.Controls.Add(this.ofyTrackBar);
            this.ofTroupBox.Controls.Add(this.ofxTrackBar);
            this.ofTroupBox.Controls.Add(this.ofzLabel);
            this.ofTroupBox.Controls.Add(this.ofyLabel);
            this.ofTroupBox.Controls.Add(this.ofxLabel);
            this.ofTroupBox.Location = new System.Drawing.Point(1091, 13);
            this.ofTroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ofTroupBox.Name = "ofTroupBox";
            this.ofTroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ofTroupBox.Size = new System.Drawing.Size(245, 250);
            this.ofTroupBox.TabIndex = 1;
            this.ofTroupBox.TabStop = false;
            this.ofTroupBox.Text = "Перемещение";
            // 
            // ofzTrackBar
            // 
            this.ofzTrackBar.Location = new System.Drawing.Point(9, 193);
            this.ofzTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofzTrackBar.Name = "ofzTrackBar";
            this.ofzTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofzTrackBar.TabIndex = 1;
            // 
            // ofyTrackBar
            // 
            this.ofyTrackBar.Location = new System.Drawing.Point(9, 119);
            this.ofyTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofyTrackBar.Name = "ofyTrackBar";
            this.ofyTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofyTrackBar.TabIndex = 1;
            // 
            // ofxTrackBar
            // 
            this.ofxTrackBar.Location = new System.Drawing.Point(9, 46);
            this.ofxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.ofxTrackBar.Name = "ofxTrackBar";
            this.ofxTrackBar.Size = new System.Drawing.Size(228, 56);
            this.ofxTrackBar.TabIndex = 1;
            // 
            // ofzLabel
            // 
            this.ofzLabel.AutoSize = true;
            this.ofzLabel.Location = new System.Drawing.Point(9, 172);
            this.ofzLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofzLabel.Name = "ofzLabel";
            this.ofzLabel.Size = new System.Drawing.Size(62, 16);
            this.ofzLabel.TabIndex = 0;
            this.ofzLabel.Text = "По оси Z";
            // 
            // ofyLabel
            // 
            this.ofyLabel.AutoSize = true;
            this.ofyLabel.Location = new System.Drawing.Point(9, 98);
            this.ofyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofyLabel.Name = "ofyLabel";
            this.ofyLabel.Size = new System.Drawing.Size(63, 16);
            this.ofyLabel.TabIndex = 0;
            this.ofyLabel.Text = "По оси Y";
            // 
            // ofxLabel
            // 
            this.ofxLabel.AutoSize = true;
            this.ofxLabel.Location = new System.Drawing.Point(9, 25);
            this.ofxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ofxLabel.Name = "ofxLabel";
            this.ofxLabel.Size = new System.Drawing.Size(62, 16);
            this.ofxLabel.TabIndex = 0;
            this.ofxLabel.Text = "По оси X";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sTrackBar
            // 
            this.sTrackBar.Location = new System.Drawing.Point(8, 21);
            this.sTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.sTrackBar.Maximum = 50;
            this.sTrackBar.Minimum = 20;
            this.sTrackBar.Name = "sTrackBar";
            this.sTrackBar.Size = new System.Drawing.Size(228, 56);
            this.sTrackBar.TabIndex = 2;
            this.sTrackBar.Value = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(1091, 532);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(245, 98);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Масштаб";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1096, 553);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масштаб";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ofTroupBox);
            this.Controls.Add(this.rGroupBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LR5";
            this.Load += new System.EventHandler(this.GrafikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.rGroupBox.ResumeLayout(false);
            this.rGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rzTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rxTrackBar)).EndInit();
            this.ofTroupBox.ResumeLayout(false);
            this.ofTroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofzTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox rGroupBox;
        private System.Windows.Forms.TrackBar rzTrackBar;
        private System.Windows.Forms.TrackBar ryTrackBar;
        private System.Windows.Forms.TrackBar rxTrackBar;
        private System.Windows.Forms.Label rzLabel;
        private System.Windows.Forms.Label ryLabel;
        private System.Windows.Forms.Label rxLabel;
        private System.Windows.Forms.GroupBox ofTroupBox;
        private System.Windows.Forms.TrackBar ofzTrackBar;
        private System.Windows.Forms.TrackBar ofyTrackBar;
        private System.Windows.Forms.TrackBar ofxTrackBar;
        private System.Windows.Forms.Label ofzLabel;
        private System.Windows.Forms.Label ofyLabel;
        private System.Windows.Forms.Label ofxLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar sTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

