﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modify_username_head
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modify_username_head))
        Me.heading = New System.Windows.Forms.Panel()
        Me.change_pass = New System.Windows.Forms.Label()
        Me.change_p = New ns1.BunifuImageButton()
        Me.change_user = New System.Windows.Forms.Label()
        Me.change_u = New ns1.BunifuImageButton()
        Me.heading.SuspendLayout()
        CType(Me.change_p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.change_u, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'heading
        '
        Me.heading.Controls.Add(Me.change_pass)
        Me.heading.Controls.Add(Me.change_p)
        Me.heading.Controls.Add(Me.change_user)
        Me.heading.Controls.Add(Me.change_u)
        Me.heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.heading.Location = New System.Drawing.Point(0, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(520, 47)
        Me.heading.TabIndex = 10
        '
        'change_pass
        '
        Me.change_pass.AutoSize = True
        Me.change_pass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_pass.ForeColor = System.Drawing.Color.DarkGray
        Me.change_pass.Location = New System.Drawing.Point(165, 12)
        Me.change_pass.Name = "change_pass"
        Me.change_pass.Size = New System.Drawing.Size(127, 19)
        Me.change_pass.TabIndex = 8
        Me.change_pass.Text = "Change Password"
        '
        'change_p
        '
        Me.change_p.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.change_p.Image = CType(resources.GetObject("change_p.Image"), System.Drawing.Image)
        Me.change_p.ImageActive = Nothing
        Me.change_p.Location = New System.Drawing.Point(208, 21)
        Me.change_p.Name = "change_p"
        Me.change_p.Size = New System.Drawing.Size(38, 40)
        Me.change_p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.change_p.TabIndex = 7
        Me.change_p.TabStop = False
        Me.change_p.Visible = False
        Me.change_p.Zoom = 0
        '
        'change_user
        '
        Me.change_user.AutoSize = True
        Me.change_user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_user.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.change_user.Location = New System.Drawing.Point(27, 12)
        Me.change_user.Name = "change_user"
        Me.change_user.Size = New System.Drawing.Size(132, 19)
        Me.change_user.TabIndex = 6
        Me.change_user.Text = "Change Username"
        '
        'change_u
        '
        Me.change_u.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.change_u.Image = CType(resources.GetObject("change_u.Image"), System.Drawing.Image)
        Me.change_u.ImageActive = Nothing
        Me.change_u.Location = New System.Drawing.Point(70, 21)
        Me.change_u.Name = "change_u"
        Me.change_u.Size = New System.Drawing.Size(38, 40)
        Me.change_u.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.change_u.TabIndex = 1
        Me.change_u.TabStop = False
        Me.change_u.Zoom = 0
        '
        'modify_username_head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.heading)
        Me.Name = "modify_username_head"
        Me.Size = New System.Drawing.Size(520, 47)
        Me.heading.ResumeLayout(False)
        Me.heading.PerformLayout()
        CType(Me.change_p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.change_u, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents heading As System.Windows.Forms.Panel
    Friend WithEvents change_user As System.Windows.Forms.Label
    Friend WithEvents change_u As ns1.BunifuImageButton
    Friend WithEvents change_pass As System.Windows.Forms.Label
    Friend WithEvents change_p As ns1.BunifuImageButton

End Class
