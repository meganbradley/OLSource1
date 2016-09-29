---
title: "ML Fatal Error A1010"
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
  - "A1010"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "A1010"
ms.assetid: 9e0b5241-67f4-4740-8701-3b2d2d1ad9e4
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ML Fatal Error A1010
**unmatched block nesting :**  
  
 A block beginning did not have a matching end, or a block end did not have a matching beginning. One of the following may be involved:  
  
-   A high-level directive such as [.IF](../VS_csharp/.if.md), [.REPEAT](../VS_csharp/.repeat.md), or [.WHILE](../VS_csharp/.while.md).  
  
-   A conditional-assembly directive such as [IF](../VS_csharp/if--masm-.md), [REPEAT](../VS_csharp/repeat.md), or **WHILE**.  
  
-   A structure or union definition.  
  
-   A procedure definition.  
  
-   A segment definition.  
  
-   A [POPCONTEXT](../VS_csharp/popcontext.md) directive.  
  
-   A conditional-assembly directive, such as an [ELSE](../VS_csharp/else--masm-.md), [ELSEIF](../VS_csharp/elseif--masm-.md), or **ENDIF** without a matching [IF](../VS_csharp/if--masm-.md).  
  
## See Also  
 [ML Error Messages](../VS_csharp/ml-error-messages.md)