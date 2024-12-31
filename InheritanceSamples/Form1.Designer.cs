namespace InheritanceSamples
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonAnimal = new Button();
            buttonCat = new Button();
            textBoxAnimalColor = new TextBox();
            textBoxCatColor = new TextBox();
            textBoxAnimalSmell = new TextBox();
            textBoxCatSmell = new TextBox();
            textBoxAnimalFlavor = new TextBox();
            textBoxCatFlavor = new TextBox();
            textBoxCatEar = new TextBox();
            textBoxAnimalSing = new TextBox();
            textBoxCatSing = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "色";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "匂い";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 0;
            label3.Text = "味";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 0;
            label4.Text = "耳の形";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "鳴き声";
            // 
            // buttonAnimal
            // 
            buttonAnimal.Location = new Point(110, 12);
            buttonAnimal.Name = "buttonAnimal";
            buttonAnimal.Size = new Size(100, 23);
            buttonAnimal.TabIndex = 1;
            buttonAnimal.Text = "動物クッキー";
            buttonAnimal.UseVisualStyleBackColor = true;
            buttonAnimal.Click += buttonAnimal_Click;
            // 
            // buttonCat
            // 
            buttonCat.Location = new Point(216, 12);
            buttonCat.Name = "buttonCat";
            buttonCat.Size = new Size(100, 23);
            buttonCat.TabIndex = 1;
            buttonCat.Text = "猫クッキー";
            buttonCat.UseVisualStyleBackColor = true;
            buttonCat.Click += buttonCat_Click;
            // 
            // textBoxAnimalColor
            // 
            textBoxAnimalColor.Location = new Point(110, 41);
            textBoxAnimalColor.Name = "textBoxAnimalColor";
            textBoxAnimalColor.Size = new Size(100, 23);
            textBoxAnimalColor.TabIndex = 2;
            // 
            // textBoxCatColor
            // 
            textBoxCatColor.Location = new Point(216, 41);
            textBoxCatColor.Name = "textBoxCatColor";
            textBoxCatColor.Size = new Size(100, 23);
            textBoxCatColor.TabIndex = 2;
            // 
            // textBoxAnimalSmell
            // 
            textBoxAnimalSmell.Location = new Point(110, 70);
            textBoxAnimalSmell.Name = "textBoxAnimalSmell";
            textBoxAnimalSmell.Size = new Size(100, 23);
            textBoxAnimalSmell.TabIndex = 2;
            // 
            // textBoxCatSmell
            // 
            textBoxCatSmell.Location = new Point(216, 70);
            textBoxCatSmell.Name = "textBoxCatSmell";
            textBoxCatSmell.Size = new Size(100, 23);
            textBoxCatSmell.TabIndex = 2;
            // 
            // textBoxAnimalFlavor
            // 
            textBoxAnimalFlavor.Location = new Point(110, 99);
            textBoxAnimalFlavor.Name = "textBoxAnimalFlavor";
            textBoxAnimalFlavor.Size = new Size(100, 23);
            textBoxAnimalFlavor.TabIndex = 2;
            // 
            // textBoxCatFlavor
            // 
            textBoxCatFlavor.Location = new Point(216, 99);
            textBoxCatFlavor.Name = "textBoxCatFlavor";
            textBoxCatFlavor.Size = new Size(100, 23);
            textBoxCatFlavor.TabIndex = 2;
            // 
            // textBoxCatEar
            // 
            textBoxCatEar.Location = new Point(216, 128);
            textBoxCatEar.Name = "textBoxCatEar";
            textBoxCatEar.Size = new Size(100, 23);
            textBoxCatEar.TabIndex = 2;
            // 
            // textBoxAnimalSing
            // 
            textBoxAnimalSing.Location = new Point(110, 157);
            textBoxAnimalSing.Name = "textBoxAnimalSing";
            textBoxAnimalSing.Size = new Size(100, 23);
            textBoxAnimalSing.TabIndex = 2;
            // 
            // textBoxCatSing
            // 
            textBoxCatSing.Location = new Point(216, 157);
            textBoxCatSing.Name = "textBoxCatSing";
            textBoxCatSing.Size = new Size(100, 23);
            textBoxCatSing.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 195);
            Controls.Add(textBoxCatSing);
            Controls.Add(textBoxCatEar);
            Controls.Add(textBoxCatFlavor);
            Controls.Add(textBoxCatSmell);
            Controls.Add(textBoxCatColor);
            Controls.Add(textBoxAnimalSing);
            Controls.Add(textBoxAnimalFlavor);
            Controls.Add(textBoxAnimalSmell);
            Controls.Add(textBoxAnimalColor);
            Controls.Add(buttonCat);
            Controls.Add(buttonAnimal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "継承のサンプル";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonAnimal;
        private Button buttonCat;
        private TextBox textBoxAnimalColor;
        private TextBox textBoxCatColor;
        private TextBox textBoxAnimalSmell;
        private TextBox textBoxCatSmell;
        private TextBox textBoxAnimalFlavor;
        private TextBox textBoxCatFlavor;
        private TextBox textBoxCatEar;
        private TextBox textBoxAnimalSing;
        private TextBox textBoxCatSing;
    }
}
