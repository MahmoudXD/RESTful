using System;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
	[Route("/")]
	[ApiController]
	public class RootController: ControllerBase
	{
		[HttpGet(Name = nameof(GetRoot))]
		public IActionResult GetRoot()
		{
			var respone = new
			{
				href = Url.Link(nameof(GetRoot), null)
			};

			return Ok(respone);
		}
	}
}

