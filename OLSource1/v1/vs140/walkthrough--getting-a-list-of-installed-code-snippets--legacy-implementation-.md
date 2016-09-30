---
title: "Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "snippets, retrieving list"
  - "code snippets, retrieving list"
  - "GetSnippets method"
ms.assetid: 7d142f8b-35b1-44c4-a13e-f89f6460c906
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)
A code snippet is a piece of code that can be inserted into the source buffer either with a menu command (which allows choosing among a list of installed code snippets) or by selecting a snippet shortcut from an IntelliSense completion list.  
  
 The \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsExpansionManager.EnumerateExpansions*> method gets all code snippets for a specific language GUID. The shortcuts for those snippets can be inserted into an IntelliSense completion list.  
  
 See [Supporting Code Snippets (Managed Package Framework)](../vs140/support-for-code-snippets-in-a-legacy-language-service.md) for details about implementing code snippets in a managed package framework (MPF) language service.  
  
### To retrieve a list of code snippets  
  
1.  The following code shows how to get a list of code snippets for a given language. The results are stored in an array of \<xref:Microsoft.VisualStudio.TextManager.Interop.VsExpansion*> structures. This method uses the static \<xref:Microsoft.VisualStudio.Shell.Package.GetGlobalService*> method to get the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextManager*> interface from the \<xref:Microsoft.VisualStudio.TextManager.Interop.SVsTextManager*> service. However, you can also use the service provider given to your VSPackage and call the \<xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService*> method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To call the GetSnippets method  
  
1.  The following method shows how to call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method at the completion of a parsing operation. The \<xref:Microsoft.VisualStudio.Package.LanguageService.OnParseComplete*> method is called after a parsing operation that was started with the reason \<xref:Microsoft.VisualStudio.Package.ParseReason.Check*>.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array listis cached for performance reasons. Changes to the snippets are not reflected in the list until the language service is stopped and reloaded (for example, by stopping and restarting [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### To use the snippet information  
  
1.  The following code shows how to use the snippet information returned by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method is called from the parser in response to any parse reason that is used to populate a list of code snippets. This should take place after the full parse has been done for the first time.  
  
     The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method builds a list of declarations that is later displayed in a completion list.  
  
     The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class contains all the information that can be displayed in a completion list as well as the type of declaration.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Supporting Code Snippets (Managed Package Framework)](../vs140/support-for-code-snippets-in-a-legacy-language-service.md)