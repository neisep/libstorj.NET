﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStorj.Wrapper.Contracts.Exceptions
{
    public class ListFilesFailedException : GenericException
    {
        public string BucketId { get; private set; }
        public ListFilesFailedException(string bucketId, int errorCode, string errorMessage) : base(errorCode, errorMessage)
        {
            BucketId = bucketId;
        }
    }
}
