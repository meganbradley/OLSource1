---
title: "texture_view::operator= Operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 67cb273a-8027-45d3-bc47-fcde31c89ce4
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# texture_view::operator= Operator
Assigns a view of the same texture as the specified `texture_view` to this `texture_view` instance.  
  
## Syntax  
  
```  
texture_view<_Value_type, _Rank>& operator=(        // [1] copy constructor  
   const texture_view<_Value_type, _Rank>& _Other  
) restrict(amp, cpu);  
  
texture_view<const _Value_type, _Rank>& operator=(  // [2] copy constructor  
   const texture_view<_Value_type, _Rank>& _Other  
) restrict(cpu);  
  
texture_view<const _Value_type, _Rank>& operator=(  // [3] copy constructor  
   const texture_view<const _Value_type, _Rank>& _Other  
) restrict(amp, cpu);  
```  
  
#### Parameters  
 `_Other`  
 [1, 2] Copy Constructor  
 A writable `texture_view` object.  
  
 [3] Copy Constructor  
 A non-writable `texture_view` object.  
  
## Return Value  
 A reference to this `texture_view` instance.  
  
## Requirements  
 **Header:** amp_graphics.h  
  
 **Namespace:** concurrency::graphics  
  
## See Also  
 [texture_view Class](../vs140/texture_view-class.md)