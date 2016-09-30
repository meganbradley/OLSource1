---
title: "Reformatting Code in a Legacy Language Service"
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
  - "reformatting code, supporting in language services [managed package framework]"
  - "language services [managed package framework], reformatting code"
ms.assetid: 08bb3375-8fef-4f4e-9efa-0d7333bab0eb
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Reformatting Code in a Legacy Language Service
In [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] source code can be reformatted by normalizing the use of indentations and whitespace. This can include inserting or removing spaces or tabs at the beginning of each line, adding new lines between lines, or replacing spaces with tabs or tabs with spaces.  
  
> [!NOTE]
>  **Note** Inserting or deleting newline characters can affect markers such as breakpoints and bookmarks, but adding or removing spaces or tabs does not affect markers.  
  
 Users can start a reformatting operation by selecting **Format Selection** or **Format Document** from the **Advanced** menu on the **Edit** menu. A reformatting operation can also be triggered when a code snippet or a particular character is inserted. For example, when you type a closing brace in C#, everything between the matching open brace and the close brace is automatically indented to the proper level.  
  
 When [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] sends the **Format Selection** or **Format Document** command to the language service, the \<xref:Microsoft.VisualStudio.Package.ViewFilter*> class calls the \<xref:Microsoft.VisualStudio.Package.Source.ReformatSpan*> method in the \<xref:Microsoft.VisualStudio.Package.Source*> class. To support formatting you must override the \<xref:Microsoft.VisualStudio.Package.Source.ReformatSpan*> method and supply your own formatting code.  
  
## Enabling Support for Reformatting  
 To support formatting, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of the \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*> must be set to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when you register your VSPackage. This sets the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableFormatSelection*> property to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The \<xref:Microsoft.VisualStudio.Package.ViewFilter.CanReformat*> method returns the value of this property. If it returns true, the \<xref:Microsoft.VisualStudio.Package.ViewFilter*> class calls the \<xref:Microsoft.VisualStudio.Package.Source.ReformatSpan*>.  
  
## Implementing Reformatting  
 To implement reformatting, you must derive a class from the \<xref:Microsoft.VisualStudio.Package.Source*> class and override the \<xref:Microsoft.VisualStudio.Package.Source.ReformatSpan*> method. The \<xref:Microsoft.VisualStudio.TextManager.Interop.TextSpan*> object describes the span to format and the \<xref:Microsoft.VisualStudio.Package.EditArray*> object holds the edits made on the span. Note that this span can be the entire document. However, since there are likely to be multiple changes made to the span, all the changes should be reversible in a single action. To do this, wrap all changes in a \<xref:Microsoft.VisualStudio.Package.CompoundAction*> object (see "Using the CompoundAction Class" section in this topic).  
  
### Example  
 The following example ensures there is a single space after every comma in the selection, unless the comma is followed by a tab or is at the end of the line. Trailing spaces after the last comma in a line are deleted. See the "Using the CompoundAction Class" section in this topic to see how this method is called from the \<xref:Microsoft.VisualStudio.Package.Source.ReformatSpan*> method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Using the CompoundAction Class  
 All the reformatting done on a section of code should be reversible in a single action. This can be accomplished using a \<xref:Microsoft.VisualStudio.Package.CompoundAction*> class. This class wraps a set of edit operations on the text buffer into a single edit operation.  
  
### Example  
 Here is an example of how to use the \<xref:Microsoft.VisualStudio.Package.CompoundAction*> class. See the example in the "Implementing Support for Formatting" section in this topic for an example of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Language Service Features (Managed Package Framework)](../vs140/legacy-language-service-features1.md)