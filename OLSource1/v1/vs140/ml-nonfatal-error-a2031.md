---
title: "ML Nonfatal Error A2031"
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
  - "A2031"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "A2031"
ms.assetid: d5b11f58-4a00-42be-9062-8fa8728e6306
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ML Nonfatal Error A2031
**must be index or base register**  
  
 An attempt was made to use a register that was not a base or index register in a memory expression.  
  
 For example, the following expressions cause this error:  
  
```  
[ax]  
[bl]  
```  
  
## See Also  
 [ML Error Messages](../vs140/ml-error-messages.md)