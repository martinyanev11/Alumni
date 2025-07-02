using Alumni.Data.Data;
using Alumni.Data.Models;
using Alumni.Services.ServicesForNews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.Services.ServicesForNews
{
	public class NewsServices : INewsService
	{
		private readonly AlumniDbContext _dbContext;

		public NewsServices(AlumniDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IEnumerable<NewsModel>> GetAllNewsAsync()
		{
			return await _dbContext.News
				.Select(n => new NewsModel
				{
					NewsId = n.NewsId,
					Title = n.Title,
					Contents = n.Contents,
					ImageUrl = n.ImageUrl,
					CreatedOn = n.CreatedOn
				})
				.ToListAsync();
		}

		public async Task<NewsModel> GetNewsByIdAsync(string id)
		{
			var news = await _dbContext.News.FindAsync(id);
			if (news == null)
			{
				return null;
			}

			return new NewsModel
			{
				NewsId = news.NewsId,
				Title = news.Title,
				Contents = news.Contents,
				ImageUrl = news.ImageUrl,
				CreatedOn = news.CreatedOn
			};
		}

		public async Task CreateNewsAsync(NewsModel model)
		{
			var news = new News
			{
				NewsId = Guid.NewGuid(), // Generate a new ID
				Title = model.Title,
				Contents = model.Contents,
				ImageUrl = model.ImageUrl,
				CreatedOn = DateTime.UtcNow // Set creation date
			};

			await _dbContext.News.AddAsync(news);
			await _dbContext.SaveChangesAsync();
		}

		public async Task UpdateNewsAsync(NewsModel model)
		{
			var news = await _dbContext.News.FindAsync(model.NewsId);
			if (news != null)
			{
				news.Title = model.Title;
				news.Contents = model.Contents;
				news.ImageUrl = model.ImageUrl;
				// You might update a 'ModifiedOn' property here if you have one
				_dbContext.News.Update(news);
				await _dbContext.SaveChangesAsync();
			}
		}

		public async Task DeleteNewsAsync(string id)
		{
			var news = await _dbContext.News.FindAsync(id);
			if (news != null)
			{
				_dbContext.News.Remove(news);
				await _dbContext.SaveChangesAsync();
			}
		}

	}
}
