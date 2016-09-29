---
title: "operator== (&lt;forward_list&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "forward_list/std::operator=="
  - "std.operator=="
  - "std::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, forward_list objects"
  - "operator==, forward_list objects"
  - "== operator, with specific standard C++ objects"
ms.assetid: 1c5768ee-455c-467d-9124-0b12d35418f1
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;forward_list&gt;)
Tests if the forward list object on the left side of the operator is equal to the forward list object on the right side.  
  
## Syntax  
  
```  
bool operator==(  
    const forward_list <Type, Allocator>& _Left,  
    const forward_list <Type, Allocator>& _Right  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Left`|An object of type `forward_list`.|  
|`_Right`|An object of type `forward_list`.|  
  
## Remarks  
 This template function overloads `operator==` to compare two objects of template class `forward_list`. The function returns `distance(_Left.begin(), end()) == distance(_Right.begin(),_Right.end()) && equal(_Left. begin(),_Left. end(),_Right.begin())`.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [<forward_list>](../vs140/-forward_list-.md)