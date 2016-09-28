---
title: "messages_base Class"
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
  - "std.messages_base"
  - "messages_base"
  - "std::messages_base"
  - "locale/std::messages_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages_base class"
ms.assetid: 9aad38c6-4c13-445d-b096-364bd0836efb
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages_base Class
The base class describes an `int` type for the catalog of messages.  
  
## Syntax  
  
```  
struct messages_base : locale::facet {  
    typedef int catalog;  
    explicit messages_base(size_t _Refs = 0)  
};  
```  
  
## Remarks  
 The type catalog is a synonym for type `int` that describes the possible return values from messages:: [do_open](../vs140/messages-class.md#messages__do_open).  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)