﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Extensions;

namespace AdventOfCode
{
    public class Day1
    {
        public readonly string Captcha;

        public Day1(string captcha)
        {
            Captcha = captcha;
        }

        public string GetCaptchaSolution()
        {
            var sum = 0.0;
            var index = 0;
            var reader = Captcha.ToCharArray();

            while(reader.Length > index)
            {
                var digit = reader[index++];
                while (index < reader.Length && reader[index].Equals(digit))
                {
                    index++;
                    sum += Char.GetNumericValue(digit);
                }
            }

            if(reader[0] == reader[reader.Length-1])
                sum += Char.GetNumericValue(reader[0]);

            return sum.ToString(CultureInfo.InvariantCulture);
        }

        public string GetCaptchaHalfwayAroundSolution()
        {
            var sum = 0.0;
            var index = 0;
            var reader = Captcha.ToCharArray();
            var jumpIndex = reader.Length / 2;

            while (reader.Length > index)
            {
                var digit = reader[index];

                var halfwayAround = reader.GetElementHalfWayAround(index, jumpIndex);

                if(digit.Equals(halfwayAround))
                    sum += Char.GetNumericValue(digit);

                index++;
            }

            return sum.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Day 1 of Christmas: Part 1: {GetCaptchaSolution()} and part 2: {GetCaptchaHalfwayAroundSolution()}";
        }
    }
}
