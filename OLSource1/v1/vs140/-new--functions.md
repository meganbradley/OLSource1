---
title: "&lt;new&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: e250f06a-b025-4509-ae7a-5356d56aad7d
caps.latest.revision: 10
---
# &lt;new&gt; functions
|||  
|-|-|  
|[nothrow](#nothrow)|[set_new_handler](#set_new_handler)|  
  
##  \<a name="nothrow">\</a>  nothrow  
 Provides an object to be used as an argument for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> versions of **new** and **delete**.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The object is used as a function argument to match the parameter type [std::nothrow_t](../vs140/nothrow_t-structure.md).  
  
### Example  
  See [operator new](../vs140/-new--operators.md#operator_new) and [operator new&#91;&#93;](../vs140/-new--operators.md#operator_new_at) for examples of how <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used as a function parameter.  
  
##  \<a name="set_new_handler">\</a>  set_new_handler  
 Installs a user function that is to be called when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> fails in its attempt to allocate memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The new_handler to be installed.  
  
### Return Value  
 0 on the first call and the previous <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on subsequent calls.  
  
### Remarks  
 The function stores <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in a static [new handler](../vs140/-new--typedefs.md#new_handler) pointer that it maintains, then returns the value previously stored in the pointer. The new handler is used by [operator new](../vs140/-new--operators.md#operator_new)( **size_t**).  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**The new_handler is called:**  
**bad allocation**    
## See Also  
 [&lt;new&gt;](../vs140/-new-.md)