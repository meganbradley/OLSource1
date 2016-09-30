---
title: "Contributing to the Add New Item Dialog Box"
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
  - "Add New Item dialog box, contributing to"
ms.assetid: b2e53175-9372-4d17-8c2b-9264c9e51e9c
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Contributing to the Add New Item Dialog Box
A project subtype can provide a complete new directory of items for the **Add New Item** dialog box by registering **Add Item** templates under the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> registry subkey.  
  
## Registering Add New Item Templates  
 This section is located under **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Projects** in the registry. The registry entries below assume a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project aggregated by a hypothetical project subtype. The entries for the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project are listed below.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> subkey contains registry entries with the path to the directory where items made available in the **Add New Item** dialog box are placed.  
  
 The environment automatically loads all of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data under the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> registry subkey. This can include the data for base project implementations as well as the data for specific project subtype types. Each project subtype is identified by a project type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The project subtype can specify that an alternate set of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> templates should be used for a particular flavored project instance by supporting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> enumeration from \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2*> in \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty*> implementation to return the GUID value of the project subtype. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property is not specified, the base project GUID is used.  
  
 You can filter items in the **Add New Item** dialog box by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg*> interface on the project subtype aggregator object. For example, a project subtype that implements a database project by aggregating a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project, can filter the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] specific items from the **Add New Item** dialog box by implementing filtering, and in turn, can add database project specific items by supporting <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty*>. For more information on filtering and adding items to the **Add New Item** dialog box, see [Add Items to the Add New Item Dialog Boxes](../vs140/adding-items-to-the-add-new-item-dialog-boxes.md).  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2*>   
 [CATIDs for Objects Commonly Used to Extend Projects](../vs140/catids-for-objects-that-are-typically-used-to-extend-projects.md)