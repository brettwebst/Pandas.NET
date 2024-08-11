using System;
using System.Collections.Generic;
using System.Linq;
using PandasNet;

namespace Pandas.Test;

public class DataFrameTailTests
{
    [Fact]
    public void TestTailMethod()
    {
        // Arrange
        var seriesList = new List<Series>()
        {
            new Series(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new Column { Name = "column1", DType = typeof(float) }),
            new Series(new float[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, new Column { Name = "column2", DType = typeof(float) })
        };
        var dataFrame = new DataFrame(seriesList);


        // Act
        var tailDataFrame = dataFrame.tail(3);

        // Assert
        Assert.True(tailDataFrame["column1"].data.OfType<float>().ToArray().SequenceEqual(new float[] { 8, 9, 10 }));
        Assert.True(tailDataFrame["column2"].data.OfType<float>().ToArray().SequenceEqual(new float[] { 18, 19, 20 }));
    }

    [Fact]
    public void TestTailMethodDefault()
    {
        // Arrange
         var seriesList = new List<Series>()
        {
            new Series(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new Column { Name = "column1", DType = typeof(float) }),
            new Series(new float[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, new Column { Name = "column2", DType = typeof(float) })
        };
        var dataFrame = new DataFrame(seriesList);

        // Act
        var tailDataFrame = dataFrame.tail();

        // Assert
        Assert.True(tailDataFrame["column1"].data.OfType<float>().ToArray().SequenceEqual(new float[] { 6, 7, 8, 9, 10 }));
        Assert.True(tailDataFrame["column2"].data.OfType<float>().ToArray().SequenceEqual(new float[] { 16, 17, 18, 19, 20 }));
    }
}