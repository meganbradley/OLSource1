---
title: "Compiler Error C3703"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3703"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3703"
ms.assetid: 7e3677d9-f2be-4c26-998f-423564e9023c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3703
'event handler': an event handler method must have the same storage class as the source 'event'  
  
 An [event](../vs140/event-handling.md) has a different storage class than the event handler to which it is hooked. For example, this error occurs if the event handler is a static member function and the event is not static. To fix this error, give the event and the event handler the same storage class.  
  
 The following sample generates C3703:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>