﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Image_Matching
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.image_browse = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.find_match_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.found_images_total_in_DB = New System.Windows.Forms.Label()
        Me.find_match_worker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.progress_loading_gif = New System.Windows.Forms.PictureBox()
        Me.match_found_list = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jewelry_image = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.progress_loading_gif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.match_found_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jewelry_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image_browse
        '
        Me.image_browse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.image_browse.FlatAppearance.BorderSize = 2
        Me.image_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.image_browse.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.image_browse.Location = New System.Drawing.Point(12, 264)
        Me.image_browse.Name = "image_browse"
        Me.image_browse.Size = New System.Drawing.Size(216, 39)
        Me.image_browse.TabIndex = 3
        Me.image_browse.Text = "Browse Image"
        Me.image_browse.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1035, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'find_match_button
        '
        Me.find_match_button.BackColor = System.Drawing.Color.DarkGray
        Me.find_match_button.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.find_match_button.FlatAppearance.BorderSize = 2
        Me.find_match_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.find_match_button.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.find_match_button.Location = New System.Drawing.Point(12, 304)
        Me.find_match_button.Name = "find_match_button"
        Me.find_match_button.Size = New System.Drawing.Size(216, 39)
        Me.find_match_button.TabIndex = 3
        Me.find_match_button.Text = "Find Match"
        Me.find_match_button.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.found_images_total_in_DB)
        Me.Panel1.Location = New System.Drawing.Point(12, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 76)
        Me.Panel1.TabIndex = 46
        '
        'found_images_total_in_DB
        '
        Me.found_images_total_in_DB.BackColor = System.Drawing.Color.AliceBlue
        Me.found_images_total_in_DB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.found_images_total_in_DB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.found_images_total_in_DB.ForeColor = System.Drawing.Color.DarkRed
        Me.found_images_total_in_DB.Location = New System.Drawing.Point(0, 0)
        Me.found_images_total_in_DB.Name = "found_images_total_in_DB"
        Me.found_images_total_in_DB.Size = New System.Drawing.Size(212, 72)
        Me.found_images_total_in_DB.TabIndex = 0
        Me.found_images_total_in_DB.Text = "0000"
        Me.found_images_total_in_DB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'find_match_worker
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.progress_loading_gif)
        Me.GroupBox2.Controls.Add(Me.match_found_list)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(787, 413)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matches Found"
        '
        'progress_loading_gif
        '
        Me.progress_loading_gif.BackColor = System.Drawing.Color.Transparent
        Me.progress_loading_gif.Image = Global.ImageMatch_Desktop.My.Resources.Resources.loading24
        Me.progress_loading_gif.Location = New System.Drawing.Point(379, 202)
        Me.progress_loading_gif.Name = "progress_loading_gif"
        Me.progress_loading_gif.Size = New System.Drawing.Size(35, 33)
        Me.progress_loading_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.progress_loading_gif.TabIndex = 47
        Me.progress_loading_gif.TabStop = False
        Me.progress_loading_gif.Visible = False
        '
        'match_found_list
        '
        Me.match_found_list.AllowUserToAddRows = False
        Me.match_found_list.BackgroundColor = System.Drawing.SystemColors.Control
        Me.match_found_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.match_found_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1, Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.match_found_list.DefaultCellStyle = DataGridViewCellStyle2
        Me.match_found_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.match_found_list.GridColor = System.Drawing.SystemColors.Control
        Me.match_found_list.Location = New System.Drawing.Point(3, 16)
        Me.match_found_list.Name = "match_found_list"
        Me.match_found_list.RowHeadersVisible = False
        Me.match_found_list.Size = New System.Drawing.Size(781, 394)
        Me.match_found_list.TabIndex = 35
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Image"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Label"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Percentage"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 180
        '
        'Column4
        '
        Me.Column4.HeaderText = "Location"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 180
        '
        'jewelry_image
        '
        Me.jewelry_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jewelry_image.Image = Global.ImageMatch_Desktop.My.Resources.Resources.upload_image_2023_04_11_023334_kxuh
        Me.jewelry_image.Location = New System.Drawing.Point(12, 12)
        Me.jewelry_image.Name = "jewelry_image"
        Me.jewelry_image.Size = New System.Drawing.Size(216, 246)
        Me.jewelry_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.jewelry_image.TabIndex = 2
        Me.jewelry_image.TabStop = False
        '
        'Image_Matching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1035, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.find_match_button)
        Me.Controls.Add(Me.image_browse)
        Me.Controls.Add(Me.jewelry_image)
        Me.Name = "Image_Matching"
        Me.ShowIcon = False
        Me.Text = "Image_Matching"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.progress_loading_gif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.match_found_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jewelry_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents image_browse As Button
    Friend WithEvents jewelry_image As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents find_match_button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents found_images_total_in_DB As Label
    Friend WithEvents find_match_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents progress_loading_gif As PictureBox
    Friend WithEvents match_found_list As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
