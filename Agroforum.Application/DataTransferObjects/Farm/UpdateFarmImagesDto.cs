﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroforum.Application.DataTransferObjects.Farm
{
    public class UpdateFarmImagesDto
    {
        public Guid FarmId { get; set; }
        public List<byte[]> Images { get; set; }
    }
}