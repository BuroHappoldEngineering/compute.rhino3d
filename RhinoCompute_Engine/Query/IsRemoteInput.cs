/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Grasshopper.Kernel;
//using BH.UI.Grasshopper.Components;

namespace BH.Engine.Computing.RhinoCompute
{
    public static partial class Query
    {
        public static bool IsRemoteInput(this IGH_DocumentObject obj)
        {
            return obj.Name == nameof(BH.Engine.Computing.Create.RemoteIN) && (obj?.Category == "BHoM" || obj.GetType().FullName == "Grasshopper.Kernel.Components.GH_PlaceholderComponent");
        }
    }
}

