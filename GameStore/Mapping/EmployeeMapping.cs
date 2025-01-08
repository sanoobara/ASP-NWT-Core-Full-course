using System;
using GameStore.Dtos;
using GameStore.Dtos.Employee;
using GameStore.Entities;

namespace GameStore.Mapping;

public static class EmployeeMapping
{
    
   public static EmployeeSummaryDto ToEmployeeSummaryDto(this Employee employee){
    return new (
        employee.id,
        employee.name,
        employee.surname,
        employee.dayOfBorn,
        employee.vocation
    );
   } 
    
    public static Employee ToEntity(this CreateEmployeeDto employee){
        return new Employee()
        {
            name = employee.name,
            surname = employee.surname,
            dayOfBorn = employee.dayOfBorn,
            vocation = employee.vocation            
        };
    }

    

}
