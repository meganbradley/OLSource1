---
title: "log (&lt;valarray&gt;)"
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
  - "valarray/std::log"
  - "log"
  - "std::log"
  - "std.log"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "log function"
ms.assetid: f9c478b6-42d6-4329-b91d-9dee74025528
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# log (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the natural logarithm of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Initial valarray: 0 10 20 30 40 50 60 70 80**  
**The natural logarithm of the initial valarray is:**  
**-1.#INF**  
**2.30259**  
**2.99573**  
**3.4012**  
**3.68888**  
**3.91202**  
**4.09434**  
**4.2485**  
**4.38203**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [exp, log, and log10](../vs140/exp--log--and-log10.md)