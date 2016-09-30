---
title: "is_class Class"
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
  - "is_class"
  - "std::tr1::is_class"
  - "std.tr1.is_class"
  - "std.is_class"
  - "std::is_class"
  - "type_traits/std::is_class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_class class [TR1]"
  - "is_class"
ms.assetid: 96fc34a3-a81b-4ec6-b7fb-baafde1a0f4e
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_class Class
Tests if type is a class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a type defined as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> form of one of them, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_class\<trivial> == true**  
**is_class\<int> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_compound](../vs140/is_compound-class.md)   
 [is_union](../vs140/is_union-class.md)