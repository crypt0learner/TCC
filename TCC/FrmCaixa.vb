Public Class FrmCaixa

    Private Sub FrmCaixa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pblCnx.ConnectionString = "Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" & Application.StartupPath & "\banco\BlackhawkBases.accdb; Uid=Admin;Pwd=  "

        TextBox6.Enabled = False

        Dim DataS As String = DateTime.Now.ToString("dd/MM/yyyy")
        TextBox3.Text = DataS
        TextBox3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        FrmPrincipal.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        FrmPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim texto As String
        texto = "Campo Entrda de Caixa Obrigatório!" & vbCrLf & "Favor Clicar No Botão Calcular Entrada de Caixa!"


        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Campo Número do Caixa Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = String.Empty Then
            MessageBox.Show("Campo Código do Funcionário Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = String.Empty Then
            MessageBox.Show("Campo Valor Inicial Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Campo Valor Final Obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox6.Text = String.Empty Then
            MessageBox.Show(texto, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Dim ssql As String
            ssql = "Insert into Caixa values ('"
            ssql = ssql & Trim(TextBox1.Text) & "','"
            ssql = ssql & Trim(TextBox2.Text) & "','"
            ssql = ssql & Trim(TextBox3.Text) & "','"
            ssql = ssql & Trim(TextBox4.Text) & "','"
            ssql = ssql & Trim(TextBox5.Text) & "','"
            ssql = ssql & Trim(TextBox6.Text) & "')"
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
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click


        Dim ssql As String
        ssql = "Select * From Caixa Where NumCaixa = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader

        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            pblDataReader.Close()
            pblCnx.Close()
            ssql = "Update Caixa set "
            ssql = ssql & "CodFunc ='" & Trim(TextBox2.Text) & "',"
            ssql = ssql & "Data ='" & Trim(TextBox3.Text) & "', "
            ssql = ssql & "ValorIni ='" & Trim(TextBox4.Text) & "', "
            ssql = ssql & "ValorFin ='" & Trim(TextBox5.Text) & "', "
            ssql = ssql & "EntradaCaixa ='" & Trim(TextBox6.Text) & "' "
            ssql = ssql & "Where NumCaixa = '" & Trim(TextBox1.Text) & "'"
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

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click


        Dim ssql As String
        ssql = "Select * From Caixa Where NumCaixa = '" & Trim(TextBox1.Text) & "'"
        pblComando.CommandText = ssql
        pblComando.Connection = pblCnx
        pblCnx.Open()
        pblDataReader = pblComando.ExecuteReader
        If Not pblDataReader.HasRows Then
            MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            TextBox1.Text = String.Empty
        Else
            TextBox1.Text = pblDataReader.Item("NumCaixa").ToString
            TextBox2.Text = pblDataReader.Item("CodFunc").ToString
            TextBox3.Text = pblDataReader.Item("Data").ToString
            TextBox4.Text = pblDataReader.Item("ValorIni").ToString
            TextBox5.Text = pblDataReader.Item("ValorFin").ToString
            TextBox6.Text = pblDataReader.Item("EntradaCaixa").ToString
        End If
        pblDataReader.Close()
        pblCnx.Close() 'fecha a conexão do banco de dados
       
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Por Favor, Insira o Número do Caixa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Dim ssql As String
            ssql = "Select * From Caixa Where NumCaixa = '" & Trim(TextBox1.Text) & "'"
            pblComando.CommandText = ssql
            pblComando.Connection = pblCnx
            pblCnx.Open()
            pblDataReader = pblComando.ExecuteReader
            If Not pblDataReader.HasRows Then
                MessageBox.Show("Código Inexistente!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Else
                pblDataReader.Close()
                pblCnx.Close()
                ssql = "Delete From Caixa Where NumCaixa = '" & Trim(TextBox1.Text) & "'"
                pblComando.CommandText = ssql
                pblComando.Connection = pblCnx
                pblCnx.Open()
                pblComando.ExecuteNonQuery()
                MessageBox.Show("Registro excluido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If TextBox4.Text = String.Empty Then
            MessageBox.Show("Por Favor Preencha o Campo Valor Inicial", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox5.Text = String.Empty Then
            MessageBox.Show("Por Favor Preencha o Campo Valor Final", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            Dim v1, v2, vtotal As Double
            v1 = TextBox4.Text
            v2 = TextBox5.Text

            vtotal = v2 - v1
            TextBox6.Text = vtotal

        End If

    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        
    End Sub
End Class