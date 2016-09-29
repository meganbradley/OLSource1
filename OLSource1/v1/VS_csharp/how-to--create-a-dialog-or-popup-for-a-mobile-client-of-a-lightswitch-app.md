---
title: "How to: Create a Dialog or Popup for a Mobile Client of a LightSwitch App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 61499b17-4d81-4e43-a182-d87ce3e34a50
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Dialog or Popup for a Mobile Client of a LightSwitch App
If you create a dialog or a popup for your LightSwitch app, users can display or specify information on a phone, tablet, or other mobile device that's running a client for that app.  
  
 When a dialog appears, users must tap its **OK** or **Cancel** button to close it. You can create multiple dialogs for any screen and share the same dialog between screens.  
  
 A popup temporarily appears on top of a screen, and users close a popup by tapping anywhere outside it. You can create multiple popups for any screen, but you can’t share them between screens.  
  
### To create a dialog  
  
1.  In **Solution Explorer**, open the HTML client screen for which you want to create a dialog.  
  
2.  In the center pane of the screen designer, open the shortcut menu for the **Command Bar** node, and then choose **Add Button**.  
  
3.  In the **Add Button** dialog box, choose the **Choose an existing item** option button.  
  
4.  In the **showPopup** list, choose **edit** to create an **Add/Edit Details** screen, or choose **view** to create a **View Contacts** screen.  
  
5.  In the **Navigate to** list, choose **New Screen**, and then choose the **OK** button.  
  
6.  In the **Add New Screen** dialog box, give the dialog a useful name, and specify the screen data and additional data to include.  
  
     See [How to: Create an HTML Client Screen](../VS_csharp/how-to--create-an-html-client-screen.md).  
  
     You can add data and design the dialog as you would any other screen. See [How to: Design an HTML Screen by Using the Screen Designer](../VS_csharp/how-to--design-an-html-screen-by-using-the-screen-designer.md).  
  
### To show an existing screen as a dialog  
  
1.  In **Solution Explorer**, open the HTML client screen that you want to show as a dialog.  
  
2.  In the center pane of the screen designer, choose the top level node.  
  
3.  In the **Properties** window, select the **Show As Dialog** check box.  
  
### To create a popup  
  
1.  In **Solution Explorer**, open the HTML client screen for which you want to create a popup.  
  
2.  In the center pane of the screen designer, open the shortcut menu for the **Popups** node, and then choose **Add Popup**.  
  
3.  In the **Properties** window, give the popup a useful name.  
  
     You can add data and design the popup as you would any other screen. See [How to: Design an HTML Screen by Using the Screen Designer](../VS_csharp/how-to--design-an-html-screen-by-using-the-screen-designer.md).  
  
## See Also  
 [HTML Client Screens](../VS_csharp/html-client-screens-for-lightswitch-apps.md)   
 [How to: Design an HTML Screen by Using the Screen Designer](../VS_csharp/how-to--design-an-html-screen-by-using-the-screen-designer.md)