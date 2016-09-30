---
title: "unary_delegate (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "unary_delegate (STL/CLR)"
f1_keywords: 
  - "cliext::unary_delegate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unary_delegate function [STL/CLR]"
ms.assetid: b3ee253c-98e8-466e-a272-505e47aed061
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unary_delegate (STL-CLR)
The genereic class describes a one-argument delegate. You use it specify a delegate in terms of its argument and return types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Arg  
 The type of the argument.  
  
 Result  
 The return type.  
  
## Remarks  
 The genereic delegate describes a one-argument function.  
  
 Note that for:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 the types <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are synonyms, while for:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 they are not the same type.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **hash(L'a') = 5**  
**hash(L'b') = 22**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [binary_delegate](../vs140/binary_delegate--stl-clr-.md)   
 [binary_delegate_noreturn](../vs140/binary_delegate_noreturn--stl-clr-.md)   
 [unary_delegate_noreturn](../vs140/unary_delegate_noreturn--stl-clr-.md)