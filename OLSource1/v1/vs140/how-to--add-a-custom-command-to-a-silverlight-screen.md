---
title: "How to: Add a Custom Command to a Silverlight Screen"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "screens [Visual Studio LightSwitch], custom buttons"
  - "screens [Visual Studio LightSwitch], custom commands"
  - "screens [Visual Studio LightSwitch], custom methods"
ms.assetid: b815c3ed-ec5c-4521-942a-cf424a3f78c7
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Custom Command to a Silverlight Screen
You can add custom code that runs when the user clicks a button on a screen. First, add a custom command to a screen. Then, add custom code that runs when the user clicks the button.  
  
### To add a custom command to a screen  
  
1.  In the **Screen Content Tree** of the **Screen Designer**, decide where you want to place the command, and then perform one of the following actions:  
  
    -   Right-click the desired node, and then select **Add Button**.  
  
    -   Select the desired node. Then, on the command bar of the **Screen Designer**, click **Add Layout Item**, and then click **Button**.  
  
     The **Add Button** dialog box appears.  
  
2.  In the **Add Button** dialog box, select one of the following options:  
  
    -   Select **New Method** if you want to create a method that runs when the user clicks the button.  
  
    -   Select **Existing Method** if you want to use a method that has already been added to the screen. You must select the method from the **Name** drop-down list.  
  
3.  In the **Screen Content Tree**, right-click the command, and then click **Edit Execute Code**.  
  
     The Code Editor opens and generates a method named *ButtonName*_Execute.  
  
4.  Add custom code to the *ButtonName*_Execute method.  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)