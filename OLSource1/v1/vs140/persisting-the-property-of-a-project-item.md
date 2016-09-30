---
title: "Persisting the Property of a Project Item"
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
  - "properties, adding to a project item"
  - "project items, adding properties"
ms.assetid: d7a0f2b0-d427-4d49-9536-54edfb37c0f3
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Persisting the Property of a Project Item
You may want to persist a property you add to a project item, such as the author of a source file. You can do this by storing the property in the project file.  
  
 The first step to persist a property in a project file is to obtain the hierarchy of the project as an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> interface. You can obtain this interface either by using Automation or by using \<xref:Microsoft.VisualStudio.Shell.Interop.IVsMonitorSelection*>. Once you obtain the interface, you can use it to determine which project item is currently selected. Once you have the project item ID, you can use \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute*> to add the property.  
  
 In the following procedures, you persist the VsPkg.cs property <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> with the value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the project file.  
  
### To obtain the project hierarchy with the DTE object  
  
1.  Add the following code to your VSPackage:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To persist the project item property with the DTE object  
  
1.  Add the following code to the code given in the method in the previous procedure:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### To obtain the project hierarchy using IVsMonitorSelection  
  
1.  Add the following code to your VSPackage:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  
  
### To persist the selected project item property, given the project hierarchy  
  
1.  Add the following code to the code given in the method in the previous procedure:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### To verify that the property is persisted  
  
1.  Start [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and then open or create a solution.  
  
2.  Select the project item VsPkg.cs in **Solution Explorer**.  
  
3.  Use a breakpoint or otherwise determine that your VSPackage is loaded and that SetItemAttribute runs.  
  
    > [!NOTE]
    >  You can autoload a VSPackage in the UI context \<xref:Microsoft.VisualStudio.VSConstants.UICONTEXT_SolutionExists*>. For more information, see [How to: Autoload a VSPackage](../vs140/loading-vspackages.md).  
  
4.  Close [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and then open the project file in Notepad. You should see the \<Author> tag with the value Tom, as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Project Items (Visual Studio SDK)](../vs140/custom-tools.md)