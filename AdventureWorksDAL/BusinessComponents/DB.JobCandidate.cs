using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class  AdventureWorksDataContext
    {

        public List<JobCandidate> JobCandidateList()
        {
            var getJobCandidate = Execute<List<JobCandidate>>(dal =>
            {
                var item = dal.JobCandidate.Skip(0).Take(100);
                return item.ToList();
            });
            return getJobCandidate;
        }

        public List<JobCandidate> JobCandidateListAll()
        {
            var getJobCandidate = Execute<List<JobCandidate>>(dal =>
            {
                var item = dal.JobCandidate;
                return item.ToList();
            });
            return getJobCandidate;
        }

        public bool JobCandidateUpdate(JobCandidate jobcandidate)
        {
            return Execute<bool>(dal =>
           {
               JobCandidate jobcandidateUpdate = dal.JobCandidate.Where(x => x.JobCandidateID == jobcandidate.JobCandidateID).FirstOrDefault();
               if (jobcandidateUpdate != null)
               {
                   jobcandidateUpdate.JobCandidateID = jobcandidate.JobCandidateID;
                   jobcandidateUpdate.BusinessEntityID = jobcandidate.BusinessEntityID;
                   jobcandidateUpdate.Resume = jobcandidate.Resume;
                   jobcandidateUpdate.ModifiedDate = jobcandidate.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool JobCandidateAdd(JobCandidate jobcandidate)
        {
            return Execute<bool>(dal =>
            {
                JobCandidate jobcandidateAdd = dal.JobCandidate.Where(x => x.JobCandidateID == jobcandidate.JobCandidateID).FirstOrDefault();
                if (jobcandidateAdd != null)
                {
                    dal.JobCandidate.InsertOnSubmit(jobcandidateAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool JobCandidateDelete(JobCandidate jobcandidate)
        {
            return Execute<bool>(dal =>
            {
                JobCandidate jobcandidateDelete = dal.JobCandidate.Where(x => x.JobCandidateID == jobcandidate.JobCandidateID).FirstOrDefault();
                if (jobcandidateDelete != null)
                {
                    dal.JobCandidate.DeleteOnSubmit(jobcandidateDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}
