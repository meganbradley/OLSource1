---
title: "unary_negate (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "unary_negate (STL/CLR)"
f1_keywords: 
  - "cliext::unary_negate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unary_negate function [STL/CLR]"
ms.assetid: 83bbdd86-199c-4451-9f70-72f9ade2264a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unary_negate (STL-CLR)
The template class describes a functor that, when called, returns the logical NOT of its stored one-argument functor. You use it specify a function object in terms of its stored functor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Fun  
 The type of the stored functor.  
  
## Member Functions  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|argument_type|The type of the functor argument.|  
|delegate_type|The type of the generic delegate.|  
|result_type|The type of the functor result.|  
  
|Member|Description|  
|------------|-----------------|  
|unary_negate|Constructs the functor.|  
  
|Operator|Description|  
|--------------|-----------------|  
|operator()|Computes the desired function.|  
|delegate_type^|Casts the functor to a delegate.|  
  
## Remarks  
 The template class describes a one-argument functor that stores another one-argument functor. It defines the member operator <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> so that, when the object is called as a function, it returns the logical NOT of the stored functor called with the argument.  
  
 You can also pass the object as a function argument whose type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and it will be converted appropriately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 0**  
 **1 0**  
 **1 0**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [not1](../vs140/not1--stl-clr-.md)