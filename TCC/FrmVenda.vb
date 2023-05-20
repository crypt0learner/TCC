Public Class FrmVenda

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        ComboBox1.Text = String.Empty
        TextBox8.Text = String.Empty
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código da Venda Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Código do Cliente Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo Código do Funcionário Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo Código do Produto Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox7.Text = String.Empty Then
            MessageBox.Show("Campo Valor Total Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo Forma de Pagamento Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox8.Text = String.Empty Then
            MessageBox.Show("Favor Escolher Classificação de Fidelidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Dim ssql As String
            ssql = "Insert into Vendas values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "','"
            ssql = ssql & Trim(TextBox7.Text) & "','"
            ssql = ssql & Trim(ComboBox1.Text) & "','"
            ssql = ssql & Trim(TextBox8.Text) & "')"


            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery() 'Executa a instrução Transact-SQL na conexão estabelecida e devolve o número de linhas afetadas.
            MessageBox.Show("Registro incluído com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            TextBox7.Text = String.Empty
            ComboBox1.Text = String.Empty
            TextBox8.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ssql As String

        ssql = "Select * From Vendas Where CodVenda = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()

            ssql = "Update Vendas set "
            ssql = ssql & "CodCli = '" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "CodFunc =' " & Trim(TextBox3.Text) & "', "
            ssql = ssql & "CodProd =' " & Trim(TextBox4.Text) & "', "
            ssql = ssql & "Data =' " & Trim(TextBox5.Text) & "', "
            ssql = ssql & "Desconto =' " & Trim(TextBox6.Text) & "', "
            ssql = ssql & "Valor =' " & Trim(TextBox7.Text) & "', "
            ssql = ssql & "FormaPagamento =' " & Trim(ComboBox1.Text) & "', "
            ssql = ssql & "Pagar =' " & Trim(TextBox8.Text) & "' "
            ssql = ssql & "Where CodVenda = '" & Trim(TextBox1.Text) & "'"
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
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        ComboBox1.Text = String.Empty
        TextBox8.Text = String.Empty
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim ssql As String
        ssql = "Select * From Vendas Where CodVenda = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodVenda").ToString
            TextBox2.Text = pblDataReader.Item("CodCli").ToString
            TextBox3.Text = pblDataReader.Item("CodFunc").ToString
            TextBox4.Text = pblDataReader.Item("CodProd").ToString
            TextBox5.Text = pblDataReader.Item("Data").ToString
            TextBox6.Text = pblDataReader.Item("Desconto").ToString
            TextBox7.Text = pblDataReader.Item("Valor").ToString
            ComboBox1.Text = pblDataReader.Item("FormaPagamento").ToString
            TextBox8.Text = pblDataReader.Item("Pagar").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        pblCnx.Open()
        Dim ssql As String
        ssql = "Delete From Vendas Where CodVenda = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblComando.ExecuteNonQuery()
        MessageBox.Show("Registro excluido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        pblCnx.Close() 'fecha a conexão do banco de dados
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        ComboBox1.Text = String.Empty
        TextBox8.Text = String.Empty
    End Sub

    Private Sub FrmVenda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
        TextBox6.Enabled = False
        TextBox8.Enabled = False
        Dim DataS As String = DateTime.Now.ToString("dd/MM/yyyy")
        TextBox5.Text = DataS
        TextBox5.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

        Dim preco, desconto, total As Double

        preco = TextBox7.Text
        TextBox8.Text = String.Empty
        If RadioButton1.Enabled = True Then
            TextBox6.Text = String.Empty
            desconto = 0.05
            total = preco - (preco * desconto)
            TextBox8.Text = total
            TextBox6.Text = "5%"
        End If

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

        Dim preco, desconto, total As Double

        preco = TextBox7.Text
        TextBox8.Text = String.Empty
        If RadioButton2.Enabled = True Then
            TextBox6.Text = String.Empty
            desconto = 0.1
            total = preco - (preco * desconto)
            TextBox8.Text = total
            TextBox6.Text = "10%"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Dim preco, desconto, total As Double

        preco = TextBox7.Text
        TextBox8.Text = String.Empty
        If RadioButton3.Enabled = True Then
            TextBox6.Text = String.Empty
            desconto = 0.2
            total = preco - (preco * desconto)
            TextBox8.Text = total
            TextBox6.Text = "20%"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Dim preco, desconto, total As Double

        preco = TextBox7.Text
        TextBox8.Text = String.Empty
        If RadioButton3.Enabled = True Then
            TextBox6.Text = String.Empty
            desconto = 1
            total = preco * desconto
            TextBox6.Text = "0%"
            TextBox8.Text = total
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
