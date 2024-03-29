﻿using PPVR.WebApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace PPVR.WebApp.DataAccess.Mappings
{
    public class EleicaoMap : EntityTypeConfiguration<Eleicao>
    {
        public EleicaoMap()
        {
            ToTable("Eleicoes");

            HasKey(x => x.EleicaoId);

            Property(x => x.Ano)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_ELEICAO_ANO_TURNO_DESCRICAO", 1)
                        {
                            IsUnique = true
                        }));

            Property(x => x.Turno)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_ELEICAO_ANO_TURNO_DESCRICAO", 2)
                        {
                            IsUnique = true
                        }));

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_ELEICAO_ANO_TURNO_DESCRICAO", 3)
                        {
                            IsUnique = true
                        }));
        }
    }
}