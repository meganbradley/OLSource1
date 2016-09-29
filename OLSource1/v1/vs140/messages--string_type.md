---
title: "messages::string_type"
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
  - "xlocmes/std::messages::string_type"
  - "string_type"
  - "messages.string_type"
  - "std::messages::string_type"
  - "std.messages.string_type"
  - "messages::string_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "string_type typedef"
ms.assetid: 0de8b10b-a85c-425e-bdcc-02240d47aa1e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::string_type
A type that describes a string of type `basic_string` containing characters of type **CharType**.  
  
## Syntax  
  
```  
typedef basic_string<CharType, Traits, Allocator> string_type;  
```  
  
## Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the message sequences.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)