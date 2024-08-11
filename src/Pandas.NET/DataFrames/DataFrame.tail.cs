using System.Linq;
using Tensorflow;

namespace PandasNet;

public partial class DataFrame
{
    public DataFrame tail(int n = 5)
    {
        if (n < 0)
        {
            throw new ValueError("n must be >= 0");
        }

        Series testSeries = _data.FirstOrDefault();
        if(testSeries == null)
        {
            return this;
        }

        int rows = testSeries.size;
        if (n > rows)
        {
            n = rows;
        }

        return this[new Slice(start: testSeries.size - n, stop: testSeries.size)];
    }
}
