---
title: "Event Sources (Visual Studio SDK)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], event sources"
ms.assetid: b9ba0908-ae4c-4a64-aab1-bee453dd7a22
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Event Sources (Visual Studio SDK)
There are two sources of events: the debug engine (DE) and the session debug manager (SDM). Events sent from a DE have a non-NULL engine, while events sent from the SDM have a NULL engine.  
  
## Example  
 The following example shows how to send the **IDebugProgramCreateEvent2** from the DE to the SDM.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Sending Events](../vs140/sending-events.md)