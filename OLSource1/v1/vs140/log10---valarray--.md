---
title: "log10 (&lt;valarray&gt;)"
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
  - "std::log10"
  - "valarray/std::log10"
  - "std.log10"
  - "log10"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "log10 function"
ms.assetid: e7802375-4f8f-4c93-b371-4a129dc5e350
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# log10 (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the base 10 or common logarithm of the elements of the input valarray.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the common logarithm of the elements of the input valarray.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Initial valarray: 0 10 20 30 40 50 60 70 80 90 100**  
**The common logarithm of the initial valarray is:**  
**-1.#INF**  
**1**  
**1.30103**  
**1.47712**  
**1.60206**  
**1.69897**  
**1.77815**  
**1.8451**  
**1.90309**  
**1.95424**  
**2**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [exp, log, and log10](../vs140/exp--log--and-log10.md)