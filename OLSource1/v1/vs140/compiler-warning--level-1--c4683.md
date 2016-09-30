---
title: "Compiler Warning (level 1) C4683"
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
  - "C4683"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4683"
ms.assetid: e6e77364-dba1-46dd-ae1d-03da23070bce
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4683
**'**   
 ***function* ': event source has an 'out'-parameter; exercise caution when hooking multiple event handlers**  
  
 If more than one event sink is listening to a COM event source, the value of an out parameter may be ignored.  
  
 Be aware that a memory leak will occur in the following situation:  
  
1.  If a method has an out parameter that is internally allocated, for example a BSTR *.  
  
2.  If the event has more than one handler (is a multicast event)  
  
 The reason for the leak is that the out parameter will be set by more than one handler, but returned to the call site only by the last handler.  
  
 The following sample generates C4683:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>