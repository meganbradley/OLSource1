---
title: "Assembly &#39;&lt;filepath1&gt;&#39; references assembly &#39;&lt;assemblyidentity&gt;&#39;, which is ambiguous between &#39;&lt;filepath2&gt;&#39; (referenced by project &#39;&lt;projectname1&gt;&#39;) and &#39;&lt;filepath3&gt;&#39; (referenced by project &#39;&lt;projectname2&gt;&#39;)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc42204
  - vbc42204
helpviewer_keywords: 
  - BC42204
ms.assetid: b0c3d2b6-2776-4981-b79e-2e36f03d4123
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Assembly &#39;&lt;filepath1&gt;&#39; references assembly &#39;&lt;assemblyidentity&gt;&#39;, which is ambiguous between &#39;&lt;filepath2&gt;&#39; (referenced by project &#39;&lt;projectname1&gt;&#39;) and &#39;&lt;filepath3&gt;&#39; (referenced by project &#39;&lt;projectname2&gt;&#39;)
Assembly '<filepath1\>' references assembly '<assemblyidentity\>', which is ambiguous between '<filepath2\>' (referenced by project '<projectname1\>') and '<filepath3\>' (referenced by project '<projectname2\>'). '<filepath2\>' will be used. If both assemblies are identical, change the references to the same location.  
  
 An assembly accesses a type in another assembly to which it has more than one file reference.  
  
 The compiler cannot guarantee that the files at the different locations hold the same version of the same assembly. Therefore, the file references are ambiguous and the compiler must select one.  
  
 The *assembly identity* includes the assembly's name, version, public key if any, and culture. This information uniquely identifies the assembly.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42204  
  
### To correct this error  
  
1.  Determine which file represents the best choice for the assembly. You might use criteria such as the most recent version, accessibility of the file, and likelihood of being updated when appropriate.  
  
2.  Change all file references to this assembly so they use the identical file path to your chosen file.  
  
## See Also  
 [NOT IN BUILD: Assemblies](assetId:///6c5c7b30-fa78-4f40-b908-120d0743b0e6)   
 [Assemblies Overview](assetId:///2cfebe19-7436-49f1-bd99-3c4019f0b676)   
 [Assembly Benefits](assetId:///77e1831e-9b6d-4a86-91a6-51e1a64271d9)   
 [Project References](../vs140/managing-references-in-a-project.md)   
 [NIB: Managing References](assetId:///910912ce-0dc9-4569-9274-32c44a20cb2c)   
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](assetId:///3bd75d61-f00c-47c0-86a2-dd1f20e231c9)