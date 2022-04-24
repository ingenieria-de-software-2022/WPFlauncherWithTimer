namespace WPFlauncherWithTimer
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.displayedTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.circuit = new System.Windows.Forms.RadioButton();
            this.graphic = new System.Windows.Forms.RadioButton();
            this.alarm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(373, 179);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(137, 20);
            this.textBoxTime.TabIndex = 0;
            this.textBoxTime.Text = "hh:mm:ss:f-dd/MM/yyyy";
            // 
            // displayedTime
            // 
            this.displayedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.displayedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayedTime.Location = new System.Drawing.Point(278, 95);
            this.displayedTime.Name = "displayedTime";
            this.displayedTime.Size = new System.Drawing.Size(232, 49);
            this.displayedTime.TabIndex = 1;
            this.displayedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la práctica que desea abrir";
            // 
            // circuit
            // 
            this.circuit.AutoSize = true;
            this.circuit.Location = new System.Drawing.Point(26, 113);
            this.circuit.Name = "circuit";
            this.circuit.Size = new System.Drawing.Size(116, 17);
            this.circuit.TabIndex = 3;
            this.circuit.TabStop = true;
            this.circuit.Text = "Práctica de circuito";
            this.circuit.UseVisualStyleBackColor = true;
            // 
            // graphic
            // 
            this.graphic.AutoSize = true;
            this.graphic.Location = new System.Drawing.Point(26, 143);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(129, 17);
            this.graphic.TabIndex = 4;
            this.graphic.TabStop = true;
            this.graphic.Text = "Práctica de graficador";
            this.graphic.UseVisualStyleBackColor = true;
            // 
            // alarm
            // 
            this.alarm.AutoSize = true;
            this.alarm.Location = new System.Drawing.Point(26, 174);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(113, 17);
            this.alarm.TabIndex = 5;
            this.alarm.TabStop = true;
            this.alarm.Text = "Práctica de alarma";
            this.alarm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 326);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.circuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayedTime);
            this.Controls.Add(this.textBoxTime);
            this.Name = "Form1";
            this.Text = "Lanzador de aplicaciones usando timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label displayedTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton circuit;
        private System.Windows.Forms.RadioButton graphic;
        private System.Windows.Forms.RadioButton alarm;
    }
}