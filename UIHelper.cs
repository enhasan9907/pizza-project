using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class UIHelper
{
    public static void StyleOrangeRoundedButton(Button btn, int radius = 20)
    {
        // الألوان والتنسيق
        btn.BackColor = Color.FromArgb(230, 57, 70); // برتقالي
        btn.ForeColor = Color.White;
        btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;

        // رسم الحواف الدائرية
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        btn.Region = new Region(path);

        // إعادة رسم الحواف عند تغيير الحجم
        btn.Resize += (s, e) =>
        {
            GraphicsPath newPath = new GraphicsPath();
            newPath.AddArc(0, 0, radius, radius, 180, 90);
            newPath.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            newPath.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            newPath.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            newPath.CloseFigure();
            btn.Region = new Region(newPath);
        };
    }
}
