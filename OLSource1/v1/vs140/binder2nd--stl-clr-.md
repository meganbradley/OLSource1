---
title: "binder2nd (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "binder2nd (STL/CLR)"
f1_keywords: 
  - "cliext::binder2nd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binder2nd function [STL/CLR]"
ms.assetid: f4be8722-1778-4cb9-9ec7-ad1443f6899f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binder2nd (STL-CLR)
The template class describes a one-argument functor that, when called, returns its stored two-argument functor called with the supplied first argument and its stored second argument. You use it specify a function object in terms of its stored functor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Fun  
 The type of the stored functor.  
  
## Member Functions  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|delegate_type|The type of the generic delegate.|  
|first_argument_type|The type of the functor first argument.|  
|result_type|The type of the functor result.|  
|second_argument_type|The type of the functor second argument.|  
|stored_function_type|The type of the functor.|  
  
|Member|Description|  
|------------|-----------------|  
|binder2nd|Constructs the functor.|  
  
|Operator|Description|  
|--------------|-----------------|  
|operator()|Computes the desired function.|  
|operator delegate_type^()|Casts the functor to a delegate.|  
  
## Remarks  
 The template class describes a one-argument functor that stores a two-argument functor and a second argument. It defines the member operator <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> so that, when the object is called as a function, it returns the result of calling the stored functor with the supplied first argument and the stored second argument.  
  
 You can also pass the object as a function argument whose type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and it will be converted appropriately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 3**  
 **0 -1**  
 **0 -1**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [bind2nd](../vs140/bind2nd--stl-clr-.md)