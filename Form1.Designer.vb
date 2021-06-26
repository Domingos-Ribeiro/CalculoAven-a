Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAnoNasc = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.numValorBase = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbNao = New System.Windows.Forms.RadioButton()
        Me.rbSim = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnResidencia = New System.Windows.Forms.Panel()
        Me.cmbConcelho = New System.Windows.Forms.ComboBox()
        Me.pnVazio = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkAgrav12 = New System.Windows.Forms.CheckBox()
        Me.chkEscalao10 = New System.Windows.Forms.CheckBox()
        Me.chkSocio5 = New System.Windows.Forms.CheckBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.numValorBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnResidencia.SuspendLayout()
        Me.pnVazio.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ANO DE NASCIMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "VALOR BASE"
        '
        'cmbAnoNasc
        '
        Me.cmbAnoNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnoNasc.FormattingEnabled = True
        Me.cmbAnoNasc.Items.AddRange(New Object() {"2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900"})
        Me.cmbAnoNasc.Location = New System.Drawing.Point(173, 15)
        Me.cmbAnoNasc.Name = "cmbAnoNasc"
        Me.cmbAnoNasc.Size = New System.Drawing.Size(102, 21)
        Me.cmbAnoNasc.TabIndex = 4
        Me.cmbAnoNasc.Text = "Selecione aqui"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(77, 16)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(208, 20)
        Me.txtNome.TabIndex = 5
        '
        'numValorBase
        '
        Me.numValorBase.Location = New System.Drawing.Point(173, 17)
        Me.numValorBase.Name = "numValorBase"
        Me.numValorBase.Size = New System.Drawing.Size(49, 20)
        Me.numValorBase.TabIndex = 6
        Me.numValorBase.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Reside em Braga?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.rbNao)
        Me.Panel1.Controls.Add(Me.rbSim)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(355, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 48)
        Me.Panel1.TabIndex = 8
        '
        'rbNao
        '
        Me.rbNao.AutoSize = True
        Me.rbNao.Location = New System.Drawing.Point(168, 20)
        Me.rbNao.Name = "rbNao"
        Me.rbNao.Size = New System.Drawing.Size(14, 13)
        Me.rbNao.TabIndex = 9
        Me.rbNao.TabStop = True
        Me.rbNao.UseVisualStyleBackColor = True
        '
        'rbSim
        '
        Me.rbSim.AutoSize = True
        Me.rbSim.Location = New System.Drawing.Point(140, 20)
        Me.rbSim.Name = "rbSim"
        Me.rbSim.Size = New System.Drawing.Size(14, 13)
        Me.rbSim.TabIndex = 8
        Me.rbSim.TabStop = True
        Me.rbSim.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(161, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Não"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sim"
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.Color.Red
        Me.lblAviso.Location = New System.Drawing.Point(23, 478)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(307, 25)
        Me.lblAviso.TabIndex = 9
        Me.lblAviso.Text = "POR FAVOR DIGITE O NOME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Como não reside em Braga "
        '
        'pnResidencia
        '
        Me.pnResidencia.Controls.Add(Me.Label7)
        Me.pnResidencia.Controls.Add(Me.cmbConcelho)
        Me.pnResidencia.Location = New System.Drawing.Point(355, 173)
        Me.pnResidencia.Name = "pnResidencia"
        Me.pnResidencia.Size = New System.Drawing.Size(203, 58)
        Me.pnResidencia.TabIndex = 11
        Me.pnResidencia.Visible = False
        '
        'cmbConcelho
        '
        Me.cmbConcelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConcelho.FormattingEnabled = True
        Me.cmbConcelho.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbConcelho.ItemHeight = 13
        Me.cmbConcelho.Items.AddRange(New Object() {"Abrantes", "Águeda", "Aguiar da Beira", "Alandroal", "Albergaria-a-Velha", "Albufeira", "Alcácer do Sal", "Alcanena", "Alcobaça", "Alcochete", "Alcoutim", "Alenquer", "Alfândega da Fé", "Alijó", "Aljezur", "Aljustrel", "Almada", "Almeida", "Almeirim", "Almodôvar", "Alpiarça", "Alter do Chão", "Alvaiázere", "Alvito", "Amadora", "Amarante", "Anadia", "Angra do Heroísmo", "Ansião", "Arcos de Valdevez", "Arganil", "Armamar", "Arouca", "Arraiolos", "Arronches", "Arruda dos Vinhos", "Aveiro", "Avis", "Azambuja", "Baião", "Barrancos", "Barreiro", "Batalha", "Beja", "Belmonte", "Benavente", "Bombarral", "Borba", "Boticas", "Bragança", "Cadaval", "Caldas da Rainha", "Calheta (Madeira)", "Calheta (São Jorge)", "Caminha", "Campo Maior", "Cantanhede", "Carrazeda de Ansiães", "Carregal do Sal", "Cartaxo", "Cascais", "Castanheira de Pêra", "Castelo Branco", "Castelo de Paiva", "Castelo de Vide", "Castro Daire", "Castro Marim", "Castro Verde", "Celorico da Beira", "Chamusca", "Chaves", "Cinfães", "Coimbra", "Condeixa-a-Nova", "Constância", "Coruche", "Corvo", "Covilhã", "Crato", "Cuba", "Câmara de Lobos", "Elvas", "Entroncamento", "Espinho", "Estarreja", "Estremoz", "Évora", "Faro", "Felgueiras", "Ferreira do Alentejo", "Ferreira do Zêzere", "Figueira da Foz", "Figueira de Castelo Rodrigo", "Figueiró dos Vinhos", "Fornos de Algodres", "Freixo de Espada à Cinta", "Fronteira", "Funchal", "Fundão", "Gavião", "Golegã", "Gondomar", "Gouveia", "Grândola", "Guarda", "Góis", "Horta", "Idanha-a-Nova", "Ílhavo", "Lagoa (Algarve)", "Lagoa (São Miguel)", "Lagos", "Lajes das Flores", "Lajes do Pico", "Lamego", "Leiria", "Lisboa", "Loulé", "Loures", "Lourinhã", "Lousã", "Lousada", "Mação", "Macedo de Cavaleiros", "Machico", "Madalena", "Mafra", "Maia", "Mangualde", "Manteigas", "Marco de Canaveses", "Marinha Grande", "Marvão", "Matosinhos", "Mealhada", "Meda", "Melgaço", "Mesão Frio", "Mira", "Miranda do Corvo", "Miranda do Douro", "Mirandela", "Mogadouro", "Moimenta da Beira", "Moita", "Monção", "Monchique", "Mondim de Basto", "Monforte", "Montalegre", "Montemor-o-Novo", "Montemor-o-Velho", "Montijo", "Mora", "Mortágua", "Moura", "Mourão", "Murça", "Murtosa", "Mértola", "Nazaré", "Nelas", "Nisa", "Nordeste", "Óbidos", "Odemira", "Odivelas", "Oeiras", "Oleiros", "Olhão", "Oliveira de Azeméis", "Oliveira de Frades", "Oliveira do Bairro", "Oliveira do Hospital", "Ourique", "Ourém", "Ovar", "Paços de Ferreira", "Palmela", "Pampilhosa da Serra", "Paredes", "Paredes de Coura", "Pedrógão Grande", "Penacova", "Penafiel", "Penalva do Castelo", "Penamacor", "Penedono", "Penela", "Peniche", "Peso da Régua", "Pinhel", "Pombal", "Ponta Delgada", "Ponta do Sol", "Ponte da Barca", "Ponte de Lima", "Ponte de Sor", "Portalegre", "Portel", "Portimão", "Porto", "Porto Moniz", "Porto Santo", "Porto de Mós", "Povoação", "Praia da Vitória", "Proença-a-Nova", "Póvoa de Varzim", "Redondo", "Reguengos de Monsaraz", "Resende", "Ribeira Brava", "Ribeira Grande", "Ribeira de Pena", "Rio Maior", "Sabrosa", "Sabugal", "Salvaterra de Magos", "Santa Comba Dão", "Santa Cruz", "Santa Cruz da Graciosa", "Santa Cruz das Flores", "Santa Maria da Feira", "Santa Marta de Penaguião", "Santana", "Santarém", "Santiago do Cacém", "Santo Tirso", "São Brás de Alportel", "São João da Madeira", "São João da Pesqueira", "São Pedro do Sul", "São Roque do Pico", "São Vicente", "Sardoal", "Sátão", "Seia", "Seixal", "Sernancelhe", "Serpa", "Sertã", "Sesimbra", "Setúbal", "Sever do Vouga", "Silves", "Sines", "Sintra", "Sobral de Monte Agraço", "Soure", "Sousel", "Tábua", "Tabuaço", "Tarouca", "Tavira", "Tomar", "Tondela", "Torre de Moncorvo", "Torres Novas", "Torres Vedras", "Trancoso", "Trofa", "Vagos", "Vale de Cambra", "Valença", "Valongo", "Valpaços", "Velas", "Vendas Novas", "Viana do Alentejo", "Viana do Castelo", "Vidigueira", "Vila Flor", "Vila Franca de Xira", "Vila Franca do Campo", "Vila Nova da Barquinha", "Vila Nova de Cerveira", "Vila Nova de Foz Côa", "Vila Nova de Gaia", "Vila Nova de Paiva", "Vila Nova de Poiares", "Vila Pouca de Aguiar", "Vila Real", "Vila Real de Santo António", "Vila Velha de Ródão", "Vila Viçosa", "Vila de Rei", "Vila do Bispo", "Vila do Conde", "Vila do Porto", "Vimioso", "Vinhais", "Viseu", "Vouzela"})
        Me.cmbConcelho.Location = New System.Drawing.Point(18, 27)
        Me.cmbConcelho.MaxDropDownItems = 15
        Me.cmbConcelho.Name = "cmbConcelho"
        Me.cmbConcelho.Size = New System.Drawing.Size(165, 21)
        Me.cmbConcelho.TabIndex = 12
        Me.cmbConcelho.Text = "Selecione aqui um Concelho"
        '
        'pnVazio
        '
        Me.pnVazio.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnVazio.Controls.Add(Me.Label11)
        Me.pnVazio.Controls.Add(Me.Label10)
        Me.pnVazio.Location = New System.Drawing.Point(355, 173)
        Me.pnVazio.Name = "pnVazio"
        Me.pnVazio.Size = New System.Drawing.Size(203, 58)
        Me.pnVazio.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Tem um Desconto Especial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Barrancos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.chkAgrav12)
        Me.Panel2.Controls.Add(Me.chkEscalao10)
        Me.Panel2.Controls.Add(Me.chkSocio5)
        Me.Panel2.Location = New System.Drawing.Point(355, 255)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 122)
        Me.Panel2.TabIndex = 14
        '
        'chkAgrav12
        '
        Me.chkAgrav12.AutoSize = True
        Me.chkAgrav12.Location = New System.Drawing.Point(18, 89)
        Me.chkAgrav12.Name = "chkAgrav12"
        Me.chkAgrav12.Size = New System.Drawing.Size(160, 17)
        Me.chkAgrav12.TabIndex = 14
        Me.chkAgrav12.Text = "Multa - Fora do Prazo -> 12€"
        Me.chkAgrav12.UseVisualStyleBackColor = True
        '
        'chkEscalao10
        '
        Me.chkEscalao10.AutoSize = True
        Me.chkEscalao10.Location = New System.Drawing.Point(18, 14)
        Me.chkEscalao10.Name = "chkEscalao10"
        Me.chkEscalao10.Size = New System.Drawing.Size(163, 17)
        Me.chkEscalao10.TabIndex = 12
        Me.chkEscalao10.Text = "Desconto de Escalão -> 10%"
        Me.chkEscalao10.UseVisualStyleBackColor = True
        '
        'chkSocio5
        '
        Me.chkSocio5.AutoSize = True
        Me.chkSocio5.Location = New System.Drawing.Point(18, 52)
        Me.chkSocio5.Name = "chkSocio5"
        Me.chkSocio5.Size = New System.Drawing.Size(160, 17)
        Me.chkSocio5.TabIndex = 13
        Me.chkSocio5.Text = "Desconto para Socios -> 5%"
        Me.chkSocio5.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(24, 53)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(154, 35)
        Me.TxtTotal.TabIndex = 16
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(99, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "CALCULAR A AVENÇA"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(22, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(309, 131)
        Me.Panel4.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.TxtTotal)
        Me.Panel5.Location = New System.Drawing.Point(355, 400)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(203, 108)
        Me.Panel5.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "TOTAL A PAGAR"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.Controls.Add(Me.txtNome)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(22, 255)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(309, 53)
        Me.Panel6.TabIndex = 18
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.numValorBase)
        Me.Panel7.Location = New System.Drawing.Point(22, 330)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(309, 47)
        Me.Panel7.TabIndex = 19
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.cmbAnoNasc)
        Me.Panel8.Location = New System.Drawing.Point(22, 400)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(309, 50)
        Me.Panel8.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(70, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(417, 29)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "CÁLCULO DO VALOR DA AVENÇA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(22, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 54)
        Me.Panel3.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 38)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "SAIR DA APLICAÇÃO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(582, 530)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pnResidencia)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnVazio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblAviso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Avença Software - 2021"
        CType(Me.numValorBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnResidencia.ResumeLayout(False)
        Me.pnResidencia.PerformLayout()
        Me.pnVazio.ResumeLayout(False)
        Me.pnVazio.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAnoNasc As ComboBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents numValorBase As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNao As RadioButton
    Friend WithEvents rbSim As RadioButton
    Friend WithEvents lblAviso As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnResidencia As Panel
    Friend WithEvents cmbConcelho As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label



    Private Sub rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles rbSim.CheckedChanged
        If True Then
            pnResidencia.Visible = False
        End If

        OnChanged()
    End Sub



    Private Sub rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles rbNao.CheckedChanged
        If True Then
            pnResidencia.Visible = True
        End If
    End Sub

    Friend WithEvents chkAgrav12 As CheckBox
    Friend WithEvents chkSocio5 As CheckBox
    Friend WithEvents chkEscalao10 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnVazio As Panel
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'If cmbAnoNasc.Text = "Selecione aqui" Then
        '    MessageBox.Show("Por favor, Selecione o Ano de Nascimento")

        '    cmbAnoNasc.Text = 1900

        'End If



        ''Adquirir o valor digitado no NumericUpDown
        'Dim valorBase = Convert.ToInt16(numValorBase.Text)

        ''Acumulado
        'Dim acumulado = valorBase

        ''Converter o valor do ano para um numero inteiro
        'Dim ano = Convert.ToInt16(cmbAnoNasc.Text)

        ''Desconto de 10%
        'Dim descontoNascimento As Double = valorBase * 0.1

        ''Desconto do valor base
        'Dim descontoEscalao As Double = valorBase * 0.1

        ''Desconto de 5%
        'Dim descontoSocio As Double = valorBase * 0.05

        ''Desconto do Distrito 1%
        'Dim descontoDistrito As Double = valorBase * 0.01

        ''Desconto do Concelho de Barrancos
        'Dim descontoConcelho As Double = valorBase * 0.2



        ''---------------------------------------------------------
        'If chkEscalao10.Checked Then
        '    acumulado = valorBase - descontoEscalao
        'End If
        ''---------------------------------------------------------
        'If chkSocio5.Checked Then
        '    acumulado = acumulado - descontoSocio
        'End If
        ''---------------------------------------------------------
        'If chkAgrav12.Checked Then
        '    acumulado = acumulado + 12
        'End If
        ''---------------------------------------------------------
        'If rbSim.Checked Then
        '    acumulado = acumulado - descontoDistrito
        'End If
        ''---------------------------------------------------------
        'If cmbConcelho.Text = "Barrancos" Then
        '    acumulado = acumulado - descontoConcelho
        'End If

        ''Se o ano for 2000 ou superior
        'If ano > 2000 Then
        '    acumulado = acumulado - descontoNascimento
        'End If

        'TxtTotal.Text = Convert.ToString(acumulado) + ".00€"

    End Sub

    Friend WithEvents TxtTotal As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button2.Visible = False

        Button1.Visible = False



    End Sub



    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel

    Private Sub txtNome_TextChanged(sender As Object, e As EventArgs) Handles txtNome.TextChanged
        If txtNome.Text <> "" Then
            ' Button1.Visible = True
            lblAviso.Text = ""
            Button2.Visible = True
        Else
            ' Button1.Visible = False
            lblAviso.Text = "POR FAVOR DIGITE O NOME"
            Button2.Visible = False
        End If

    End Sub

    Private Sub chkEscalao10_CheckedChanged(sender As Object, e As EventArgs) Handles chkEscalao10.CheckedChanged

        OnChanged()

    End Sub


    Private Sub OnChanged()

        ''''''''''''''''   Lembrar para escolher o Ano de Nascimento   '''''''''''''''''
        'If cmbAnoNasc.Text = "Selecione aqui" Then
        '    MessageBox.Show("Por favor, Selecione o Ano de Nascimento")

        '    cmbAnoNasc.Text = 1900

        'End If

        cmbAnoNasc.Text = 1900

        'Adquirir o valor digitado no NumericUpDown
        Dim valorBase = Convert.ToInt16(numValorBase.Text)

        'Acumulado
        Dim acumulado = valorBase

        'Converter o valor do ano para um numero inteiro
        Dim ano = Convert.ToInt16(cmbAnoNasc.Text)

        'Desconto de 10%
        Dim descontoNascimento As Double = valorBase * 0.1

        'Desconto do valor base
        Dim descontoEscalao As Double = valorBase * 0.1

        'Desconto de 5%
        Dim descontoSocio As Double = valorBase * 0.05

        'Desconto do Distrito 1%
        Dim descontoDistrito As Double = valorBase * 0.01

        'Desconto do Concelho de Barrancos
        Dim descontoConcelho As Double = valorBase * 0.2



        '---------------------------------------------------------
        If chkEscalao10.Checked Then
            acumulado = valorBase - descontoEscalao
        End If
        '---------------------------------------------------------
        If chkSocio5.Checked Then
            acumulado = acumulado - descontoSocio
        End If
        '---------------------------------------------------------
        If chkAgrav12.Checked Then
            acumulado = acumulado + 12
        End If
        '---------------------------------------------------------
        If rbSim.Checked Then
            acumulado = acumulado - descontoDistrito
        End If
        '---------------------------------------------------------
        If cmbConcelho.Text = "Barrancos" Then
            acumulado = acumulado - descontoConcelho
        End If

        'Se o ano for 2000 ou superior
        If ano > 2000 Then
            acumulado = acumulado - descontoNascimento
        End If

        TxtTotal.Text = Convert.ToString(acumulado) + ".00€"

    End Sub

    Private Sub cmbAnoNasc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnoNasc.SelectedIndexChanged
        OnChanged()
    End Sub

    Private Sub chkSocio5_CheckedChanged(sender As Object, e As EventArgs) Handles chkSocio5.CheckedChanged
        OnChanged()
    End Sub

    Private Sub chkAgrav12_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgrav12.CheckedChanged
        OnChanged()
    End Sub

    Private Sub cmbConcelho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConcelho.SelectedIndexChanged
        OnChanged()
    End Sub

    Private Sub numValorBase_ValueChanged(sender As Object, e As EventArgs) Handles numValorBase.ValueChanged
        OnChanged()
    End Sub

    Friend WithEvents Button2 As Button

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class

'Private Sub BuscarDados()
'    Dim Con As SqlConnection = New SqlConnection(SC)
'    Con.Open()

'    Dim cmd As SqlCommand = New SqlCommand(ssql, Con)

'    Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)

'    Dim dt As New DataTable()
'    adapter.Fill(dt)

'    adapter.Dispose()
'    Con.Close()

'    Return dt
'End Sub