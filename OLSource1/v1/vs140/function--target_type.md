---
title: "function::target_type"
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
  - "std::tr1::function::target_type"
  - "function::target_type"
  - "target_type"
  - "function.target_type"
  - "std.tr1.function.target_type"
  - "functional/std::tr1::function::target_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "target_type method [TR1]"
ms.assetid: d92f8afa-bcbf-49aa-8225-517b8f9b883b
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::target_type
Gets type information on the callable object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is empty, otherwise it returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the type of the target object.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **empty == false**  
**type == int (__cdecl\*)(int)**  
**empty == true**  
**type == void**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::target](../vs140/function--target.md)