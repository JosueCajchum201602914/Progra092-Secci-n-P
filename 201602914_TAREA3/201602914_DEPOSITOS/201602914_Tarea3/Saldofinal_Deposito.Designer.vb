<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saldofinal_Deposito
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Saldofinal_Deposito))
        Me.LBL2_1 = New System.Windows.Forms.Label()
        Me.TBX_SALDONUEVO = New System.Windows.Forms.TextBox()
        Me.TBX_INTERÉS = New System.Windows.Forms.TextBox()
        Me.LBL2_2 = New System.Windows.Forms.Label()
        Me.LBL2_3 = New System.Windows.Forms.Label()
        Me.TBX_SALDOFINAL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_REGRESAR = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBX_SALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL2_1
        '
        Me.LBL2_1.AutoSize = True
        Me.LBL2_1.BackColor = System.Drawing.Color.PowderBlue
        Me.LBL2_1.Location = New System.Drawing.Point(161, 139)
        Me.LBL2_1.Name = "LBL2_1"
        Me.LBL2_1.Size = New System.Drawing.Size(138, 13)
        Me.LBL2_1.TabIndex = 0
        Me.LBL2_1.Text = "Saldo Nuevo (Sin intereses)"
        '
        'TBX_SALDONUEVO
        '
        Me.TBX_SALDONUEVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TBX_SALDONUEVO.Enabled = False
        Me.TBX_SALDONUEVO.Location = New System.Drawing.Point(358, 136)
        Me.TBX_SALDONUEVO.Name = "TBX_SALDONUEVO"
        Me.TBX_SALDONUEVO.Size = New System.Drawing.Size(135, 20)
        Me.TBX_SALDONUEVO.TabIndex = 1
        '
        'TBX_INTERÉS
        '
        Me.TBX_INTERÉS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TBX_INTERÉS.Enabled = False
        Me.TBX_INTERÉS.Location = New System.Drawing.Point(358, 171)
        Me.TBX_INTERÉS.Name = "TBX_INTERÉS"
        Me.TBX_INTERÉS.Size = New System.Drawing.Size(135, 20)
        Me.TBX_INTERÉS.TabIndex = 2
        '
        'LBL2_2
        '
        Me.LBL2_2.AutoSize = True
        Me.LBL2_2.BackColor = System.Drawing.Color.PowderBlue
        Me.LBL2_2.Location = New System.Drawing.Point(192, 174)
        Me.LBL2_2.Name = "LBL2_2"
        Me.LBL2_2.Size = New System.Drawing.Size(107, 13)
        Me.LBL2_2.TabIndex = 3
        Me.LBL2_2.Text = "Intereses calculados:"
        '
        'LBL2_3
        '
        Me.LBL2_3.AutoSize = True
        Me.LBL2_3.BackColor = System.Drawing.Color.PowderBlue
        Me.LBL2_3.Location = New System.Drawing.Point(103, 206)
        Me.LBL2_3.Name = "LBL2_3"
        Me.LBL2_3.Size = New System.Drawing.Size(196, 13)
        Me.LBL2_3.TabIndex = 4
        Me.LBL2_3.Text = "Saldo Nuevo (Con intereses percibidos):"
        '
        'TBX_SALDOFINAL
        '
        Me.TBX_SALDOFINAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TBX_SALDOFINAL.Enabled = False
        Me.TBX_SALDOFINAL.Location = New System.Drawing.Point(358, 199)
        Me.TBX_SALDOFINAL.Name = "TBX_SALDOFINAL"
        Me.TBX_SALDOFINAL.Size = New System.Drawing.Size(135, 20)
        Me.TBX_SALDOFINAL.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Q"
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(179, 284)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(244, 60)
        Me.BTN_REGRESAR.TabIndex = 9
        Me.BTN_REGRESAR.Text = "Regresar a ventana de depositos"
        Me.BTN_REGRESAR.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(150, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 43)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PowderBlue
        Me.Label4.Location = New System.Drawing.Point(227, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Saldo anterior:"
        '
        'TBX_SALDOANTERIOR
        '
        Me.TBX_SALDOANTERIOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TBX_SALDOANTERIOR.Enabled = False
        Me.TBX_SALDOANTERIOR.Location = New System.Drawing.Point(358, 105)
        Me.TBX_SALDOANTERIOR.Name = "TBX_SALDOANTERIOR"
        Me.TBX_SALDOANTERIOR.Size = New System.Drawing.Size(135, 20)
        Me.TBX_SALDOANTERIOR.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Q"
        '
        'Saldofinal_Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 370)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBX_SALDOANTERIOR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_REGRESAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBX_SALDOFINAL)
        Me.Controls.Add(Me.LBL2_3)
        Me.Controls.Add(Me.LBL2_2)
        Me.Controls.Add(Me.TBX_INTERÉS)
        Me.Controls.Add(Me.TBX_SALDONUEVO)
        Me.Controls.Add(Me.LBL2_1)
        Me.DoubleBuffered = True
        Me.Name = "Saldofinal_Deposito"
        Me.Text = "Saldofinal_Deposito:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL2_1 As System.Windows.Forms.Label
    Friend WithEvents TBX_SALDONUEVO As System.Windows.Forms.TextBox
    Friend WithEvents TBX_INTERÉS As System.Windows.Forms.TextBox
    Friend WithEvents LBL2_2 As System.Windows.Forms.Label
    Friend WithEvents LBL2_3 As System.Windows.Forms.Label
    Friend WithEvents TBX_SALDOFINAL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTN_REGRESAR As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBX_SALDOANTERIOR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
