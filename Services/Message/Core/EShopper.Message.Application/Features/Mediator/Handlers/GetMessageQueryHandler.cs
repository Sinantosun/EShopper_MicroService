using EShopper.Message.Application.Features.Mediator.Queries;
using EShopper.Message.Application.Features.Mediator.Results;
using EShopper.Message.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Features.Mediator.Handlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, List<GetMessageQueryResult>>
    {
        private readonly IMessageService _messageService;

        public GetMessageQueryHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<List<GetMessageQueryResult>> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _messageService.GetUserMessages();
            return values.Select(x => new GetMessageQueryResult()
            {
                Email = x.Email,
                MessageContent = x.MessageContent,
                NameSurname = x.NameSurname,
                Subject = x.Subject,
                UserMessageId=x.UserMessageId,

            }).ToList();
        }
    }
}
