namespace CS_REG_ContestantNumber
{
    partial class frmDataStorageConversion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpConvFrom = new System.Windows.Forms.GroupBox();
            this.txtConvertVal = new System.Windows.Forms.TextBox();
            this.rbGigabit = new System.Windows.Forms.RadioButton();
            this.rbKilobit = new System.Windows.Forms.RadioButton();
            this.rbTerabit = new System.Windows.Forms.RadioButton();
            this.rbMegabit = new System.Windows.Forms.RadioButton();
            this.rbByte = new System.Windows.Forms.RadioButton();
            this.lblConvFrom = new System.Windows.Forms.Label();
            this.grpConvTo = new System.Windows.Forms.GroupBox();
            this.txtFinalVal = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbToGiga = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbToKilo = new System.Windows.Forms.RadioButton();
            this.rbToMega = new System.Windows.Forms.RadioButton();
            this.rbToTera = new System.Windows.Forms.RadioButton();
            this.rbToByte = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.errConvertVal = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpConvFrom.SuspendLayout();
            this.grpConvTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errConvertVal)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConvFrom
            // 
            this.grpConvFrom.Controls.Add(this.txtConvertVal);
            this.grpConvFrom.Controls.Add(this.rbGigabit);
            this.grpConvFrom.Controls.Add(this.rbKilobit);
            this.grpConvFrom.Controls.Add(this.rbTerabit);
            this.grpConvFrom.Controls.Add(this.rbMegabit);
            this.grpConvFrom.Controls.Add(this.rbByte);
            this.grpConvFrom.Controls.Add(this.lblConvFrom);
            this.grpConvFrom.Location = new System.Drawing.Point(21, 40);
            this.grpConvFrom.Name = "grpConvFrom";
            this.grpConvFrom.Size = new System.Drawing.Size(382, 310);
            this.grpConvFrom.TabIndex = 0;
            this.grpConvFrom.TabStop = false;
            this.grpConvFrom.Text = "Convert From";
            // 
            // txtConvertVal
            // 
            this.txtConvertVal.Location = new System.Drawing.Point(214, 33);
            this.txtConvertVal.Name = "txtConvertVal";
            this.txtConvertVal.Size = new System.Drawing.Size(112, 23);
            this.txtConvertVal.TabIndex = 6;
            this.txtConvertVal.Validating += new System.ComponentModel.CancelEventHandler(this.txtConvertVal_Validating);
            // 
            // rbGigabit
            // 
            this.rbGigabit.AutoSize = true;
            this.rbGigabit.Location = new System.Drawing.Point(12, 223);
            this.rbGigabit.Name = "rbGigabit";
            this.rbGigabit.Size = new System.Drawing.Size(63, 19);
            this.rbGigabit.TabIndex = 5;
            this.rbGigabit.Text = "Gigabit";
            this.rbGigabit.UseVisualStyleBackColor = true;
            // 
            // rbKilobit
            // 
            this.rbKilobit.AutoSize = true;
            this.rbKilobit.Location = new System.Drawing.Point(6, 129);
            this.rbKilobit.Name = "rbKilobit";
            this.rbKilobit.Size = new System.Drawing.Size(59, 19);
            this.rbKilobit.TabIndex = 4;
            this.rbKilobit.Text = "Kilobit";
            this.rbKilobit.UseVisualStyleBackColor = true;
            // 
            // rbTerabit
            // 
            this.rbTerabit.AutoSize = true;
            this.rbTerabit.Location = new System.Drawing.Point(15, 278);
            this.rbTerabit.Name = "rbTerabit";
            this.rbTerabit.Size = new System.Drawing.Size(60, 19);
            this.rbTerabit.TabIndex = 3;
            this.rbTerabit.Text = "Terabit";
            this.rbTerabit.UseVisualStyleBackColor = true;
            // 
            // rbMegabit
            // 
            this.rbMegabit.AutoSize = true;
            this.rbMegabit.Location = new System.Drawing.Point(6, 173);
            this.rbMegabit.Name = "rbMegabit";
            this.rbMegabit.Size = new System.Drawing.Size(69, 19);
            this.rbMegabit.TabIndex = 2;
            this.rbMegabit.Text = "Megabit";
            this.rbMegabit.UseVisualStyleBackColor = true;
            // 
            // rbByte
            // 
            this.rbByte.AutoSize = true;
            this.rbByte.Checked = true;
            this.rbByte.Location = new System.Drawing.Point(6, 76);
            this.rbByte.Name = "rbByte";
            this.rbByte.Size = new System.Drawing.Size(48, 19);
            this.rbByte.TabIndex = 1;
            this.rbByte.TabStop = true;
            this.rbByte.Text = "Byte";
            this.rbByte.UseVisualStyleBackColor = true;
            // 
            // lblConvFrom
            // 
            this.lblConvFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConvFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConvFrom.Location = new System.Drawing.Point(6, 36);
            this.lblConvFrom.Name = "lblConvFrom";
            this.lblConvFrom.Size = new System.Drawing.Size(212, 37);
            this.lblConvFrom.TabIndex = 0;
            this.lblConvFrom.Text = "Enter the value to convert from then select the data size:";
            // 
            // grpConvTo
            // 
            this.grpConvTo.Controls.Add(this.txtFinalVal);
            this.grpConvTo.Controls.Add(this.btnConvert);
            this.grpConvTo.Controls.Add(this.rbToGiga);
            this.grpConvTo.Controls.Add(this.label2);
            this.grpConvTo.Controls.Add(this.rbToKilo);
            this.grpConvTo.Controls.Add(this.rbToMega);
            this.grpConvTo.Controls.Add(this.rbToTera);
            this.grpConvTo.Controls.Add(this.rbToByte);
            this.grpConvTo.Location = new System.Drawing.Point(433, 40);
            this.grpConvTo.Name = "grpConvTo";
            this.grpConvTo.Size = new System.Drawing.Size(333, 310);
            this.grpConvTo.TabIndex = 1;
            this.grpConvTo.TabStop = false;
            this.grpConvTo.Text = "Convert To";
            // 
            // txtFinalVal
            // 
            this.txtFinalVal.Location = new System.Drawing.Point(136, 160);
            this.txtFinalVal.Name = "txtFinalVal";
            this.txtFinalVal.Size = new System.Drawing.Size(172, 23);
            this.txtFinalVal.TabIndex = 7;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConvert.Location = new System.Drawing.Point(136, 112);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 23);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbToGiga
            // 
            this.rbToGiga.AutoSize = true;
            this.rbToGiga.Location = new System.Drawing.Point(16, 210);
            this.rbToGiga.Name = "rbToGiga";
            this.rbToGiga.Size = new System.Drawing.Size(63, 19);
            this.rbToGiga.TabIndex = 10;
            this.rbToGiga.Text = "Gigabit";
            this.rbToGiga.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select the data size to convert to:";
            // 
            // rbToKilo
            // 
            this.rbToKilo.AutoSize = true;
            this.rbToKilo.Location = new System.Drawing.Point(16, 116);
            this.rbToKilo.Name = "rbToKilo";
            this.rbToKilo.Size = new System.Drawing.Size(59, 19);
            this.rbToKilo.TabIndex = 9;
            this.rbToKilo.Text = "Kilobit";
            this.rbToKilo.UseVisualStyleBackColor = true;
            // 
            // rbToMega
            // 
            this.rbToMega.AutoSize = true;
            this.rbToMega.Location = new System.Drawing.Point(16, 160);
            this.rbToMega.Name = "rbToMega";
            this.rbToMega.Size = new System.Drawing.Size(69, 19);
            this.rbToMega.TabIndex = 7;
            this.rbToMega.Text = "Megabit";
            this.rbToMega.UseVisualStyleBackColor = true;
            // 
            // rbToTera
            // 
            this.rbToTera.AutoSize = true;
            this.rbToTera.Location = new System.Drawing.Point(16, 265);
            this.rbToTera.Name = "rbToTera";
            this.rbToTera.Size = new System.Drawing.Size(60, 19);
            this.rbToTera.TabIndex = 8;
            this.rbToTera.Text = "Terabit";
            this.rbToTera.UseVisualStyleBackColor = true;
            // 
            // rbToByte
            // 
            this.rbToByte.AutoSize = true;
            this.rbToByte.Checked = true;
            this.rbToByte.Location = new System.Drawing.Point(16, 63);
            this.rbToByte.Name = "rbToByte";
            this.rbToByte.Size = new System.Drawing.Size(48, 19);
            this.rbToByte.TabIndex = 6;
            this.rbToByte.TabStop = true;
            this.rbToByte.Text = "Byte";
            this.rbToByte.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(363, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // errConvertVal
            // 
            this.errConvertVal.ContainerControl = this;
            // 
            // frmDataStorageConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpConvTo);
            this.Controls.Add(this.grpConvFrom);
            this.Name = "frmDataStorageConversion";
            this.Text = "Data Storage Conversion";
            this.grpConvFrom.ResumeLayout(false);
            this.grpConvFrom.PerformLayout();
            this.grpConvTo.ResumeLayout(false);
            this.grpConvTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errConvertVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpConvFrom;
        private TextBox txtConvertVal;
        private RadioButton rbGigabit;
        private RadioButton rbKilobit;
        private RadioButton rbTerabit;
        private RadioButton rbMegabit;
        private RadioButton rbByte;
        private Label lblConvFrom;
        private GroupBox grpConvTo;
        private Button btnConvert;
        private RadioButton rbToGiga;
        private Label label2;
        private RadioButton rbToKilo;
        private RadioButton rbToMega;
        private RadioButton rbToTera;
        private RadioButton rbToByte;
        private TextBox txtFinalVal;
        private Button btnExit;
        private ErrorProvider errConvertVal;
    }
}