<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Management_Interface
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
        Me.add_new_item_btn = New System.Windows.Forms.Button()
        Me.listViewJewelry = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureBoxJewelry = New System.Windows.Forms.PictureBox()
        Me.inv_cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pictureBoxJewelry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inv_cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'add_new_item_btn
        '
        Me.add_new_item_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.add_new_item_btn.FlatAppearance.BorderSize = 2
        Me.add_new_item_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_new_item_btn.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.add_new_item_btn.Location = New System.Drawing.Point(12, 12)
        Me.add_new_item_btn.Name = "add_new_item_btn"
        Me.add_new_item_btn.Size = New System.Drawing.Size(92, 31)
        Me.add_new_item_btn.TabIndex = 4
        Me.add_new_item_btn.Text = "Add New"
        Me.add_new_item_btn.UseVisualStyleBackColor = True
        '
        'listViewJewelry
        '
        Me.listViewJewelry.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader7})
        Me.listViewJewelry.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.listViewJewelry.FullRowSelect = True
        Me.listViewJewelry.HideSelection = False
        Me.listViewJewelry.Location = New System.Drawing.Point(12, 49)
        Me.listViewJewelry.Name = "listViewJewelry"
        Me.listViewJewelry.Size = New System.Drawing.Size(707, 332)
        Me.listViewJewelry.TabIndex = 5
        Me.listViewJewelry.UseCompatibleStateImageBehavior = False
        Me.listViewJewelry.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 169
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Type"
        Me.ColumnHeader6.Width = 138
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 233
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Location"
        Me.ColumnHeader3.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Dateadded"
        Me.ColumnHeader4.Width = 193
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Image_Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(213, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(266, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 24)
        Me.txtSearch.TabIndex = 11
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(987, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(746, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Selected Item Image Preview"
        '
        'pictureBoxJewelry
        '
        Me.pictureBoxJewelry.BackColor = System.Drawing.Color.DimGray
        Me.pictureBoxJewelry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBoxJewelry.Location = New System.Drawing.Point(747, 80)
        Me.pictureBoxJewelry.Name = "pictureBoxJewelry"
        Me.pictureBoxJewelry.Size = New System.Drawing.Size(203, 236)
        Me.pictureBoxJewelry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxJewelry.TabIndex = 15
        Me.pictureBoxJewelry.TabStop = False
        '
        'inv_cms
        '
        Me.inv_cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.inv_cms.Name = "loc_cms"
        Me.inv_cms.Size = New System.Drawing.Size(113, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'Inventory_Management_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 406)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pictureBoxJewelry)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listViewJewelry)
        Me.Controls.Add(Me.add_new_item_btn)
        Me.Name = "Inventory_Management_Interface"
        Me.ShowIcon = False
        Me.Text = "Inventory Management Interface"
        CType(Me.pictureBoxJewelry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inv_cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_new_item_btn As Button
    Friend WithEvents listViewJewelry As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents pictureBoxJewelry As PictureBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents inv_cms As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
End Class
