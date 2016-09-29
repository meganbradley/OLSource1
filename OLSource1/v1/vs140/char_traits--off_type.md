---
title: "char_traits::off_type"
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
  - "std.char_traits.off_type"
  - "iosfwd/std::char_traits::off_type"
  - "std::char_traits::off_type"
  - "char_traits.off_type"
  - "char_traits::off_type"
  - "off_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "off_type typedef"
ms.assetid: 8fe7f98c-c2fa-4e43-8aeb-11c97215c417
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::off_type
An integer type that can represent offsets between positions in a stream.  
  
## Syntax  
  
```  
typedef streamoff off_type;  
```  
  
## Remarks  
 The type is a signed integer that describes an object that can store a byte offset involved in various stream positioning operations. It is typically a synonym for [streamoff](../vs140/streamoff.md), but it has essentially the same properties as that type.  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)