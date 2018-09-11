namespace Modificar_Parametros
{
    partial class Frm_Modificar_Parametros
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Parametros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.group_parametros = new System.Windows.Forms.GroupBox();
            this.btntipo_alimento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.titulo_parametros = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtparametros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.grilla_parametros = new System.Windows.Forms.DataGridView();
            this.vigente = new System.Windows.Forms.DataGridViewImageColumn();
            this.M = new System.Windows.Forms.DataGridViewImageColumn();
            this.CODIGO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.group_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_parametros)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(7, 6);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 97;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(257, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 47);
            this.btn_limpiar.TabIndex = 96;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Modificar_Parametros.Properties.Resources.save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(152, 1);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(99, 48);
            this.btn_guardar.TabIndex = 95;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // group_parametros
            // 
            this.group_parametros.Controls.Add(this.btntipo_alimento);
            this.group_parametros.Controls.Add(this.label3);
            this.group_parametros.Controls.Add(this.titulo_parametros);
            this.group_parametros.Controls.Add(this.txtdescripcion);
            this.group_parametros.Controls.Add(this.label2);
            this.group_parametros.Controls.Add(this.txtparametros);
            this.group_parametros.Controls.Add(this.label1);
            this.group_parametros.Location = new System.Drawing.Point(7, 60);
            this.group_parametros.Name = "group_parametros";
            this.group_parametros.Size = new System.Drawing.Size(486, 93);
            this.group_parametros.TabIndex = 94;
            this.group_parametros.TabStop = false;
            // 
            // btntipo_alimento
            // 
            this.btntipo_alimento.Image = ((System.Drawing.Image)(resources.GetObject("btntipo_alimento.Image")));
            this.btntipo_alimento.Location = new System.Drawing.Point(397, 31);
            this.btntipo_alimento.Name = "btntipo_alimento";
            this.btntipo_alimento.Size = new System.Drawing.Size(27, 23);
            this.btntipo_alimento.TabIndex = 181;
            this.btntipo_alimento.UseVisualStyleBackColor = true;
            this.btntipo_alimento.Click += new System.EventHandler(this.btntipo_alimento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción ";
            // 
            // titulo_parametros
            // 
            this.titulo_parametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titulo_parametros.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_parametros.ForeColor = System.Drawing.Color.White;
            this.titulo_parametros.Image = ((System.Drawing.Image)(resources.GetObject("titulo_parametros.Image")));
            this.titulo_parametros.Location = new System.Drawing.Point(0, 0);
            this.titulo_parametros.Name = "titulo_parametros";
            this.titulo_parametros.Size = new System.Drawing.Size(494, 25);
            this.titulo_parametros.TabIndex = 79;
            this.titulo_parametros.Text = "Información ";
            this.titulo_parametros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(103, 63);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtdescripcion.TabIndex = 3;
            this.txtdescripcion.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            this.txtdescripcion.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // txtparametros
            // 
            this.txtparametros.BackColor = System.Drawing.Color.White;
            this.txtparametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtparametros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtparametros.Location = new System.Drawing.Point(103, 33);
            this.txtparametros.Name = "txtparametros";
            this.txtparametros.Size = new System.Drawing.Size(288, 20);
            this.txtparametros.TabIndex = 1;
            this.txtparametros.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtparametros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparametros_KeyPress);
            this.txtparametros.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Parametros";
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(390, -17);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 98;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // grilla_parametros
            // 
            this.grilla_parametros.AllowUserToAddRows = false;
            this.grilla_parametros.AllowUserToDeleteRows = false;
            this.grilla_parametros.AllowUserToResizeColumns = false;
            this.grilla_parametros.AllowUserToResizeRows = false;
            this.grilla_parametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_parametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vigente,
            this.M,
            this.CODIGO2,
            this.DESCRIPCION2,
            this.V});
            this.grilla_parametros.Location = new System.Drawing.Point(7, 182);
            this.grilla_parametros.Name = "grilla_parametros";
            this.grilla_parametros.ReadOnly = true;
            this.grilla_parametros.RowHeadersVisible = false;
            this.grilla_parametros.Size = new System.Drawing.Size(486, 230);
            this.grilla_parametros.TabIndex = 99;
            this.grilla_parametros.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_parametros_CellContentDoubleClick);
            this.grilla_parametros.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_parametros_CellPainting);
            // 
            // vigente
            // 
            this.vigente.HeaderText = "V";
            this.vigente.Name = "vigente";
            this.vigente.ReadOnly = true;
            this.vigente.Width = 30;
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.Image = global::Modificar_Parametros.Properties.Resources.ver_ficha;
            this.M.Name = "M";
            this.M.ReadOnly = true;
            this.M.Width = 30;
            // 
            // CODIGO2
            // 
            this.CODIGO2.DataPropertyName = "CODIGO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.CODIGO2.DefaultCellStyle = dataGridViewCellStyle1;
            this.CODIGO2.HeaderText = "CODIGO";
            this.CODIGO2.Name = "CODIGO2";
            this.CODIGO2.ReadOnly = true;
            this.CODIGO2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CODIGO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO2.Width = 50;
            // 
            // DESCRIPCION2
            // 
            this.DESCRIPCION2.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION2.HeaderText = "DESCRIPCION";
            this.DESCRIPCION2.Name = "DESCRIPCION2";
            this.DESCRIPCION2.ReadOnly = true;
            this.DESCRIPCION2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DESCRIPCION2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCRIPCION2.Width = 250;
            // 
            // V
            // 
            this.V.DataPropertyName = "vigencia";
            this.V.HeaderText = "VIGENTE";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Visible = false;
            this.V.Width = 50;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 25);
            this.label4.TabIndex = 183;
            this.label4.Text = "Listado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Modificar_Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grilla_parametros);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.group_parametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Parametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Parametros";
            this.Load += new System.EventHandler(this.Frm_Modificar_Parametros_Load);
            this.group_parametros.ResumeLayout(false);
            this.group_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_parametros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox group_parametros;
        private System.Windows.Forms.Button btntipo_alimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titulo_parametros;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtparametros;
        private System.Windows.Forms.Label label1;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.DataGridView grilla_parametros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn vigente;
        private System.Windows.Forms.DataGridViewImageColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION2;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
    }
}

