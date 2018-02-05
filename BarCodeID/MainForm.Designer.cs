namespace BarCodeID
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.ident_page = new System.Windows.Forms.TabPage();
            this.list_ident_data = new System.Windows.Forms.ListBox();
            this.print_page_poluf = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.change_interval_cmb = new System.Windows.Forms.ComboBox();
            this.clear_lists_btn = new System.Windows.Forms.Button();
            this.add_from_skanner_btn = new System.Windows.Forms.Button();
            this.incr_sn_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.add_qr_btn = new System.Windows.Forms.Button();
            this.qr_size_poluf = new System.Windows.Forms.NumericUpDown();
            this.qr_add_poluf = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.del_btn_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.sn_param_poluf = new System.Windows.Forms.ComboBox();
            this.qr_result_poluf = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.del_item_qr_result = new System.Windows.Forms.ToolStripMenuItem();
            this.value_poluf_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.param_poluf_cmb = new System.Windows.Forms.ComboBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.sn_array_count = new System.Windows.Forms.NumericUpDown();
            this.add_sn_chk = new System.Windows.Forms.CheckBox();
            this.database_page = new System.Windows.Forms.TabPage();
            this.listKeyPairs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_data = new System.Windows.Forms.ListView();
            this.id_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_len_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_descr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.property_page = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.path_btn = new System.Windows.Forms.Button();
            this.path_lbl = new System.Windows.Forms.Label();
            this.timer_scan = new System.Windows.Forms.Timer(this.components);
            this.tab_control.SuspendLayout();
            this.ident_page.SuspendLayout();
            this.print_page_poluf.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_size_poluf)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sn_array_count)).BeginInit();
            this.database_page.SuspendLayout();
            this.property_page.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.ident_page);
            this.tab_control.Controls.Add(this.print_page_poluf);
            this.tab_control.Controls.Add(this.database_page);
            this.tab_control.Controls.Add(this.property_page);
            this.tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1021, 507);
            this.tab_control.TabIndex = 0;
            this.tab_control.SelectedIndexChanged += new System.EventHandler(this.tab_control_SelectedIndexChanged);
            this.tab_control.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tab_control_KeyPress);
            // 
            // ident_page
            // 
            this.ident_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ident_page.Controls.Add(this.list_ident_data);
            this.ident_page.Location = new System.Drawing.Point(4, 29);
            this.ident_page.Margin = new System.Windows.Forms.Padding(0);
            this.ident_page.Name = "ident_page";
            this.ident_page.Padding = new System.Windows.Forms.Padding(3);
            this.ident_page.Size = new System.Drawing.Size(1013, 474);
            this.ident_page.TabIndex = 0;
            this.ident_page.Text = "Идентификация";
            this.ident_page.UseVisualStyleBackColor = true;
            // 
            // list_ident_data
            // 
            this.list_ident_data.FormattingEnabled = true;
            this.list_ident_data.ItemHeight = 20;
            this.list_ident_data.Location = new System.Drawing.Point(244, 3);
            this.list_ident_data.Name = "list_ident_data";
            this.list_ident_data.Size = new System.Drawing.Size(760, 464);
            this.list_ident_data.TabIndex = 0;
            // 
            // print_page_poluf
            // 
            this.print_page_poluf.Controls.Add(this.groupBox1);
            this.print_page_poluf.Location = new System.Drawing.Point(4, 29);
            this.print_page_poluf.Name = "print_page_poluf";
            this.print_page_poluf.Padding = new System.Windows.Forms.Padding(3);
            this.print_page_poluf.Size = new System.Drawing.Size(1013, 474);
            this.print_page_poluf.TabIndex = 1;
            this.print_page_poluf.Text = "Печать этикеток ";
            this.print_page_poluf.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.change_interval_cmb);
            this.groupBox1.Controls.Add(this.clear_lists_btn);
            this.groupBox1.Controls.Add(this.add_from_skanner_btn);
            this.groupBox1.Controls.Add(this.incr_sn_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.add_qr_btn);
            this.groupBox1.Controls.Add(this.qr_size_poluf);
            this.groupBox1.Controls.Add(this.qr_add_poluf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sn_param_poluf);
            this.groupBox1.Controls.Add(this.qr_result_poluf);
            this.groupBox1.Controls.Add(this.value_poluf_cmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.param_poluf_cmb);
            this.groupBox1.Controls.Add(this.print_btn);
            this.groupBox1.Controls.Add(this.sn_array_count);
            this.groupBox1.Controls.Add(this.add_sn_chk);
            this.groupBox1.Location = new System.Drawing.Point(256, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные этикетки";
            // 
            // change_interval_cmb
            // 
            this.change_interval_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.change_interval_cmb.FormattingEnabled = true;
            this.change_interval_cmb.Items.AddRange(new object[] {
            "1",
            "10",
            "20"});
            this.change_interval_cmb.Location = new System.Drawing.Point(144, 135);
            this.change_interval_cmb.Name = "change_interval_cmb";
            this.change_interval_cmb.Size = new System.Drawing.Size(42, 28);
            this.change_interval_cmb.TabIndex = 25;
            // 
            // clear_lists_btn
            // 
            this.clear_lists_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_lists_btn.Location = new System.Drawing.Point(421, 424);
            this.clear_lists_btn.Name = "clear_lists_btn";
            this.clear_lists_btn.Size = new System.Drawing.Size(146, 31);
            this.clear_lists_btn.TabIndex = 24;
            this.clear_lists_btn.Text = "Очитстить формы";
            this.clear_lists_btn.UseVisualStyleBackColor = true;
            this.clear_lists_btn.Click += new System.EventHandler(this.clear_lists_btn_Click);
            // 
            // add_from_skanner_btn
            // 
            this.add_from_skanner_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_from_skanner_btn.Location = new System.Drawing.Point(214, 313);
            this.add_from_skanner_btn.Name = "add_from_skanner_btn";
            this.add_from_skanner_btn.Size = new System.Drawing.Size(201, 31);
            this.add_from_skanner_btn.TabIndex = 23;
            this.add_from_skanner_btn.Text = "Сканировать входные детали";
            this.add_from_skanner_btn.UseVisualStyleBackColor = true;
            this.add_from_skanner_btn.Click += new System.EventHandler(this.add_from_skanner_btn_Click);
            // 
            // incr_sn_btn
            // 
            this.incr_sn_btn.Location = new System.Drawing.Point(421, 364);
            this.incr_sn_btn.Name = "incr_sn_btn";
            this.incr_sn_btn.Size = new System.Drawing.Size(321, 28);
            this.incr_sn_btn.TabIndex = 22;
            this.incr_sn_btn.Text = "Увеличить серийный номер на 1";
            this.incr_sn_btn.UseVisualStyleBackColor = true;
            this.incr_sn_btn.Click += new System.EventHandler(this.incr_sn_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Размер Qr кода";
            // 
            // add_qr_btn
            // 
            this.add_qr_btn.Location = new System.Drawing.Point(359, 97);
            this.add_qr_btn.Name = "add_qr_btn";
            this.add_qr_btn.Size = new System.Drawing.Size(38, 30);
            this.add_qr_btn.TabIndex = 21;
            this.add_qr_btn.Text = "+";
            this.add_qr_btn.UseVisualStyleBackColor = true;
            this.add_qr_btn.Click += new System.EventHandler(this.add_qr_btn_Click);
            // 
            // qr_size_poluf
            // 
            this.qr_size_poluf.Location = new System.Drawing.Point(18, 136);
            this.qr_size_poluf.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.qr_size_poluf.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.qr_size_poluf.Name = "qr_size_poluf";
            this.qr_size_poluf.ReadOnly = true;
            this.qr_size_poluf.Size = new System.Drawing.Size(120, 26);
            this.qr_size_poluf.TabIndex = 16;
            this.qr_size_poluf.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.qr_size_poluf.ValueChanged += new System.EventHandler(this.qr_size_poluf_ValueChanged);
            // 
            // qr_add_poluf
            // 
            this.qr_add_poluf.ContextMenuStrip = this.contextMenuStrip1;
            this.qr_add_poluf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qr_add_poluf.FormattingEnabled = true;
            this.qr_add_poluf.HorizontalScrollbar = true;
            this.qr_add_poluf.Location = new System.Drawing.Point(6, 173);
            this.qr_add_poluf.Name = "qr_add_poluf";
            this.qr_add_poluf.Size = new System.Drawing.Size(409, 134);
            this.qr_add_poluf.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.del_btn_menu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // del_btn_menu
            // 
            this.del_btn_menu.Name = "del_btn_menu";
            this.del_btn_menu.Size = new System.Drawing.Size(118, 22);
            this.del_btn_menu.Text = "Удалить";
            this.del_btn_menu.Click += new System.EventHandler(this.del_btn_menu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Параметр серийного номера";
            // 
            // sn_param_poluf
            // 
            this.sn_param_poluf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sn_param_poluf.FormattingEnabled = true;
            this.sn_param_poluf.Location = new System.Drawing.Point(18, 386);
            this.sn_param_poluf.Name = "sn_param_poluf";
            this.sn_param_poluf.Size = new System.Drawing.Size(236, 28);
            this.sn_param_poluf.TabIndex = 18;
            // 
            // qr_result_poluf
            // 
            this.qr_result_poluf.ContextMenuStrip = this.contextMenuStrip2;
            this.qr_result_poluf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qr_result_poluf.FormattingEnabled = true;
            this.qr_result_poluf.Location = new System.Drawing.Point(421, 16);
            this.qr_result_poluf.Name = "qr_result_poluf";
            this.qr_result_poluf.Size = new System.Drawing.Size(321, 342);
            this.qr_result_poluf.TabIndex = 13;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.del_item_qr_result});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(119, 26);
            // 
            // del_item_qr_result
            // 
            this.del_item_qr_result.Name = "del_item_qr_result";
            this.del_item_qr_result.Size = new System.Drawing.Size(118, 22);
            this.del_item_qr_result.Text = "Удалить";
            this.del_item_qr_result.Click += new System.EventHandler(this.del_item_qr_result_Click);
            // 
            // value_poluf_cmb
            // 
            this.value_poluf_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.value_poluf_cmb.FormattingEnabled = true;
            this.value_poluf_cmb.Location = new System.Drawing.Point(160, 64);
            this.value_poluf_cmb.Name = "value_poluf_cmb";
            this.value_poluf_cmb.Size = new System.Drawing.Size(236, 28);
            this.value_poluf_cmb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выбор значения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Выбор параметра";
            // 
            // param_poluf_cmb
            // 
            this.param_poluf_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.param_poluf_cmb.FormattingEnabled = true;
            this.param_poluf_cmb.Location = new System.Drawing.Point(161, 30);
            this.param_poluf_cmb.Name = "param_poluf_cmb";
            this.param_poluf_cmb.Size = new System.Drawing.Size(236, 28);
            this.param_poluf_cmb.TabIndex = 9;
            this.param_poluf_cmb.SelectedIndexChanged += new System.EventHandler(this.param_poluf_cmb_SelectedIndexChanged);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(667, 420);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 34);
            this.print_btn.TabIndex = 8;
            this.print_btn.Text = "Печать";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // sn_array_count
            // 
            this.sn_array_count.Location = new System.Drawing.Point(247, 429);
            this.sn_array_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sn_array_count.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sn_array_count.Name = "sn_array_count";
            this.sn_array_count.Size = new System.Drawing.Size(120, 26);
            this.sn_array_count.TabIndex = 7;
            this.sn_array_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // add_sn_chk
            // 
            this.add_sn_chk.AutoSize = true;
            this.add_sn_chk.Location = new System.Drawing.Point(18, 430);
            this.add_sn_chk.Name = "add_sn_chk";
            this.add_sn_chk.Size = new System.Drawing.Size(223, 24);
            this.add_sn_chk.TabIndex = 6;
            this.add_sn_chk.Text = "Печатать серию номеров";
            this.add_sn_chk.UseVisualStyleBackColor = true;
            this.add_sn_chk.CheckedChanged += new System.EventHandler(this.add_sn_chk_CheckedChanged);
            // 
            // database_page
            // 
            this.database_page.Controls.Add(this.listKeyPairs);
            this.database_page.Controls.Add(this.list_data);
            this.database_page.Location = new System.Drawing.Point(4, 29);
            this.database_page.Name = "database_page";
            this.database_page.Size = new System.Drawing.Size(1013, 474);
            this.database_page.TabIndex = 3;
            this.database_page.Text = "Справочник";
            this.database_page.UseVisualStyleBackColor = true;
            // 
            // listKeyPairs
            // 
            this.listKeyPairs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listKeyPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listKeyPairs.FullRowSelect = true;
            this.listKeyPairs.GridLines = true;
            this.listKeyPairs.Location = new System.Drawing.Point(409, 17);
            this.listKeyPairs.MultiSelect = false;
            this.listKeyPairs.Name = "listKeyPairs";
            this.listKeyPairs.Size = new System.Drawing.Size(595, 449);
            this.listKeyPairs.TabIndex = 2;
            this.listKeyPairs.UseCompatibleStateImageBehavior = false;
            this.listKeyPairs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Запись";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 425;
            // 
            // list_data
            // 
            this.list_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_data,
            this.data_len_column,
            this.data_descr});
            this.list_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_data.FullRowSelect = true;
            this.list_data.GridLines = true;
            this.list_data.Location = new System.Drawing.Point(9, 17);
            this.list_data.MultiSelect = false;
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(394, 449);
            this.list_data.TabIndex = 0;
            this.list_data.UseCompatibleStateImageBehavior = false;
            this.list_data.View = System.Windows.Forms.View.Details;
            this.list_data.SelectedIndexChanged += new System.EventHandler(this.list_data_SelectedIndexChanged);
            // 
            // id_data
            // 
            this.id_data.Text = "Идентификатор типа записи";
            this.id_data.Width = 160;
            // 
            // data_len_column
            // 
            this.data_len_column.Text = "Кол-во цифр";
            this.data_len_column.Width = 76;
            // 
            // data_descr
            // 
            this.data_descr.Text = "Назначение(описание)";
            this.data_descr.Width = 134;
            // 
            // property_page
            // 
            this.property_page.Controls.Add(this.groupBox3);
            this.property_page.Location = new System.Drawing.Point(4, 29);
            this.property_page.Name = "property_page";
            this.property_page.Size = new System.Drawing.Size(1013, 474);
            this.property_page.TabIndex = 4;
            this.property_page.Text = "Настройки";
            this.property_page.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.path_btn);
            this.groupBox3.Controls.Add(this.path_lbl);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 89);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Путь к файлу справочника";
            // 
            // path_btn
            // 
            this.path_btn.Location = new System.Drawing.Point(6, 34);
            this.path_btn.Name = "path_btn";
            this.path_btn.Size = new System.Drawing.Size(90, 30);
            this.path_btn.TabIndex = 1;
            this.path_btn.Text = "Выбрать";
            this.path_btn.UseVisualStyleBackColor = true;
            this.path_btn.Click += new System.EventHandler(this.path_btn_Click);
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.Location = new System.Drawing.Point(102, 39);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(17, 20);
            this.path_lbl.TabIndex = 0;
            this.path_lbl.Text = "..";
            // 
            // timer_scan
            // 
            this.timer_scan.Interval = 1000;
            this.timer_scan.Tick += new System.EventHandler(this.timer_scan_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 507);
            this.Controls.Add(this.tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QR::Терминал";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tab_control.ResumeLayout(false);
            this.ident_page.ResumeLayout(false);
            this.print_page_poluf.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qr_size_poluf)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sn_array_count)).EndInit();
            this.database_page.ResumeLayout(false);
            this.property_page.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage ident_page;
        private System.Windows.Forms.TabPage print_page_poluf;
        private System.Windows.Forms.TabPage database_page;
        private System.Windows.Forms.TabPage property_page;
        private System.Windows.Forms.ListView list_data;
        private System.Windows.Forms.ColumnHeader id_data;
        private System.Windows.Forms.ColumnHeader data_len_column;
        private System.Windows.Forms.ColumnHeader data_descr;
        private System.Windows.Forms.ListView listKeyPairs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button path_btn;
        private System.Windows.Forms.Label path_lbl;
        private System.Windows.Forms.ListBox list_ident_data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.NumericUpDown sn_array_count;
        private System.Windows.Forms.CheckBox add_sn_chk;
        private System.Windows.Forms.ListBox qr_result_poluf;
        private System.Windows.Forms.ComboBox value_poluf_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox param_poluf_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown qr_size_poluf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sn_param_poluf;
        private System.Windows.Forms.ListBox qr_add_poluf;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem del_btn_menu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem del_item_qr_result;
        private System.Windows.Forms.Button add_qr_btn;
        private System.Windows.Forms.Button incr_sn_btn;
        private System.Windows.Forms.Button add_from_skanner_btn;
        private System.Windows.Forms.Timer timer_scan;
        private System.Windows.Forms.Button clear_lists_btn;
        private System.Windows.Forms.ComboBox change_interval_cmb;
    }
}

