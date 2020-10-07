<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdministrador
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.dashboradTb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.cbMostrar = New System.Windows.Forms.ComboBox()
        Me.Mostrar = New System.Windows.Forms.Label()
        Me.eliminarBtn = New System.Windows.Forms.Button()
        Me.actualizarBtn = New System.Windows.Forms.Button()
        Me.crearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cerrarSesionBtn = New System.Windows.Forms.Button()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reportCb = New System.Windows.Forms.ComboBox()
        Me.datosDv = New System.Windows.Forms.DataGridView()
        Me.reportChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.dashboradTb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.datosDv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboradTb
        '
        Me.dashboradTb.Controls.Add(Me.TabPage1)
        Me.dashboradTb.Controls.Add(Me.TabPage2)
        Me.dashboradTb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboradTb.Location = New System.Drawing.Point(0, 0)
        Me.dashboradTb.Name = "dashboradTb"
        Me.dashboradTb.SelectedIndex = 0
        Me.dashboradTb.Size = New System.Drawing.Size(849, 500)
        Me.dashboradTb.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.dashboradTb.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvDatos)
        Me.TabPage1.Controls.Add(Me.cbMostrar)
        Me.TabPage1.Controls.Add(Me.Mostrar)
        Me.TabPage1.Controls.Add(Me.eliminarBtn)
        Me.TabPage1.Controls.Add(Me.actualizarBtn)
        Me.TabPage1.Controls.Add(Me.crearBtn)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(15, 110)
        Me.dgvDatos.MultiSelect = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RowHeadersWidth = 51
        Me.dgvDatos.RowTemplate.Height = 24
        Me.dgvDatos.Size = New System.Drawing.Size(765, 241)
        Me.dgvDatos.TabIndex = 7
        '
        'cbMostrar
        '
        Me.cbMostrar.FormattingEnabled = True
        Me.cbMostrar.Items.AddRange(New Object() {"Empleados", "Sucursales", "Productos"})
        Me.cbMostrar.Location = New System.Drawing.Point(105, 80)
        Me.cbMostrar.Name = "cbMostrar"
        Me.cbMostrar.Size = New System.Drawing.Size(233, 24)
        Me.cbMostrar.TabIndex = 6
        '
        'Mostrar
        '
        Me.Mostrar.AutoSize = True
        Me.Mostrar.Location = New System.Drawing.Point(15, 80)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(56, 17)
        Me.Mostrar.TabIndex = 5
        Me.Mostrar.Text = "Mostrar"
        '
        'eliminarBtn
        '
        Me.eliminarBtn.Location = New System.Drawing.Point(566, 368)
        Me.eliminarBtn.Name = "eliminarBtn"
        Me.eliminarBtn.Size = New System.Drawing.Size(214, 46)
        Me.eliminarBtn.TabIndex = 4
        Me.eliminarBtn.Text = "Eliminar"
        Me.eliminarBtn.UseVisualStyleBackColor = True
        '
        'actualizarBtn
        '
        Me.actualizarBtn.Location = New System.Drawing.Point(277, 368)
        Me.actualizarBtn.Name = "actualizarBtn"
        Me.actualizarBtn.Size = New System.Drawing.Size(214, 46)
        Me.actualizarBtn.TabIndex = 3
        Me.actualizarBtn.Text = "Actualizar"
        Me.actualizarBtn.UseVisualStyleBackColor = True
        '
        'crearBtn
        '
        Me.crearBtn.Location = New System.Drawing.Point(15, 368)
        Me.crearBtn.Name = "crearBtn"
        Me.crearBtn.Size = New System.Drawing.Size(194, 46)
        Me.crearBtn.TabIndex = 2
        Me.crearBtn.Text = "Crear"
        Me.crearBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cerrarSesionBtn)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del administrador"
        '
        'cerrarSesionBtn
        '
        Me.cerrarSesionBtn.Location = New System.Drawing.Point(648, 16)
        Me.cerrarSesionBtn.Name = "cerrarSesionBtn"
        Me.cerrarSesionBtn.Size = New System.Drawing.Size(111, 38)
        Me.cerrarSesionBtn.TabIndex = 4
        Me.cerrarSesionBtn.Text = "Cerrar sesion"
        Me.cerrarSesionBtn.UseVisualStyleBackColor = True
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(425, 26)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(51, 17)
        Me.lblCorreo.TabIndex = 3
        Me.lblCorreo.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Correo"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(71, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 17)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cbSucursal)
        Me.TabPage2.Controls.Add(Me.lblSucursal)
        Me.TabPage2.Controls.Add(Me.reportChart)
        Me.TabPage2.Controls.Add(Me.datosDv)
        Me.TabPage2.Controls.Add(Me.reportCb)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(841, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo de reporte"
        '
        'reportCb
        '
        Me.reportCb.FormattingEnabled = True
        Me.reportCb.Items.AddRange(New Object() {"Ordenes hechas", "Ventas por sucursal", "Ventas por empleado", "Top 3 sucursales donde se vendio mas pizza", "Top 3 sucursales donde se vendieron mas bebidas"})
        Me.reportCb.Location = New System.Drawing.Point(128, 22)
        Me.reportCb.Name = "reportCb"
        Me.reportCb.Size = New System.Drawing.Size(368, 24)
        Me.reportCb.TabIndex = 1
        '
        'datosDv
        '
        Me.datosDv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosDv.Location = New System.Drawing.Point(19, 100)
        Me.datosDv.Name = "datosDv"
        Me.datosDv.RowHeadersWidth = 51
        Me.datosDv.RowTemplate.Height = 24
        Me.datosDv.Size = New System.Drawing.Size(329, 350)
        Me.datosDv.TabIndex = 2
        '
        'reportChart
        '
        ChartArea4.Name = "ChartArea1"
        Me.reportChart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.reportChart.Legends.Add(Legend4)
        Me.reportChart.Location = New System.Drawing.Point(372, 100)
        Me.reportChart.Name = "reportChart"
        Me.reportChart.Size = New System.Drawing.Size(461, 350)
        Me.reportChart.TabIndex = 3
        Me.reportChart.Text = "Chart1"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(16, 62)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(63, 17)
        Me.lblSucursal.TabIndex = 4
        Me.lblSucursal.Text = "Surcusal"
        Me.lblSucursal.Visible = False
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(128, 62)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(220, 24)
        Me.cbSucursal.TabIndex = 5
        Me.cbSucursal.Visible = False
        '
        'DashboardAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 500)
        Me.Controls.Add(Me.dashboradTb)
        Me.Name = "DashboardAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardAdministrador"
        Me.dashboradTb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datosDv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashboradTb As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents cbMostrar As ComboBox
    Friend WithEvents Mostrar As Label
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents actualizarBtn As Button
    Friend WithEvents crearBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cerrarSesionBtn As Button
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents reportChart As DataVisualization.Charting.Chart
    Friend WithEvents datosDv As DataGridView
    Friend WithEvents reportCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents lblSucursal As Label
End Class
