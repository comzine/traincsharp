class Measurement
{
    private int measId;
    private int SAPNo;
    private int durationSec;
    private string date;
    private string timeStart;
    private string op;
    private int machineId;

    private int startHour;
    private int startMinute;
    private int startSecond;


#if WITH_HEADERS
  private static string[] headers = { "MeasID", "SAPNo", "DurationSec", "Date", "TimeStart", "OP", "MachineID" };
#endif
    public Measurement(int measId, int SAPNo, int durationSec, string date, string timeStart, string op, int machineId)
    {
        this.measId = measId;
        this.SAPNo = SAPNo;
        this.durationSec = durationSec;
        this.date = date;
        this.timeStart = timeStart;
        this.op = op;
        this.machineId = machineId;
    }

    public Measurement(string csv)
    {
        string[] parts = csv.Split(';');
        this.measId = int.Parse(parts[0]);
        //this.measId = int.Parse(parts[Array.IndexOf(headers, "MeasId")]);
        this.SAPNo = int.Parse(parts[1]);
        this.durationSec = int.Parse(parts[2]);
        this.date = parts[3];
        this.timeStart = parts[4];
        this.op = parts[5];
        this.machineId = int.Parse(parts[6]);
    }

    public override string ToString()
    {
        return $"{measId}: {durationSec}";
    }

#if WITH_HEADERS
    public static void SetHeaders(string csv)
    {
        string[] parts = csv.Split(';');
        headers = parts;
    }
#endif

    public string ToCSV()
    {
        return $"{measId};{SAPNo};{durationSec};{date};{timeStart};{op};{machineId}";
    }

    private void ParseTimeStart()
    {
        string[] parts = timeStart.Split(':');
        startHour = int.Parse(parts[0]);
        startMinute = int.Parse(parts[1]);
        startSecond = int.Parse(parts[2]);
    }

    public string GetTimeEnd()
    {
        ParseTimeStart();
        int endSecond = startSecond + durationSec;
        int endMinute = startMinute + endSecond / 60;
        endSecond %= 60;
        int endHour = startHour + endMinute / 60;
        endMinute %= 60;
        return $"{endHour}:{endMinute}:{endSecond}";
    }

    public string ToCsvStartEnd()
    {
        return $"{measId};{timeStart};{GetTimeEnd()}";
    }

    public int GetDurationSec()
    {
        return durationSec;
    }
}