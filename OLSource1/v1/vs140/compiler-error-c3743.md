---
title: "Compiler Error C3743"
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
  - "C3743"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3743"
ms.assetid: 7ca9a76e-7b60-46d1-ab8b-18600cf1a306
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3743
can only hook/unhook an entire interface when the 'layout_dependent' parameter of event_receiver is true  
  
 The [__unhook](../vs140/__unhook.md) function varies in the number of parameters that it takes based on the value passed to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter in the [event_receiver](../vs140/event_receiver.md) class.  
  
 The following sample generates C3743:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>