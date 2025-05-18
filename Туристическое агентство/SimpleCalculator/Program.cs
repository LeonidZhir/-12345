using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TravelAgencyApp
{
    public partial class MainForm : Form
    {
        private List<Region> regions = new List<Region>();
        private string userRegion;
        private int time;
        private int budget;

        public MainForm()
        {
            InitializeComponent();
            InitializeRegionsComboBox();
            InitializeTimeComboBox();
        }

        private void InitializeRegionsComboBox()
        {
            comboBoxRegions.Items.AddRange(new string[] 
            {
                "��������", "������-��������", "�����������", "����������-����������",
                "�����-�������", "����������", "�������-����������", "���������",
                "�������-���������", "��������-���������", "���������������"
            });
        }

        private void InitializeTimeComboBox()
        {
            comboBoxTime.Items.AddRange(new string[] { "1", "2" });
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxRegions.SelectedItem == null || comboBoxTime.SelectedItem == null)
            {
                MessageBox.Show("����������, �������� ������ � ������������ ������.");
                return;
            }

            userRegion = comboBoxRegions.SelectedItem.ToString();
            time = int.Parse(comboBoxTime.SelectedItem.ToString());
            budget = (int)numericUpDownBudget.Value;

            InitializeRegionsData();

            List<Region> availableRegions = new List<Region>();
            foreach (var region in regions)
            {
                if (budget >= region.MinBudget)
                {
                    availableRegions.Add(region);
                }
            }

            if (availableRegions.Count == 0)
            {
                MessageBox.Show("� ���������, ��� ��������� �������� ��� ������ � ������ ������ �������.");
                return;
            }

            DisplayAvailableRegions(availableRegions);
        }

        private void InitializeRegionsData()
        {
            regions.Clear();

            if (userRegion == "������-��������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 82740, MaxBudget = 102740, Description = "��������������� ������ ���������� ������ ������������ ���������� ����������� � ������������� ��� ����������� �� ������ �������." },
                new Region { Name = "���������", MinBudget = 54740, MaxBudget = 60740, Description = "��������� ������ �������� ����� ������� �������� � ������������� ���������� ���������, �������� ����������� ��� ������." },
                new Region { Name = "��������", MinBudget = 40740, MaxBudget = 42740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." },
                new Region { Name = "����������-����������", MinBudget = 56740, MaxBudget = 58740, Description = "����������� ������ ���������� ���������� �������� � ��������� ��������������� ����������� ��� ���� �����." },
                new Region { Name = "�����������", MinBudget = 52740, MaxBudget = 54740, Description = "����������� ������ � ��� ������ ������, ��� ������� � ������������� ���������� ����������." },
                new Region { Name = "�������-����������", MinBudget = 67740, MaxBudget = 70740, Description = "����� ������ �������� ������ ���������, ������ �������� � ������������ ������." },
                new Region { Name = "����������", MinBudget = 53740, MaxBudget = 62740, Description = "����������� ������ ����� ����������� ���������� � ������������� �����������, ������� ����� �������." },
                new Region { Name = "��������-���������", MinBudget = 72740, MaxBudget = 82740, Description = "��������� ������ ���������� ���������� ��������� ����������� � ����������� ��� ����������." },
                new Region { Name = "�������-���������", MinBudget = 62740, MaxBudget = 74740, Description = "�������-��������� ������ � ��� �����, ��� ������� � �������� ������� ������������ ���������." },
                new Region { Name = "�����-�������", MinBudget = 52740, MaxBudget = 60740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 111480, MaxBudget = 115480, Description = "��������������� ������ ���������� ������ ������������ ���������� ����������� � ������������� ��� ����������� �� ������ �������." },
                new Region { Name = "���������", MinBudget = 67480, MaxBudget = 73480, Description = "��������� ������ �������� ����� ������� �������� � ������������� ���������� ���������, �������� ����������� ��� ������." },
                new Region { Name = "����������-����������", MinBudget = 55480, MaxBudget = 55480, Description = "����������� ������ ���������� ���������� �������� � ��������� ��������������� ����������� ��� ���� �����." },
                new Region { Name = "�����������", MinBudget = 53480, MaxBudget = 56480, Description = "����������� ������ � ��� ������ ������, ��� ������� � ������������� ���������� ����������." },
                new Region { Name = "�������-����������", MinBudget = 71480, MaxBudget = 85480, Description = "����� ������ �������� ������ ���������, ������ �������� � ������������ ������." },
                new Region { Name = "����������", MinBudget = 61480, MaxBudget = 69480, Description = "����������� ������ ����� ����������� ���������� � ������������� �����������, ������� ����� �������." },
                new Region { Name = "��������-���������", MinBudget = 81480, MaxBudget = 97480, Description = "��������� ������ ���������� ���������� ��������� ����������� � ����������� ��� ����������." },
                new Region { Name = "�������-���������", MinBudget = 67480, MaxBudget = 83480, Description = "�������-��������� ������ � ��� �����, ��� ������� � �������� ������� ������������ ���������." },
                new Region { Name = "�����-�������", MinBudget = 62480, MaxBudget = 69480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 52480, MaxBudget = 56480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "��������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 82740, MaxBudget = 102740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 54740, MaxBudget = 60740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 40740, MaxBudget = 42740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 56740, MaxBudget = 58740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 52740, MaxBudget = 54740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 67740, MaxBudget = 70740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 53740, MaxBudget = 62740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 72740, MaxBudget = 82740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 62740, MaxBudget = 74740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 52740, MaxBudget = 60740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 105480, MaxBudget = 125480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 67480, MaxBudget = 73480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 63480, MaxBudget = 65480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 79480, MaxBudget = 81480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 75480, MaxBudget = 77480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 90480, MaxBudget = 93480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 76480, MaxBudget = 85480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 95480, MaxBudget = 105480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 85480, MaxBudget = 97480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 75480, MaxBudget = 83480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." }
            };
                }
            }
            else if (userRegion == "�����������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 62740, MaxBudget = 86740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 39740, MaxBudget = 42740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 30740, MaxBudget = 32740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 28740, MaxBudget = 30740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�������-����������", MinBudget = 44740, MaxBudget = 49740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 33740, MaxBudget = 36740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 50740, MaxBudget = 63740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 40740, MaxBudget = 56740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 32740, MaxBudget = 38740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 36740, MaxBudget = 41740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 85480, MaxBudget = 109480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 62480, MaxBudget = 65480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 53480, MaxBudget = 55480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 51480, MaxBudget = 53480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�������-����������", MinBudget = 67480, MaxBudget = 72480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 56480, MaxBudget = 59480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 73480, MaxBudget = 86480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 63480, MaxBudget = 79480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 55480, MaxBudget = 61480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 59480, MaxBudget = 64480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "�����-�������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 76740, MaxBudget = 79740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 30740, MaxBudget = 33740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 41740, MaxBudget = 43740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 34740, MaxBudget = 35740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 28740, MaxBudget = 32740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 50740, MaxBudget = 52740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 26740, MaxBudget = 30740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 54740, MaxBudget = 69740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 49740, MaxBudget = 60740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "��������", MinBudget = 40740, MaxBudget = 51740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 99480, MaxBudget = 102480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 53480, MaxBudget = 56480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 53480, MaxBudget = 55480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 57480, MaxBudget = 58480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 51480, MaxBudget = 55480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 67480, MaxBudget = 72480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 56480, MaxBudget = 59480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 73480, MaxBudget = 86480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 63480, MaxBudget = 79480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "��������", MinBudget = 63480, MaxBudget = 74480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "����������-����������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 65740, MaxBudget = 89740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 42740, MaxBudget = 45740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 33740, MaxBudget = 35740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "�����������", MinBudget = 30740, MaxBudget = 31740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 47740, MaxBudget = 52740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 36740, MaxBudget = 39740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 53740, MaxBudget = 66740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 43740, MaxBudget = 59740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 34740, MaxBudget = 35740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 39740, MaxBudget = 44740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 88480, MaxBudget = 112480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 65480, MaxBudget = 68480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 56480, MaxBudget = 58480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "�����������", MinBudget = 53480, MaxBudget = 54480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 70480, MaxBudget = 75480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 59480, MaxBudget = 62480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 76480, MaxBudget = 89480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 66480, MaxBudget = 82480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 45480, MaxBudget = 46480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 62480, MaxBudget = 67480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "�������-����������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 62740, MaxBudget = 94740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 40740, MaxBudget = 45740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 46740, MaxBudget = 48740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 41740, MaxBudget = 42740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 45740, MaxBudget = 47740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "����������", MinBudget = 39740, MaxBudget = 44740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 49740, MaxBudget = 59740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 49740, MaxBudget = 66740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 44740, MaxBudget = 46740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 51740, MaxBudget = 58740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 85480, MaxBudget = 117480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 63480, MaxBudget = 65480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 53480, MaxBudget = 55480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 64480, MaxBudget = 65480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 74480, MaxBudget = 81480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "����������", MinBudget = 62480, MaxBudget = 67480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 72480, MaxBudget = 82480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 72480, MaxBudget = 89480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 67480, MaxBudget = 69480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 69480, MaxBudget = 71480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "����������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 72740, MaxBudget = 98740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 28740, MaxBudget = 47740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 46740, MaxBudget = 48740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 42740, MaxBudget = 43740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 45740, MaxBudget = 47740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 52740, MaxBudget = 56740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "��������-���������", MinBudget = 55740, MaxBudget = 62740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 45740, MaxBudget = 49740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 27740, MaxBudget = 30740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 46740, MaxBudget = 52740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 95480, MaxBudget = 121480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 51480, MaxBudget = 70480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 65480, MaxBudget = 66480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 65480, MaxBudget = 66480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 68480, MaxBudget = 70480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 75480, MaxBudget = 79480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "��������-���������", MinBudget = 78480, MaxBudget = 85480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 68480, MaxBudget = 72480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 50480, MaxBudget = 53480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 69480, MaxBudget = 75480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "���������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 72740, MaxBudget = 98740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "������-��������", MinBudget = 44740, MaxBudget = 46740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 42740, MaxBudget = 43740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 45740, MaxBudget = 47740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 52740, MaxBudget = 56740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 28740, MaxBudget = 47740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 57740, MaxBudget = 72740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 42740, MaxBudget = 66740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 29740, MaxBudget = 32740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 46740, MaxBudget = 50740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 95480, MaxBudget = 121480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "������-��������", MinBudget = 67480, MaxBudget = 69480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 65480, MaxBudget = 66480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 68480, MaxBudget = 70480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 75480, MaxBudget = 79480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 51480, MaxBudget = 70480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 80480, MaxBudget = 95480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 65480, MaxBudget = 89480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 52480, MaxBudget = 55480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 69480, MaxBudget = 73480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "�������-���������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 64740, MaxBudget = 84740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 42740, MaxBudget = 62740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 52740, MaxBudget = 54740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 54740, MaxBudget = 55740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 52740, MaxBudget = 55740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 60740, MaxBudget = 64740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 44740, MaxBudget = 53740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 46740, MaxBudget = 59740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 50740, MaxBudget = 54740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 54740, MaxBudget = 64740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 87480, MaxBudget = 107480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 65480, MaxBudget = 85480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 75480, MaxBudget = 77480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 65480, MaxBudget = 66480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 75480, MaxBudget = 78480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 83480, MaxBudget = 87480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 67480, MaxBudget = 76480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 69480, MaxBudget = 82480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 73480, MaxBudget = 77480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 77480, MaxBudget = 87480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "��������-���������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 57740, MaxBudget = 68740, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 46740, MaxBudget = 53740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 58740, MaxBudget = 60740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 57740, MaxBudget = 58740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 52740, MaxBudget = 53740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 60740, MaxBudget = 64740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 67480, MaxBudget = 76480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "�������-���������", MinBudget = 42740, MaxBudget = 49740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 52740, MaxBudget = 59740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 62740, MaxBudget = 70740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������������", MinBudget = 70480, MaxBudget = 91480, Description = "��������������� ������ ���������� ���������� ��������� ��������� � �����������." },
                new Region { Name = "���������", MinBudget = 69480, MaxBudget = 76480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 81480, MaxBudget = 83480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 80480, MaxBudget = 81480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 77480, MaxBudget = 80480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 83480, MaxBudget = 87480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 77480, MaxBudget = 89480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "�������-���������", MinBudget = 65480, MaxBudget = 72480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 9000, MaxBudget = 22000, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 85480, MaxBudget = 93480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else if (userRegion == "���������������")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������", MinBudget = 45740, MaxBudget = 66740, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 74740, MaxBudget = 76740, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 77740, MaxBudget = 78740, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 79740, MaxBudget = 82740, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 84740, MaxBudget = 88740, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 74740, MaxBudget = 78740, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 45740, MaxBudget = 66740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 68740, MaxBudget = 75740, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 72740, MaxBudget = 82740, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 82740, MaxBudget = 95740, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "���������", MinBudget = 88480, MaxBudget = 103480, Description = "��������� ������ ����� ������������� ����������������������� � ���������� ���������." },
                new Region { Name = "������-��������", MinBudget = 97480, MaxBudget = 99480, Description = "������-�������� ������ �������� ������ ����������� � ������������� �����������." },
                new Region { Name = "����������-����������", MinBudget = 100480, MaxBudget = 101480, Description = "����������� ������ ���������� ��������� ���������� � ��������������� �����������." },
                new Region { Name = "�����������", MinBudget = 102480, MaxBudget = 105480, Description = "������������, ������������ � ������������� ����� ������. �� ��� ���������� ��������� ������� ������." },
                new Region { Name = "�������-����������", MinBudget = 107480, MaxBudget = 111480, Description = "����� ������ �������� ������ ��������� � ������ ��������." },
                new Region { Name = "����������", MinBudget = 97480, MaxBudget = 101480, Description = "����������� ������ ����� ������������� � ����������� �����������������������." },
                new Region { Name = "��������-���������", MinBudget = 68480, MaxBudget = 89480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�������-���������", MinBudget = 91480, MaxBudget = 98480, Description = "��������� ������ ���������� ���������� ��������� ����������� � �����������." },
                new Region { Name = "�����-�������", MinBudget = 95480, MaxBudget = 105480, Description = "�����-������� ������ �������� ������ ����������� ��������� � ������� ���������." },
                new Region { Name = "��������", MinBudget = 105480, MaxBudget = 118480, Description = "�������� ������ ���������� ������������ ��������� �������, ����� ��� �������� ������." }
            };
                }
            }
            else
            {
                MessageBox.Show("������������ ���� �������. ����������, ������� ���������� ������.");
                return;
            }
        }

        private void DisplayAvailableRegions(List<Region> availableRegions)
        {
            listBoxRegions.Items.Clear();
            foreach (var region in availableRegions)
            {
                listBoxRegions.Items.Add($"{region.Name} (������: {region.MinBudget} - {region.MaxBudget})");
            }
        }

        private void listBoxRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegions.SelectedIndex != -1)
            {
                string selectedRegionName = listBoxRegions.SelectedItem.ToString().Split(' ')[0];
                Region selectedRegion = regions.Find(r => r.Name == selectedRegionName);

                if (budget <= selectedRegion.MaxBudget)
                {
                    MessageBox.Show($"��� �������� 1 ����� ��� ������ � ������� {selectedRegion.Name}:\n{GetSingleCity(selectedRegion.Name)}");
                }
                else
                {
                    MessageBox.Show($"��� �������� 3 ������ ��� ������ � ������� {selectedRegion.Name}:\n{GetThreeCities(selectedRegion.Name)}");
                }
            }
        }

        private string GetSingleCity(string regionName)
        {
            switch (regionName)
            {
                case "���������������": return "������";
                case "��������": return "������������";
                case "������-��������": return "�����-���������";
                case "�����������": return "���������";
                case "����������-����������": return "������";
                case "�����-�������": return "������ ��������";
                case "����������": return "������";
                case "�������-����������": return "����";
                case "���������": return "���������";
                case "�������-���������": return "������";
                case "��������-���������": return "����������";
                default: return "����������� ������";
            }
        }

        private string GetThreeCities(string regionName)
        {
            switch (regionName)
            {
                case "���������������": return "�������������-����������, ������, �����������";
                case "��������": return "������������, �������, ��������";
                case "������-��������": return "�����-���������, ��������, ������";
                case "�����������": return "���������, �����, ��������";
                case "����������-����������": return "�������, ������, ������";
                case "�����-�������": return "������ ��������, �������, ���������";
                case "����������": return "������, ������, �������";
                case "�������-����������": return "����, ���������, ���������";
                case "���������": return "�����, ������������, ���������";
                case "�������-���������": return "������, ����, �����-�������";
                case "��������-���������": return "����������, �����, �������";
                default: return "����������� ������";
            }
        }
    }
}