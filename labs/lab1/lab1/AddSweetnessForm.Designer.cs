using System.ComponentModel;

namespace lab1;

partial class AddSweetnessForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        okButton = new System.Windows.Forms.Button();
        cancelButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Location = new System.Drawing.Point(6, 12);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(504, 382);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // okButton
        // 
        okButton.Location = new System.Drawing.Point(6, 400);
        okButton.Name = "okButton";
        okButton.Size = new System.Drawing.Size(237, 42);
        okButton.TabIndex = 2;
        okButton.Text = "Ok";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += okButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new System.Drawing.Point(274, 400);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(237, 41);
        cancelButton.TabIndex = 3;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += cancelButton_Click;
        // 
        // AddSweetnessForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(520, 450);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(flowLayoutPanel1);
        Text = "AddSweetnessForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Button cancelButton;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    #endregion
}