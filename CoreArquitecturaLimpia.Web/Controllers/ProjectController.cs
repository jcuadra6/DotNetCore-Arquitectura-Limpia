using CoreArquitecturaLimpia.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CoreArquitecturaLimpia.Web.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {

        private IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET: ProjectController
        public ActionResult Index()
        {
            return View(_projectService.GetProjects());
        }
        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
