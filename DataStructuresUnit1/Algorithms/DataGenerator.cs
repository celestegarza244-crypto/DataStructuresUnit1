namespace DataStructuresUnit1.Algorithms;

/// <summary>Creates the input arrays used by the algorithm comparison.</summary>
public static class DataGenerator
{
    public const int RandomScenario = 0;
    public const int SortedScenario = 1;
    public const int ReversedScenario = 2;

    public static int[] Create(int size, int scenario)
    {
        var data = new int[size];

        switch (scenario)
        {
            case SortedScenario:
                for (int i = 0; i < size; i++)
                {
                    data[i] = i;
                }

                break;

            case ReversedScenario:
                for (int i = 0; i < size; i++)
                {
                    data[i] = size - i;
                }

                break;

            default:
                var random = new Random(42); // fixed seed => reproducible results for the report
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next(0, 1_000_000);
                }

                break;
        }

        return data;
    }
}
