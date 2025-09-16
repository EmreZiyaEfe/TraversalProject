using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Business.Reports.PDF
{
    public class TestReport : IDocument
    {
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(30);
                page.Header()
                    .Text("Hello")
                    .FontSize(20).Bold().AlignCenter();

                page.Content()
                    .Text("Bu, QuestPDF ile oluşturduğun ilk rapor.")
                    .FontSize(14);
            });
        }
    }
}
