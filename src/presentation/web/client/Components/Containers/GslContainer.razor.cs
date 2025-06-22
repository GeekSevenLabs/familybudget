using BlazorComponentUtilities;

namespace FamilyBudget.Presentation.Web.Client.Components.Containers;

public partial class GslContainer : GslComponentBase
{
    private string? CssClass => CssBuilder.Default("tw:container tw:mx-auto")
        .AddClass(Class)
        .AddClass("tw:py-10 tw:px-4", WithPadding)
        .AddClass("tw|max-w-screen-sm", MaxWidth is GslMaxWidth.Small)
        .AddClass("tw|max-w-screen-md", MaxWidth is GslMaxWidth.Medium)
        .AddClass("tw|max-w-screen-lg", MaxWidth is GslMaxWidth.Large)
        .AddClass("tw|max-w-screen-xl", MaxWidth is GslMaxWidth.ExtraLarge)
        .AddClass("tw|max-w-screen-2xl", MaxWidth is GslMaxWidth.ExtraExtraLarge)
        .ToString();
    
    #region Content

    [Parameter, EditorRequired] public required RenderFragment ChildContent { get; set; }

    #endregion

    #region Size

    [Parameter] public GslMaxWidth MaxWidth { get; set; } = GslMaxWidth.Medium;
    [Parameter] public bool WithPadding { get; set; }

    #endregion
}

public enum GslMaxWidth
{
    Small,
    Medium,
    Large,
    ExtraLarge,
    ExtraExtraLarge
}