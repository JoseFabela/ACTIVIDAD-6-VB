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
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(184, 137)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(304, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Escribe el nombre de la pelicula su director y su año de estreno"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(292, 301)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Año"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(292, 232)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Pelicula"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(292, 267)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Director"
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(354, 267)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(263, 20)
        Me.txtDirector.TabIndex = 13
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(354, 294)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(263, 20)
        Me.txtAño.TabIndex = 12
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(354, 232)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTitulo.Size = New System.Drawing.Size(263, 20)
        Me.txtTitulo.TabIndex = 11
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(187, 291)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 10
        Me.btnMostrar.Text = "MOSTRAR"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(187, 232)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txtDirector As TextBox
    Private WithEvents txtAño As TextBox
    Private WithEvents txtTitulo As TextBox
    Private WithEvents btnMostrar As Button
    Private WithEvents btnGuardar As Button
End Class
