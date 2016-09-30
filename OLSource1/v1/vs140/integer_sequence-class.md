---
title: "integer_sequence Class"
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
  - "type_traits/std::index_sequence"
  - "type_traits/std::make_index_sequence"
  - "type_traits/std::integer_sequence"
  - "type_traits/std::make_integer_sequence"
  - "type_traits/std::index_sequence_for"
  - "integer_sequence"
  - "std.integer_sequence"
  - "std::integer_sequence"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "integer_sequence"
ms.assetid: 2cfdddee-819d-478e-bb78-c8a9c2696803
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# integer_sequence Class
Represents an integer sequence. Can be used to deduce and expand parameter packs in variadic types such as std::tuple\<T...> that are passed as arguments to a function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 T  
 The type of the values; must be an integral type: bool, char, char16_t, char32_t, wchar_t, or signed or unsigned integer types.  
  
 Vals  
 A non-type parameter pack that represents a sequence of values of integral type T.  
  
## Members  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of elements in the sequence.|  
|typedef T value_type|The type of each element in the sequence. Must be an integral type.|  
  
## Remarks  
 A parameter pack that is passed directly to a function can be unpacked without any special library helpers. When a parameter pack is part of a type that is passed to a function, and you need indices to access the elements, then the easiest way to unpack it is to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and its related type aliases <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
 The following example is based on the original proposal                     [N3658](http://open-std.org/jtc1/sc22/wg21/docs/papers/2013/n3658.html). It shows how to use an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> from a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and how to use an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to get at the tuple members.  
  
 In the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function, an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is an alias of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> based on the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> integral type. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is an alias that at compile time creates a zero-based  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> with the same number of elements as the array that is passed in by the caller. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> passes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by value to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> , where the expression <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> unpacks <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and then the elements are being fed to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> which consumes them as individual arguments. For example, if the sequence contains three elements, then <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is called as make_tuple(a[0], a[1], a[2]). The array elements themselves can of course be any type.  
  
 The apply function accepts a [std::tuple](../vs140/tuple-class.md), and produces an integer_sequence by using the  <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> helper class. Note that [std::decay_t](../vs140/decay-class.md)_is necessary because [tuple_size](../vs140/tuple_size-class--tuple-.md) does not work with reference types. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function unpacks the tuple members and forwards them as separate arguments to a function call. In this example the function is a simple lambda expression that prints out the values.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  To make an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> for a parameter pack, use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<T...> which is an alias for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>\<sizeof...(T)>  
  
## Requirements  
 Header: \<type_traits>  
  
 Namepace: std  
  
## See Also  
 [Ellipses and Variadic Templates](../vs140/ellipses-and-variadic-templates.md)