namespace lab1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ElementPanel = new System.Windows.Forms.FlowLayoutPanel();
        CountLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // ElementPanel
        // 
        ElementPanel.AutoScroll = true;
        ElementPanel.Location = new System.Drawing.Point(36, 48);
        ElementPanel.Name = "ElementPanel";
        ElementPanel.Size = new System.Drawing.Size(853, 437);
        ElementPanel.TabIndex = 0;
        ElementPanel.WrapContents = false;
        // 
        // CountLabel
        // 
        CountLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        CountLabel.Location = new System.Drawing.Point(382, 4);
        CountLabel.Name = "CountLabel";
        CountLabel.Size = new System.Drawing.Size(150, 41);
        CountLabel.TabIndex = 1;
        CountLabel.Text = "0";
        CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(923, 648);
        Controls.Add(CountLabel);
        Controls.Add(ElementPanel);
        Text = "Some interesting stuff";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label CountLabel;

    private System.Windows.Forms.FlowLayoutPanel ElementPanel;

    #endregion
}