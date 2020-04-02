
public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var m = new int[size, size];

        int left = 0, top = 0;
        int right = size - 1, bottom = size - 1;
        int n = 1;

        while (left <= right && top <= bottom)
        {
            for (int i = left; i <= right; i++)
                m[top, i] = n++;
            top++;

            for (int i = top; i <= bottom; i++)
                m[i, right] = n++;
            right--;

            for (int i = right; i >= left; i--)
                m[bottom, i] = n++;
            bottom--;

            for (int i = bottom; i >= top; i--)
                m[i, left] = n++;
            left++;
        }

        return m;
    }
}
