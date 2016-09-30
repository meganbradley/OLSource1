---
title: "Web Site Support Attributes"
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
  - "web site projects, registration"
ms.assetid: 46d52e2c-ca2a-4bbd-8500-5b0129768aec
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Web Site Support Attributes
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Web site project can be extended to provide support for Web programming languages. The language must register itself with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] so that project templates can appear in the **New Web Site** dialog box when the language is selected.  
  
 The IronPython Studio sample includes web site support. You can find it with the [Visual Studio Extensibility samples](../vs140/vssdk-samples.md). It includes the following attribute classes to register IronPython as a codebehind language for new Web projects.  
  
## WebSiteProjectAttribute  
 This attribute is placed on the language project. It adds the language to the list of Web programming languages in the **Language** list in the **New Web Site** dialog box. For example, the following adds IronPython to the list:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This attribute also sets the templates path to point to the templates folder. For more information on the location of the templates folder, see [Web Site Project Templates](../vs140/web-site-support-templates.md).  
  
## WebSiteProjectRelatedFilesAttribute  
 This attribute is placed on the language project. It allows the Web Site project to nest one file type (related) under another file type (primary) in the **Solution Explorer**.  
  
 For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 specifies that an IronPython codebehind file is related to an .aspx file. When a new .aspx Web page is created in an IronPython Web site solution, a new .py source file is generated and appears as a child node of the .aspx page.  
  
## ProvideIntellisenseProviderAttribute  
 This attribute is placed on the language project package. It selects the Intellisense provider for the language.  
  
 For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 specifies that an instance of PythonIntellisenseProvider, which implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsIntellisenseProject*>, should be created on demand to provide language services.  
  
 The IVsIntellisenseProject implementation handles references and calls the language compiler when a Web page with code is requested but is not cached.  
  
## See Also  
 [Web Site Support](../vs140/web-site-support.md)