---
title: "&lt;iomanip&gt; put_money"
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
  - "iomanip/std::put_money"
  - "std.put_money"
  - "std::put_money"
  - "put_money"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_money function"
ms.assetid: 720238c7-e736-4a28-b73d-41ffb4bdc091
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iomanip&gt; put_money
Inserts a monetary amount using the desired format into a stream.  
  
## Syntax  
  
```  
template<class Money>  
    T8 put_money(  
        const Money& _Amount,   
        bool _Intl  
);  
```  
  
#### Parameters  
 `_Amount`  
 The monetary amount to insert into the stream.  
  
 `_Intl`  
 Set to `true` if manipulator should use international format, `false` if it should not.  
  
## Return Value  
 Returns `str`.  
  
## Remarks  
 The manipulator returns an object that, when inserted into the stream `str`, behaves as a formatted output function that calls the member function `put` for the locale facet `money_put` associated with `str`. If successful, the call inserts `amount` suitably formatted, using `_Intl` to indicate international format and `str.fill()`, as the fill element. The manipulator then returns `str`.  
  
 `Money` must be of type `long double` or an instantiation of `basic_string` with the same element and traits parameters as `str`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [<iomanip\>](../vs140/-iomanip-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)