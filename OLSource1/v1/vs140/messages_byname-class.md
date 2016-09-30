---
title: "messages_byname Class"
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
  - "messages_byname"
  - "std::messages_byname"
  - "std.messages_byname"
  - "xlocmes/std::messages_byname"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "messages_byname class"
ms.assetid: c6c64841-3e80-43c8-b54c-fed41833ad6b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# messages_byname Class
The derived template class describes an object that can serve as a message facet of a given locale, enabling the retrieval of localized messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A named locale.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An initial reference count.  
  
## Remarks  
 Its behavior is determined by the named locale <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Each constructor initializes its base object with [messages](../vs140/messages-class.md#messages__messages)\<CharType>( <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)