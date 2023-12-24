<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Invntory_button = New System.Windows.Forms.Button()
        Me.ImageMatch_button = New System.Windows.Forms.Button()
        Me.Location_button = New System.Windows.Forms.Button()
        Me.location_image_placeholder = New System.Windows.Forms.PictureBox()
        Me.match_image_placeholder = New System.Windows.Forms.PictureBox()
        Me.inventory_image_placeholder = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.location_image_placeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.match_image_placeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventory_image_placeholder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Invntory_button
        '
        Me.Invntory_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Invntory_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Invntory_button.FlatAppearance.BorderSize = 2
        Me.Invntory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Invntory_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Invntory_button.Location = New System.Drawing.Point(12, 217)
        Me.Invntory_button.Name = "Invntory_button"
        Me.Invntory_button.Size = New System.Drawing.Size(206, 39)
        Me.Invntory_button.TabIndex = 1
        Me.Invntory_button.Text = "Inventory Management"
        Me.Invntory_button.UseVisualStyleBackColor = False
        '
        'ImageMatch_button
        '
        Me.ImageMatch_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ImageMatch_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ImageMatch_button.FlatAppearance.BorderSize = 2
        Me.ImageMatch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImageMatch_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ImageMatch_button.Location = New System.Drawing.Point(253, 217)
        Me.ImageMatch_button.Name = "ImageMatch_button"
        Me.ImageMatch_button.Size = New System.Drawing.Size(206, 39)
        Me.ImageMatch_button.TabIndex = 1
        Me.ImageMatch_button.Text = "Image Match Search"
        Me.ImageMatch_button.UseVisualStyleBackColor = False
        '
        'Location_button
        '
        Me.Location_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Location_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Location_button.FlatAppearance.BorderSize = 2
        Me.Location_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Location_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Location_button.Location = New System.Drawing.Point(493, 217)
        Me.Location_button.Name = "Location_button"
        Me.Location_button.Size = New System.Drawing.Size(206, 39)
        Me.Location_button.TabIndex = 1
        Me.Location_button.Text = "Location Management"
        Me.Location_button.UseVisualStyleBackColor = False
        '
        'location_image_placeholder
        '
        Me.location_image_placeholder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.location_image_placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.location_image_placeholder.Image = Global.ImageMatch_Desktop.My.Resources.Resources.inventory_imagematch
        Me.location_image_placeholder.Location = New System.Drawing.Point(493, 12)
        Me.location_image_placeholder.Name = "location_image_placeholder"
        Me.location_image_placeholder.Size = New System.Drawing.Size(206, 199)
        Me.location_image_placeholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.location_image_placeholder.TabIndex = 0
        Me.location_image_placeholder.TabStop = False
        '
        'match_image_placeholder
        '
        Me.match_image_placeholder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.match_image_placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.match_image_placeholder.Image = Global.ImageMatch_Desktop.My.Resources.Resources.search_26236
        Me.match_image_placeholder.Location = New System.Drawing.Point(253, 12)
        Me.match_image_placeholder.Name = "match_image_placeholder"
        Me.match_image_placeholder.Size = New System.Drawing.Size(206, 199)
        Me.match_image_placeholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.match_image_placeholder.TabIndex = 0
        Me.match_image_placeholder.TabStop = False
        '
        'inventory_image_placeholder
        '
        Me.inventory_image_placeholder.BackColor = System.Drawing.Color.Transparent
        Me.inventory_image_placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inventory_image_placeholder.Image = Global.ImageMatch_Desktop.My.Resources.Resources._144_1445528_zoho_inventory_aftership_inventory_logo_png
        Me.inventory_image_placeholder.Location = New System.Drawing.Point(12, 12)
        Me.inventory_image_placeholder.Name = "inventory_image_placeholder"
        Me.inventory_image_placeholder.Size = New System.Drawing.Size(206, 199)
        Me.inventory_image_placeholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventory_image_placeholder.TabIndex = 0
        Me.inventory_image_placeholder.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 265)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(241, 17)
        Me.ToolStripStatusLabel1.Text = "ALX Portfolio Project - ImageMatch Desktop"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(724, 287)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Location_button)
        Me.Controls.Add(Me.ImageMatch_button)
        Me.Controls.Add(Me.Invntory_button)
        Me.Controls.Add(Me.location_image_placeholder)
        Me.Controls.Add(Me.match_image_placeholder)
        Me.Controls.Add(Me.inventory_image_placeholder)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.Text = "Main Interface"
        CType(Me.location_image_placeholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.match_image_placeholder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventory_image_placeholder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inventory_image_placeholder As PictureBox
    Friend WithEvents match_image_placeholder As PictureBox
    Friend WithEvents location_image_placeholder As PictureBox
    Friend WithEvents Invntory_button As Button
    Friend WithEvents ImageMatch_button As Button
    Friend WithEvents Location_button As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
