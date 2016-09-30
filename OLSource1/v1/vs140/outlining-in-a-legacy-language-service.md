---
title: "Outlining in a Legacy Language Service"
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
  - "outlining"
  - "language services [managed package framework], outlining"
  - "outlining, supporting in language services [managed package framework]"
ms.assetid: 7b5578b4-a20a-4b94-ad4c-98687ac133b9
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Outlining in a Legacy Language Service
Outlining makes it possible to collapse a complex program into an overview or outline. For example, in C# all methods can be collapsed to a single line, showing only the method signature. In addition, structures and classes can be collapsed to show only the names of the structures and classes. Inside a single method, complex logic can be collapsed to show the overall flow by showing only the first line of statements such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Walkthrough: Outlining](../vs140/walkthrough--outlining.md).  
  
> [!NOTE]
>  We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Enabling Support for Outlining  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> registry entry is set to 1 to enable automatic outlining. Automatic outlining sets up a parse of the whole source when a file is loaded or changed in order to identify hidden regions and show the outlining glyphs. Outlining can also be controlled manually by the user.  
  
 The value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> registry entry can be obtained through the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences.AutoOutlining*> property on the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences*> class. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> registry entry can be initialized with a named parameter to the \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*> attribute (see [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md) for details).  
  
## The Hidden Region  
 To provide outlining, your language service must support hidden regions. These are spans of text that can be expanded or collapsed. Hidden regions can be delimited by standard language symbols, such as curly braces, or by custom symbols. For example, C# has a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pair that delimits a hidden region.  
  
 Hidden regions are managed by a hidden region manager, which is exposed as the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextSession*> interface.  
  
 Outlining uses hidden regions the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegion*> interface and contain the span of the hidden region, the current visible state, and the banner to be shown when the span is collapsed.  
  
 The language service parser uses the \<xref:Microsoft.VisualStudio.Package.AuthoringSink.AddHiddenRegion*> method to add a new hidden region with the default behavior for hidden regions, while the \<xref:Microsoft.VisualStudio.Package.AuthoringSink.AddHiddenRegion*> method allows you to customize the appearance and behavior of the outline. Once hidden regions are given to the hidden region session, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] manages the hidden regions for the language service.  
  
 If you need to determine when the hidden region session is destroyed, a hidden region is changed, or you need to make sure a particular hidden region is visible; you must derive a class from the \<xref:Microsoft.VisualStudio.Package.Source*> class and override the appropriate methods, \<xref:Microsoft.VisualStudio.Package.Source.OnBeforeSessionEnd*>, \<xref:Microsoft.VisualStudio.Package.Source.OnHiddenRegionChange*>, and [M:Microsoft.VisualStudio.Package.Source.MakeBaseSpanVisible(Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegion,Microsoft.VisualStudio.TextManager.Interop.TextSpan\[\])](assetId:///M:Microsoft.VisualStudio.Package.Source.MakeBaseSpanVisible(Microsoft.VisualStudio.TextManager.Interop.IVsHiddenRegion,Microsoft.VisualStudio.TextManager.Interop.TextSpan[])?qualifyHint=False&autoUpgrade=True), respectively.  
  
### Example  
 Here is a simplified example of creating hidden regions for all pairs of curly braces. It is assumed that the language provides brace matching, and that the braces to be matched include at least the curly braces ({ and }). This approach is for illustrative purposes only. A full implementation would have a complete handling of cases in \<xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource*>. This example also shows how to set the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences.AutoOutlining*> preference to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> temporarily. An alternative is to specify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> named parameter in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute in your language package.  
  
 This example assumes C# rules for comments, strings, and literals.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Language Service Features (Managed Package Framework)](../vs140/legacy-language-service-features1.md)   
 [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md)