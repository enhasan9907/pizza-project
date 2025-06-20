namespace pizza_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbPlace = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.ckbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.ckbOlives = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbTomatoes = new System.Windows.Forms.CheckBox();
            this.ckbMushrooms = new System.Windows.Forms.CheckBox();
            this.ckbExtraChees = new System.Windows.Forms.CheckBox();
            this.laPrice = new System.Windows.Forms.Label();
            this.laDolar = new System.Windows.Forms.Label();
            this.laTitel = new System.Windows.Forms.Label();
            this.laTotalPrice = new System.Windows.Forms.Label();
            this.btnOrderFinish = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbPlace.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(12, 118);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(122, 164);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(7, 108);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(64, 24);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.TabStop = true;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(7, 69);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(89, 24);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 26);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(72, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbThinkCrust);
            this.gbType.Controls.Add(this.rbThinCrust);
            this.gbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbType.ForeColor = System.Drawing.Color.White;
            this.gbType.Location = new System.Drawing.Point(12, 310);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(122, 112);
            this.gbType.TabIndex = 1;
            this.gbType.TabStop = false;
            this.gbType.Text = "Cryst Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(4, 66);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(111, 24);
            this.rbThinkCrust.TabIndex = 1;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "ThinkCrust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(6, 26);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(108, 24);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbPlace
            // 
            this.gbPlace.Controls.Add(this.rbTakeOut);
            this.gbPlace.Controls.Add(this.rbEatIn);
            this.gbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlace.ForeColor = System.Drawing.Color.White;
            this.gbPlace.Location = new System.Drawing.Point(12, 440);
            this.gbPlace.Name = "gbPlace";
            this.gbPlace.Size = new System.Drawing.Size(355, 73);
            this.gbPlace.TabIndex = 2;
            this.gbPlace.TabStop = false;
            this.gbPlace.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(202, 26);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(98, 24);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(7, 27);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(73, 24);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.ckbGreenPeppers);
            this.gbToppings.Controls.Add(this.ckbOlives);
            this.gbToppings.Controls.Add(this.ckbOnion);
            this.gbToppings.Controls.Add(this.ckbTomatoes);
            this.gbToppings.Controls.Add(this.ckbMushrooms);
            this.gbToppings.Controls.Add(this.ckbExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.White;
            this.gbToppings.Location = new System.Drawing.Point(496, 349);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(280, 164);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // ckbGreenPeppers
            // 
            this.ckbGreenPeppers.AutoSize = true;
            this.ckbGreenPeppers.ForeColor = System.Drawing.Color.White;
            this.ckbGreenPeppers.Location = new System.Drawing.Point(132, 100);
            this.ckbGreenPeppers.Name = "ckbGreenPeppers";
            this.ckbGreenPeppers.Size = new System.Drawing.Size(144, 24);
            this.ckbGreenPeppers.TabIndex = 5;
            this.ckbGreenPeppers.Text = "Green Peppers";
            this.ckbGreenPeppers.UseVisualStyleBackColor = true;
            this.ckbGreenPeppers.CheckedChanged += new System.EventHandler(this.ckbGreenPeppers_CheckedChanged);
            // 
            // ckbOlives
            // 
            this.ckbOlives.AutoSize = true;
            this.ckbOlives.ForeColor = System.Drawing.Color.White;
            this.ckbOlives.Location = new System.Drawing.Point(132, 64);
            this.ckbOlives.Name = "ckbOlives";
            this.ckbOlives.Size = new System.Drawing.Size(78, 24);
            this.ckbOlives.TabIndex = 4;
            this.ckbOlives.Text = "Olives";
            this.ckbOlives.UseVisualStyleBackColor = true;
            this.ckbOlives.CheckedChanged += new System.EventHandler(this.ckbOlives_CheckedChanged);
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.ForeColor = System.Drawing.Color.White;
            this.ckbOnion.Location = new System.Drawing.Point(132, 28);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(75, 24);
            this.ckbOnion.TabIndex = 3;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            this.ckbOnion.CheckedChanged += new System.EventHandler(this.ckbOnion_CheckedChanged);
            // 
            // ckbTomatoes
            // 
            this.ckbTomatoes.AutoSize = true;
            this.ckbTomatoes.ForeColor = System.Drawing.Color.White;
            this.ckbTomatoes.Location = new System.Drawing.Point(7, 99);
            this.ckbTomatoes.Name = "ckbTomatoes";
            this.ckbTomatoes.Size = new System.Drawing.Size(105, 24);
            this.ckbTomatoes.TabIndex = 2;
            this.ckbTomatoes.Text = "Tomatoes";
            this.ckbTomatoes.UseVisualStyleBackColor = true;
            this.ckbTomatoes.CheckedChanged += new System.EventHandler(this.ckbTomatoes_CheckedChanged);
            // 
            // ckbMushrooms
            // 
            this.ckbMushrooms.AutoSize = true;
            this.ckbMushrooms.ForeColor = System.Drawing.Color.White;
            this.ckbMushrooms.Location = new System.Drawing.Point(7, 63);
            this.ckbMushrooms.Name = "ckbMushrooms";
            this.ckbMushrooms.Size = new System.Drawing.Size(119, 24);
            this.ckbMushrooms.TabIndex = 1;
            this.ckbMushrooms.Text = "Mushrooms";
            this.ckbMushrooms.UseVisualStyleBackColor = true;
            this.ckbMushrooms.CheckedChanged += new System.EventHandler(this.ckbMushrooms_CheckedChanged);
            // 
            // ckbExtraChees
            // 
            this.ckbExtraChees.AutoSize = true;
            this.ckbExtraChees.ForeColor = System.Drawing.Color.White;
            this.ckbExtraChees.Location = new System.Drawing.Point(7, 27);
            this.ckbExtraChees.Name = "ckbExtraChees";
            this.ckbExtraChees.Size = new System.Drawing.Size(123, 24);
            this.ckbExtraChees.TabIndex = 0;
            this.ckbExtraChees.Text = "Extra Chees";
            this.ckbExtraChees.UseVisualStyleBackColor = true;
            this.ckbExtraChees.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // laPrice
            // 
            this.laPrice.AutoSize = true;
            this.laPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPrice.ForeColor = System.Drawing.Color.White;
            this.laPrice.Location = new System.Drawing.Point(936, 393);
            this.laPrice.Name = "laPrice";
            this.laPrice.Size = new System.Drawing.Size(42, 46);
            this.laPrice.TabIndex = 4;
            this.laPrice.Text = "0";
            this.laPrice.Click += new System.EventHandler(this.laPrice_Click);
            // 
            // laDolar
            // 
            this.laDolar.AutoSize = true;
            this.laDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDolar.ForeColor = System.Drawing.Color.White;
            this.laDolar.Location = new System.Drawing.Point(897, 392);
            this.laDolar.Name = "laDolar";
            this.laDolar.Size = new System.Drawing.Size(42, 46);
            this.laDolar.TabIndex = 5;
            this.laDolar.Text = "$";
            // 
            // laTitel
            // 
            this.laTitel.AutoSize = true;
            this.laTitel.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitel.ForeColor = System.Drawing.Color.Red;
            this.laTitel.Location = new System.Drawing.Point(12, 18);
            this.laTitel.Name = "laTitel";
            this.laTitel.Size = new System.Drawing.Size(374, 50);
            this.laTitel.TabIndex = 6;
            this.laTitel.Text = "Make Your Pizza";
            // 
            // laTotalPrice
            // 
            this.laTotalPrice.AutoSize = true;
            this.laTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalPrice.ForeColor = System.Drawing.Color.White;
            this.laTotalPrice.Location = new System.Drawing.Point(843, 372);
            this.laTotalPrice.Name = "laTotalPrice";
            this.laTotalPrice.Size = new System.Drawing.Size(96, 20);
            this.laTotalPrice.TabIndex = 7;
            this.laTotalPrice.Text = "Toral Price:";
            // 
            // btnOrderFinish
            // 
            this.btnOrderFinish.Location = new System.Drawing.Point(859, 449);
            this.btnOrderFinish.Name = "btnOrderFinish";
            this.btnOrderFinish.Size = new System.Drawing.Size(132, 72);
            this.btnOrderFinish.TabIndex = 8;
            this.btnOrderFinish.Text = "Order";
            this.btnOrderFinish.UseVisualStyleBackColor = true;
            this.btnOrderFinish.Click += new System.EventHandler(this.btnOrderFinish_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 541);
            this.Controls.Add(this.btnOrderFinish);
            this.Controls.Add(this.laTotalPrice);
            this.Controls.Add(this.laTitel);
            this.Controls.Add(this.laDolar);
            this.Controls.Add(this.laPrice);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbPlace);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbSize);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbPlace.ResumeLayout(false);
            this.gbPlace.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbPlace;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox ckbGreenPeppers;
        private System.Windows.Forms.CheckBox ckbOlives;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbTomatoes;
        private System.Windows.Forms.CheckBox ckbMushrooms;
        private System.Windows.Forms.CheckBox ckbExtraChees;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label laPrice;
        private System.Windows.Forms.Label laDolar;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label laTitel;
        private System.Windows.Forms.Label laTotalPrice;
        private System.Windows.Forms.Button btnOrderFinish;
    }
}