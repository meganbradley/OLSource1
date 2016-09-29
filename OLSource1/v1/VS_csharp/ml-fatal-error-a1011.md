---
title: "ML Fatal Error A1011"
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
  - "A1011"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "A1011"
ms.assetid: 7fbf092d-4189-4330-a884-dfa2268fc3dd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ML Fatal Error A1011
**directive must be in control block**  
  
 The assembler found a high-level directive where one was not expected. One of the following directives was found:  
  
-   [.ELSE](../VS_csharp/.else.md) without [.IF](../VS_csharp/.if.md)  
  
-   [.ENDIF](../VS_csharp/.endif.md) without [.IF](../VS_csharp/.if.md)  
  
-   [.ENDW](../VS_csharp/.endw.md) without [.WHILE](../VS_csharp/.while.md)  
  
-   [.UNTILCXZ](../VS_csharp/.untilcxz.md) without [.REPEAT](../VS_csharp/.repeat.md)  
  
-   [.CONTINUE](../VS_csharp/.continue.md) without [.WHILE](../VS_csharp/.while.md) or [.REPEAT](../VS_csharp/.repeat.md)  
  
-   [.BREAK](../VS_csharp/.break.md) without [.WHILE](../VS_csharp/.while.md) or [.REPEAT](../VS_csharp/.repeat.md)  
  
-   [.ELSE](../VS_csharp/.else.md) following `.ELSE`  
  
## See Also  
 [ML Error Messages](../VS_csharp/ml-error-messages.md)