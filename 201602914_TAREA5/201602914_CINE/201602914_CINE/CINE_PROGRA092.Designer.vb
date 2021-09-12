<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CINE_PROGRA092
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CINE_PROGRA092))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMB_FUNCION = New System.Windows.Forms.ComboBox()
        Me.CMB_CINE = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripLIMPIAR_LISTAS = New System.Windows.Forms.ToolStripComboBox()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LST_N_ENT = New System.Windows.Forms.ListBox()
        Me.LST_TOTAL = New System.Windows.Forms.ListBox()
        Me.LST_DESC2 = New System.Windows.Forms.ListBox()
        Me.LST_DESC1 = New System.Windows.Forms.ListBox()
        Me.LST_SUBTOTAL = New System.Windows.Forms.ListBox()
        Me.LST_FUNCIÓN = New System.Windows.Forms.ListBox()
        Me.LST_CINE = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_N_ENTRADAS = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CMB_FUNCION)
        Me.GroupBox1.Controls.Add(Me.CMB_CINE)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(141, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de Cine/Función"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FUNCIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CINE"
        '
        'CMB_FUNCION
        '
        Me.CMB_FUNCION.FormattingEnabled = True
        Me.CMB_FUNCION.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CMB_FUNCION.Location = New System.Drawing.Point(73, 89)
        Me.CMB_FUNCION.Name = "CMB_FUNCION"
        Me.CMB_FUNCION.Size = New System.Drawing.Size(121, 26)
        Me.CMB_FUNCION.TabIndex = 1
        '
        'CMB_CINE
        '
        Me.CMB_CINE.FormattingEnabled = True
        Me.CMB_CINE.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CMB_CINE.Location = New System.Drawing.Point(73, 46)
        Me.CMB_CINE.Name = "CMB_CINE"
        Me.CMB_CINE.Size = New System.Drawing.Size(121, 26)
        Me.CMB_CINE.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gold
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLIMPIAR_LISTAS, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripLIMPIAR_LISTAS
        '
        Me.ToolStripLIMPIAR_LISTAS.Name = "ToolStripLIMPIAR_LISTAS"
        Me.ToolStripLIMPIAR_LISTAS.Size = New System.Drawing.Size(121, 23)
        Me.ToolStripLIMPIAR_LISTAS.Text = "LIMPIAR LISTAS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 23)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 23)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(397, 165)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(120, 40)
        Me.BTN_ACEPTAR.TabIndex = 2
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_SALIR.Location = New System.Drawing.Point(605, 165)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(120, 40)
        Me.BTN_SALIR.TabIndex = 3
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Brown
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LST_N_ENT)
        Me.GroupBox2.Controls.Add(Me.LST_TOTAL)
        Me.GroupBox2.Controls.Add(Me.LST_DESC2)
        Me.GroupBox2.Controls.Add(Me.LST_DESC1)
        Me.GroupBox2.Controls.Add(Me.LST_SUBTOTAL)
        Me.GroupBox2.Controls.Add(Me.LST_FUNCIÓN)
        Me.GroupBox2.Controls.Add(Me.LST_CINE)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 188)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COMPRAS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Navy
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label10.Location = New System.Drawing.Point(612, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "TOTAL A PAGAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Navy
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label9.Location = New System.Drawing.Point(506, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "DESCUENTO 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label8.Location = New System.Drawing.Point(402, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "DESCUENTO 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label7.Location = New System.Drawing.Point(305, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "SUBTOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Location = New System.Drawing.Point(208, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "# ENTRADAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label5.Location = New System.Drawing.Point(110, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FUNCIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CINE"
        '
        'LST_N_ENT
        '
        Me.LST_N_ENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_N_ENT.FormattingEnabled = True
        Me.LST_N_ENT.ItemHeight = 15
        Me.LST_N_ENT.Location = New System.Drawing.Point(218, 45)
        Me.LST_N_ENT.Name = "LST_N_ENT"
        Me.LST_N_ENT.Size = New System.Drawing.Size(77, 124)
        Me.LST_N_ENT.TabIndex = 6
        '
        'LST_TOTAL
        '
        Me.LST_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_TOTAL.FormattingEnabled = True
        Me.LST_TOTAL.ItemHeight = 15
        Me.LST_TOTAL.Location = New System.Drawing.Point(615, 45)
        Me.LST_TOTAL.Name = "LST_TOTAL"
        Me.LST_TOTAL.Size = New System.Drawing.Size(98, 124)
        Me.LST_TOTAL.TabIndex = 5
        '
        'LST_DESC2
        '
        Me.LST_DESC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_DESC2.FormattingEnabled = True
        Me.LST_DESC2.ItemHeight = 15
        Me.LST_DESC2.Location = New System.Drawing.Point(509, 45)
        Me.LST_DESC2.Name = "LST_DESC2"
        Me.LST_DESC2.Size = New System.Drawing.Size(98, 124)
        Me.LST_DESC2.TabIndex = 4
        '
        'LST_DESC1
        '
        Me.LST_DESC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_DESC1.FormattingEnabled = True
        Me.LST_DESC1.ItemHeight = 15
        Me.LST_DESC1.Location = New System.Drawing.Point(405, 45)
        Me.LST_DESC1.Name = "LST_DESC1"
        Me.LST_DESC1.Size = New System.Drawing.Size(98, 124)
        Me.LST_DESC1.TabIndex = 3
        '
        'LST_SUBTOTAL
        '
        Me.LST_SUBTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_SUBTOTAL.FormattingEnabled = True
        Me.LST_SUBTOTAL.ItemHeight = 15
        Me.LST_SUBTOTAL.Location = New System.Drawing.Point(301, 45)
        Me.LST_SUBTOTAL.Name = "LST_SUBTOTAL"
        Me.LST_SUBTOTAL.Size = New System.Drawing.Size(98, 124)
        Me.LST_SUBTOTAL.TabIndex = 2
        '
        'LST_FUNCIÓN
        '
        Me.LST_FUNCIÓN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_FUNCIÓN.FormattingEnabled = True
        Me.LST_FUNCIÓN.ItemHeight = 15
        Me.LST_FUNCIÓN.Location = New System.Drawing.Point(113, 45)
        Me.LST_FUNCIÓN.Name = "LST_FUNCIÓN"
        Me.LST_FUNCIÓN.Size = New System.Drawing.Size(98, 124)
        Me.LST_FUNCIÓN.TabIndex = 1
        '
        'LST_CINE
        '
        Me.LST_CINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_CINE.FormattingEnabled = True
        Me.LST_CINE.ItemHeight = 15
        Me.LST_CINE.Location = New System.Drawing.Point(6, 45)
        Me.LST_CINE.Name = "LST_CINE"
        Me.LST_CINE.Size = New System.Drawing.Size(98, 124)
        Me.LST_CINE.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Dutch801 XBd BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(359, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NÚMERO DE ENTRADAS"
        '
        'TXT_N_ENTRADAS
        '
        Me.TXT_N_ENTRADAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_N_ENTRADAS.Location = New System.Drawing.Point(397, 133)
        Me.TXT_N_ENTRADAS.Name = "TXT_N_ENTRADAS"
        Me.TXT_N_ENTRADAS.Size = New System.Drawing.Size(118, 22)
        Me.TXT_N_ENTRADAS.TabIndex = 6
        '
        'CINE_PROGRA092
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(747, 439)
        Me.Controls.Add(Me.TXT_N_ENTRADAS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CINE_PROGRA092"
        Me.Text = "CINE :) 201602914"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripLIMPIAR_LISTAS As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTN_ACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LST_TOTAL As System.Windows.Forms.ListBox
    Friend WithEvents LST_DESC2 As System.Windows.Forms.ListBox
    Friend WithEvents LST_DESC1 As System.Windows.Forms.ListBox
    Friend WithEvents LST_SUBTOTAL As System.Windows.Forms.ListBox
    Friend WithEvents LST_FUNCIÓN As System.Windows.Forms.ListBox
    Friend WithEvents LST_CINE As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_N_ENTRADAS As System.Windows.Forms.TextBox
    Friend WithEvents LST_N_ENT As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMB_FUNCION As System.Windows.Forms.ComboBox
    Friend WithEvents CMB_CINE As System.Windows.Forms.ComboBox

End Class
