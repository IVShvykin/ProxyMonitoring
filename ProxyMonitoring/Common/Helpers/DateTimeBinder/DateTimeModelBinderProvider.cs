﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Linq;

namespace Common.Helpers.DateTimeBinder
{
    public class DateTimeModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (DateTimeModelBinder.SUPPORTED_TYPES.Contains(context.Metadata.ModelType))
            {
                return new BinderTypeModelBinder(typeof(DateTimeModelBinder));
            }

            return null;
        }
    }
}
