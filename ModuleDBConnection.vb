Imports System.Data.SqlClient

Module ModuleDBConnection
    ' Define the connection string once, making it reusable '
    Public ReadOnly connectionString As String = "Data Source=DESKTOP-PD9I1RP\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"

    ' Function to create and return an open SqlConnection '
    Public Function GetConnection() As SqlConnection
        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Function to execute a scalar query (returns a single value) '
    Public Function ExecuteScalarQuery(query As String, parameters As Dictionary(Of String, Object)) As Object
        Using conn As SqlConnection = GetConnection()
            If conn IsNot Nothing Then
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters dynamically '
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Return cmd.ExecuteScalar()
                End Using
            End If
        End Using
        Return Nothing
    End Function
End Module
