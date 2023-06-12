using Slugify;

namespace ClothingShop.Server.Extensions
{
    public static class StringExtension
    {
        public static string ToSlug(this string value)
        {
            if (value == null)
                return null;

            var config = new SlugHelperConfiguration();

            config.StringReplacements.Add("&", "-");
            config.StringReplacements.Add(",", "-");
            config.StringReplacements.Add("đ", "d");

            var helper = new SlugHelper(config);

            var result = helper.GenerateSlug(value);
            return result;
        }
    }
}
