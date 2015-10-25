﻿using Client.Model.Cards;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client.View
{
    /// <summary>
    /// GameV.xaml 的交互逻辑
    /// </summary>
    public partial class GameV : Window
    {
        GameVM gameVM;
        public GameV(int num, int seatNum)
        {
            gameVM = new GameVM(num, seatNum);
            gameVM.GamePlayerList[seatNum - 1].Exp = 1;
            DataContext = gameVM;
            InitializeComponent();
        }
        #region 测试
        public GameV()
        {
            int num = 3;
            int sNum = 2;
            gameVM = new GameVM(num, sNum);
            InitializeComponent();
            DataContext = gameVM;
            myCitadel.DataContext = gameVM.GamePlayerList[sNum - 1];
            switch (num)
            {
                case 2:
                    upCitadel.DataContext = gameVM.GamePlayerList[2 - sNum];
                    break;
                case 3:
                    leftCitadel.DataContext = gameVM.GamePlayerList[sNum % 3];
                    rightCitadel.DataContext = gameVM.GamePlayerList[(sNum + 1) % 3];
                    break;
                case 4:
                    leftCitadel.DataContext = gameVM.GamePlayerList[sNum % 4];
                    upCitadel.DataContext = gameVM.GamePlayerList[(sNum + 1) % 4];
                    rightCitadel.DataContext = gameVM.GamePlayerList[(sNum + 2) % 4];
                    break;
            }
        }
        #endregion
    }
}
