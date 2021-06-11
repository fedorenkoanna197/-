
namespace Fifteen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.CausesValidation = false;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(10, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 30);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Enter += new System.EventHandler(this.ButtonEnter);
			this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button2
			// 
			this.button2.CausesValidation = false;
			this.button2.Location = new System.Drawing.Point(40, 10);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 30);
			this.button2.TabIndex = 1;
			this.button2.TabStop = false;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Enter += new System.EventHandler(this.ButtonEnter);
			this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button3
			// 
			this.button3.CausesValidation = false;
			this.button3.Location = new System.Drawing.Point(70, 10);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(30, 30);
			this.button3.TabIndex = 2;
			this.button3.TabStop = false;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Enter += new System.EventHandler(this.ButtonEnter);
			this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button4
			// 
			this.button4.CausesValidation = false;
			this.button4.Location = new System.Drawing.Point(100, 10);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(30, 30);
			this.button4.TabIndex = 3;
			this.button4.TabStop = false;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Enter += new System.EventHandler(this.ButtonEnter);
			this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button5
			// 
			this.button5.CausesValidation = false;
			this.button5.Location = new System.Drawing.Point(10, 40);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(30, 30);
			this.button5.TabIndex = 4;
			this.button5.TabStop = false;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Enter += new System.EventHandler(this.ButtonEnter);
			this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button6
			// 
			this.button6.CausesValidation = false;
			this.button6.Location = new System.Drawing.Point(40, 40);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(30, 30);
			this.button6.TabIndex = 5;
			this.button6.TabStop = false;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Enter += new System.EventHandler(this.ButtonEnter);
			this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button7
			// 
			this.button7.CausesValidation = false;
			this.button7.Location = new System.Drawing.Point(70, 40);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(30, 30);
			this.button7.TabIndex = 6;
			this.button7.TabStop = false;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Enter += new System.EventHandler(this.ButtonEnter);
			this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button8
			// 
			this.button8.CausesValidation = false;
			this.button8.Location = new System.Drawing.Point(100, 40);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(30, 30);
			this.button8.TabIndex = 7;
			this.button8.TabStop = false;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Enter += new System.EventHandler(this.ButtonEnter);
			this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button9
			// 
			this.button9.CausesValidation = false;
			this.button9.Location = new System.Drawing.Point(10, 70);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(30, 30);
			this.button9.TabIndex = 8;
			this.button9.TabStop = false;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Enter += new System.EventHandler(this.ButtonEnter);
			this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button10
			// 
			this.button10.CausesValidation = false;
			this.button10.Location = new System.Drawing.Point(40, 70);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(30, 30);
			this.button10.TabIndex = 9;
			this.button10.TabStop = false;
			this.button10.Text = "10";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Enter += new System.EventHandler(this.ButtonEnter);
			this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button11
			// 
			this.button11.CausesValidation = false;
			this.button11.Location = new System.Drawing.Point(70, 70);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(30, 30);
			this.button11.TabIndex = 10;
			this.button11.TabStop = false;
			this.button11.Text = "11";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Enter += new System.EventHandler(this.ButtonEnter);
			this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button12
			// 
			this.button12.CausesValidation = false;
			this.button12.Location = new System.Drawing.Point(100, 70);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(30, 30);
			this.button12.TabIndex = 11;
			this.button12.TabStop = false;
			this.button12.Text = "12";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Enter += new System.EventHandler(this.ButtonEnter);
			this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button13
			// 
			this.button13.CausesValidation = false;
			this.button13.Location = new System.Drawing.Point(10, 100);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(30, 30);
			this.button13.TabIndex = 12;
			this.button13.TabStop = false;
			this.button13.Text = "13";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Enter += new System.EventHandler(this.ButtonEnter);
			this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button14
			// 
			this.button14.CausesValidation = false;
			this.button14.Location = new System.Drawing.Point(40, 100);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(30, 30);
			this.button14.TabIndex = 13;
			this.button14.TabStop = false;
			this.button14.Text = "14";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Enter += new System.EventHandler(this.ButtonEnter);
			this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// button15
			// 
			this.button15.CausesValidation = false;
			this.button15.Location = new System.Drawing.Point(70, 100);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(30, 30);
			this.button15.TabIndex = 14;
			this.button15.TabStop = false;
			this.button15.Text = "15";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Enter += new System.EventHandler(this.ButtonEnter);
			this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 10);
			this.label1.TabIndex = 15;
			this.label1.Text = "  ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(140, 141);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "15";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
