---
title: "is_compound Class"
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
  - "std::tr1::is_compound"
  - "is_compound"
  - "std.tr1.is_compound"
  - "std.is_compound"
  - "std::is_compound"
  - "type_traits/std::is_compound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_compound class [TR1]"
  - "is_compound"
ms.assetid: bdad1167-cf3f-4f37-8321-62a5df159ead
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_compound Class
Tests if the specified type is not fundamental.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the type of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a fundamental type (that is, if [is_fundamental](../vs140/is_fundamental-class.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> holds <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>); otherwise, it holds <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Thus, the predicate holds <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an array type, a function type, a pointer to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or an object or a function, a reference, a class, a union, an enumeration, or a pointer to non-static class member, or a *cv-qualified* form of one of them.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_compound\<trivial> == true**  
**is_compound\<int[]> == true**  
**is_compound\<int()> == true**  
**is_compound\<int&> == true**  
**is_compound\<void \*> == true**  
**is_compound\<int> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_class](../vs140/is_class-class.md)