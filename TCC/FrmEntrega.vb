Public Class FrmEntrega

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        FrmPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub FrmEntrega_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        ComboBox1.Text = String.Empty
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Código da Entrega", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            pblCnx.Open()

            Dim ssql As String
            ssql = "Delete From Entrega Where CodEntrega = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblComando.ExecuteNonQuery()
            MessageBox.Show("Registro excluido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            ComboBox1.Text = String.Empty
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Código da Entrega Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Código do Cliente Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = String.Empty Then
            MessageBox.Show("Campo Código do Produto Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf ComboBox1.Text = String.Empty Then
            MessageBox.Show("Campo Status Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else

            Dim ssql As String
            ssql = "Insert into Entrega values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(ComboBox1.Text) & "')"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblComando.ExecuteNonQuery() 'Executa a instrução Transact-SQL na conexão estabelecida e devolve o número de linhas afetadas.
            MessageBox.Show("Registro incluído com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            pblCnx.Close() 'fecha a conexão do banco de dados

            TextBox1.Text = String.Empty
            TextBox2.Text = String.Empty
            TextBox3.Text = String.Empty
            ComboBox1.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim ssql As String
        ssql = "Select * From Entrega Where CodEntrega = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()

            ssql = "Update Entrega set "
            ssql = ssql & "CodProduto = '" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "CodCliente = '" & Trim(TextBox3.Text) & "', "
            ssql = ssql & "Status =' " & Trim(ComboBox1.Text) & "' "
            ssql = ssql & "Where CodEntrega = '" & Trim(TextBox1.Text) & "'"
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
        ComboBox1.Text = String.Empty
     
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        

        Dim ssql As String
        ssql = "Select * From Entrega Where CodEntrega = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("CodEntrega").ToString
            TextBox2.Text = pblDataReader.Item("CodProduto").ToString
            TextBox3.Text = pblDataReader.Item("CodCliente").ToString
            ComboBox1.Text = pblDataReader.Item("Status").ToString
            
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
    End Sub
End Class