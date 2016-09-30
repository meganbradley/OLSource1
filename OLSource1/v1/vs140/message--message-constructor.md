---
title: "message::message Constructor"
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
  - "agents/concurrency::message::message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message, constructor"
ms.assetid: 515d2743-1a79-479f-bd84-e3fc49faa607
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message::message Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The payload of this message.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unique ID of this message.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference or pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The constructor that takes a pointer to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object as an argument throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [message Class](../vs140/message-class.md)