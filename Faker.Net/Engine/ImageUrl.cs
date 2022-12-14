using System;
namespace Faker.Net.Engine
{
    public class ImageUrl
    {
        public static string ImageUrlString() => ImageUrlFill[new Random().Next(1, ImageUrlFill.Length)];

        private static string[] ImageUrlFill { get; } = new string[]
        {
            "https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938393823/data.png","https://sw.images.amazon.com/912912935323823/data.png","https://sw.images.amazon.com/912912918323823/data.png","https://sw.images.amazon.com/912912938326823/data.png","https://sw.images.amazon.com/912912918323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912935323823/data.png","https://sw.images.amazon.com/912912938393823/data.png","https://sw.images.amazon.com/912912939323823/data.png","https://sw.images.amazon.com/912912918323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/9129129386423823/data.png","https://sw.images.amazon.com/91291293838223823/data.png","https://sw.images.amazon.com/9129129386423823/data.png","https://sw.images.amazon.com/91291293838223823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938393823/data.png","https://sw.images.amazon.com/912912938393823/data.png","https://sw.images.amazon.com/9129129387723823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.pnghttps://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/9129129383923823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912939323823/data.png","https://sw.images.amazon.com/9129129383923823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938393823/data.png","https://sw.images.amazon.com/91291293820323823/data.png","https://sw.images.amazon.com/912912938323423/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323423/data.png","https://sw.images.amazon.com/912912918323823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912935323823/data.png","https://sw.images.amazon.com/9129129386423823/data.png","https://sw.images.amazon.com/912912918323823/data.png","https://sw.images.amazon.com/9129129383923823/data.png","https://sw.images.amazon.com/9129129383923823/data.png","https://sw.images.amazon.com/912912938323423/data.png","https://sw.images.amazon.com/9129129386423823/data.png","https://sw.images.amazon.com/912912938323823/data.png","https://sw.images.amazon.com/912912938323423/data.png"
        };
    }
}

