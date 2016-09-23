---
title: "operator!= (&lt;forward_list&gt;)"
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
  - std::!=
  - forward_list/std::operator!=
  - std::operator!=
  - std.operator!=
  - std.!=
  - operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator !=, forward_list objects
  - operator!=, forward_list objects
ms.assetid: 26a8077e-f38b-4682-853f-08388c84237c
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator!= (&lt;forward_list&gt;)
Tests if the forward list object on the left side of the operator is not equal to the forward list object on the right side.  
  
## Syntax  
  
```  
bool operator!=(  
    const forward_list <Type, Allocator>& _Left,  
    const forward_list <Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|An object of type `forward_list`.|  
|`_Right`|An object of type `forward_list`.|  
  
## Return Value  
 **true** if the lists are not equal; **false** if the lists are equal.  
  
## Remarks  
 This template function returns `!(_Left == _Right)`.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [<forward_list>](../vs140/-forward_list-.md)