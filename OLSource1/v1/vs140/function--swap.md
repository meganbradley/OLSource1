---
title: "function::swap"
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
  - "function::swap"
  - "functional/std::tr1::function::swap"
  - "std.tr1.function.swap"
  - "function.swap"
  - "std::tr1::function::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
ms.assetid: f0e99367-d73a-460c-906d-7ca053920dcf
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::swap
Swap two callable objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function object to swap with.  
  
## Remarks  
 The member function swaps the target objects between <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It does so in constant time and throws no exceptions.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **empty == false**  
**val == -3**  
**empty == true**  
**empty == true**  
**empty == false**  
**val == -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::operator_as](../vs140/function--operator=.md)