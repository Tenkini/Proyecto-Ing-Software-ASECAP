namespace Proyecto_IngSoftware_Grupo_3
{
    internal class ResizeService
    {
        internal void ResizeControl(Control control, Rectangle originalControlRect, Form form, Rectangle originalFormRect)
        {
            float xRatio = (float)form.ClientRectangle.Width / (float)originalFormRect.Width;
            float yRatio = (float)form.ClientRectangle.Height / (float)originalFormRect.Height;

            float newX = originalControlRect.Location.X * xRatio;
            float newY = originalControlRect.Location.Y * yRatio;

            control.Location = new Point((int)newX, (int)newY);
            control.Width = (int)(originalControlRect.Width * xRatio);
            control.Height = (int)(originalControlRect.Height * yRatio);
        }
    }
}