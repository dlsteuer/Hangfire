﻿// This file is part of HangFire.
// Copyright © 2013 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with HangFire.  If not, see <http://www.gnu.org/licenses/>.

namespace HangFire.Filters
{
    /// <summary>
    /// Defines members that specify the order of filters and 
    /// whether multiple filters are allowed.
    /// </summary>
    public interface IJobFilter
    {
        /// <summary>
        /// When implemented in a class, gets or sets a value 
        /// that indicates whether multiple filters are allowed.
        /// </summary>
        bool AllowMultiple { get; }

        /// <summary>
        /// When implemented in a class, gets the filter order.
        /// </summary>
        int Order { get; }
    }
}