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
        Me.components = New System.ComponentModel.Container()
        Me.LblHost = New System.Windows.Forms.Label()
        Me.DgvLobby = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnStartHost = New System.Windows.Forms.Button()
        Me.BtnCreateLobby = New System.Windows.Forms.Button()
        Me.TimerHostChecking = New System.Windows.Forms.Timer(Me.components)
        Me.BtnEnterLobby = New System.Windows.Forms.Button()
        CType(Me.DgvLobby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHost
        '
        Me.LblHost.AutoSize = True
        Me.LblHost.Location = New System.Drawing.Point(28, 20)
        Me.LblHost.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblHost.Name = "LblHost"
        Me.LblHost.Size = New System.Drawing.Size(52, 25)
        Me.LblHost.TabIndex = 0
        Me.LblHost.Text = "Host"
        '
        'DgvLobby
        '
        Me.DgvLobby.AllowUserToAddRows = False
        Me.DgvLobby.AllowUserToDeleteRows = False
        Me.DgvLobby.AllowUserToResizeColumns = False
        Me.DgvLobby.AllowUserToResizeRows = False
        Me.DgvLobby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLobby.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DgvLobby.Location = New System.Drawing.Point(33, 70)
        Me.DgvLobby.Margin = New System.Windows.Forms.Padding(6)
        Me.DgvLobby.Name = "DgvLobby"
        Me.DgvLobby.ReadOnly = True
        Me.DgvLobby.RowHeadersVisible = False
        Me.DgvLobby.Size = New System.Drawing.Size(779, 288)
        Me.DgvLobby.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Lobby"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Player1"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Player2"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'BtnStartHost
        '
        Me.BtnStartHost.Location = New System.Drawing.Point(700, 20)
        Me.BtnStartHost.Name = "BtnStartHost"
        Me.BtnStartHost.Size = New System.Drawing.Size(112, 41)
        Me.BtnStartHost.TabIndex = 2
        Me.BtnStartHost.Text = "Start Host"
        Me.BtnStartHost.UseVisualStyleBackColor = True
        '
        'BtnCreateLobby
        '
        Me.BtnCreateLobby.Location = New System.Drawing.Point(674, 367)
        Me.BtnCreateLobby.Name = "BtnCreateLobby"
        Me.BtnCreateLobby.Size = New System.Drawing.Size(138, 41)
        Me.BtnCreateLobby.TabIndex = 3
        Me.BtnCreateLobby.Text = "Create Lobby"
        Me.BtnCreateLobby.UseVisualStyleBackColor = True
        '
        'TimerHostChecking
        '
        Me.TimerHostChecking.Enabled = True
        Me.TimerHostChecking.Interval = 2000
        '
        'BtnEnterLobby
        '
        Me.BtnEnterLobby.Location = New System.Drawing.Point(515, 367)
        Me.BtnEnterLobby.Name = "BtnEnterLobby"
        Me.BtnEnterLobby.Size = New System.Drawing.Size(138, 41)
        Me.BtnEnterLobby.TabIndex = 4
        Me.BtnEnterLobby.Text = "Enter Lobby"
        Me.BtnEnterLobby.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 435)
        Me.Controls.Add(Me.BtnEnterLobby)
        Me.Controls.Add(Me.BtnCreateLobby)
        Me.Controls.Add(Me.BtnStartHost)
        Me.Controls.Add(Me.DgvLobby)
        Me.Controls.Add(Me.LblHost)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.DgvLobby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHost As Label
    Friend WithEvents DgvLobby As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnStartHost As Button
    Friend WithEvents BtnCreateLobby As Button
    Friend WithEvents TimerHostChecking As Timer
    Friend WithEvents BtnEnterLobby As Button
End Class
