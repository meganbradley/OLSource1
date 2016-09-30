---
title: "modulus (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "modulus (STL/CLR)"
f1_keywords: 
  - "cliext::modulus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "modulus function [STL/CLR]"
ms.assetid: 49907edd-6e32-4c81-8ef2-e9c6f512437f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# modulus (STL-CLR)
The template class describes a functor that, when called, returns the first argument modulo the second. You use it specify a function object in terms of its argument type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Arg  
 The type of the arguments and return value.  
  
## Member Functions  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|delegate_type|The type of the generic delegate.|  
|first_argument_type|The type of the functor first argument.|  
|result_type|The type of the functor result.|  
|second_argument_type|The type of the functor second argument.|  
  
|Member|Description|  
|------------|-----------------|  
|modulus|Constructs the functor.|  
  
|Operator|Description|  
|--------------|-----------------|  
|operator()|Computes the desired function.|  
|operator delegate_type^|Casts the functor to a delegate.|  
  
## Remarks  
 The template class describes a two-argument functor. It defines the member operator <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> so that, when the object is called as a function, it returns the first argument modulo the second.  
  
 You can also pass the object as a function argument whose type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and it will be converted appropriately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 2**  
 **3 1**  
 **1 0**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [divides](../vs140/divides--stl-clr-.md)   
 [multiplies](../vs140/multiplies--stl-clr-.md)