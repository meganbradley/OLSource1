---
title: "list::remove_if (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "list::remove_if (STL/CLR)"
f1_keywords: 
  - "cliext::list::remove_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_if member [STL/CLR]"
ms.assetid: cbc66192-751b-41c5-b557-d5d7bbc2a840
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::remove_if (STL-CLR)
Removes elements that pass a specified test.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pred  
 Test for elements to remove.  
  
## Remarks  
 The member function removes from the controlled sequence (erases) every element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for which <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is true. You use it to remove all elements that satisfy a condition you specify as a function or delegate.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b b b c**  
 **a b b b c**  
 **b b b**   
## Requirements  
 **Header:** \<cliext/list>  
  
 **Namespace:** cliext  
  
## See Also  
 [list](../vs140/list--stl-clr-.md)   
 [clear](../vs140/list--clear--stl-clr-.md)   
 [erase](../vs140/list--erase--stl-clr-.md)   
 [remove](../vs140/list--remove--stl-clr-.md)   
 [unique](../vs140/list--unique--stl-clr-.md)