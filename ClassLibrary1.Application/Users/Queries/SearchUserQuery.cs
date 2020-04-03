using AutoMapper;
using AutoMapper.QueryableExtensions;
using ClassLibrary1.Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Users.Queries
{

	public class SearchUserQuery : IRequest<IQueryable<UserVM>>
	{
		#region Public members
		public string Filter { get; set; }
		#endregion

		#region Handler			
		public class SearchUserQueryHandler : IRequestHandler<SearchUserQuery, IQueryable<UserVM>>
		{
			private readonly IMediator mediator;
			private readonly IClassLibDbContext dbContext;
			private readonly IMapper mapper;

			public SearchUserQueryHandler(IMediator mediator, IClassLibDbContext dbContext, IMapper mapper)
			{
				this.mediator = mediator;
				this.dbContext = dbContext;
				this.mapper = mapper;
			}

			public async Task<IQueryable<UserVM>> Handle(SearchUserQuery request, CancellationToken cancellationToken)
			{
				var _searchResult = dbContext.Users
					.Where(a => a.Name.Contains(request.Filter))
					.ProjectTo<UserVM>(mapper.ConfigurationProvider);

				return _searchResult;
			}
		}
		#endregion
	}
}
