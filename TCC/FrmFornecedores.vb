Public Class FrmFornecedores

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub
    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub FrmFornecedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

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
        ComboBox1.Text = String.Empty
        TextBox8.Text = String.Empty
        TextBox9.Text = String.Empty
        TextBox10.Text = String.Empty
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código do Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            TextBox4.Text = String.Empty
            TextBox5.Text = String.Empty
            TextBox6.Text = String.Empty
            ComboBox1.Text = String.Empty
            TextBox8.Text = String.Empty
            TextBox9.Text = String.Empty
            TextBox10.Text = String.Empty

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código do Fornecedor Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
       
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Nome do Fornecedor Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo CNPJ Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo Inscrição Estadual Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Campo Endereço Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox6.Text = String.Empty Then
            MessageBox.Show("Campo Cidade Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo UF Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox8.Text = String.Empty Then
            MessageBox.Show("Campo CEP Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox9.Text = String.Empty Then
            MessageBox.Show("Campo Gênero Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox10.Text = String.Empty Then
            MessageBox.Show("Campo Telefone Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else

            Dim ssql As String
            ssql = "Insert into Fornecedores values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "','"
            ssql = ssql & Trim(ComboBox1.Text) & "','"
            ssql = ssql & Trim(TextBox8.Text) & "','"
            ssql = ssql & Trim(TextBox9.Text) & "','"
            ssql = ssql & Trim(TextBox10.Text) & "')"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery() 'Executa a instrução Transact-SQL na conexão estabelecida e devolve o número de linhas afetadas.
            MessageBox.Show("Registro incluído com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        
        Dim ssql As String

        ssql = "Select * From Fornecedores Where CodForn = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()

            ssql = "Update Fornecedores set "
            ssql = ssql & "RazaoSocial = '" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "CNPJ = '" & Trim(TextBox3.Text) & "', "
            ssql = ssql & "IE =' " & Trim(TextBox4.Text) & "', "
            ssql = ssql & "Endereco =' " & Trim(TextBox5.Text) & "', "
            ssql = ssql & "Cidade=' " & Trim(TextBox6.Text) & "', "
            ssql = ssql & "Estado =' " & Trim(ComboBox1.Text) & "', "
            ssql = ssql & "CEP=' " & Trim(TextBox8.Text) & "', "
            ssql = ssql & "Genero =' " & Trim(TextBox9.Text) & "', "
            ssql = ssql & "Telefone =' " & Trim(TextBox10.Text) & "' "
            ssql = ssql & "Where CodForn = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery()
            MessageBox.Show("Registro alterado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

        End If
        pblDataReader.Close()
        pblCnx.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim ssql As String
        ssql = "Select * From Fornecedores Where CodForn = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodForn").ToString
            TextBox2.Text = pblDataReader.Item("RazaoSocial").ToString
            TextBox3.Text = pblDataReader.Item("CNPJ").ToString
            TextBox4.Text = pblDataReader.Item("IE").ToString
            TextBox5.Text = pblDataReader.Item("Endereco").ToString
            TextBox6.Text = pblDataReader.Item("Cidade").ToString
            ComboBox1.Text = pblDataReader.Item("Estado").ToString
            TextBox8.Text = pblDataReader.Item("CEP").ToString
            TextBox9.Text = pblDataReader.Item("Genero").ToString
            TextBox10.Text = pblDataReader.Item("Telefone").ToString
          End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub
End Class