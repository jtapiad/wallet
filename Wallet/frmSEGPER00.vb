Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core

Public Class frmSEGPER00
    Dim TagPER As Accion
    ''' <summary>
    ''' Carga el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSEGPER00_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)

    End Sub

    ''' <summary>
    ''' Abre el formulario para agregar nuevo perfil
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Entrega el tag sin código y con acción 1</remarks>
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        TagPER.Accion = 1
        TagPER.Codigo = String.Empty
        frmSEGPER01.Tag = TagPER
        frmSEGPER01.MdiParent = Me.MdiParent
        frmSEGPER01.Show()

    End Sub

    ''' <summary>
    ''' Abre el formulario de detalle para modificar el perfil existente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Entrega el tag con el código seleccionado y con acción 2</remarks>
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        TagPER.Accion = 2
        TagPER.Codigo = Me.lstPerfiles.SelectedValue
        frmSEGPER01.Tag = TagPER
        frmSEGPER01.MdiParent = Me.MdiParent
        frmSEGPER01.Show()

    End Sub

    ''' <summary>
    ''' Abre el formulario de detalle para elimiar el perfil existente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFiniquitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiniquitar.Click

        TagPER.Accion = 3
        TagPER.Codigo = Me.lstPerfiles.SelectedValue
        frmSEGPER01.Tag = TagPER
        frmSEGPER01.MdiParent = Me.MdiParent
        frmSEGPER01.Show()

    End Sub

    ''' <summary>
    ''' Exporta los datos a Excel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        ExportaDatosExcel()

    End Sub

    ''' <summary>
    ''' Sale de la pantalla de resumen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    ''' <summary>
    ''' Refresca el listbox con los perfiles disponibles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click

        Me.SEGPERTableAdapter.Fill(Me.DsSEGPER.SEGPER)

    End Sub

    ''' <summary>
    ''' Al hacer el doble clic en el listado de perfiles disponibles, abre el seleccionado para editarlo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPerfiles.DoubleClick
        TagPER.Accion = 2
        TagPER.Codigo = Me.lstPerfiles.SelectedValue
        frmSEGPER01.Tag = TagPER
        frmSEGPER01.MdiParent = Me.MdiParent
        frmSEGPER01.Show()
    End Sub

    ''' <summary>
    ''' Dependiendo de la tecla que se presione en el listado de perfiles disponibles, crea uno nuevo o abre la pantalla de detalle para eliminar el seleccionado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lstPerfiles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPerfiles.KeyDown
        'Si se presiona Delete con un usuario seleccionado, se abre SEGPER01, opción Eliminar
        If e.KeyData = Keys.Delete Then
            TagPER.Accion = 3
            TagPER.Codigo = Me.lstPerfiles.SelectedValue
            frmSEGPER01.Tag = TagPER
            frmSEGPER01.MdiParent = Me.MdiParent
            frmSEGPER01.Show()
            Me.lstPerfiles.Refresh()
        End If
        'Si se presiona Insert con un centro seleccionado, se abre SEGPER01, opción Agregar
        If e.KeyData = Keys.Insert Then
            TagPER.Accion = 1
            TagPER.Codigo = 0
            frmSEGPER01.Tag = TagPER
            frmSEGPER01.MdiParent = Me.MdiParent
            frmSEGPER01.Show()
            Me.lstPerfiles.Refresh()
        End If
    End Sub

#Region "Excel"

    ''' <summary>
    ''' Contiene todo lo necesario para hacer el reporte de Excel
    ''' </summary>
    ''' <remarks>Hace la exportación a Excel desde un DataTable
    '''  Llama a GuardaFoto para sacar de los recursos los logos y luego BorraFoto 
    ''' para borrar los logos y así impedir que los modifiquen o alteren</remarks>
    Private Sub ExportaDatosExcel()

        'Creo variables de DataTable y Table Adapter
        Dim da As New dsSEGPER.SEGPERDataTable
        Dim dt As New dsSEGPERTableAdapters.SEGPERTableAdapter

        dt.Fill(da)

        'Abro Excel
        Dim m_excel As New Excel.Application
        'pongo el cursor de espera
        m_excel.Cursor = Excel.XlMousePointer.xlWait
        'hago visible la hoja de cálculo
        m_excel.Visible = True
        'creo el libro de excel
        Dim LibroExcel As Excel.Workbook = m_excel.Workbooks.Add
        'creo la hoja del libro
        Dim HojaExcel As Excel.Worksheet = LibroExcel.Worksheets(1)
        'en la hoja del libro creo el encabezado
        Dim Logo2sys As New Bitmap(My.Resources.logo)
        'Poner el logo del sistema que se está creando
        'Dim LogoPREGA As New Bitmap(My.Resources.logo)

        Dim Ubicacion As String
        Dim Nombre As String

        Nombre = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        Ubicacion = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        GuardarFoto()

        With HojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado
            'logos 
            .Range("A1:A1").Insert()
            .Shapes.AddPicture(Ubicacion & "\Logo 2sys.jpg", MsoTriState.msoFalse, MsoTriState.msoCTrue, 0, 0, My.Resources.logo.Width / 24, My.Resources.logo.Height / 24)
            .Range("I1:I1").Insert()
            .Shapes.AddPicture(Ubicacion & "\Logo Sistema.jpg", MsoTriState.msoFalse, MsoTriState.msoCTrue, 250, 0, My.Resources.Logo_Wallet.Width / 10, My.Resources.Logo_Wallet.Height / 10)

            'Títulos
            .Range("A6:E6").Merge()
            .Range("A6:E6").HorizontalAlignment = XlHAlign.xlHAlignCenter
            .Range("A6:E6").Value = "Perfiles"
            .Range("A6:E6").Font.Bold = True
            .Range("A6:E6").Font.Size = 24

            'ingreso los valores a las filas y columnas
            'creo las variables para moverme en la hoja
            Const PrimeraLetra As Char = "B"
            Const PrimerNumero As Short = 10
            Dim Letra As Char
            Dim UltimaLetra As Char
            Dim Numero As Integer
            Dim UltimoNumero As Integer
            Dim Cod_letra As Byte = Asc(PrimeraLetra) - 1
            Dim SeparadorDecimal As String = ","
            Dim SeparadorMil As String = "."

            'Establezco formatos de las columnas de la hoja de cálculo
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim Cod_LetraIzq As String = Asc(PrimeraLetra) - 1
            Letra = PrimeraLetra
            Numero = PrimerNumero

            Dim ObjCelda As Excel.Range
            Dim DC As DataColumn

            For Each DC In da.Columns
                If Letra = "Z" Then
                    Letra = PrimeraLetra
                    Cod_letra = Asc(PrimeraLetra)
                    Cod_LetraIzq += 1
                    LetraIzq = Chr(Cod_LetraIzq)
                Else
                    Cod_letra += 1
                    Letra = Chr(Cod_letra)
                End If
                'pongo títulos
                strColumna = LetraIzq + Letra + Numero.ToString
                ObjCelda = .Range(strColumna, Type.Missing)
                ObjCelda.Value = DC.ColumnName
                Select Case ObjCelda.Value
                    Case "SEGPER_CODIGO"
                        ObjCelda.Value = "Código Perfil"
                    Case "SEGPER_PERFIL"
                        ObjCelda.Value = "Nombre"
                    Case "SEGPER_DESCRIPCION"
                        ObjCelda.Value = "Descripción"
                End Select
                ObjCelda.EntireColumn.Font.Size = 11
                If DC.DataType Is GetType(Decimal) OrElse DC.DataType Is GetType(Double) Then
                    ObjCelda.EntireColumn.NumberFormat = "#" + SeparadorMil + "0" + SeparadorDecimal + "00"
                End If

            Next
            Dim RangoEncab As Excel.Range = .Range(PrimeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
            RangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = Letra
            Dim UltimaLetraIzquierda As String = LetraIzq

            'Cargo Datos
            Dim i As Integer = Numero + 1

            For Each Reg As DataRow In da.Rows
                LetraIzq = ""
                Cod_LetraIzq = Asc(PrimeraLetra) - 1
                Letra = PrimeraLetra
                Cod_letra = Asc(PrimeraLetra) - 1
                For Each c As DataColumn In da.Columns
                    If Letra = "Z" Then
                        Letra = PrimeraLetra
                        Cod_letra = Asc(PrimeraLetra)
                        Cod_LetraIzq += 1
                        LetraIzq = Chr(Cod_LetraIzq)
                    Else
                        Cod_letra += 1
                        Letra = Chr(Cod_letra)
                    End If
                    strColumna = LetraIzq + Letra
                    'acá se realiza la carga
                    .Cells(i, strColumna) = IIf(IsDBNull(Reg.ToString), "", Reg(c.Ordinal))
                Next
                Dim RangoReg As Excel.Range = .Range(PrimeraLetra + i.ToString, strColumna + i.ToString)
                RangoReg.Rows.BorderAround()
                RangoReg.Select()
                i += 1
            Next
            UltimoNumero = i
            'dibujo las líneas de las columnas
            LetraIzq = ""
            Cod_LetraIzq = Asc("A")
            Cod_letra = Asc(PrimeraLetra)
            Letra = PrimeraLetra
            For Each c As DataColumn In da.Columns
                ObjCelda = .Range(LetraIzq + Letra + PrimerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                ObjCelda.BorderAround()
                If Letra = "Z" Then
                    Letra = PrimeraLetra
                    Cod_letra = Asc(PrimeraLetra)
                    Cod_LetraIzq += 1
                    LetraIzq = Chr(Cod_LetraIzq)
                Else
                    Cod_letra += 1
                    Letra = Chr(Cod_letra)
                End If
            Next
            'dibujo el borde exterior grueso
            Dim objRango As Excel.Range = .Range(PrimeraLetra + PrimerNumero.ToString, UltimaLetraIzquierda + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With

        m_excel.Cursor = Excel.XlMousePointer.xlDefault
        EliminarFoto()

    End Sub

    ''' <summary>
    ''' Crea la foto que se usará para el título del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarFoto()

        Dim aPath As String
        Dim aName As String
        aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        aPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        My.Resources.Logo.Save(aPath & "\logo.jpg")
        My.Resources.Logo_Wallet.Save(aPath & "\Logo Sistema.jpg")

    End Sub


    ''' <summary>
    ''' Borra la foto creada para el título del reporte
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EliminarFoto()

        Dim aPath As String
        Dim aName As String
        Dim bpath As String

        aName = System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        aPath = System.IO.Path.GetDirectoryName(aName)
        aPath = aPath & "\logo.jpg"
        bpath = System.IO.Path.GetDirectoryName(aName)
        bpath = bpath & "\Logo Sistema.jpg"
        Try
            My.Computer.FileSystem.DeleteFile(aPath)
            My.Computer.FileSystem.DeleteFile(bpath)
        Catch ex As System.Exception
        End Try

    End Sub

#End Region

End Class