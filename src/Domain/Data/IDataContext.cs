using System.Collections;

namespace OS.WpfDevExpress.Domain.CsvRopository.Data
{
    public interface IDataContext
    {
        IEnumerable Read();
    }
}