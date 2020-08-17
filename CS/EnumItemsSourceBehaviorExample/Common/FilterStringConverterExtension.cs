using System;
using System.Linq;
using System.Windows.Markup;
using System.Collections.Generic;

namespace EnumItemsSourceBehaviorExample.Common {
    public class FilterStringConverterExtension : MarkupExtension {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return new FilterStringConverter();
        }
    }
}
