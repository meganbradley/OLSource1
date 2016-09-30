---
title: "multimap::lower_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::lower_bound (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound member [STL/CLR]"
ms.assetid: b8f9b2c2-ebcd-4553-b410-75fd8d472a49
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::lower_bound (STL-CLR)
Finds beginning of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the first element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that has equivalent ordering to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no such element exists, it returns [end](../vs140/multimap--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to locate the beginning of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**lower_bound(L'x')==end() = True**  
**\*lower_bound(L'a') = [a 1]**  
**\*lower_bound(L'b') = [b 2]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [count](../vs140/multimap--count--stl-clr-.md)   
 [equal_range](../vs140/multimap--equal_range--stl-clr-.md)   
 [find](../vs140/multimap--find--stl-clr-.md)   
 [upper_bound](../vs140/multimap--upper_bound--stl-clr-.md)