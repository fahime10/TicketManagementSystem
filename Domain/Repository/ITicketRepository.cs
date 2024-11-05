﻿using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;

namespace Domain.Repository
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
        List<Ticket> GetTickets(GetTicketsRequest request);
        List<ChartResponse> Last12MonthsTickets();
        List<ChartResponse> ChartByCategory(string category);
        List<ChartResponse> GetSummary();

        Ticket FindTicketById(int ticketId);
    }
}
