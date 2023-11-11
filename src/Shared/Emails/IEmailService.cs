﻿using Foodtruck.Shared.Quotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Shared.Emails;

public interface IEmailService
{
    Task<bool> SendEmail(string text);
    Task<bool> SendQuotationPdfEmail(string base64, string text);
}
