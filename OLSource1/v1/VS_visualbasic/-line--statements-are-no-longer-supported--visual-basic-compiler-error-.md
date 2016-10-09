---
title: "&#39;Line&#39; statements are no longer supported (Visual Basic Compiler Error)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 11
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# &#39;Line&#39; statements are no longer supported (Visual Basic Compiler Error)
Line statements are no longer supported. File I/O functionality is available as `Microsoft.VisualBasic.FileSystem.LineInput` and graphics functionality is available as `System.Drawing.Graphics.DrawLine`.  
  
 **Error ID:** BC30830  
  
### To correct this error  
  
1.  If performing file access, use `Microsoft.VisualBasic.FileSystem.LineInput`.  
  
2.  If performing graphics, use `System.Drawing.Graphics.Drawline`.  
  
## See Also  
 \<xref:System.IO>   
 \<xref:System.Drawing>   
 [File Access with Visual Basic](../VS_visualbasic/file-access-with-visual-basic.md)