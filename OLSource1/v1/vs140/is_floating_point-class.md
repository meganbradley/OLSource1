---
title: "is_floating_point Class"
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
  - "is_floating_point"
  - "std.tr1.is_floating_point"
  - "std::tr1::is_floating_point"
  - "std.is_floating_point"
  - "std::is_floating_point"
  - "type_traits/std::is_floating_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_floating_point class [TR1]"
  - "is_floating_point"
ms.assetid: 070679c1-115b-4ee4-8ab7-f52e5d9e157f
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_floating_point Class
Tests if type is floating point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a floating point type or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of a floating point type, otherwise it holds false.  
  
 A floating point type is one of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_floating_point\<trivial> == false**  
**is_floating_point\<int> == false**  
**is_floating_point\<float> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_integral](../vs140/is_integral-class.md)