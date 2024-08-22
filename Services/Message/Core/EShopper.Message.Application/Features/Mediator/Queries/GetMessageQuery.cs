using EShopper.Message.Application.Features.Mediator.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Application.Features.Mediator.Queries
{
    public class GetMessageQuery : IRequest<List<GetMessageQueryResult>>
    {
    }
}
