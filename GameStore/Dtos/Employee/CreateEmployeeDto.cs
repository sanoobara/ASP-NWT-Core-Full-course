using System;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Dtos;

public record class CreateEmployeeDto(

    
    [Required][StringLength(30)] string name,
    [Required][StringLength(30)] string surname,
    DateTime dayOfBorn,
    [Required][StringLength(30)] string vocation
);

