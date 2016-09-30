---
title: "map::upper_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::upper_bound (STL/CLR)"
f1_keywords: 
  - "cliext::map::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound member [STL/CLR]"
ms.assetid: d772b4a8-d0dc-439a-8b5b-3c91836d9256
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::upper_bound (STL-CLR)
Finds end of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the last element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that has equivalent ordering to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If no such element exists, or if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the last element in the controlled sequence, it returns [end](../vs140/map--end--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates the first element beyond <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to locate the end of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**upper_bound(L'x')==end() = True**  
**\*upper_bound(L'a') = [b 2]**  
**\*upper_bound(L'b') = [c 3]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [count](../vs140/map--count--stl-clr-.md)   
 [equal_range](../vs140/map--equal_range--stl-clr-.md)   
 [find](../vs140/map--find--stl-clr-.md)   
 [lower_bound](../vs140/map--lower_bound--stl-clr-.md)