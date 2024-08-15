using DataAccess.Context;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TicketService : ITicketService
    {
        private readonly JumpInTicketsContext _context;
        public TicketService(JumpInTicketsContext jumpInTicketsContext)
        {
            _context = jumpInTicketsContext;
        }

        public async Task<List<TicketListModel>> List(int DeparmentId, string assignedTo, string status)
        {
            var result = await _context.PR_Ticket_List.FromSqlRaw($"exec pr_Ticket_List @DepartmentId='{DeparmentId}',@AssignedTo = '{assignedTo}', @StatusId = '{status}'").ToListAsync();
            return result.Select(x => new TicketListModel
            {
                AssignedTo = x.AssignedTo,
                CategoryName = x.CategoryName,
                DepartmentName = x.DepartmentName,
                id = x.id,
                DueDate = x.DueDate,
                StatusName = x.StatusName,
                SubCategoryName = x.SubCategoryName,
                TicketDescription = x.TicketDescription,
                TicketTitle = x.TicketTitle,
                PriorityName = x.PriorityName,
                DateCreated = x.DateCreated

            }).ToList();
        }
    }
}
