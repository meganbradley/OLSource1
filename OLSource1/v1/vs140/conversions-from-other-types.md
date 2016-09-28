---
title: "Conversions from Other Types"
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
  - "values, converting"
  - "type casts, conversion"
ms.assetid: 30fbd974-8f5a-4b70-ac44-d3937b96b702
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversions from Other Types
Since an `enum` value is an `int` value by definition, conversions to and from an `enum` value are the same as those for the `int` type. For the Microsoft C compiler, an integer is the same as a **long**.  
  
 **Microsoft Specific**  
  
 No conversions between structure or union types are allowed.  
  
 Any value can be converted to type `void`, but the result of such a conversion can be used only in a context where an expression value is discarded, such as in an expression statement.  
  
 The `void` type has no value, by definition. Therefore, it cannot be converted to any other type, and other types cannot be converted to `void` by assignment. However, you can explicitly cast a value to type `void`, as discussed in [Type-Cast Conversions](../vs140/type-cast-conversions.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [Assignment Conversions](../vs140/assignment-conversions.md)