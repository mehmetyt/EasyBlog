using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBlog.Areas.Admin.Controllers
{
	[Authorize(Roles = "Administrator")]
	[Area("Admin")]

	public abstract class AdminBaseController : Controller
	{

	}
}
