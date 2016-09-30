---
title: "binary_delegate_noreturn (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "binary_delegate_noreturn (STL/CLR)"
f1_keywords: 
  - "cliext::binary_delegate_noreturn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_delegate_noreturn function [STL/CLR]"
ms.assetid: 055c7e9d-e5c3-48fe-9327-3f6316e8a51e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_delegate_noreturn (STL-CLR)
The genereic class describes a two-argument delegate that returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it specify a delegate in terms of its argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Arg1  
 The type of the first argument.  
  
 Arg2  
 The type of the second argument.  
  
## Remarks  
 The genereic delegate describes a two-argument function that returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Note that for:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 the types <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are synonyms, while for:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 they are not the same type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **compare(a, a) = False**  
**compare(a, b) = True**  
**compare(b, a) = False**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [binary_delegate](../vs140/binary_delegate--stl-clr-.md)   
 [unary_delegate](../vs140/unary_delegate--stl-clr-.md)   
 [unary_delegate_noreturn](../vs140/unary_delegate_noreturn--stl-clr-.md)