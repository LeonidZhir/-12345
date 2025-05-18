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
                "Северный", "Северо-Западный", "Центральный", "Центрально-Чернозёмный",
                "Волго-Вятский", "Поволжский", "Северно-Кавказский", "Уральский",
                "Западно-Сибирский", "Восточно-Сибирский", "Дальневосточный"
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
                MessageBox.Show("Пожалуйста, выберите регион и длительность отдыха.");
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
                MessageBox.Show("К сожалению, нет доступных регионов для отдыха в рамках вашего бюджета.");
                return;
            }

            DisplayAvailableRegions(availableRegions);
        }

        private void InitializeRegionsData()
        {
            regions.Clear();

            if (userRegion == "Северо-Западный")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 82740, MaxBudget = 102740, Description = "Дальневосточный регион привлекает своими потрясающими природными ландшафтами и возможностями для приключений на свежем воздухе." },
                new Region { Name = "Уральский", MinBudget = 54740, MaxBudget = 60740, Description = "Уральский регион славится своей богатой историей и великолепными природными красотами, идеально подходящими для отдыха." },
                new Region { Name = "Северный", MinBudget = 40740, MaxBudget = 42740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 56740, MaxBudget = 58740, Description = "Центральный регион предлагает уникальную культуру и множество развлекательных мероприятий для всей семьи." },
                new Region { Name = "Центральный", MinBudget = 52740, MaxBudget = 54740, Description = "Центральный регион — это сердце России, где история и современность гармонично сочетаются." },
                new Region { Name = "Северно-Кавказский", MinBudget = 67740, MaxBudget = 70740, Description = "Южный регион известен своими курортами, теплым климатом и приветливыми людьми." },
                new Region { Name = "Поволжский", MinBudget = 53740, MaxBudget = 62740, Description = "Приволжский регион богат культурными традициями и историческими памятниками, которые стоит увидеть." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 72740, MaxBudget = 82740, Description = "Сибирский регион предлагает уникальные природные заповедники и возможности для экотуризма." },
                new Region { Name = "Западно-Сибирский", MinBudget = 62740, MaxBudget = 74740, Description = "Западно-Сибирский регион — это место, где природа и культура создают неповторимую атмосферу." },
                new Region { Name = "Волго-Вятский", MinBudget = 52740, MaxBudget = 60740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 111480, MaxBudget = 115480, Description = "Дальневосточный регион привлекает своими потрясающими природными ландшафтами и возможностями для приключений на свежем воздухе." },
                new Region { Name = "Уральский", MinBudget = 67480, MaxBudget = 73480, Description = "Уральский регион славится своей богатой историей и великолепными природными красотами, идеально подходящими для отдыха." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 55480, MaxBudget = 55480, Description = "Центральный регион предлагает уникальную культуру и множество развлекательных мероприятий для всей семьи." },
                new Region { Name = "Центральный", MinBudget = 53480, MaxBudget = 56480, Description = "Центральный регион — это сердце России, где история и современность гармонично сочетаются." },
                new Region { Name = "Северно-Кавказский", MinBudget = 71480, MaxBudget = 85480, Description = "Южный регион известен своими курортами, теплым климатом и приветливыми людьми." },
                new Region { Name = "Поволжский", MinBudget = 61480, MaxBudget = 69480, Description = "Приволжский регион богат культурными традициями и историческими памятниками, которые стоит увидеть." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 81480, MaxBudget = 97480, Description = "Сибирский регион предлагает уникальные природные заповедники и возможности для экотуризма." },
                new Region { Name = "Западно-Сибирский", MinBudget = 67480, MaxBudget = 83480, Description = "Западно-Сибирский регион — это место, где природа и культура создают неповторимую атмосферу." },
                new Region { Name = "Волго-Вятский", MinBudget = 62480, MaxBudget = 69480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 52480, MaxBudget = 56480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Северный")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 82740, MaxBudget = 102740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 54740, MaxBudget = 60740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 40740, MaxBudget = 42740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 56740, MaxBudget = 58740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 52740, MaxBudget = 54740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 67740, MaxBudget = 70740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 53740, MaxBudget = 62740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 72740, MaxBudget = 82740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 62740, MaxBudget = 74740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 52740, MaxBudget = 60740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 105480, MaxBudget = 125480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 67480, MaxBudget = 73480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 63480, MaxBudget = 65480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 79480, MaxBudget = 81480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 75480, MaxBudget = 77480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 90480, MaxBudget = 93480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 76480, MaxBudget = 85480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 95480, MaxBudget = 105480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 85480, MaxBudget = 97480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 75480, MaxBudget = 83480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." }
            };
                }
            }
            else if (userRegion == "Центральный")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 62740, MaxBudget = 86740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 39740, MaxBudget = 42740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 30740, MaxBudget = 32740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 28740, MaxBudget = 30740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Северно-Кавказский", MinBudget = 44740, MaxBudget = 49740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 33740, MaxBudget = 36740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 50740, MaxBudget = 63740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 40740, MaxBudget = 56740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 32740, MaxBudget = 38740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 36740, MaxBudget = 41740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 85480, MaxBudget = 109480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 62480, MaxBudget = 65480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 53480, MaxBudget = 55480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 51480, MaxBudget = 53480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Северно-Кавказский", MinBudget = 67480, MaxBudget = 72480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 56480, MaxBudget = 59480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 73480, MaxBudget = 86480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 63480, MaxBudget = 79480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 55480, MaxBudget = 61480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 59480, MaxBudget = 64480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Волго-Вятский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 76740, MaxBudget = 79740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 30740, MaxBudget = 33740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 41740, MaxBudget = 43740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 34740, MaxBudget = 35740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 28740, MaxBudget = 32740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 50740, MaxBudget = 52740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 26740, MaxBudget = 30740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 54740, MaxBudget = 69740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 49740, MaxBudget = 60740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Северный", MinBudget = 40740, MaxBudget = 51740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 99480, MaxBudget = 102480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 53480, MaxBudget = 56480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 53480, MaxBudget = 55480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 57480, MaxBudget = 58480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 51480, MaxBudget = 55480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 67480, MaxBudget = 72480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 56480, MaxBudget = 59480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 73480, MaxBudget = 86480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 63480, MaxBudget = 79480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Северный", MinBudget = 63480, MaxBudget = 74480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Центрально-Чернозёмный")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 65740, MaxBudget = 89740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 42740, MaxBudget = 45740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 33740, MaxBudget = 35740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центральный", MinBudget = 30740, MaxBudget = 31740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 47740, MaxBudget = 52740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 36740, MaxBudget = 39740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 53740, MaxBudget = 66740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 43740, MaxBudget = 59740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 34740, MaxBudget = 35740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 39740, MaxBudget = 44740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 88480, MaxBudget = 112480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 65480, MaxBudget = 68480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 56480, MaxBudget = 58480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центральный", MinBudget = 53480, MaxBudget = 54480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 70480, MaxBudget = 75480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 59480, MaxBudget = 62480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 76480, MaxBudget = 89480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 66480, MaxBudget = 82480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 45480, MaxBudget = 46480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 62480, MaxBudget = 67480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Северно-Кавказский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 62740, MaxBudget = 94740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 40740, MaxBudget = 45740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 46740, MaxBudget = 48740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 41740, MaxBudget = 42740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 45740, MaxBudget = 47740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Поволжский", MinBudget = 39740, MaxBudget = 44740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 49740, MaxBudget = 59740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 49740, MaxBudget = 66740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 44740, MaxBudget = 46740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 51740, MaxBudget = 58740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 85480, MaxBudget = 117480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 63480, MaxBudget = 65480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 53480, MaxBudget = 55480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 64480, MaxBudget = 65480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 74480, MaxBudget = 81480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Поволжский", MinBudget = 62480, MaxBudget = 67480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 72480, MaxBudget = 82480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 72480, MaxBudget = 89480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 67480, MaxBudget = 69480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 69480, MaxBudget = 71480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Поволжский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 72740, MaxBudget = 98740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 28740, MaxBudget = 47740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 46740, MaxBudget = 48740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 42740, MaxBudget = 43740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 45740, MaxBudget = 47740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 52740, MaxBudget = 56740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 55740, MaxBudget = 62740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 45740, MaxBudget = 49740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 27740, MaxBudget = 30740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 46740, MaxBudget = 52740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 95480, MaxBudget = 121480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 51480, MaxBudget = 70480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 65480, MaxBudget = 66480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 65480, MaxBudget = 66480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 68480, MaxBudget = 70480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 75480, MaxBudget = 79480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 78480, MaxBudget = 85480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 68480, MaxBudget = 72480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 50480, MaxBudget = 53480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 69480, MaxBudget = 75480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Уральский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 72740, MaxBudget = 98740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Северо-Западный", MinBudget = 44740, MaxBudget = 46740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 42740, MaxBudget = 43740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 45740, MaxBudget = 47740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 52740, MaxBudget = 56740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 28740, MaxBudget = 47740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 57740, MaxBudget = 72740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 42740, MaxBudget = 66740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 29740, MaxBudget = 32740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 46740, MaxBudget = 50740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 95480, MaxBudget = 121480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Северо-Западный", MinBudget = 67480, MaxBudget = 69480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 65480, MaxBudget = 66480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 68480, MaxBudget = 70480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 75480, MaxBudget = 79480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 51480, MaxBudget = 70480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 80480, MaxBudget = 95480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 65480, MaxBudget = 89480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 52480, MaxBudget = 55480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 69480, MaxBudget = 73480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Западно-Сибирский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 64740, MaxBudget = 84740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 42740, MaxBudget = 62740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 52740, MaxBudget = 54740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 54740, MaxBudget = 55740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 52740, MaxBudget = 55740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 60740, MaxBudget = 64740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 44740, MaxBudget = 53740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 46740, MaxBudget = 59740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 50740, MaxBudget = 54740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 54740, MaxBudget = 64740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 87480, MaxBudget = 107480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 65480, MaxBudget = 85480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 75480, MaxBudget = 77480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 65480, MaxBudget = 66480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 75480, MaxBudget = 78480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 83480, MaxBudget = 87480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 67480, MaxBudget = 76480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 69480, MaxBudget = 82480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 73480, MaxBudget = 77480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 77480, MaxBudget = 87480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Восточно-Сибирский")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 57740, MaxBudget = 68740, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 46740, MaxBudget = 53740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 58740, MaxBudget = 60740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 57740, MaxBudget = 58740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 52740, MaxBudget = 53740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 60740, MaxBudget = 64740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 67480, MaxBudget = 76480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Западно-Сибирский", MinBudget = 42740, MaxBudget = 49740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 52740, MaxBudget = 59740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 62740, MaxBudget = 70740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Дальневосточный", MinBudget = 70480, MaxBudget = 91480, Description = "Дальневосточный регион предлагает уникальные природные ландшафты и приключения." },
                new Region { Name = "Уральский", MinBudget = 69480, MaxBudget = 76480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 81480, MaxBudget = 83480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 80480, MaxBudget = 81480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 77480, MaxBudget = 80480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 83480, MaxBudget = 87480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 77480, MaxBudget = 89480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Западно-Сибирский", MinBudget = 65480, MaxBudget = 72480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 9000, MaxBudget = 22000, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 85480, MaxBudget = 93480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else if (userRegion == "Дальневосточный")
            {
                if (time == 1)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Уральский", MinBudget = 45740, MaxBudget = 66740, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 74740, MaxBudget = 76740, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 77740, MaxBudget = 78740, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 79740, MaxBudget = 82740, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 84740, MaxBudget = 88740, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 74740, MaxBudget = 78740, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 45740, MaxBudget = 66740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 68740, MaxBudget = 75740, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 72740, MaxBudget = 82740, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 82740, MaxBudget = 95740, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
                else if (time == 2)
                {
                    regions = new List<Region>
            {
                new Region { Name = "Уральский", MinBudget = 88480, MaxBudget = 103480, Description = "Уральский регион богат историческими достопримечательностями и природными красотами." },
                new Region { Name = "Северо-Западный", MinBudget = 97480, MaxBudget = 99480, Description = "Северо-Западный регион известен своими культурными и историческими памятниками." },
                new Region { Name = "Центрально-Чернозёмный", MinBudget = 100480, MaxBudget = 101480, Description = "Центральный регион предлагает множество культурных и развлекательных мероприятий." },
                new Region { Name = "Центральный", MinBudget = 102480, MaxBudget = 105480, Description = "Исторический, политический и хозяйственный центр страны. На его территории находится столица России." },
                new Region { Name = "Северно-Кавказский", MinBudget = 107480, MaxBudget = 111480, Description = "Южный регион славится своими курортами и теплым климатом." },
                new Region { Name = "Поволжский", MinBudget = 97480, MaxBudget = 101480, Description = "Приволжский регион богат историческими и культурными достопримечательностями." },
                new Region { Name = "Восточно-Сибирский", MinBudget = 68480, MaxBudget = 89480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Западно-Сибирский", MinBudget = 91480, MaxBudget = 98480, Description = "Сибирский регион предлагает уникальные природные заповедники и приключения." },
                new Region { Name = "Волго-Вятский", MinBudget = 95480, MaxBudget = 105480, Description = "Волго-Вятский регион известен своими живописными пейзажами и богатой культурой." },
                new Region { Name = "Северный", MinBudget = 105480, MaxBudget = 118480, Description = "Северный регион предлагает удивительные природные явления, такие как северное сияние." }
            };
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод региона. Пожалуйста, введите корректный регион.");
                return;
            }
        }

        private void DisplayAvailableRegions(List<Region> availableRegions)
        {
            listBoxRegions.Items.Clear();
            foreach (var region in availableRegions)
            {
                listBoxRegions.Items.Add($"{region.Name} (Бюджет: {region.MinBudget} - {region.MaxBudget})");
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
                    MessageBox.Show($"Вам доступен 1 город для отдыха в регионе {selectedRegion.Name}:\n{GetSingleCity(selectedRegion.Name)}");
                }
                else
                {
                    MessageBox.Show($"Вам доступны 3 города для отдыха в регионе {selectedRegion.Name}:\n{GetThreeCities(selectedRegion.Name)}");
                }
            }
        }

        private string GetSingleCity(string regionName)
        {
            switch (regionName)
            {
                case "Дальневосточный": return "Якутск";
                case "Северный": return "Петрозаводск";
                case "Северо-Западный": return "Санкт-Петербург";
                case "Центральный": return "Ярославль";
                case "Центрально-Чернозёмный": return "Тамбов";
                case "Волго-Вятский": return "Нижний Новгород";
                case "Поволжский": return "Казань";
                case "Северно-Кавказский": return "Сочи";
                case "Уральский": return "Челябинск";
                case "Западно-Сибирский": return "Тюмень";
                case "Восточно-Сибирский": return "Красноярск";
                default: return "Неизвестный регион";
            }
        }

        private string GetThreeCities(string regionName)
        {
            switch (regionName)
            {
                case "Дальневосточный": return "Петропавловск-Камчатский, Якутск, Владивосток";
                case "Северный": return "Петрозаводск, Вологда, Мурманск";
                case "Северо-Западный": return "Санкт-Петербург, Новгород, Выборг";
                case "Центральный": return "Ярославль, Тверь, Владимир";
                case "Центрально-Чернозёмный": return "Воронеж, Тамбов, Липецк";
                case "Волго-Вятский": return "Нижний Новгород, Саранск, Чебоксары";
                case "Поволжский": return "Казань, Самара, Саратов";
                case "Северно-Кавказский": return "Сочи, Краснодар, Махачкала";
                case "Уральский": return "Пермь, Екатеринбург, Челябинск";
                case "Западно-Сибирский": return "Тюмень, Омск, Горно-Алтайск";
                case "Восточно-Сибирский": return "Красноярск, Кызыл, Иркутск";
                default: return "Неизвестный регион";
            }
        }
    }
}