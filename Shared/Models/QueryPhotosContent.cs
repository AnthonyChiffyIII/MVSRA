using MudBlazor;

namespace MVSRA.Shared.Models;

public class QueryPhotosContent
{
    public string SearchParameter { get; set; } = string.Empty;
    public TableState State { get; set; } = null!;

    public QueryPhotosContent(string searchParameter, TableState state)
    {
        SearchParameter = searchParameter;
        State = state;
    }
}
