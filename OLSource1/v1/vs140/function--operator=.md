---
title: "function::operator="
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
  - "function::operator="
  - "functional/std::tr1::function::operator="
  - "std.tr1.function.operator="
  - "function.operator="
  - "std::tr1::function::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
ms.assetid: 992901b5-7366-4056-9312-350f6a096255
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::operator=
Replaces the stored callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A null pointer constant.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The function object to copy.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The callable object to wrap.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The callable object reference to wrap.  
  
## Remarks  
 The operators each replace the callable object held by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the callable object passed as the operand.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **empty == false**  
**val == -3**  
**empty == true**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**  
**empty == false**  
**val == -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::function](../vs140/function--function.md)   
 [function::swap](../vs140/function--swap.md)