/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using sones.GraphDB.TypeSystem;

namespace sones.GraphDB.ErrorHandling
{
    /// <summary>
    /// The exception that is thrown, if a vertex type is added, but it contains duplicated attribute names.
    /// </summary>
    public sealed class DuplicatedAttributeNameException: AGraphDBVertexAttributeException
    {
        /// <summary>
        /// The name of the attribute, that is tried to be added multiple times.
        /// </summary>
        public string DuplicatedName { get; private set; }

        /// <summary>
        /// The vertex type predefinition that contains a duplicated attribute name.
        /// </summary>
        public ATypePredefinition Predefinition { get; private set; }

        /// <summary>
        /// Creates a new instance of DuplicatedTypeNameException.
        /// </summary>
        /// <param name="myTypeName">The name of the type, that is tried to be added multiple times.</param>
        public DuplicatedAttributeNameException(ATypePredefinition myTypePredefinition, String myTypeName, Exception innerException = null)
			: base(innerException)
        {
            Predefinition = myTypePredefinition;
            DuplicatedName = myTypeName;

            _msg = string.Format("The attribute {0} was declared multiple times on type {1}.", DuplicatedName, Predefinition.TypeName);
        }

    }
}
