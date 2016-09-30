---
title: "hash_map::find (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_map::find (STL/CLR)"
f1_keywords: 
  - "cliext::hash_map::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find member [STL/CLR]"
ms.assetid: 53ff8d57-2ea4-485e-9419-aed5e3f5affb
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::find (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 If at least one element in the controlled sequence has equivalent ordering with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the member function returns an iterator designating one of those elements; otherwise it returns [end](../vs140/hash_map--end--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to locate an element currently in the controlled sequence that matches a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**find A = False**  
**find b = [b 2]**  
**find C = False**   
## Description  
 Note that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not guarantee which of several element it finds.  
  
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_map](../vs140/hash_map--stl-clr-.md)   
 [equal_range](../vs140/hash_map--equal_range--stl-clr-.md)   
 [lower_bound](../vs140/hash_map--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_map--upper_bound--stl-clr-.md)