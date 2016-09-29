---
title: "forward_list::push_front"
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
  - "forward_list.push_front"
  - "std.forward_list.push_front"
  - "push_front"
  - "forward_list::push_front"
  - "std::forward_list::push_front"
  - "forward_list/std::forward_list::push_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_front method"
ms.assetid: 0b1428a3-cbad-4441-a5c5-2ea48b854edc
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::push_front
Adds an element to the beginning of a forward list.  
  
## Syntax  
  
```  
void push_front(const Type& _Val);  
void push_front(Type&& _Val);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`_Val`|The element added to the beginning of the forward list.|  
  
## Remarks  
 If an exception is thrown, the container is left unaltered and the exception is rethrown.  
  
## Requirements  
 **Header:** <forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)