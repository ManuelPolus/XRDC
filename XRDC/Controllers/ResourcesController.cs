using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using XRDC.DemandManagement;
using XRDC.Models;
using XRDC.Models.Resources;
using XRDC.Utilities;

namespace XRDC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            //TODO delete fake resources 
            List<Resource> result = new List<Resource>();

            result.Add(new Light {Id=1,Name="lampe du salon",OnOff=false });
            result.Add(new Music { Id = 2, Name = "boombox", OnOff = false, Playing=false });

            ((Light) result[0]).Switch();

            try
            {
                Request.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                //TODO actual request
                if (result.Count ==0)
                    return StatusCode(404, "nothing was found");

                return Ok(result);
            }
            catch (Exception e)
            {
                ErrorLaucher.Display(e);
                return StatusCode(500, "Internal Error");
            }
        }

        [HttpPost]
        [Route("/api/resources/{request}")]
        public IActionResult Post(string request)
        {
            Request.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            try
            {
                if(request == ""|| request == null)
                    return StatusCode(400, "the request is empty");

                return DemandAnalyzer.AnalyzeAndExecute(request) ? StatusCode(200,"Request made") : StatusCode(500, "Network Error");  
            }
            catch (JsonSerializationException jsonex)
            {
                ErrorLaucher.Display(jsonex);
                return StatusCode(500, "Internal Error. Request format is not valid");
            }
            catch (Exception e)
            {
                ErrorLaucher.Display(e);
                return StatusCode(500, "Internal Error");
            }
        }

    }
}