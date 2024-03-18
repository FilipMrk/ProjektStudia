using ChildrenDatabase.Application.ChildrenDatabase;
using ChildrenDatabase.Application.ChildrenDatabase.Commands.CreateChildrenDatabase;
using ChildrenDatabase.Application.ChildrenDatabase.Queries.GetAllChildrenDatabases;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace ChildrenDatabase.MVC.Controllers
{
    public class ChildrenDatabaseController : Controller 
    {
        private readonly IMediator _mediator;

        public ChildrenDatabaseController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        public async Task <IActionResult> Index()
        {
            var childrenDatabases = await _mediator.Send(new GetAllChildrenDatabasesQuery());
            return View(childrenDatabases);
        }
        public IActionResult Create () 
        { 
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateChildrenDatabaseCommand command)
        {
           if(!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
           return RedirectToAction(nameof(Create));
        }
    }
}
