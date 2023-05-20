Public Class FrmPrincipal

    Private Sub CadastrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CadastrarToolStripMenuItem.Click
        FrmProdutos.Show()
        Me.Hide()


      
    End Sub

    Private Sub PrToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FrmProdutos.Show()
        Me.Hide()

    End Sub

    Private Sub CadastrarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        FrmClientes.Show()
        Me.Hide()


    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmClientes.Show()
        Me.Hide()
    End Sub

    Private Sub EntregasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EntregasToolStripMenuItem.Click
        FrmEntrega.Show()
        Me.Hide()



    End Sub

    Private Sub CadastrarToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        FrmFuncionarios.Show()
        Me.Hide()


    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NovaVendaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FrmVenda.Show()
        Me.Hide()

    End Sub

    Private Sub ConsultarToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        FrmCaixa.Show()
        Me.Hide()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub FinanceiroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FinanceiroToolStripMenuItem.Click
        FrmFinanceiro.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CaixaToolStripMenuItem.Click
        FrmCaixa.Show()
        Me.Hide()

    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VendasToolStripMenuItem.Click
        FrmVenda.Show()
        Me.Hide()


    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        FrmFuncionarios.Show()
        Me.Hide()

    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RelatóriosToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        FrmFornecedores.Show()
        Me.Hide()
    End Sub
End Class