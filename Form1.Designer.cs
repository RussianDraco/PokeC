namespace PokeC;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvCards;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtType;
    private System.Windows.Forms.TextBox txtHP;
    private System.Windows.Forms.TextBox txtRarity;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblHP;
    private System.Windows.Forms.Label lblRarity;

    private void InitializeComponent()
    {
        this.dgvCards = new System.Windows.Forms.DataGridView();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnSave = new System.Windows.Forms.Button();
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtType = new System.Windows.Forms.TextBox();
        this.txtHP = new System.Windows.Forms.TextBox();
        this.txtRarity = new System.Windows.Forms.TextBox();
        this.lblName = new System.Windows.Forms.Label();
        this.lblType = new System.Windows.Forms.Label();
        this.lblHP = new System.Windows.Forms.Label();
        this.lblRarity = new System.Windows.Forms.Label();
        
        this.dgvCards.Location = new System.Drawing.Point(20, 20);
        this.dgvCards.Size = new System.Drawing.Size(400, 200);

        this.lblName.Text = "Name:";
        this.lblName.Location = new System.Drawing.Point(20, 230);
        this.txtName.Location = new System.Drawing.Point(80, 230);

        this.lblType.Text = "Type:";
        this.lblType.Location = new System.Drawing.Point(20, 260);
        this.txtType.Location = new System.Drawing.Point(80, 260);

        this.lblHP.Text = "HP:";
        this.lblHP.Location = new System.Drawing.Point(20, 290);
        this.txtHP.Location = new System.Drawing.Point(80, 290);

        this.lblRarity.Text = "Rarity:";
        this.lblRarity.Location = new System.Drawing.Point(20, 320);
        this.txtRarity.Location = new System.Drawing.Point(80, 320);

        this.btnAdd.Text = "Add";
        this.btnAdd.Location = new System.Drawing.Point(20, 360);
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        this.btnUpdate.Text = "Update";
        this.btnUpdate.Location = new System.Drawing.Point(100, 360);
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

        this.btnDelete.Text = "Delete";
        this.btnDelete.Location = new System.Drawing.Point(180, 360);
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

        this.btnSave.Text = "Save";
        this.btnSave.Location = new System.Drawing.Point(260, 360);
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

        this.ClientSize = new System.Drawing.Size(450, 400);
        this.Controls.Add(this.dgvCards);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblType);
        this.Controls.Add(this.txtType);
        this.Controls.Add(this.lblHP);
        this.Controls.Add(this.txtHP);
        this.Controls.Add(this.lblRarity);
        this.Controls.Add(this.txtRarity);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnSave);
        this.Text = "Pokémon Card Manager";
    }
}
