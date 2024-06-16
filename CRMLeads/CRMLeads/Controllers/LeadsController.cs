using CRMLeads.Data;
using CRMLeads.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRMLeads.Controllers
{
    public class LeadsController : Controller
    {
        public IActionResult Index()
        {
            List<LeadsEntity> leads = new List<LeadsEntity>();

            LeadRepository leadRepository = new LeadRepository();

            leads = leadRepository.GetAllLeads();

            return View(leads);
        }

        public IActionResult EditLead(int Id)
        {
            LeadsEntity leads = new LeadsEntity();

            LeadRepository leadRepository = new LeadRepository();

            leads = leadRepository.GetLeadById(Id);

            return View(leads);
        }

        public IActionResult EditLeadDetails(int Id, LeadsEntity leadDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (leadDetails.NextFollowUpDate < leadDetails.LeadDate)
                    {
                        ViewBag.Message = "Follow up date cannot be less than Lead date.";
                        return View("AddLead");
                    }

                    LeadRepository _DbLead = new LeadRepository();

                    if (_DbLead.EditLeadDetails(Id, leadDetails))
                        return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddLead()
        {
            return View();
        }

        public ActionResult DeleteLead()
        {
            return View();
        }

        public ActionResult AddNewLead(LeadsEntity leadDetails) 
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if(leadDetails.NextFollowUpDate < leadDetails.LeadDate)
                    {
                        ViewBag.Message = "Follow up date cannot be less than Lead date.";
                        return View("AddLead");
                    }

                    LeadRepository _DbLead = new LeadRepository();

                    if (_DbLead.AddLead(leadDetails))
                        return RedirectToAction("Index");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
