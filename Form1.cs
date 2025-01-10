namespace PokeC;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

public partial class Form1 : Form
{
    static List<PokeCard> cards = new List<PokeCard>();
    const string jsonPath = "cards.json";

    public Form1()
    {
        InitializeComponent();
        LoadCards();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvCards.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a card to update.");
            return;
        }

        var selectedRowIndex = dgvCards.SelectedRows[0].Index;
        var card = cards[selectedRowIndex];

        card.Name = txtName.Text;
        card.Type = txtType.Text;
        card.HP = int.Parse(txtHP.Text);
        card.Rarity = txtRarity.Text;

        RefreshCardList();
        MessageBox.Show("Card updated successfully.");
    }


    private void btnAdd_Click(object sender, EventArgs e)
    {
        var card = new PokeCard {
            Name = txtName.Text,
            Type = txtType.Text,
            HP = int.Parse(txtHP.Text),
            Rarity = txtRarity.Text
        };
        cards.Add(card);
        RefreshCardList();
    }

    private void RefreshCardList() {
        dgvCards.DataSource = null;
        dgvCards.DataSource = cards;
    }

    private void LoadCards() {
        if (File.Exists(jsonPath)) {
            string json = File.ReadAllText(jsonPath);
            cards = JsonConvert.DeserializeObject<List<PokeCard>>(json);
        }
    }

    private void SaveCards() {
        var json = JsonConvert.SerializeObject(cards, Formatting.Indented);
        File.WriteAllText(jsonPath, json);
    }
}
