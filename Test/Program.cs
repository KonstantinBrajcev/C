using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Accord.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;

class Program
{
    static void Main()
    {
        // Загрузка данных для обучения из файла train.txt
        var trainData = new StreamReader("train.txt");
        var X_train = new List<string>();
        var Y_train = new List<string>();
        string line;
        while ((line = trainData.ReadLine()) != null)
        {
            var parts = line.Split('\t');
            X_train.Add(parts[0]);
            Y_train.Add(parts[1]);
        }
        trainData.Close();

        // Преобразование текстовых признаков в числовые с помощью TF-IDF
        var vectorizer = new TfidfVectorizer();
        var X_train_transformed = vectorizer.FitTransform(X_train.ToArray());

        // Преобразование меток в числовой формат
        var labelEncoder = new LabelEncoder();
        var Y_train_transformed = labelEncoder.FitTransform(Y_train.ToArray());

        // Нормализация признаков
        var scaler = new MaxAbsScaler();
        var X_train_normalized = scaler.FitTransform(X_train_transformed);

        // Обучение модели логистической регрессии
        var teacher = new LogisticRegressionTeacher();
        var model = teacher.Learn(X_train_normalized, Y_train_transformed);

        // Загрузка данных для вывода предсказаний из файла test.txt
        var testData = new StreamReader("test.txt");
        var X_test = new List<string>();
        while ((line = testData.ReadLine()) != null)
        {
            X_test.Add(line);
        }
        testData.Close();

        // Преобразование текстовых признаков в числовые с помощью TF-IDF
        var X_test_transformed = vectorizer.Transform(X_test.ToArray());

        // Нормализация признаков
        var X_test_normalized = scaler.Transform(X_test_transformed);

        // Предсказание на тестовых данных
        var Y_pred = model.Decide(X_test_normalized);

        // Обратное преобразование числовых меток в исходный формат
        var predicted_labels = labelEncoder.InverseTransform(Y_pred);

        // Сохранение предсказаний в файл output.txt
        using (var outputFile = new StreamWriter("output.txt"))
        {
            foreach (var label in predicted_labels)
            {
                outputFile.WriteLine(label);
            }
        }

        Console.WriteLine("Прогнозы сохранены в output.txt.");
    }
}