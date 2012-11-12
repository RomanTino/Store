// -----------------------------------------------------------------------
// <copyright file="ICRUD.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.ICRUD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Socket.ADO;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface ICRUD<Type>
    {
        void Create(Type obj);

        Type Read(string key);

        void Update(string key);

        void Delete(string key);
    }
}
