namespace SSP2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rock = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.MiddleText = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.Label();
            this.labelStavka = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Stavka = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.PlayerPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerSumPointsRound1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayerSumPointsRound2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayerSumPointsRound3 = new System.Windows.Forms.Label();
            this.OpponentSumPointsRound3 = new System.Windows.Forms.Label();
            this.OpponentSumPointsRound2 = new System.Windows.Forms.Label();
            this.OpponentSumPointsRound1 = new System.Windows.Forms.Label();
            this.OpponentPoints = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Rounds = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OpponentScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PlayerStavka = new System.Windows.Forms.Label();
            this.StavkaError = new System.Windows.Forms.TextBox();
            this.NextBut = new System.Windows.Forms.Button();
            this.labelOpponentStavka = new System.Windows.Forms.Label();
            this.StavkaOpponenta = new System.Windows.Forms.Label();
            this.StavkaPlayer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Enabled = false;
            this.Rock.Image = ((System.Drawing.Image)(resources.GetObject("Rock.Image")));
            this.Rock.Location = new System.Drawing.Point(247, 468);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(208, 189);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Scissors
            // 
            this.Scissors.Enabled = false;
            this.Scissors.Image = ((System.Drawing.Image)(resources.GetObject("Scissors.Image")));
            this.Scissors.Location = new System.Drawing.Point(528, 498);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(207, 129);
            this.Scissors.TabIndex = 1;
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.Enabled = false;
            this.Paper.Image = ((System.Drawing.Image)(resources.GetObject("Paper.Image")));
            this.Paper.Location = new System.Drawing.Point(813, 464);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(152, 196);
            this.Paper.TabIndex = 2;
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(813, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 196);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(528, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 129);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(247, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 189);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MiddleText
            // 
            this.MiddleText.AutoSize = true;
            this.MiddleText.BackColor = System.Drawing.Color.Transparent;
            this.MiddleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleText.Location = new System.Drawing.Point(612, 331);
            this.MiddleText.Name = "MiddleText";
            this.MiddleText.Size = new System.Drawing.Size(40, 25);
            this.MiddleText.TabIndex = 6;
            this.MiddleText.Text = "VS";
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.BackColor = System.Drawing.Color.Transparent;
            this.NickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NickName.Location = new System.Drawing.Point(614, 644);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(33, 17);
            this.NickName.TabIndex = 7;
            this.NickName.Text = "Ник";
            // 
            // labelStavka
            // 
            this.labelStavka.AutoSize = true;
            this.labelStavka.BackColor = System.Drawing.Color.Transparent;
            this.labelStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStavka.Location = new System.Drawing.Point(9, 468);
            this.labelStavka.Name = "labelStavka";
            this.labelStavka.Size = new System.Drawing.Size(110, 18);
            this.labelStavka.TabIndex = 8;
            this.labelStavka.Text = "Первая ставка";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 543);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 25);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сделать ставку";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Stavka
            // 
            this.Stavka.Location = new System.Drawing.Point(12, 489);
            this.Stavka.Name = "Stavka";
            this.Stavka.ReadOnly = true;
            this.Stavka.Size = new System.Drawing.Size(111, 20);
            this.Stavka.TabIndex = 10;
            this.Stavka.Text = "200";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label50.Location = new System.Drawing.Point(9, 609);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(86, 18);
            this.label50.TabIndex = 11;
            this.label50.Text = "Ваши очки:";
            // 
            // PlayerPoints
            // 
            this.PlayerPoints.AutoSize = true;
            this.PlayerPoints.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayerPoints.Location = new System.Drawing.Point(9, 627);
            this.PlayerPoints.Name = "PlayerPoints";
            this.PlayerPoints.Size = new System.Drawing.Size(40, 18);
            this.PlayerPoints.TabIndex = 12;
            this.PlayerPoints.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(983, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Сумма очков за 1 раунд:";
            // 
            // PlayerSumPointsRound1
            // 
            this.PlayerSumPointsRound1.AutoSize = true;
            this.PlayerSumPointsRound1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSumPointsRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerSumPointsRound1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayerSumPointsRound1.Location = new System.Drawing.Point(983, 487);
            this.PlayerSumPointsRound1.Name = "PlayerSumPointsRound1";
            this.PlayerSumPointsRound1.Size = new System.Drawing.Size(18, 20);
            this.PlayerSumPointsRound1.TabIndex = 14;
            this.PlayerSumPointsRound1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(983, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сумма очков за 2 раунда:";
            // 
            // PlayerSumPointsRound2
            // 
            this.PlayerSumPointsRound2.AutoSize = true;
            this.PlayerSumPointsRound2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSumPointsRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerSumPointsRound2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayerSumPointsRound2.Location = new System.Drawing.Point(983, 529);
            this.PlayerSumPointsRound2.Name = "PlayerSumPointsRound2";
            this.PlayerSumPointsRound2.Size = new System.Drawing.Size(18, 20);
            this.PlayerSumPointsRound2.TabIndex = 16;
            this.PlayerSumPointsRound2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(983, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Сумма очков за 3 раунда:";
            // 
            // PlayerSumPointsRound3
            // 
            this.PlayerSumPointsRound3.AutoSize = true;
            this.PlayerSumPointsRound3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSumPointsRound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerSumPointsRound3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayerSumPointsRound3.Location = new System.Drawing.Point(983, 571);
            this.PlayerSumPointsRound3.Name = "PlayerSumPointsRound3";
            this.PlayerSumPointsRound3.Size = new System.Drawing.Size(18, 20);
            this.PlayerSumPointsRound3.TabIndex = 18;
            this.PlayerSumPointsRound3.Text = "0";
            // 
            // OpponentSumPointsRound3
            // 
            this.OpponentSumPointsRound3.AutoSize = true;
            this.OpponentSumPointsRound3.BackColor = System.Drawing.Color.Transparent;
            this.OpponentSumPointsRound3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpponentSumPointsRound3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpponentSumPointsRound3.Location = new System.Drawing.Point(983, 121);
            this.OpponentSumPointsRound3.Name = "OpponentSumPointsRound3";
            this.OpponentSumPointsRound3.Size = new System.Drawing.Size(18, 20);
            this.OpponentSumPointsRound3.TabIndex = 24;
            this.OpponentSumPointsRound3.Text = "0";
            // 
            // OpponentSumPointsRound2
            // 
            this.OpponentSumPointsRound2.AutoSize = true;
            this.OpponentSumPointsRound2.BackColor = System.Drawing.Color.Transparent;
            this.OpponentSumPointsRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpponentSumPointsRound2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpponentSumPointsRound2.Location = new System.Drawing.Point(983, 79);
            this.OpponentSumPointsRound2.Name = "OpponentSumPointsRound2";
            this.OpponentSumPointsRound2.Size = new System.Drawing.Size(18, 20);
            this.OpponentSumPointsRound2.TabIndex = 22;
            this.OpponentSumPointsRound2.Text = "0";
            // 
            // OpponentSumPointsRound1
            // 
            this.OpponentSumPointsRound1.AutoSize = true;
            this.OpponentSumPointsRound1.BackColor = System.Drawing.Color.Transparent;
            this.OpponentSumPointsRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpponentSumPointsRound1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpponentSumPointsRound1.Location = new System.Drawing.Point(983, 37);
            this.OpponentSumPointsRound1.Name = "OpponentSumPointsRound1";
            this.OpponentSumPointsRound1.Size = new System.Drawing.Size(18, 20);
            this.OpponentSumPointsRound1.TabIndex = 20;
            this.OpponentSumPointsRound1.Text = "0";
            // 
            // OpponentPoints
            // 
            this.OpponentPoints.AutoSize = true;
            this.OpponentPoints.BackColor = System.Drawing.Color.Transparent;
            this.OpponentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpponentPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpponentPoints.Location = new System.Drawing.Point(9, 175);
            this.OpponentPoints.Name = "OpponentPoints";
            this.OpponentPoints.Size = new System.Drawing.Size(40, 18);
            this.OpponentPoints.TabIndex = 26;
            this.OpponentPoints.Text = "1000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(9, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Очки противника:";
            // 
            // Rounds
            // 
            this.Rounds.AutoSize = true;
            this.Rounds.BackColor = System.Drawing.Color.Transparent;
            this.Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rounds.Location = new System.Drawing.Point(13, 331);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(68, 20);
            this.Rounds.TabIndex = 27;
            this.Rounds.Text = "Раунд 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(112, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 28;
            this.label14.Text = "Счет";
            // 
            // OpponentScore
            // 
            this.OpponentScore.AutoSize = true;
            this.OpponentScore.BackColor = System.Drawing.Color.Transparent;
            this.OpponentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpponentScore.Location = new System.Drawing.Point(123, 290);
            this.OpponentScore.Name = "OpponentScore";
            this.OpponentScore.Size = new System.Drawing.Size(20, 22);
            this.OpponentScore.TabIndex = 29;
            this.OpponentScore.Text = "0";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerScore.Location = new System.Drawing.Point(123, 374);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(20, 22);
            this.PlayerScore.TabIndex = 30;
            this.PlayerScore.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(983, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Сумма очков за 3 раунда:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(983, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Сумма очков за 2 раунда:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(983, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Сумма очков за 1 раунд:";
            // 
            // PlayerStavka
            // 
            this.PlayerStavka.AutoSize = true;
            this.PlayerStavka.BackColor = System.Drawing.Color.Transparent;
            this.PlayerStavka.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PlayerStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerStavka.Location = new System.Drawing.Point(9, 571);
            this.PlayerStavka.Name = "PlayerStavka";
            this.PlayerStavka.Size = new System.Drawing.Size(100, 18);
            this.PlayerStavka.TabIndex = 34;
            this.PlayerStavka.Text = "Ваша ставка:";
            // 
            // StavkaError
            // 
            this.StavkaError.Location = new System.Drawing.Point(130, 489);
            this.StavkaError.Multiline = true;
            this.StavkaError.Name = "StavkaError";
            this.StavkaError.ReadOnly = true;
            this.StavkaError.Size = new System.Drawing.Size(100, 168);
            this.StavkaError.TabIndex = 36;
            // 
            // NextBut
            // 
            this.NextBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBut.Location = new System.Drawing.Point(318, 322);
            this.NextBut.Name = "NextBut";
            this.NextBut.Size = new System.Drawing.Size(198, 40);
            this.NextBut.TabIndex = 37;
            this.NextBut.Text = "Следующая разыгровка";
            this.NextBut.UseVisualStyleBackColor = true;
            this.NextBut.Visible = false;
            this.NextBut.Click += new System.EventHandler(this.NextBut_Click);
            // 
            // labelOpponentStavka
            // 
            this.labelOpponentStavka.AutoSize = true;
            this.labelOpponentStavka.BackColor = System.Drawing.Color.Transparent;
            this.labelOpponentStavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpponentStavka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOpponentStavka.Location = new System.Drawing.Point(9, 123);
            this.labelOpponentStavka.Name = "labelOpponentStavka";
            this.labelOpponentStavka.Size = new System.Drawing.Size(146, 18);
            this.labelOpponentStavka.TabIndex = 38;
            this.labelOpponentStavka.Text = "Ставка противника:";
            // 
            // StavkaOpponenta
            // 
            this.StavkaOpponenta.AutoSize = true;
            this.StavkaOpponenta.BackColor = System.Drawing.Color.Transparent;
            this.StavkaOpponenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StavkaOpponenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StavkaOpponenta.Location = new System.Drawing.Point(161, 123);
            this.StavkaOpponenta.Name = "StavkaOpponenta";
            this.StavkaOpponenta.Size = new System.Drawing.Size(16, 18);
            this.StavkaOpponenta.TabIndex = 39;
            this.StavkaOpponenta.Text = "0";
            // 
            // StavkaPlayer
            // 
            this.StavkaPlayer.AutoSize = true;
            this.StavkaPlayer.BackColor = System.Drawing.Color.Transparent;
            this.StavkaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StavkaPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StavkaPlayer.Location = new System.Drawing.Point(14, 589);
            this.StavkaPlayer.Name = "StavkaPlayer";
            this.StavkaPlayer.Size = new System.Drawing.Size(16, 18);
            this.StavkaPlayer.TabIndex = 40;
            this.StavkaPlayer.Text = "0";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(73, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "max";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StavkaPlayer);
            this.Controls.Add(this.StavkaOpponenta);
            this.Controls.Add(this.labelOpponentStavka);
            this.Controls.Add(this.NextBut);
            this.Controls.Add(this.StavkaError);
            this.Controls.Add(this.PlayerStavka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.OpponentScore);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Rounds);
            this.Controls.Add(this.OpponentPoints);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.OpponentSumPointsRound3);
            this.Controls.Add(this.OpponentSumPointsRound2);
            this.Controls.Add(this.OpponentSumPointsRound1);
            this.Controls.Add(this.PlayerSumPointsRound3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PlayerSumPointsRound2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlayerSumPointsRound1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerPoints);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.Stavka);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.labelStavka);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.MiddleText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "Камень, Ножницы, Бумага";
            this.Activated += new System.EventHandler(this.Form1_Enter);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label MiddleText;
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label labelStavka;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Stavka;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label PlayerPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PlayerSumPointsRound1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PlayerSumPointsRound2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PlayerSumPointsRound3;
        private System.Windows.Forms.Label OpponentSumPointsRound3;
        private System.Windows.Forms.Label OpponentSumPointsRound2;
        private System.Windows.Forms.Label OpponentSumPointsRound1;
        private System.Windows.Forms.Label OpponentPoints;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Rounds;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label OpponentScore;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PlayerStavka;
        private System.Windows.Forms.TextBox StavkaError;
        private System.Windows.Forms.Button NextBut;
        private System.Windows.Forms.Label labelOpponentStavka;
        private System.Windows.Forms.Label StavkaOpponenta;
        private System.Windows.Forms.Label StavkaPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

