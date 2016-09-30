---
title: "is_object Class"
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
  - "is_object"
  - "std.tr1.is_object"
  - "std::tr1::is_object"
  - "std.is_object"
  - "std::is_object"
  - "type_traits/std::is_object"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_object class [TR1]"
  - "is_object"
ms.assetid: b452ceea-5676-488f-925b-ab881126c387
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_object Class
Tests if type is an object type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds false if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a reference type, a function type, or void, or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of one of them, otherwise holds true.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_object\<trivial> == true**  
**is_object\<functional> == true**  
**is_object\<trivial&> == false**  
**is_object\<float()> == false**  
**is_object\<void> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_function](../vs140/is_function-class.md)