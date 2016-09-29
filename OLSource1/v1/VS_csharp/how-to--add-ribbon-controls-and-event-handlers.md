---
title: "How to: Add Ribbon Controls and Event Handlers"
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
  - "event handlers, adding"
  - "ribbon controls, adding"
ms.assetid: b31f25bc-ede7-49c3-9e3c-dffe4e174a69
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add Ribbon Controls and Event Handlers
Ribbon controls are elements, such as buttons and combo boxes, that you add to panels. Panels are areas of the ribbon bar that display a group of related controls.  
  
 In this topic, you will open the Ribbon Designer, add a button, and then link an event that displays "Hello World".  
  
### To open the Ribbon Designer  
  
1.  In Visual Studio, on the **View** menu, click **Resource View**.  
  
2.  In **Resource View**, double-click the ribbon resource to display it on the design surface.  
  
### To add a Button and an Event Handler  
  
1.  From the **Toolbar**, click **Button** and drag it on to a panel in the design surface.  
  
2.  Right-click the button, and click **Add Event Handler**.  
  
3.  In the **Event Handler Wizard**, confirm the default settings and click **Add and Edit**. For more information, see [Event Handler Wizard](../VS_csharp/event-handler-wizard.md).  
  
4.  In the code editor, add the following code into the handler function:  
  
    ```  
    MessageBox((LPCTSTR)L"Hello World");  
    ```  
  
## See Also  
 [RibbonGadgets Sample: Ribbon Gadgets Application](../VS_csharp/visual-c---samples.md)   
 [Ribbon Designer (MFC)](../VS_csharp/ribbon-designer--mfc-.md)