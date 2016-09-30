---
title: "_1 Object"
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
  - "std.tr1._1"
  - "_1"
  - "std::tr1::_1"
  - "functional/std::tr1::_1"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_1 object [TR1]"
ms.assetid: 30c3c480-ff31-4708-94be-7d0d65f243c9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _1 Object
Placeholders for replaceable arguments.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The objects <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are placeholders designating the first, second, ..., Mth argument, respectively in a function call to an object returned by [bind](../vs140/-functional--functions.md#bind_function). You use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify where the Nth argument should be inserted when the bind expression is evaluated.  
  
 In this implementation the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is 20.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**  
**1\*2 == 2**  
**2\*2 == 4**  
**3\*2 == 6**  
**1^2 == 1**  
**2^2 == 4**  
**3^2 == 9**    
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [bind](../vs140/-functional--functions.md#bind_function)   
 [is_placeholder](../vs140/is_placeholder-class.md)