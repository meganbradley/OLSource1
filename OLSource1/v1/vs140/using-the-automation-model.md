---
title: "Using the Automation Model"
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
  - "automation [Visual Studio SDK], automation model"
ms.assetid: 0c7f7889-fbfb-4b19-804f-b742138baecd
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Using the Automation Model
After you have connected your VSPackage to automation, you can obtain the properties and methods by calling the \<xref:EnvDTE.DTEClass.GetObject*> method on the \<xref:EnvDTE._DTE*> object, passing a string representing the object you wish to retrieve.  
  
## Obtaining Project Objects  
 The following are two code examples that show how an automation consumer obtains the project automation objects. For information about how to get the DTE object, see [How to: Get References to the DTE and DTE2 Objects](assetId:///c92e3c8e-82e6-4a67-85da-e43c50ffd8e4).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 At this point, you can use the standard project objects that are part of a specific VSPackage to move down the hierarchy model.  
  
 The following code example shows how to get a custom object that is a property of a custom project type.:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following code lists the names of all of the properties in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment **General** option on the **Tools** menu:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 \<xref:EnvDTE.DTEClass.GetObject*>