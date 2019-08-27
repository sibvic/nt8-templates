    public enum SmoothingType
	{
		DoNotUse,
		DEMA,
		EMA,
		HMA,
		SMA,
		TEMA,
		TMA,
		VWMA,
		WMA,
		ZLEMA
	}

    Indicator CreateMA(SmoothingType method, ISeries<double> source, int period)
    {
        switch (method) {
            case SmoothingType.EMA: {
                return EMA(source, period);
            }
            case SmoothingType.DEMA: {
                return DEMA(source, period);
            }
            case SmoothingType.HMA: {
                return HMA(source, period);
            }
            case SmoothingType.SMA: {
                return SMA(source, period);
            }
            case SmoothingType.TEMA: {
                return TEMA(source, period);
            }
            case SmoothingType.TMA: {
                return TMA(source, period);
            }
            case SmoothingType.VWMA: {
                return VWMA(source, period);
            }
            case SmoothingType.WMA: {
                return WMA(source, period);
            }
            case SmoothingType.ZLEMA: {
                return ZLEMA(source, period);
            }
            case SmoothingType.DoNotUse:
            	return null;
        }
        return null;
    }