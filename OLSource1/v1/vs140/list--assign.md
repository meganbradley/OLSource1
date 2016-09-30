---
title: "list::assign"
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
  - "list::assign"
  - "list.assign"
  - "assign"
  - "std.list.assign"
  - "list/std::list::assign"
  - "Assign"
  - "std::list::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: 11910f04-6827-48c8-97a3-01043b566df7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::assign
Erases elements from a list and copies a new set of elements to a target list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied from the argument list.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element just beyond the range of elements to be copied from the argument list.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value of the element being inserted into the list.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The initializer_list that contains the elements to be inserted.  
  
## Remarks  
 After erasing any existing elements in the target list, assign either inserts a specified range of elements from the original list or from some other list into the target list or inserts copies of a new element of a specified value into the target list  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **c1 = 10 20 30c1 = 50 60c1 = 4 4 4 4 4 4 4c1 = 10 20 30 40**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)