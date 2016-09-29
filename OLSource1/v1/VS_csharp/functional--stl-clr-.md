---
title: "functional (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "functional (STL/CLR)"
f1_keywords: 
  - "<cliext/functional>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<functional> header [STL/CLR]"
  - "<cliext/functional> header [STL/CLR]"
  - "functional functions [STL/CLR]"
ms.assetid: 88738b8c-5d37-4375-970e-a4442bf5efde
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# functional (STL-CLR)
Include the STL/CLR header `<cliext/functional>` to define the a number of template classes and related template delegates and functions.  
  
## Syntax  
  
```  
#include <functional>  
```  
  
## Declarations  
  
|Delegate|Description|  
|--------------|-----------------|  
|[binary_delegate](../VS_csharp/binary_delegate--stl-clr-.md)|Two-argument delegate.|  
|[binary_delegate_noreturn](../VS_csharp/binary_delegate_noreturn--stl-clr-.md)|Two-argument delegate returning `void`.|  
|[unary_delegate](../VS_csharp/unary_delegate--stl-clr-.md)|One-argument delegate.|  
|[unary_delegate_noreturn](../VS_csharp/unary_delegate_noreturn--stl-clr-.md)|One-argument delegate returning `void`.|  
  
|Class|Description|  
|-----------|-----------------|  
|[binary_negate](../VS_csharp/binary_negate--stl-clr-.md)|Functor to negate a two-argument functor.|  
|[binder1st](../VS_csharp/binder1st--stl-clr-.md)|Functor to bind first argument to a two-argument functor.|  
|[binder2nd](../VS_csharp/binder2nd--stl-clr-.md)|Functor to bind second argument to a two-argument functor.|  
|[divides](../VS_csharp/divides--stl-clr-.md)|Divide functor.|  
|[equal_to](../VS_csharp/equal_to--stl-clr-.md)|Equal comparison functor.|  
|[greater](../VS_csharp/greater--stl-clr-.md)|Greater comparison functor.|  
|[greater_equal](../VS_csharp/greater_equal--stl-clr-.md)|Greater or equal comparison functor.|  
|[less](../VS_csharp/less--stl-clr-.md)|Less comparison functor.|  
|[less_equal](../VS_csharp/less_equal--stl-clr-.md)|Less or equal comparison functor.|  
|[logical_and](../VS_csharp/logical_and--stl-clr-.md)|Logical AND functor.|  
|[logical_not (STL/CLR)](../VS_csharp/logical_not--stl-clr-.md)|Logical NOT functor.|  
|[logical_or](../VS_csharp/logical_or--stl-clr-.md)|Logical OR functor.|  
|[minus](../VS_csharp/minus--stl-clr-.md)|Subtract functor.|  
|[modulus](../VS_csharp/modulus--stl-clr-.md)|Modulus functor.|  
|[multiplies](../VS_csharp/multiplies--stl-clr-.md)|Multiply functor.|  
|[negate (STL/CLR)](../VS_csharp/negate--stl-clr-.md)|Functor to return its argument negated.|  
|[not_equal_to](../VS_csharp/not_equal_to--stl-clr-.md)|Not equal comparison functor.|  
|[plus](../VS_csharp/plus--stl-clr-.md)|Add functor.|  
|[unary_negate](../VS_csharp/unary_negate--stl-clr-.md)|Functor to negate a one-argument functor.|  
  
|Function|Description|  
|--------------|-----------------|  
|[bind1st](../VS_csharp/bind1st--stl-clr-.md)|Generates a binder1st for an argument and functor.|  
|[bind2nd](../VS_csharp/bind2nd--stl-clr-.md)|Generates a binder2nd for an argument and functor.|  
|[not1](../VS_csharp/not1--stl-clr-.md)|Generates a unary_negate for a functor.|  
|[not2](../VS_csharp/not1--stl-clr-.md)|Generates a binary_negate for a functor.|  
  
## Requirements  
 **Header:** <cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [STL/CLR Library Reference](../VS_csharp/stl-clr-library-reference.md)