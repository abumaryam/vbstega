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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textboxImage = New System.Windows.Forms.RichTextBox()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.boxGambar = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnASCII = New System.Windows.Forms.Button()
        Me.TbInputASCII = New System.Windows.Forms.TextBox()
        Me.TbOutputASCII = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.boxGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textboxImage)
        Me.GroupBox1.Controls.Add(Me.btnImage)
        Me.GroupBox1.Controls.Add(Me.boxGambar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 168)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image"
        '
        'textboxImage
        '
        Me.textboxImage.Location = New System.Drawing.Point(83, 19)
        Me.textboxImage.Name = "textboxImage"
        Me.textboxImage.Size = New System.Drawing.Size(440, 143)
        Me.textboxImage.TabIndex = 2
        Me.textboxImage.Text = ""
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(544, 20)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(75, 23)
        Me.btnImage.TabIndex = 1
        Me.btnImage.Text = "Proses"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'boxGambar
        '
        Me.boxGambar.Image = CType(resources.GetObject("boxGambar.Image"), System.Drawing.Image)
        Me.boxGambar.InitialImage = Nothing
        Me.boxGambar.Location = New System.Drawing.Point(7, 20)
        Me.boxGambar.Name = "boxGambar"
        Me.boxGambar.Size = New System.Drawing.Size(10, 10)
        Me.boxGambar.TabIndex = 0
        Me.boxGambar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TbOutputASCII)
        Me.GroupBox2.Controls.Add(Me.TbInputASCII)
        Me.GroupBox2.Controls.Add(Me.btnASCII)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 190)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ASCII"
        '
        'btnASCII
        '
        Me.btnASCII.Location = New System.Drawing.Point(544, 20)
        Me.btnASCII.Name = "btnASCII"
        Me.btnASCII.Size = New System.Drawing.Size(75, 23)
        Me.btnASCII.TabIndex = 0
        Me.btnASCII.Text = "Proses"
        Me.btnASCII.UseVisualStyleBackColor = True
        '
        'TbInputASCII
        '
        Me.TbInputASCII.Location = New System.Drawing.Point(6, 42)
        Me.TbInputASCII.Name = "TbInputASCII"
        Me.TbInputASCII.Size = New System.Drawing.Size(100, 20)
        Me.TbInputASCII.TabIndex = 1
        '
        'TbOutputASCII
        '
        Me.TbOutputASCII.Location = New System.Drawing.Point(128, 20)
        Me.TbOutputASCII.Name = "TbOutputASCII"
        Me.TbOutputASCII.Size = New System.Drawing.Size(395, 118)
        Me.TbOutputASCII.TabIndex = 2
        Me.TbOutputASCII.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 405)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.boxGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents boxGambar As PictureBox
    Friend WithEvents btnImage As Button
    Friend WithEvents textboxImage As RichTextBox
    Friend WithEvents btnASCII As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbOutputASCII As RichTextBox
    Friend WithEvents TbInputASCII As TextBox
End Class
