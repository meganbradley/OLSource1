---
title: "Error embedding Win32 manifest: &lt;manifest&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31191"
  - "bc31191"
helpviewer_keywords: 
  - "BC31191"
ms.assetid: 5babed58-d024-4acd-9838-fab8f07c4a37
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error embedding Win32 manifest: &lt;manifest&gt;
The file specified for the `/win32manifest` compiler option cannot be embedded. This can be a result of insufficient security privileges to the manifest file.  
  
 **Error ID:** BC31191  
  
### To correct this error  
  
1.  Ensure that the identity running the Visual Basic compiler command has access to the Win32 manifest file.  
  
## See Also  
 [/win32manifest (Visual Basic)](../vs140/-win32manifest--visual-basic-.md)   
 [Visual Basic Compiler](../vs140/visual-basic-command-line-compiler.md)