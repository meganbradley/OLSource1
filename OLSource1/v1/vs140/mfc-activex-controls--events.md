---
title: "MFC ActiveX Controls: Events"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC ActiveX controls, events"
  - "notifications [C++], notifying containers of events"
  - "custom events, adding to ActiveX controls"
  - "events [C++], mapping"
  - "COleControl class, handling of events"
  - "mappings, events"
  - "stock events"
  - "container events"
  - "events [C++], ActiveX controls"
  - "OLE events"
ms.assetid: e1e57e0c-206b-4923-a0b5-682c26564f74
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Events
ActiveX controls use events to notify a container that something has happened to the control. Common examples of events include clicks on the control, data entered using the keyboard, and changes in the control's state. When these actions occur, the control fires an event to alert the container.  
  
 Events are also called messages.  
  
 MFC supports two kinds of events: stock and custom. Stock events are those events that class [COleControl](../vs140/colecontrol-class.md) handles automatically. For a complete list of stock events, see the article [MFC ActiveX Controls: Adding Stock Events](../vs140/mfc-activex-controls--adding-stock-events-to-an-activex-control.md). Custom events allow a control the ability to notify the container when an action specific to that control occurs. Some examples would be a change in the internal state of a control or receipt of a certain window message.  
  
 For your control to fire events properly, your control class must map each event of the control to a member function that should be called when the related event occurs. This mapping mechanism (called an event map) centralizes information about the event and allows Visual Studio to easily access and manipulate the control's events. This event map is declared by the following macro, located in the header (.H) file of the control class declaration:  
  
 [!code[NVC_MFC_AxUI#2](../vs140/codesnippet/CPP/mfc-activex-controls--events_1.h)]  
  
 After the event map has been declared, it must be defined in your control's implementation (.CPP) file. The following lines of code define the event map, allowing your control to fire specific events:  
  
 [!code[NVC_MFC_AxUI#3](../vs140/codesnippet/CPP/mfc-activex-controls--events_2.cpp)]  
[!code[NVC_MFC_AxUI#4](../vs140/codesnippet/CPP/mfc-activex-controls--events_3.cpp)]  
  
 If you use the MFC ActiveX Control Wizard to create the project, it automatically adds these lines. If you do not use the MFC ActiveX Control Wizard, you must add these lines manually.  
  
 With Class View, you can add stock events supported by class `COleControl` or custom events that you define. For each new event, Class View automatically adds the proper entry to the control's event map and the control's .IDL file.  
  
 Two other articles discuss events in detail:  
  
-   [MFC ActiveX Controls: Adding Stock Events](../vs140/mfc-activex-controls--adding-stock-events-to-an-activex-control.md)  
  
-   [MFC ActiveX Controls: Adding Custom Events](../vs140/mfc-activex-controls--adding-custom-events.md)  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md)   
 [COleControl Class](../vs140/colecontrol-class.md)