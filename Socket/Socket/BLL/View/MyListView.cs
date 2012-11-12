// -----------------------------------------------------------------------
// <copyright file="MyListView.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Socket.BLL.View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ComponentOwl.BetterListView;
    using System.Drawing;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>

    public class MyListView : BetterListView
    {
        protected override void OnDrawItemBackground(BetterListViewDrawItemBackgroundEventArgs eventArgs)
        {
            base.OnDrawItemBackground(eventArgs);

            if (eventArgs.Item.Selected)
            {
                Brush brushSelection = new SolidBrush(Color.FromArgb(128, Color.WhiteSmoke));
                eventArgs.Graphics.FillRectangle(brushSelection, eventArgs.ItemBounds.BoundsSelection);
                brushSelection.Dispose();
            }
        }

        protected override void OnDrawItem(BetterListViewDrawItemEventArgs eventArgs)
        {
            eventArgs.DrawSelection = false;

            base.OnDrawItem(eventArgs);

            if (eventArgs.Item.Selected)
            {
                eventArgs.Graphics.DrawRectangle(Pens.Black, eventArgs.ItemBounds.BoundsSelection);
            }
        }
    }
}
