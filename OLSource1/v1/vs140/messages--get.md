---
title: "messages::get"
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
  - "get"
  - "messages::get"
  - "messages.get"
  - "std::messages::get"
  - "xlocmes/std::messages::get"
  - "std.messages.get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: f5b769b8-17a0-4622-8ba1-c6758c7faa18
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::get
Retrieves the message catalog.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identification value specifying the message catalog to be searched.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second identified used to locate a message in a message catalog.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The string to be returned on failure.  
  
## Return Value  
 It returns a copy of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on failure. Otherwise, it returns a copy of the specified message sequence.  
  
## Remarks  
 The member function returns [do_get](../vs140/messages--do_get.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)