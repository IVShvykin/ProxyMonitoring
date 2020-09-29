using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Helpers.DateTimeBinder
{
    public class DateTimeModelBinder : IModelBinder
    {
        public static readonly Type[] SUPPORTED_TYPES = new Type[] { typeof(DateTime), typeof(DateTime?) };

        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            if (!SUPPORTED_TYPES.Contains(bindingContext.ModelType))
            {
                return;
            }

            var modelName = GetModelName(bindingContext);

            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                return;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var dateToParse = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(dateToParse))
            {
                return;
            }

            var (success, dateTime) = DateTimeUTCParseHelper.ParseDateTime(dateToParse);

            if (success)
                bindingContext.Result = ModelBindingResult.Success(dateTime);
            else
            {
                bindingContext.Result = ModelBindingResult.Failed();
                bindingContext.ModelState.AddModelError(modelName, "Дата должна быть указана в формате UTC");
            }

            return;
        }

        private string GetModelName(ModelBindingContext bindingContext)
        {
            if (!string.IsNullOrEmpty(bindingContext.BinderModelName))
            {
                return bindingContext.BinderModelName;
            }

            return bindingContext.ModelName;
        }


    }
}
