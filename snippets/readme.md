# Snippets

## Signaler

Signals an alert: sound, email and debug print.

## MultiColorStream

Stream coloring.

Usage

    MultiColorStream output;

    protected override void OnStateChange()
    {
        if (State == State.DataLoaded)
        {
            output = new MultiColorStream();
            output.Add(Values[1]);
            output.Add(Values[2]);
            output.Add(Values[3]);
            output.Add(Values[4]);
        }
    }

    protected override void OnBarUpdate()
    {
        output.Set(val[0], val[1], IsUp() ? 0 : 1);
    }