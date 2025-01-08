using System;
using GameStore.Data;
using GameStore.Entities;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Endpoints;

public static class EmployeeEndpoints
{
    public static RouteGroupBuilder MapEmployeeEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("employee")
                    .WithParameterValidation();

        group.MapGet("/", (GameStoreContext dbContext) =>
            dbContext.Employees
                            .Select(employee => employee.ToEmployeeSummaryDto())
                            .AsTracking()
                            .ToList());



        return group;
    }

}
