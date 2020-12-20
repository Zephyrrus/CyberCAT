using CyberCAT.Core;
using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCAT.Forms
{
    
    public partial class Form1 : Form
    {
        SaveFileCompressionHelper activeSaveFile = new SaveFileCompressionHelper();
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Constants.FileStructure.OUTPUT_FOLDER_NAME))
            {
                Directory.CreateDirectory(Constants.FileStructure.OUTPUT_FOLDER_NAME);
            }

            openSaveFile.InitialDirectory = System.IO.Path.Combine(KnownFolderPathHelper.GetSavedGamesPath(), "CD Projekt Red\\Cyberpunk 2077");
            openSaveFile.FileName = "sav.dat";
            openSaveFile.Filter = "Cyberpunk save|sav.dat|All files (*.*)|*.*";
            openSaveFile.DefaultExt = ".dat";

            openDecompressedSaveFile.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Constants.FileStructure.OUTPUT_FOLDER_NAME);
            openDecompressedSaveFile.FileName = "";
            openDecompressedSaveFile.Filter = "Decompressed save|*.bin|All files (*.*)|*.*";
            openDecompressedSaveFile.DefaultExt = ".bin";

            openMetaInfo.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Constants.FileStructure.OUTPUT_FOLDER_NAME);
            openMetaInfo.FileName = "";
            openMetaInfo.Filter = "metainf|*.json|All files (*.*)|*.*";
            openMetaInfo.DefaultExt = ".json";
        }

        private void uncompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(decompressFilePathTextbox.Text))
            {
                using (var compressedInputStream = File.OpenRead(decompressFilePathTextbox.Text))
                {
                    activeSaveFile = new SaveFileCompressionHelper();
                    var decompressedFile = activeSaveFile.Decompress(compressedInputStream);
                    string json = JsonConvert.SerializeObject(activeSaveFile.MetaInformation, Formatting.Indented);
                    File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}", json);
                    File.WriteAllBytes($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.{Constants.FileExtensions.DECOMPRESSED_FILE}", decompressedFile);
                }
            }
            else
            {
                MessageBox.Show(Constants.Messages.MISSING_FILE_TEXT);
            }
        }
        private void recompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(recompressFilePathTextbox.Text))
            {
                if (File.Exists(metaInformationFilePathTextbox.Text))
                {
                    activeSaveFile.CompressFromSingleFile(recompressFilePathTextbox.Text,metaInformationFilePathTextbox.Text);
                }
                else
                {
                    MessageBox.Show(Constants.Messages.MISSING_METAINFO_FILE_TEXT);
                }
            }
        }

        private void decompressFilePathTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decompressFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                decompressFilePathTextbox.Text = files[0];
            }
        }

        private void decompressFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void recompressFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                recompressFilePathTextbox.Text = files[0];
                var splitted = Path.GetFileName(files[0]).Split('_');
                var metainfoFileNameGuess = $"{splitted[0]}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}";
                if (File.Exists($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{metainfoFileNameGuess}"))
                {
                    metaInformationFilePathTextbox.Text = Path.GetFullPath($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{metainfoFileNameGuess}");
                }
            }
        }

        private void recompressFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void metaInformationFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                metaInformationFilePathTextbox.Text = files[0];
            }
        }

        private void metaInformationFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void appearanceUncompressedSaveFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void appearanceUncompressedSaveFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                appearanceUncompressedSaveFilePathTextbox.Text = files[0];
            }
        }

        private void loadAppearanceSectionButton_Click(object sender, EventArgs e)
        {
            SaveFileParser parser = new SaveFileParser();
            var fileBytes = File.ReadAllBytes(appearanceUncompressedSaveFilePathTextbox.Text);
            using(var stream = new MemoryStream(fileBytes))
            {
                var results = parser.Parse(stream);
                int index = 0;
                foreach (var json in results)
                {
                    File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{Path.GetFileName(appearanceUncompressedSaveFilePathTextbox.Text)}json_{index}.json",json);
                    index++;
                }
            }
               

            
        }

        private void decompressFilePathTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (openSaveFile.ShowDialog() == DialogResult.OK)
            {
                decompressFilePathTextbox.Text = openSaveFile.FileName;
            }
        }

        private void recompressFilePathTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (openDecompressedSaveFile.ShowDialog() == DialogResult.OK)
            {
                recompressFilePathTextbox.Text = openDecompressedSaveFile.FileName;
                try
                {
                    var selectedPath = openDecompressedSaveFile.FileName;

                    var folderPath = Path.GetDirectoryName(selectedPath);
                    var fileName = Path.GetFileNameWithoutExtension(selectedPath);

                    var uuid = fileName.Split('_').First();

                    var potentialMetaFilePath = Path.Combine(folderPath, $"{uuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}");
                    if (File.Exists(potentialMetaFilePath))
                    {
                        metaInformationFilePathTextbox.Text = potentialMetaFilePath;
                    }
                } catch(Exception exp)
                {
                    MessageBox.Show(exp.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metaInformationFilePathTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (openMetaInfo.ShowDialog() == DialogResult.OK)
            {
                metaInformationFilePathTextbox.Text = openMetaInfo.FileName;
            }
        }
    }
}
