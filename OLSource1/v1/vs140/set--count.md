---
title: "set::count"
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
  - "set::count"
  - "std.set.count"
  - "set/std::set::count"
  - "set.count"
  - "count"
  - "std::set::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 6688fb52-0774-4b0d-9171-3e8bab24bd15
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::count
Returns the number of elements in a set whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the set.  
  
## Return Value  
 1 if the set contains an element whose sort key matches the parameter key. 0 if the set does not contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the following range:  
  
 [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (_*Key* ), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (\_*Key* ) ).  
  
## Example  
 The following example demonstrates the use of the set::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in s1 with a sort key of 1 is: 1.**  
**The number of elements in s1 with a sort key of 2 is: 0.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::count](../vs140/set--count--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)