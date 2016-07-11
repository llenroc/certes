﻿using System;

namespace Certes.AspNet
{
    public class SslBinding
    {
        public string HostName { get; set; }
        public string CertificateThumbprint { get; set; }
        public DateTimeOffset CertificateExpires { get; set; }
    }
}