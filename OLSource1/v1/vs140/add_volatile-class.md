---
title: "add_volatile Class"
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
  - "std::tr1::add_volatile"
  - "add_volatile"
  - "std.tr1.add_volatile"
  - "std.add_volatile"
  - "std::add_volatile"
  - "type_traits/std::add_volatile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add_volatile class [TR1]"
  - "add_volatile"
ms.assetid: cde57277-d764-402d-841e-97611ebaab14
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# add_volatile Class
Makes volatile type from the specified type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of the type modifier holds a modified-type that is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a reference, a function, or a volatile-qualified type, otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **add_volatile\<int> == int**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_volatile](../vs140/remove_volatile-class.md)