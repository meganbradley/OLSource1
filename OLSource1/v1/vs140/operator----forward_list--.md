---
title: "operator&gt; (&lt;forward_list&gt;)"
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
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "forward_list/std::operator>"
  - "std::>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "> operator"
  - "operator >, forward_list objects"
  - "operator>, forward_list objects"
ms.assetid: 3967d460-947a-4823-87a9-6ca518ef779c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (&lt;forward_list&gt;)
Tests if the forward list object on the left side of the operator is greater than the forward list object on the right side.  
  
## Syntax  
  
```  
bool operator>(  
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
 `true` if the list on the left side of the operator is greater than the list on the right side of the operator; otherwise `false`.  
  
## Remarks  
 This template function returns `_Right < _Left`.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [\<forward_list>](../vs140/-forward_list-.md)