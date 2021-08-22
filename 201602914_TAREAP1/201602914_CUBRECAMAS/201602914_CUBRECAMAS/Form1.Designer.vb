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
        Me.RBN_IMPERIAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBN_KING = New System.Windows.Forms.RadioButton()
        Me.RBN_QUEEN = New System.Windows.Forms.RadioButton()
        Me.RBN_MATRIMONIAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_HILO = New System.Windows.Forms.TextBox()
        Me.TXT_SEDA = New System.Windows.Forms.TextBox()
        Me.TXT_ALGODON = New System.Windows.Forms.TextBox()
        Me.TXT_LINO = New System.Windows.Forms.TextBox()
        Me.CBX_HILO = New System.Windows.Forms.CheckBox()
        Me.CBX_SEDA = New System.Windows.Forms.CheckBox()
        Me.CBX_ALGODON = New System.Windows.Forms.CheckBox()
        Me.CBX_LINO = New System.Windows.Forms.CheckBox()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.TXT_COSTO = New System.Windows.Forms.TextBox()
        Me.TXT_VENTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBL_HILO = New System.Windows.Forms.Label()
        Me.LBL_SEDA = New System.Windows.Forms.Label()
        Me.LBL_ALGODON = New System.Windows.Forms.Label()
        Me.LBL_LINO = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBN_IMPERIAL
        '
        Me.RBN_IMPERIAL.AutoSize = True
        Me.RBN_IMPERIAL.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RBN_IMPERIAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBN_IMPERIAL.Location = New System.Drawing.Point(18, 36)
        Me.RBN_IMPERIAL.Name = "RBN_IMPERIAL"
        Me.RBN_IMPERIAL.Size = New System.Drawing.Size(75, 17)
        Me.RBN_IMPERIAL.TabIndex = 0
        Me.RBN_IMPERIAL.TabStop = True
        Me.RBN_IMPERIAL.Text = "IMPERIAL"
        Me.RBN_IMPERIAL.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RBN_KING)
        Me.GroupBox1.Controls.Add(Me.RBN_QUEEN)
        Me.GroupBox1.Controls.Add(Me.RBN_MATRIMONIAL)
        Me.GroupBox1.Controls.Add(Me.RBN_IMPERIAL)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(37, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONAR TAMAÑO DE CUBRECAMA:"
        '
        'RBN_KING
        '
        Me.RBN_KING.AutoSize = True
        Me.RBN_KING.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RBN_KING.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBN_KING.Location = New System.Drawing.Point(18, 140)
        Me.RBN_KING.Name = "RBN_KING"
        Me.RBN_KING.Size = New System.Drawing.Size(51, 17)
        Me.RBN_KING.TabIndex = 3
        Me.RBN_KING.TabStop = True
        Me.RBN_KING.Text = "KING"
        Me.RBN_KING.UseVisualStyleBackColor = False
        '
        'RBN_QUEEN
        '
        Me.RBN_QUEEN.AutoSize = True
        Me.RBN_QUEEN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RBN_QUEEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBN_QUEEN.Location = New System.Drawing.Point(18, 105)
        Me.RBN_QUEEN.Name = "RBN_QUEEN"
        Me.RBN_QUEEN.Size = New System.Drawing.Size(63, 17)
        Me.RBN_QUEEN.TabIndex = 2
        Me.RBN_QUEEN.TabStop = True
        Me.RBN_QUEEN.Text = "QUEEN"
        Me.RBN_QUEEN.UseVisualStyleBackColor = False
        '
        'RBN_MATRIMONIAL
        '
        Me.RBN_MATRIMONIAL.AutoSize = True
        Me.RBN_MATRIMONIAL.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RBN_MATRIMONIAL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RBN_MATRIMONIAL.Location = New System.Drawing.Point(18, 67)
        Me.RBN_MATRIMONIAL.Name = "RBN_MATRIMONIAL"
        Me.RBN_MATRIMONIAL.Size = New System.Drawing.Size(100, 17)
        Me.RBN_MATRIMONIAL.TabIndex = 1
        Me.RBN_MATRIMONIAL.TabStop = True
        Me.RBN_MATRIMONIAL.Text = "MATRIMONIAL"
        Me.RBN_MATRIMONIAL.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.TXT_HILO)
        Me.GroupBox2.Controls.Add(Me.TXT_SEDA)
        Me.GroupBox2.Controls.Add(Me.TXT_ALGODON)
        Me.GroupBox2.Controls.Add(Me.TXT_LINO)
        Me.GroupBox2.Controls.Add(Me.CBX_HILO)
        Me.GroupBox2.Controls.Add(Me.CBX_SEDA)
        Me.GroupBox2.Controls.Add(Me.CBX_ALGODON)
        Me.GroupBox2.Controls.Add(Me.CBX_LINO)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(304, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 168)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONAR MATERIAL"
        '
        'TXT_HILO
        '
        Me.TXT_HILO.Location = New System.Drawing.Point(113, 140)
        Me.TXT_HILO.Name = "TXT_HILO"
        Me.TXT_HILO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_HILO.TabIndex = 7
        Me.TXT_HILO.Visible = False
        '
        'TXT_SEDA
        '
        Me.TXT_SEDA.Location = New System.Drawing.Point(113, 105)
        Me.TXT_SEDA.Name = "TXT_SEDA"
        Me.TXT_SEDA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_SEDA.TabIndex = 6
        Me.TXT_SEDA.Visible = False
        '
        'TXT_ALGODON
        '
        Me.TXT_ALGODON.Location = New System.Drawing.Point(113, 67)
        Me.TXT_ALGODON.Name = "TXT_ALGODON"
        Me.TXT_ALGODON.Size = New System.Drawing.Size(100, 20)
        Me.TXT_ALGODON.TabIndex = 5
        Me.TXT_ALGODON.Visible = False
        '
        'TXT_LINO
        '
        Me.TXT_LINO.Location = New System.Drawing.Point(113, 33)
        Me.TXT_LINO.Name = "TXT_LINO"
        Me.TXT_LINO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_LINO.TabIndex = 4
        Me.TXT_LINO.Visible = False
        '
        'CBX_HILO
        '
        Me.CBX_HILO.AutoSize = True
        Me.CBX_HILO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBX_HILO.Location = New System.Drawing.Point(6, 143)
        Me.CBX_HILO.Name = "CBX_HILO"
        Me.CBX_HILO.Size = New System.Drawing.Size(93, 17)
        Me.CBX_HILO.TabIndex = 3
        Me.CBX_HILO.Text = "HILO CRUDO"
        Me.CBX_HILO.UseVisualStyleBackColor = False
        '
        'CBX_SEDA
        '
        Me.CBX_SEDA.AutoSize = True
        Me.CBX_SEDA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBX_SEDA.Location = New System.Drawing.Point(6, 109)
        Me.CBX_SEDA.Name = "CBX_SEDA"
        Me.CBX_SEDA.Size = New System.Drawing.Size(55, 17)
        Me.CBX_SEDA.TabIndex = 2
        Me.CBX_SEDA.Text = "SEDA"
        Me.CBX_SEDA.UseVisualStyleBackColor = False
        '
        'CBX_ALGODON
        '
        Me.CBX_ALGODON.AutoSize = True
        Me.CBX_ALGODON.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBX_ALGODON.Location = New System.Drawing.Point(6, 70)
        Me.CBX_ALGODON.Name = "CBX_ALGODON"
        Me.CBX_ALGODON.Size = New System.Drawing.Size(79, 17)
        Me.CBX_ALGODON.TabIndex = 1
        Me.CBX_ALGODON.Text = "ALGODÓN"
        Me.CBX_ALGODON.UseVisualStyleBackColor = False
        '
        'CBX_LINO
        '
        Me.CBX_LINO.AutoSize = True
        Me.CBX_LINO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBX_LINO.Location = New System.Drawing.Point(7, 33)
        Me.CBX_LINO.Name = "CBX_LINO"
        Me.CBX_LINO.Size = New System.Drawing.Size(51, 17)
        Me.CBX_LINO.TabIndex = 0
        Me.CBX_LINO.Text = "LINO"
        Me.CBX_LINO.UseVisualStyleBackColor = False
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(635, 155)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(120, 54)
        Me.BTN_CALCULAR.TabIndex = 3
        Me.BTN_CALCULAR.Text = "CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = False
        '
        'TXT_COSTO
        '
        Me.TXT_COSTO.Enabled = False
        Me.TXT_COSTO.Location = New System.Drawing.Point(126, 33)
        Me.TXT_COSTO.Name = "TXT_COSTO"
        Me.TXT_COSTO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_COSTO.TabIndex = 4
        '
        'TXT_VENTA
        '
        Me.TXT_VENTA.Enabled = False
        Me.TXT_VENTA.Location = New System.Drawing.Point(126, 65)
        Me.TXT_VENTA.Name = "TXT_VENTA"
        Me.TXT_VENTA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_VENTA.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PRECIO DE COSTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PRECIO DE VENTA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBL_HILO)
        Me.GroupBox3.Controls.Add(Me.LBL_SEDA)
        Me.GroupBox3.Controls.Add(Me.LBL_ALGODON)
        Me.GroupBox3.Controls.Add(Me.LBL_LINO)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 114)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COSTOS DE MATERIALES"
        '
        'LBL_HILO
        '
        Me.LBL_HILO.AutoSize = True
        Me.LBL_HILO.Location = New System.Drawing.Point(199, 72)
        Me.LBL_HILO.Name = "LBL_HILO"
        Me.LBL_HILO.Size = New System.Drawing.Size(112, 13)
        Me.LBL_HILO.TabIndex = 3
        Me.LBL_HILO.Text = "Total a pagar por Hilo:"
        '
        'LBL_SEDA
        '
        Me.LBL_SEDA.AutoSize = True
        Me.LBL_SEDA.Location = New System.Drawing.Point(199, 40)
        Me.LBL_SEDA.Name = "LBL_SEDA"
        Me.LBL_SEDA.Size = New System.Drawing.Size(119, 13)
        Me.LBL_SEDA.TabIndex = 2
        Me.LBL_SEDA.Text = "Total a pagar por Seda:"
        '
        'LBL_ALGODON
        '
        Me.LBL_ALGODON.AutoSize = True
        Me.LBL_ALGODON.Location = New System.Drawing.Point(6, 72)
        Me.LBL_ALGODON.Name = "LBL_ALGODON"
        Me.LBL_ALGODON.Size = New System.Drawing.Size(133, 13)
        Me.LBL_ALGODON.TabIndex = 1
        Me.LBL_ALGODON.Text = "Total a pagar por Algodón:"
        '
        'LBL_LINO
        '
        Me.LBL_LINO.AutoSize = True
        Me.LBL_LINO.Location = New System.Drawing.Point(6, 40)
        Me.LBL_LINO.Name = "LBL_LINO"
        Me.LBL_LINO.Size = New System.Drawing.Size(110, 13)
        Me.LBL_LINO.TabIndex = 0
        Me.LBL_LINO.Text = "Total a pagar por lino:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TXT_COSTO)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TXT_VENTA)
        Me.GroupBox4.Location = New System.Drawing.Point(436, 279)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(268, 114)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PRECIOS"
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(635, 98)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(120, 40)
        Me.BTN_LIMPIAR.TabIndex = 10
        Me.BTN_LIMPIAR.Text = "LIMPIAR"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_SALIR.Location = New System.Drawing.Point(635, 41)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(120, 40)
        Me.BTN_SALIR.TabIndex = 11
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(771, 449)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_LIMPIAR)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTN_CALCULAR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RBN_IMPERIAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBN_KING As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_QUEEN As System.Windows.Forms.RadioButton
    Friend WithEvents RBN_MATRIMONIAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBX_HILO As System.Windows.Forms.CheckBox
    Friend WithEvents CBX_SEDA As System.Windows.Forms.CheckBox
    Friend WithEvents CBX_ALGODON As System.Windows.Forms.CheckBox
    Friend WithEvents CBX_LINO As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_HILO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SEDA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ALGODON As System.Windows.Forms.TextBox
    Friend WithEvents TXT_LINO As System.Windows.Forms.TextBox
    Friend WithEvents BTN_CALCULAR As System.Windows.Forms.Button
    Friend WithEvents TXT_COSTO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_HILO As System.Windows.Forms.Label
    Friend WithEvents LBL_SEDA As System.Windows.Forms.Label
    Friend WithEvents LBL_ALGODON As System.Windows.Forms.Label
    Friend WithEvents LBL_LINO As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_LIMPIAR As System.Windows.Forms.Button
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button

End Class
