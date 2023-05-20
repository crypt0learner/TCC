Public Class FrmProdutos

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox8.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
       
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Nome Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo CodFornecedor Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo Valor/Custo Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Campo Valor/Venda Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox6.Text = String.Empty Then
            MessageBox.Show("Campo Garantia Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox7.Text = String.Empty Then
            MessageBox.Show("Campo Data de Fabricação Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else

            Dim ssql As String
            ssql = "Insert into Produtos values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox8.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "','"
            ssql = ssql & Trim(TextBox7.Text) & "')"


            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery() 'Executa a instrução Transact-SQL na conexão estabelecida e devolve o número de linhas afetadas.
            MessageBox.Show("Registro incluído com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados
            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox8.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            TextBox7.Text = String.Empty

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ssql As String

        ssql = "Select * From Produtos Where CodProd = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()

            ssql = "Update Produtos set "
            ssql = ssql & "Nome = '" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "Descricao = '" & Trim(TextBox8.Text) & "', "
            ssql = ssql & "CodForn =' " & Trim(TextBox3.Text) & "', "
            ssql = ssql & "ValCusto =' " & Trim(TextBox4.Text) & "', "
            ssql = ssql & "ValVenda =' " & Trim(TextBox5.Text) & "', "
            ssql = ssql & "Garantia =' " & Trim(TextBox6.Text) & "', "
            ssql = ssql & "DataFab =' " & Trim(TextBox7.Text) & "' "
            ssql = ssql & "Where CodProd = '" & Trim(TextBox1.Text) & "'"
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
        TextBox8.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim ssql As String
        ssql = "Select * From Produtos Where CodProd = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodProd").ToString
            TextBox2.Text = pblDataReader.Item("Nome").ToString
            TextBox8.Text = pblDataReader.Item("Descricao").ToString
            TextBox3.Text = pblDataReader.Item("CodForn").ToString
            TextBox4.Text = pblDataReader.Item("ValCusto").ToString
            TextBox5.Text = pblDataReader.Item("ValVenda").ToString
            TextBox6.Text = pblDataReader.Item("Garantia").ToString
            TextBox7.Text = pblDataReader.Item("DataFab").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código do Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblCnx.Open()
            Dim ssql As String

            ssql = "Delete From Produtos Where CodProd = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblComando.ExecuteNonQuery()
            MessageBox.Show("Registro excluido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox8.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            TextBox7.Text = String.Empty
        End If


    End Sub

    Private Sub FrmProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
    End Sub
End Class
