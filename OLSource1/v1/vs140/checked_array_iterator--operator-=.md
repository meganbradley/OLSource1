---
title: "checked_array_iterator::operator&lt;="
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
  - operator<=
  - checked_array_iterator::operator<=
  - iterator/checked_array_iterator::operator<=
  - checked_array_iterator.operator<=
  - std.checked_array_iterator.operator<=
  - <=
  - std::checked_array_iterator::operator<=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator <=, iterators
  - <= operator, with specific standard C<= library objects
  - operator<=, iterators
ms.assetid: 134ecdc6-5a2d-4e26-b4e5-6fc62301cc36
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# checked_array_iterator::operator&lt;=
Tests if the `checked_array_iterator` on the left side of the operator is less than or equal to the `checked_array_iterator` on the right side.  
  
## Syntax  
  
```  
bool operator<=(  
   const checked_array_iterator<_Iterator>& _Right  
) const;  
```  
  
#### Parameters  
 `_Right`  
 The `checked_array_iterator` to compare against.  
  
## Remarks  
 See [checked_array_iterator::operator>=](../vs140/checked_array_iterator--operator-=.md) for a code sample.  
  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)