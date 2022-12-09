namespace billsystem
{
    partial class Items
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_item_campany_name = new System.Windows.Forms.ComboBox();
            this.cb_item_type_name = new System.Windows.Forms.ComboBox();
            this.Item_name = new System.Windows.Forms.TextBox();
            this.Seling_price = new System.Windows.Forms.TextBox();
            this.Buying_price = new System.Windows.Forms.TextBox();
            this.not1 = new System.Windows.Forms.RichTextBox();
            this.item_cancel = new System.Windows.Forms.Button();
            this.item_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_unit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items Form";
            // 
            // cb_item_campany_name
            // 
            this.cb_item_campany_name.FormattingEnabled = true;
            this.cb_item_campany_name.Location = new System.Drawing.Point(293, 122);
            this.cb_item_campany_name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_item_campany_name.Name = "cb_item_campany_name";
            this.cb_item_campany_name.Size = new System.Drawing.Size(608, 24);
            this.cb_item_campany_name.TabIndex = 1;
            this.cb_item_campany_name.SelectedIndexChanged += new System.EventHandler(this.cb_item_campany_name_SelectedIndexChanged);
            this.cb_item_campany_name.SelectionChangeCommitted += new System.EventHandler(this.item_campany_name_SelectionChangeCommitted);
            // 
            // cb_item_type_name
            // 
            this.cb_item_type_name.FormattingEnabled = true;
            this.cb_item_type_name.Location = new System.Drawing.Point(293, 155);
            this.cb_item_type_name.Margin = new System.Windows.Forms.Padding(4);
            this.cb_item_type_name.Name = "cb_item_type_name";
            this.cb_item_type_name.Size = new System.Drawing.Size(608, 24);
            this.cb_item_type_name.TabIndex = 2;
            this.cb_item_type_name.SelectedIndexChanged += new System.EventHandler(this.cb_item_type_name_SelectedIndexChanged);
            // 
            // Item_name
            // 
            this.Item_name.Location = new System.Drawing.Point(293, 190);
            this.Item_name.Margin = new System.Windows.Forms.Padding(4);
            this.Item_name.Name = "Item_name";
            this.Item_name.Size = new System.Drawing.Size(608, 22);
            this.Item_name.TabIndex = 3;
            // 
            // Seling_price
            // 
            this.Seling_price.Location = new System.Drawing.Point(293, 255);
            this.Seling_price.Margin = new System.Windows.Forms.Padding(4);
            this.Seling_price.Name = "Seling_price";
            this.Seling_price.Size = new System.Drawing.Size(608, 22);
            this.Seling_price.TabIndex = 4;
            // 
            // Buying_price
            // 
            this.Buying_price.Location = new System.Drawing.Point(293, 284);
            this.Buying_price.Margin = new System.Windows.Forms.Padding(4);
            this.Buying_price.Name = "Buying_price";
            this.Buying_price.Size = new System.Drawing.Size(608, 22);
            this.Buying_price.TabIndex = 5;
            // 
            // not1
            // 
            this.not1.Location = new System.Drawing.Point(293, 356);
            this.not1.Margin = new System.Windows.Forms.Padding(4);
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(608, 126);
            this.not1.TabIndex = 9;
            this.not1.Text = "";
            // 
            // item_cancel
            // 
            this.item_cancel.BackColor = System.Drawing.Color.Red;
            this.item_cancel.FlatAppearance.BorderSize = 0;
            this.item_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.item_cancel.Location = new System.Drawing.Point(293, 501);
            this.item_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.item_cancel.Name = "item_cancel";
            this.item_cancel.Size = new System.Drawing.Size(113, 38);
            this.item_cancel.TabIndex = 12;
            this.item_cancel.Text = "Cancel";
            this.item_cancel.UseVisualStyleBackColor = false;
            this.item_cancel.Click += new System.EventHandler(this.item_cancel_Click);
            // 
            // item_save
            // 
            this.item_save.BackColor = System.Drawing.Color.Green;
            this.item_save.FlatAppearance.BorderSize = 0;
            this.item_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.item_save.Location = new System.Drawing.Point(489, 501);
            this.item_save.Margin = new System.Windows.Forms.Padding(4);
            this.item_save.Name = "item_save";
            this.item_save.Size = new System.Drawing.Size(100, 38);
            this.item_save.TabIndex = 13;
            this.item_save.Text = "Save";
            this.item_save.UseVisualStyleBackColor = false;
            this.item_save.Click += new System.EventHandler(this.item_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Seling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buying Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nots";
            // 
            // cb_unit
            // 
            this.cb_unit.FormattingEnabled = true;
            this.cb_unit.Location = new System.Drawing.Point(293, 222);
            this.cb_unit.Margin = new System.Windows.Forms.Padding(4);
            this.cb_unit.Name = "cb_unit";
            this.cb_unit.Size = new System.Drawing.Size(608, 24);
            this.cb_unit.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Unit";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_unit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_save);
            this.Controls.Add(this.item_cancel);
            this.Controls.Add(this.not1);
            this.Controls.Add(this.Buying_price);
            this.Controls.Add(this.Seling_price);
            this.Controls.Add(this.Item_name);
            this.Controls.Add(this.cb_item_type_name);
            this.Controls.Add(this.cb_item_campany_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_item_campany_name;
        private System.Windows.Forms.ComboBox cb_item_type_name;
        private System.Windows.Forms.TextBox Item_name;
        private System.Windows.Forms.TextBox Seling_price;
        private System.Windows.Forms.TextBox Buying_price;
        private System.Windows.Forms.RichTextBox not1;
        private System.Windows.Forms.Button item_cancel;
        private System.Windows.Forms.Button item_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_unit;
        private System.Windows.Forms.Label label8;
    }
}