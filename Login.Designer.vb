<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Image = My.Resources.Resources.undraw_building_websites_i78t
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1330, 1149)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Black", 20.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(1465, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 56)
        Label1.TabIndex = 1
        Label1.Text = "BIENVENUE!"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15.0F)
        Label2.ForeColor = SystemColors.HighlightText
        Label2.Location = New Point(1465, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 46)
        Label2.TabIndex = 2
        Label2.Text = "nom d'utilisateur:"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 15.0F)
        Label3.ForeColor = SystemColors.HighlightText
        Label3.Location = New Point(1465, 481)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 38)
        Label3.TabIndex = 3
        Label3.Text = "Mot de Passe:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1465, 338)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(321, 48)
        TextBox1.TabIndex = 4
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1465, 565)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(321, 50)
        TextBox2.TabIndex = 5
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.ForeColor = SystemColors.ControlLightLight
        CheckBox1.Location = New Point(1533, 761)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(200, 29)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Voir le mot de passe"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 20.0F)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(1490, 918)
        Button1.Name = "Button1"
        Button1.Size = New Size(284, 85)
        Button1.TabIndex = 7
        Button1.Text = "Connexion"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_Account_50px
        PictureBox2.Location = New Point(1386, 323)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(73, 80)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_Secure_50px
        PictureBox3.Location = New Point(1386, 552)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 90)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1924, 1050)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Login"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
