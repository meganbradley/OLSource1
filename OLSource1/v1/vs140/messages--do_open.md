---
title: "messages::do_open"
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
  - "std::messages::do_open"
  - "std.messages.do_open"
  - "do_open"
  - "messages::do_open"
  - "xlocmes/std::messages::do_open"
  - "messages.do_open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_open method"
ms.assetid: 859ae6c9-23e2-4c83-ad50-721baf3374c3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages::do_open
A virtual function called to open the message catalog.  
  
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
 The protected member function tries to open a message catalog whose name is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It may make use of the locale <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in doing so  
  
 The return value should be used as the argument on a later call to [close](../vs140/messages--close.md).  
  
## Example  
 See the example for [open](../vs140/messages--open.md), which calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [messages Class](../vs140/messages-class.md)