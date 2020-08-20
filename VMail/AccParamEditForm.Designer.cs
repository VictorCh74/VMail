/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 15.07.2020
 * Time: 17:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VMail
{
	partial class AccParamEditForm 
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label accountParamLable;
		private System.Windows.Forms.DataGridView accountParamDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
		private System.Windows.Forms.DataGridViewTextBoxColumn accParamValue;
		private System.Windows.Forms.Button saveAccParamButton;
		
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
			this.accountParamLable = new System.Windows.Forms.Label();
			this.accountParamDataGridView = new System.Windows.Forms.DataGridView();
			this.saveAccParamButton = new System.Windows.Forms.Button();
			this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.accountParamDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// accountParamLable
			// 
			this.accountParamLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.accountParamLable.Location = new System.Drawing.Point(33, 13);
			this.accountParamLable.Name = "accountParamLable";
			this.accountParamLable.Size = new System.Drawing.Size(1173, 23);
			this.accountParamLable.TabIndex = 0;
			this.accountParamLable.Text = "Параметры учетной записи";
			this.accountParamLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// accountParamDataGridView
			// 
			this.accountParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.accountParamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.paramName,
			this.accParamValue});
			this.accountParamDataGridView.Location = new System.Drawing.Point(62, 52);
			this.accountParamDataGridView.Name = "accountParamDataGridView";
			this.accountParamDataGridView.Size = new System.Drawing.Size(1144, 318);
			this.accountParamDataGridView.TabIndex = 1;
			// 
			// saveAccParamButton
			// 
			this.saveAccParamButton.Location = new System.Drawing.Point(985, 438);
			this.saveAccParamButton.Name = "saveAccParamButton";
			this.saveAccParamButton.Size = new System.Drawing.Size(221, 49);
			this.saveAccParamButton.TabIndex = 2;
			this.saveAccParamButton.Text = "Сохранить";
			this.saveAccParamButton.UseVisualStyleBackColor = true;
			this.saveAccParamButton.MouseClick += SaveParam ;
			
			// 
			// paramName
			// 
			this.paramName.HeaderText = "Наименование_параметра";
			this.paramName.Name = "paramName";
			this.paramName.ToolTipText = "";
			this.paramName.Width = 500;
			// 
			// accParamValue
			// 
			this.accParamValue.HeaderText = "Значение_параметра";
			this.accParamValue.Name = "accParamValue";
			this.accParamValue.Width = 600;
			// 
			// AccParamEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(1245, 515);
			this.Controls.Add(this.saveAccParamButton);
			this.Controls.Add(this.accountParamDataGridView);
			this.Controls.Add(this.accountParamLable);
			this.Name = "AccParamEditForm";
			this.Text = "Редактирование учетной записи";
			((System.ComponentModel.ISupportInitialize)(this.accountParamDataGridView)).EndInit();
			this.ResumeLayout(false);

		}
		

	}
}
