---
title: "const_pointer_cast"
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
  - "const_pointer_cast"
  - "std::tr1::const_pointer_cast"
  - "std.tr1.const_pointer_cast"
  - "memory/std::tr1::const_pointer_cast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer_cast function [TR1]"
ms.assetid: 53d61b0a-d7eb-4f6e-bf32-7749da6b88cf
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# const_pointer_cast
Const cast to shared_ptr.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type controlled by the returned shared pointer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type controlled by the argument shared pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The argument shared pointer.  
  
## Remarks  
 The template function returns an empty shared_ptr object if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns a null pointer; otherwise it returns a [shared_ptr](../vs140/shared_ptr-class.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that owns the resource that is owned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The expression <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be valid.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **sp1 == 3**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)   
 [dynamic_pointer_cast](../vs140/dynamic_pointer_cast.md)   
 [static_pointer_cast](../vs140/static_pointer_cast.md)