<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_v_cetak_pendaftaran
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
        Me.report_pendaftaran = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.report_pendaftaran1 = New bimbel.report_pendaftaran()
        Me.SuspendLayout()
        '
        'report_pendaftaran
        '
        Me.report_pendaftaran.ActiveViewIndex = 0
        Me.report_pendaftaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.report_pendaftaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.report_pendaftaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.report_pendaftaran.Location = New System.Drawing.Point(0, 0)
        Me.report_pendaftaran.Name = "report_pendaftaran"
        Me.report_pendaftaran.ReportSource = Me.report_pendaftaran1
        Me.report_pendaftaran.Size = New System.Drawing.Size(1370, 749)
        Me.report_pendaftaran.TabIndex = 0
        '
        'Form_v_cetak_pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.report_pendaftaran)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_v_cetak_pendaftaran"
        Me.Text = "CETAK PENDAFTARAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents report_pendaftaran As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents report_pendaftaran1 As report_pendaftaran
End Class
