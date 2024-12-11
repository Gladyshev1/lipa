using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lipa
{
    public partial class Visibleform : Form
    {
        private CheckedListBox checkedListBox;
        private readonly Action<List<bool>> action;
        public List<bool> flags;

        public Visibleform(List<string> Hed, Action<List<bool>> action)
        {
            flags = new List<bool>();
            this.action = action;
            InitializeComponent();
            InitializeCheckedListBox(Hed);
        }

        private void InitializeCheckedListBox(List<string> Hed)
        {
            checkedListBox = new CheckedListBox
            {
                Dock = DockStyle.Fill, // заполняет всю форму
                CheckOnClick = true
            };

            // Добавление элементов из списка Hed и установка флажка для каждого из них
            foreach (var item in Hed)
            {
                checkedListBox.Items.Add(item);
                checkedListBox.SetItemChecked(checkedListBox.Items.Count - 1, true); // Установка флажка для текущего элемента
            }

            // Добавление CheckedListBox на форму
            this.Controls.Add(checkedListBox);

            // Опционально добавить кнопку для подтверждения выбора
            Button confirmButton = new Button
            {
                Text = "Подтвердить выбор",
                Dock = DockStyle.Bottom
            };
            confirmButton.Click += (sender, e) => OnConfirm();

            this.Controls.Add(confirmButton);
        }

        private void OnConfirm()
        {
            // Логика обработки выбранных элементов
            flags.Clear(); // Очистить список перед добавлением новых значений
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                flags.Add(checkedListBox.GetItemChecked(i)); // Здесь можно добавить желаемую обработку
            }
            action(flags);
            this.Close(); // Закрыть форму после обработки
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                flags.Add(checkedListBox.GetItemChecked(i)); // Здесь можно добавить желаемую обработку
            }
            action(flags);
        }
    }
}
