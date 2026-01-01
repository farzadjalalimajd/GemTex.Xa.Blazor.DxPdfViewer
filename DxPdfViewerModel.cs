using DevExpress.Blazor;
using DevExpress.Blazor.Navigation.Internal;
using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;

namespace GemTex.ExpressApp.Blazor.Editors.Models;

public class DxPdfViewerModel : ComponentModelBase
{
    public byte[] DocumentContent
    {
        get => GetPropertyValue<byte[]>();
        set => SetPropertyValue(value);
    }

    public string DocumentName
    {
        get => GetPropertyValue<string>("Document");
        set => SetPropertyValue(value);
    }

    public string CssClass
    {
        get => GetPropertyValue<string>();
        set => SetPropertyValue(value);
    }

    public bool IsSinglePagePreview
    {
        get => GetPropertyValue<bool>(false);
        set => SetPropertyValue(value);
    }

    public SizeMode? SizeMode
    {
        get => GetPropertyValue<SizeMode?>(null);
        set => SetPropertyValue(value);
    }

    public double ZoomLevel
    {
        get => GetPropertyValue<double>(-1.0);
        set => SetPropertyValue(value);
    }

    public EventCallback<ToolbarModel> CustomizeToolbar
    {
        get => GetPropertyValue<EventCallback<ToolbarModel>>();
        set => SetPropertyValue(value);
    }

    public override Type ComponentType => typeof(DevExpress.Blazor.PdfViewer.DxPdfViewer);
}
