---
title: "is_trivial Class"
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
  - "is_trivial"
  - "std.is_trivial"
  - "std::is_trivial"
  - "type_traits/std::is_trivial"
dev_langs: 
  - "C++"
  - "c++"
helpviewer_keywords: 
  - "is_trivial"
ms.assetid: 6beb11d4-2f38-4c7e-9959-ca5d26250df7
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_trivial Class
Tests whether the type is a trivial type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a trivial type, otherwise it holds false. Trivial types are scalar types, trivially copyable class types, arrays of these types and cv-qualified versions of these types.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)