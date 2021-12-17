using Laba._19._11.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba._19._11
{
    public interface IChurch
    {
        #region Regular Parshioners
        void registerParishioner(Parishioner parishioner);
        void removeParishioner(Parishioner parishioner);
        void notifyParishioners();
        #endregion

        #region Normals 
        void registerNormal(Normal parishioner);
        void removeNormal(Normal parishioner);
        void notifyNormal();
        #endregion
    }
}
