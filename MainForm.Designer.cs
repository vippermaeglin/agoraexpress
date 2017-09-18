/*
 * Criado por SharpDevelop.
 * Usuário: Vipper
 * Data: 26/9/2010
 * Hora: 16:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Agora_Express
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.sAIRToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem1,
            this.gerenciarToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            resources.ApplyResources(this.funcionáriosToolStripMenuItem, "funcionáriosToolStripMenuItem");
            // 
            // cadastrarNovoToolStripMenuItem1
            // 
            this.cadastrarNovoToolStripMenuItem1.Name = "cadastrarNovoToolStripMenuItem1";
            resources.ApplyResources(this.cadastrarNovoToolStripMenuItem1, "cadastrarNovoToolStripMenuItem1");
            this.cadastrarNovoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem1_Click);
            // 
            // gerenciarToolStripMenuItem1
            // 
            this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
            resources.ApplyResources(this.gerenciarToolStripMenuItem1, "gerenciarToolStripMenuItem1");
            this.gerenciarToolStripMenuItem1.Click += new System.EventHandler(this.gerenciarToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.gerenciarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            resources.ApplyResources(this.cadastrarNovoToolStripMenuItem, "cadastrarNovoToolStripMenuItem");
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            resources.ApplyResources(this.gerenciarToolStripMenuItem, "gerenciarToolStripMenuItem");
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovaToolStripMenuItem,
            this.gerenciarToolStripMenuItem2});
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            resources.ApplyResources(this.sAIRToolStripMenuItem, "sAIRToolStripMenuItem");
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // criarNovaToolStripMenuItem
            // 
            this.criarNovaToolStripMenuItem.Name = "criarNovaToolStripMenuItem";
            resources.ApplyResources(this.criarNovaToolStripMenuItem, "criarNovaToolStripMenuItem");
            this.criarNovaToolStripMenuItem.Click += new System.EventHandler(this.criarNovaToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem2
            // 
            this.gerenciarToolStripMenuItem2.Name = "gerenciarToolStripMenuItem2";
            resources.ApplyResources(this.gerenciarToolStripMenuItem2, "gerenciarToolStripMenuItem2");
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.funcionáriosToolStripMenuItem1,
            this.oSToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            resources.ApplyResources(this.clientesToolStripMenuItem1, "clientesToolStripMenuItem1");
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            resources.ApplyResources(this.funcionáriosToolStripMenuItem1, "funcionáriosToolStripMenuItem1");
            // 
            // oSToolStripMenuItem
            // 
            this.oSToolStripMenuItem.Name = "oSToolStripMenuItem";
            resources.ApplyResources(this.oSToolStripMenuItem, "oSToolStripMenuItem");
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            resources.ApplyResources(this.financeiroToolStripMenuItem, "financeiroToolStripMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Agora_Express.Properties.Resources.eternal_sky53;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
	}
}
