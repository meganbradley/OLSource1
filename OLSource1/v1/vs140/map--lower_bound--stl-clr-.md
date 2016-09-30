---
title: "map::lower_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::lower_bound (STL/CLR)"
f1_keywords: 
  - "cliext::map::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound member [STL/CLR]"
ms.assetid: 959651a0-f949-4cc1-859b-248b6930f16c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::lower_bound (STL-CLR)
Finds beginning of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the first element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that has equivalent ordering to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no such element exists, it returns [end](../vs140/map--end--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to locate the beginning of a sequence of elements currently in the controlled sequence that match a specified key.  
  
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
 [map](../vs140/map--stl-clr-.md)   
 [count](../vs140/map--count--stl-clr-.md)   
 [equal_range](../vs140/map--equal_range--stl-clr-.md)   
 [find](../vs140/map--find--stl-clr-.md)   
 [upper_bound](../vs140/map--upper_bound--stl-clr-.md)