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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ML Fatal Error A1011
**directive must be in control block**  
  
 The assembler found a high-level directive where one was not expected. One of the following directives was found:  
  
-   [.ELSE](../vs140/.else.md) without [.IF](../vs140/.if.md)  
  
-   [.ENDIF](../vs140/.endif.md) without [.IF](../vs140/.if.md)  
  
-   [.ENDW](../vs140/.endw.md) without [.WHILE](../vs140/.while.md)  
  
-   [.UNTILCXZ](../vs140/.untilcxz.md) without [.REPEAT](../vs140/.repeat.md)  
  
-   [.CONTINUE](../vs140/.continue.md) without [.WHILE](../vs140/.while.md) or [.REPEAT](../vs140/.repeat.md)  
  
-   [.BREAK](../vs140/.break.md) without [.WHILE](../vs140/.while.md) or [.REPEAT](../vs140/.repeat.md)  
  
-   [.ELSE](../vs140/.else.md) following `.ELSE`  
  
## See Also  
 [ML Error Messages](../vs140/ml-error-messages.md)