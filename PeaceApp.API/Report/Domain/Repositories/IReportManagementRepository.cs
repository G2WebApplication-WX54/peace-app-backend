using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Shared.Domain.Repositories;

namespace PeaceApp.API.Report.Domain.Repositories;

public interface IReportManagementRepository : IBaseRepository<ReportManagement>
{
    Task<IEnumerable<ReportManagement>> FindAllByDistrictAsync(string district);
    Task<IEnumerable<ReportManagement>> FindAllByKindOfReportAsync(string kindOfReport);
    Task<IEnumerable<ReportManagement>> FindAllByDateAsync(DateTimeOffset date);
    Task<IEnumerable<ReportManagement>> FindAllByDistrictAndDateAsync(string district, DateTimeOffset date);
}