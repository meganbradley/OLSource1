---
title: "exchange Function"
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
ms.assetid: 631caa8b-5401-441b-8ebd-244e675834c6
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exchange Function
**(C++14)** Assigns a new value to an object and returns its old value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object that will receive the value of new_val.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The object whose value is copied or moved into val.  
  
## Return Value  
 Returns the original value of the left hand argument before the function was called.  
  
## Remarks  
 For complex types, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> avoids copying the old value when a move constructor is available, avoids copying the new value if it’s a temporary object or is moved, and accepts any type as the new value, using any available converting assignment operator. The exchange function is different from [std::swap](../vs140/swap.md) in that the left argument is not moved or copied to the right argument.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. In the real world, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is most useful with large objects that are expensive to copy:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: \<utility>  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)