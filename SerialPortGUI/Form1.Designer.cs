namespace SerialPortGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTx = new System.Windows.Forms.TextBox();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRx = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbMessageID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPlay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFwBw = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFunctionality = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTx);
            this.groupBox1.Controls.Add(this.cmbPuertos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto";
            // 
            // txtTx
            // 
            this.txtTx.Location = new System.Drawing.Point(144, 70);
            this.txtTx.Name = "txtTx";
            this.txtTx.Size = new System.Drawing.Size(217, 20);
            this.txtTx.TabIndex = 3;
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(144, 28);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(217, 21);
            this.cmbPuertos.TabIndex = 1;
            this.cmbPuertos.Text = "COM1";
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbPuertos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puertos disponibles";
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Location = new System.Drawing.Point(155, 180);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 27);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Rx";
            // 
            // txtRx
            // 
            this.txtRx.AutoSize = true;
            this.txtRx.Location = new System.Drawing.Point(163, 204);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(0, 13);
            this.txtRx.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbMessageID
            // 
            this.cmbMessageID.FormattingEnabled = true;
            this.cmbMessageID.Location = new System.Drawing.Point(155, 25);
            this.cmbMessageID.Name = "cmbMessageID";
            this.cmbMessageID.Size = new System.Drawing.Size(121, 21);
            this.cmbMessageID.TabIndex = 1;
            this.cmbMessageID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbMessageID_MouseClick);
            this.cmbMessageID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbMessageID_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPlay);
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbFwBw);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbFunctionality);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbMessageID);
            this.groupBox2.Location = new System.Drawing.Point(442, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje";
            // 
            // cmbPlay
            // 
            this.cmbPlay.FormattingEnabled = true;
            this.cmbPlay.Location = new System.Drawing.Point(155, 137);
            this.cmbPlay.Name = "cmbPlay";
            this.cmbPlay.Size = new System.Drawing.Size(121, 21);
            this.cmbPlay.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Play";
            // 
            // cmbFwBw
            // 
            this.cmbFwBw.FormattingEnabled = true;
            this.cmbFwBw.Location = new System.Drawing.Point(155, 97);
            this.cmbFwBw.Name = "cmbFwBw";
            this.cmbFwBw.Size = new System.Drawing.Size(121, 21);
            this.cmbFwBw.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FwBw";
            // 
            // cmbFunctionality
            // 
            this.cmbFunctionality.FormattingEnabled = true;
            this.cmbFunctionality.Location = new System.Drawing.Point(155, 62);
            this.cmbFunctionality.Name = "cmbFunctionality";
            this.cmbFunctionality.Size = new System.Drawing.Size(121, 21);
            this.cmbFunctionality.TabIndex = 4;
            this.cmbFunctionality.SelectedIndexChanged += new System.EventHandler(this.cmbFunctionality_SelectedIndexChanged);
            this.cmbFunctionality.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbFunctionality_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Functionality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MessageID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRx);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtRx;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbMessageID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFunctionality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFwBw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPlay;
        private System.Windows.Forms.Label label6;
    }
}

