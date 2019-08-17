namespace AppiSimo.Client.Converters
{
    using AppiSimo.Client.Abstract;
    using NodaTime;
    using NodaTime.Text;

    public class LocalTimeConverter : ITypeConverter<LocalTime?>
    {
        // TODO: Create specific converter
        static readonly LocalTimePattern Pattern = LocalTimePattern.CreateWithInvariantCulture("HH:mm");

        public string FormatValueAsString(LocalTime? value) =>
            value.HasValue ? Pattern.Format((LocalTime) value) : string.Empty;

        public bool TryParseValueFromString(string value, out LocalTime? result)
        {
            var success = Pattern.Parse(value).TryGetValue(default, out var r);
            result = r;

            return success;
        }
    }
}