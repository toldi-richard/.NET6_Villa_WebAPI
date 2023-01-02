using AutoMapper;

using MagicVilla_API.Controllers.v1;
using MagicVilla_API.Models;
using MagicVilla_API.Models.DTO;
using MagicVilla_API.Repository.IRepository;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

using System.Net;

namespace MagicVilla_API.Controllers.v2;

[Route("api/v{version:apiVersion}/VillaNumberAPI")]
[ApiController]
[ApiVersion("2.0")]
public class VillaNumberAPIController : ControllerBase
{
    protected APIResponse _response;
    private readonly IVillaNumberRepository _dbVillaNumber;
    private readonly IVillaRepository _dbVilla;
    private IStringLocalizer<VillaAPIController> _stringLocalizer;
    private readonly ILogger<VillaAPIController> _logger;
    //private readonly ILogging _logger;  -> custom logolás
    private readonly IMapper _mapper;

    public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IVillaRepository dbVilla, IStringLocalizer<VillaAPIController> villaAPI,
        ILogger<VillaAPIController> logger /* ILogging logger */, IMapper mapper)
    {
        _dbVillaNumber = dbVillaNumber;
        _dbVilla = dbVilla;
        _stringLocalizer = villaAPI;
        _logger = logger;
        _mapper = mapper;
        _response = new();
    }

    //[MapToApiVersion("2.0")]
    [HttpGet("GetString")]
    public IEnumerable<string> Get()
    {
        return new string[] { "Valami", "Akármi" };
    }
}

