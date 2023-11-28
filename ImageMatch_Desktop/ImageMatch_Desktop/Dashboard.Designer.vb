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
        Me.invntory_button = New System.Windows.Forms.Button()
        Me.imageMatch_button = New System.Windows.Forms.Button()
        Me.location_button = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invntory_button
        '
        Me.invntory_button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.invntory_button.FlatAppearance.BorderSize = 2
        Me.invntory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invntory_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.invntory_button.Location = New System.Drawing.Point(12, 217)
        Me.invntory_button.Name = "invntory_button"
        Me.invntory_button.Size = New System.Drawing.Size(206, 39)
        Me.invntory_button.TabIndex = 1
        Me.invntory_button.Text = "Inventory Management"
        Me.invntory_button.UseVisualStyleBackColor = True
        '
        'imageMatch_button
        '
        Me.imageMatch_button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.imageMatch_button.FlatAppearance.BorderSize = 2
        Me.imageMatch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imageMatch_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.imageMatch_button.Location = New System.Drawing.Point(253, 217)
        Me.imageMatch_button.Name = "imageMatch_button"
        Me.imageMatch_button.Size = New System.Drawing.Size(206, 39)
        Me.imageMatch_button.TabIndex = 1
        Me.imageMatch_button.Text = "Image Match Search"
        Me.imageMatch_button.UseVisualStyleBackColor = True
        '
        'location_button
        '
        Me.location_button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.location_button.FlatAppearance.BorderSize = 2
        Me.location_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.location_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.location_button.Location = New System.Drawing.Point(493, 217)
        Me.location_button.Name = "location_button"
        Me.location_button.Size = New System.Drawing.Size(206, 39)
        Me.location_button.TabIndex = 1
        Me.location_button.Text = "Location Management"
        Me.location_button.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.ImageMatch_Desktop.My.Resources.Resources.inventory_imagematch
        Me.PictureBox3.Location = New System.Drawing.Point(493, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(206, 199)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.ImageMatch_Desktop.My.Resources.Resources.search_26236
        Me.PictureBox2.Location = New System.Drawing.Point(253, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 199)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.ImageMatch_Desktop.My.Resources.Resources._144_1445528_zoho_inventory_aftership_inventory_logo_png
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 199)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 265)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(724, 287)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.location_button)
        Me.Controls.Add(Me.imageMatch_button)
        Me.Controls.Add(Me.invntory_button)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.Text = "Main Interface"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents invntory_button As Button
    Friend WithEvents imageMatch_button As Button
    Friend WithEvents location_button As Button
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
