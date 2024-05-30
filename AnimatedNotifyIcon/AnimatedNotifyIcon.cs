using System.ComponentModel;

namespace AnimatedNotifyIcon
{
    [ToolboxBitmap(@"C:\Users\Веніамін Ревін\source\repos\Lab1.net\AnimatedNotifyIcon\AnimatedNotifyIcon.ico")]
    public partial class AnimatedNotifyIcon : UserControl
    {
        private int currentFrame;
        private Icon[] icons;
        public AnimatedNotifyIcon()
        {
            InitializeComponent();
            // Ініціалізація масиву іконок з директорії
            string iconDirectory = $"{Directory.GetCurrentDirectory()}\\MyNotifyIcon";
            LoadIconsFromDirectory(iconDirectory);

            if (icons.Length > 0)
            {
                notifyIcon1.Icon = icons[0];
                notifyIcon1.Visible = true;

                timer1.Interval = 500; // Інтервал у мілісекундах
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("No icons found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadIconsFromDirectory(string directory)
        {
            try
            {
                // Отримати всі файли з розширенням .ico з директорії
                string[] iconFiles = Directory.GetFiles(directory, "*.ico");
                icons = new Icon[iconFiles.Length];

                // Завантажити всі іконки
                for (int i = 0; i < iconFiles.Length; i++)
                {
                    icons[i] = new Icon(iconFiles[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load icons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                icons = new Icon[0];
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Зміна іконки
            currentFrame = (currentFrame + 1) % icons.Length;
            notifyIcon1.Icon = icons[currentFrame];
        }

        // Властивість для зміни тексту NotifyIcon
        [Category("Behavior"), Description("Текст, що відображається при наведенні на іконку в системному треї")]
        public string NotifyText
        {
            get => notifyIcon1.Text;
            set => notifyIcon1.Text = value;
        }

        // Властивість для доступу до контекстного меню
        [Category("Behavior"), Description("Контекстне меню для іконки в системному треї")]
        public ContextMenuStrip NotifyContextMenu
        {
            get => notifyIcon1.ContextMenuStrip;
            set => notifyIcon1.ContextMenuStrip = value;
        }
    }
}