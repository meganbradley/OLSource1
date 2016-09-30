---
title: "make_unsigned Class"
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
  - "std.tr1.make_unsigned"
  - "make_unsigned"
  - "std::tr1::make_unsigned"
  - "std.make_unsigned"
  - "std::make_unsigned"
  - "type_traits/std::make_unsigned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "make_unsigned class[TR1]"
  - "make_unsigned"
ms.assetid: 7a6a3c4f-1a4c-47e8-9ee2-ac1f7b669353
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# make_unsigned Class
Makes type or the smallest unsigned type greater than or equal in size to type.  
  
## Syntax  
  
```  
template<class T>  
    struct make_unsigned;  
  
template<class T>  
    using make_unsigned_t = typename make_unsigned<T>::type;  
  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`T`|The type to modify.|  
  
## Remarks  
 An instance of the type modifier holds a modified-type that is `T` if `is_unsigned<T>` holds true. Otherwise it is the smallest signed type `ST` for which `sizeof (T) <= sizeof (ST)`.  
  
## Requirements  
 **Header:** <type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [<type_traits>](../vs140/-type_traits-.md)