
namespace POSAPPLICATION
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ThaiTea = new System.Windows.Forms.Button();
            this.Lychee = new System.Windows.Forms.Button();
            this.LemonTea = new System.Windows.Forms.Button();
            this.Chocolate = new System.Windows.Forms.Button();
            this.TaroLatte = new System.Windows.Forms.Button();
            this.KopiSusu = new System.Windows.Forms.Button();
            this.Tubruk = new System.Windows.Forms.Button();
            this.Latte = new System.Windows.Forms.Button();
            this.Cappucino = new System.Windows.Forms.Button();
            this.CaramelLatte = new System.Windows.Forms.Button();
            this.Espresso = new System.Windows.Forms.Button();
            this.Americano = new System.Windows.Forms.Button();
            this.MatchaBtn = new System.Windows.Forms.Button();
            this.VanlilaLateBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.RedVelvet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 253);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.resetBtn);
            this.panel4.Controls.Add(this.printBtn);
            this.panel4.Controls.Add(this.payBtn);
            this.panel4.Location = new System.Drawing.Point(950, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 232);
            this.panel4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(241, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove\r\nItem";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.removeBtn);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(241, 10);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(196, 95);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printBtn.Location = new System.Drawing.Point(10, 123);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(196, 95);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // payBtn
            // 
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payBtn.Location = new System.Drawing.Point(10, 10);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(196, 95);
            this.payBtn.TabIndex = 0;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lblChange);
            this.panel3.Controls.Add(this.lblCost);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(482, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 232);
            this.panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // lblChange
            // 
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(257, 156);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(173, 62);
            this.lblChange.TabIndex = 10;
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(257, 83);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(173, 62);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "0";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 62);
            this.label9.TabIndex = 7;
            this.label9.Text = "Change";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 62);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cost";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 62);
            this.label7.TabIndex = 5;
            this.label7.Text = "Method Of Peyment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblTax);
            this.panel2.Controls.Add(this.lblSubTot);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 232);
            this.panel2.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(254, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(173, 62);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(254, 83);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(173, 62);
            this.lblTax.TabIndex = 3;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTot
            // 
            this.lblSubTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTot.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTot.Location = new System.Drawing.Point(254, 10);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(173, 62);
            this.lblSubTot.TabIndex = 1;
            this.lblSubTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.RedVelvet);
            this.panel5.Controls.Add(this.ThaiTea);
            this.panel5.Controls.Add(this.Lychee);
            this.panel5.Controls.Add(this.LemonTea);
            this.panel5.Controls.Add(this.Chocolate);
            this.panel5.Controls.Add(this.TaroLatte);
            this.panel5.Controls.Add(this.KopiSusu);
            this.panel5.Controls.Add(this.Tubruk);
            this.panel5.Controls.Add(this.Latte);
            this.panel5.Controls.Add(this.Cappucino);
            this.panel5.Controls.Add(this.CaramelLatte);
            this.panel5.Controls.Add(this.Espresso);
            this.panel5.Controls.Add(this.Americano);
            this.panel5.Controls.Add(this.MatchaBtn);
            this.panel5.Controls.Add(this.VanlilaLateBtn);
            this.panel5.Location = new System.Drawing.Point(462, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(620, 476);
            this.panel5.TabIndex = 1;
            // 
            // ThaiTea
            // 
            this.ThaiTea.Location = new System.Drawing.Point(409, 346);
            this.ThaiTea.Name = "ThaiTea";
            this.ThaiTea.Size = new System.Drawing.Size(195, 78);
            this.ThaiTea.TabIndex = 17;
            this.ThaiTea.Text = "Thai Tea\r\n15K";
            this.ThaiTea.UseVisualStyleBackColor = true;
            this.ThaiTea.Click += new System.EventHandler(this.ThaiTea_Click);
            // 
            // Lychee
            // 
            this.Lychee.Location = new System.Drawing.Point(409, 262);
            this.Lychee.Name = "Lychee";
            this.Lychee.Size = new System.Drawing.Size(195, 78);
            this.Lychee.TabIndex = 16;
            this.Lychee.Text = "Lychee Tea\r\n15K";
            this.Lychee.UseVisualStyleBackColor = true;
            this.Lychee.Click += new System.EventHandler(this.Lychee_Click);
            // 
            // LemonTea
            // 
            this.LemonTea.Location = new System.Drawing.Point(409, 178);
            this.LemonTea.Name = "LemonTea";
            this.LemonTea.Size = new System.Drawing.Size(195, 78);
            this.LemonTea.TabIndex = 15;
            this.LemonTea.Text = "Lemon Tea\r\n15K";
            this.LemonTea.UseVisualStyleBackColor = true;
            this.LemonTea.Click += new System.EventHandler(this.LemonTea_Click);
            // 
            // Chocolate
            // 
            this.Chocolate.Location = new System.Drawing.Point(409, 94);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(195, 78);
            this.Chocolate.TabIndex = 14;
            this.Chocolate.Text = "Chocolate\r\n18K";
            this.Chocolate.UseVisualStyleBackColor = true;
            this.Chocolate.Click += new System.EventHandler(this.Chocolate_Click);
            // 
            // TaroLatte
            // 
            this.TaroLatte.Location = new System.Drawing.Point(208, 346);
            this.TaroLatte.Name = "TaroLatte";
            this.TaroLatte.Size = new System.Drawing.Size(195, 78);
            this.TaroLatte.TabIndex = 13;
            this.TaroLatte.Text = "Taro Latte\r\n20K";
            this.TaroLatte.UseVisualStyleBackColor = true;
            this.TaroLatte.Click += new System.EventHandler(this.TaroLatte_Click);
            // 
            // KopiSusu
            // 
            this.KopiSusu.Location = new System.Drawing.Point(208, 262);
            this.KopiSusu.Name = "KopiSusu";
            this.KopiSusu.Size = new System.Drawing.Size(195, 78);
            this.KopiSusu.TabIndex = 12;
            this.KopiSusu.Text = "Kopi Susu\r\n18K";
            this.KopiSusu.UseVisualStyleBackColor = true;
            this.KopiSusu.Click += new System.EventHandler(this.KopiSusu_Click);
            // 
            // Tubruk
            // 
            this.Tubruk.Location = new System.Drawing.Point(208, 178);
            this.Tubruk.Name = "Tubruk";
            this.Tubruk.Size = new System.Drawing.Size(195, 78);
            this.Tubruk.TabIndex = 11;
            this.Tubruk.Text = "Kopi Tubruk\r\n15K";
            this.Tubruk.UseVisualStyleBackColor = true;
            this.Tubruk.Click += new System.EventHandler(this.Tubruk_Click);
            // 
            // Latte
            // 
            this.Latte.Location = new System.Drawing.Point(208, 94);
            this.Latte.Name = "Latte";
            this.Latte.Size = new System.Drawing.Size(195, 78);
            this.Latte.TabIndex = 10;
            this.Latte.Text = "Latte\r\n15K\r\n";
            this.Latte.UseVisualStyleBackColor = true;
            this.Latte.Click += new System.EventHandler(this.Latte_Click);
            // 
            // Cappucino
            // 
            this.Cappucino.Location = new System.Drawing.Point(208, 10);
            this.Cappucino.Name = "Cappucino";
            this.Cappucino.Size = new System.Drawing.Size(195, 78);
            this.Cappucino.TabIndex = 8;
            this.Cappucino.Text = "Cappucino\r\n15K";
            this.Cappucino.UseVisualStyleBackColor = true;
            this.Cappucino.Click += new System.EventHandler(this.Cappucino_Click);
            // 
            // CaramelLatte
            // 
            this.CaramelLatte.Location = new System.Drawing.Point(7, 346);
            this.CaramelLatte.Name = "CaramelLatte";
            this.CaramelLatte.Size = new System.Drawing.Size(195, 78);
            this.CaramelLatte.TabIndex = 7;
            this.CaramelLatte.Text = "Caramel Latte\r\n20K\r\n";
            this.CaramelLatte.UseVisualStyleBackColor = true;
            this.CaramelLatte.Click += new System.EventHandler(this.CaramelLatte_Click);
            // 
            // Espresso
            // 
            this.Espresso.Location = new System.Drawing.Point(7, 262);
            this.Espresso.Name = "Espresso";
            this.Espresso.Size = new System.Drawing.Size(195, 78);
            this.Espresso.TabIndex = 6;
            this.Espresso.Text = "Espresso\r\n15K\r\n\r\n";
            this.Espresso.UseVisualStyleBackColor = true;
            this.Espresso.Click += new System.EventHandler(this.Espresso_Click);
            // 
            // Americano
            // 
            this.Americano.Location = new System.Drawing.Point(7, 178);
            this.Americano.Name = "Americano";
            this.Americano.Size = new System.Drawing.Size(195, 78);
            this.Americano.TabIndex = 5;
            this.Americano.Text = "Americano\r\n20K";
            this.Americano.UseVisualStyleBackColor = true;
            this.Americano.Click += new System.EventHandler(this.Americano_Click);
            // 
            // MatchaBtn
            // 
            this.MatchaBtn.Location = new System.Drawing.Point(7, 94);
            this.MatchaBtn.Name = "MatchaBtn";
            this.MatchaBtn.Size = new System.Drawing.Size(195, 78);
            this.MatchaBtn.TabIndex = 4;
            this.MatchaBtn.Text = "Matcha Latte\r\n20K";
            this.MatchaBtn.UseVisualStyleBackColor = true;
            this.MatchaBtn.Click += new System.EventHandler(this.MatchaBtn_Click);
            // 
            // VanlilaLateBtn
            // 
            this.VanlilaLateBtn.Location = new System.Drawing.Point(7, 10);
            this.VanlilaLateBtn.Name = "VanlilaLateBtn";
            this.VanlilaLateBtn.Size = new System.Drawing.Size(195, 78);
            this.VanlilaLateBtn.TabIndex = 0;
            this.VanlilaLateBtn.Text = "Vanilla Latte\r\n20K";
            this.VanlilaLateBtn.UseVisualStyleBackColor = true;
            this.VanlilaLateBtn.Click += new System.EventHandler(this.VanlilaLateBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button13);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button32);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(1088, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 476);
            this.panel6.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(9, 323);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 15;
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Numbers);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(115, 323);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 14;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Numbers);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(9, 217);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 13;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Numbers);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(115, 217);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 12;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Numbers);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(115, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 11;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Numbers);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(9, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 10;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Numbers);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button32.Location = new System.Drawing.Point(-124, 5);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 100);
            this.button32.TabIndex = 9;
            this.button32.Text = "7";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(9, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numbers);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(115, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 8;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numbers);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(221, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 7;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(221, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 6;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numbers);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(221, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 5;
            this.button1.Text = "6";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numbers);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(221, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 4;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numbers);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(444, 473);
            this.dataGridView1.TabIndex = 3;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RedVelvet
            // 
            this.RedVelvet.Location = new System.Drawing.Point(409, 10);
            this.RedVelvet.Name = "RedVelvet";
            this.RedVelvet.Size = new System.Drawing.Size(195, 78);
            this.RedVelvet.TabIndex = 18;
            this.RedVelvet.Text = "Red Velvet\r\n20K";
            this.RedVelvet.UseVisualStyleBackColor = true;
            this.RedVelvet.Click += new System.EventHandler(this.RedVelvet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 757);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ThaiTea;
        private System.Windows.Forms.Button Lychee;
        private System.Windows.Forms.Button LemonTea;
        private System.Windows.Forms.Button Chocolate;
        private System.Windows.Forms.Button TaroLatte;
        private System.Windows.Forms.Button KopiSusu;
        private System.Windows.Forms.Button Tubruk;
        private System.Windows.Forms.Button Latte;
        private System.Windows.Forms.Button Cappucino;
        private System.Windows.Forms.Button CaramelLatte;
        private System.Windows.Forms.Button Espresso;
        private System.Windows.Forms.Button Americano;
        private System.Windows.Forms.Button MatchaBtn;
        private System.Windows.Forms.Button VanlilaLateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button RedVelvet;
    }
}

