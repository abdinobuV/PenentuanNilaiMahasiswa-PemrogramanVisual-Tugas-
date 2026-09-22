<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox_DataMahasiswa = New GroupBox()
        Label_NIM = New Label()
        TextBox_NIM = New TextBox()
        Label_Nama = New Label()
        TextBox_Nama = New TextBox()
        Label_Nilai = New Label()
        TextBox_Nilai = New TextBox()
        Label_Status = New Label()
        ComboBox_Status = New ComboBox()
        GroupBox_Hasil = New GroupBox()
        Label_TitlePredikat = New Label()
        Label_Predikat = New Label()
        Label_TitleKeterangan = New Label()
        Label_Keterangan = New Label()
        Button_Proses = New Button()
        Button_Reset = New Button()
        GroupBox_DataMahasiswa.SuspendLayout()
        GroupBox_Hasil.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox_DataMahasiswa
        ' 
        GroupBox_DataMahasiswa.Controls.Add(Label_NIM)
        GroupBox_DataMahasiswa.Controls.Add(TextBox_NIM)
        GroupBox_DataMahasiswa.Controls.Add(Label_Nama)
        GroupBox_DataMahasiswa.Controls.Add(TextBox_Nama)
        GroupBox_DataMahasiswa.Controls.Add(Label_Nilai)
        GroupBox_DataMahasiswa.Controls.Add(TextBox_Nilai)
        GroupBox_DataMahasiswa.Controls.Add(Label_Status)
        GroupBox_DataMahasiswa.Controls.Add(ComboBox_Status)
        GroupBox_DataMahasiswa.Location = New Point(29, 33)
        GroupBox_DataMahasiswa.Margin = New Padding(4, 5, 4, 5)
        GroupBox_DataMahasiswa.Name = "GroupBox_DataMahasiswa"
        GroupBox_DataMahasiswa.Padding = New Padding(4, 5, 4, 5)
        GroupBox_DataMahasiswa.Size = New Size(571, 300)
        GroupBox_DataMahasiswa.TabIndex = 0
        GroupBox_DataMahasiswa.TabStop = False
        GroupBox_DataMahasiswa.Text = "Data Mahasiswa"
        ' 
        ' Label_NIM
        ' 
        Label_NIM.AutoSize = True
        Label_NIM.Location = New Point(29, 58)
        Label_NIM.Margin = New Padding(4, 0, 4, 0)
        Label_NIM.Name = "Label_NIM"
        Label_NIM.Size = New Size(50, 25)
        Label_NIM.TabIndex = 0
        Label_NIM.Text = "NIM:"
        ' 
        ' TextBox_NIM
        ' 
        TextBox_NIM.Location = New Point(200, 53)
        TextBox_NIM.Margin = New Padding(4, 5, 4, 5)
        TextBox_NIM.Name = "TextBox_NIM"
        TextBox_NIM.Size = New Size(341, 31)
        TextBox_NIM.TabIndex = 1
        ' 
        ' Label_Nama
        ' 
        Label_Nama.AutoSize = True
        Label_Nama.Location = New Point(29, 117)
        Label_Nama.Margin = New Padding(4, 0, 4, 0)
        Label_Nama.Name = "Label_Nama"
        Label_Nama.Size = New Size(63, 25)
        Label_Nama.TabIndex = 2
        Label_Nama.Text = "Nama:"
        ' 
        ' TextBox_Nama
        ' 
        TextBox_Nama.Location = New Point(200, 112)
        TextBox_Nama.Margin = New Padding(4, 5, 4, 5)
        TextBox_Nama.Name = "TextBox_Nama"
        TextBox_Nama.Size = New Size(341, 31)
        TextBox_Nama.TabIndex = 3
        ' 
        ' Label_Nilai
        ' 
        Label_Nilai.AutoSize = True
        Label_Nilai.Location = New Point(29, 175)
        Label_Nilai.Margin = New Padding(4, 0, 4, 0)
        Label_Nilai.Name = "Label_Nilai"
        Label_Nilai.Size = New Size(96, 25)
        Label_Nilai.TabIndex = 4
        Label_Nilai.Text = "Nilai Akhir:"
        ' 
        ' TextBox_Nilai
        ' 
        TextBox_Nilai.Location = New Point(200, 170)
        TextBox_Nilai.Margin = New Padding(4, 5, 4, 5)
        TextBox_Nilai.Name = "TextBox_Nilai"
        TextBox_Nilai.Size = New Size(141, 31)
        TextBox_Nilai.TabIndex = 5
        ' 
        ' Label_Status
        ' 
        Label_Status.AutoSize = True
        Label_Status.Location = New Point(29, 233)
        Label_Status.Margin = New Padding(4, 0, 4, 0)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(155, 25)
        Label_Status.TabIndex = 6
        Label_Status.Text = "Status Mahasiswa:"
        ' 
        ' ComboBox_Status
        ' 
        ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox_Status.FormattingEnabled = True
        ComboBox_Status.Items.AddRange(New Object() {"Aktif", "Cuti", "Non-Aktif", "Lulus"})
        ComboBox_Status.Location = New Point(200, 228)
        ComboBox_Status.Margin = New Padding(4, 5, 4, 5)
        ComboBox_Status.Name = "ComboBox_Status"
        ComboBox_Status.Size = New Size(341, 33)
        ComboBox_Status.TabIndex = 7
        ' 
        ' GroupBox_Hasil
        ' 
        GroupBox_Hasil.Controls.Add(Label_TitlePredikat)
        GroupBox_Hasil.Controls.Add(Label_Predikat)
        GroupBox_Hasil.Controls.Add(Label_TitleKeterangan)
        GroupBox_Hasil.Controls.Add(Label_Keterangan)
        GroupBox_Hasil.Location = New Point(29, 367)
        GroupBox_Hasil.Margin = New Padding(4, 5, 4, 5)
        GroupBox_Hasil.Name = "GroupBox_Hasil"
        GroupBox_Hasil.Padding = New Padding(4, 5, 4, 5)
        GroupBox_Hasil.Size = New Size(571, 183)
        GroupBox_Hasil.TabIndex = 1
        GroupBox_Hasil.TabStop = False
        GroupBox_Hasil.Text = "Hasil"
        ' 
        ' Label_TitlePredikat
        ' 
        Label_TitlePredikat.AutoSize = True
        Label_TitlePredikat.Location = New Point(29, 58)
        Label_TitlePredikat.Margin = New Padding(4, 0, 4, 0)
        Label_TitlePredikat.Name = "Label_TitlePredikat"
        Label_TitlePredikat.Size = New Size(80, 25)
        Label_TitlePredikat.TabIndex = 0
        Label_TitlePredikat.Text = "Predikat:"
        ' 
        ' Label_Predikat
        ' 
        Label_Predikat.AutoSize = True
        Label_Predikat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label_Predikat.Location = New Point(200, 58)
        Label_Predikat.Margin = New Padding(4, 0, 4, 0)
        Label_Predikat.Name = "Label_Predikat"
        Label_Predikat.Size = New Size(19, 25)
        Label_Predikat.TabIndex = 1
        Label_Predikat.Text = "-"
        ' 
        ' Label_TitleKeterangan
        ' 
        Label_TitleKeterangan.AutoSize = True
        Label_TitleKeterangan.Location = New Point(29, 117)
        Label_TitleKeterangan.Margin = New Padding(4, 0, 4, 0)
        Label_TitleKeterangan.Name = "Label_TitleKeterangan"
        Label_TitleKeterangan.Size = New Size(105, 25)
        Label_TitleKeterangan.TabIndex = 2
        Label_TitleKeterangan.Text = "Keterangan:"
        ' 
        ' Label_Keterangan
        ' 
        Label_Keterangan.AutoSize = True
        Label_Keterangan.Location = New Point(200, 117)
        Label_Keterangan.Margin = New Padding(4, 0, 4, 0)
        Label_Keterangan.Name = "Label_Keterangan"
        Label_Keterangan.Size = New Size(19, 25)
        Label_Keterangan.TabIndex = 3
        Label_Keterangan.Text = "-"
        ' 
        ' Button_Proses
        ' 
        Button_Proses.Location = New Point(343, 583)
        Button_Proses.Margin = New Padding(4, 5, 4, 5)
        Button_Proses.Name = "Button_Proses"
        Button_Proses.Size = New Size(121, 50)
        Button_Proses.TabIndex = 2
        Button_Proses.Text = "Proses"
        Button_Proses.UseVisualStyleBackColor = True
        ' 
        ' Button_Reset
        ' 
        Button_Reset.Location = New Point(479, 583)
        Button_Reset.Margin = New Padding(4, 5, 4, 5)
        Button_Reset.Name = "Button_Reset"
        Button_Reset.Size = New Size(121, 50)
        Button_Reset.TabIndex = 3
        Button_Reset.Text = "Reset"
        Button_Reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 668)
        Controls.Add(Button_Reset)
        Controls.Add(Button_Proses)
        Controls.Add(GroupBox_Hasil)
        Controls.Add(GroupBox_DataMahasiswa)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Penentuan Nilai dan Predikat Mahasiswa"
        GroupBox_DataMahasiswa.ResumeLayout(False)
        GroupBox_DataMahasiswa.PerformLayout()
        GroupBox_Hasil.ResumeLayout(False)
        GroupBox_Hasil.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_DataMahasiswa As System.Windows.Forms.GroupBox
    Friend WithEvents Label_NIM As System.Windows.Forms.Label
    Friend WithEvents TextBox_NIM As System.Windows.Forms.TextBox
    Friend WithEvents Label_Nama As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nama As System.Windows.Forms.TextBox
    Friend WithEvents Label_Nilai As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nilai As System.Windows.Forms.TextBox
    Friend WithEvents Label_Status As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Status As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox_Hasil As System.Windows.Forms.GroupBox
    Friend WithEvents Label_TitlePredikat As System.Windows.Forms.Label
    Friend WithEvents Label_Predikat As System.Windows.Forms.Label
    Friend WithEvents Label_TitleKeterangan As System.Windows.Forms.Label
    Friend WithEvents Label_Keterangan As System.Windows.Forms.Label
    Friend WithEvents Button_Proses As System.Windows.Forms.Button
    Friend WithEvents Button_Reset As System.Windows.Forms.Button
End Class
