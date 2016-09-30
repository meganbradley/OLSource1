---
title: "ios_base::xalloc"
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
  - "xiosbase/std::ios_base::xalloc"
  - "std::ios_base::xalloc"
  - "xalloc"
  - "ios_base.xalloc"
  - "ios_base::xalloc"
  - "std.ios_base.xalloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "xalloc method"
ms.assetid: 302f8773-f86b-4517-8690-ec6ed1e82c59
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::xalloc
Specifies that a variable is part of the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The static member function returns a stored static value, which it increments on each call.  
  
## Remarks  
 You can use the return value as a unique index argument when calling the member functions [iword](../vs140/ios_base--iword.md) or [pword](../vs140/ios_base--pword.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **11**  
**13**  
**testing**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)