using Products.Models;

namespace Products.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var model = item as Product;

            Application
                .Current
                .Resources
                .TryGetValue("SimpleProductDataTemplate", out var simpleProductDataTemplate);

            if (model != null)
            {
                if(model.HasOffer)
                {
                    return new DataTemplate();
                }
            }

            return simpleProductDataTemplate as DataTemplate;
        }
    }
}