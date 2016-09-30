---
title: "Editor Imports"
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
  - "editors [Visual Studio SDK], new - services"
ms.assetid: 8d096de3-33b4-427a-a122-4aeff8a72da0
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Editor Imports
You can import a number of editor services, factories, and brokers that provide your extension with different kinds of access to the core editor. For example, you can import the \<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigatorSelectorService*> to provide you with a \<xref:Microsoft.VisualStudio.Text.Operations.ITextStructureNavigator*> for a given content type. (This navigator allows you perform different kinds of searches on a text buffer.)  
  
 To use an editor import, you import it as a field or property of a class that exports a Managed Extensibility Framework component part.  
  
> [!NOTE]
>  For more information about the Managed Extensibility Framework, see [Managed Extensibility Framework Overview](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
## Import Syntax  
 The following example shows how to import the editor options factory service.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you want to import the service as a field and not a property, you should set it to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the declaration in order to avoid the compiler warnings about not assigning to a variable:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more examples of using imports, see the following walkthroughs:  
  
 [Walkthrough: Creating a Margin Glyph](../vs140/walkthrough--creating-a-margin-glyph.md)  
  
 [Walkthrough: Customizing the Text View](../vs140/walkthrough--customizing-the-text-view.md)  
  
 [Walkthrough: Highlighting Text](../vs140/walkthrough--highlighting-text.md)  
  
 [Walkthrough: Displaying QuickInfo Tooltips](../vs140/walkthrough--displaying-quickinfo-tooltips.md)  
  
 [Walkthrough: Displaying Signature Help](../vs140/walkthrough--displaying-signature-help.md)  
  
 [Walkthrough: Displaying Statement Completion](../vs140/walkthrough--displaying-statement-completion.md)  
  
 [Walkthrough: Displaying SmartTags](../vs140/walkthrough--displaying-smarttags.md)  
  
## Importing the Service Provider  
 You can also import a \<xref:Microsoft.VisualStudio.Shell.SVsServiceProvider*> (found in the assembly Microsoft.VisualStudio.Shell.Immutable.10.0) in the same way to get access to Visual Studio services:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 See [Walkthrough: Accessing the DTE Object from an Editor Extension](../vs140/walkthrough--accessing-the-dte-object-from-an-editor-extension.md) for more information.  
  
## Services  
 Editor services are generally single entities that provide a service and are shared across multiple components.  
  
|Import|Provides|  
|------------|--------------|  
|\<xref:Microsoft.VisualStudio.Utilities.IFileExtensionRegistryService*>|The relationship between file extensions and \<xref:Microsoft.VisualStudio.Utilities.IContentType*> objects.|  
|\<xref:Microsoft.VisualStudio.Utilities.IContentTypeRegistryService*>|The collection of \<xref:Microsoft.VisualStudio.Utilities.IContentType*> objects.|  
|\<xref:Microsoft.VisualStudio.Editor.IVsFontsAndColorsInformationService*>|\<xref:Microsoft.VisualStudio.Editor.IVsFontsAndColorsInformation*> objects|  
|\<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService*>|Many editor adapter objects:\<br />\<br /> \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow*>\<br />\<br /> \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer*>\<br />\<br /> \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator*>\<br />\<br /> \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView*>|  
|\<xref:Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearchFactoryService*>|An \<xref:Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearch*> object for a given text view.|  
|\<xref:Microsoft.VisualStudio.Text.ITextBufferFactoryService*>|An \<xref:Microsoft.VisualStudio.Text.ITextBuffer*>.|  
|\<xref:Microsoft.VisualStudio.Text.ITextDocumentFactoryService*>|An \<xref:Microsoft.VisualStudio.Text.ITextDocument*>.|  
|\<xref:Microsoft.VisualStudio.Text.Differencing.IDifferenceService*>|An <xref:Microsoft.VisualStudio.Text.Differencing.IDifferenceCollection<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> for a text buffer.|  
|\<xref:Microsoft.VisualStudio.Text.Tagging.IViewTagAggregatorFactoryService*>|An <xref:Microsoft.VisualStudio.Text.Tagging.ITagAggregator<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*> of type \<xref:Microsoft.VisualStudio.Text.Tagging.ErrorTag*>) for the given buffer.|  
|\<xref:Microsoft.VisualStudio.Text.Adornments.ITextMarkerProviderFactory*>|A text marker tagger (a \<xref:Microsoft.VisualStudio.Text.Tagging.SimpleTagger`1*> of type \<xref:Microsoft.VisualStudio.Text.Tagging.TextMarkerTag*>).|  
|\<xref:Microsoft.VisualStudio.Text.Adornments.IToolTipProviderFactory*>|An \<xref:Microsoft.VisualStudio.Text.Adornments.IToolTipProvider*> for a given \<xref:Microsoft.VisualStudio.Text.Editor.ITextView*>.|  
|\<xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionBroker*>|An \<xref:Microsoft.VisualStudio.Language.Intellisense.ICompletionSession*>.|  
|\<xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoBroker*>|An \<xref:Microsoft.VisualStudio.Language.Intellisense.IQuickInfoSession*>.|  
|\<xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpBroker*>|An \<xref:Microsoft.VisualStudio.Language.Intellisense.ISignatureHelpSession*>.|  
  
## See Also  
 [Editor Extension Points](../vs140/language-service-and-editor-extension-points.md)