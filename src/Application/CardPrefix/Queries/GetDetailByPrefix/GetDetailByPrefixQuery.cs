using AutoMapper;
using AutoMapper.QueryableExtensions;
using TAP_TEST.Application.Common.Interfaces;
using TAP_TEST.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TAP_TEST.Application.CardPrefix.Queries.GetDetailByPrefix
{
   public class GetDetailByPrefixQuery : IRequest<CardPrefixDto>
    {
        public string prefix { get; set; }

        public class GetDetailByPrefixQueryHandler : IRequestHandler<GetDetailByPrefixQuery, CardPrefixDto>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetDetailByPrefixQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<CardPrefixDto> Handle(GetDetailByPrefixQuery request, CancellationToken cancellationToken)
            {
                var result = await _context.CardPrefixes
                      .ProjectTo<CardPrefixDto>(_mapper.ConfigurationProvider)
                    .Where(x => x.Prefix == request.prefix.Substring(0,5)).SingleOrDefaultAsync(cancellationToken);


                if(result == null)
                {
                    return new CardPrefixDto { BankAlias = "UNKNOWN", CardType = "UNKNOWN", Prefix = request.prefix };
                }

                return result;
            }
        }

    }
}
