<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image_Upload_Interface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJewelryName = New System.Windows.Forms.TextBox()
        Me.txtJewelryType = New System.Windows.Forms.TextBox()
        Me.txtJewelryDescription = New System.Windows.Forms.TextBox()
        Me.btnAddJewelry = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.browse_Jewelry_image = New System.Windows.Forms.Button()
        Me.jewelry_image = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtJewelryLocationID = New System.Windows.Forms.ComboBox()
        Me.txtJewelryImagePath = New System.Windows.Forms.TextBox()
        CType(Me.jewelry_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(238, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(238, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(238, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(238, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Location:"
        '
        'txtJewelryName
        '
        Me.txtJewelryName.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtJewelryName.Location = New System.Drawing.Point(334, 13)
        Me.txtJewelryName.Name = "txtJewelryName"
        Me.txtJewelryName.Size = New System.Drawing.Size(258, 25)
        Me.txtJewelryName.TabIndex = 3
        '
        'txtJewelryType
        '
        Me.txtJewelryType.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtJewelryType.Location = New System.Drawing.Point(334, 62)
        Me.txtJewelryType.Name = "txtJewelryType"
        Me.txtJewelryType.Size = New System.Drawing.Size(258, 25)
        Me.txtJewelryType.TabIndex = 3
        '
        'txtJewelryDescription
        '
        Me.txtJewelryDescription.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtJewelryDescription.Location = New System.Drawing.Point(334, 115)
        Me.txtJewelryDescription.Multiline = True
        Me.txtJewelryDescription.Name = "txtJewelryDescription"
        Me.txtJewelryDescription.Size = New System.Drawing.Size(258, 80)
        Me.txtJewelryDescription.TabIndex = 3
        '
        'btnAddJewelry
        '
        Me.btnAddJewelry.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddJewelry.FlatAppearance.BorderSize = 2
        Me.btnAddJewelry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddJewelry.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnAddJewelry.Location = New System.Drawing.Point(334, 310)
        Me.btnAddJewelry.Name = "btnAddJewelry"
        Me.btnAddJewelry.Size = New System.Drawing.Size(127, 31)
        Me.btnAddJewelry.TabIndex = 1
        Me.btnAddJewelry.Text = "Save"
        Me.btnAddJewelry.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(460, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 31)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'browse_Jewelry_image
        '
        Me.browse_Jewelry_image.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.browse_Jewelry_image.FlatAppearance.BorderSize = 2
        Me.browse_Jewelry_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse_Jewelry_image.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.browse_Jewelry_image.Location = New System.Drawing.Point(12, 261)
        Me.browse_Jewelry_image.Name = "browse_Jewelry_image"
        Me.browse_Jewelry_image.Size = New System.Drawing.Size(216, 39)
        Me.browse_Jewelry_image.TabIndex = 1
        Me.browse_Jewelry_image.Text = "Browse Image"
        Me.browse_Jewelry_image.UseVisualStyleBackColor = True
        '
        'jewelry_image
        '
        Me.jewelry_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jewelry_image.Image = Global.ImageMatch_Desktop.My.Resources.Resources.upload_image_2023_04_11_023334_kxuh
        Me.jewelry_image.Location = New System.Drawing.Point(12, 12)
        Me.jewelry_image.Name = "jewelry_image"
        Me.jewelry_image.Size = New System.Drawing.Size(216, 246)
        Me.jewelry_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.jewelry_image.TabIndex = 0
        Me.jewelry_image.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 368)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(610, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtJewelryLocationID
        '
        Me.txtJewelryLocationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtJewelryLocationID.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtJewelryLocationID.FormattingEnabled = True
        Me.txtJewelryLocationID.Location = New System.Drawing.Point(334, 216)
        Me.txtJewelryLocationID.Name = "txtJewelryLocationID"
        Me.txtJewelryLocationID.Size = New System.Drawing.Size(258, 26)
        Me.txtJewelryLocationID.TabIndex = 7
        '
        'txtJewelryImagePath
        '
        Me.txtJewelryImagePath.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtJewelryImagePath.Location = New System.Drawing.Point(12, 261)
        Me.txtJewelryImagePath.Name = "txtJewelryImagePath"
        Me.txtJewelryImagePath.ReadOnly = True
        Me.txtJewelryImagePath.Size = New System.Drawing.Size(216, 25)
        Me.txtJewelryImagePath.TabIndex = 9
        '
        'Image_Upload_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(610, 390)
        Me.Controls.Add(Me.txtJewelryLocationID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtJewelryDescription)
        Me.Controls.Add(Me.txtJewelryType)
        Me.Controls.Add(Me.txtJewelryName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnAddJewelry)
        Me.Controls.Add(Me.browse_Jewelry_image)
        Me.Controls.Add(Me.jewelry_image)
        Me.Controls.Add(Me.txtJewelryImagePath)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Image_Upload_Interface"
        Me.ShowIcon = False
        Me.Text = "Image Upload Interface"
        CType(Me.jewelry_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJewelryName As TextBox
    Friend WithEvents txtJewelryType As TextBox
    Friend WithEvents txtJewelryDescription As TextBox
    Friend WithEvents btnAddJewelry As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents jewelry_image As PictureBox
    Friend WithEvents browse_Jewelry_image As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtJewelryLocationID As ComboBox
    Friend WithEvents txtJewelryImagePath As TextBox
End Class
