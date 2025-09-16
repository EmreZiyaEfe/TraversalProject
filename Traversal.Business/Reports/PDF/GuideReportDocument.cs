using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete.Entities;

namespace Traversal.Business.Reports.PDF
{
    public class GuideReportDocument : IDocument
    {
        private readonly List<Guide> _guides;

        public GuideReportDocument(List<Guide> guides)
        {
            _guides = guides;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);

                page.Header()
                    .Text("Guides Report")
                    .FontSize(20)
                    .Bold()
                    .AlignCenter();

                page.Content().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Element(container => container
                        .DefaultTextStyle(x => x.Bold())
                        .Padding(5)
                        .Background(Colors.Grey.Lighten2)
                        .Text("Name Surname"));

                        header.Cell().Element(container => container
                        .DefaultTextStyle(x => x.Bold())
                        .Padding(5)
                        .Background(Colors.Grey.Lighten2)
                        .Text("Description"));

                    });

                    foreach (var item in _guides)
                    {
                        table.Cell().Text(item.Name);
                        table.Cell().Text(item.Description);
                    }
                });
            });
        }
    }
}
