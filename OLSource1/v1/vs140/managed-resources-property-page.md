---
title: "Managed Resources Property Page"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VC.Project.VCManagedResourceCompilerTool.ResourceFileName"
  - "VC.Project.VCManagedResourceCompilerTool.OutputFileName"
  - "VC.Project.VCManagedResourceCompilerTool.DefaultLocalizedResources"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Managed Resources property page"
ms.assetid: 80b80384-ee55-494d-9f0e-907bb98cfc19
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Managed Resources Property Page
Enables settings for the resource compiler.  
  
 The **Managed Resources** property page contains the following properties:  
  
 **Resource Logical Name**  
 Specifies the *logical name* of the generated intermediate .resources file. The logical name is the name used to load the resource. If no logical name is specified, the resource (.resx) file name is used as the logical name.  
  
 **Output File Name**  
 Specifies the name of the final output file that the resource (.resx) file contributes to.  
  
 **Default Localized Resources**  
 Specifies whether the given .resx file contributes to the default resources or to a satellite .dll.  
  
 For information on how to access the **Managed Resources** property page, see [How to: Specify Project Properties with Property Pages](../vs140/how-to--specify-project-properties-with-property-pages.md).  
  
## See Also  
 [Using RC (The RC Command Line)](http://msdn.microsoft.com/library/windows/desktop/aa381055)   
 [Property Pages](../vs140/property-pages--visual-c---.md)   
 [/ASSEMBLYRESOURCE (Embed a Managed Resource)](../vs140/-assemblyresource--embed-a-managed-resource-.md)