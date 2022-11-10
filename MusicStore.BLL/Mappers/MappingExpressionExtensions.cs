using AutoMapper;
using MusicStore.DAL.Models;

namespace MusicStore.BLL.Mappers
{
    public static class MappingExpressionExtensions
    {
        public static void ConfigureUpdateEntity<TEntity>(this IMappingExpression<TEntity, TEntity> mappingExpression) where TEntity : BaseEntity
        {
            mappingExpression
                .ForMember(ent => ent.Id, p => p.Ignore())
                .ForMember(ent => ent.CreatedDate, p => p.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
