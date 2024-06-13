using MudBlazor;

namespace MVSRA.Shared.Models;

public class QueryTableState
{
    public string SearchParameter { get; set; } = string.Empty;
    public TableState State { get; set; } = null!;

    public QueryTableState(string? searchParameter, TableState state)
    {
        SearchParameter = searchParameter ?? string.Empty;
        State = state;
        State.SortLabel = state.SortLabel ?? string.Empty;
    }
}
