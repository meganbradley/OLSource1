---
title: "New or Changed Behavior with Editor Adapters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - adapter behavior"
ms.assetid: 5555b116-cfdb-4773-ba62-af80fda64abd
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# New or Changed Behavior with Editor Adapters
If you are updating code that was written against earlier versions of the Visual Studio core editor, and you plan to use the editor adapters (or shims) rather than using the new API, you should be aware of the following differences in the behavior of the editor adapters with respect to the previous core editor.  
  
## Features  
  
#### Using SetSite()  
 You must call [SetSite](assetId:///M:Microsoft.VisualStudio.OLE.Interop.IObjectWithSite.SetSite(System.Object)?qualifyHint=False&autoUpgrade=True) when you CoCreate text buffers, text views, and code windows before you perform any other operations on them. However, this is not necessary if you use the <xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService*> to create them, because this service's Create() methods themselves call [SetSite](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory.SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider)?qualifyHint=False&autoUpgrade=True).  
  
#### Hosting IVsCodeWindow and IVsTextView in your own content  
 You can host both <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow*> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> in your own content using either Win32 mode or WPF mode. However, you should keep in mind that there are some differences in the two modes.  
  
##### Using Win32 and WPF versions of IVsCodeWindow  
 The editor code window is derived from <xref:Microsoft.VisualStudio.Shell.WindowPane*>, which implements the older Win32 <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane*> interface as well as the new WPF <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIElementPane*> interface. You can use the [IVsWindowPane.CreatePaneWindow](assetId:///M:Microsoft.VisualStudio.Shell.WindowPane.Microsoft#VisualStudio#Shell#Interop#IVsWindowPane#CreatePaneWindow(System.IntPtr,System.Int32,System.Int32,System.Int32,System.Int32,System.IntPtr@)?qualifyHint=False&autoUpgrade=True) method to create an HWND-based hosting environment, or the [IVsUIElementPane.CreateUIElementPane](assetId:///M:Microsoft.VisualStudio.Shell.WindowPane.Microsoft#VisualStudio#Shell#Interop#IVsUIElementPane#CreateUIElementPane(System.Object@)?qualifyHint=False&autoUpgrade=True) method to create a WPF hosting environment. The underlying editor always uses WPF, but you can create the kind of window pane that suits your hosting requirements if you are embedding this window pane directly into your own content.  
  
##### Using Win32 and WPF versions of IVsTextView  
 You can set an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> to Win32 mode or WPF mode.  
  
 When an editor factory creates a text view, by default it is hosted inside an HWND, and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetWindowHandle*> returns an HWND. You should not use this mode to embed the editor inside a WPF control.  
  
 To set a text view to WPF mode, you must call [Initialize](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.Initialize(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines,System.IntPtr,System.UInt32,Microsoft.VisualStudio.TextManager.Interop.INITVIEW[])?qualifyHint=False&autoUpgrade=True) and pass in <xref:Microsoft.VisualStudio.TextManager.Interop.TextViewInitFlags3.VIF_NO_HWND_SUPPORT*> as one of the initialization flags in the `InitView` parameter. You can get the <xref:System.Windows.FrameworkElement*> by calling [CreateUIElementPane](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIElementPane.CreateUIElementPane(System.Object@)?qualifyHint=False&autoUpgrade=True).  
  
 WPF mode differs from Win32 mode in two ways. First, the text view can be hosted in a WPF context. You can access the WPF pane by casting the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> to <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIElementPane*> and calling [GetUIObject](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIElement.GetUIObject(System.Object@)?qualifyHint=False&autoUpgrade=True). Second, <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetWindowHandle*> still returns an HWND, but this HWND can be used only to check its position and set focus on it. You must not use this HWND to respond to a WM_PAINT message, because it will not affect how the editor paints the window. This HWND is present only to facilitate the transition to the new editor code by means of the adapters. It is highly recommended that you should not use `VIF_NO_HWND_SUPPORT` if your component requires an HWND to work, due to the limitations in the HWND returned from `GetWindowHandle` while in this mode.  
  
#### Passing arrays as parameters in native code  
 There are many methods in the legacy editor API that have parameters that include an array and its count. Examples are:  
  
 [AppendViewOnlyMarkerTypes](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.AppendViewOnlyMarkerTypes(System.UInt32,System.UInt32[])?qualifyHint=False&autoUpgrade=True)  
  
 [RemoveViewOnlyMarkerTypes](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.RemoveViewOnlyMarkerTypes(System.UInt32,System.UInt32[])?qualifyHint=False&autoUpgrade=True)  
  
 If you are calling these methods in native code, you must pass in only one element at a time. If you pass in more than one element, the call will be rejected, due to problems with the primary interop implementation.  
  
 The problem is more complex with methods such as [SetIgnoreMarkerTypes](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.SetIgnoreMarkerTypes(System.Int32,System.UInt32[])?qualifyHint=False&autoUpgrade=True). Every time this method is called, it clears the previous list of ignored marker types, so it is not possible simply to call this method three times with three different marker types. The only remedy is to call this method only in managed code.  
  
#### Threading  
 You should always call the buffer adapter from the UI thread. The buffer adapter is a managed object, which means that calling into it from managed code will bypass COM marshaling and your call will not automatically be marshaled to the UI thread.  If you are calling the buffer adapter from a background thread, you must use <xref:System.Windows.Threading.Dispatcher.Invoke*> or a similar method.  
  
#### LockBuffer methods  
 All LockBuffer() methods are deprecated. Examples are:  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer.LockBuffer*>  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextStream.LockBuffer*>  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.LockBuffer*>  
  
#### Commit events  
 Commit events are not supported. Calling a method that advises for these events causes the method to return a failure code.  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsPreliminaryTextChangeCommitEvents*>  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFinalTextChangeCommitEvents*>  
  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsUndoRedoClusterWithCommitEvents*>  
  
#### TextEditorEvents  
 The <xref:EnvDTE.TextEditorEvents*> no longer fire on Commit(). Instead they fire on every text change.  
  
#### Text Markers  
 You must call <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarker.Invalidate*> on <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextMarker*> objects when you remove them. In previous versions, you needed only to release the markers.  
  
#### Line numbers  
 For a variety of methods on <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*> and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx*>, line numbers correspond to underlying buffer line numbers, not line numbers that factor in outlining and word-wrap, as in Visual Studio 2008.  
  
 The methods affected include the following (the list is not exhaustive):  
  
-   [CenterLines](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.CenterLines(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
-   [GetCaretPos](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetCaretPos(System.Int32@,System.Int32@)?qualifyHint=False&autoUpgrade=True)  
  
-   [GetLineAndColumn](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetLineAndColumn(System.Int32,System.Int32@,System.Int32@)?qualifyHint=False&autoUpgrade=True)  
  
-   [GetNearestPosition](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetNearestPosition(System.Int32,System.Int32,System.Int32@,System.Int32@)?qualifyHint=False&autoUpgrade=True)  
  
-   [GetPointOfLineColumn](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetPointOfLineColumn(System.Int32,System.Int32,Microsoft.VisualStudio.OLE.Interop.POINT[])?qualifyHint=False&autoUpgrade=True)  
  
-   [GetTextStream](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetTextStream(System.Int32,System.Int32,System.Int32,System.Int32,System.String@)?qualifyHint=False&autoUpgrade=True)  
  
-   [GetWordExtent](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetWordExtent(System.Int32,System.Int32,System.UInt32,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True)  
  
-   [PositionCaretForEditing](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.PositionCaretForEditing(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
-   [ReplaceTextOnLine](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.ReplaceTextOnLine(System.Int32,System.Int32,System.Int32,System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
-   [SetCaretPos](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.SetCaretPos(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
-   [SetSelection](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.SetSelection(System.Int32,System.Int32,System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
-   [SetTopLine](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.SetTopLine(System.Int32)?qualifyHint=False&autoUpgrade=True)  
  
#### Outlining  
 Clients of <xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession*> will see only those outlining regions that were added using [AddHiddenRegions](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession.AddHiddenRegions(System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegion[],Microsoft.VisualStudio.TextManager.Interop.IVsEnumHiddenRegions[])?qualifyHint=False&autoUpgrade=True)or [AddHiddenRegionsEx](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSessionEx.AddHiddenRegionsEx(System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.NewHiddenRegionEx[],Microsoft.VisualStudio.TextManager.Interop.IVsEnumHiddenRegions@)?qualifyHint=False&autoUpgrade=True). They will not see ad hoc regions, because they are not added through the editor adapters. Likewise, these clients will not see outlining regions added by languages (including C# and C++) that are using the new editor code rather than the editor adapters.  
  
#### Line heights  
 In the new editor, text lines can have different heights, depending on the font size and possible line transforms that may move the line relative to other lines. The line height returned by methods such as [GetLineHeight](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetLineHeight(System.Int32@)?qualifyHint=False&autoUpgrade=True) is the height of a line using the default font size with no line transforms applied. This height may or may not reflect the actual height of a line in the view.  
  
#### Eventing and undo  
 In the new editor, the view continues to perform operations such as rendering and raising events continuously, even when an undo cluster is open. This behavior is different from that of legacy views, which did not perform those operations until after the closing of the undo cluster.  
  
#### IntelliSense  
  
-   The [UpdateTipWindow](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.UpdateTipWindow(Microsoft.VisualStudio.TextManager.Interop.IVsTipWindow,System.UInt32)?qualifyHint=False&autoUpgrade=True) method will fail if you pass in a class that does not implement either <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextTipWindow2*> or <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow3*>. Custom Win32 owner-drawn popups are no longer supported.  
  
#### SmartTags  
 There is no adapter support for smart tags created with, <xref:Microsoft.VisualStudio.TextManager.Interop.IVsSmartTagData*>, <xref:Microsoft.VisualStudio.TextManager.Interop.IVsSmartTagTipWindow*>, and <xref:Microsoft.VisualStudio.TextManager.Interop.IVsSmartTagTipWindow2*> interfaces.  
  
#### DTE  
 <xref:EnvDTE80.IncrementalSearch*> is not implemented.  
  
## Unimplemented methods  
 Some methods have not been implemented on the text buffer adapter, text view adapter, and text layer adapter.  
  
|Interface|Not implemented|  
|---------------|---------------------|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*>|`Reload(false)` is not implemented.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator*>|[EnumSpans](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.EnumSpans(Microsoft.VisualStudio.TextManager.Interop.IVsEnumBufferCoordinatorSpans@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [SetBufferMappingModes](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.SetBufferMappingModes(System.UInt32,System.UInt32)?qualifyHint=False&autoUpgrade=True)<br /><br /> [SetSpanMappings](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator.SetSpanMappings(System.Int32,Microsoft.VisualStudio.TextManager.Interop.NewSpanMapping[])?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines*>|[GetMarkerData](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.GetMarkerData(System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.MARKERDATA[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [ReleaseMarkerData](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLines.ReleaseMarkerData(Microsoft.VisualStudio.TextManager.Interop.MARKERDATA[])?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer*>|[CanReplaceLines](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.CanReplaceLines(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)<br /><br /> [CopyLineText](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.CopyLineText(System.Int32,System.Int32,System.Int32,System.Int32,System.IntPtr,System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [CreateTrackingPoint](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.CreateTrackingPoint(System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsTextTrackingPoint@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [EnumLayerMarkers](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.EnumLayerMarkers(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.UInt32,Microsoft.VisualStudio.TextManager.Interop.IVsEnumLayerMarkers@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetBaseBuffer](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.GetBaseBuffer(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetLengthOfLine](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.GetLengthOfLine(System.Int32,System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetLineCount](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.GetLineCount(System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetLineText](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.GetLineText(System.Int32,System.Int32,System.Int32,System.Int32,System.String@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetMarkerData](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.GetMarkerData(System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.MARKERDATA[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [LockBufferEx](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.LockBufferEx(System.UInt32)?qualifyHint=False&autoUpgrade=True)<br /><br /> [MapLocalSpansToTextOriginatingLayer](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.MapLocalSpansToTextOriginatingLayer(System.UInt32,Microsoft.VisualStudio.TextManager.Interop.IVsEnumTextSpans,Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer@,Microsoft.VisualStudio.TextManager.Interop.IVsEnumTextSpans@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [ReleaseMarkerData](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.ReleaseMarkerData(Microsoft.VisualStudio.TextManager.Interop.MARKERDATA[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [ReplaceLines](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.ReplaceLines(System.Int32,System.Int32,System.Int32,System.Int32,System.IntPtr,System.Int32,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [ReplaceLinesEx](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.ReplaceLinesEx(System.UInt32,System.Int32,System.Int32,System.Int32,System.Int32,System.IntPtr,System.Int32,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [UnlockBufferEx](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextLayer.UnlockBufferEx(System.UInt32)?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget*>|[Find](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find(System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.UInt32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [Replace](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace(System.String,System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.Int32@)?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsLayeredTextView*>|[GetSelectedAtom](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsLayeredTextView.GetSelectedAtom(System.UInt32,System.Object@)?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*>|[GetSelectionDataObject](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.GetSelectionDataObject(Microsoft.VisualStudio.OLE.Interop.IDataObject@)?qualifyHint=False&autoUpgrade=True)<br /><br /> assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.PositionCaretForEditing(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True<br /><br /> [RestrictViewRange](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.RestrictViewRange(System.Int32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsViewRangeClient)?qualifyHint=False&autoUpgrade=True)<br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateViewFrameCaption*>|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx*>|[GetSmartTagRect](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.GetSmartTagRect(Microsoft.VisualStudio.OLE.Interop.RECT[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [InvokeInsertionUI](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.InvokeInsertionUI(Microsoft.VisualStudio.TextManager.Interop.IVsCompletionSet,System.String,System.String,Microsoft.VisualStudio.TextManager.Interop.IVsInsertionUI@)?qualifyHint=False&autoUpgrade=True)<br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewEx.SetHoverWaitTimer*>|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow*>|[SetViewClassID](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow.SetViewClassID(System.Guid@)?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost*>|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.AfterCompletorCommit*><br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.BeforeCompletorCommit*><br /><br /> [Exec](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.Exec(System.Guid@,System.UInt32,System.UInt32,System.Object@,System.Object@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetContextLocation](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetContextLocation(System.Int32,System.Int32,System.Int32,Microsoft.VisualStudio.OLE.Interop.RECT[],System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetServiceProvider](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetServiceProvider(Microsoft.VisualStudio.OLE.Interop.IServiceProvider@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetSmartTagRect](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetSmartTagRect(Microsoft.VisualStudio.OLE.Interop.RECT[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetSubjectCaretPos](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetSubjectCaretPos(System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetSubjectSelection](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetSubjectSelection(System.Int32@,System.Int32@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [GetSubjectText](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.GetSubjectText(System.String@)?qualifyHint=False&autoUpgrade=True)<br /><br /> [QueryStatus](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.QueryStatus(System.Guid@,System.UInt32,Microsoft.VisualStudio.OLE.Interop.OLECMD[],Microsoft.VisualStudio.OLE.Interop.OLECMDTEXT[])?qualifyHint=False&autoUpgrade=True)<br /><br /> [ReplaceSubjectTextSpan](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.ReplaceSubjectTextSpan(System.Int32,System.Int32,System.String)?qualifyHint=False&autoUpgrade=True)<br /><br /> [SetSubjectCaretPos](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.SetSubjectCaretPos(System.Int32)?qualifyHint=False&autoUpgrade=True)<br /><br /> [SetSubjectSelection](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.SetSubjectSelection(System.Int32,System.Int32)?qualifyHint=False&autoUpgrade=True)<br /><br /> [UpdateSmartTagWindow](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsIntellisenseHost.UpdateSmartTagWindow(Microsoft.VisualStudio.TextManager.Interop.IVsSmartTagTipWindow,System.UInt32)?qualifyHint=False&autoUpgrade=True)|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewIntellisenseHost*>|[SetSubjectFromPrimaryBuffer](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsTextViewIntellisenseHost.SetSubjectFromPrimaryBuffer(Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True) is implemented in the adapters but ignored by the outlining UI.|  
|<xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegionEx*>|[GetBannerAttr](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegionEx.GetBannerAttr(System.UInt32,System.UInt32[])?qualifyHint=False&autoUpgrade=True) is implemented in the adapters but ignored by the outlining UI.|