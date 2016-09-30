---
title: "map::equal_range (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::equal_range (STL/CLR)"
f1_keywords: 
  - "cliext::map::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range member [STL/CLR]"
ms.assetid: c0d7409c-344d-4102-99c4-aeab8643a073
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [lower_bound](../vs140/map--lower_bound--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [upper_bound](../vs140/map--upper_bound--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**equal_range(L'x') empty = True**  
 **[b 2]**   
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [count](../vs140/map--count--stl-clr-.md)   
 [find](../vs140/map--find--stl-clr-.md)   
 [lower_bound](../vs140/map--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/map--upper_bound--stl-clr-.md)