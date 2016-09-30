---
title: "get Function &lt;tuple&gt;"
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
  - "get"
  - "std::tr1::get"
  - "std.tr1.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get function [TR1]"
ms.assetid: 9d6c9820-3f79-4649-8cd8-1f9f78a0839e
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# get Function &lt;tuple&gt;
Gets an element from a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, by index or (in C++14) by type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the element to get.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The sequence of types declared in the tuple, in declaration order.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the element to get.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A std::tuple that contains any number of elements.  
  
## Remarks  
 The template functions return a reference to the value at index <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 Calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> will produce a compiler error if Tuple contains more or less than one element of type T.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<tuple>  
  
 **Namespace:** std  
  
## See Also  
 [\<tuple>](../vs140/-tuple-.md)   
 [tuple_element](../vs140/tuple_element-class--tuple-.md)