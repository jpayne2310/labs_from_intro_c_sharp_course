namespace Mid_Term
{
    partial class AnyTimePizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnyTimePizza));
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.cbRoni = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbMeatball = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbSpinach = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbSplit = new System.Windows.Forms.CheckBox();
            this.cbXCheese = new System.Windows.Forms.CheckBox();
            this.cbBBQ = new System.Windows.Forms.CheckBox();
            this.cbPineapple = new System.Windows.Forms.CheckBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.lstbTotalCost = new System.Windows.Forms.ListBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioPickup = new System.Windows.Forms.RadioButton();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.gbOrderType = new System.Windows.Forms.GroupBox();
            this.radioWalkIn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpPizza = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnClearOrders = new System.Windows.Forms.Button();
            this.gbPizzaSize.SuspendLayout();
            this.gbTopping.SuspendLayout();
            this.gbOrderType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(6, 21);
            this.radioSmall.Margin = new System.Windows.Forms.Padding(1);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(50, 17);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.CheckedChanged += new System.EventHandler(this.radioSmall_CheckedChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(61, 21);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(1);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(62, 17);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(129, 21);
            this.radioLarge.Margin = new System.Windows.Forms.Padding(1);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(52, 17);
            this.radioLarge.TabIndex = 2;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbPizzaSize.Controls.Add(this.radioSmall);
            this.gbPizzaSize.Controls.Add(this.radioLarge);
            this.gbPizzaSize.Controls.Add(this.radioMedium);
            this.gbPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.Location = new System.Drawing.Point(18, 116);
            this.gbPizzaSize.Margin = new System.Windows.Forms.Padding(1);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Padding = new System.Windows.Forms.Padding(1);
            this.gbPizzaSize.Size = new System.Drawing.Size(184, 42);
            this.gbPizzaSize.TabIndex = 3;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Pizza Size:";
            // 
            // cbRoni
            // 
            this.cbRoni.AutoSize = true;
            this.cbRoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoni.Location = new System.Drawing.Point(2, 27);
            this.cbRoni.Margin = new System.Windows.Forms.Padding(1);
            this.cbRoni.Name = "cbRoni";
            this.cbRoni.Size = new System.Drawing.Size(74, 17);
            this.cbRoni.TabIndex = 4;
            this.cbRoni.Text = "Pepperoni";
            this.cbRoni.UseVisualStyleBackColor = true;
            this.cbRoni.CheckedChanged += new System.EventHandler(this.cbRoni_CheckedChanged);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSausage.Location = new System.Drawing.Point(76, 27);
            this.cbSausage.Margin = new System.Windows.Forms.Padding(1);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(68, 17);
            this.cbSausage.TabIndex = 5;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.CheckedChanged += new System.EventHandler(this.cbSausage_CheckedChanged);
            // 
            // cbMeatball
            // 
            this.cbMeatball.AutoSize = true;
            this.cbMeatball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeatball.Location = new System.Drawing.Point(151, 27);
            this.cbMeatball.Margin = new System.Windows.Forms.Padding(1);
            this.cbMeatball.Name = "cbMeatball";
            this.cbMeatball.Size = new System.Drawing.Size(66, 17);
            this.cbMeatball.TabIndex = 6;
            this.cbMeatball.Text = "Meatball";
            this.cbMeatball.UseVisualStyleBackColor = true;
            this.cbMeatball.CheckedChanged += new System.EventHandler(this.cbMeatball_CheckedChanged);
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHam.Location = new System.Drawing.Point(225, 27);
            this.cbHam.Margin = new System.Windows.Forms.Padding(1);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(48, 17);
            this.cbHam.TabIndex = 7;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            this.cbHam.CheckedChanged += new System.EventHandler(this.cbHam_CheckedChanged);
            // 
            // cbSpinach
            // 
            this.cbSpinach.AutoSize = true;
            this.cbSpinach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpinach.Location = new System.Drawing.Point(225, 56);
            this.cbSpinach.Margin = new System.Windows.Forms.Padding(1);
            this.cbSpinach.Name = "cbSpinach";
            this.cbSpinach.Size = new System.Drawing.Size(65, 17);
            this.cbSpinach.TabIndex = 11;
            this.cbSpinach.Text = "Spinach";
            this.cbSpinach.UseVisualStyleBackColor = true;
            this.cbSpinach.CheckedChanged += new System.EventHandler(this.cbSpinach_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(151, 56);
            this.cbOlives.Margin = new System.Windows.Forms.Padding(1);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 10;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnions.Location = new System.Drawing.Point(76, 56);
            this.cbOnions.Margin = new System.Windows.Forms.Padding(1);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(59, 17);
            this.cbOnions.TabIndex = 9;
            this.cbOnions.Text = "Onions";
            this.cbOnions.UseVisualStyleBackColor = true;
            this.cbOnions.CheckedChanged += new System.EventHandler(this.cbOnions_CheckedChanged);
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeppers.Location = new System.Drawing.Point(2, 56);
            this.cbPeppers.Margin = new System.Windows.Forms.Padding(1);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(65, 17);
            this.cbPeppers.TabIndex = 8;
            this.cbPeppers.Text = "Peppers";
            this.cbPeppers.UseVisualStyleBackColor = true;
            this.cbPeppers.CheckedChanged += new System.EventHandler(this.cbPeppers_CheckedChanged);
            // 
            // cbSplit
            // 
            this.cbSplit.AutoSize = true;
            this.cbSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSplit.Location = new System.Drawing.Point(243, 86);
            this.cbSplit.Margin = new System.Windows.Forms.Padding(1);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(46, 17);
            this.cbSplit.TabIndex = 15;
            this.cbSplit.Text = "Split";
            this.cbSplit.UseVisualStyleBackColor = true;
            this.cbSplit.CheckedChanged += new System.EventHandler(this.cbSplit_CheckedChanged);
            // 
            // cbXCheese
            // 
            this.cbXCheese.AutoSize = true;
            this.cbXCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXCheese.Location = new System.Drawing.Point(158, 86);
            this.cbXCheese.Margin = new System.Windows.Forms.Padding(1);
            this.cbXCheese.Name = "cbXCheese";
            this.cbXCheese.Size = new System.Drawing.Size(84, 17);
            this.cbXCheese.TabIndex = 14;
            this.cbXCheese.Text = "Xtra Cheese";
            this.cbXCheese.UseVisualStyleBackColor = true;
            this.cbXCheese.CheckedChanged += new System.EventHandler(this.cbXCheese_CheckedChanged);
            // 
            // cbBBQ
            // 
            this.cbBBQ.AutoSize = true;
            this.cbBBQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBBQ.Location = new System.Drawing.Point(76, 86);
            this.cbBBQ.Margin = new System.Windows.Forms.Padding(1);
            this.cbBBQ.Name = "cbBBQ";
            this.cbBBQ.Size = new System.Drawing.Size(82, 17);
            this.cbBBQ.TabIndex = 13;
            this.cbBBQ.Text = "BBQ Sauce";
            this.cbBBQ.UseVisualStyleBackColor = true;
            this.cbBBQ.CheckedChanged += new System.EventHandler(this.cbBBQ_CheckedChanged);
            // 
            // cbPineapple
            // 
            this.cbPineapple.AutoSize = true;
            this.cbPineapple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPineapple.Location = new System.Drawing.Point(2, 86);
            this.cbPineapple.Margin = new System.Windows.Forms.Padding(1);
            this.cbPineapple.Name = "cbPineapple";
            this.cbPineapple.Size = new System.Drawing.Size(73, 17);
            this.cbPineapple.TabIndex = 12;
            this.cbPineapple.Text = "Pinnapple";
            this.cbPineapple.UseVisualStyleBackColor = true;
            this.cbPineapple.CheckedChanged += new System.EventHandler(this.cbPineapple_CheckedChanged);
            // 
            // gbTopping
            // 
            this.gbTopping.BackColor = System.Drawing.Color.SandyBrown;
            this.gbTopping.Controls.Add(this.cbMeatball);
            this.gbTopping.Controls.Add(this.cbSplit);
            this.gbTopping.Controls.Add(this.cbRoni);
            this.gbTopping.Controls.Add(this.cbXCheese);
            this.gbTopping.Controls.Add(this.cbBBQ);
            this.gbTopping.Controls.Add(this.cbSausage);
            this.gbTopping.Controls.Add(this.cbPineapple);
            this.gbTopping.Controls.Add(this.cbHam);
            this.gbTopping.Controls.Add(this.cbOlives);
            this.gbTopping.Controls.Add(this.cbSpinach);
            this.gbTopping.Controls.Add(this.cbPeppers);
            this.gbTopping.Controls.Add(this.cbOnions);
            this.gbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTopping.Location = new System.Drawing.Point(18, 172);
            this.gbTopping.Margin = new System.Windows.Forms.Padding(1);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Padding = new System.Windows.Forms.Padding(1);
            this.gbTopping.Size = new System.Drawing.Size(294, 123);
            this.gbTopping.TabIndex = 16;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Pizza Toppings";
            // 
            // lstbTotalCost
            // 
            this.lstbTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbTotalCost.FormattingEnabled = true;
            this.lstbTotalCost.HorizontalScrollbar = true;
            this.lstbTotalCost.Location = new System.Drawing.Point(423, 37);
            this.lstbTotalCost.Margin = new System.Windows.Forms.Padding(1);
            this.lstbTotalCost.Name = "lstbTotalCost";
            this.lstbTotalCost.Size = new System.Drawing.Size(294, 628);
            this.lstbTotalCost.TabIndex = 16;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Location = new System.Drawing.Point(98, 358);
            this.lblCustomerInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(106, 13);
            this.lblCustomerInfo.TabIndex = 17;
            this.lblCustomerInfo.Text = "Customer Information";
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtFname.Location = new System.Drawing.Point(82, 378);
            this.txtFname.Margin = new System.Windows.Forms.Padding(1);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(137, 20);
            this.txtFname.TabIndex = 26;
            this.txtFname.Text = "James";
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtLname.Location = new System.Drawing.Point(82, 410);
            this.txtLname.Margin = new System.Windows.Forms.Padding(1);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(137, 20);
            this.txtLname.TabIndex = 27;
            this.txtLname.Text = "Payne";
            // 
            // txtStreet1
            // 
            this.txtStreet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtStreet1.Location = new System.Drawing.Point(82, 443);
            this.txtStreet1.Margin = new System.Windows.Forms.Padding(1);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(137, 20);
            this.txtStreet1.TabIndex = 28;
            this.txtStreet1.Text = "23 Boulevard Ave";
            // 
            // txtStreet2
            // 
            this.txtStreet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtStreet2.Location = new System.Drawing.Point(82, 476);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(1);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(137, 20);
            this.txtStreet2.TabIndex = 29;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPhone.Location = new System.Drawing.Point(82, 574);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(1);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(137, 20);
            this.txtPhone.TabIndex = 30;
            this.txtPhone.Text = "555-5555";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtEmail.Location = new System.Drawing.Point(82, 607);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Text = "jpayne2310@hotmail.com";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(82, 508);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(1);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(137, 21);
            this.cmbCity.TabIndex = 32;
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(82, 540);
            this.cmbState.Margin = new System.Windows.Forms.Padding(1);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(137, 21);
            this.cmbState.TabIndex = 33;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(243, 378);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(167, 31);
            this.btnPlaceOrder.TabIndex = 34;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.Red;
            this.btnClearForm.Location = new System.Drawing.Point(271, 308);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(80, 31);
            this.btnClearForm.TabIndex = 35;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(243, 520);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(159, 107);
            this.txtFeedback.TabIndex = 36;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(5, 379);
            this.lblFName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(73, 16);
            this.lblFName.TabIndex = 18;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(5, 411);
            this.lblLName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(70, 15);
            this.lblLName.TabIndex = 19;
            this.lblLName.Text = "Last Name ";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStreet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet1.Location = new System.Drawing.Point(5, 444);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(70, 15);
            this.lblStreet1.TabIndex = 20;
            this.lblStreet1.Text = "    Street1    ";
            this.lblStreet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet2.Location = new System.Drawing.Point(5, 480);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(70, 15);
            this.lblStreet2.TabIndex = 21;
            this.lblStreet2.Text = "   Street2     ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(5, 510);
            this.lblCity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(71, 15);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "        City       ";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(5, 541);
            this.lbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 15);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "      State      ";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(5, 575);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 15);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "      Phone   ";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(5, 608);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 15);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "      Email     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Anytime Pizza";
            // 
            // radioPickup
            // 
            this.radioPickup.AutoSize = true;
            this.radioPickup.Location = new System.Drawing.Point(2, 19);
            this.radioPickup.Name = "radioPickup";
            this.radioPickup.Size = new System.Drawing.Size(58, 17);
            this.radioPickup.TabIndex = 38;
            this.radioPickup.TabStop = true;
            this.radioPickup.Text = "Pickup";
            this.radioPickup.UseVisualStyleBackColor = true;
            this.radioPickup.CheckedChanged += new System.EventHandler(this.radioPickup_CheckedChanged);
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.Location = new System.Drawing.Point(61, 19);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.Size = new System.Drawing.Size(63, 17);
            this.radioDelivery.TabIndex = 39;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "Delivery";
            this.radioDelivery.UseVisualStyleBackColor = true;
            this.radioDelivery.CheckedChanged += new System.EventHandler(this.radioDelivery_CheckedChanged);
            // 
            // gbOrderType
            // 
            this.gbOrderType.BackColor = System.Drawing.Color.SandyBrown;
            this.gbOrderType.Controls.Add(this.radioWalkIn);
            this.gbOrderType.Controls.Add(this.radioPickup);
            this.gbOrderType.Controls.Add(this.radioDelivery);
            this.gbOrderType.Location = new System.Drawing.Point(18, 62);
            this.gbOrderType.Name = "gbOrderType";
            this.gbOrderType.Size = new System.Drawing.Size(184, 42);
            this.gbOrderType.TabIndex = 40;
            this.gbOrderType.TabStop = false;
            this.gbOrderType.Text = "Order Type";
            // 
            // radioWalkIn
            // 
            this.radioWalkIn.AutoSize = true;
            this.radioWalkIn.Location = new System.Drawing.Point(119, 19);
            this.radioWalkIn.Name = "radioWalkIn";
            this.radioWalkIn.Size = new System.Drawing.Size(62, 17);
            this.radioWalkIn.TabIndex = 41;
            this.radioWalkIn.TabStop = true;
            this.radioWalkIn.Text = "Walk In";
            this.radioWalkIn.UseVisualStyleBackColor = true;
            this.radioWalkIn.CheckedChanged += new System.EventHandler(this.radioWalkIn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mid_Term.Properties.Resources.pizzeria_pizza_wall_clock12tyrThis61;
            this.pictureBox1.Location = new System.Drawing.Point(243, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 127);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // dtpPizza
            // 
            this.dtpPizza.Location = new System.Drawing.Point(11, 11);
            this.dtpPizza.Name = "dtpPizza";
            this.dtpPizza.Size = new System.Drawing.Size(200, 20);
            this.dtpPizza.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.dtpPizza);
            this.groupBox1.Location = new System.Drawing.Point(18, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 37);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Date and Time";
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.Black;
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveOrder.Location = new System.Drawing.Point(243, 476);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(167, 31);
            this.btnRemoveOrder.TabIndex = 44;
            this.btnRemoveOrder.Text = "Remove First Displayed Pizza";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.BackColor = System.Drawing.Color.Cyan;
            this.btnAddPizza.Location = new System.Drawing.Point(243, 428);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(167, 31);
            this.btnAddPizza.TabIndex = 45;
            this.btnAddPizza.Text = "Add Another Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = false;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // btnClearOrders
            // 
            this.btnClearOrders.Location = new System.Drawing.Point(486, 669);
            this.btnClearOrders.Name = "btnClearOrders";
            this.btnClearOrders.Size = new System.Drawing.Size(167, 31);
            this.btnClearOrders.TabIndex = 46;
            this.btnClearOrders.Text = "Clear All Orders";
            this.btnClearOrders.UseVisualStyleBackColor = true;
            this.btnClearOrders.Click += new System.EventHandler(this.btnClearOrders_Click);
            // 
            // AnyTimePizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(744, 723);
            this.Controls.Add(this.btnClearOrders);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbOrderType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lstbTotalCost);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbPizzaSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AnyTimePizza";
            this.Text = "AnyTimePizza";
            this.Load += new System.EventHandler(this.AnyTimePizza_Load);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbOrderType.ResumeLayout(false);
            this.gbOrderType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.CheckBox cbRoni;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbMeatball;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.CheckBox cbSpinach;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.CheckBox cbSplit;
        private System.Windows.Forms.CheckBox cbXCheese;
        private System.Windows.Forms.CheckBox cbBBQ;
        private System.Windows.Forms.CheckBox cbPineapple;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.ListBox lstbTotalCost;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioPickup;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.GroupBox gbOrderType;
        private System.Windows.Forms.RadioButton radioWalkIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnClearOrders;
    }
}

