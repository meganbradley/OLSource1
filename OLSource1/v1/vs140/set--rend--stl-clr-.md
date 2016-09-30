---
title: "set::rend (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set::rend (STL/CLR)"
f1_keywords: 
  - "cliext::set::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend member [STL/CLR]"
ms.assetid: 4a98d138-ad89-4dee-b757-e798da2e0c0e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::rend (STL-CLR)
Designates the end of the reversed controlled sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reverse iterator that points just beyond the beginning of the controlled sequence. Hence, it designates the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of the reverse sequence. You use it to obtain an iterator that designates the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> end of the controlled sequence seen in reverse order, but its status can change if the length of the controlled sequence changes.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**\*-- --rend() = b**  
**\*--rend() = a**   
## Requirements  
 **Header:** \<cliext/set>  
  
 **Namespace:** cliext  
  
## See Also  
 [set](../vs140/set--stl-clr-.md)   
 [begin](../vs140/set--begin--stl-clr-.md)   
 [end](../vs140/set--end--stl-clr-.md)   
 [rbegin](../vs140/set--rbegin--stl-clr-.md)