---
title: "forward_list::insert_after"
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
  - "std.forward_list.insert_after"
  - "std::forward_list::insert_after"
  - "forward_list.insert_after"
  - "insert_after"
  - "forward_list::insert_after"
  - "forward_list/std::forward_list::insert_after"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert_after method"
ms.assetid: 94fb6c2c-4a46-4997-bd62-e703ed5a7bba
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# forward_list::insert_after
Adds elements to the forward list after a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The position in the target forward list where the first element is inserted.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of elements to insert.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The beginning of the insertion range.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The end of the insertion range.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The element added to the forward list.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The initializer_list to insert.|  
  
## Return Value  
 An iterator that designates the newly inserted element (first and last member functions only).  
  
## Remarks  
 Each of the member functions inserts—just after the element pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the controlled sequence—a sequence that' specified by the remaining operands.  
  
 The first member function inserts an element that has value <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and returns an iterator that designates the newly inserted element.  
  
 The second member function inserts a repetition of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an integer type, the third member function behaves the same as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Otherwise, it inserts the sequence <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, which must not overlap the initial controlled sequence.  
  
 The fourth member function inserts the sequence that's specified by an object of class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The last member function is the same as the first, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 Inserting <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> elements causes <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> constructor calls. [Reallocation](../vs140/forward_list-class.md) occurs, but no iterators or references become invalid.  
  
 If an exception is thrown during the insertion of one or more elements, the container is left unaltered and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)