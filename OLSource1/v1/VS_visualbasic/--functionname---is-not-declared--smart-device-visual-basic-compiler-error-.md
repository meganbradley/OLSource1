---
title: "&#39;&lt;functionname&gt;&#39; is not declared (Smart Device-Visual Basic Compiler Error)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "&#39;&lt;functionname&gt;&#39; is not declared (Smart Device/Visual Basic Compiler Error)"
f1_keywords: 
  - "bc30766"
  - "vbc30766"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30766"
ms.assetid: 13918600-6087-40d7-8134-32aa9d3bfda4
caps.latest.revision: 7
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
# &#39;&lt;functionname&gt;&#39; is not declared (Smart Device-Visual Basic Compiler Error)
<`functionname`> is not declared. File I/O functionality is normally available in the `Microsoft.VisualBasic` namespace, but the targeted version of the .NET Compact Framework does not support it.  
  
 **Error ID:** BC30766  
  
### To correct this error  
  
-   Perform file operations with functions defined in the `System.IO` namespace.  
  
## See Also  
 \<xref:System.IO>   
 [File Access with Visual Basic](../VS_visualbasic/file-access-with-visual-basic.md)