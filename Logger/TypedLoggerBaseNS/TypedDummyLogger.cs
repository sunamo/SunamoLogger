namespace SunamoLogging;


public class TypedDummyLogger : TypedLoggerBase
{
    public static TypedDummyLogger Instance = new TypedDummyLogger();

    private TypedDummyLogger() : base(RuntimeHelper.EmptyDummyMethodLogMessage)
    {

    }


}
