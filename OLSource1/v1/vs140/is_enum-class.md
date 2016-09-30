---
title: "is_enum Class"
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
  - "is_enum"
  - "std.tr1.is_enum"
  - "std::tr1::is_enum"
  - "std.is_enum"
  - "std::is_enum"
  - "type_traits/std::is_enum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_enum class [TR1]"
  - "is_enum"
ms.assetid: df3b00b7-4f98-4b3a-96ce-10ad958ee69c
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_enum Class
Tests if type is an enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an enumeration type or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of an enumeration type, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_enum\<trivial> == false**  
**is_enum\<color> == true**  
**is_enum\<int> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_integral](../vs140/is_integral-class.md)