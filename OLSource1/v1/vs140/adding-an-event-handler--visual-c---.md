---
title: "Adding an Event Handler (Visual C++)"
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
  - "vc.codewiz.eventhandler.overview"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handlers, adding"
  - "properties [Visual Studio], MSBuild"
  - "MSBuild, properties"
ms.assetid: 050bebf0-a9e0-474b-905c-796fe5ac8fc3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding an Event Handler (Visual C++)
From the resource editor, you can add a new event handler, or edit an existing event handler, for a dialog box control using the [Event Handler Wizard](../vs140/event-handler-wizard.md).  
  
 You can add an event to the class implementing the dialog box using the [Properties window](../vs140/properties-window.md). If you want to add the event to a class other than the dialog box class, use the Event Handler Wizard.  
  
### To add an event handler to a dialog box control  
  
1.  Double-click the dialog box resource in [Resource View](../vs140/resource-view-window.md) to open the dialog box resource that contains the control in the [dialog editor](../vs140/dialog-editor.md).  
  
2.  Right-click the control for which you want to handle the notification event.  
  
3.  On the shortcut menu, click **Add Event Handler** to display the Event Handler Wizard.  
  
4.  Select the event in the **Message type** box to add to the class selected in the **Class list** box.  
  
5.  Accept the default name in the **Function handler name** box, or provide the name of your choice.  
  
6.  Click **Add and edit** to add the event handler to the project and open the text editor at the new function to add the appropriate event handler code.  
  
     If the selected message type already has an event handler for the selected class, **Add and edit** is unavailable, and **Edit code** is available. Click **Edit code** to open the text editor at the existing function.  
  
 Alternately, you can add event handlers from the [Properties window](../vs140/properties-window.md). See [Adding Event Handlers for Dialog Box Controls](../vs140/adding-event-handlers-for-dialog-box-controls.md) for more information.  
  
## See Also  
 [Adding Functionality with Code Wizards](../vs140/adding-functionality-with-code-wizards--c---.md)   
 [Adding a Class](../vs140/adding-a-class--visual-c---.md)   
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)   
 [Adding a Member Function](../vs140/adding-a-member-function--visual-c---.md)   
 [MFC Message Handler](../vs140/adding-an-mfc-message-handler.md)   
 [Navigating the Class Structure](../vs140/navigating-the-class-structure--visual-c---.md)