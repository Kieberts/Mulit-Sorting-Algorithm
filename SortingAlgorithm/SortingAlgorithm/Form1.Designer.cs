namespace SortingAlgorithm
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
            this.btnSortAlge = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pcbShowArray = new System.Windows.Forms.PictureBox();
            this.pcbTestButton = new System.Windows.Forms.PictureBox();
            this.lblTestTrackBar = new System.Windows.Forms.Label();
            this.trackBarSizeArray = new System.Windows.Forms.TrackBar();
            this.BtnQuickSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTestButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeArray)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortAlge
            // 
            this.btnSortAlge.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSortAlge.Location = new System.Drawing.Point(165, 576);
            this.btnSortAlge.Name = "btnSortAlge";
            this.btnSortAlge.Size = new System.Drawing.Size(157, 35);
            this.btnSortAlge.TabIndex = 2;
            this.btnSortAlge.Text = "Sorting algorithm";
            this.btnSortAlge.UseVisualStyleBackColor = true;
            this.btnSortAlge.Click += new System.EventHandler(this.btnSortAlge_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(654, 576);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pcbShowArray
            // 
            this.pcbShowArray.Location = new System.Drawing.Point(190, 170);
            this.pcbShowArray.Name = "pcbShowArray";
            this.pcbShowArray.Size = new System.Drawing.Size(600, 400);
            this.pcbShowArray.TabIndex = 6;
            this.pcbShowArray.TabStop = false;
            this.pcbShowArray.Click += new System.EventHandler(this.pcbShowArray_Click);
            this.pcbShowArray.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbShowArray_Paint);
            // 
            // pcbTestButton
            // 
            this.pcbTestButton.Location = new System.Drawing.Point(190, 46);
            this.pcbTestButton.Name = "pcbTestButton";
            this.pcbTestButton.Size = new System.Drawing.Size(610, 85);
            this.pcbTestButton.TabIndex = 7;
            this.pcbTestButton.TabStop = false;
            // 
            // lblTestTrackBar
            // 
            this.lblTestTrackBar.AutoSize = true;
            this.lblTestTrackBar.Location = new System.Drawing.Point(46, 640);
            this.lblTestTrackBar.Name = "lblTestTrackBar";
            this.lblTestTrackBar.Size = new System.Drawing.Size(35, 13);
            this.lblTestTrackBar.TabIndex = 9;
            this.lblTestTrackBar.Text = "label1";
            // 
            // trackBarSizeArray
            // 
            this.trackBarSizeArray.Location = new System.Drawing.Point(165, 640);
            this.trackBarSizeArray.Name = "trackBarSizeArray";
            this.trackBarSizeArray.Size = new System.Drawing.Size(646, 45);
            this.trackBarSizeArray.TabIndex = 10;
            this.trackBarSizeArray.Scroll += new System.EventHandler(this.trackBarSizeArray_Scroll);
            // 
            // BtnQuickSort
            // 
            this.BtnQuickSort.Location = new System.Drawing.Point(328, 576);
            this.BtnQuickSort.Name = "BtnQuickSort";
            this.BtnQuickSort.Size = new System.Drawing.Size(157, 35);
            this.BtnQuickSort.TabIndex = 11;
            this.BtnQuickSort.Text = "Quick Sort";
            this.BtnQuickSort.UseVisualStyleBackColor = true;
            this.BtnQuickSort.Click += new System.EventHandler(this.BtnQuickSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.BtnQuickSort);
            this.Controls.Add(this.trackBarSizeArray);
            this.Controls.Add(this.lblTestTrackBar);
            this.Controls.Add(this.pcbTestButton);
            this.Controls.Add(this.pcbShowArray);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSortAlge);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbShowArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTestButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizeArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSortAlge;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pcbShowArray;
        private System.Windows.Forms.PictureBox pcbTestButton;
        private System.Windows.Forms.Label lblTestTrackBar;
        private System.Windows.Forms.TrackBar trackBarSizeArray;
        private System.Windows.Forms.Button BtnQuickSort;
    }
}

