using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FileUpload
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RadUploadDropPanel1_DragEnter(object sender, DragEventArgs e)
        {
            Color backgroundColor = new Color();
            backgroundColor.R = 208;
            backgroundColor.G = 232;
            backgroundColor.B = 254;
            this.RadUploadDropPanel1.Background = new SolidColorBrush(backgroundColor);
        }
        private void RadUploadDropPanel_DragLeave(object sender, DragEventArgs e)
        {
            this.RadUploadDropPanel1.Background = new SolidColorBrush(Colors.White);
        }
       
        
       

    }
}
