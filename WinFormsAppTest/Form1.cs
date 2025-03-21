using System.Windows.Forms;

namespace WinFormsAppTest
{
    public partial class Pictures : Form
    {
        public Pictures()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string photosFolder = folderBrowserDialog.SelectedPath;
                LoadPhotosFromFolder(photosFolder);
            }
        }
        private void LoadPhotosFromFolder(string folder)
        {
            Images.Items.Clear();
            File.WriteAllText(@"..\..\..\FileNames.txt", folder);

            string[] allFiles = Directory.GetFiles(folder, "*.*");

            foreach (string file in allFiles)
            {
                string extension = Path.GetExtension(file).ToLower();
                if (extension == ".jpg" || extension == ".png")
                {
                    Images.Items.Add(Path.GetFileName(file));
                }
            }

            if (Images.Items.Count == 0)
            {
                MessageBox.Show("� ����� ��� ������ � ������������ .jpg ��� .png.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadPhotosFromFile(string filePath)
        {
            Images.Items.Clear();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length >= 1)
                    {
                        string imagePath = parts[0].Trim(); 
                        string title = parts.Length > 1 ? parts[1].Trim() : ""; 

                        if (File.Exists(imagePath))
                        {
                            Images.Items.Add($"{Path.GetFileName(imagePath)} - {title}");
                        }
                        else
                        {
                            MessageBox.Show($"���� �� ������: {imagePath}", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                if (Images.Items.Count == 0)
                {
                    MessageBox.Show("� ����� ��� ���������� ����� � ������������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ �����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Images.SelectedIndex != -1)
            {
                string selectedFilePath = Path.Combine(File.ReadAllText(@"..\..\..\FileNames.txt"), Images.SelectedItem.ToString());

                try
                {
                    Image image = Image.FromFile(selectedFilePath);
                    pictureBox1.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� �����������: " + ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            saveFileDialog.Title = "��������� ������ �� ListBox";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var item in Images.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("������ ������� ���������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� �����: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";
            openFileDialog.Title = "�������� ���� � ������ � ������������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadPhotosFromFile(filePath);
            }
        }
    }
}