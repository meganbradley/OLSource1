---
title: "is_nothrow_constructible Class"
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
  - "is_nothrow_constructible"
  - "std.is_nothrow_constructible"
  - "std::is_nothrow_constructible"
  - "type_traits/std::is_nothrow_constructible"
dev_langs: 
  - "C++"
  - "c++"
helpviewer_keywords: 
  - "is_nothrow_constructible"
ms.assetid: 8be3f927-283e-4d67-95a5-8bf5dc4e7a3d
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_nothrow_constructible Class
Tests whether a type is constructible and is known not to throw when the specified argument types are used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type to query.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument types to match in a constructor of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is constructible by using the argument types in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and the constructor is known by the compiler not to throw; otherwise it holds false. Type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is constructible if the variable definition <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is well-formed. Both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and all the types in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be complete types, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, or arrays of unknown bound.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)