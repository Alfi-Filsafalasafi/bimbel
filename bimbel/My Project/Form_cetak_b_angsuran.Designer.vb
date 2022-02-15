<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_cetak_b_angsuran
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
        Me.report_angsuran = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'report_angsuran
        '
        Me.report_angsuran.ActiveViewIndex = -1
        Me.report_angsuran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.report_angsuran.Cursor = System.Windows.Forms.Cursors.Default
        Me.report_angsuran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_angsuran.Location = New System.Drawing.Point(0, 0)
        Me.report_angsuran.Name = "report_angsuran"
        Me.report_angsuran.Size = New System.Drawing.Size(1370, 749)
        Me.report_angsuran.TabIndex = 0
        '
        'Form_cetak_b_angsuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.report_angsuran)
        Me.Name = "Form_cetak_b_angsuran"
        Me.Text = "CETAK ANGSURAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents report_angsuran As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
