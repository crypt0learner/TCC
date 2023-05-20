Public Class FrmFuncionarios

    Private Sub FrmFuncionarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
    End Sub

    Private Sub TextBox18_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TextBox19_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label25_Click(sender As System.Object, e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

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
        ComboBox1.Text = String.Empty
        TextBox9.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox12.Text = String.Empty
        TextBox13.Text = String.Empty
        TextBox14.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
        TextBox15.Text = String.Empty
        ComboBox4.Text = String.Empty
        TextBox16.Text = String.Empty
        TextBox17.Text = String.Empty
        TextBox18.Text = String.Empty
        TextBox19.Text = String.Empty
        ComboBox5.Text = String.Empty



    End Sub

    Private Sub TextBox10_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código do Funcionário Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
        ElseIf TextBox7.Text = String.Empty Then
            MessageBox.Show("Campo Data de Nascimento Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox8.Text = String.Empty Then
            MessageBox.Show("Campo CEP Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo UF Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox9.Text = String.Empty Then
            MessageBox.Show("Campo Cidade Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox10.Text = String.Empty Then
            MessageBox.Show("Campo Endereço Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox11.Text = String.Empty Then
            MessageBox.Show("Campo Nº Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox12.Text = String.Empty Then
            MessageBox.Show("Campo Telefone Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox13.Text = String.Empty Then
            MessageBox.Show("Campo Celular Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox14.Text = String.Empty Then
            MessageBox.Show("Campo CTPS Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox2.Text = String.Empty Then
            MessageBox.Show("Campo Sexo Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox3.Text = String.Empty Then
            MessageBox.Show("Campo Estado Civil Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox15.Text = String.Empty Then
            MessageBox.Show("Campo Data Adimissão Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox4.Text = String.Empty Then
            MessageBox.Show("Campo Turno Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox16.Text = String.Empty Then
            MessageBox.Show("Campo Cargo Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox17.Text = String.Empty Then
            MessageBox.Show("Campo Salário Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox18.Text = String.Empty Then
            MessageBox.Show("Campo Demissão Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox19.Text = String.Empty Then
            MessageBox.Show("Campo Data Demissão Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox5.Text = String.Empty Then
            MessageBox.Show("Campo Status Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            Dim ssql As String
            ssql = "Insert into Funcionarios values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "','"
            ssql = ssql & Trim(TextBox7.Text) & "','"
            ssql = ssql & Trim(TextBox8.Text) & "','"
            ssql = ssql & Trim(ComboBox1.Text) & "','"
            ssql = ssql & Trim(TextBox9.Text) & "','"
            ssql = ssql & Trim(TextBox10.Text) & "','"
            ssql = ssql & Trim(TextBox11.Text) & "','"
            ssql = ssql & Trim(TextBox12.Text) & "','"
            ssql = ssql & Trim(TextBox13.Text) & "','"
            ssql = ssql & Trim(TextBox14.Text) & "','"
            ssql = ssql & Trim(ComboBox2.Text) & "','"
            ssql = ssql & Trim(ComboBox3.Text) & "','"
            ssql = ssql & Trim(TextBox15.Text) & "','"
            ssql = ssql & Trim(ComboBox4.Text) & "','"
            ssql = ssql & Trim(TextBox16.Text) & "','"
            ssql = ssql & Trim(TextBox17.Text) & "','"
            ssql = ssql & Trim(TextBox18.Text) & "','"
            ssql = ssql & Trim(TextBox19.Text) & "','"
            ssql = ssql & Trim(ComboBox5.Text) & "')"
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
            ComboBox1.Text = String.Empty
            TextBox9.Text = String.Empty
            TextBox10.Text = String.Empty
            TextBox11.Text = String.Empty
            TextBox12.Text = String.Empty
            TextBox13.Text = String.Empty
            TextBox14.Text = String.Empty
            ComboBox2.Text = String.Empty
            ComboBox3.Text = String.Empty
            TextBox15.Text = String.Empty
            ComboBox4.Text = String.Empty
            TextBox16.Text = String.Empty
            TextBox17.Text = String.Empty
            TextBox18.Text = String.Empty
            TextBox19.Text = String.Empty
            ComboBox5.Text = String.Empty
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código do Funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblCnx.Open()

            Dim ssql As String
            ssql = "Delete From Funcionarios Where CodFunc = '" & Trim(TextBox1.Text) & "'"
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
            TextBox8.Text = String.Empty
            ComboBox1.Text = String.Empty
            TextBox9.Text = String.Empty
            TextBox10.Text = String.Empty
            TextBox11.Text = String.Empty
            TextBox12.Text = String.Empty
            TextBox13.Text = String.Empty
            TextBox14.Text = String.Empty
            ComboBox2.Text = String.Empty
            ComboBox3.Text = String.Empty
            TextBox15.Text = String.Empty
            ComboBox4.Text = String.Empty
            TextBox16.Text = String.Empty
            TextBox17.Text = String.Empty
            TextBox18.Text = String.Empty
            TextBox19.Text = String.Empty
            ComboBox5.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim ssql As String

        ssql = "Select * From Funcionarios Where CodFunc = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()
            ssql = "Update Funcionarios set "
        ssql = ssql & "Nome = '" & Trim(TextBox2.Text) & "',"
        ssql = ssql & "SobreNome = '" & Trim(TextBox3.Text) & "', "
        ssql = ssql & "Email =' " & Trim(TextBox4.Text) & "', "
        ssql = ssql & "CPF =' " & Trim(TextBox5.Text) & "', "
        ssql = ssql & "RG =' " & Trim(TextBox6.Text) & "', "
        ssql = ssql & "DataNasc =' " & Trim(TextBox7.Text) & "', "
        ssql = ssql & "CEP =' " & Trim(TextBox8.Text) & "', "
        ssql = ssql & "UF =' " & Trim(ComboBox1.Text) & "', "
        ssql = ssql & "Cidade =' " & Trim(TextBox9.Text) & "', "
        ssql = ssql & "Endereco =' " & Trim(TextBox10.Text) & "', "
        ssql = ssql & "Numero =' " & Trim(TextBox11.Text) & "', "
        ssql = ssql & "Telefone =' " & Trim(TextBox12.Text) & "', "
        ssql = ssql & "Celular =' " & Trim(TextBox13.Text) & "', "
        ssql = ssql & "CTPS =' " & Trim(TextBox14.Text) & "', "
        ssql = ssql & "Sexo =' " & Trim(ComboBox2.Text) & "', "
        ssql = ssql & "EstadoCivil =' " & Trim(ComboBox3.Text) & "', "
        ssql = ssql & "DataAdm =' " & Trim(TextBox15.Text) & "', "
        ssql = ssql & "Turno =' " & Trim(ComboBox4.Text) & "', "
        ssql = ssql & "Cargo =' " & Trim(TextBox16.Text) & "', "
        ssql = ssql & "Salario =' " & Trim(TextBox17.Text) & "', "
        ssql = ssql & "Demissao =' " & Trim(TextBox18.Text) & "', "
        ssql = ssql & "DataDem =' " & Trim(TextBox19.Text) & "', "
            ssql = ssql & "Status =' " & Trim(ComboBox5.Text) & "' "
        ssql = ssql & "Where CodFunc = '" & Trim(TextBox18.Text) & "'"
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
        ComboBox1.Text = String.Empty
        TextBox9.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox12.Text = String.Empty
        TextBox13.Text = String.Empty
        TextBox14.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
        TextBox15.Text = String.Empty
        ComboBox4.Text = String.Empty
        TextBox16.Text = String.Empty
        TextBox17.Text = String.Empty
        TextBox18.Text = String.Empty
        TextBox19.Text = String.Empty
        ComboBox5.Text = String.Empty
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim ssql As String
        ssql = "Select * From Funcionarios Where CodFunc = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            TextBox1.Text = pblDataReader.Item("CodFunc").ToString
            TextBox2.Text = pblDataReader.Item("Nome").ToString
            TextBox3.Text = pblDataReader.Item("Sobrenome").ToString
            TextBox4.Text = pblDataReader.Item("Email").ToString
            TextBox5.Text = pblDataReader.Item("CPF").ToString
            TextBox6.Text = pblDataReader.Item("RG").ToString
            TextBox7.Text = pblDataReader.Item("DataNasc").ToString
            TextBox8.Text = pblDataReader.Item("CEP").ToString
            ComboBox1.Text = pblDataReader.Item("UF").ToString
            TextBox9.Text = pblDataReader.Item("Cidade").ToString
            TextBox10.Text = pblDataReader.Item("Endereco").ToString
            TextBox11.Text = pblDataReader.Item("Numero").ToString
            TextBox12.Text = pblDataReader.Item("Telefone").ToString
            TextBox13.Text = pblDataReader.Item("Celular").ToString
            TextBox14.Text = pblDataReader.Item("CTPS").ToString
            ComboBox2.Text = pblDataReader.Item("Sexo").ToString
            ComboBox3.Text = pblDataReader.Item("EstadoCivil").ToString
            TextBox15.Text = pblDataReader.Item("DataAdm").ToString
            ComboBox4.Text = pblDataReader.Item("Turno").ToString
            TextBox16.Text = pblDataReader.Item("Cargo").ToString
            TextBox17.Text = pblDataReader.Item("Salario").ToString
            TextBox18.Text = pblDataReader.Item("Demissao").ToString
            TextBox19.Text = pblDataReader.Item("DataDem").ToString
            ComboBox5.Text = pblDataReader.Item("Status").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class