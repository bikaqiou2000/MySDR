using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySDR.Model;
using MySDR.Web.Models;

namespace MySDR.Web.API
{
    public class ParcelPlanController : ApiController
    {
        private ParcelPlan plan;
        public ParcelPlanController()
        {
            plan = new ParcelPlan();
        }
        // POST: api/ParcelPlan
        public PlanResponse Post(PlanRequest input)
        {
            var res = new PlanResponse();
            try
            {
                plan.InputStr = input.inputStr;
                plan.WorkPlan();
                res.Packs = plan.ShowSdrPlan();
                res.Delays = plan.ShowDelaySdrs();
                res.Success = true;
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.ErrMsg = "Opps!...出错了 :(";
            }
            return res;
        }

    }
}
