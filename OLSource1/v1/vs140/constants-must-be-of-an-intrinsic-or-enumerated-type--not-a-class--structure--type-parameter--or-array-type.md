---
title: "Constants must be of an intrinsic or enumerated type, not a class, structure, type parameter, or array type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30424"
  - "bc30424"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30424"
ms.assetid: 2d402c2f-27ad-428b-b699-d45cd62f7196
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constants must be of an intrinsic or enumerated type, not a class, structure, type parameter, or array type
You have attempted to declare a constant as a class, structure, or array type, or as a type parameter defined by a containing generic type.  
  
 Constants must be of an intrinsic type (`Boolean`, `Byte`, `Date`, `Decimal`, `Double`, `Integer`, `Long`, `Object`, `SByte`, `Short`, `Single`, `String`, `UInteger`, `ULong`, or `UShort`), or an `Enum` type based on one of the integral types.  
  
 **Error ID:** BC30424  
  
### To correct this error  
  
1.  Declare the constant as an intrinsic or `Enum` type.  
  
2.  A constant can also be a special value such as `True`, `False`, or `Nothing`. The compiler considers these predefined values to be of the appropriate intrinsic type.  
  
## See Also  
 [Constants and Enumerations](../vs140/constants-and-enumerations--visual-basic-.md)   
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md)