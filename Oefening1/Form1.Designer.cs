namespace Oefening1
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
            this.btnAddInt = new System.Windows.Forms.Button();
            this.btnRemoveInt = new System.Windows.Forms.Button();
            this.btnClearInt = new System.Windows.Forms.Button();
            this.btnCountInt = new System.Windows.Forms.Button();
            this.btnIsPresentInt = new System.Windows.Forms.Button();
            this.btnCopyInt = new System.Windows.Forms.Button();
            this.tbInputInt = new System.Windows.Forms.TextBox();
            this.tbOutputInt = new System.Windows.Forms.TextBox();
            this.tbOutputString = new System.Windows.Forms.TextBox();
            this.tbInputString = new System.Windows.Forms.TextBox();
            this.btnCopyString = new System.Windows.Forms.Button();
            this.btnIsPresentString = new System.Windows.Forms.Button();
            this.btnCountString = new System.Windows.Forms.Button();
            this.btnClearString = new System.Windows.Forms.Button();
            this.btnRemoveString = new System.Windows.Forms.Button();
            this.btnAddString = new System.Windows.Forms.Button();
            this.tbOutputClass = new System.Windows.Forms.TextBox();
            this.tbInputClass = new System.Windows.Forms.TextBox();
            this.btnCopyClass = new System.Windows.Forms.Button();
            this.btnIsPresentClass = new System.Windows.Forms.Button();
            this.btnCountClass = new System.Windows.Forms.Button();
            this.btnClearClass = new System.Windows.Forms.Button();
            this.btnRemoveClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddInt
            // 
            this.btnAddInt.Location = new System.Drawing.Point(27, 30);
            this.btnAddInt.Name = "btnAddInt";
            this.btnAddInt.Size = new System.Drawing.Size(97, 23);
            this.btnAddInt.TabIndex = 0;
            this.btnAddInt.Text = "Toevoegen int";
            this.btnAddInt.UseVisualStyleBackColor = true;
            this.btnAddInt.Click += new System.EventHandler(this.btnAddInt_Click);
            // 
            // btnRemoveInt
            // 
            this.btnRemoveInt.Location = new System.Drawing.Point(27, 74);
            this.btnRemoveInt.Name = "btnRemoveInt";
            this.btnRemoveInt.Size = new System.Drawing.Size(134, 23);
            this.btnRemoveInt.TabIndex = 1;
            this.btnRemoveInt.Text = "Haal int van de stapel";
            this.btnRemoveInt.UseVisualStyleBackColor = true;
            this.btnRemoveInt.Click += new System.EventHandler(this.btnRemoveInt_Click_1);
            // 
            // btnClearInt
            // 
            this.btnClearInt.Location = new System.Drawing.Point(27, 122);
            this.btnClearInt.Name = "btnClearInt";
            this.btnClearInt.Size = new System.Drawing.Size(160, 23);
            this.btnClearInt.TabIndex = 1;
            this.btnClearInt.Text = "Maak de int stapel leeg";
            this.btnClearInt.UseVisualStyleBackColor = true;
            this.btnClearInt.Click += new System.EventHandler(this.btnClearInt_Click);
            // 
            // btnCountInt
            // 
            this.btnCountInt.Location = new System.Drawing.Point(27, 171);
            this.btnCountInt.Name = "btnCountInt";
            this.btnCountInt.Size = new System.Drawing.Size(134, 23);
            this.btnCountInt.TabIndex = 1;
            this.btnCountInt.Text = "Grote van de int stapel";
            this.btnCountInt.UseVisualStyleBackColor = true;
            this.btnCountInt.Click += new System.EventHandler(this.btnCountInt_Click);
            // 
            // btnIsPresentInt
            // 
            this.btnIsPresentInt.Location = new System.Drawing.Point(27, 218);
            this.btnIsPresentInt.Name = "btnIsPresentInt";
            this.btnIsPresentInt.Size = new System.Drawing.Size(121, 23);
            this.btnIsPresentInt.TabIndex = 1;
            this.btnIsPresentInt.Text = "Is de int aanwezig";
            this.btnIsPresentInt.UseVisualStyleBackColor = true;
            this.btnIsPresentInt.Click += new System.EventHandler(this.btnIsPresentInt_Click);
            // 
            // btnCopyInt
            // 
            this.btnCopyInt.Location = new System.Drawing.Point(27, 267);
            this.btnCopyInt.Name = "btnCopyInt";
            this.btnCopyInt.Size = new System.Drawing.Size(75, 23);
            this.btnCopyInt.TabIndex = 1;
            this.btnCopyInt.Text = "Copy int";
            this.btnCopyInt.UseVisualStyleBackColor = true;
            this.btnCopyInt.Click += new System.EventHandler(this.btnCopyInt_Click);
            // 
            // tbInputInt
            // 
            this.tbInputInt.Location = new System.Drawing.Point(200, 31);
            this.tbInputInt.Multiline = true;
            this.tbInputInt.Name = "tbInputInt";
            this.tbInputInt.Size = new System.Drawing.Size(142, 114);
            this.tbInputInt.TabIndex = 2;
            // 
            // tbOutputInt
            // 
            this.tbOutputInt.Location = new System.Drawing.Point(200, 189);
            this.tbOutputInt.Multiline = true;
            this.tbOutputInt.Name = "tbOutputInt";
            this.tbOutputInt.Size = new System.Drawing.Size(142, 117);
            this.tbOutputInt.TabIndex = 3;
            // 
            // tbOutputString
            // 
            this.tbOutputString.Location = new System.Drawing.Point(568, 190);
            this.tbOutputString.Multiline = true;
            this.tbOutputString.Name = "tbOutputString";
            this.tbOutputString.Size = new System.Drawing.Size(142, 117);
            this.tbOutputString.TabIndex = 11;
            // 
            // tbInputString
            // 
            this.tbInputString.Location = new System.Drawing.Point(568, 32);
            this.tbInputString.Multiline = true;
            this.tbInputString.Name = "tbInputString";
            this.tbInputString.Size = new System.Drawing.Size(142, 114);
            this.tbInputString.TabIndex = 10;
            // 
            // btnCopyString
            // 
            this.btnCopyString.Location = new System.Drawing.Point(395, 268);
            this.btnCopyString.Name = "btnCopyString";
            this.btnCopyString.Size = new System.Drawing.Size(89, 23);
            this.btnCopyString.TabIndex = 5;
            this.btnCopyString.Text = "Copy string";
            this.btnCopyString.UseVisualStyleBackColor = true;
            this.btnCopyString.Click += new System.EventHandler(this.btnCopyString_Click);
            // 
            // btnIsPresentString
            // 
            this.btnIsPresentString.Location = new System.Drawing.Point(395, 219);
            this.btnIsPresentString.Name = "btnIsPresentString";
            this.btnIsPresentString.Size = new System.Drawing.Size(134, 23);
            this.btnIsPresentString.TabIndex = 6;
            this.btnIsPresentString.Text = "Is de string aanwezig";
            this.btnIsPresentString.UseVisualStyleBackColor = true;
            this.btnIsPresentString.Click += new System.EventHandler(this.btnIsPresentString_Click);
            // 
            // btnCountString
            // 
            this.btnCountString.Location = new System.Drawing.Point(395, 172);
            this.btnCountString.Name = "btnCountString";
            this.btnCountString.Size = new System.Drawing.Size(160, 23);
            this.btnCountString.TabIndex = 7;
            this.btnCountString.Text = "Grote van de string stapel";
            this.btnCountString.UseVisualStyleBackColor = true;
            this.btnCountString.Click += new System.EventHandler(this.btnCountString_Click);
            // 
            // btnClearString
            // 
            this.btnClearString.Location = new System.Drawing.Point(395, 123);
            this.btnClearString.Name = "btnClearString";
            this.btnClearString.Size = new System.Drawing.Size(160, 23);
            this.btnClearString.TabIndex = 8;
            this.btnClearString.Text = "Maak de string stapel leeg";
            this.btnClearString.UseVisualStyleBackColor = true;
            this.btnClearString.Click += new System.EventHandler(this.btnClearString_Click);
            // 
            // btnRemoveString
            // 
            this.btnRemoveString.Location = new System.Drawing.Point(395, 75);
            this.btnRemoveString.Name = "btnRemoveString";
            this.btnRemoveString.Size = new System.Drawing.Size(160, 23);
            this.btnRemoveString.TabIndex = 9;
            this.btnRemoveString.Text = "Haal string van de stapel";
            this.btnRemoveString.UseVisualStyleBackColor = true;
            this.btnRemoveString.Click += new System.EventHandler(this.btnRemoveString_Click);
            // 
            // btnAddString
            // 
            this.btnAddString.Location = new System.Drawing.Point(395, 31);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(121, 23);
            this.btnAddString.TabIndex = 4;
            this.btnAddString.Text = "Toevoegen string";
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // tbOutputClass
            // 
            this.tbOutputClass.Location = new System.Drawing.Point(956, 191);
            this.tbOutputClass.Multiline = true;
            this.tbOutputClass.Name = "tbOutputClass";
            this.tbOutputClass.Size = new System.Drawing.Size(142, 117);
            this.tbOutputClass.TabIndex = 19;
            // 
            // tbInputClass
            // 
            this.tbInputClass.Location = new System.Drawing.Point(956, 30);
            this.tbInputClass.Multiline = true;
            this.tbInputClass.Name = "tbInputClass";
            this.tbInputClass.Size = new System.Drawing.Size(142, 114);
            this.tbInputClass.TabIndex = 18;
            // 
            // btnCopyClass
            // 
            this.btnCopyClass.Location = new System.Drawing.Point(768, 269);
            this.btnCopyClass.Name = "btnCopyClass";
            this.btnCopyClass.Size = new System.Drawing.Size(130, 23);
            this.btnCopyClass.TabIndex = 13;
            this.btnCopyClass.Text = "Copy basic class";
            this.btnCopyClass.UseVisualStyleBackColor = true;
            this.btnCopyClass.Click += new System.EventHandler(this.btnCopyClass_Click);
            // 
            // btnIsPresentClass
            // 
            this.btnIsPresentClass.Location = new System.Drawing.Point(768, 220);
            this.btnIsPresentClass.Name = "btnIsPresentClass";
            this.btnIsPresentClass.Size = new System.Drawing.Size(160, 23);
            this.btnIsPresentClass.TabIndex = 14;
            this.btnIsPresentClass.Text = "Is de basic class aanwezig";
            this.btnIsPresentClass.UseVisualStyleBackColor = true;
            this.btnIsPresentClass.Click += new System.EventHandler(this.btnIsPresentClass_Click);
            // 
            // btnCountClass
            // 
            this.btnCountClass.Location = new System.Drawing.Point(768, 173);
            this.btnCountClass.Name = "btnCountClass";
            this.btnCountClass.Size = new System.Drawing.Size(181, 23);
            this.btnCountClass.TabIndex = 15;
            this.btnCountClass.Text = "Grote van de basic class stapel";
            this.btnCountClass.UseVisualStyleBackColor = true;
            this.btnCountClass.Click += new System.EventHandler(this.btnCountClass_Click);
            // 
            // btnClearClass
            // 
            this.btnClearClass.Location = new System.Drawing.Point(768, 124);
            this.btnClearClass.Name = "btnClearClass";
            this.btnClearClass.Size = new System.Drawing.Size(181, 23);
            this.btnClearClass.TabIndex = 16;
            this.btnClearClass.Text = "Maak de basic class stapel leeg";
            this.btnClearClass.UseVisualStyleBackColor = true;
            this.btnClearClass.Click += new System.EventHandler(this.btnClearClass_Click);
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.Location = new System.Drawing.Point(768, 76);
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(181, 23);
            this.btnRemoveClass.TabIndex = 17;
            this.btnRemoveClass.Text = "Haal basic class van de stapel";
            this.btnRemoveClass.UseVisualStyleBackColor = true;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(768, 32);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(139, 23);
            this.btnAddClass.TabIndex = 12;
            this.btnAddClass.Text = "Toevoegen basic class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 312);
            this.Controls.Add(this.tbOutputClass);
            this.Controls.Add(this.tbInputClass);
            this.Controls.Add(this.btnCopyClass);
            this.Controls.Add(this.btnIsPresentClass);
            this.Controls.Add(this.btnCountClass);
            this.Controls.Add(this.btnClearClass);
            this.Controls.Add(this.btnRemoveClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.tbOutputString);
            this.Controls.Add(this.tbInputString);
            this.Controls.Add(this.btnCopyString);
            this.Controls.Add(this.btnIsPresentString);
            this.Controls.Add(this.btnCountString);
            this.Controls.Add(this.btnClearString);
            this.Controls.Add(this.btnRemoveString);
            this.Controls.Add(this.btnAddString);
            this.Controls.Add(this.tbOutputInt);
            this.Controls.Add(this.tbInputInt);
            this.Controls.Add(this.btnCopyInt);
            this.Controls.Add(this.btnIsPresentInt);
            this.Controls.Add(this.btnCountInt);
            this.Controls.Add(this.btnClearInt);
            this.Controls.Add(this.btnRemoveInt);
            this.Controls.Add(this.btnAddInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddInt;
        private Button btnRemoveInt;
        private Button btnClearInt;
        private Button btnCountInt;
        private Button btnIsPresentInt;
        private Button btnCopyInt;
        private TextBox tbInputInt;
        private TextBox tbOutputInt;
        private TextBox tbOutputString;
        private TextBox tbInputString;
        private Button btnCopyString;
        private Button btnIsPresentString;
        private Button btnCountString;
        private Button btnClearString;
        private Button btnRemoveString;
        private Button btnAddString;
        private TextBox tbOutputClass;
        private TextBox tbInputClass;
        private Button btnCopyClass;
        private Button btnIsPresentClass;
        private Button btnCountClass;
        private Button btnClearClass;
        private Button btnRemoveClass;
        private Button btnAddClass;
    }
}