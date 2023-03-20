using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Infra.Data.Repositories;
using ProjetoModeloDDD.MVC.AutoMapper;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientsController : Controller
    {

        //private readonly ClientRepository _clientRepository = new ClientRepository();

        private readonly IClientAppService _clientApp;
        private readonly IMapper _mapper;

        public ClientsController(IMapper mapper, IClientAppService clientApp)
        {
            _mapper = mapper;
            _clientApp = clientApp;
        }


        // GET: ClientsController
        public ActionResult Index()
        {
            //var mapper = new Mapper(AutoMapperConfigurationException);
            //OrderDto dto = mapper.Map<OrderDto>(order);
            var clientViewModel = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetAll());
            return View(clientViewModel);
        }

        public ActionResult SpecialClients()
        {
            //var mapper = new Mapper(AutoMapperConfigurationException);
            //OrderDto dto = mapper.Map<OrderDto>(order);
            var clientViewModel = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetSpecialClients());
            return View(clientViewModel);
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientApp.GetById(id);
            var clientViewModel = _mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientDomain = _mapper.Map<ClientViewModel, Client>(client);
                _clientApp.Add(clientDomain);

                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientApp.GetById(id);
            var clientViewModel = _mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: ClientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clentDomain = _mapper.Map<ClientViewModel, Client>(client);
                _clientApp.Update(clentDomain);
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientApp.GetById(id);
            var clientViewModel = _mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: ClientsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComfirmed(int id)
        {
            var client = _clientApp.GetById(id);
            _clientApp.Remove(client);

            return RedirectToAction("Index");
        }
    }
}
