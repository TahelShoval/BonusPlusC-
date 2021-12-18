using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json.Linq;
using System.Collections;


namespace BonusPlus.Controllers
{

    [RoutePrefix("api/Workers")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class WorkersController : ApiController
    {
        // GET: api/Workers
        [HttpGet]
        [Route("GetAllWorkers")]
        public List<DTO.WorkersDTO> GetAllWorkers()
        {
            return BL.WorkersBL.GetAllWorkers();
        }

        // GET: api/Workers/id
        [HttpGet]
        [Route("GetWorkerById/{id}")]
        public DTO.WorkersDTO GetWorkerById(int id)
        {
            return BL.WorkersBL.GetWorkerById(id);
        }

        // GET: api/Workers/employerID
        [HttpGet]
        [Route("GetWorkersByEmployerId/{employerId}")]
        public List<DTO.WorkersDTO> GetWorkersByEmployerId(int employerId)
        {
            return BL.WorkersBL.GetWorkersByEmployerId(employerId);
        }

        // GET: api/Workers/userName
        [HttpGet]
        [Route("GetWorkerByUserName/{userName}")]
        public DTO.WorkersDTO GetWorkerByUserName(string userName)
        {
            return BL.WorkersBL.GetWorkerByUserName(userName);
        }

        // GET: api/Workers/email
        [HttpGet]
        [Route("GetWorkerByEmail/{email}")]
        public DTO.WorkersDTO GetWorkerByEmail(string email)
        {
            return BL.WorkersBL.GetWorkerByEmail(email);
        }

        [HttpGet]
        [Route("sendEmail/{email}")]
        public void sendEmail(string email)
        {
            email = email.Replace("{}", ".");
            email = email.Replace("[]", "@");
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string from = "servicebonusplus@gmail.com";
            string password = "Se94Bo75Ps1!";
            string to = email;
            string subject = "שחזור סיסמא לאתר";
            string body = "<h2>משתמש/ת יקר/ה</h2> <br>" +
                "קיבלנו בקשה לאפס את הסיסמא המקושרת לכתובת מייל זו";
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(from, password);
                    smtp.EnableSsl = enableSSL;
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        // POST: api/Workers
        [HttpPost]
        [Route("PostWorker")]
        public void Post(DTO.WorkersDTO workerDTO)
        {
            BL.WorkersBL.PostWorker(workerDTO);
        }

        // PUT: api/Workers/5
        [HttpPut]
        [Route("PutWorker")]
        public void Put(DTO.WorkersDTO workersDTO)
        {
            BL.WorkersBL.PutWorker(workersDTO);
        }

        // DELETE: api/Workers/5
        [HttpDelete]
        [Route("DeleteWorker/{id}")]
        public void DeleteWorker(int id)
        {
            BL.WorkersBL.DeleteWorker(id);
        }
    }
}
