using System;

namespace GameStore.Dtos.Employee;

public record class EmployeeSummaryDto(
    int id,
    string name,
    string surname,
    DateTime dayOfBorn,
    string vocation
);

