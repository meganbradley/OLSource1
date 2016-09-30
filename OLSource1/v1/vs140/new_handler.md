---
title: "new_handler"
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
  - "new_handler"
  - "std.new_handler"
  - "std::new_handler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "new_handler function"
ms.assetid: 4a28059f-a15a-478c-a63f-7dff446574e4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new_handler
The type points to a function suitable for use as a new handler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This type of handler function is called by **operator new** or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when they cannot satisfy a request for additional storage.  
  
## Example  
 See [set_new_handler](../vs140/set_new_handler.md) for an example using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as a return value.  
  
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std