---
title: "Adding and Removing Property Pages"
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
  - "property pages, adding"
  - "property pages, project subtypes"
  - "property pages, removing"
ms.assetid: 34853412-ab8a-4caa-9601-7d0727b2985d
caps.latest.revision: 33
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding and Removing Property Pages
The Project Designer provides a centralized location for managing project properties, settings, and resources in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. It appears as a single window in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) and contains a number of panes on the right that are accessed through the tabs on the left. The panes (often referred to as property pages) in the Project Designer vary by project type and language. The Project Designer can be accessed with the **Properties** command on the **Project** menu.  
  
 A project subtype frequently needs to display additional property pages in the Project Designer. Likewise, some project subtypes might require that built-in property pages be removed. To do either, your project subtype must implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> interface and override the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty*> method. By overriding this method and using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter containing one of the values of the \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2*> enumeration, you can filter, add or remove project properties. For example, you might need to add a page to the configuration-dependent property pages. To do this, you need to filter configuration-dependent property pages and then add a new page to the existing list.  
  
## Adding and Removing Property Pages in Project Designer  
  
#### To remove a property page in Project Designer  
  
1.  Override the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method to filter property pages and obtain a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> list.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Remove the **Build Events** page from obtained <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> list.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To add a property page in Project Designer  
  
1.  Create a property page you want to add.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
2.  Register your new property page.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
3.  Override the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method to filter property pages, obtain a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> list and add a new property page.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
> [!NOTE]
>  All code examples provided in this topic are parts of a larger example, [Visual Studio Extensibility Samples](../vs140/vssdk-samples.md).  
  
## See Also  
 [Project Subtypes](../vs140/project-subtypes.md)