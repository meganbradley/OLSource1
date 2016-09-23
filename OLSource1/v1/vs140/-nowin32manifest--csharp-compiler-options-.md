---
title: "-nowin32manifest (C# Compiler Options)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
H1: /nowin32manifest (C# Compiler Options)
f1_keywords: 
  - /nowin32manifest
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - nowin32manifest compiler option [C#]
  - -nowin32manifest compiler option [C#]
  - /nowin32manifest compiler option [C#]
ms.assetid: 6f06365b-b87b-46a2-b187-b3bfeaf4862d
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -nowin32manifest (C# Compiler Options)
Use the **/nowin32manifest** option to instruct the compiler not to embed any application manifest into the executable file.  
  
## Syntax  
  
```  
/nowin32manifest  
```  
  
## Remarks  
 When this option is used, the application will be subject to virtualization on Windows Vista unless you provide an application manifest in a Win32 Resource file or during a later build step.  
  
 In Visual Studio, set this option in the **Application Property** page by selecting the **Create Application Without a Manifest** option in the **Manifest** drop down list. For more information, see [Application Page, Project Designer (C#)](../vs140/application-page--project-designer--csharp-.md).  
  
 For more information about manifest creation, see [/win32manifest](../vs140/-win32manifest--csharp-compiler-options-.md).  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)