---
title: "deque::operator="
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
  - "deque::operator="
  - "="
  - "operator="
  - "std::deque::operator="
  - "deque/std::deque::operator="
  - "std.deque.operator="
  - "deque.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific standard C++ objects"
  - "operator =, deque objects"
  - "operator=, deque objects"
ms.assetid: 77db5b35-e6e8-4a5c-a4df-821a8e68b446
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::operator=
Replaces the elements of this deque using the elements from another deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The deque that provides the new content.|  
  
## Remarks  
 The first override copies elements to this deque from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the source of the assignment. The second override moves elements to this deque from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Elements that are contained in this deque before the operator executes are removed.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [vector Class](../vs140/vector-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)