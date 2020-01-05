Imports System.Configuration
Imports System.Data.SqlClient
Imports MetroFramework

Public Class productsForm

    Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings("VBnetApp.My.MySettings.dbConnectionString").ConnectionString)
    Private Sub productsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        __bindGrid()
    End Sub

    Private Function __bindGrid()

        Dim sqlview As String = "SELECT Product_ID AS ID,Product_Name AS Name,Product_Price AS Price ,Product_Type AS Type FROM PRODUCTS"
        Dim cmd As New SqlCommand(sqlview, conn)

        Try
            conn.Open()

            Dim dataTable As New DataTable
            dataTable.Load(cmd.ExecuteReader)
            'Dim datAdapter As New SqlDataAdapter
            'datAdapter.SelectCommand = cmd
            'Dim dataSet As New DataSet
            'datAdapter.Fill(dataSet)
            'Dim dataTable As New DataTable

            With productGridView
                .AutoGenerateColumns = True
                .DataSource = dataTable
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        conn.Close()

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim emptyTextBoxes = From txt In Me.Controls.OfType(Of MetroFramework.Controls.MetroTextBox)()
                             Where txt.Text.Length = 0
                             Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(",", emptyTextBoxes)))
        Else

            Try

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

        'Dim decprice As Decimal = CDec(iPriceTxtbx.Text)
        __bindGrid()

    End Sub
End Class
