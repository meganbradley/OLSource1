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
|[binary_delegate](../vs140/binary_delegate--stl-clr-.md)|Two-argument delegate.|  
|[binary_delegate_noreturn](../vs140/binary_delegate_noreturn--stl-clr-.md)|Two-argument delegate returning `void`.|  
|[unary_delegate](../vs140/unary_delegate--stl-clr-.md)|One-argument delegate.|  
|[unary_delegate_noreturn](../vs140/unary_delegate_noreturn--stl-clr-.md)|One-argument delegate returning `void`.|  
  
|Class|Description|  
|-----------|-----------------|  
|[binary_negate](../vs140/binary_negate--stl-clr-.md)|Functor to negate a two-argument functor.|  
|[binder1st](../vs140/binder1st--stl-clr-.md)|Functor to bind first argument to a two-argument functor.|  
|[binder2nd](../vs140/binder2nd--stl-clr-.md)|Functor to bind second argument to a two-argument functor.|  
|[divides](../vs140/divides--stl-clr-.md)|Divide functor.|  
|[equal_to](../vs140/equal_to--stl-clr-.md)|Equal comparison functor.|  
|[greater](../vs140/greater--stl-clr-.md)|Greater comparison functor.|  
|[greater_equal](../vs140/greater_equal--stl-clr-.md)|Greater or equal comparison functor.|  
|[less](../vs140/less--stl-clr-.md)|Less comparison functor.|  
|[less_equal](../vs140/less_equal--stl-clr-.md)|Less or equal comparison functor.|  
|[logical_and](../vs140/logical_and--stl-clr-.md)|Logical AND functor.|  
|[logical_not (STL/CLR)](../vs140/logical_not--stl-clr-.md)|Logical NOT functor.|  
|[logical_or](../vs140/logical_or--stl-clr-.md)|Logical OR functor.|  
|[minus](../vs140/minus--stl-clr-.md)|Subtract functor.|  
|[modulus](../vs140/modulus--stl-clr-.md)|Modulus functor.|  
|[multiplies](../vs140/multiplies--stl-clr-.md)|Multiply functor.|  
|[negate (STL/CLR)](../vs140/negate--stl-clr-.md)|Functor to return its argument negated.|  
|[not_equal_to](../vs140/not_equal_to--stl-clr-.md)|Not equal comparison functor.|  
|[plus](../vs140/plus--stl-clr-.md)|Add functor.|  
|[unary_negate](../vs140/unary_negate--stl-clr-.md)|Functor to negate a one-argument functor.|  
  
|Function|Description|  
|--------------|-----------------|  
|[bind1st](../vs140/bind1st--stl-clr-.md)|Generates a binder1st for an argument and functor.|  
|[bind2nd](../vs140/bind2nd--stl-clr-.md)|Generates a binder2nd for an argument and functor.|  
|[not1](../vs140/not1--stl-clr-.md)|Generates a unary_negate for a functor.|  
|[not2](../vs140/not1--stl-clr-.md)|Generates a binary_negate for a functor.|  
  
## Requirements  
 **Header:** <cliext/functional>  
  
 **Namespace:** cliext  
  
## See Also  
 [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md)