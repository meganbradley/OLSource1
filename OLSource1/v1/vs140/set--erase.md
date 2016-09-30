---
title: "set::erase"
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
  - "std::set::erase"
  - "set::erase"
  - "erase"
  - "set/std::set::erase"
  - "set.erase"
  - "std.set.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 959f262f-5829-4e53-a029-eaea8f21021a
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::erase
Removes an element or a range of elements in a set from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the set if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the set.  
  
## Remarks  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [\<set>](../vs140/-set-.md)   
 [set Class](../vs140/set-class.md)   
 [set::clear](../vs140/set--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)