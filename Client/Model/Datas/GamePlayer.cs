﻿using Client.Model.Cards;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Datas
{
   public class GamePlayer: NotificationObject
    {
        int _seatNum;
        public int SeatNum
        {
            get
            {
                return _seatNum;
            }

            set
            {
                _seatNum = value;
                RaisePropertyChanged("SeatNum");
            }
        }

        string _nick;
        public string Nick
        {
            get
            {
                return _nick;
            }

            set
            {
                _nick = value;
                RaisePropertyChanged("Nick");
            }
        }

        int _exp;
        public int Exp
        {
            get
            {
                return _exp;
            }

            set
            {
                _exp = value;
            }
        }

        int _money;
        public int Money
        {
            get
            {
                return _money;
            }

            set
            {
                _money = value;
                RaisePropertyChanged("Money");
            }
        }

        bool _isBishop;
        public bool IsBishop
        {
            get
            {
                return _isBishop;
            }

            set
            {
                _isBishop = value;
                RaisePropertyChanged("IsBishop");
            }
        }

        ObservableCollection<Building> _buildings;
        public ObservableCollection<Building> Buildings
        {
            get
            {
                return _buildings;
            }

            set
            {
                _buildings = value;
                RaisePropertyChanged("Buildings");
            }
        }

        ObservableCollection<Hero> _roles;
        public ObservableCollection<Hero> Roles
        {
            get
            {
                return _roles;
            }

            set
            {
                _roles = value;
                RaisePropertyChanged("Roles");
            }
        }

        int _score;
        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
                RaisePropertyChanged("Score");
            }
        }
        
        public GamePlayer(int seatNum,string nick,int exp,int money)
        {
            SeatNum = seatNum;
            Nick = nick;
            Exp = exp;
            Money = money;
            IsBishop = false;
            Score = 0;
            Buildings = new ObservableCollection<Building>();
            Roles = new ObservableCollection<Hero>();
        }
    }
}
