---
title: "char_traits::state_type"
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
  - "char_traits::state_type"
  - "iosfwd/std::char_traits::state_type"
  - "state_type"
  - "std::char_traits::state_type"
  - "char_traits.state_type"
  - "std.char_traits.state_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "state_type typedef"
ms.assetid: f0b83473-5026-40ce-8f6c-5470cdb112de
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::state_type
A type that represents the conversion state for multibyte characters in a stream.  
  
## Syntax  
  
```  
  
typedef implementation-defined state_type;  
```  
  
## Remarks  
 The type describes an object that can represent a conversion state. It is typically a synonym for `mbstate_t`, but in any case it has essentially the same properties as that type.  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)