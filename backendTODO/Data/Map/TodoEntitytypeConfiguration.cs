using backendTODO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendTODO.Data.Map
{
    public class TodoEntitytypeConfiguration : IEntityTypeConfiguration<TodoModel>
    {
        public void Configure( EntityTypeBuilder<TodoModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("tb_todo");

            builder.Property(t => t.Title)
                .HasColumnName("title")
                .IsRequired()
                .HasColumnType("varchar(64)");

            builder.Property(t => t.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasColumnType("varchar(24)");

            builder.Property(t => t.created_at)
                .HasColumnName("created_at")
                .IsRequired()
                .HasColumnType("TimeStamp");

        }   
    }
}
