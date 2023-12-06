<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Location_Management_Interface
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loc_name = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.add_new_location_btn = New System.Windows.Forms.Button()
        Me.location_lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.loc_cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loc_cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Location Name:"
        '
        'loc_name
        '
        Me.loc_name.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.loc_name.Location = New System.Drawing.Point(112, 16)
        Me.loc_name.Name = "loc_name"
        Me.loc_name.Size = New System.Drawing.Size(203, 24)
        Me.loc_name.TabIndex = 12
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 397)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'add_new_location_btn
        '
        Me.add_new_location_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.add_new_location_btn.FlatAppearance.BorderSize = 2
        Me.add_new_location_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_new_location_btn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.add_new_location_btn.Location = New System.Drawing.Point(321, 12)
        Me.add_new_location_btn.Name = "add_new_location_btn"
        Me.add_new_location_btn.Size = New System.Drawing.Size(69, 31)
        Me.add_new_location_btn.TabIndex = 14
        Me.add_new_location_btn.Text = "Add"
        Me.add_new_location_btn.UseVisualStyleBackColor = True
        '
        'location_lv
        '
        Me.location_lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.location_lv.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.location_lv.FullRowSelect = True
        Me.location_lv.HideSelection = False
        Me.location_lv.Location = New System.Drawing.Point(12, 60)
        Me.location_lv.Name = "location_lv"
        Me.location_lv.Size = New System.Drawing.Size(776, 332)
        Me.location_lv.TabIndex = 16
        Me.location_lv.UseCompatibleStateImageBehavior = False
        Me.location_lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Location ID"
        Me.ColumnHeader1.Width = 169
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Location Name"
        Me.ColumnHeader2.Width = 203
        '
        'loc_cms
        '
        Me.loc_cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.loc_cms.Name = "loc_cms"
        Me.loc_cms.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Location_Management_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 419)
        Me.Controls.Add(Me.location_lv)
        Me.Controls.Add(Me.add_new_location_btn)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.loc_name)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Location_Management_Interface"
        Me.ShowIcon = False
        Me.Text = "Location_Management_Interface"
        Me.loc_cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents loc_name As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents add_new_location_btn As Button
    Friend WithEvents location_lv As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents loc_cms As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
