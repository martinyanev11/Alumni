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

		Task<NewsModel> GetNewsByIdAsync(Guid id);

		Task AddNewsAsync(NewsModel model);

		Task EditNewsAsync(NewsModel model);
		Task DeleteNewsAsync(Guid id);
	}
}
