﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehiclesUserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehiclesUserControl))
        Panel1 = New Panel()
        VehicleBodypanel = New Panel()
        Panel2 = New Panel()
        VehiclePanel1 = New Panel()
        DeleteVehicle1Button = New Button()
        UpdateVehicle1Button = New Button()
        Label2 = New Label()
        VehicleHeaderPanel = New Panel()
        AddVehicleButton = New Button()
        VehiclesLabel = New Label()
        VehicleSearchBar = New TextBox()
        Panel1.SuspendLayout()
        VehicleBodypanel.SuspendLayout()
        Panel2.SuspendLayout()
        VehiclePanel1.SuspendLayout()
        VehicleHeaderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(VehicleBodypanel)
        Panel1.Controls.Add(VehicleHeaderPanel)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(20, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(984, 621)
        Panel1.TabIndex = 0
        ' 
        ' VehicleBodypanel
        ' 
        VehicleBodypanel.Controls.Add(Panel2)
        VehicleBodypanel.Dock = DockStyle.Fill
        VehicleBodypanel.Location = New Point(0, 62)
        VehicleBodypanel.Name = "VehicleBodypanel"
        VehicleBodypanel.Padding = New Padding(20)
        VehicleBodypanel.Size = New Size(984, 559)
        VehicleBodypanel.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.Controls.Add(VehiclePanel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(20, 20)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20)
        Panel2.Size = New Size(944, 519)
        Panel2.TabIndex = 3
        ' 
        ' VehiclePanel1
        ' 
        VehiclePanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        VehiclePanel1.BackColor = Color.Silver
        VehiclePanel1.Controls.Add(DeleteVehicle1Button)
        VehiclePanel1.Controls.Add(UpdateVehicle1Button)
        VehiclePanel1.Controls.Add(Label2)
        VehiclePanel1.Location = New Point(23, 23)
        VehiclePanel1.Name = "VehiclePanel1"
        VehiclePanel1.Padding = New Padding(5)
        VehiclePanel1.Size = New Size(898, 65)
        VehiclePanel1.TabIndex = 0
        ' 
        ' DeleteVehicle1Button
        ' 
        DeleteVehicle1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        DeleteVehicle1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        DeleteVehicle1Button.ForeColor = Color.Red
        DeleteVehicle1Button.Location = New Point(806, 12)
        DeleteVehicle1Button.Name = "DeleteVehicle1Button"
        DeleteVehicle1Button.Size = New Size(84, 40)
        DeleteVehicle1Button.TabIndex = 2
        DeleteVehicle1Button.Text = "Delete"
        DeleteVehicle1Button.UseVisualStyleBackColor = True
        ' 
        ' UpdateVehicle1Button
        ' 
        UpdateVehicle1Button.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        UpdateVehicle1Button.Font = New Font("Gabriola", 10F, FontStyle.Bold)
        UpdateVehicle1Button.Location = New Point(711, 12)
        UpdateVehicle1Button.Name = "UpdateVehicle1Button"
        UpdateVehicle1Button.Size = New Size(84, 40)
        UpdateVehicle1Button.TabIndex = 1
        UpdateVehicle1Button.Text = "Update"
        UpdateVehicle1Button.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 13F, FontStyle.Bold)
        Label2.Location = New Point(8, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 40)
        Label2.TabIndex = 0
        Label2.Text = "Vehicle details"
        ' 
        ' VehicleHeaderPanel
        ' 
        VehicleHeaderPanel.Controls.Add(AddVehicleButton)
        VehicleHeaderPanel.Controls.Add(VehiclesLabel)
        VehicleHeaderPanel.Controls.Add(VehicleSearchBar)
        VehicleHeaderPanel.Dock = DockStyle.Top
        VehicleHeaderPanel.Location = New Point(0, 0)
        VehicleHeaderPanel.Name = "VehicleHeaderPanel"
        VehicleHeaderPanel.Size = New Size(984, 62)
        VehicleHeaderPanel.TabIndex = 4
        ' 
        ' AddVehicleButton
        ' 
        AddVehicleButton.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        AddVehicleButton.BackColor = Color.Gray
        AddVehicleButton.FlatAppearance.BorderSize = 0
        AddVehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddVehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddVehicleButton.FlatStyle = FlatStyle.Flat
        AddVehicleButton.Font = New Font("Gabriola", 12F, FontStyle.Bold)
        AddVehicleButton.Location = New Point(813, 15)
        AddVehicleButton.Name = "AddVehicleButton"
        AddVehicleButton.Size = New Size(151, 39)
        AddVehicleButton.TabIndex = 2
        AddVehicleButton.Text = "Add Vehicle"
        AddVehicleButton.UseVisualStyleBackColor = False
        ' 
        ' VehiclesLabel
        ' 
        VehiclesLabel.AutoSize = True
        VehiclesLabel.Font = New Font("MV Boli", 15F, FontStyle.Bold)
        VehiclesLabel.Image = CType(resources.GetObject("VehiclesLabel.Image"), Image)
        VehiclesLabel.ImageAlign = ContentAlignment.MiddleLeft
        VehiclesLabel.Location = New Point(17, 15)
        VehiclesLabel.Name = "VehiclesLabel"
        VehiclesLabel.Size = New Size(135, 32)
        VehiclesLabel.TabIndex = 1
        VehiclesLabel.Text = "  Vehicles"
        VehiclesLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' VehicleSearchBar
        ' 
        VehicleSearchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        VehicleSearchBar.BackColor = Color.White
        VehicleSearchBar.Location = New Point(614, 20)
        VehicleSearchBar.MinimumSize = New Size(130, 27)
        VehicleSearchBar.Name = "VehicleSearchBar"
        VehicleSearchBar.PlaceholderText = "Search"
        VehicleSearchBar.Size = New Size(184, 27)
        VehicleSearchBar.TabIndex = 0
        ' 
        ' VehiclesUserControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "VehiclesUserControl"
        Padding = New Padding(20)
        Size = New Size(1024, 661)
        Panel1.ResumeLayout(False)
        VehicleBodypanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        VehiclePanel1.ResumeLayout(False)
        VehiclePanel1.PerformLayout()
        VehicleHeaderPanel.ResumeLayout(False)
        VehicleHeaderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents VehiclesLabel As Label
    Friend WithEvents VehicleSearchBar As TextBox
    Friend WithEvents AddVehicleButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VehiclePanel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateVehicle1Button As Button
    Friend WithEvents DeleteVehicle1Button As Button
    Friend WithEvents VehicleHeaderPanel As Panel
    Friend WithEvents VehicleBodypanel As Panel

End Class
