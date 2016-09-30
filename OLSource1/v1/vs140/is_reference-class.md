---
title: "is_reference Class"
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
  - "std.tr1.is_reference"
  - "std::tr1::is_reference"
  - "is_reference"
  - "std.is_reference"
  - "std::is_reference"
  - "type_traits/std::is_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_reference class [TR1]"
  - "is_reference"
ms.assetid: 3d9e631f-3092-430c-843e-e914ab58c257
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_reference Class
Tests if type is a reference.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a reference to an object or to a function, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_reference\<trivial> == false**  
**is_reference\<trivial&> == true**  
**is_reference\<int()> == false**  
**is_reference\<int(&)()> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_pointer](../vs140/is_pointer-class.md)