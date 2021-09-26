<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RENTAUTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RENTAUTOS))
        Me.TXT_NIT = New System.Windows.Forms.TextBox()
        Me.TXT_PLACA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_EFECTIVO = New System.Windows.Forms.TextBox()
        Me.CHBX_EFECTIVO = New System.Windows.Forms.CheckBox()
        Me.TXT_TARJETA = New System.Windows.Forms.TextBox()
        Me.CHBX_TARJETA = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DIAS = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMBX_MARCA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LST_NIT = New System.Windows.Forms.ListBox()
        Me.LST_PLACA = New System.Windows.Forms.ListBox()
        Me.LST_MARCA = New System.Windows.Forms.ListBox()
        Me.LST_DIAS = New System.Windows.Forms.ListBox()
        Me.LST_PARCIAL = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LST_FINAL = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_NIT
        '
        Me.TXT_NIT.Location = New System.Drawing.Point(139, 59)
        Me.TXT_NIT.Name = "TXT_NIT"
        Me.TXT_NIT.Size = New System.Drawing.Size(100, 23)
        Me.TXT_NIT.TabIndex = 0
        '
        'TXT_PLACA
        '
        Me.TXT_PLACA.Location = New System.Drawing.Point(139, 35)
        Me.TXT_PLACA.MaxLength = 6
        Me.TXT_PLACA.Name = "TXT_PLACA"
        Me.TXT_PLACA.Size = New System.Drawing.Size(100, 23)
        Me.TXT_PLACA.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_NIT)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 108)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFO DEL CLIENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INGRESE EL NIT DEL CLIENTE:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TXT_DIAS)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(554, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 246)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS ALQUILER"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TXT_EFECTIVO)
        Me.GroupBox5.Controls.Add(Me.CHBX_EFECTIVO)
        Me.GroupBox5.Controls.Add(Me.TXT_TARJETA)
        Me.GroupBox5.Controls.Add(Me.CHBX_TARJETA)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 89)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(265, 156)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FORMA DE PAGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "%"
        '
        'TXT_EFECTIVO
        '
        Me.TXT_EFECTIVO.Enabled = False
        Me.TXT_EFECTIVO.Location = New System.Drawing.Point(124, 50)
        Me.TXT_EFECTIVO.Name = "TXT_EFECTIVO"
        Me.TXT_EFECTIVO.Size = New System.Drawing.Size(76, 23)
        Me.TXT_EFECTIVO.TabIndex = 2
        Me.TXT_EFECTIVO.Text = "0"
        '
        'CHBX_EFECTIVO
        '
        Me.CHBX_EFECTIVO.AutoSize = True
        Me.CHBX_EFECTIVO.Location = New System.Drawing.Point(18, 29)
        Me.CHBX_EFECTIVO.Name = "CHBX_EFECTIVO"
        Me.CHBX_EFECTIVO.Size = New System.Drawing.Size(86, 22)
        Me.CHBX_EFECTIVO.TabIndex = 0
        Me.CHBX_EFECTIVO.Text = "EFECTIVO"
        Me.CHBX_EFECTIVO.UseVisualStyleBackColor = True
        '
        'TXT_TARJETA
        '
        Me.TXT_TARJETA.Enabled = False
        Me.TXT_TARJETA.Location = New System.Drawing.Point(124, 120)
        Me.TXT_TARJETA.Name = "TXT_TARJETA"
        Me.TXT_TARJETA.Size = New System.Drawing.Size(76, 23)
        Me.TXT_TARJETA.TabIndex = 3
        Me.TXT_TARJETA.Text = "0"
        '
        'CHBX_TARJETA
        '
        Me.CHBX_TARJETA.AutoSize = True
        Me.CHBX_TARJETA.Location = New System.Drawing.Point(18, 97)
        Me.CHBX_TARJETA.Name = "CHBX_TARJETA"
        Me.CHBX_TARJETA.Size = New System.Drawing.Size(79, 22)
        Me.CHBX_TARJETA.TabIndex = 1
        Me.CHBX_TARJETA.Text = "TARJETA"
        Me.CHBX_TARJETA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "INGRESE CANTIDAD DE DÍAS A ALQUILAR:"
        '
        'TXT_DIAS
        '
        Me.TXT_DIAS.Location = New System.Drawing.Point(138, 63)
        Me.TXT_DIAS.Name = "TXT_DIAS"
        Me.TXT_DIAS.Size = New System.Drawing.Size(100, 23)
        Me.TXT_DIAS.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.CMBX_MARCA)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TXT_PLACA)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(280, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 150)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DEL VEHÍCULO"
        '
        'CMBX_MARCA
        '
        Me.CMBX_MARCA.FormattingEnabled = True
        Me.CMBX_MARCA.Items.AddRange(New Object() {"Honda", "Mercedez Benz", "Toyota", "Mazda"})
        Me.CMBX_MARCA.Location = New System.Drawing.Point(136, 97)
        Me.CMBX_MARCA.Name = "CMBX_MARCA"
        Me.CMBX_MARCA.Size = New System.Drawing.Size(126, 26)
        Me.CMBX_MARCA.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MARCA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PLACA DEL AUTO:"
        '
        'LST_NIT
        '
        Me.LST_NIT.FormattingEnabled = True
        Me.LST_NIT.ItemHeight = 18
        Me.LST_NIT.Location = New System.Drawing.Point(18, 38)
        Me.LST_NIT.Name = "LST_NIT"
        Me.LST_NIT.Size = New System.Drawing.Size(115, 148)
        Me.LST_NIT.TabIndex = 6
        '
        'LST_PLACA
        '
        Me.LST_PLACA.FormattingEnabled = True
        Me.LST_PLACA.ItemHeight = 18
        Me.LST_PLACA.Location = New System.Drawing.Point(139, 38)
        Me.LST_PLACA.Name = "LST_PLACA"
        Me.LST_PLACA.Size = New System.Drawing.Size(120, 148)
        Me.LST_PLACA.TabIndex = 7
        '
        'LST_MARCA
        '
        Me.LST_MARCA.FormattingEnabled = True
        Me.LST_MARCA.ItemHeight = 18
        Me.LST_MARCA.Location = New System.Drawing.Point(265, 38)
        Me.LST_MARCA.Name = "LST_MARCA"
        Me.LST_MARCA.Size = New System.Drawing.Size(120, 148)
        Me.LST_MARCA.TabIndex = 8
        '
        'LST_DIAS
        '
        Me.LST_DIAS.FormattingEnabled = True
        Me.LST_DIAS.ItemHeight = 18
        Me.LST_DIAS.Location = New System.Drawing.Point(391, 38)
        Me.LST_DIAS.Name = "LST_DIAS"
        Me.LST_DIAS.Size = New System.Drawing.Size(77, 148)
        Me.LST_DIAS.TabIndex = 9
        '
        'LST_PARCIAL
        '
        Me.LST_PARCIAL.FormattingEnabled = True
        Me.LST_PARCIAL.ItemHeight = 18
        Me.LST_PARCIAL.Location = New System.Drawing.Point(474, 38)
        Me.LST_PARCIAL.Name = "LST_PARCIAL"
        Me.LST_PARCIAL.Size = New System.Drawing.Size(101, 148)
        Me.LST_PARCIAL.TabIndex = 10
        '
        'LST_DESCUENTO
        '
        Me.LST_DESCUENTO.FormattingEnabled = True
        Me.LST_DESCUENTO.ItemHeight = 18
        Me.LST_DESCUENTO.Location = New System.Drawing.Point(581, 38)
        Me.LST_DESCUENTO.Name = "LST_DESCUENTO"
        Me.LST_DESCUENTO.Size = New System.Drawing.Size(101, 148)
        Me.LST_DESCUENTO.TabIndex = 11
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.LST_FINAL)
        Me.GroupBox4.Controls.Add(Me.LST_DIAS)
        Me.GroupBox4.Controls.Add(Me.LST_DESCUENTO)
        Me.GroupBox4.Controls.Add(Me.LST_NIT)
        Me.GroupBox4.Controls.Add(Me.LST_PARCIAL)
        Me.GroupBox4.Controls.Add(Me.LST_PLACA)
        Me.GroupBox4.Controls.Add(Me.LST_MARCA)
        Me.GroupBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(25, 275)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(820, 214)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS ALMACENADOS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.CadetBlue
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(578, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 18)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "RECARGO/"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.CadetBlue
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(685, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 18)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "PAGO FINAL:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.CadetBlue
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(578, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 18)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "DESCUENTO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.CadetBlue
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(484, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "PAGO PARCIAL:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.CadetBlue
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(369, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "DÍAS DE ALQUILER:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.CadetBlue
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(270, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "MARCA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.CadetBlue
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(139, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PLACA DEL AUTO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CadetBlue
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NIT:"
        '
        'LST_FINAL
        '
        Me.LST_FINAL.FormattingEnabled = True
        Me.LST_FINAL.ItemHeight = 18
        Me.LST_FINAL.Location = New System.Drawing.Point(688, 38)
        Me.LST_FINAL.Name = "LST_FINAL"
        Me.LST_FINAL.Size = New System.Drawing.Size(120, 148)
        Me.LST_FINAL.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESOSToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(866, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROCESOSToolStripMenuItem
        '
        Me.PROCESOSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROCESOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem"
        Me.PROCESOSToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.PROCESOSToolStripMenuItem.Text = "PROCESOS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIMPIARENTRADASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIMPIARVECTORESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 73)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'RENTAUTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(866, 501)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RENTAUTOS"
        Me.Text = "RENTAUTOS_201602914"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_NIT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PLACA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_EFECTIVO As System.Windows.Forms.TextBox
    Friend WithEvents CHBX_EFECTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents CHBX_TARJETA As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIAS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LST_NIT As System.Windows.Forms.ListBox
    Friend WithEvents LST_PLACA As System.Windows.Forms.ListBox
    Friend WithEvents LST_MARCA As System.Windows.Forms.ListBox
    Friend WithEvents LST_DIAS As System.Windows.Forms.ListBox
    Friend WithEvents LST_PARCIAL As System.Windows.Forms.ListBox
    Friend WithEvents LST_DESCUENTO As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LST_FINAL As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PROCESOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMBX_MARCA As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
