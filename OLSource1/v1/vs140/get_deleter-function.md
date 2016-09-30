---
title: "get_deleter Function"
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
  - "std::tr1::get_deleter"
  - "get_deleter"
  - "std.tr1.get_deleter"
  - "memory/std::tr1::get_deleter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_deleter function [TR1]"
ms.assetid: 98adaa00-79a0-477a-801e-acef04a96c3e
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# get_deleter Function
Get deleter from shared_ptr.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the deleter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type controlled by the shared pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The shared pointer.  
  
## Remarks  
 The template function returns a pointer to the deleter of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that belongs to the [shared_ptr](../vs140/shared_ptr-class.md) object <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> has no deleter or if its deleter is not of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> the function returns 0.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **get_deleter(sp0) != 0 == false**  
**get_deleter(sp1) != 0 == true**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr](../vs140/shared_ptr-class.md)