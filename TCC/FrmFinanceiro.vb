Public Class FrmFinanceiro

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = String.Empty
        ComboBox1.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código da Transação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            pblCnx.Open()

            Dim ssql As String
            ssql = "Delete From Financeiro Where CodTrans = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblComando.ExecuteNonQuery()
            MessageBox.Show("Registro excluido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            ComboBox1.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código da Transação Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo Status Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo Saldo Anterior Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo Valor Crédito Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Campo Data Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


            Dim ssql As String
            ssql = "Insert into Financeiro values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(ComboBox1.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "')"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery() 'Executa a instrução Transact-SQL na conexão estabelecida e devolve o número de linhas afetadas.
            MessageBox.Show("Registro incluído com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            ComboBox1.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim ssql As String

        ssql = "Select * From Financeiro Where CodTrans = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()

            ssql = "Update Financeiro set "
            ssql = ssql & "Status = '" & Trim(ComboBox1.Text) & "',"
            ssql = ssql & "SaldoAnt = '" & Trim(TextBox3.Text) & "', "
            ssql = ssql & "ValorCred =' " & Trim(TextBox4.Text) & "', "
            ssql = ssql & "SaldoFin =' " & Trim(TextBox5.Text) & "' "
            ssql = ssql & "Where CodTrans = '" & Trim(TextBox1.Text) & "'"

            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery()
            MessageBox.Show("Registro alterado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

        End If
        pblDataReader.Close()
        pblCnx.Close()

        TextBox1.Text = String.Empty
        ComboBox1.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        

        Dim ssql As String
        ssql = "Select * From Financeiro Where CodTrans = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodTrans").ToString
            ComboBox1.Text = pblDataReader.Item("Status").ToString
            TextBox3.Text = pblDataReader.Item("SaldoAnt").ToString
            TextBox4.Text = pblDataReader.Item("ValorCred").ToString
            TextBox5.Text = pblDataReader.Item("SaldoFin").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub

    Private Sub FrmFinanceiro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
        Dim DataS As String = DateTime.Now.ToString("dd/MM/yyyy")
        TextBox5.Text = DataS
        TextBox5.Enabled = False
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class