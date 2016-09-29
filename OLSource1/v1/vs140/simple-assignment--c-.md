---
title: "Simple Assignment (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "type conversion [C++], simple assignment"
  - "data type conversion [C++], simple assignment"
  - "operators [C], simple assignment"
  - "assignment operators [C++], simple"
  - "simple assignment operator"
  - "equal sign"
ms.assetid: e7140a0a-7104-4b3a-b293-7adcc1fdd52b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Simple Assignment (C)
The simple-assignment operator assigns its right operand to its left operand. The value of the right operand is converted to the type of the assignment expression and replaces the value stored in the object designated by the left operand. The conversion rules for assignment apply (see [Assignment Conversions](../vs140/assignment-conversions.md)).  
  
```  
double x;  
int y;  
  
x = y;  
```  
  
 In this example, the value of `y` is converted to type **double** and assigned to `x`.  
  
## See Also  
 [C Assignment Operators](../vs140/c-assignment-operators.md)