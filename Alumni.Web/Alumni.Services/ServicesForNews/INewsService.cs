using Alumni.Services.ServicesForNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForNews
{
	public interface INewsService
	{
		Task<IEnumerable<NewsModel>> GetAllNewsAsync();

		Task<NewsModel> GetNewsByIdAsync(string id);

		Task CreateNewsAsync(NewsModel model);

		Task UpdateNewsAsync(NewsModel model);
		Task DeleteNewsAsync(string id);
	}
}
