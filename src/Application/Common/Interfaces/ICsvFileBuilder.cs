using TAP_TEST.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace TAP_TEST.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
