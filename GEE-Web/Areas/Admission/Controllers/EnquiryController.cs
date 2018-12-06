using GEE.Web.Service;
using GEE.Web.ViewModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GEE_Web.Areas.Admission.Controllers
{
    public class EnquiryController : Controller
    {
        EnquiryService service = new EnquiryService();

        public async Task<ActionResult> Index()
        {
            var list = await service.GetAll();
            return View(list);
        }

        public async Task<ActionResult> Details(int id)
        {
            var record = await service.GetById(id);
            return View(record);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(EnquiryViewModel collection)
        {
            try
            {
                var stringContent = new StringContent(JsonConvert.SerializeObject(collection).ToString(), Encoding.UTF8, "application/json");
                var status = await service.Save(stringContent);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            var record = await service.GetById(id);
            return View(record);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EnquiryViewModel collection)
        {
            try
            {

                var stringContent = new StringContent(JsonConvert.SerializeObject(collection).ToString(), Encoding.UTF8, "application/json");
                var status = await service.Update(stringContent);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
