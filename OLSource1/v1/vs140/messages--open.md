---
title: "messages::open"
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
  - "messages::open"
  - "std.messages.open"
  - "messages.open"
  - "Open"
  - "std::messages::open"
  - "open"
  - "xlocmes/std::messages::open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open method"
ms.assetid: 84ae3a79-a1ab-45ab-8ef9-8c4a43d846a0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::open
Opens the message catalog.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the catalog to be searched.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale being searched for in the catalog.  
  
## Return Value  
 It returns a value that compares less than zero on failure. Otherwise, the returned value can be used as the first argument on a later call to [get](../vs140/messages--get.md).  
  
## Remarks  
 The member function returns [do_open](../vs140/messages--do_open.md)(<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)