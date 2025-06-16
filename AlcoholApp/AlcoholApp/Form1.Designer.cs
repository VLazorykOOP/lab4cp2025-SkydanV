namespace AlcoholApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1341, 567);
            dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(320, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Пошук";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(440, 12);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(130, 28);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Замовити";
            btnOrder.Click += btnOrder_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1350, 593);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnOrder);
            Name = "Form1";
            Text = "AlcoholApp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
