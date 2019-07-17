class MultiColorStream
{
    List<Series<double>> _streams = new List<Series<double>>();
    public MultiColorStream()
    {
    }
    
    public void Add(Series<double> stream)
    {
        _streams.Add(stream);
    }
    
    public void Set(double value, double previous, int index)
    {
        for (int i = 0; i < _streams.Count; ++i)
        {
            if (i == index)
            {
                _streams[i][0] = value;
                _streams[i][1] = previous;
            }
            else
            {
                _streams[i].IsValidDataPoint(0);
                if (_streams[i][2] == 0)
                    _streams[i].IsValidDataPoint(1);
            }
        }
    }
}