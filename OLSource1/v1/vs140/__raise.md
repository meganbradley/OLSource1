---
title: "__raise"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__raise"
  - "__raise_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__raise keyword [C++]"
ms.assetid: 6f1ae418-5f0f-48b6-9f6e-8ea7e66b239a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __raise
Emphasizes the call site of an event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 From managed code, an event can only be raised from within the class where it is defined. See [event](../vs140/event---c---component-extensions-.md) for more information.  
  
 The keyword <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> causes an error to be emitted if you call a non-event.  
  
> [!NOTE]
>  A templated class or struct cannot contain events.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Event Handling](../vs140/event-handling.md)   
 [New C++ Language Features](../vs140/component-extensions-for-runtime-platforms.md)