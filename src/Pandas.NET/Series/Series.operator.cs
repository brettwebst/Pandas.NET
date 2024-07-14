﻿using System;
using System.Linq;

namespace PandasNet
{
    public partial class Series
    {
        public static Series operator !=(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x != b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }

        public static Series operator ==(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x == b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }

        public static Series operator *(Series a, Series b)
        {
            if (a.data is float[] float32a && b.data is float[] float32b)
            {
                var data = new float[a.index.size];
                for (var i = 0; i < data.Length; i++)
                    data[i] = float32a[i] * float32b[i];
                return new Series(data);
            }
            else if (a.data is double[] float64a && b.data is double[] float64b)
            {
                var data = new double[a.index.size];
                for (var i = 0; i < data.Length; i++)
                    data[i] = float64a[i] * float64b[i];
                return new Series(data);
            }
            throw new NotImplementedException("");
        }

        public static Series operator +(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x + b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }

        public static Series operator -(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x - b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }

        public static Series operator *(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x * b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }

        public static Series operator /(Series a, double b)
        {
            if (a.data is int[] || a.data is float[] || a.data is double[])
            {
                return new Series(a.data.Cast<double>().Select(x => x / b).ToArray()
                    , column: a._column
                    , index: a._index?.copy());
            }

            throw new NotImplementedException("");
        }
    }
}
