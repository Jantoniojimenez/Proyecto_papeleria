namespace App_Papeleria
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ListArchivos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboPrefijos = new System.Windows.Forms.ComboBox();
            this.TexFecha1 = new System.Windows.Forms.TextBox();
            this.TexFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelOrdenes = new System.Windows.Forms.Panel();
            this.IButtonHistorial = new FontAwesome.Sharp.IconButton();
            this.ButtonImpresiones = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.IconBGetData = new FontAwesome.Sharp.IconButton();
            this.OrdenesAndPrefijo = new System.Windows.Forms.TextBox();
            this.linkPrefijo = new System.Windows.Forms.LinkLabel();
            this.IconDesplazar = new FontAwesome.Sharp.IconPictureBox();
            this.IconBuscarPrefijo = new FontAwesome.Sharp.IconButton();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconDesplazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.ListArchivos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ComboPrefijos);
            this.panel1.Controls.Add(this.TexFecha1);
            this.panel1.Controls.Add(this.TexFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 792);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(591, 37);
            this.dateTimePicker2.MaximumSize = new System.Drawing.Size(21, 24);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(21, 24);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(21, 24);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged_1);
            // 
            // ListArchivos
            // 
            this.ListArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ListArchivos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListArchivos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListArchivos.FormattingEnabled = true;
            this.ListArchivos.HorizontalScrollbar = true;
            this.ListArchivos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListArchivos.ItemHeight = 19;
            this.ListArchivos.Location = new System.Drawing.Point(3, 73);
            this.ListArchivos.Name = "ListArchivos";
            this.ListArchivos.Size = new System.Drawing.Size(609, 707);
            this.ListArchivos.TabIndex = 6;
            this.ListArchivos.SelectedIndexChanged += new System.EventHandler(this.ListArchivos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(51, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prefijos";
            // 
            // ComboPrefijos
            // 
            this.ComboPrefijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPrefijos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboPrefijos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPrefijos.FormattingEnabled = true;
            this.ComboPrefijos.Location = new System.Drawing.Point(3, 36);
            this.ComboPrefijos.MinimumSize = new System.Drawing.Size(157, 0);
            this.ComboPrefijos.Name = "ComboPrefijos";
            this.ComboPrefijos.Size = new System.Drawing.Size(157, 29);
            this.ComboPrefijos.TabIndex = 0;
            this.ComboPrefijos.DropDown += new System.EventHandler(this.ComboPrefijos_DropDown);
            this.ComboPrefijos.SelectionChangeCommitted += new System.EventHandler(this.ComboPrefijos_SelectionChangeCommitted);
            // 
            // TexFecha1
            // 
            this.TexFecha1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexFecha1.HideSelection = false;
            this.TexFecha1.Location = new System.Drawing.Point(393, 37);
            this.TexFecha1.Multiline = true;
            this.TexFecha1.Name = "TexFecha1";
            this.TexFecha1.Size = new System.Drawing.Size(192, 25);
            this.TexFecha1.TabIndex = 2;
            // 
            // TexFecha
            // 
            this.TexFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexFecha.HideSelection = false;
            this.TexFecha.Location = new System.Drawing.Point(166, 37);
            this.TexFecha.Multiline = true;
            this.TexFecha.Name = "TexFecha";
            this.TexFecha.Size = new System.Drawing.Size(194, 25);
            this.TexFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(450, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(230, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora Inicial";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 37);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(21, 24);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(21, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 24);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.PanelOrdenes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IconBGetData);
            this.panel2.Controls.Add(this.OrdenesAndPrefijo);
            this.panel2.Controls.Add(this.linkPrefijo);
            this.panel2.Controls.Add(this.IconDesplazar);
            this.panel2.Controls.Add(this.IconBuscarPrefijo);
            this.panel2.Controls.Add(this.GridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(618, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 792);
            this.panel2.TabIndex = 1;
            // 
            // PanelOrdenes
            // 
            this.PanelOrdenes.Controls.Add(this.IButtonHistorial);
            this.PanelOrdenes.Controls.Add(this.ButtonImpresiones);
            this.PanelOrdenes.Location = new System.Drawing.Point(547, 50);
            this.PanelOrdenes.Name = "PanelOrdenes";
            this.PanelOrdenes.Size = new System.Drawing.Size(173, 100);
            this.PanelOrdenes.TabIndex = 9;
            // 
            // IButtonHistorial
            // 
            this.IButtonHistorial.AutoSize = true;
            this.IButtonHistorial.BackColor = System.Drawing.Color.DimGray;
            this.IButtonHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IButtonHistorial.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.IButtonHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IButtonHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IButtonHistorial.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IButtonHistorial.IconColor = System.Drawing.Color.White;
            this.IButtonHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IButtonHistorial.IconSize = 22;
            this.IButtonHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IButtonHistorial.Location = new System.Drawing.Point(2, 67);
            this.IButtonHistorial.Name = "IButtonHistorial";
            this.IButtonHistorial.Size = new System.Drawing.Size(173, 30);
            this.IButtonHistorial.TabIndex = 9;
            this.IButtonHistorial.Text = "All complete";
            this.IButtonHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IButtonHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IButtonHistorial.UseVisualStyleBackColor = false;
            this.IButtonHistorial.Click += new System.EventHandler(this.IButtonHistorial_Click);
            // 
            // ButtonImpresiones
            // 
            this.ButtonImpresiones.AutoSize = true;
            this.ButtonImpresiones.BackColor = System.Drawing.Color.DimGray;
            this.ButtonImpresiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonImpresiones.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ButtonImpresiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImpresiones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonImpresiones.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ButtonImpresiones.IconColor = System.Drawing.Color.White;
            this.ButtonImpresiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonImpresiones.IconSize = 22;
            this.ButtonImpresiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonImpresiones.Location = new System.Drawing.Point(2, 19);
            this.ButtonImpresiones.Name = "ButtonImpresiones";
            this.ButtonImpresiones.Size = new System.Drawing.Size(173, 30);
            this.ButtonImpresiones.TabIndex = 8;
            this.ButtonImpresiones.Text = "By Impressions";
            this.ButtonImpresiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonImpresiones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonImpresiones.UseVisualStyleBackColor = false;
            this.ButtonImpresiones.Click += new System.EventHandler(this.ButtonImpresiones_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(321, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listado de ordenes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconBGetData
            // 
            this.IconBGetData.AutoSize = true;
            this.IconBGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IconBGetData.BackColor = System.Drawing.Color.Transparent;
            this.IconBGetData.FlatAppearance.BorderSize = 0;
            this.IconBGetData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IconBGetData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.IconBGetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBGetData.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.IconBGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBGetData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconBGetData.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.IconBGetData.IconColor = System.Drawing.Color.White;
            this.IconBGetData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBGetData.IconSize = 22;
            this.IconBGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBGetData.Location = new System.Drawing.Point(547, 17);
            this.IconBGetData.Name = "IconBGetData";
            this.IconBGetData.Size = new System.Drawing.Size(173, 30);
            this.IconBGetData.TabIndex = 7;
            this.IconBGetData.Text = "Historial Ordenes";
            this.IconBGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconBGetData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IconBGetData.UseVisualStyleBackColor = false;
            this.IconBGetData.Click += new System.EventHandler(this.IconBGetData_Click);
            this.IconBGetData.MouseHover += new System.EventHandler(this.IconBGetData_MouseHover);
            // 
            // OrdenesAndPrefijo
            // 
            this.OrdenesAndPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdenesAndPrefijo.Location = new System.Drawing.Point(341, 25);
            this.OrdenesAndPrefijo.MaxLength = 0;
            this.OrdenesAndPrefijo.Name = "OrdenesAndPrefijo";
            this.OrdenesAndPrefijo.ReadOnly = true;
            this.OrdenesAndPrefijo.Size = new System.Drawing.Size(153, 24);
            this.OrdenesAndPrefijo.TabIndex = 6;
            this.OrdenesAndPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkPrefijo
            // 
            this.linkPrefijo.ActiveLinkColor = System.Drawing.Color.Teal;
            this.linkPrefijo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkPrefijo.AutoEllipsis = true;
            this.linkPrefijo.AutoSize = true;
            this.linkPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrefijo.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkPrefijo.Location = new System.Drawing.Point(786, 22);
            this.linkPrefijo.MinimumSize = new System.Drawing.Size(400, 20);
            this.linkPrefijo.Name = "linkPrefijo";
            this.linkPrefijo.Size = new System.Drawing.Size(537, 20);
            this.linkPrefijo.TabIndex = 5;
            this.linkPrefijo.TabStop = true;
            this.linkPrefijo.Text = "Cuando busque un prefijo, aqui aparecera el link si este, es encontrado";
            this.linkPrefijo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkPrefijo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPrefijo_LinkClicked);
            // 
            // IconDesplazar
            // 
            this.IconDesplazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(123)))));
            this.IconDesplazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconDesplazar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.IconDesplazar.IconColor = System.Drawing.Color.White;
            this.IconDesplazar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconDesplazar.IconSize = 56;
            this.IconDesplazar.Location = new System.Drawing.Point(0, 3);
            this.IconDesplazar.Name = "IconDesplazar";
            this.IconDesplazar.Size = new System.Drawing.Size(69, 56);
            this.IconDesplazar.TabIndex = 4;
            this.IconDesplazar.TabStop = false;
            this.IconDesplazar.Click += new System.EventHandler(this.IconPictureBox1_Click);
            // 
            // IconBuscarPrefijo
            // 
            this.IconBuscarPrefijo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IconBuscarPrefijo.BackColor = System.Drawing.Color.Transparent;
            this.IconBuscarPrefijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IconBuscarPrefijo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconBuscarPrefijo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.IconBuscarPrefijo.FlatAppearance.BorderSize = 0;
            this.IconBuscarPrefijo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.IconBuscarPrefijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.IconBuscarPrefijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBuscarPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBuscarPrefijo.ForeColor = System.Drawing.Color.Transparent;
            this.IconBuscarPrefijo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconBuscarPrefijo.IconColor = System.Drawing.Color.White;
            this.IconBuscarPrefijo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBuscarPrefijo.IconSize = 25;
            this.IconBuscarPrefijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBuscarPrefijo.Location = new System.Drawing.Point(94, 14);
            this.IconBuscarPrefijo.MaximumSize = new System.Drawing.Size(263, 56);
            this.IconBuscarPrefijo.Name = "IconBuscarPrefijo";
            this.IconBuscarPrefijo.Size = new System.Drawing.Size(211, 37);
            this.IconBuscarPrefijo.TabIndex = 3;
            this.IconBuscarPrefijo.Text = "Buscar Prefijo";
            this.IconBuscarPrefijo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBuscarPrefijo.UseCompatibleTextRendering = true;
            this.IconBuscarPrefijo.UseVisualStyleBackColor = false;
            this.IconBuscarPrefijo.Click += new System.EventHandler(this.IconBuscarPrefijo_Click);
            // 
            // GridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridView1.Location = new System.Drawing.Point(3, 73);
            this.GridView1.Name = "GridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridView1.RowTemplate.Height = 24;
            this.GridView1.Size = new System.Drawing.Size(1157, 707);
            this.GridView1.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1784, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1469, 798);
            this.Name = "FormPrincipal";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extraer_Archivos_Papeleria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelOrdenes.ResumeLayout(false);
            this.PanelOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconDesplazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboPrefijos;
        private System.Windows.Forms.TextBox TexFecha1;
        private System.Windows.Forms.TextBox TexFecha;
        private System.Windows.Forms.ListBox ListArchivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView GridView1;
        private FontAwesome.Sharp.IconPictureBox IconDesplazar;
        private FontAwesome.Sharp.IconButton IconBuscarPrefijo;
        private System.Windows.Forms.LinkLabel linkPrefijo;
        private System.Windows.Forms.TextBox OrdenesAndPrefijo;
        private FontAwesome.Sharp.IconButton IconBGetData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PanelOrdenes;
        private FontAwesome.Sharp.IconButton IButtonHistorial;
        private FontAwesome.Sharp.IconButton ButtonImpresiones;
    }
}

