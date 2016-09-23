---
title: "Compiler Warning (level 1) C4180"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4180
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4180
ms.assetid: 40c91bd4-37f1-4d59-a4f3-d5ddab68239b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4180
qualifier applied to function type has no meaning; ignored  
  
 A qualifier, such as **const**, is applied to a function type defined by `typedef`.  
  
## Example  
  
```  
// C4180.cpp  
// compile with: /W1 /c  
typedef int FuncType(void);  
  
// the const qualifier cannot be applied to the  
// function type FuncType  
const FuncType f;   // C4180  
```