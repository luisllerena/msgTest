﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mgcTest.DTO
{
    public class ResponseDTO<T>
    {
        public int code { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
