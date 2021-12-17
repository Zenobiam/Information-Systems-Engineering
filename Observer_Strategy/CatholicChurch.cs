using Laba._19._11.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba._19._11
{
    public class CatholicChurch : IChurch  // Observable
    {
        private List<Parishioner> parishioners;
        private List<Normal> normals;
        private string newsChurch;

        public CatholicChurch()
        {
            parishioners = new List<Parishioner>();
            normals = new List<Normal>();
        }

        public void setNewsChurch(string news) // уведомление подписчиков о новостях
        {
            this.newsChurch = news;
            notifyParishioners();
            notifyNormal();
        }

        #region Regular Parshioners
        public void registerParishioner(Parishioner parishioner) // Регистрация подписчика
        {
            parishioners.Add(parishioner);
        }

        public void removeParishioner(Parishioner parishioner)
        {
            parishioners.Remove(parishioner);
        }

        public void notifyParishioners()
        {
            foreach (Parishioner person in parishioners)
            {
                person.Reaction(newsChurch);
            }
        }
        #endregion



        #region Normals 
        public void registerNormal(Normal parishioner)
        {
            normals.Add(parishioner);
        }

        public void removeNormal(Normal parishioner)
        {
            normals.Remove(parishioner);
        }

        public void notifyNormal()
        {
            foreach (Normal person in normals)
            {
                person.Reaction(newsChurch);
            }
        }
        #endregion
    }
}