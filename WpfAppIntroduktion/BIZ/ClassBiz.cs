using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktion.BIZ
{
    class ClassBiz
    {
        public ClassBiz()
        {
        }
        Random random = new Random();

        private List<int> GetRandomNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }
            return numbers;
        }

        //Opgave 2
        public void Number4711(ListBox listBox)
        {
            for (int i = 4711; i <= 4736; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        //Opgave 3
        public void RandomNumbers(ListBox listBox)
        {
            List<int> numbers = GetRandomNumbers();
            foreach (int number in numbers)
            {
                listBox.Items.Add(number.ToString());
            }
            
        }

        //Opgave 4
        public void RandomSortedNumbers(ListBox listBox)
        {
            List<int> numbers = GetRandomNumbers();

            numbers.Sort();

            foreach (int number in numbers)
            {
                listBox.Items.Add(number.ToString());
            }
        }

        //Opgave 5
        public void RandomNumbersSortedAndUnsorted(ListBox listBox)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                list1.Add(randomNumber);
                list2.Add(randomNumber);
            }
            list2.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                listBox.Items.Add($"{list1[i]} - {list2[i]}");
            }
        }

        //Opgave 6
        public void GetAverage(ListBox listBox)
        {
            List<int> numbers = GetRandomNumbers();
            int average = FindAverage(numbers);

            foreach (int number in numbers)
            {
                listBox.Items.Add(number);
            }

            listBox.Items.Add("");
            listBox.Items.Add("Gennemsnit: " + average);
        }
        private int FindAverage(List<int> numbers)
        {
            int average = (int)numbers.Average();
            return average;
        }

        //Opgave 7
        public void GetAverageAndSubtract(ListBox listBox)
        {
            List<int> numbers = GetRandomNumbers();
            numbers.Sort();
            int average = FindAverage(numbers);
            
            foreach (int number in numbers)
            {
                listBox.Items.Add($"{number} - {average} = {number - average}");
            }
        }

        //Opgave 8
        public List<String> 

    }
}
