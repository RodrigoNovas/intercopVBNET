<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PathFile = New System.Windows.Forms.TextBox()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Maximizar = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.PanelDinamico = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.PictureBox()
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelDinamico.SuspendLayout()
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PathFile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 598)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(638, 283)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Convertir Archivos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PathFile
        '
        Me.PathFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PathFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PathFile.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathFile.ForeColor = System.Drawing.Color.Silver
        Me.PathFile.Location = New System.Drawing.Point(519, 178)
        Me.PathFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PathFile.Name = "PathFile"
        Me.PathFile.Size = New System.Drawing.Size(498, 38)
        Me.PathFile.TabIndex = 0
        Me.PathFile.Text = "Ingrese Ruta "
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelCabecera.Controls.Add(Me.Restaurar)
        Me.PanelCabecera.Controls.Add(Me.Minimizar)
        Me.PanelCabecera.Controls.Add(Me.Maximizar)
        Me.PanelCabecera.Controls.Add(Me.Cerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1253, 40)
        Me.PanelCabecera.TabIndex = 3
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Restaurar.FlatAppearance.BorderSize = 0
        Me.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Restaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restaurar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Restaurar.Location = New System.Drawing.Point(1143, 0)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(52, 40)
        Me.Restaurar.TabIndex = 5
        Me.Restaurar.Text = "⬜"
        Me.Restaurar.UseVisualStyleBackColor = True
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Minimizar.FlatAppearance.BorderSize = 0
        Me.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Minimizar.Location = New System.Drawing.Point(1085, 0)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(52, 40)
        Me.Minimizar.TabIndex = 4
        Me.Minimizar.Text = "-"
        Me.Minimizar.UseVisualStyleBackColor = True
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Maximizar.FlatAppearance.BorderSize = 0
        Me.Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Maximizar.Location = New System.Drawing.Point(1143, 0)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(52, 40)
        Me.Maximizar.TabIndex = 3
        Me.Maximizar.Text = "⬜"
        Me.Maximizar.UseVisualStyleBackColor = True
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cerrar.FlatAppearance.BorderSize = 0
        Me.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cerrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Cerrar.Location = New System.Drawing.Point(1201, 0)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(52, 40)
        Me.Cerrar.TabIndex = 2
        Me.Cerrar.Text = "X"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'PanelDinamico
        '
        Me.PanelDinamico.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelDinamico.Controls.Add(Me.Menu)
        Me.PanelDinamico.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDinamico.Location = New System.Drawing.Point(0, 40)
        Me.PanelDinamico.Name = "PanelDinamico"
        Me.PanelDinamico.Size = New System.Drawing.Size(200, 558)
        Me.PanelDinamico.TabIndex = 4
        '
        'Menu
        '
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.Menu.Image = Global.WindowsApp1.My.Resources.Resources.Menu
        Me.Menu.Location = New System.Drawing.Point(150, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(50, 558)
        Me.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Menu.TabIndex = 0
        Me.Menu.TabStop = False
        '
        'tmOcultar
        '
        '
        'tmMostrar
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1253, 598)
        Me.Controls.Add(Me.PanelDinamico)
        Me.Controls.Add(Me.PanelCabecera)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.DarkViolet
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Conversor "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelDinamico.ResumeLayout(False)
        CType(Me.Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PathFile As TextBox
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PanelDinamico As Panel
    Friend WithEvents Cerrar As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents Maximizar As Button
    Friend WithEvents Restaurar As Button
    Friend WithEvents Menu As PictureBox
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents tmMostrar As Timer
End Class
