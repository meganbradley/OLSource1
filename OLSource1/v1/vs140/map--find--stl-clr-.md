---
title: "map::find (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "map::find (STL/CLR)"
f1_keywords: 
  - "cliext::map::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find member [STL/CLR]"
ms.assetid: 779dcbee-d584-4fbd-b788-481e094ece9d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::find (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 If at least one element in the controlled sequence has equivalent ordering with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the member function returns an iterator designating one of those elements; otherwise it returns [end](../vs140/map--end--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to locate an element currently in the controlled sequence that matches a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**find A = False**  
**find b = [b 2]**  
**find C = False**   
## Description  
 Note that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not guarantee which of several element it finds.  
  
## Requirements  
 **Header:** \<cliext/map>  
  
 **Namespace:** cliext  
  
## See Also  
 [map](../vs140/map--stl-clr-.md)   
 [equal_range](../vs140/map--equal_range--stl-clr-.md)   
 [lower_bound](../vs140/map--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/map--upper_bound--stl-clr-.md)