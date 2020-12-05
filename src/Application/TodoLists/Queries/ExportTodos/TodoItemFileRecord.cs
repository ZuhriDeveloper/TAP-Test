using TAP_TEST.Application.Common.Mappings;
using TAP_TEST.Domain.Entities;

namespace TAP_TEST.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
