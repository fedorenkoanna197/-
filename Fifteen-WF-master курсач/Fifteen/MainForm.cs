using System;
using System.Windows.Forms;

namespace Fifteen
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		int [,] arr = new int [4,4];
		int bord = 10;
		int otst = 0;
		int time = 0;
			
		void NewGame() //создаём новую игру 
		{
			Random r = new Random(); 
			bool flag = false;
			int tmp;
			tmp = r.Next(16);
			for (int i=0;i<=3;i++){                           //создаем матрицу размером 4х4 в которую случайным порядком записываем числа от 1 до 15
				for (int j=0;j<=3;j++){
					if ((i != 0) || (j != 0)){
						do {
							flag = false;
							tmp = r.Next(16);
							for (int k=0;k<=i;k++){
								if (k<i){
									for (int l=0;l<=3;l++){
										if (arr [k,l] == tmp) {flag = true;}
									}
								} else {
									for (int l=0;l<j;l++){
										if (arr [k,l] == tmp) {flag = true;}
									}
								}
							}
						}
						while (flag == true);
					}
					arr [i,j] = tmp;
				}
			}
			Raskl();
		}
		
		void Raskl(){            //строим кнопки
			for (int i=0;i<=3;i++){
				for (int j=0;j<=3;j++){
					foreach (Control ctrl in this.Controls){
						if (ctrl.Name == "button"+arr [i,j].ToString()){
							if (i == 0 && j > 0){ctrl.Location = new System.Drawing.Point(bord+j*ctrl.Size.Width+j*otst,bord+i*ctrl.Size.Height);}
							if (j == 0 && i > 0){ctrl.Location = new System.Drawing.Point(bord+j*ctrl.Size.Width,bord+i*ctrl.Size.Height+i*otst);}
							if (j > 0 && i > 0){ctrl.Location = new System.Drawing.Point(bord+j*ctrl.Size.Width+j*otst,bord+i*ctrl.Size.Height+i*otst);}
							if (j == 0 && i == 0) {ctrl.Location = new System.Drawing.Point(bord+j*ctrl.Size.Width,bord+i*ctrl.Size.Height);}
						}
					}
				}
			}
		}
		
		void UserClick(int key)
		{
			int arrx = 0;
			int arry = 0;
			int ar0x = 0;
			int ar0y = 0;
			
			for (int i=0;i<=3;i++){
				for (int j=0;j<=3;j++){
					if (arr[i,j] == key){   // записываем позицию кнопки на которую нажал игрок
						arrx = i;
						arry = j;
						break;
					}
				}
			}
			for (int i=0;i<=3;i++){    // записываем позицию пустой кнопки
				for (int j=0;j<=3;j++){
					if (arr[i,j] == 0){
						ar0x = i;
						ar0y = j;
						break;
					}
				}
			}
			if (arrx == ar0x){    //двигаем пустую кнопку влево
				if (ar0y > arry){
					for (int i=ar0y;i>arry;i--){   
						arr[arrx,i] = arr[arrx,i-1];
					}
				}
				if (ar0y < arry){           //двигаем пустую кнопку вправо
					for (int i=ar0y;i<arry;i++){
						arr[arrx,i] = arr[arrx,i+1];
					}
				}
				arr[arrx,arry] = 0;
			}
			if (arry == ar0y){
				if (ar0x > arrx){
					for (int i=ar0x;i>arrx;i--){    //двигаем пустую кнопку вверх
						arr[i,arry] = arr[i-1,arry];
					}
				}
				if (ar0x < arrx){                //двигаем пустую кнопку вниз
					for (int i=ar0x;i<arrx;i++){
						arr[i,arry] = arr[i+1,arry];
					}
				}
				arr[arrx,arry] = 0;
			}
			if (!timer1.Enabled){    
				timer1.Start();
			}
			Raskl();
			if (Prov()){            
				timer1.Stop();
				MessageBox.Show("Время: "+time.ToString()+" сек.");    // в случае победы выводим время за которое игрок прошёл
				time = 0;
				this.Text = "15";
				NewGame();
			}
		}
		
		bool Prov(){        //проверка условия победы
			int pr = 1;
			bool ver = true;
			for (int i=0;i<=3;i++){
				for (int j=0;j<=3;j++){
					if (((arr[i,j] != pr) && (pr < 14)) || (arr[3,3] != 0)) ver = false;
					pr++;
				}
			}
			return ver;
		}
			
		void MainFormLoad(object sender, EventArgs e)
		{
			NewGame();
		}
		
		void Timer1Tick(object sender, EventArgs e)  //таймер решения задачи
		{
			time++;
			this.Text = time.ToString();
		}
		
		void ButtonMouseDown(object sender, MouseEventArgs e)
		{
			UserClick(Convert.ToInt32(((Button)sender).Text));
			label1.Focus();
		}

		void ButtonEnter(object sender, EventArgs e)
		{
			label1.Focus();
		}
	}
}
