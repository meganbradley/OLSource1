---
title: "Accessing Visual Studio or other Hosts from a Text Template"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a68886da-7416-4785-8145-3796bb382cba
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing Visual Studio or other Hosts from a Text Template
In a text template, you can use methods and properties exposed by the host that executes the template, such as [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 This applies to regular text templates, not preprocessed text templates.  
  
## Obtaining access to the host  
 Set <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive. This lets you use  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which has type \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost*>. This type has members that you can use, for example, to resolve file names and to log errors.  
  
### Resolving File Names  
 To find the full path of a file relative to the text template, use this.Host.ResolvePath().  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Displaying Error Messages  
 This example logs messages when you transform the template. If the host is [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], they are added to the error window.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Using the Visual Studio API  
 If you are executing a text template in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to access services provided by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and any packages or extensions that are loaded.  
  
 Set hostspecific="true" and cast <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to \<xref:System.IServiceProvider*>.  
  
 This example gets the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] API, \<xref:EnvDTE.DTE*>, as a service:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Using hostSpecific with template inheritance  
 Specify <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if you also use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute, and if you inherit from a template that specifies <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This avoids a compiler warning to the effect that the property <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> has been declared twice.