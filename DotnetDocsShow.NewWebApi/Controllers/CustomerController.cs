


namespace Structured.ControllerBasedAPI.Controllers;

[ApiController]
[Route("customers")]
public class CustomerController : Controller
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet("")]
    public IActionResult GetAll()
    {
        var customer = _customerRepository.GetAll();
        return Ok(customer);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var customer = _customerRepository.GetById(id);
        return Ok(customer);
    }

    [HttpPost("")]
    public IActionResult Create([FromBody] Customer customer)
    {
        _customerRepository.Create(customer);
        return Created($"/customers/{customer.Id}", customer);

    }


    [HttpPut("")]
    public IActionResult Update([FromRoute] Guid id, [FromBody] Customer updateCustomer)
    {
        var customer = _customerRepository.GetById(id);
        if (customer is null)
        {
            return NotFound();
        }
        _customerRepository.Update(updateCustomer);
        return Ok(updateCustomer);


    }

    [HttpDelete("{id:guid}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        _customerRepository.Delete(id);
        return Ok();
    }

}

