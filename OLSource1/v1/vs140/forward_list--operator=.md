---
title: "forward_list::operator="
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
  - "forward_list.forward_list.operator="
  - "forward_list::operator="
  - "forward_list/std::forward_list::operator="
  - "forward_list::forward_list::operator="
  - "forward_list.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= method"
ms.assetid: 6d8e0bd8-367d-45cb-b1e3-cc17b7473207
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::operator=
Replaces the elements of the forward list with a copy of another forward list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The forward list being copied into the forward list.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A brace-enclosed initializer list, which behaves just like a sequence of elements of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The first member operator replaces the controlled sequence with a copy of the sequence controlled by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The second member operator replaces the controlled sequence from an object of class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The third member operator is the same as the first, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)