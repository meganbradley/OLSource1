---
title: "is_trivially_assignable Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "is_trivially_assignable"
  - "std.is_trivially_assignable"
  - "std::is_trivially_assignable"
  - "type_traits/std::is_trivially_assignable"
dev_langs: 
  - "C++"
  - "c++"
helpviewer_keywords: 
  - "is_trivially_assignable"
ms.assetid: 1284a8f7-4093-426d-9c9a-dabb46f90d6d
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_trivially_assignable Class
Tests whether a value of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type can be trivially assigned to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 To  
 The type of the object that receives the assignment.  
  
 From  
 The type of the object that provides the value.  
  
## Remarks  
 The expression <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> must be well-formed, and must be known to the compiler to require no non-trivial operations. Both <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be complete types, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or arrays of unknown bound.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)