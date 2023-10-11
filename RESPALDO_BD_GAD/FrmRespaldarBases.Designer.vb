<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRespaldoBase
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
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.CbBasesDeDatos = New System.Windows.Forms.ComboBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.BtnRuta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGenerarRespaldo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRutaRestaurar = New System.Windows.Forms.Button()
        Me.TxtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtBaseRestaurar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(397, 59)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConectar.TabIndex = 0
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'CbBasesDeDatos
        '
        Me.CbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBasesDeDatos.FormattingEnabled = True
        Me.CbBasesDeDatos.Location = New System.Drawing.Point(20, 60)
        Me.CbBasesDeDatos.Name = "CbBasesDeDatos"
        Me.CbBasesDeDatos.Size = New System.Drawing.Size(371, 21)
        Me.CbBasesDeDatos.TabIndex = 1
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(22, 103)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(362, 20)
        Me.txtRuta.TabIndex = 2
        '
        'BtnRuta
        '
        Me.BtnRuta.Location = New System.Drawing.Point(390, 101)
        Me.BtnRuta.Name = "BtnRuta"
        Me.BtnRuta.Size = New System.Drawing.Size(41, 23)
        Me.BtnRuta.TabIndex = 3
        Me.BtnRuta.Text = "..."
        Me.BtnRuta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRuta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Conectar Bases de datos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seleccionar ruta:"
        '
        'BtnGenerarRespaldo
        '
        Me.BtnGenerarRespaldo.Location = New System.Drawing.Point(501, 59)
        Me.BtnGenerarRespaldo.Name = "BtnGenerarRespaldo"
        Me.BtnGenerarRespaldo.Size = New System.Drawing.Size(75, 65)
        Me.BtnGenerarRespaldo.TabIndex = 6
        Me.BtnGenerarRespaldo.Text = "Generar Respaldo"
        Me.BtnGenerarRespaldo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(503, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 65)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Restaurar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Seleccionar ruta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Base a restaurar"
        '
        'BtnRutaRestaurar
        '
        Me.BtnRutaRestaurar.Location = New System.Drawing.Point(392, 180)
        Me.BtnRutaRestaurar.Name = "BtnRutaRestaurar"
        Me.BtnRutaRestaurar.Size = New System.Drawing.Size(41, 23)
        Me.BtnRutaRestaurar.TabIndex = 10
        Me.BtnRutaRestaurar.Text = "..."
        Me.BtnRutaRestaurar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRutaRestaurar.UseVisualStyleBackColor = True
        '
        'TxtRutaRestaurar
        '
        Me.TxtRutaRestaurar.Location = New System.Drawing.Point(24, 182)
        Me.TxtRutaRestaurar.Name = "TxtRutaRestaurar"
        Me.TxtRutaRestaurar.Size = New System.Drawing.Size(362, 20)
        Me.TxtRutaRestaurar.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TxtBaseRestaurar
        '
        Me.TxtBaseRestaurar.Location = New System.Drawing.Point(23, 224)
        Me.TxtBaseRestaurar.Name = "TxtBaseRestaurar"
        Me.TxtBaseRestaurar.Size = New System.Drawing.Size(362, 20)
        Me.TxtBaseRestaurar.TabIndex = 14
        '
        'FrmRespaldoBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(605, 297)
        Me.Controls.Add(Me.TxtBaseRestaurar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRutaRestaurar)
        Me.Controls.Add(Me.TxtRutaRestaurar)
        Me.Controls.Add(Me.BtnGenerarRespaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRuta)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.CbBasesDeDatos)
        Me.Controls.Add(Me.BtnConectar)
        Me.Name = "FrmRespaldoBase"
        Me.Text = "Respaldo de Base de Datos Sistemas GAD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConectar As Button
    Friend WithEvents CbBasesDeDatos As ComboBox
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents BtnRuta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGenerarRespaldo As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnRutaRestaurar As Button
    Friend WithEvents TxtRutaRestaurar As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtBaseRestaurar As TextBox
End Class
