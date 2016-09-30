---
title: "Compiler Error CS0070"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0070"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0070"
ms.assetid: bb0de7c6-c734-4a8f-ab62-0a50eac2a91f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0070
The event 'event' can only appear on the left hand side of += or -= (except when used from within the type 'type')  
  
 Outside of the class it is defined in, an [event](../vs140/event--csharp-reference-.md) can only add or subtract references. For more information, see [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md).  
  
 The following sample generates CS0070:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>