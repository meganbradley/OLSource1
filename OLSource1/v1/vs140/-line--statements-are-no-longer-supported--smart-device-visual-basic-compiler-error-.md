---
title: "&#39;Line&#39; statements are no longer supported (Smart Device-Visual Basic Compiler Error)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "&#39;Line&#39; statements are no longer supported (Smart Device/Visual Basic Compiler Error)"
f1_keywords: 
  - "vbc30768"
  - "bc30768"
helpviewer_keywords: 
  - "BC30768"
ms.assetid: e7a17c77-06bb-4d33-966e-addb4f51caaf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Line&#39; statements are no longer supported (Smart Device-Visual Basic Compiler Error)
The `Line` statement is no longer supported. File I/O functionality is normally available as <xref:Microsoft.VisualBasic.FileSystem.LineInput*?displayProperty=fullName>, but the targeted version of the .NET Compact Framework does not support it.  
  
 **Error ID:** BC30768  
  
### To correct this error  
  
-   If performing file access, use the functions defined in the <xref:System.IO*> namespace.  
  
-   If performing graphics, use <xref:System.Drawing.Graphics.DrawLine*?displayProperty=fullName>.  
  
## See Also  
 <xref:System.IO*>   
 <xref:System.Drawing*>   
 [File Access with Visual Basic](../vs140/file-access-with-visual-basic.md)