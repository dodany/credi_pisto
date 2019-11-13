﻿namespace Pisto_credito.Interface
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectos = new System.Windows.Forms.ToolStripMenuItem();
            this.verProspectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarProspectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarios,
            this.prospectos,
            this.clientes,
            this.productos,
            this.permisos,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarios
            // 
            this.usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuariosToolStripMenuItem});
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(71, 21);
            this.usuarios.Text = "Usuarios";
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // prospectos
            // 
            this.prospectos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProspectosToolStripMenuItem,
            this.verificarProspectosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem});
            this.prospectos.Name = "prospectos";
            this.prospectos.Size = new System.Drawing.Size(85, 21);
            this.prospectos.Text = "Prospectos";
            // 
            // verProspectosToolStripMenuItem
            // 
            this.verProspectosToolStripMenuItem.Name = "verProspectosToolStripMenuItem";
            this.verProspectosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verProspectosToolStripMenuItem.Text = "Ver Prospectos";
            // 
            // verificarProspectosToolStripMenuItem
            // 
            this.verificarProspectosToolStripMenuItem.Name = "verificarProspectosToolStripMenuItem";
            this.verificarProspectosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.verificarProspectosToolStripMenuItem.Text = "Evaluar Prospectos";
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // clientes
            // 
            this.clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verClientesToolStripMenuItem,
            this.estadoClientesToolStripMenuItem});
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(65, 21);
            this.clientes.Text = "Clientes";
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            // 
            // estadoClientesToolStripMenuItem
            // 
            this.estadoClientesToolStripMenuItem.Name = "estadoClientesToolStripMenuItem";
            this.estadoClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoClientesToolStripMenuItem.Text = "Estado Clientes";
            // 
            // productos
            // 
            this.productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem});
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(79, 21);
            this.productos.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            // 
            // permisos
            // 
            this.permisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPermisosToolStripMenuItem});
            this.permisos.Name = "permisos";
            this.permisos.Size = new System.Drawing.Size(73, 21);
            this.permisos.Text = "Permisos";
            // 
            // gestionarPermisosToolStripMenuItem
            // 
            this.gestionarPermisosToolStripMenuItem.Name = "gestionarPermisosToolStripMenuItem";
            this.gestionarPermisosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestionarPermisosToolStripMenuItem.Text = "Gestionar Permisos";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 479);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarios;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prospectos;
        private System.Windows.Forms.ToolStripMenuItem verProspectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarProspectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientes;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisos;
        private System.Windows.Forms.ToolStripMenuItem gestionarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}