﻿namespace ZkManager.Forms
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.fullPath = new System.Windows.Forms.Label();
            this.newNodeName = new System.Windows.Forms.TextBox();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullPath
            // 
            this.fullPath.AutoSize = true;
            this.fullPath.Location = new System.Drawing.Point(12, 9);
            this.fullPath.Name = "fullPath";
            this.fullPath.Size = new System.Drawing.Size(0, 12);
            this.fullPath.TabIndex = 0;
            // 
            // newNodeName
            // 
            this.newNodeName.Location = new System.Drawing.Point(12, 24);
            this.newNodeName.Name = "newNodeName";
            this.newNodeName.Size = new System.Drawing.Size(125, 21);
            this.newNodeName.TabIndex = 1;
            this.newNodeName.TextChanged += new System.EventHandler(this.newNodeName_TextChanged);
            // 
            // button_Cancle
            // 
            this.button_Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancle.Location = new System.Drawing.Point(86, 50);
            this.button_Cancle.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(51, 21);
            this.button_Cancle.TabIndex = 7;
            this.button_Cancle.Text = "取消";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(11, 50);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(51, 21);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 77);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.newNodeName);
            this.Controls.Add(this.fullPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增节点";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullPath;
        private System.Windows.Forms.TextBox newNodeName;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Button button_OK;
    }
}