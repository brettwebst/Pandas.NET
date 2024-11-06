using Xunit;
using PandasNet;
using Tensorflow.NumPy;
using System.Collections.Generic;

namespace Pandas.Test;
public class DataFrameTests
{
    [Fact]
    public void TestToNumpyMethod()
    {
        // Arrange
        var seriesList = new List<Series>(){
            new Series(new float[] { 1, 2, 3 }, new Column { Name = "column1", DType = typeof(float) }),
            new Series(new float[] { 4, 5, 6 }, new Column { Name = "column2", DType = typeof(float) })
        };
        var dataFrame = new DataFrame(seriesList);

        // Act
        NDArray numpyArray = dataFrame.to_numpy();

        // Assert
        Assert.Equal(3, numpyArray.shape[0]); // Number of rows
        Assert.Equal(2, numpyArray.shape[1]); // Number of columns
        Assert.Equal(1.0f, (float)numpyArray[0, 0]);
        Assert.Equal(2.0f, (float)numpyArray[1, 0]);
        Assert.Equal(3.0f, (float)numpyArray[2, 0]);
        Assert.Equal(4.0f, (float)numpyArray[0, 1]);
        Assert.Equal(5.0f, (float)numpyArray[1, 1]);
        Assert.Equal(6.0f, (float)numpyArray[2, 1]);
    }
}