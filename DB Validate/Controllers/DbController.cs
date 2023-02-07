using AutoMapper;
using DB_Validate.Data;
using DB_Validate.Data.Dtos;
using DB_Validate.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_Validate.Controller;

[ApiController]
[Route("[Controller]")]

public class DbController : ControllerBase
{

    private DbvalidateContext _context;
    private IMapper _mapper;

    public DbController(DbvalidateContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdcionaDbValidate(
        [FromBody] CreateUserDto dbvalidateDto)
    {
        dbvalidate dbvalidate = _mapper.Map<dbvalidate>(dbvalidateDto);

        _context.dbvalidates.Add(dbvalidate);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecouppdbvalidateId), 
            new { id = dbvalidate.Id }, 
                dbvalidate);
    }
    [HttpGet]
    public IEnumerable<dbvalidate> ConsultDbvalidates([FromBody] int skip = 0, int take = 25)
    {
        return _context.dbvalidates.Skip(skip).Take(take);
    }
    [HttpGet("{id}")]
    public IActionResult RecouppdbvalidateId(int id)
    {
        var dbvalidate = _context.dbvalidates
            .FirstOrDefault(dbvalidate => dbvalidate.Id == id);
        if (dbvalidate == null) 
            return NotFound();
            return Ok(dbvalidate);
    }
}
