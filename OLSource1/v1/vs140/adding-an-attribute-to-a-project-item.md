---
title: "Adding an Attribute to a Project Item"
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
  - "attributes [Visual Studio], adding to a project item"
ms.assetid: 404a71d5-cce5-44e7-9eaf-d747c794fedb
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding an Attribute to a Project Item
The methods \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.GetItemAttribute*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute*> get and set the value of the attributes of a project item. SetItemAttribute creates the attribute if it does not already exist, adding it to the project item metadata.  
  
## Adding an attribute to a project item  
  
#### To add an attribute to a project item  
  
-   The following code uses the \<xref:EnvDTE.DTE*> automation object and the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute*> method to add an attribute to a project item. The project item ID is obtained from the project item name "program.cs". The attribute "MyAttribute" is added to this project item and given the value "MyValue".  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Persisting Data in the MSBuild Project File](../vs140/persisting-data-in-the-msbuild-project-file.md)