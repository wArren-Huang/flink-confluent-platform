// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.10.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace schneider.poem.models
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class TagNumericValue : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"TagNumericValue\",\"namespace\":\"schneider.poem.models\",\"fi" +
				"elds\":[{\"name\":\"tagName\",\"type\":\"string\"},{\"name\":\"tagValue\",\"type\":\"double\"},{\"" +
				"name\":\"timestamp\",\"type\":\"long\"}]}");
		private string _tagName;
		private double _tagValue;
		private long _timestamp;
		public virtual Schema Schema
		{
			get
			{
				return TagNumericValue._SCHEMA;
			}
		}
		public string tagName
		{
			get
			{
				return this._tagName;
			}
			set
			{
				this._tagName = value;
			}
		}
		public double tagValue
		{
			get
			{
				return this._tagValue;
			}
			set
			{
				this._tagValue = value;
			}
		}
		public long timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.tagName;
			case 1: return this.tagValue;
			case 2: return this.timestamp;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.tagName = (System.String)fieldValue; break;
			case 1: this.tagValue = (System.Double)fieldValue; break;
			case 2: this.timestamp = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
