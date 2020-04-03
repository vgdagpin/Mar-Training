using ClassLibrary1.Application.Common.Interfaces;
using ClassLibrary1.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Users.Commands
{

	public class RegisterUserCommand : IRequest<int>
	{
		#region Public members
		public string Name { get; set; }
		#endregion

		#region Handler
		public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, int>
		{
			private readonly IMediator mediator;
			private readonly IClassLibDbContext dbContext;

			public RegisterUserCommandHandler(IMediator mediator, IClassLibDbContext dbContext)
			{
				this.mediator = mediator;
				this.dbContext = dbContext;
			}

			public async Task<int> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
			{
				var _newUser = new User
				{
					Name = request.Name
				};

				dbContext.Users.Add(_newUser);
				await dbContext.SaveChangesAsync();

				return _newUser.ID;
			}
		}
		#endregion
	}
}
