using System;

class GradeCalculator
{
    static void Main()
    {
        int dbModuleMax = 22;
        int softwareDevModuleMax = 38;
        int softwareMaintenanceModuleMax = 20;
        int totalScore = 0;

        totalScore += GetModuleScore("Разработка, администрирование и защита баз данных", dbModuleMax);
        totalScore += GetModuleScore("Разработка модулей программного обеспечения для компьютерных систем", softwareDevModuleMax);
        totalScore += GetModuleScore("Сопровождение и обслуживание программного обеспечения компьютерных систем", softwareMaintenanceModuleMax);

        Console.WriteLine($"Общая сумма баллов: {totalScore}");
        Console.WriteLine($"Оценка по 5-бальной шкале: {GetGrade(totalScore)}");
    }

    static int GetModuleScore(string moduleName, int moduleMaxScore)
    {
        Console.WriteLine($"Введите баллы за модуль '{moduleName}' (максимум {moduleMaxScore}): ");
        int score = int.Parse(Console.ReadLine());
        return Math.Min(score, moduleMaxScore);
    }

    static string GetGrade(int totalScore)
    {
        if (totalScore >= 56) return "5 (отлично)";
        if (totalScore >= 32) return "4 (хорошо)";
        if (totalScore >= 16) return "3 (удовлетворительно)";
        return "2 (неудовлетворительно)";
    }
}
