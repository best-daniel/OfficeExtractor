﻿using System;

/*
   Copyright 2013 - 2016 Kees van Spelde

   Licensed under The Code Project Open License (CPOL) 1.02;
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.codeproject.com/info/cpol10.aspx

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

namespace OfficeExtractor.Exceptions
{
    /// <summary>
    ///     Raised when the Microsoft Office file is corrupt
    /// </summary>
    public class OEFileIsCorrupt : Exception
    {
        public OEFileIsCorrupt()
        {
        }

        public OEFileIsCorrupt(string message) : base(message)
        {
        }

        public OEFileIsCorrupt(string message, Exception inner) : base(message, inner)
        {
        }
    }
}