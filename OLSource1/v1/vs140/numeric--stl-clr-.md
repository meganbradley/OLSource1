---
title: "numeric (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "numeric (STL/CLR)"
f1_keywords: 
  - "<cliext/numeric>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "numeric functions [STL/CLR]"
  - "<cliext/numeric> header [STL/CLR]"
  - "<numeric> header [STL/CLR]"
ms.assetid: 1dc4d9a3-e734-459c-9678-5d9be0ef4c79
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numeric (STL-CLR)
Defines container template functions that perform algorithms provided for numerical processing.  
  
## Syntax  
  
```  
#include <cliext/numeric>  
```  
  
## Functions  
  
|Function|Description|  
|--------------|-----------------|  
|[accumulate (STL/CLR)](../vs140/accumulate--stl-clr-.md)|Computes the sum of all the elements in a specified range including some initial value by computing successive partial sums or computes the result of successive partial results similarly obtained from using a specified binary operation other than the sum.|  
|[adjacent_difference (STL/CLR)](../vs140/adjacent_difference--stl-clr-.md)|Computes the successive differences between each element and its predecessor in an input range and outputs the results to a destination range or computes the result of a generalized procedure where the difference operation is replaced by another, specified binary operation.|  
|[inner_product (STL/CLR)](../vs140/inner_product--stl-clr-.md)|Computes the sum of the element-wise product of two ranges and adds it to a specified initial value or computes the result of a generalized procedure where the sum and product binary operations are replaced by other specified binary operations.|  
|[partial_sum (STL/CLR)](../vs140/partial_sum--stl-clr-.md)|Computes a series of sums in an input range from the first element through the `i`th element and stores the result of each such sum in `i`th element of a destination range or computes the result of a generalized procedure where the sum operation is replaced by another specified binary operation.|  
  
## Requirements  
 **Header:** <cliext/numeric>  
  
 **Namespace:** cliext  
  
## See Also  
 [STL/CLR Library](../vs140/stl-clr-library-reference.md)