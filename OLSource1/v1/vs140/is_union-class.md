---
title: "is_union Class"
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
  - "is_union"
  - "std::tr1::is_union"
  - "std.tr1.is_union"
  - "std.is_union"
  - "std::is_union"
  - "type_traits/std::is_union"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_union class [TR1]"
  - "is_union"
ms.assetid: 80eda256-40b8-4db5-9ac1-d58bb8032a3e
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_union Class
Tests if type is a union.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a union type or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of a union type, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_union\<trivial> == false**  
**is_union\<int> == false**  
**is_union\<ints> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_class](../vs140/is_class-class.md)