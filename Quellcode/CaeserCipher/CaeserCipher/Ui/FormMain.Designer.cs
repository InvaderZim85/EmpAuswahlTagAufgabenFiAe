namespace CaeserCipher.Ui;

partial class FormMain
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
        tableLayoutPanel = new TableLayoutPanel();
        groupBoxInput = new GroupBox();
        textBoxInput = new TextBox();
        groupBoxOptions = new GroupBox();
        tableLayoutPanelOptions = new TableLayoutPanel();
        labelShift = new Label();
        numericUpDownShift = new NumericUpDown();
        labelCipherType = new Label();
        panelOptions = new Panel();
        buttonChange = new Button();
        comboBoxCipherType = new ComboBox();
        labelTextType = new Label();
        comboBoxTextType = new ComboBox();
        controlAlphabet = new ControlAlphabet();
        labelDirection = new Label();
        comboBoxDirection = new ComboBox();
        groupBoxOutput = new GroupBox();
        textBoxOutput = new TextBox();
        tableLayoutPanel.SuspendLayout();
        groupBoxInput.SuspendLayout();
        groupBoxOptions.SuspendLayout();
        tableLayoutPanelOptions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownShift).BeginInit();
        panelOptions.SuspendLayout();
        groupBoxOutput.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        tableLayoutPanel.ColumnCount = 1;
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel.Controls.Add(groupBoxInput, 0, 0);
        tableLayoutPanel.Controls.Add(groupBoxOptions, 0, 1);
        tableLayoutPanel.Controls.Add(groupBoxOutput, 0, 2);
        tableLayoutPanel.Dock = DockStyle.Fill;
        tableLayoutPanel.Location = new Point(0, 0);
        tableLayoutPanel.Name = "tableLayoutPanel";
        tableLayoutPanel.Padding = new Padding(5);
        tableLayoutPanel.RowCount = 3;
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel.RowStyles.Add(new RowStyle());
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
        tableLayoutPanel.Size = new Size(1064, 729);
        tableLayoutPanel.TabIndex = 0;
        // 
        // groupBoxInput
        // 
        groupBoxInput.Controls.Add(textBoxInput);
        groupBoxInput.Dock = DockStyle.Fill;
        groupBoxInput.Location = new Point(8, 8);
        groupBoxInput.Name = "groupBoxInput";
        groupBoxInput.Size = new Size(1048, 212);
        groupBoxInput.TabIndex = 0;
        groupBoxInput.TabStop = false;
        groupBoxInput.Text = "Input";
        // 
        // textBoxInput
        // 
        textBoxInput.AcceptsReturn = true;
        textBoxInput.AcceptsTab = true;
        textBoxInput.Dock = DockStyle.Fill;
        textBoxInput.Location = new Point(3, 19);
        textBoxInput.Multiline = true;
        textBoxInput.Name = "textBoxInput";
        textBoxInput.Size = new Size(1042, 190);
        textBoxInput.TabIndex = 0;
        // 
        // groupBoxOptions
        // 
        groupBoxOptions.Controls.Add(tableLayoutPanelOptions);
        groupBoxOptions.Dock = DockStyle.Fill;
        groupBoxOptions.Location = new Point(8, 226);
        groupBoxOptions.Name = "groupBoxOptions";
        groupBoxOptions.Size = new Size(1048, 275);
        groupBoxOptions.TabIndex = 1;
        groupBoxOptions.TabStop = false;
        groupBoxOptions.Text = "Options";
        // 
        // tableLayoutPanelOptions
        // 
        tableLayoutPanelOptions.ColumnCount = 3;
        tableLayoutPanelOptions.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        tableLayoutPanelOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelOptions.Controls.Add(labelShift, 0, 0);
        tableLayoutPanelOptions.Controls.Add(numericUpDownShift, 1, 0);
        tableLayoutPanelOptions.Controls.Add(labelCipherType, 0, 4);
        tableLayoutPanelOptions.Controls.Add(panelOptions, 0, 5);
        tableLayoutPanelOptions.Controls.Add(comboBoxCipherType, 1, 4);
        tableLayoutPanelOptions.Controls.Add(labelTextType, 0, 3);
        tableLayoutPanelOptions.Controls.Add(comboBoxTextType, 1, 3);
        tableLayoutPanelOptions.Controls.Add(controlAlphabet, 0, 2);
        tableLayoutPanelOptions.Controls.Add(labelDirection, 0, 1);
        tableLayoutPanelOptions.Controls.Add(comboBoxDirection, 1, 1);
        tableLayoutPanelOptions.Dock = DockStyle.Fill;
        tableLayoutPanelOptions.Location = new Point(3, 19);
        tableLayoutPanelOptions.Name = "tableLayoutPanelOptions";
        tableLayoutPanelOptions.RowCount = 6;
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle());
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle());
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle());
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle());
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle());
        tableLayoutPanelOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanelOptions.Size = new Size(1042, 253);
        tableLayoutPanelOptions.TabIndex = 0;
        // 
        // labelShift
        // 
        labelShift.AutoSize = true;
        labelShift.Dock = DockStyle.Fill;
        labelShift.Location = new Point(3, 0);
        labelShift.Name = "labelShift";
        labelShift.Size = new Size(71, 29);
        labelShift.TabIndex = 0;
        labelShift.Text = "Shift:";
        labelShift.TextAlign = ContentAlignment.MiddleRight;
        // 
        // numericUpDownShift
        // 
        numericUpDownShift.Dock = DockStyle.Fill;
        numericUpDownShift.Location = new Point(80, 3);
        numericUpDownShift.Maximum = new decimal(new int[] { 26, 0, 0, 0 });
        numericUpDownShift.Name = "numericUpDownShift";
        numericUpDownShift.Size = new Size(194, 23);
        numericUpDownShift.TabIndex = 1;
        numericUpDownShift.ValueChanged += numericUpDownShift_ValueChanged;
        // 
        // labelCipherType
        // 
        labelCipherType.AutoSize = true;
        labelCipherType.Dock = DockStyle.Fill;
        labelCipherType.Location = new Point(3, 173);
        labelCipherType.Name = "labelCipherType";
        labelCipherType.Size = new Size(71, 29);
        labelCipherType.TabIndex = 4;
        labelCipherType.Text = "Cipher type:";
        labelCipherType.TextAlign = ContentAlignment.MiddleRight;
        // 
        // panelOptions
        // 
        tableLayoutPanelOptions.SetColumnSpan(panelOptions, 3);
        panelOptions.Controls.Add(buttonChange);
        panelOptions.Dock = DockStyle.Fill;
        panelOptions.Location = new Point(0, 202);
        panelOptions.Margin = new Padding(0);
        panelOptions.Name = "panelOptions";
        panelOptions.Size = new Size(1042, 51);
        panelOptions.TabIndex = 5;
        // 
        // buttonChange
        // 
        buttonChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonChange.Location = new Point(964, 25);
        buttonChange.Name = "buttonChange";
        buttonChange.Size = new Size(75, 23);
        buttonChange.TabIndex = 0;
        buttonChange.Text = "Go!";
        buttonChange.UseVisualStyleBackColor = true;
        buttonChange.Click += buttonChange_Click;
        // 
        // comboBoxCipherType
        // 
        comboBoxCipherType.Dock = DockStyle.Fill;
        comboBoxCipherType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCipherType.FormattingEnabled = true;
        comboBoxCipherType.Location = new Point(80, 176);
        comboBoxCipherType.Name = "comboBoxCipherType";
        comboBoxCipherType.Size = new Size(194, 23);
        comboBoxCipherType.TabIndex = 7;
        // 
        // labelTextType
        // 
        labelTextType.AutoSize = true;
        labelTextType.Dock = DockStyle.Fill;
        labelTextType.Location = new Point(3, 144);
        labelTextType.Name = "labelTextType";
        labelTextType.Size = new Size(71, 29);
        labelTextType.TabIndex = 3;
        labelTextType.Text = "Text type:";
        labelTextType.TextAlign = ContentAlignment.MiddleRight;
        // 
        // comboBoxTextType
        // 
        comboBoxTextType.Dock = DockStyle.Fill;
        comboBoxTextType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTextType.FormattingEnabled = true;
        comboBoxTextType.Location = new Point(80, 147);
        comboBoxTextType.Name = "comboBoxTextType";
        comboBoxTextType.Size = new Size(194, 23);
        comboBoxTextType.TabIndex = 6;
        // 
        // controlAlphabet
        // 
        tableLayoutPanelOptions.SetColumnSpan(controlAlphabet, 3);
        controlAlphabet.Dock = DockStyle.Fill;
        controlAlphabet.Location = new Point(3, 61);
        controlAlphabet.Name = "controlAlphabet";
        controlAlphabet.Size = new Size(1036, 80);
        controlAlphabet.TabIndex = 2;
        // 
        // labelDirection
        // 
        labelDirection.AutoSize = true;
        labelDirection.Dock = DockStyle.Fill;
        labelDirection.Location = new Point(3, 29);
        labelDirection.Name = "labelDirection";
        labelDirection.Size = new Size(71, 29);
        labelDirection.TabIndex = 8;
        labelDirection.Text = "Direction:";
        labelDirection.TextAlign = ContentAlignment.MiddleRight;
        // 
        // comboBoxDirection
        // 
        comboBoxDirection.Dock = DockStyle.Fill;
        comboBoxDirection.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxDirection.FormattingEnabled = true;
        comboBoxDirection.Location = new Point(80, 32);
        comboBoxDirection.Name = "comboBoxDirection";
        comboBoxDirection.Size = new Size(194, 23);
        comboBoxDirection.TabIndex = 9;
        comboBoxDirection.SelectedIndexChanged += comboBoxDirection_SelectedIndexChanged;
        // 
        // groupBoxOutput
        // 
        groupBoxOutput.Controls.Add(textBoxOutput);
        groupBoxOutput.Dock = DockStyle.Fill;
        groupBoxOutput.Location = new Point(8, 507);
        groupBoxOutput.Name = "groupBoxOutput";
        groupBoxOutput.Size = new Size(1048, 214);
        groupBoxOutput.TabIndex = 2;
        groupBoxOutput.TabStop = false;
        groupBoxOutput.Text = "Output";
        // 
        // textBoxOutput
        // 
        textBoxOutput.AcceptsReturn = true;
        textBoxOutput.AcceptsTab = true;
        textBoxOutput.Dock = DockStyle.Fill;
        textBoxOutput.Location = new Point(3, 19);
        textBoxOutput.Multiline = true;
        textBoxOutput.Name = "textBoxOutput";
        textBoxOutput.ReadOnly = true;
        textBoxOutput.Size = new Size(1042, 192);
        textBoxOutput.TabIndex = 0;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1064, 729);
        Controls.Add(tableLayoutPanel);
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Caeser Cipher";
        Load += FormMain_Load;
        tableLayoutPanel.ResumeLayout(false);
        groupBoxInput.ResumeLayout(false);
        groupBoxInput.PerformLayout();
        groupBoxOptions.ResumeLayout(false);
        tableLayoutPanelOptions.ResumeLayout(false);
        tableLayoutPanelOptions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownShift).EndInit();
        panelOptions.ResumeLayout(false);
        groupBoxOutput.ResumeLayout(false);
        groupBoxOutput.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel;
    private GroupBox groupBoxInput;
    private GroupBox groupBoxOptions;
    private GroupBox groupBoxOutput;
    private TableLayoutPanel tableLayoutPanelOptions;
    private Label labelShift;
    private NumericUpDown numericUpDownShift;
    private ControlAlphabet controlAlphabet;
    private Label labelTextType;
    private Label labelCipherType;
    private Panel panelOptions;
    private ComboBox comboBoxTextType;
    private ComboBox comboBoxCipherType;
    private Label labelDirection;
    private ComboBox comboBoxDirection;
    private Button buttonChange;
    private TextBox textBoxInput;
    private TextBox textBoxOutput;
}