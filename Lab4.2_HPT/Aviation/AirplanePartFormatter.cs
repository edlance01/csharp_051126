namespace com.ntier.Aviation
{
    internal class AirplanePartFormatter
    {
        // The base method that knows how to format the core part data
        public virtual string GetPartInfo(AirplanePart part)
        {
            return $@"Part Number: {part.PartNumber}
Description: {part.Description}
Price: {part.Price:C}";
        }
    }
}