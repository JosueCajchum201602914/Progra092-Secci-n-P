<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COBRO_LUZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COBRO_LUZ))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMB_SERVICIO = New System.Windows.Forms.ComboBox()
        Me.CMB_TARIFA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CONSUMO = New System.Windows.Forms.TextBox()
        Me.TXT_SALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NIT = New System.Windows.Forms.TextBox()
        Me.TXT_CONSUMIDOR = New System.Windows.Forms.TextBox()
        Me.LST_CONSUMIDOR = New System.Windows.Forms.ListBox()
        Me.LST_NIT = New System.Windows.Forms.ListBox()
        Me.LST_SERVICIO = New System.Windows.Forms.ListBox()
        Me.LST_TARIFA = New System.Windows.Forms.ListBox()
        Me.LST_SALDO = New System.Windows.Forms.ListBox()
        Me.LST_P_INICIAL = New System.Windows.Forms.ListBox()
        Me.LST_MORA = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO = New System.Windows.Forms.ListBox()
        Me.LST_TOTAL = New System.Windows.Forms.ListBox()
        Me.LBL_CONSUMIDOR = New System.Windows.Forms.Label()
        Me.LBL_NIT = New System.Windows.Forms.Label()
        Me.LBL_SERVICIO = New System.Windows.Forms.Label()
        Me.LBL_TARIFA = New System.Windows.Forms.Label()
        Me.LBL_SALDO = New System.Windows.Forms.Label()
        Me.LBL_PAGOINICIAL = New System.Windows.Forms.Label()
        Me.LBL_MORA = New System.Windows.Forms.Label()
        Me.LBL_DESCUENTO = New System.Windows.Forms.Label()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR LISTAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TXT_CONSUMO)
        Me.GroupBox1.Controls.Add(Me.TXT_SALDOANTERIOR)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_NIT)
        Me.GroupBox1.Controls.Add(Me.TXT_CONSUMIDOR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 221)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL CONSUMIDOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CMB_SERVICIO)
        Me.GroupBox2.Controls.Add(Me.CMB_TARIFA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 100)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de tarifa:"
        '
        'CMB_SERVICIO
        '
        Me.CMB_SERVICIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMB_SERVICIO.FormattingEnabled = True
        Me.CMB_SERVICIO.Location = New System.Drawing.Point(159, 20)
        Me.CMB_SERVICIO.Name = "CMB_SERVICIO"
        Me.CMB_SERVICIO.Size = New System.Drawing.Size(121, 21)
        Me.CMB_SERVICIO.TabIndex = 4
        '
        'CMB_TARIFA
        '
        Me.CMB_TARIFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMB_TARIFA.FormattingEnabled = True
        Me.CMB_TARIFA.Location = New System.Drawing.Point(159, 64)
        Me.CMB_TARIFA.Name = "CMB_TARIFA"
        Me.CMB_TARIFA.Size = New System.Drawing.Size(121, 21)
        Me.CMB_TARIFA.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de servicio:"
        '
        'TXT_CONSUMO
        '
        Me.TXT_CONSUMO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXT_CONSUMO.Location = New System.Drawing.Point(473, 43)
        Me.TXT_CONSUMO.Name = "TXT_CONSUMO"
        Me.TXT_CONSUMO.Size = New System.Drawing.Size(121, 20)
        Me.TXT_CONSUMO.TabIndex = 3
        '
        'TXT_SALDOANTERIOR
        '
        Me.TXT_SALDOANTERIOR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXT_SALDOANTERIOR.Location = New System.Drawing.Point(131, 154)
        Me.TXT_SALDOANTERIOR.Name = "TXT_SALDOANTERIOR"
        Me.TXT_SALDOANTERIOR.Size = New System.Drawing.Size(131, 20)
        Me.TXT_SALDOANTERIOR.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Consumo de KWh de este mes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Saldo Anterior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NIT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre del consumidor:"
        '
        'TXT_NIT
        '
        Me.TXT_NIT.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXT_NIT.Location = New System.Drawing.Point(131, 100)
        Me.TXT_NIT.Name = "TXT_NIT"
        Me.TXT_NIT.Size = New System.Drawing.Size(131, 20)
        Me.TXT_NIT.TabIndex = 1
        '
        'TXT_CONSUMIDOR
        '
        Me.TXT_CONSUMIDOR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TXT_CONSUMIDOR.Location = New System.Drawing.Point(131, 46)
        Me.TXT_CONSUMIDOR.Name = "TXT_CONSUMIDOR"
        Me.TXT_CONSUMIDOR.Size = New System.Drawing.Size(131, 20)
        Me.TXT_CONSUMIDOR.TabIndex = 0
        '
        'LST_CONSUMIDOR
        '
        Me.LST_CONSUMIDOR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LST_CONSUMIDOR.FormattingEnabled = True
        Me.LST_CONSUMIDOR.Location = New System.Drawing.Point(7, 47)
        Me.LST_CONSUMIDOR.Name = "LST_CONSUMIDOR"
        Me.LST_CONSUMIDOR.Size = New System.Drawing.Size(120, 95)
        Me.LST_CONSUMIDOR.TabIndex = 2
        '
        'LST_NIT
        '
        Me.LST_NIT.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LST_NIT.FormattingEnabled = True
        Me.LST_NIT.Location = New System.Drawing.Point(133, 47)
        Me.LST_NIT.Name = "LST_NIT"
        Me.LST_NIT.Size = New System.Drawing.Size(96, 95)
        Me.LST_NIT.TabIndex = 3
        '
        'LST_SERVICIO
        '
        Me.LST_SERVICIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_SERVICIO.FormattingEnabled = True
        Me.LST_SERVICIO.Location = New System.Drawing.Point(236, 47)
        Me.LST_SERVICIO.Name = "LST_SERVICIO"
        Me.LST_SERVICIO.Size = New System.Drawing.Size(96, 95)
        Me.LST_SERVICIO.TabIndex = 4
        '
        'LST_TARIFA
        '
        Me.LST_TARIFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_TARIFA.FormattingEnabled = True
        Me.LST_TARIFA.Location = New System.Drawing.Point(338, 47)
        Me.LST_TARIFA.Name = "LST_TARIFA"
        Me.LST_TARIFA.Size = New System.Drawing.Size(100, 95)
        Me.LST_TARIFA.TabIndex = 5
        '
        'LST_SALDO
        '
        Me.LST_SALDO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_SALDO.FormattingEnabled = True
        Me.LST_SALDO.Location = New System.Drawing.Point(444, 47)
        Me.LST_SALDO.Name = "LST_SALDO"
        Me.LST_SALDO.Size = New System.Drawing.Size(107, 95)
        Me.LST_SALDO.TabIndex = 6
        '
        'LST_P_INICIAL
        '
        Me.LST_P_INICIAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_P_INICIAL.FormattingEnabled = True
        Me.LST_P_INICIAL.Location = New System.Drawing.Point(557, 47)
        Me.LST_P_INICIAL.Name = "LST_P_INICIAL"
        Me.LST_P_INICIAL.Size = New System.Drawing.Size(107, 95)
        Me.LST_P_INICIAL.TabIndex = 7
        '
        'LST_MORA
        '
        Me.LST_MORA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_MORA.FormattingEnabled = True
        Me.LST_MORA.Location = New System.Drawing.Point(670, 47)
        Me.LST_MORA.Name = "LST_MORA"
        Me.LST_MORA.Size = New System.Drawing.Size(107, 95)
        Me.LST_MORA.TabIndex = 8
        '
        'LST_DESCUENTO
        '
        Me.LST_DESCUENTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_DESCUENTO.FormattingEnabled = True
        Me.LST_DESCUENTO.Location = New System.Drawing.Point(783, 47)
        Me.LST_DESCUENTO.Name = "LST_DESCUENTO"
        Me.LST_DESCUENTO.Size = New System.Drawing.Size(102, 95)
        Me.LST_DESCUENTO.TabIndex = 9
        '
        'LST_TOTAL
        '
        Me.LST_TOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LST_TOTAL.FormattingEnabled = True
        Me.LST_TOTAL.Location = New System.Drawing.Point(891, 47)
        Me.LST_TOTAL.Name = "LST_TOTAL"
        Me.LST_TOTAL.Size = New System.Drawing.Size(102, 95)
        Me.LST_TOTAL.TabIndex = 10
        '
        'LBL_CONSUMIDOR
        '
        Me.LBL_CONSUMIDOR.AutoSize = True
        Me.LBL_CONSUMIDOR.Location = New System.Drawing.Point(14, 28)
        Me.LBL_CONSUMIDOR.Name = "LBL_CONSUMIDOR"
        Me.LBL_CONSUMIDOR.Size = New System.Drawing.Size(81, 13)
        Me.LBL_CONSUMIDOR.TabIndex = 12
        Me.LBL_CONSUMIDOR.Text = "CONSUMIDOR"
        '
        'LBL_NIT
        '
        Me.LBL_NIT.AutoSize = True
        Me.LBL_NIT.Location = New System.Drawing.Point(135, 31)
        Me.LBL_NIT.Name = "LBL_NIT"
        Me.LBL_NIT.Size = New System.Drawing.Size(25, 13)
        Me.LBL_NIT.TabIndex = 13
        Me.LBL_NIT.Text = "NIT"
        '
        'LBL_SERVICIO
        '
        Me.LBL_SERVICIO.AutoSize = True
        Me.LBL_SERVICIO.Location = New System.Drawing.Point(243, 31)
        Me.LBL_SERVICIO.Name = "LBL_SERVICIO"
        Me.LBL_SERVICIO.Size = New System.Drawing.Size(57, 13)
        Me.LBL_SERVICIO.TabIndex = 14
        Me.LBL_SERVICIO.Text = "SERVICIO"
        '
        'LBL_TARIFA
        '
        Me.LBL_TARIFA.AutoSize = True
        Me.LBL_TARIFA.Location = New System.Drawing.Point(347, 31)
        Me.LBL_TARIFA.Name = "LBL_TARIFA"
        Me.LBL_TARIFA.Size = New System.Drawing.Size(45, 13)
        Me.LBL_TARIFA.TabIndex = 15
        Me.LBL_TARIFA.Text = "TARIFA"
        '
        'LBL_SALDO
        '
        Me.LBL_SALDO.AutoSize = True
        Me.LBL_SALDO.Location = New System.Drawing.Point(451, 31)
        Me.LBL_SALDO.Name = "LBL_SALDO"
        Me.LBL_SALDO.Size = New System.Drawing.Size(43, 13)
        Me.LBL_SALDO.TabIndex = 16
        Me.LBL_SALDO.Text = "SALDO"
        '
        'LBL_PAGOINICIAL
        '
        Me.LBL_PAGOINICIAL.AutoSize = True
        Me.LBL_PAGOINICIAL.Location = New System.Drawing.Point(554, 31)
        Me.LBL_PAGOINICIAL.Name = "LBL_PAGOINICIAL"
        Me.LBL_PAGOINICIAL.Size = New System.Drawing.Size(77, 13)
        Me.LBL_PAGOINICIAL.TabIndex = 17
        Me.LBL_PAGOINICIAL.Text = "PAGO INICIAL"
        '
        'LBL_MORA
        '
        Me.LBL_MORA.AutoSize = True
        Me.LBL_MORA.Location = New System.Drawing.Point(683, 31)
        Me.LBL_MORA.Name = "LBL_MORA"
        Me.LBL_MORA.Size = New System.Drawing.Size(39, 13)
        Me.LBL_MORA.TabIndex = 18
        Me.LBL_MORA.Text = "MORA"
        '
        'LBL_DESCUENTO
        '
        Me.LBL_DESCUENTO.AutoSize = True
        Me.LBL_DESCUENTO.Location = New System.Drawing.Point(789, 31)
        Me.LBL_DESCUENTO.Name = "LBL_DESCUENTO"
        Me.LBL_DESCUENTO.Size = New System.Drawing.Size(74, 13)
        Me.LBL_DESCUENTO.TabIndex = 19
        Me.LBL_DESCUENTO.Text = "DESCUENTO"
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.Location = New System.Drawing.Point(893, 31)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(92, 13)
        Me.LBL_TOTAL.TabIndex = 20
        Me.LBL_TOTAL.Text = "TOTAL A PAGAR"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(691, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 169)
        Me.Panel1.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.LBL_CONSUMIDOR)
        Me.GroupBox3.Controls.Add(Me.LST_CONSUMIDOR)
        Me.GroupBox3.Controls.Add(Me.LBL_TOTAL)
        Me.GroupBox3.Controls.Add(Me.LST_NIT)
        Me.GroupBox3.Controls.Add(Me.LBL_DESCUENTO)
        Me.GroupBox3.Controls.Add(Me.LST_SERVICIO)
        Me.GroupBox3.Controls.Add(Me.LBL_MORA)
        Me.GroupBox3.Controls.Add(Me.LST_TARIFA)
        Me.GroupBox3.Controls.Add(Me.LBL_PAGOINICIAL)
        Me.GroupBox3.Controls.Add(Me.LST_SALDO)
        Me.GroupBox3.Controls.Add(Me.LBL_SALDO)
        Me.GroupBox3.Controls.Add(Me.LST_P_INICIAL)
        Me.GroupBox3.Controls.Add(Me.LBL_TARIFA)
        Me.GroupBox3.Controls.Add(Me.LST_MORA)
        Me.GroupBox3.Controls.Add(Me.LBL_SERVICIO)
        Me.GroupBox3.Controls.Add(Me.LST_DESCUENTO)
        Me.GroupBox3.Controls.Add(Me.LBL_NIT)
        Me.GroupBox3.Controls.Add(Me.LST_TOTAL)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(998, 159)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORME"
        '
        'COBRO_LUZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 398)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "COBRO_LUZ"
        Me.Text = "COBRO LUZ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_CONSUMO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SALDOANTERIOR As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMB_TARIFA As System.Windows.Forms.ComboBox
    Friend WithEvents CMB_SERVICIO As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_NIT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CONSUMIDOR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LST_CONSUMIDOR As System.Windows.Forms.ListBox
    Friend WithEvents LST_NIT As System.Windows.Forms.ListBox
    Friend WithEvents LST_SERVICIO As System.Windows.Forms.ListBox
    Friend WithEvents LST_TARIFA As System.Windows.Forms.ListBox
    Friend WithEvents LST_SALDO As System.Windows.Forms.ListBox
    Friend WithEvents LST_P_INICIAL As System.Windows.Forms.ListBox
    Friend WithEvents LST_MORA As System.Windows.Forms.ListBox
    Friend WithEvents LST_DESCUENTO As System.Windows.Forms.ListBox
    Friend WithEvents LST_TOTAL As System.Windows.Forms.ListBox
    Friend WithEvents LBL_CONSUMIDOR As System.Windows.Forms.Label
    Friend WithEvents LBL_NIT As System.Windows.Forms.Label
    Friend WithEvents LBL_SERVICIO As System.Windows.Forms.Label
    Friend WithEvents LBL_TARIFA As System.Windows.Forms.Label
    Friend WithEvents LBL_SALDO As System.Windows.Forms.Label
    Friend WithEvents LBL_PAGOINICIAL As System.Windows.Forms.Label
    Friend WithEvents LBL_MORA As System.Windows.Forms.Label
    Friend WithEvents LBL_DESCUENTO As System.Windows.Forms.Label
    Friend WithEvents LBL_TOTAL As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
