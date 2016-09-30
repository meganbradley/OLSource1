---
title: "multimap::equal_range (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "multimap::equal_range (STL/CLR)"
f1_keywords: 
  - "cliext::multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range member [STL/CLR]"
ms.assetid: f1008d89-7442-429b-9eca-4ef7ee704766
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The method returns a pair of iterators <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [lower_bound](../vs140/multimap--lower_bound--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [upper_bound](../vs140/multimap--upper_bound--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**equal_range(L'x') empty = True**  
 **[b 2]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [multimap](../vs140/multimap--stl-clr-.md)   
 [count](../vs140/multimap--count--stl-clr-.md)   
 [find](../vs140/multimap--find--stl-clr-.md)   
 [lower_bound](../vs140/multimap--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/multimap--upper_bound--stl-clr-.md)