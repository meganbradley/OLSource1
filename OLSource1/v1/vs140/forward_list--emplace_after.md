---
title: "forward_list::emplace_after"
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
  - "emplace_after"
  - "forward_list::emplace_after"
  - "forward_list/std::forward_list::emplace_after"
  - "std::forward_list::emplace_after"
  - "forward_list.emplace_after"
  - "std.forward_list.emplace_after"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_after method"
ms.assetid: 00998dc7-4c47-43ba-a531-227e3a903585
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::emplace_after
Move constructs a new element after a specified position.  
  
## Syntax  
  
```  
template<class _Ty>  
    iterator emplace_after(const_iterator _Where, Type&& _Val);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Where`|The position in the target forward list where the new element is constructed.|  
|`_Val`|The constructor argument.|  
  
## Return Value  
 An iterator that designates the newly inserted element.  
  
## Remarks  
 This member function inserts an element with the constructor arguments `_Val` just after the element pointed to by `_Where` in the controlled sequence. Its behavior is otherwise the same as [insert_after](../vs140/forward_list--insert_after.md).  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)