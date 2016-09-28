---
title: "How to: Add a Button to a Mobile Client for LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a681e17b-f0a4-4ca9-8d05-fc73edeafc73
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Button to a Mobile Client for LightSwitch
When you develop an HTML mobile client for your [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] app, you can add code that runs when the user taps a button on a screen in that client. For example, you might add code that launches a different screen or performs a calculation.  
  
### To add a custom button to a screen  
  
1.  In the **Screen Content Tree**, choose the node where you want the button to appear.  
  
2.  On the **Screen Designer** toolbar, choose the **Add Layout Item** drop-down list, and then choose **Button**.  
  
     The **Add Button** dialog box appears.  
  
3.  ##### To use a built-in method  
4.  1.  In the **Add Button** dialog box, choose the **Choose an existing method** option button.  
  
    2.  In the **showDialog** list, choose the method to run.  
  
         If you choose a method that displays a screen or a dialog box, additional choices may appear. For more information, see [How to: Control Navigation between HTML Screens](../vs140/how-to--control-navigation-between-html-screens-in-a-lightswitch-app.md).  
  
    3.  Choose the **OK** button to create the button.  
5.  ##### To create your own method  
6.  1.  In the **Add Button** dialog box, choose the **Write my own method** option button.  
  
    2.  In the **Method** text box, enter a name for the button, and then choose the **OK** button.  
  
    3.  In the **Screen Content Tree**, open the shortcut menu for the new button node and choose **Edit Execute Code** code.  
  
         The code editor appears.  
  
    4.  In the code editor, add code that will run when the user taps the button.  
  
## See Also  
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)