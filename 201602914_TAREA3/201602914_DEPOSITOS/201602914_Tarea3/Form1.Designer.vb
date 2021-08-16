<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBN_AHORRO = New System.Windows.Forms.RadioButton()
        Me.RBN_MPREMIER = New System.Windows.Forms.RadioButton()
        Me.RBN_MONETARIO = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_MONTO = New System.Windows.Forms.Label()
        Me.CBX_EFECTIVO = New System.Windows.Forms.CheckBox()
        Me.CBX_CHEQUEO = New System.Windows.Forms.CheckBox()
        Me.CBX_CHEQUEP = New System.Windows.Forms.CheckBox()
        Me.TBX_EFECTIVO = New System.Windows.Forms.TextBox()
        Me.TBX_CHEQUEO = New System.Windows.Forms.TextBox()
        Me.TBX_CHEQUEP = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBX_SALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBN_AHORRO)
        Me.GroupBox1.Controls.Add(Me.RBN_MPREMIER)
        Me.GroupBox1.Controls.Add(Me.RBN_MONETARIO)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE DEPOSITO"
        '
        'RBN_AHORRO
        '
        Me.RBN_AHORRO.AutoSize = True
        Me.RBN_AHORRO.Location = New System.Drawing.Point(6, 123)
        Me.RBN_AHORRO.Name = "RBN_AHORRO"
        Me.RBN_AHORRO.Size = New System.Drawing.Size(56, 17)
        Me.RBN_AHORRO.TabIndex = 2
        Me.RBN_AHORRO.TabStop = True
        Me.RBN_AHORRO.Text = "Ahorro"
        Me.RBN_AHORRO.UseVisualStyleBackColor = True
        '
        'RBN_MPREMIER
        '
        Me.RBN_MPREMIER.AutoSize = True
        Me.RBN_MPREMIER.Location = New System.Drawing.Point(6, 86)
        Me.RBN_MPREMIER.Name = "RBN_MPREMIER"
        Me.RBN_MPREMIER.Size = New System.Drawing.Size(110, 17)
        Me.RBN_MPREMIER.TabIndex = 1
        Me.RBN_MPREMIER.TabStop = True
        Me.RBN_MPREMIER.Text = "Monetario Premier"
        Me.RBN_MPREMIER.UseVisualStyleBackColor = True
        '
        'RBN_MONETARIO
        '
        Me.RBN_MONETARIO.AutoSize = True
        Me.RBN_MONETARIO.Location = New System.Drawing.Point(6, 51)
        Me.RBN_MONETARIO.Name = "RBN_MONETARIO"
        Me.RBN_MONETARIO.Size = New System.Drawing.Size(72, 17)
        Me.RBN_MONETARIO.TabIndex = 0
        Me.RBN_MONETARIO.TabStop = True
        Me.RBN_MONETARIO.Text = "Monetario"
        Me.RBN_MONETARIO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LBL_MONTO)
        Me.GroupBox2.Controls.Add(Me.CBX_EFECTIVO)
        Me.GroupBox2.Controls.Add(Me.CBX_CHEQUEO)
        Me.GroupBox2.Controls.Add(Me.CBX_CHEQUEP)
        Me.GroupBox2.Controls.Add(Me.TBX_EFECTIVO)
        Me.GroupBox2.Controls.Add(Me.TBX_CHEQUEO)
        Me.GroupBox2.Controls.Add(Me.TBX_CHEQUEP)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONAR EL/LOS MODOS DE DEPOSITO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Q"
        '
        'LBL_MONTO
        '
        Me.LBL_MONTO.AutoSize = True
        Me.LBL_MONTO.Location = New System.Drawing.Point(138, 21)
        Me.LBL_MONTO.Name = "LBL_MONTO"
        Me.LBL_MONTO.Size = New System.Drawing.Size(40, 13)
        Me.LBL_MONTO.TabIndex = 12
        Me.LBL_MONTO.Text = "Monto:"
        '
        'CBX_EFECTIVO
        '
        Me.CBX_EFECTIVO.AutoSize = True
        Me.CBX_EFECTIVO.Location = New System.Drawing.Point(3, 120)
        Me.CBX_EFECTIVO.Name = "CBX_EFECTIVO"
        Me.CBX_EFECTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CBX_EFECTIVO.TabIndex = 11
        Me.CBX_EFECTIVO.Text = "Efectivo"
        Me.CBX_EFECTIVO.UseVisualStyleBackColor = True
        '
        'CBX_CHEQUEO
        '
        Me.CBX_CHEQUEO.AutoSize = True
        Me.CBX_CHEQUEO.Location = New System.Drawing.Point(3, 89)
        Me.CBX_CHEQUEO.Name = "CBX_CHEQUEO"
        Me.CBX_CHEQUEO.Size = New System.Drawing.Size(132, 17)
        Me.CBX_CHEQUEO.TabIndex = 10
        Me.CBX_CHEQUEO.Text = "Cheques otros bancos"
        Me.CBX_CHEQUEO.UseVisualStyleBackColor = True
        '
        'CBX_CHEQUEP
        '
        Me.CBX_CHEQUEP.AutoSize = True
        Me.CBX_CHEQUEP.Location = New System.Drawing.Point(3, 54)
        Me.CBX_CHEQUEP.Name = "CBX_CHEQUEP"
        Me.CBX_CHEQUEP.Size = New System.Drawing.Size(105, 17)
        Me.CBX_CHEQUEP.TabIndex = 9
        Me.CBX_CHEQUEP.Text = "Cheques propios"
        Me.CBX_CHEQUEP.UseVisualStyleBackColor = True
        '
        'TBX_EFECTIVO
        '
        Me.TBX_EFECTIVO.Location = New System.Drawing.Point(154, 117)
        Me.TBX_EFECTIVO.Name = "TBX_EFECTIVO"
        Me.TBX_EFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TBX_EFECTIVO.TabIndex = 8
        Me.TBX_EFECTIVO.Visible = False
        '
        'TBX_CHEQUEO
        '
        Me.TBX_CHEQUEO.Location = New System.Drawing.Point(154, 86)
        Me.TBX_CHEQUEO.Name = "TBX_CHEQUEO"
        Me.TBX_CHEQUEO.Size = New System.Drawing.Size(100, 20)
        Me.TBX_CHEQUEO.TabIndex = 7
        Me.TBX_CHEQUEO.Visible = False
        '
        'TBX_CHEQUEP
        '
        Me.TBX_CHEQUEP.Location = New System.Drawing.Point(154, 51)
        Me.TBX_CHEQUEP.Name = "TBX_CHEQUEP"
        Me.TBX_CHEQUEP.Size = New System.Drawing.Size(100, 20)
        Me.TBX_CHEQUEP.TabIndex = 6
        Me.TBX_CHEQUEP.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TBX_SALDOANTERIOR)
        Me.GroupBox3.Location = New System.Drawing.Point(519, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(145, 115)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SALDO ANTERIOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Q"
        '
        'TBX_SALDOANTERIOR
        '
        Me.TBX_SALDOANTERIOR.Location = New System.Drawing.Point(25, 54)
        Me.TBX_SALDOANTERIOR.Name = "TBX_SALDOANTERIOR"
        Me.TBX_SALDOANTERIOR.Size = New System.Drawing.Size(100, 20)
        Me.TBX_SALDOANTERIOR.TabIndex = 6
        Me.TBX_SALDOANTERIOR.Visible = False
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(297, 345)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(128, 51)
        Me.BTN_CALCULAR.TabIndex = 13
        Me.BTN_CALCULAR.Text = "CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = False
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(54, 345)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(128, 52)
        Me.BTN_LIMPIAR.TabIndex = 14
        Me.BTN_LIMPIAR.Text = "LIMPIAR"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SALIR.Location = New System.Drawing.Point(527, 344)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(117, 52)
        Me.BTN_SALIR.TabIndex = 15
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(99, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 102)
        Me.Panel1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(683, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_LIMPIAR)
        Me.Controls.Add(Me.BTN_CALCULAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Depositos bancarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBN_AHORRO As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_MPREMIER As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_MONETARIO As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBX_EFECTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents CBX_CHEQUEO As System.Windows.Forms.CheckBox
    Friend WithEvents CBX_CHEQUEP As System.Windows.Forms.CheckBox
    Friend WithEvents TBX_EFECTIVO As System.Windows.Forms.TextBox
    Friend WithEvents TBX_CHEQUEO As System.Windows.Forms.TextBox
    Friend WithEvents TBX_CHEQUEP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TBX_SALDOANTERIOR As System.Windows.Forms.TextBox
    Friend WithEvents LBL_MONTO As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTN_CALCULAR As System.Windows.Forms.Button
    Friend WithEvents BTN_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
