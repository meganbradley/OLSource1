---
title: "Values"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
ms.assetid: 24003f89-220f-4f93-be7a-b650c26157d7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Values
**ANSI 3.1.2.5** The representations and sets of values of the various types of floating-point numbers  
  
 The **float** type contains 32 bits: 1 for the sign, 8 for the exponent, and 23 for the mantissa. Its range is +/– 3.4E38 with at least 7 digits of precision.  
  
 The **double** type contains 64 bits: 1 for the sign, 11 for the exponent, and 52 for the mantissa. Its range is +/– 1.7E308 with at least 15 digits of precision.  
  
 The **long double** type contains 80 bits: 1 for the sign, 15 for the exponent, and 64 for the mantissa. Its range is +/– 1.2E4932 with at least 19 digits of precision. Note that with the Microsoft C compiler, the representation of type **long double** is identical to type **double**.  
  
## See Also  
 [Floating-Point Math](../vs140/floating-point-math.md)