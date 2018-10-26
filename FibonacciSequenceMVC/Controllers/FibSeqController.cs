using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibonacciSequenceMVC.Controllers
{
    public class FibSeqController : Controller
    {
        // GET: FibSeq
        public ActionResult Index()
        {
            int[] nums = new int[20];
            nums[0] = 1;
            nums[1] = 1;

            for (int counter=2; counter<=19; counter++)
            {
                nums[counter] = nums[counter-1] + nums[counter-2];                
            }

            ViewBag.nums = nums;

            return View();
        }
    }
}