using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertEvaluationIS
{
    class SampleData
    {
        public static Groups sampleGroup = new Groups(1);
        
        public static void setData()
        {            
            List<Answers> answers = new List<Answers>();
            List<Qij> questions = new List<Qij>();
            List<Gi> KCollection = new List<Gi>();
            List<G> groups = new List<G>();
            answers.Add(new Answers("1. тимчасово не праццює", 5));
            answers.Add(new Answers("2. немає стабільні доходи", 10));
            answers.Add(new Answers("3. має стабільні доходи", 25));
            answers.Add(new Answers("4. має стабільні доходи та заощадження", 30));
            questions.Add(new Qij(1, 1, "Фізична особа працює та ...?", new List<Answers>(answers), 25));

            answers.Add(new Answers("1. не забезпечений", 0));
            answers.Add(new Answers("2. не менше 6 місяців", 10));
            answers.Add(new Answers("3. більше 3-ох років", 15));
            answers.Add(new Answers("4. більше 10 років", 30));
            questions.Add(new Qij(1, 2, "Забезпеченість постійною роботою?", new List<Answers>(answers), 15));
            
            answers.Add(new Answers("1. підтверджується відповідним листом-рекомендацією", 5));
            answers.Add(new Answers("2. підтверджується клопотанням  юридичної особи чи з місця роботи", 10));
            answers.Add(new Answers("3. підтверджується фактом займання заступником керівної посади", 25));
            answers.Add(new Answers("4. підтверджується фактом займання керівної посади", 30));
            questions.Add(new Qij(1, 3, "Ділова репутація (має зв’язки та підтримку у ділових колах)?", new List<Answers>(answers), 25));

            answers.Add(new Answers("1. середня", 5));
            answers.Add(new Answers("2. середня-спеціальна, середня-технічна, незакінчена вища", 10));
            answers.Add(new Answers("3. вища", 25));
            answers.Add(new Answers("4. наявність наукового ступеня", 30));
            questions.Add(new Qij(1, 3, "Освіта:", new List<Answers>(answers), 25));

            answers.Add(new Answers("1. страхування позичальника від нещасного випадку", 5));
            answers.Add(new Answers("2. добровільне медичне страхування", 10));
            answers.Add(new Answers("3. страхування майна", 20));
            answers.Add(new Answers("4. добровільне медичне страхування та накопичувальне страхування", 30));
            questions.Add(new Qij(1, 3, "Наявність страхування:", new List<Answers>(answers), 10));

            KCollection.Add(new Gi("Cоціальна стабільність", 1, new List<Qij>(questions)));
            questions.Clear();
            answers.Clear();

            //--------------------

            answers.Add(new Answers("1. 91% - 100%", 5));
            answers.Add(new Answers("2. 81% - 90%", 10));
            answers.Add(new Answers("3. 61% - 80%", 20));
            answers.Add(new Answers("4. не більше 60%", 25));
            questions.Add(new Qij(2, 1, "Питома вага сукупних витрат позичальника в сукупних доходах:", new List<Answers>(answers), 20));

            answers.Add(new Answers("1. 1.5% - 0%", 0));
            answers.Add(new Answers("2. 15% - 6%", 5));
            answers.Add(new Answers("3. 24% - 16%", 10));
            answers.Add(new Answers("4. 25% i більше", 15));
            questions.Add(new Qij(2, 2, "Співвідношення сукупного чистого середньомісячного доходу до суми кредитом:", new List<Answers>(answers), 15));

            answers.Add(new Answers("1. більше 40% від запитуваного кредиту", 0));
            answers.Add(new Answers("2. 10-40%  від запитуваного кредиту", 10));
            answers.Add(new Answers("3. до 10% від запитуваного кредиту", 15));
            answers.Add(new Answers("4. не має", 20));
            questions.Add(new Qij(2, 3, "Наявність заборгованості за іншими кредитами в інших банках:", new List<Answers>(answers), 15));

            KCollection.Add(new Gi("Платоспроможність позичальника", 2, new List<Qij>(questions)));
            questions.Clear();
            answers.Clear();

            //--------------------

            answers.Add(new Answers("1. одноразово в кінці терміну", 5));
            answers.Add(new Answers("2. рідше ніж 1 раз на квартал", 10));
            answers.Add(new Answers("3. щоквартально", 15));
            answers.Add(new Answers("4. щомісячно", 25));
            questions.Add(new Qij(3, 1, "Погашення основного боргу проводиться:", new List<Answers>(answers), 25));

            answers.Add(new Answers("1. в кінці терміну", 5));
            answers.Add(new Answers("2. рідше ніж раз на квартал", 10));
            answers.Add(new Answers("3. щомісячно", 15));
            answers.Add(new Answers("4. авансово", 15));
            questions.Add(new Qij(3, 2, "Погашення процентів за кредитом проводиться:", new List<Answers>(answers), 15));

            answers.Add(new Answers("1. менше 0,8", 5));
            answers.Add(new Answers("2. від 0,8 до 1", 10));
            answers.Add(new Answers("3. 1", 15));
            answers.Add(new Answers("4. більше 1", 25));
            questions.Add(new Qij(3, 3, "Коефіцієнт забезпеченості за кредитами:", new List<Answers>(answers), 15));

            KCollection.Add(new Gi("Умови кредитування позичальника", 3, new List<Qij>(questions)));
            questions.Clear();
            answers.Clear();

            //--------------------

            answers.Add(new Answers("1. 20% від боргу", 5));
            answers.Add(new Answers("2. тільки на відсотки", 10));
            answers.Add(new Answers("3. тільки на основну суму боргу", 20));
            answers.Add(new Answers("4. на всю суму", 25));
            questions.Add(new Qij(4, 1, "Порука підприємства:", new List<Answers>(answers), 20));

            answers.Add(new Answers("1. не має", 10));
            answers.Add(new Answers("2. менше суми основного боргу", 15));
            answers.Add(new Answers("3. еквівалент основного боргу та відсотків", 25));
            answers.Add(new Answers("4. авансово", 35));
            questions.Add(new Qij(4, 2, "Наявність депозитів:", new List<Answers>(answers), 15));

            answers.Add(new Answers("1. не має", 0));
            answers.Add(new Answers("2. понад 50% від суми заборгованості за кредитами", 10));
            answers.Add(new Answers("3. на суму заборгованості за кредитами", 20));
            answers.Add(new Answers("4. на суму заборгованості за кредитом та процентів, що підлягають сплаті за наступні 2 місяця", 30));
            questions.Add(new Qij(4, 3, "Нерухоме майно заставною вартістю:", new List<Answers>(answers), 20));

            answers.Add(new Answers("1. не має", 0));
            answers.Add(new Answers("2. понад 50% від суми заборгованості за кредитами", 20));
            answers.Add(new Answers("3. на суму заборгованості за кредитами", 30));
            answers.Add(new Answers("4. на суму заборгованості за кредитом та процентів, що підлягають сплаті за наступні 2 місяця", 35));
            questions.Add(new Qij(4, 4, "Транспортні засоби:", new List<Answers>(answers), 20));

            KCollection.Add(new Gi("Забезпечення кредиту", 4, new List<Qij>(questions)));
            questions.Clear();
            answers.Clear();

            //--------------------

            answers.Add(new Answers("1. негативна, але заборгованість погашена", 5));
            answers.Add(new Answers("2. тільки прострочені відсотки", 10));
            answers.Add(new Answers("3. не має", 20));
            answers.Add(new Answers("4. позитивна", 25));
            questions.Add(new Qij(5, 1, "Кредитна історія:", new List<Answers>(answers), 20));

            answers.Add(new Answers("1. ймовірність зменшення", 5));
            answers.Add(new Answers("2. стабільно без змін", 15));
            answers.Add(new Answers("3. ймовірність збільшення", 25));
            answers.Add(new Answers("4. ймовірність збільшення у 2 рази", 35));
            questions.Add(new Qij(5, 2, "Перспективність зростання доходу:", new List<Answers>(answers), 15));

            KCollection.Add(new Gi("Кредитна історія та перспективи збільшення доходу", 5, new List<Qij>(questions)));
            questions.Clear();
            answers.Clear();
        }
    }
}
