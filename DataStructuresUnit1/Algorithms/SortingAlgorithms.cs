using System.Diagnostics;

namespace DataStructuresUnit1.Algorithms;

/// <summary>Instrumented results of one sorting run.</summary>
public readonly record struct SortMetrics(long Comparisons, long Assignments, double ElapsedMilliseconds);

/// <summary>
/// Two algorithms that solve the SAME problem (sorting an array of integers):
///  - Bubble Sort: time O(n^2), extra space O(1) (in place).
///  - Merge Sort : time O(n log n), extra space O(n) (auxiliary buffer).
/// Both count their comparisons and assignments so the theory can be checked against real data.
/// </summary>
public static class SortingAlgorithms
{
    private sealed class OperationCounter
    {
        public long Comparisons;
        public long Assignments;
    }

    // ---------------------------------------------------------------------
    // Bubble Sort (optimized with an early-exit flag)
    // ---------------------------------------------------------------------
    public static SortMetrics BubbleSort(int[] data)
    {
        var counter = new OperationCounter();
        var stopwatch = Stopwatch.StartNew();

        int n = data.Length;
        for (int pass = 0; pass < n - 1; pass++)
        {
            bool swapped = false;

            for (int j = 0; j < n - 1 - pass; j++)
            {
                counter.Comparisons++;

                if (data[j] > data[j + 1])
                {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                    counter.Assignments += 3; // a swap = 3 assignments (temp, left, right)
                    swapped = true;
                }
            }

            // If no swap happened the array is already sorted: best case O(n).
            if (!swapped)
            {
                break;
            }
        }

        stopwatch.Stop();
        return new SortMetrics(counter.Comparisons, counter.Assignments, stopwatch.Elapsed.TotalMilliseconds);
    }

    // ---------------------------------------------------------------------
    // Merge Sort (top-down, one auxiliary buffer of n elements)
    // ---------------------------------------------------------------------
    public static SortMetrics MergeSort(int[] data)
    {
        var counter = new OperationCounter();
        var stopwatch = Stopwatch.StartNew();

        if (data.Length > 1)
        {
            int[] buffer = new int[data.Length]; // O(n) extra memory
            MergeSortRecursive(data, buffer, 0, data.Length - 1, counter);
        }

        stopwatch.Stop();
        return new SortMetrics(counter.Comparisons, counter.Assignments, stopwatch.Elapsed.TotalMilliseconds);
    }

    private static void MergeSortRecursive(int[] data, int[] buffer, int left, int right, OperationCounter counter)
    {
        if (left >= right)
        {
            return;
        }

        int middle = left + (right - left) / 2;
        MergeSortRecursive(data, buffer, left, middle, counter);
        MergeSortRecursive(data, buffer, middle + 1, right, counter);
        Merge(data, buffer, left, middle, right, counter);
    }

    private static void Merge(int[] data, int[] buffer, int left, int middle, int right, OperationCounter counter)
    {
        int i = left;
        int j = middle + 1;
        int k = left;

        while (i <= middle && j <= right)
        {
            counter.Comparisons++;
            buffer[k++] = data[i] <= data[j] ? data[i++] : data[j++];
            counter.Assignments++;
        }

        while (i <= middle)
        {
            buffer[k++] = data[i++];
            counter.Assignments++;
        }

        while (j <= right)
        {
            buffer[k++] = data[j++];
            counter.Assignments++;
        }

        for (int t = left; t <= right; t++)
        {
            data[t] = buffer[t];
            counter.Assignments++;
        }
    }

    /// <summary>Checks that the array is sorted in ascending order.</summary>
    public static bool IsSorted(int[] data)
    {
        for (int i = 1; i < data.Length; i++)
        {
            if (data[i - 1] > data[i])
            {
                return false;
            }
        }

        return true;
    }
}
