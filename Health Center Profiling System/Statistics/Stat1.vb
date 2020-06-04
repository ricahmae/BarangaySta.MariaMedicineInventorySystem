Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Public Class Stat1
    Private Sub Stat1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewdata()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
    Sub viewdata()

        Chart1.Series.Clear()
        Chart1.Series.Add("MedicineName_VS_Number")

        Chart1.Series("MedicineName_VS_Number").IsValueShownAsLabel = True
        Chart1.Series("MedicineName_VS_Number").YValueType = DataVisualization.Charting.ChartValueType.Int32
        Try
            Dim sql As String

            sql = "Select *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal FROM stockout,profilemedicine WHERE stockout.MedicineID=profilemedicine.MedicineID AND DOS = '" & Format(CDate(DateTimePicker1.Value).Date, "yyyy-M-d") & "' GROUP BY MedicineCode ASC"

            dbConnect()
            ExecuteQuery(sql)
            While reader.Read()
                Chart1.Series("MedicineName_VS_Number").Points.AddXY(reader.GetString("MedicineName"), reader.GetInt32("stockouttotal"))
            End While
            reader.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Chart1.Series.Clear()

        Chart1.Series.Add("MedicineName_VS_Number")

        Chart1.Series("MedicineName_VS_Number").IsValueShownAsLabel = True
        Chart1.Series("MedicineName_VS_Number").YValueType = DataVisualization.Charting.ChartValueType.Int32
        Try
            Dim sql As String

            sql = "Select *,(SELECT COALESCE(SUM(QuantitySO),0)) as stockouttotal FROM stockout,profilemedicine WHERE stockout.MedicineID=profilemedicine.MedicineID AND DOS = '" & Format(CDate(DateTimePicker1.Value).Date, "yyyy-M-d") & "' GROUP BY MedicineCode ASC"

            dbConnect()
            ExecuteQuery(sql)

            While reader.Read()
                Chart1.Series("MedicineName_VS_Number").Points.AddXY(reader.GetString("MedicineName"), reader.GetInt32("stockouttotal"))
            End While
            reader.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click
        Me.Close()
    End Sub
End Class