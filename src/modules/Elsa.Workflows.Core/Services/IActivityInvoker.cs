using Elsa.Expressions.Models;
using Elsa.Workflows.Core.Models;

namespace Elsa.Workflows.Core.Services;

public interface IActivityInvoker
{
    Task InvokeAsync(
        WorkflowExecutionContext workflowExecutionContext,
        IActivity activity,
        ActivityExecutionContext? owner = default,
        IEnumerable<MemoryDatumReference>? locationReferences = default);

    Task InvokeAsync(ActivityExecutionContext activityExecutionContext);
}