---
title: "list::front"
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
  - "list/std::list::front"
  - "std::list::front"
  - "std.list.front"
  - "list::front"
  - "front"
  - "list.front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "front method, list class"
  - "front method"
ms.assetid: b90b417c-1927-4b34-ba8d-67a5f9140def
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::front
Returns a reference to the first element in a list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the list is empty, the return is undefined.  
  
## Remarks  
 If the return value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the list object cannot be modified. If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a **reference**, the list object can be modified.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element in an empty list.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first integer of c1 is 10**  
**The first integer of c1 is 11**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [list::back and list::front](../vs140/list--back-and-list--front.md)   
 [Standard Template Library](../vs140/standard-template-library.md)