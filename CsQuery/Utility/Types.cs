﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CsQuery.Utility
{
    /// <summary>
    /// A set of helper methods for analyzing types.
    /// </summary>

    public static class Types
    {
        /// <summary>
        /// Determine if the type is an anonymous type.
        /// </summary>
        ///
        /// <param name="type">
        /// A type/
        /// </param>
        ///
        /// <returns>
        /// true if anonymous type, false if not.
        /// </returns>
        /// <url>http://stackoverflow.com/questions/2483023/how-to-test-if-a-type-is-anonymous.</url>

        public static bool IsAnonymousType(Type type)
        {
            return Attribute.IsDefined(type, typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false)
                && type.IsGenericType && type.Name.Contains("AnonymousType")
                && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
                && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
        }
    }
}
