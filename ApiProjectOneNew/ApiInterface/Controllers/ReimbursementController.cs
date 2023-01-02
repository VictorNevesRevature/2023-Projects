using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace ApiInterface.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReimbursementController : ControllerBase
    {
        

        //private readonly ILogger<ReimbursementController> _logger;

        //public ReimbursementController(ILogger<ReimbursementController> logger)
        //{
        //   _logger = logger;
        //}

        /// <summary>
        /// Posting new employee to the database
        /// returns the created customer if successful
        /// otherwisem null
        /// </summary>
        /// 

    private readonly IBusPostEmployee? _ibus;
    private readonly IGettingEmployeeInfo? _ibusinfo;

    public ReimbursementController(IBusPostEmployee ibus, IGettingEmployeeInfo ibusinfo) //dependency injection
    {
        this._ibus= ibus;
        this._ibusinfo = ibusinfo;
    }

    

   

    [HttpPost("Creating Employee")]
    public ActionResult<Employee> PostEmployee(Employee emp)
    {
        //call business layer method
        //if(ModelState.IsValid)
       // {
            //Employee emp1 = this._ibus!.PostEmployee(emp);
        //}
        //else
        //{
            //return NotFound("Model binding failed");
        //}
        //return what bus layer returned to this calling method
        //return Created("link",emp);

        //in ($"https://localhost:7007/api/pokemon/getcustomer/{c.customerId}",c)

        return _ibus!.PostEmployee(emp);
    }

    //[HttpPost("Getting single employee")]
    //public ActionResult<Employee> LoginEmployee(Employee emp)
    


    [HttpGet("Get All Employee Info")]
    public ActionResult<List<Employee>> GettingEmployeeInfo()
    {

        return _ibusinfo!.BusGettingEmployeeInfo();
    }
}}