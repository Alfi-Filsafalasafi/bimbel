<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cetak_siswa
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
        Me.report_siswa = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.report_siswa1 = New bimbel.report_siswa()
        Me.SuspendLayout()
        '
        'report_siswa
        '
        Me.report_siswa.ActiveViewIndex = 0
        Me.report_siswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.report_siswa.Cursor = System.Windows.Forms.Cursors.Default
        Me.report_siswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_siswa.Location = New System.Drawing.Point(0, 0)
        Me.report_siswa.Name = "report_siswa"
        Me.report_siswa.ReportSource = Me.report_siswa1
        Me.report_siswa.Size = New System.Drawing.Size(1370, 749)
        Me.report_siswa.TabIndex = 0
        '
        'Form_cetak_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.report_siswa)
        Me.Name = "Form_cetak_siswa"
        Me.Text = "Form_cetak_siswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents report_siswa As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents report_siswa1 As report_siswa
End Class
