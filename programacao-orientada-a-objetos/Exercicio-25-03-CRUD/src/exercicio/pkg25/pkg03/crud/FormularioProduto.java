package exercicio.pkg25.pkg03.crud;

/**
 * @author hiq
 */
import javax.swing.*;
import java.awt.*;

public class FormularioProduto extends JFrame {
    private DefaultListModel<Produto> modelo = new DefaultListModel<>();
    private JTextField txtCod, txtDesc, txtGrp, txtPCompra, txtEstoque, txtPVenda;
    private JList<Produto> listaProdutos;

    public FormularioProduto() {
        setTitle("PROJETO");
        setSize(700, 500);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null); // pra centralizar a janela
        setLayout(new BorderLayout(10, 10));

        // painel do frame na esquerda
        JPanel pnlCampos = new JPanel(new GridLayout(8, 2, 5, 5));
        pnlCampos.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        
        pnlCampos.add(new JLabel("Código:")); txtCod = new JTextField(); pnlCampos.add(txtCod);
        pnlCampos.add(new JLabel("Descrição:")); txtDesc = new JTextField(); pnlCampos.add(txtDesc);
        pnlCampos.add(new JLabel("Grupo:")); txtGrp = new JTextField(); pnlCampos.add(txtGrp);
        pnlCampos.add(new JLabel("Preço Compra:")); txtPCompra = new JTextField(); pnlCampos.add(txtPCompra);
        pnlCampos.add(new JLabel("Estoque:")); txtEstoque = new JTextField(); pnlCampos.add(txtEstoque);
        pnlCampos.add(new JLabel("Preço Venda:")); txtPVenda = new JTextField(); pnlCampos.add(txtPVenda);

        JButton btnAdd = new JButton("Adicionar");
        JButton btnEdit = new JButton("Salvar Edição");
        JButton btnDel = new JButton("Remover");

        pnlCampos.add(btnAdd);
        pnlCampos.add(btnEdit);
        pnlCampos.add(btnDel);

        // config lista
        listaProdutos = new JList<>(modelo);
        JScrollPane scroll = new JScrollPane(listaProdutos);
        scroll.setBorder(BorderFactory.createTitledBorder("Lista de Produtos"));

        // funcoes / eventos
        btnAdd.addActionListener(e -> adicionar());
        btnDel.addActionListener(e -> remover());
        btnEdit.addActionListener(e -> editar());

        // preenchimento de campos
        listaProdutos.addListSelectionListener(e -> {
            if (!e.getValueIsAdjusting()) {
                Produto p = listaProdutos.getSelectedValue();
                if (p != null) {
                    txtCod.setText(String.valueOf(p.getCodigo()));
                    txtDesc.setText(p.getDescricao());
                    txtGrp.setText(p.getGrupo());
                    txtPCompra.setText(String.valueOf(p.getPrecoDeCompra()));
                    txtEstoque.setText(String.valueOf(p.getEstoque()));
                    txtPVenda.setText(String.valueOf(p.getPrecoDeVenda()));
                }
            }
        });

        add(pnlCampos, BorderLayout.WEST);
        add(scroll, BorderLayout.CENTER);
    }

    //funcoes   
    private void adicionar() {
        try {
            Produto p = new Produto(
                Integer.parseInt(txtCod.getText()),
                txtDesc.getText(),
                txtGrp.getText(),
                Double.parseDouble(txtPCompra.getText().replace(",", ".")),
                Integer.parseInt(txtEstoque.getText()), (int) Double.parseDouble(txtPVenda.getText().replace(",", ".")));
            modelo.addElement(p);
            limpar();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Erro: Preencha os campos corretamente!");
        }
    }

    
    private void editar() {
        int index = listaProdutos.getSelectedIndex();
        if (index != -1) {
            try {
                Produto p = modelo.getElementAt(index);
                p.setCodigo(Integer.parseInt(txtCod.getText()));
                p.setDescricao(txtDesc.getText());
                p.setGrupo(txtGrp.getText());
                p.setPrecoDeCompra(Double.parseDouble(txtPCompra.getText().replace(",", ".")));
                p.setEstoque(Integer.parseInt(txtEstoque.getText()));
                p.setPrecoDeVenda(Double.parseDouble(txtPVenda.getText().replace(",", ".")));
                
                listaProdutos.repaint();
                JOptionPane.showMessageDialog(this, "Produto atualizado!");
            } catch (Exception ex) {
                JOptionPane.showMessageDialog(this, "Erro ao editar!");
            }
        }
    }

    private void remover() {
        int index = listaProdutos.getSelectedIndex();
        if (index != -1) {
            modelo.remove(index);
            limpar();
        }
    }

    private void limpar() {
        txtCod.setText(""); txtDesc.setText(""); txtGrp.setText("");
        txtPCompra.setText(""); txtEstoque.setText(""); txtPVenda.setText("");
        listaProdutos.clearSelection();
    }
}