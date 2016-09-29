---
title: "-nowin32manifest (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/nowin32manifest (Visual Basic)"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/nowin32manifest compiler option [Visual Basic]"
  - "nowin32manifest compiler option [Visual Basic]"
  - "-nowin32manifest compiler option [Visual Basic]"
ms.assetid: c0528aae-83b3-4425-99f0-19448e9843e3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -nowin32manifest (Visual Basic)
Instructs the compiler not to embed any application manifest into the executable file.  
  
## Syntax  
  
```  
/nowin32manifest  
```  
  
## Remarks  
 When this option is used, the application will be subject to virtualization on Windows Vista unless you provide an application manifest in a Win32 Resource file or during a later build step. For more information about virtualization, see [ClickOnce Deployment on Windows Vista](../vs140/clickonce-deployment-on-windows-vista.md).  
  
 For more information about manifest creation, see [/win32manifest (Visual Basic)](../vs140/-win32manifest--visual-basic-.md).  
  
## See Also  
 [Visual Basic Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md)