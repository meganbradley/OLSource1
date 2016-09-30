---
title: "set::equal_range (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::equal_range (STL/CLR)"
f1_keywords: 
  - "cliext::set::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range member [STL/CLR]"
ms.assetid: f0b20a65-f37a-44b1-a291-09c33c10c355
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [lower_bound](../vs140/set--lower_bound--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [upper_bound](../vs140/set--upper_bound--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**equal_range(L'x') empty = True**  
 **b**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [count](../vs140/set--count--stl-clr-.md)   
 [find](../vs140/set--find--stl-clr-.md)   
 [lower_bound](../vs140/set--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/set--upper_bound--stl-clr-.md)