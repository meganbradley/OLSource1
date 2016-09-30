---
title: "Template Specialization (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partial specialization of class templates"
ms.assetid: f3c67c0b-3875-434a-b8d8-bb47e99cf4f0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template Specialization (C++)
Class templates can be partially specialized, and the resulting class is still a template. Partial specialization allows template code to be partially customized for specific types in situations, such as:  
  
-   A template has multiple types and only some of them need to be specialized. The result is a template parameterized on the remaining types.  
  
-   A template has only one type, but a specialization is needed for pointer, reference, pointer to member, or function pointer types. The specialization itself is still a template on the type pointed to or referenced.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **PTS\<S>::IsPointer == 0 PTS\<S>::IsPointerToDataMember == 0**  
**PTS\<S\*>::IsPointer == 1 PTS\<S\*>::IsPointerToDataMember ==0**  
**PTS\<int S::\*>::IsPointer == 0 PTS\<int S::\*>::IsPointerToDataMember == 1**   
## Example  
 If you have a template collection class that takes any type **T**, you can create a partial specialization that takes any pointer type **T\***. The following code demonstrates a collection class template <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and a partial specialization for pointer types in which the collection dereferences the pointer types before copying them to the array. The collection then stores the values that are pointed to. With the original template, only the pointers themselves would have been stored in the collection, leaving the data vulnerable to deletion or modification. In this special pointer version of the collection, code to check for a null pointer in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method is added.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **10 9 8**   
**a b c**   
**Null pointer!**  
**3 87 8 100**    
## Example  
 The following example defines a template class that takes pairs of any two types and then defines a partial specialization of that template class specialized so that one of the types is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The specialization defines an additional sort method that implements a simple bubble sort based on the integer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **{apple, fruit}**  
**{banana, fruit}**  
**{dog, animal}**  
**{100, apple}**  
**{101, banana}**  
**{103, dog}**  
**{89, cat}**  
**Sorted list:**  
**{89, cat}**  
**{100, apple}**  
**{101, banana}**  
**{103, dog}**   
## See Also  
 [Explicit Specialization of Class Templates](../vs140/explicit-specialization-of-class-templates.md)