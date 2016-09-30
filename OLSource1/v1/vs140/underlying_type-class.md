---
title: "underlying_type Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "underlying_type"
  - "std.underlying_type"
  - "std::underlying_type"
  - "type_traits/std::underlying_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "underlying_type"
ms.assetid: 691ddce3-2677-4480-bd35-d933fab85d3e
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# underlying_type Class
Produces the underlying integral type for an enumeration type.  
  
## Syntax  
  
```  
template <class T>  
    struct underlying_type;  
```  
  
#### Parameters  
 `T`  
 The type to modify.  
  
## Remarks  
 The `type` member typedef of the template class names the underlying integral type of `T`, when `T` is an enumeration type, otherwise there is no member typedef `type`.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)