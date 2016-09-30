---
title: "How to: Handle Screen Events in a Mobile Client for a LightSwitch App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ba240f05-731e-493f-b611-873f10e2d011
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Handle Screen Events in a Mobile Client for a LightSwitch App
As you develop an HTML mobile client in LightSwitch app, you can write JavaScript code that runs when a user initiates a certain event. For example, you can write code that runs when a user chooses a button on a screen in your client.  
  
 You can write the following kinds of methods to run when a user takes a certain action:  
  
-   Button methods run when a user chooses a button.  
  
-   General methods run when a user loads data, saves data, or closes a screen.  
  
-   Access control methods run when a user tries to perform a task that requires certain permissions.  
  
 For more information about these kinds of methods, see the tables after the following procedure.  
  
### To handle an event  
  
1.  In **Solution Explorer**, open the screen that you want to modify.  
  
     The **Screen Designer** opens.  
  
2.  On the **Screen Designer** toolbar, open the **Write Code** list, and then choose the appropriate method  
  
     The Code Editor opens.  
  
3.  In the new method, enter the code that you want to run when the event occurs.  
  
## Screen Event Methods  
 The following tables list methods that can run when a user interacts with a screen. All of these methods run on the client tier.  
  
|Button Method|Description|  
|-------------------|-----------------|  
|*ButtonName*_execute|Called when a user chooses the button that’s associated with the method. Applies only to buttons based on custom methods.|  
  
|General Methods|Description|  
|---------------------|-----------------|  
|*ScreenName*_created|Called just after the screen appears.|  
|*ControlName*_postRender|Called after the HTML for a control is created.|  
|*ControlName*_render|Called to create the HTML for a custom control.|  
|*ScreenName*_beforeApplyChanges|Called just before a screen is is closed and data is saved.|  
  
|**Access Control Methods**|Description|  
|--------------------------------|-----------------|  
|*MethodName*_canExecute|Called before a method runs. [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] calls this method to check permissions for the current user.|  
  
## See Also  
 [How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md)   
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)