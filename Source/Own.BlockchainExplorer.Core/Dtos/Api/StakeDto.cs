﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Own.BlockchainExplorer.Core.Dtos.Api
{
    public class StakeDto
    {
        public string StakerAddress { get; set; }
        public string ValidatorAddress { get; set; }
        public decimal Amount { get; set; }
    }
}
