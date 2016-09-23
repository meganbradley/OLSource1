---
title: "ML Nonfatal Error A2008"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - A2008
dev_langs: 
  - C++
helpviewer_keywords: 
  - A2008
ms.assetid: ca24157f-c88a-4678-ae06-3bc3cd956001
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ML Nonfatal Error A2008
**syntax error :**  
  
 A token at the current location caused a syntax error.  
  
 One of the following may have occurred:  
  
-   A dot prefix was added to or omitted from a directive.  
  
-   A reserved word (such as **C** or **SIZE**) was used as an identifier.  
  
-   An instruction was used that was not available with the current processor or coprocessor selection.  
  
-   A comparison run-time operator (such as `==`) was used in a conditional assembly statement instead of a relational operator (such as [EQ](../vs140/operator-eq.md)).  
  
-   An instruction or directive was given too few operands.  
  
-   An obsolete directive was used.  
  
## See Also  
 [ML Error Messages](../vs140/ml-error-messages.md)