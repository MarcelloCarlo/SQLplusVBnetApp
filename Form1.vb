Imports System.Configuration
Imports System.Data.SqlClient
Imports MetroFramework

Public Class productsForm
    'Setup database connection. See: App.Config
    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("VBnetApp.My.MySettings.dbConnectionString").ConnectionString)
    Private Sub productsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        __bindGrid()
    End Sub

    'Load all products from database
    Private Function __bindGrid()

        'Sample statement to get the list
        Dim sqlview As String = "SELECT Product_ID AS ID,Product_Name AS Name,Product_Price AS Price ,Product_Type AS Type FROM PRODUCTS"
        Dim cmd As New SqlCommand(sqlview, conn)

        Try
            'Open the connection
            conn.Open()

            'Setup the data table and fetch the data from the query
            Dim dataTable As New DataTable
            dataTable.Load(cmd.ExecuteReader)

            'Fill the product grid view from data table
            With productGridView
                .AutoGenerateColumns = True
                .DataSource = dataTable
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        'Close the connection
        conn.Close()

    End Function

    'The function when the add button is clicked
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Check if the texboxes are empty
        Dim emptyTextBoxes = From txt In Me.Controls.OfType(Of MetroFramework.Controls.MetroTextBox)()
                             Where txt.Text.Length = 0
                             Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(",", emptyTextBoxes)))
        Else

            Try
                'Insert values from the textboxes
                Dim sqlview As String = "INSERT INTO PRODUCTS (Product_Name,Product_Price,Product_Type) VALUES (@Product_Name,@Product_Price,@Product_Type)"
                Dim cmd As New SqlCommand(sqlview, conn)

                cmd.Parameters.AddWithValue("@Product_Name", sNameTxtbx.Text.ToString().Trim())
                cmd.Parameters.AddWithValue("@Product_Price", iPriceTxtbx.Text.ToString().Trim())
                cmd.Parameters.AddWithValue("@Product_Type", sTypeTxtbx.Text.ToString().Trim())

                conn.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
                Console.WriteLine(ex.ToString)
            End Try
            conn.Close()
        End If

        __bindGrid()

    End Sub
End Class
