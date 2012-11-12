// -----------------------------------------------------------------------
// <copyright file="ITableCRUD.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.ITableCRUD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface ITableCRUD<Type>
    {
        void TablCreate(List<Type> obj);

        List<Type> TablRead();

        void TablUpdate();

        void TablDelete();
    }
}
