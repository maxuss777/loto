﻿
namespace LottoStatisticsAnalyzer.Domain
{
    public class Drop
    {
        public int Value { get; set; }
        public int Next { get; set; }
        public int Previous { get; set; }
        public double Diff { get; set; }
    }
}