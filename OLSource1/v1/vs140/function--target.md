---
title: "function::target"
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
  - "target"
  - "std::tr1::function::target"
  - "std.tr1.function.target"
  - "function::target"
  - "function.target"
  - "functional/std::tr1::function::target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "target method [TR1]"
ms.assetid: 244ed813-3dfa-47bb-b3b5-a42d66b19348
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::target
Tests if stored callable object is callable as specified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The target callable object type to test.  
  
## Remarks  
 The type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be callable for the argument types <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the return type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the member template function returns the address of the target object; otherwise, it returns 0.  
  
 A type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is callable for the argument types <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the return type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if, for lvalues <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> of types <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, respectively, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is well-formed and, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, convertible to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **empty == false**  
**no target == false**  
**val == -3**  
**empty == true**  
**no target == true**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target_type](../vs140/function--target_type.md)