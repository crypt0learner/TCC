Public Class FrmClientes

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub FrmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
        TextBox7.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else

            Dim ssql As String
            ssql = "Delete From Clientes Where CodCli = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
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
            TextBox8.Text = String.Empty
            ComboBox4.Text = String.Empty
            TextBox10.Text = String.Empty
            TextBox11.Text = String.Empty
            TextBox12.Text = String.Empty
            TextBox13.Text = String.Empty
            TextBox14.Text = String.Empty
            ComboBox1.Text = String.Empty
            ComboBox2.Text = String.Empty
            ComboBox3.Text = String.Empty
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        TextBox8.Text = String.Empty
        ComboBox4.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox12.Text = String.Empty
        TextBox13.Text = String.Empty
        TextBox14.Text = String.Empty
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Nome Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo Sobrenome Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo E-mail Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Campo CPF Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox6.Text = String.Empty Then
            MessageBox.Show("Campo RG Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox8.Text = String.Empty Then
            MessageBox.Show("Campo CEP Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox10.Text = String.Empty Then
            MessageBox.Show("Campo Cidade Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox11.Text = String.Empty Then
            MessageBox.Show("Campo Endereço Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox12.Text = String.Empty Then
            MessageBox.Show("Campo Nº Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox13.Text = String.Empty Then
            MessageBox.Show("Campo Telefone Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo Dia Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox2.Text = String.Empty Then
            MessageBox.Show("Campo Mês Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox3.Text = String.Empty Then
            MessageBox.Show("Campo Ano Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox4.Text = String.Empty Then
            MessageBox.Show("Campo UF Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        Else
            Dim DataNasc As String
            DataNasc = ComboBox1.Text & "/" & ComboBox2.Text & "/" & ComboBox3.Text

            Dim ssql As String
            ssql = "Insert into Clientes values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "','"
            ssql = ssql & Trim(DataNasc) & "','"
            ssql = ssql & Trim(TextBox8.Text) & "','"
            ssql = ssql & Trim(ComboBox4.Text) & "','"
            ssql = ssql & Trim(TextBox10.Text) & "','"
            ssql = ssql & Trim(TextBox11.Text) & "','"
            ssql = ssql & Trim(TextBox12.Text) & "','"
            ssql = ssql & Trim(TextBox13.Text) & "','"
            ssql = ssql & Trim(TextBox14.Text) & "')"

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
            TextBox8.Text = String.Empty
            ComboBox4.Text = String.Empty
            TextBox10.Text = String.Empty
            TextBox11.Text = String.Empty
            TextBox12.Text = String.Empty
            TextBox13.Text = String.Empty
            TextBox14.Text = String.Empty
            ComboBox1.Text = String.Empty
            ComboBox2.Text = String.Empty
            ComboBox3.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim DataNasc As String
        DataNasc = ComboBox1.Text & "/" & ComboBox2.Text & "/" & ComboBox3.Text

        Dim ssql As String
        ssql = "Select * From Clientes Where CodCli = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()
            ssql = "Update Clientes set "
            ssql = ssql & "Nome = '" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "SobreNome = '" & Trim(TextBox3.Text) & "', "
            ssql = ssql & "Email =' " & Trim(TextBox4.Text) & "', "
            ssql = ssql & "CPF =' " & Trim(TextBox5.Text) & "', "
            ssql = ssql & "RG =' " & Trim(TextBox6.Text) & "', "
            ssql = ssql & "DataNasc =' " & Trim(DataNasc) & "', "
            ssql = ssql & "CEP =' " & Trim(TextBox8.Text) & "', "
            ssql = ssql & "UF =' " & Trim(ComboBox4.Text) & "', "
            ssql = ssql & "Cidade =' " & Trim(TextBox10.Text) & "', "
            ssql = ssql & "Endereco =' " & Trim(TextBox11.Text) & "', "
            ssql = ssql & "Numero =' " & Trim(TextBox12.Text) & "', "
            ssql = ssql & "Telefone =' " & Trim(TextBox13.Text) & "', "
            ssql = ssql & "Celular =' " & Trim(TextBox14.Text) & "' "
            ssql = ssql & "Where CodCli = '" & Trim(TextBox1.Text) & "'"
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
        TextBox8.Text = String.Empty
        ComboBox4.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox12.Text = String.Empty
        TextBox13.Text = String.Empty
        TextBox14.Text = String.Empty
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        Dim ssql As String
        ssql = "Select * From Clientes Where CodCli = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodCli").ToString
            TextBox2.Text = pblDataReader.Item("Nome").ToString
            TextBox3.Text = pblDataReader.Item("Sobrenome").ToString
            TextBox4.Text = pblDataReader.Item("Email").ToString
            TextBox5.Text = pblDataReader.Item("CPF").ToString
            TextBox6.Text = pblDataReader.Item("RG").ToString
            TextBox7.Text = pblDataReader.Item("DataNasc").ToString
            TextBox8.Text = pblDataReader.Item("CEP").ToString
            ComboBox4.Text = pblDataReader.Item("UF").ToString
            TextBox10.Text = pblDataReader.Item("Cidade").ToString
            TextBox11.Text = pblDataReader.Item("Endereco").ToString
            TextBox12.Text = pblDataReader.Item("Numero").ToString
            TextBox13.Text = pblDataReader.Item("Telefone").ToString
            TextBox14.Text = pblDataReader.Item("Celular").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
      
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox7_Click(sender As Object, e As System.EventArgs) Handles TextBox7.Click
        Dim DataNasc As String
        DataNasc = ComboBox1.Text & "/" & ComboBox2.Text & "/" & ComboBox3.Text
        TextBox7.Text = DataNasc
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class