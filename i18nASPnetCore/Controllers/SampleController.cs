using i18nASPnetCore.Models;
using i18nASPnetCore.SharedResources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace i18nASPnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IStringLocalizer<SampleController> _localizer;
        private readonly IStringLocalizer<SharedTranslate> _sharedLocalizer;

        public SampleController(IStringLocalizer<SampleController> localizer,
            IStringLocalizer<SharedTranslate> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        [HttpGet]
        public string Get()
        {
            return _localizer["Hello World"];
        }

        [HttpGet("shared")]
        public string GetShared()
        {
            return _sharedLocalizer["Welcome"];
        }

        [HttpPost("model")]
        public string TestModel(SampleViewModel model)
        {
            return "Model is OK";
        }
    }
}
