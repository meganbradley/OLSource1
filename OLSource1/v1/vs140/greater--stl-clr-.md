---
title: "greater (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "greater (STL/CLR)"
f1_keywords: 
  - "cliext::greater"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "greater function [STL/CLR]"
ms.assetid: a6dfe5e3-b5a5-4ec4-8e53-8dd33a37d10d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# greater (STL-CLR)
The template class describes a functor that, when called, returns true only if the first argument is greater than the second. You use it specify a function object in terms of its argument type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Arg  
 The type of the arguments.  
  
## Member Functions  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|delegate_type|The type of the generic delegate.|  
|first_argument_type|The type of the functor first argument.|  
|result_type|The type of the functor result.|  
|second_argument_type|The type of the functor second argument.|  
  
|Member|Description|  
|------------|-----------------|  
|greater|Constructs the functor.|  
  
|Operator|Description|  
|--------------|-----------------|  
|operator()|Computes the desired function.|  
|operator delegate_type^|Casts the functor to a delegate.|  
  
## Remarks  
 The template class describes a two-argument functor. It defines the member operator <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> so that, when the object is called as a function, it returns true only if the first argument is greater than the second.  
  
 You can also pass the object as a function argument whose type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and it will be converted appropriately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 3**  
 **3 3**  
 **1 0**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [less_equal](../vs140/less_equal--stl-clr-.md)