<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productsForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.productGridView = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.sNameTxtbx = New MetroFramework.Controls.MetroTextBox()
        Me.iPriceTxtbx = New MetroFramework.Controls.MetroTextBox()
        Me.sTypeTxtbx = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        CType(Me.productGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productGridView
        '
        Me.productGridView.AllowUserToResizeRows = False
        Me.productGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.productGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.productGridView.EnableHeadersVisualStyles = False
        Me.productGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.productGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productGridView.Location = New System.Drawing.Point(23, 77)
        Me.productGridView.Name = "productGridView"
        Me.productGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.productGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productGridView.Size = New System.Drawing.Size(439, 293)
        Me.productGridView.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(468, 194)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Name"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(468, 235)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Price"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(468, 275)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Type"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(569, 324)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = True
        '
        'sNameTxtbx
        '
        '
        '
        '
        Me.sNameTxtbx.CustomButton.Image = Nothing
        Me.sNameTxtbx.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.sNameTxtbx.CustomButton.Name = ""
        Me.sNameTxtbx.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.sNameTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.sNameTxtbx.CustomButton.TabIndex = 1
        Me.sNameTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.sNameTxtbx.CustomButton.UseSelectable = True
        Me.sNameTxtbx.CustomButton.Visible = False
        Me.sNameTxtbx.Lines = New String(-1) {}
        Me.sNameTxtbx.Location = New System.Drawing.Point(542, 194)
        Me.sNameTxtbx.MaxLength = 32767
        Me.sNameTxtbx.Name = "sNameTxtbx"
        Me.sNameTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sNameTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.sNameTxtbx.SelectedText = ""
        Me.sNameTxtbx.SelectionLength = 0
        Me.sNameTxtbx.SelectionStart = 0
        Me.sNameTxtbx.ShortcutsEnabled = True
        Me.sNameTxtbx.Size = New System.Drawing.Size(119, 23)
        Me.sNameTxtbx.TabIndex = 5
        Me.sNameTxtbx.UseSelectable = True
        Me.sNameTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.sNameTxtbx.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'iPriceTxtbx
        '
        '
        '
        '
        Me.iPriceTxtbx.CustomButton.Image = Nothing
        Me.iPriceTxtbx.CustomButton.Location = New System.Drawing.Point(80, 1)
        Me.iPriceTxtbx.CustomButton.Name = ""
        Me.iPriceTxtbx.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.iPriceTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.iPriceTxtbx.CustomButton.TabIndex = 1
        Me.iPriceTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.iPriceTxtbx.CustomButton.UseSelectable = True
        Me.iPriceTxtbx.CustomButton.Visible = False
        Me.iPriceTxtbx.Lines = New String(-1) {}
        Me.iPriceTxtbx.Location = New System.Drawing.Point(542, 235)
        Me.iPriceTxtbx.MaxLength = 32767
        Me.iPriceTxtbx.Name = "iPriceTxtbx"
        Me.iPriceTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.iPriceTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.iPriceTxtbx.SelectedText = ""
        Me.iPriceTxtbx.SelectionLength = 0
        Me.iPriceTxtbx.SelectionStart = 0
        Me.iPriceTxtbx.ShortcutsEnabled = True
        Me.iPriceTxtbx.Size = New System.Drawing.Size(102, 23)
        Me.iPriceTxtbx.TabIndex = 6
        Me.iPriceTxtbx.UseSelectable = True
        Me.iPriceTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.iPriceTxtbx.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'sTypeTxtbx
        '
        '
        '
        '
        Me.sTypeTxtbx.CustomButton.Image = Nothing
        Me.sTypeTxtbx.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.sTypeTxtbx.CustomButton.Name = ""
        Me.sTypeTxtbx.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.sTypeTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.sTypeTxtbx.CustomButton.TabIndex = 1
        Me.sTypeTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.sTypeTxtbx.CustomButton.UseSelectable = True
        Me.sTypeTxtbx.CustomButton.Visible = False
        Me.sTypeTxtbx.Lines = New String(-1) {}
        Me.sTypeTxtbx.Location = New System.Drawing.Point(542, 275)
        Me.sTypeTxtbx.MaxLength = 32767
        Me.sTypeTxtbx.Name = "sTypeTxtbx"
        Me.sTypeTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sTypeTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.sTypeTxtbx.SelectedText = ""
        Me.sTypeTxtbx.SelectionLength = 0
        Me.sTypeTxtbx.SelectionStart = 0
        Me.sTypeTxtbx.ShortcutsEnabled = True
        Me.sTypeTxtbx.Size = New System.Drawing.Size(119, 23)
        Me.sTypeTxtbx.TabIndex = 7
        Me.sTypeTxtbx.UseSelectable = True
        Me.sTypeTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.sTypeTxtbx.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(524, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(152, 25)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Register A Product"
        '
        'productsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.sTypeTxtbx)
        Me.Controls.Add(Me.iPriceTxtbx)
        Me.Controls.Add(Me.sNameTxtbx)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.productGridView)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "productsForm"
        Me.Text = "ProductsVB"
        CType(Me.productGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productGridView As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents sNameTxtbx As MetroFramework.Controls.MetroTextBox
    Friend WithEvents iPriceTxtbx As MetroFramework.Controls.MetroTextBox
    Friend WithEvents sTypeTxtbx As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
End Class
