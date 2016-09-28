---
title: "Using IDispEventImpl"
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
  - "IDispEventImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDispEventImpl class, using"
ms.assetid: 82d53b61-9d0d-45c5-aff9-2fafa468a9ca
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using IDispEventImpl
When using `IDispEventImpl` to handle events, you will need to:  
  
-   Derive your class from [IDispEventImpl](../vs140/idispeventimpl-class.md).  
  
-   Add an [event sink map](../vs140/begin_sink_map.md) to your class.  
  
-   Add entries to the event sink map using the [SINK_ENTRY](../vs140/sink_entry.md) or [SINK_ENTRY_EX](../vs140/sink_entry_ex.md) macro.  
  
-   Implement the methods that you're interested in handling.  
  
-   Advise and unadvise the event source.  
  
## Example  
 The example below shows how to handle the **DocumentChange** event fired by Word's **Application** object. This event is defined as a method on the **ApplicationEvents** dispinterface.  
  
 The example is from the [ATLEventHandling sample](../vs140/visual-c---samples.md).  
  
 `[`  
  
 `uuid(000209F7-0000-0000-C000-000000000046),`  
  
 `hidden`  
  
 `]`  
  
 `dispinterface ApplicationEvents {`  
  
 `properties:`  
  
 `methods:`  
  
 `[id(0x00000001), restricted, hidden]`  
  
 `void Startup();`  
  
 `[id(0x00000002)]`  
  
 `void Quit();`  
  
 `[id(0x00000003)]`  
  
 `void DocumentChange();`  
  
 `};`  
  
 The example uses `#import` to generate the required header files from Word's type library. If you want to use this example with other versions of Word, you must specify the correct mso dll file. For example, Office 2000 provides mso9.dll and OfficeXP provides mso.dll. This code is simplified from stdafx.h:  
  
 [!code[NVC_ATL_EventHandlingSample#1](../vs140/codesnippet/CPP/using-idispeventimpl_1.h)]  
  
 The following code appears in NotSoSimple.h. The relevant code is noted by comments:  
  
 [!code[NVC_ATL_EventHandlingSample#2](../vs140/codesnippet/CPP/using-idispeventimpl_2.h)]  
  
## See Also  
 [Event Handling](../vs140/event-handling-and-atl.md)   
 [ATLEventHandling Sample](../vs140/visual-c---samples.md)