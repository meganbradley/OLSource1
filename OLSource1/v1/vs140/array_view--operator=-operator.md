---
title: "array_view::operator= Operator"
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
  - amp/Concurrency::array_view::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator=
ms.assetid: 7c716b87-a34e-4130-b4ef-ba272830f612
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# array_view::operator= Operator
Copies the contents of the specified [array_view](../vs140/array_view-class.md) object to this one.  
  
## Syntax  
  
```  
array_view& operator=(  
   const array_view& _Other  
) restrict(amp,cpu);  
  
array_view& operator=(  
   const array_view<_Value_type, _Rank>& _Other  
) restrict(amp,cpu);  
```  
  
#### Parameters  
 `_Other`  
 The `array_view` object to copy from.  
  
## Return Value  
 A reference to this `array_view` object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array_view Class](../vs140/array_view-class.md)