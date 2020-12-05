using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TAP_TEST.Application.Common.Mappings;
using TAP_TEST.Domain.Entities;

namespace TAP_TEST.Application.CardPrefix.Queries.GetDetailByPrefix
{
    public class CardPrefixDto : IMapFrom<TAP_TEST.Domain.Entities.CardPrefix>
    {

        public int IdPrefix { get; set; }
        public string Prefix { get; set; }
        public string BankAlias { get; set; }
        public string CardType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TAP_TEST.Domain.Entities.CardPrefix, CardPrefixDto>()
                .ForMember(m => m.IdPrefix, opt => opt.MapFrom(s => s.Id)); ;
        }
    }
}
