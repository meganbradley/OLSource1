---
title: "ML Nonfatal Error A2050"
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
  - "A2050"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "A2050"
ms.assetid: 16f3a58f-4bde-48f1-b0e3-2ed9612780a5
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ML Nonfatal Error A2050
**real or BCD number not allowed**  
  
 A floating-point (real) number or binary coded decimal (BCD) constant was used other than as a data initializer.  
  
 One of the following occurred:  
  
-   A real number or a BCD was used in an expression.  
  
-   A real number was used to initialize a directive other than [DWORD](../vs140/dword.md), [QWORD](../vs140/qword.md), or [TBYTE](../vs140/tbyte.md).  
  
-   A BCD was used to initialize a directive other than `TBYTE`.  
  
## See Also  
 [ML Error Messages](../vs140/ml-error-messages.md)