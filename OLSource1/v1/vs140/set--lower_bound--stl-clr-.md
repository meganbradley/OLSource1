---
title: "set::lower_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::lower_bound (STL/CLR)"
f1_keywords: 
  - "cliext::set::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound member [STL/CLR]"
ms.assetid: d4da5b8b-ddf2-4d36-8092-f1be81b42348
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::lower_bound (STL-CLR)
Finds beginning of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the first element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that has equivalent ordering to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no such element exists, it returns [end](../vs140/set--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to locate the beginning of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**lower_bound(L'x')==end() = True**  
**\*lower_bound(L'a') = a**  
**\*lower_bound(L'b') = b**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [count](../vs140/set--count--stl-clr-.md)   
 [equal_range](../vs140/set--equal_range--stl-clr-.md)   
 [find](../vs140/set--find--stl-clr-.md)   
 [upper_bound](../vs140/set--upper_bound--stl-clr-.md)