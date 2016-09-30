---
title: "set::find (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::find (STL/CLR)"
f1_keywords: 
  - "cliext::set::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find member [STL/CLR]"
ms.assetid: 916e581c-2815-4c07-a51a-6c5ddfa730c1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::find (STL-CLR)
Finds an element that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 If at least one element in the controlled sequence has equivalent ordering with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the member function returns an iterator designating one of those elements; otherwise it returns [end](../vs140/set--end--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You use it to locate an element currently in the controlled sequence that matches a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**find A = False**  
**find b = b**  
**find C = False**   
## Description  
 Note that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not guarantee which of several element it finds.  
  
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [equal_range](../vs140/set--equal_range--stl-clr-.md)   
 [lower_bound](../vs140/set--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/set--upper_bound--stl-clr-.md)