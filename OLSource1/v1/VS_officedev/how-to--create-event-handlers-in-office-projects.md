---
title: "How to: Create Event Handlers in Office Projects"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Visual Basic [Office development in Visual Studio], event handlers"
  - "event handlers [Office development in Visual Studio]"
  - "Visual C# [Office development in Visual Studio], event handlers"
  - "events [Office development in Visual Studio]"
ms.assetid: 2cfd6a45-4c25-4431-b4fc-e0f2c0a72e54
caps.latest.revision: 31
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Create Event Handlers in Office Projects
  There are several ways to create event handlers in Visual Basic and C#. In design view, you can create the default event handlers for controls by double-clicking the control, or use the events pane of the **Properties** window to create handlers for any event on the control. However, if you are in Code view, you may not want to switch to Design view to create an event handler.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 [!INCLUDE[note_settings_general](../VS_officedev/includes/note_settings_general_md.md)]  
  
### To create an event handler in Visual Basic  
  
1.  From the **Class Name** drop-down list at the top of the Code Editor, select the object that you want to create an event handler for.  
  
    > [!NOTE]  
    >  If you want to create event handlers for `ThisDocument` or `ThisWorkbook`, you must select **(ThisDocument Events)** or **(ThisWorkbook Events)** in the **Class Name** drop-down list  
  
2.  From the **Method Name** drop-down list at the top of the Code Editor, select the event.  
  
     Visual Studio creates the event handler and moves the insertion point to the newly created event handler. If the event handler already exists, the insertion point moves to the existing event handler.  
  
### To create an event handler in C#  
  
1.  Create the event delegate in the **Startup** event of the class by typing the qualified event name followed by a space, and then typing **+=** with no space afterwards. For example:  
  
     `this.<object name>.<event name> +=`  
  
2.  At the end of the line of code, press the TAB key twice.  
  
     Visual Studio automatically completes the line of code, creates the event handler, and moves the insertion point to the newly created event handler.  
  
## See Also  
 [Writing Code in Office Solutions](../VS_officedev/writing-code-in-office-solutions.md)   
 [Walkthrough: Programming Against Events of a NamedRange Control](../VS_officedev/walkthrough--programming-against-events-of-a-namedrange-control.md)   
 [Building Office Solutions](../VS_officedev/building-office-solutions.md)  
  
  