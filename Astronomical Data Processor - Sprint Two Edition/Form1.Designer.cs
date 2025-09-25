namespace Astronomical_Data_Processor
{
    partial class AstroDataProcess
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lstElementDisplay = new System.Windows.Forms.ListBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIndex = new System.Windows.Forms.ListBox();
            this.txtSearchEdit = new System.Windows.Forms.TextBox();
            this.lstMeanModeMedRange = new System.Windows.Forms.ListBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(183, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Value";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChange
            // 
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Location = new System.Drawing.Point(183, 127);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(85, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change Value";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lstElementDisplay
            // 
            this.lstElementDisplay.FormattingEnabled = true;
            this.lstElementDisplay.Location = new System.Drawing.Point(25, 173);
            this.lstElementDisplay.Name = "lstElementDisplay";
            this.lstElementDisplay.Size = new System.Drawing.Size(243, 199);
            this.lstElementDisplay.TabIndex = 2;
            this.lstElementDisplay.SelectedIndexChanged += new System.EventHandler(this.lstElementDisplay_SelectedIndexChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(168, 101);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 3;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(168, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSort
            // 
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.Location = new System.Drawing.Point(25, 144);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(25, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(355, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search and Edit variable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Results";
            // 
            // lstIndex
            // 
            this.lstIndex.FormattingEnabled = true;
            this.lstIndex.Location = new System.Drawing.Point(25, 65);
            this.lstIndex.Name = "lstIndex";
            this.lstIndex.Size = new System.Drawing.Size(101, 17);
            this.lstIndex.TabIndex = 11;
            this.lstIndex.SelectedIndexChanged += new System.EventHandler(this.lstIndex_SelectedIndexChanged);
            // 
            // txtSearchEdit
            // 
            this.txtSearchEdit.BackColor = System.Drawing.Color.White;
            this.txtSearchEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearchEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEdit.Location = new System.Drawing.Point(25, 33);
            this.txtSearchEdit.Multiline = true;
            this.txtSearchEdit.Name = "txtSearchEdit";
            this.txtSearchEdit.ReadOnly = true;
            this.txtSearchEdit.Size = new System.Drawing.Size(36, 30);
            this.txtSearchEdit.TabIndex = 12;
            this.txtSearchEdit.TextChanged += new System.EventHandler(this.txtSearchEdit_TextChanged);
            // 
            // lstMeanModeMedRange
            // 
            this.lstMeanModeMedRange.FormattingEnabled = true;
            this.lstMeanModeMedRange.Location = new System.Drawing.Point(296, 187);
            this.lstMeanModeMedRange.Name = "lstMeanModeMedRange";
            this.lstMeanModeMedRange.Size = new System.Drawing.Size(123, 121);
            this.lstMeanModeMedRange.TabIndex = 13;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(296, 17);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(123, 23);
            this.btnAvg.TabIndex = 14;
            this.btnAvg.Text = "Calculate Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(296, 59);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(123, 23);
            this.btnMode.TabIndex = 15;
            this.btnMode.Text = "Calculate Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(296, 101);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(123, 23);
            this.btnMed.TabIndex = 16;
            this.btnMed.Text = "Calculate Median";
            this.btnMed.UseVisualStyleBackColor = true;
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(296, 144);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(123, 23);
            this.btnRange.TabIndex = 17;
            this.btnRange.Text = "Calculate Range";
            this.btnRange.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Clears all values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search for variable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Change variable to:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Generates values";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sorts values";
            // 
            // AstroDataProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.lstMeanModeMedRange);
            this.Controls.Add(this.txtSearchEdit);
            this.Controls.Add(this.lstIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lstElementDisplay);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSearch);
            this.Name = "AstroDataProcess";
            this.Text = "Astronomical Data Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ListBox lstElementDisplay;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIndex;
        private System.Windows.Forms.TextBox txtSearchEdit;
        private System.Windows.Forms.ListBox lstMeanModeMedRange;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

