using PeaceApp.API.Report.Domain.Model.Aggregates;
using PeaceApp.API.Report.Domain.Model.Queries;
using PeaceApp.API.Report.Domain.Repositories;
using PeaceApp.API.Report.Domain.Services;

namespace PeaceApp.API.Report.Application.Internal.QueryServices;

public class ReportManagementQueryService(IReportManagementRepository reportManagementRepository)
    : IReportManagementQueryService
{


    public async Task<ReportManagement> Handle(GetReportByIdQuery query)
    {
        return await reportManagementRepository.FindByIdAsync(query.Id);
    }
    
    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsQuery query)
    {
        return await reportManagementRepository.FindAllReports();
    }
    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsByDateQuery query)
    {
        return await reportManagementRepository.FindAllByDateAsync(query.Date);
    }

    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsByDistrictAndDateQuery query)
    {
        return await reportManagementRepository.FindAllByDistrictAndDateAsync(query.District, query.Date.ToString());
    }

    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsByDistrictQuery query)
    {
        return await reportManagementRepository.FindAllByDistrictAsync(query.District);
    }

    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsByKindOfReportQuery query)
    {
        return await reportManagementRepository.FindAllByKindOfReportAsync(query.KindOfReport);
    }
    public async Task<IEnumerable<ReportManagement>> Handle(GetAllReportsByCitizenIdQuery query)
    {
        return await reportManagementRepository.FindAllByCitizenIdAsync(query.CitizenId);
    }

    public async Task<ReportManagement> Handle(GetReportByIdAndCitizenIdQuery query)
    {
        return await reportManagementRepository.FindReportByIdAndCitizenIdAsync(query.CitizenId, query.Id);
    }

}