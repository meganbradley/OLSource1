---
title: "logical_not (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "logical_not (STL/CLR)"
f1_keywords: 
  - "cliext::logical_not"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "logical_not function [STL/CLR]"
ms.assetid: 32a2c6e2-1c58-41ac-8827-f3ee5adfe81d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# logical_not (STL-CLR)
The template class describes a functor that, when called, returns true only if either its argument tests as false. You use it specify a function object in terms of its argument type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 Arg  
 The type of the arguments.  
  
## Member Functions  
  
|Type Definition|Description|  
|---------------------|-----------------|  
|argument_type|The type of the functor argument.|  
|delegate_type|The type of the generic delegate.|  
|result_type|The type of the functor result.|  
  
|Member|Description|  
|------------|-----------------|  
|logical_not|Constructs the functor.|  
  
|Operator|Description|  
|--------------|-----------------|  
|operator()|Computes the desired function.|  
|operator delegate_type^|Casts the functor to a delegate.|  
  
## Remarks  
 The template class describes a one-argument functor. It defines the member operator <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> so that, when the object is called as a function, it returns true only if its argument tests as false.  
  
 You can also pass the object as a function argument whose type is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and it will be converted appropriately.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **4 0**  
 **0 1**   
## Requirements  
 **Header:** \<cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [negate](../vs140/negate--stl-clr-.md)