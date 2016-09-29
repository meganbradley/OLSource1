---
title: "&lt;iomanip&gt; get_money"
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
  - "std.get_money"
  - "get_money"
  - "std::get_money"
  - "iomanip/std::get_money"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_money function"
ms.assetid: ee47e488-689e-4c74-9167-957e600cc810
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; get_money
Extracts a monetary value from a stream using the desired format, and returns the value in a parameter.  
  
## Syntax  
  
```  
template<class Money>  
    T7 get_money(  
        Money& _Amount,   
        bool _Intl  
);  
```  
  
#### Parameters  
 _Amount  
 The extracted monetary value.  
  
 _Intl  
 If `true`, use international format. The default value is `false`.  
  
## Property Value/Return Value  
 Returns the stream `str`.  
  
## Exceptions  
  
## Remarks  
 The manipulator returns an object that, when extracted from the stream `str`, behaves as a `formatted input function` that calls the member function `get` for the locale facet `money_get` associated with `str`, using `_Intl` to indicate international format. If successful, the call stores in `_Amount` the extracted monetary value. The manipulator then returns `str`.  
  
 `Money` must be of type `long double` or an instantiation of `basic_string` with the same element and traits parameters as `str`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [<iomanip\>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)