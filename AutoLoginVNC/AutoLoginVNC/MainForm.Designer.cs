/*
 * Created by SharpDevelop.
 * User: lucasarusiewicz
 * Date: 28/02/2018
 * Time: 15:50
 */
namespace Digitar
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_usuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_senha;
		private System.Windows.Forms.CheckBox checkBox_delay;
		private System.Windows.Forms.NumericUpDown numericUpDown_segundos;
		private System.Windows.Forms.Button button_digitar;
		private System.Windows.Forms.Label label_versao;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_usuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_senha = new System.Windows.Forms.TextBox();
			this.checkBox_delay = new System.Windows.Forms.CheckBox();
			this.numericUpDown_segundos = new System.Windows.Forms.NumericUpDown();
			this.button_digitar = new System.Windows.Forms.Button();
			this.label_versao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segundos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário";
			// 
			// textBox_usuario
			// 
			this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_usuario.Location = new System.Drawing.Point(12, 35);
			this.textBox_usuario.Name = "textBox_usuario";
			this.textBox_usuario.Size = new System.Drawing.Size(173, 26);
			this.textBox_usuario.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Senha";
			// 
			// textBox_senha
			// 
			this.textBox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_senha.Location = new System.Drawing.Point(13, 95);
			this.textBox_senha.Name = "textBox_senha";
			this.textBox_senha.PasswordChar = '●';
			this.textBox_senha.Size = new System.Drawing.Size(172, 26);
			this.textBox_senha.TabIndex = 3;
			// 
			// checkBox_delay
			// 
			this.checkBox_delay.Checked = true;
			this.checkBox_delay.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_delay.Location = new System.Drawing.Point(128, 126);
			this.checkBox_delay.Name = "checkBox_delay";
			this.checkBox_delay.Size = new System.Drawing.Size(55, 24);
			this.checkBox_delay.TabIndex = 5;
			this.checkBox_delay.Text = "Delay";
			this.checkBox_delay.UseVisualStyleBackColor = true;
			// 
			// numericUpDown_segundos
			// 
			this.numericUpDown_segundos.Location = new System.Drawing.Point(13, 128);
			this.numericUpDown_segundos.Maximum = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.numericUpDown_segundos.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDown_segundos.Name = "numericUpDown_segundos";
			this.numericUpDown_segundos.ReadOnly = true;
			this.numericUpDown_segundos.Size = new System.Drawing.Size(100, 20);
			this.numericUpDown_segundos.TabIndex = 4;
			this.numericUpDown_segundos.Value = new decimal(new int[] {
			2,
			0,
			0,
			0});
			// 
			// button_digitar
			// 
			this.button_digitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_digitar.Location = new System.Drawing.Point(12, 154);
			this.button_digitar.Name = "button_digitar";
			this.button_digitar.Size = new System.Drawing.Size(173, 60);
			this.button_digitar.TabIndex = 6;
			this.button_digitar.Text = "Digitar";
			this.button_digitar.UseVisualStyleBackColor = true;
			this.button_digitar.Click += new System.EventHandler(this.Button_digitarClick);
			// 
			// label_versao
			// 
			this.label_versao.Location = new System.Drawing.Point(163, 221);
			this.label_versao.Name = "label_versao";
			this.label_versao.Size = new System.Drawing.Size(41, 15);
			this.label_versao.TabIndex = 7;
			this.label_versao.Text = "v1.0.0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 236);
			this.Controls.Add(this.label_versao);
			this.Controls.Add(this.button_digitar);
			this.Controls.Add(this.numericUpDown_segundos);
			this.Controls.Add(this.checkBox_delay);
			this.Controls.Add(this.textBox_senha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_usuario);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(215, 275);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(215, 275);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AutoLogin VNC";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_segundos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
