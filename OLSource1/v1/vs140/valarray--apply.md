---
title: "valarray::apply"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::valarray::apply"
  - "valarray.apply"
  - "std.valarray.apply"
  - "valarray::apply"
  - "apply"
  - "valarray/std::valarray::apply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "apply method"
ms.assetid: de0fa123-8cd7-4d7d-be1c-0fda959d25a3
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# valarray::apply
Applies a specified function to each element of a valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *_Func(Type)*  
 The function object to be applied to each element of the operand valarray.  
  
 *_Func(const Type&)*  
 The function object for const to be applied to each element of the operand valarray.  
  
## Return Value  
 A valarray whose elements have had <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> applied element-wise to the elements of the operand valarray.  
  
## Remarks  
 The member function returns an object of class [valarray](../vs140/valarray-class.md)**\<Type>**, of length [size](../vs140/valarray--size.md), each of whose elements <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is **func**((**\*this**)[<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>]).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initial Right valarray is: ( 0 0 -2 3 0 -5 6 0 -8 9 )**  
**The element-by-element result of applying MyApplyFunc to vaR is the**  
**valarray: (  0 0 -4 6 0 -10 12 0 -16 18 )**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)