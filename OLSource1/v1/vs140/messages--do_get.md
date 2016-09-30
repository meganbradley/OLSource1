---
title: "messages::do_get"
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
  - "messages.do_get"
  - "messages::do_get"
  - "xlocmes/std::messages::do_get"
  - "std::messages::do_get"
  - "std.messages.do_get"
  - "do_get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_get method"
ms.assetid: 0ae89ea3-f148-4c9a-88ad-45dcbd1638b9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::do_get
A virtual function called to retrieve the message catalog.  
  
## Syntax  
  
```  
virtual string_type do_get(  
    catalog _Catval,   
    int _Set,   
    int _Message,  
    const string_type& _Dfault  
) const;  
```  
  
#### Parameters  
 `_Catval`  
 The identification value specifying the message catalog to be searched.  
  
 `_Set`  
 The first identified used to locate a message in a message catalog.  
  
 `_Message`  
 The second identified used to locate a message in a message catalog.  
  
 `_Dfault`  
 The string to be returned on failure.  
  
## Return Value  
 It returns a copy of `_Dfault` on failure. Otherwise, it returns a copy of the specified message sequence.  
  
## Remarks  
 The protected member function tries to obtain a message sequence from the message catalog `_Catval`. It may make use of `_Set`, `_Message`, and `_Dfault` in doing so.  
  
## Example  
 See the example for [get](../vs140/messages--get.md), which calls `do_get`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)