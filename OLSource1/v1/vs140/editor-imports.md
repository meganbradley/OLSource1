---
title: "Editor Imports"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - editors [Visual Studio SDK], new - services
ms.assetid: 8d096de3-33b4-427a-a122-4aeff8a72da0
caps.latest.revision: 23
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Editor Imports
You can import a number of editor services, factories, and brokers that provide your extension with different kinds of access to the core editor. For example, you can import the <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService?qualifyHint=False> to provide you with a <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigator?qualifyHint=False> for a given content type. (This navigator allows you perform different kinds of searches on a text buffer.)  
  
 To use an editor import, you import it as a field or property of a class that exports a Managed Extensibility Framework component part.  
  
> [!NOTE]
>  For more information about the Managed Extensibility Framework, see [Managed Extensibility Framework Overview](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
## Import Syntax  
 The following example shows how to import the editor options factory service.  
  
```  
[Import]  
internal IEditorOptionsFactoryService EditorOptions { get; set; }  
```  
  
 If you want to import the service as a field and not a property, you should set it to `null` in the declaration in order to avoid the compiler warnings about not assigning to a variable:  
  
```  
[Import]  
internal IEditorOptionsFactoryService m_editorOptions = null;  
```  
  
 For more examples of using imports, see the following walkthroughs:  
  
 [Walkthrough: Creating a Margin Glyph](../vs140/walkthrough--creating-a-margin-glyph.md)  
  
 [Walkthrough: Customizing the Text View](../vs140/walkthrough--customizing-the-text-view.md)  
  
 [Walkthrough: Highlighting Text](../vs140/walkthrough--highlighting-text.md)  
  
 [Walkthrough: Displaying QuickInfo Tooltips](../vs140/walkthrough--displaying-quickinfo-tooltips.md)  
  
 [Walkthrough: Displaying Signature Help](../vs140/walkthrough--displaying-signature-help.md)  
  
 [Walkthrough: Displaying Statement Completion](../vs140/walkthrough--displaying-statement-completion.md)  
  
 [Walkthrough: Displaying SmartTags](../vs140/walkthrough--displaying-smarttags.md)  
  
## Importing the Service Provider  
 You can also import a <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider?qualifyHint=False> (found in the assembly Microsoft.VisualStudio.Shell.Immutable.10.0) in the same way to get access to Visual Studio services:  
  
```  
[Import]  
internal SVsServiceProvider ServiceProvider = null;   
```  
  
 See [Walkthrough: Accessing the DTE Object from an Editor Extension](../vs140/walkthrough--accessing-the-dte-object-from-an-editor-extension.md) for more information.  
  
## Services  
 Editor services are generally single entities that provide a service and are shared across multiple components.  
  
|Import|Provides|  
|------------|--------------|  
|<xref:Microsoft.VisualStudio.Utilities.IFileExtensionRegistryService?qualifyHint=False>|The relationship between file extensions and <xref:Microsoft.VisualStudio.Utilities.IContentType?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Utilities.IContentTypeRegistryService?qualifyHint=False>|The collection of <xref:Microsoft.VisualStudio.Utilities.IContentType?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Editor.IVsFontsAndColorsInformationService?qualifyHint=False>|<xref:Microsoft.VisualStudio.Editor.IVsFontsAndColorsInformation?qualifyHint=False> objects|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService?qualifyHint=False>|Many editor adapter objects:<br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow?qualifyHint=False><br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer?qualifyHint=False><br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator?qualifyHint=False><br /><br /> <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False>|  
|<xref:Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearchFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearch?qualifyHint=False> object for a given text view.|  
|<xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.ITextBuffer?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.ITextDocumentFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.ITextDocument?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Differencing.IDifferenceService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Differencing.IDifferenceCollection`1?qualifyHint=False> of differences.|  
|<xref:Microsoft.VisualStudio.Text.Differencing.IHierarchicalStringDifferenceService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Differencing.IHierarchicalDifferenceCollection?qualifyHint=False> of differences.|  
|<xref:Microsoft.VisualStudio.Text.Projection.IProjectionBufferFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Projection.IProjectionBuffer?qualifyHint=False> or an <xref:Microsoft.VisualStudio.Text.Projection.IElisionBuffer?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Projection.IBufferGraphFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Projection.IBufferGraph?qualifyHint=False> for a set of <xref:Microsoft.VisualStudio.Text.ITextBuffer?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Text.Classification.IClassifierAggregatorService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Classification.IClassifier?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.ITextBuffer?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Classification.IViewClassifierAggregatorService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Classification.IClassifier?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Classification.IClassificationFormatMapService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Classification.IClassificationFormatMap?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMapService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Classification.IEditorFormatMap?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService?qualifyHint=False>|Maintains the collection of <xref:Microsoft.VisualStudio.Text.Classification.IClassificationType?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Text.Tagging.IBufferTagAggregatorFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Tagging.ITagAggregator`1?qualifyHint=False> for a text buffer.|  
|<xref:Microsoft.VisualStudio.Text.Tagging.IViewTagAggregatorFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Tagging.ITagAggregator`1?qualifyHint=False> for a text view.|  
|<xref:Microsoft.VisualStudio.Text.Editor.IEditorOptionsFactoryService?qualifyHint=False>|The <xref:Microsoft.VisualStudio.Text.Editor.IEditorOptions?qualifyHint=False> for the specified scope.|  
|<xref:Microsoft.VisualStudio.Text.Editor.IScrollMapFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Editor.IScrollMap?qualifyHint=False> for a text view.|  
|<xref:Microsoft.VisualStudio.Text.Editor.ISmartIndentationService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Editor.ISmartIndent?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Editor.ISmartIndentationService?qualifyHint=False>|Gets the automatic indentation through the <xref:Microsoft.VisualStudio.Text.Editor.ISmartIndentProvider?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Text.Editor.ITextEditorFactoryService?qualifyHint=False>|Manages the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Formatting.IFormattedTextSourceFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Formatting.IFormattedLineSource?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Formatting.IRtfBuilderService?qualifyHint=False>|Generates RTF-formatted text from a set of snapshot spans.|  
|<xref:Microsoft.VisualStudio.Text.Formatting.ITextAndAdornmentSequencerFactoryService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Formatting.ITextAndAdornmentSequencer?qualifyHint=False> for an <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Formatting.ITextParagraphPropertiesFactoryService?qualifyHint=False>|A <xref:System.Windows.Media.TextFormatting.TextParagraphProperties?qualifyHint=False> for formatting text lines in a view.|  
|<xref:Microsoft.VisualStudio.Text.Operations.IEditorOperationsFactoryService?qualifyHint=False>|A <xref:Microsoft.VisualStudio.Text.Operations.IEditorOperations?qualifyHint=False> object for an <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Operations.ITextSearchService?qualifyHint=False>|Searches a text snapshot.|  
|<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigator?qualifyHint=False> for an <xref:Microsoft.VisualStudio.Text.ITextBuffer?qualifyHint=False> by <xref:Microsoft.VisualStudio.Utilities.IContentType?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Text.Outlining.IOutliningManagerService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Outlining.IOutliningManager?qualifyHint=False> for a text view.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.IGlyphService?qualifyHint=False>|A standard set of glyphs.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseSessionStackMapService?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Language.Intellisense.IIntellisenseSessionStack?qualifyHint=False> for a <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.IWpfKeyboardTrackingService?qualifyHint=False>|Tracks keyboard handling.|  
|<xref:Microsoft.VisualStudio.Language.StandardClassification.IStandardClassificationService?qualifyHint=False>|Standard <xref:Microsoft.VisualStudio.Text.Classification.IClassificationType?qualifyHint=False> objects.|  
|<xref:Microsoft.VisualStudio.Text.Operations.ITextUndoHistoryRegistry?qualifyHint=False>|Maintains the relationship between text buffers and  <xref:Microsoft.VisualStudio.Text.Operations.ITextUndoHistory?qualifyHint=False> objects.|  
  
## Other Imports  
 Provider factories and brokers are generally entities that can have multiple instances in multiple components.  
  
|Import|Provides|  
|------------|--------------|  
|<xref:Microsoft.VisualStudio.Text.Adornments.IErrorProviderFactory?qualifyHint=False>|A <xref:Microsoft.VisualStudio.Text.Tagging.SimpleTagger`1?qualifyHint=False> of type <xref:Microsoft.VisualStudio.Text.Tagging.ErrorTag?qualifyHint=False>) for the given buffer.|  
|<xref:Microsoft.VisualStudio.Text.Adornments.ITextMarkerProviderFactory?qualifyHint=False>|A text marker tagger (a <xref:Microsoft.VisualStudio.Text.Tagging.SimpleTagger`1?qualifyHint=False> of type <xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag?qualifyHint=False>).|  
|<xref:Microsoft.VisualStudio.Text.Adornments.IToolTipProviderFactory?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Text.Adornments.IToolTipProvider?qualifyHint=False> for a given <xref:Microsoft.VisualStudio.Text.Editor.ITextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionBroker?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSession?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoBroker?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSession?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpBroker?qualifyHint=False>|An <xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpSession?qualifyHint=False>.|  
  
## See Also  
 [Editor Extension Points](../vs140/language-service-and-editor-extension-points.md)