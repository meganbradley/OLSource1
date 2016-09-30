---
title: "Compiler Error C3739"
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
  - "C3739"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3739"
ms.assetid: acffe894-08b8-4bf2-9249-9501e6e2bad3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3739
'class': syntax is only supported when the 'layout_dependent' parameter of event_receiver is true  
  
 You tried to hook an entire interface of events but <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on [event_receiver](../vs140/event_receiver.md) attribute is not true; you must hook a single event at a time.  
  
 The following sample generates C3739:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>