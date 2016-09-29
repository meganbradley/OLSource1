---
title: "&#39;Line&#39; statements are no longer supported (Visual Basic Compiler Error)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30830"
  - "vbc30830"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30830"
ms.assetid: 4734bc1d-882e-4555-b498-1f1ec0399d16
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Line&#39; statements are no longer supported (Visual Basic Compiler Error)
Line statements are no longer supported. File I/O functionality is available as `Microsoft.VisualBasic.FileSystem.LineInput` and graphics functionality is available as `System.Drawing.Graphics.DrawLine`.  
  
 **Error ID:** BC30830  
  
### To correct this error  
  
1.  If performing file access, use `Microsoft.VisualBasic.FileSystem.LineInput`.  
  
2.  If performing graphics, use `System.Drawing.Graphics.Drawline`.  
  
## See Also  
 <xref:System.IO*>   
 <xref:System.Drawing*>   
 [File Access with Visual Basic](../VS_csharp/file-access-with-visual-basic.md)