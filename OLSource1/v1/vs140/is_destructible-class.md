---
title: "is_destructible Class"
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
  - "is_destructible"
  - "std.is_destructible"
  - "std::is_destructible"
  - "type_traits/std::is_destructible"
dev_langs: 
  - "C++"
  - "c++"
helpviewer_keywords: 
  - "is_destructible"
ms.assetid: 3bb9b718-1ad5-49ae-93cc-92b93b546b4d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_destructible Class
Tests whether the type is destructible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a destructible type, otherwise it holds false. Destructible types are reference types, object types, and types where for some type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> equal to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> the unevaluated operand <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is well-formed. Other types, including incomplete types, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and function types, are not destructible types.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)