---
title: "add_pointer Class"
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
  - "std::tr1::add_pointer"
  - "std.tr1.add_pointer"
  - "add_pointer"
  - "std.add_pointer"
  - "std::add_pointer"
  - "type_traits/std::add_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add_pointer class [TR1]"
  - "add_pointer"
ms.assetid: d8095cb0-6578-4143-b78f-87f82485298c
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# add_pointer Class
Makes a pointer-to-type from a specified type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 The member typedef type names the same type as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 Because it is invalid to make a pointer from a reference, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> removes the reference, if any, from the specified type before it makes a pointer-to-type. Consequently, you can use a type with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> without being concerned about whether the type is a reference.  
  
## Example  
 The following example demonstrates that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of a type is the same as a pointer to that type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **add_pointer_t\<int> == int \***    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_pointer](../vs140/remove_pointer-class.md)