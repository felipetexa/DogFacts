namespace DogFacts
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
            getRandomDogFacts = new Button();
            SuspendLayout();
            // 
            // getRandomDogFacts
            // 
            getRandomDogFacts.Location = new Point(272, 206);
            getRandomDogFacts.Name = "getRandomDogFacts";
            getRandomDogFacts.Size = new Size(252, 46);
            getRandomDogFacts.TabIndex = 0;
            getRandomDogFacts.Text = "Random Dog Facts";
            getRandomDogFacts.UseVisualStyleBackColor = true;
            getRandomDogFacts.Click += getRandomDogFacts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(getRandomDogFacts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button getRandomDogFacts;
    }
}
