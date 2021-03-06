﻿using SDON.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SDON.Model
{
    /// <summary>
    /// Object defining of a column in a data table.
    /// </summary>
    [Serializable]
    public sealed class DataTableColumn : SDONSerializeable
    {
        [DataMember(Name = "Name")]
        [IgnoreIfDefaultValue(Default = null)]
        private string _name = null;

        [DataMember(Name = "Type")]
        [IgnoreIfDefaultValue(Default = null)]
        private string _type = null;

        /// <summary>
        /// The name of the column.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The data type of the column. Must be one of the data types from DataTableDataTypes.
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DataTableColumn()
        {
        }

        /// <summary>
        /// Special constructor for implementing ISerializeable. Deserializes the object.
        /// </summary>
        /// <param name="info">Serialization info (all the values that are on the incoming object graph) of the object being deserialized.</param>
        /// <param name="context">The deserialization context.</param>
        internal DataTableColumn(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
