---
title: "function::operator()"
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
  - "function::operator()"
  - "std::tr1::function::operator()"
  - "std.tr1.function.operator()"
  - "function.operator()"
  - "functional/std::tr1::function::operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator() operator [TR1]"
ms.assetid: 0ba41345-237b-4d25-99e3-a65bdeac6ccc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::operator()
Calls a callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the Nth call argument.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The Nth call argument.  
  
## Remarks  
 The member function returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the target object stored in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to call the wrapped callable object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **empty == false**  
**val == -3**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target](../vs140/function--target.md)