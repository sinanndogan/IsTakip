using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.MailParamsClasses
{
  public class MailParams : BaseObject
  {
    public string SenderName { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string EMailAdress { get; set; }

    public string Password { get; set; }
    public string SmtpAdress { get; set; }

    [RegularExpression("^[0-9]*$", ErrorMessage ="{1} sadece rakamdan oluşmalı")]
    public string SmtpPort { get; set; }
    public bool SSLKullan { get; set; }
  }
}
