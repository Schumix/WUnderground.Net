﻿using System;
using Newtonsoft.Json;

namespace CGurus.Weather.WundergroundAPI.Utilities
{
	internal class DoubleConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(string.IsNullOrWhiteSpace(value.ToString()) ? (double?)null : (double)value);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return string.IsNullOrWhiteSpace(existingValue.ToString()) ? (double?)null : (double)existingValue;
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(double);
		}
	}
}
