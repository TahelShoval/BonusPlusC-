using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using System.Web.Http.Cors;
namespace BonusPlus.Controllers
{
    [RoutePrefix("api/Employers")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployersController : ApiController
    {
        // GET: api/Employers
        [HttpGet]
        [Route("GetAllEmployers")]
        public List<DTO.EmployersDTO> GetAllEmployers()
        {
            return BL.EmployersBL.GetAllEmployers();
        }

        //GET: api/Employers/5
        [HttpGet]
        [Route("GetEmployerById/{id}")]
        public DTO.EmployersDTO GetEmployerById(int id)
        {
            return BL.EmployersBL.GetEmployerById(id);
        }

        //GET: api/Employers/5
        [HttpGet]
        [Route("GetEmployerByUserName/{userName}")]
        public DTO.EmployersDTO GetEmployerByUserName(string userName)    
        {
            return BL.EmployersBL.GetEmployerByUserName(userName);
        }

        // GET: api/Employers/email
        [HttpGet]
        [Route("GetEmployerByEmail/{email}")]
        public DTO.EmployersDTO GetEmploterByEmail(string email)
        {
            return BL.EmployersBL.GetEmployerByEmail(email);
        }

        [HttpDelete]
        [Route("passwordReset/{email}")]
        public void sendEmail(string email)
        {
            DTO.EmployersDTO employer = GetEmploterByEmail(email);


            Random r = new Random();
            string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string newPassword = "";

            for (int i = 0; i < 8; i++)
            {
                int x = r.Next(str.Length);
                newPassword += str[x];
            }

            employer.EmployerPassword = newPassword;

            Put(employer);

            email = email.Replace("{}", ".");
            email = email.Replace("[]", "@");
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string from = "servicebonusplus@gmail.com";
            string password = "Se94Bo75Ps1!";
            string to = email;
            string subject = " שחזור סיסמא לאתר " + " Bonus Plus  ";
            string body = "<h2> שלום " + employer.CompanyName + " </h2>" +
                "<h3>" + "קיבלנו בקשה לאפס את הסיסמא המקושרת לכתובת מייל זו <br><br>" +
                " להלן סיסמתך החדשה: " + newPassword + "<br><br> " +
                "בברכה, <br> Bonus Plus" + "</h3>";
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

        //POST: api/Employers
        [HttpPost]
       [Route("PostEmployer")]
        public void Post(DTO.EmployersDTO employersDTO)
        {
            BL.EmployersBL.PostEmployer(employersDTO);
        }

        //PUT: api/Employers/5
        [HttpPut]
        [Route("PutEmployer")]
        public void Put(DTO.EmployersDTO employersDTO)
        {
            BL.EmployersBL.PutEmployer(employersDTO);
        }

        //DELETE: api/Employers/5
        [HttpDelete]
        [Route("DeleteEmployer/{id}")]
        public void Delete(int id)
        {
            BL.EmployersBL.DeleteEmployer(id);
        }
    }
}
