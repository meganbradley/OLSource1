---
title: "How to: Control Navigation between HTML Screens in a LightSwitch App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 781e75ce-593c-4888-8e27-55d23e8c1c2e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Control Navigation between HTML Screens in a LightSwitch App
As you design an HTML client for a Visual Studio LightSwitch app, you specify how users open one screen from another. They can open a screen by tapping either a list item on another screen or a button on the command bar.  
  
> [!NOTE]
>  If you create a Common Screen Set, standard navigation between screens is automatically created for you. See [Choosing a Screen Type for an HTML Client of a LightSwitch App](../VS_csharp/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md).  
  
### To open a screen by tapping a list item  
  
1.  In **Solution Explorer**, open the screen from which users will open a different screen.  
  
2.  In the Screen Designer, in the **Screen Content Tree**, choose the collection node or button that users will tap to open the new screen.  
  
3.  In the **Properties** window, choose the **Item Tap** link.  
  
4.  In the **Edit Tap Action** dialog box, choose the **Choose an existing method** option button.  
  
5.  In the **showPopup** list, choose **show***ScreenName*, where *ScreenName* is the screen that you want to open, and then choose the **OK** button.  
  
### To open a screen by tapping a button  
  
1.  In **Solution Explorer**, open the screen from which users will open a different screen.  
  
2.  In the Screen Designer, open the shortcut menu for the **Command Bar** node, and then choose **Add Button**.  
  
3.  In the **Add Button** dialog box, choose the **Choose an existing method** option button.  
  
4.  In the **showPopup** list, choose **show***ScreenName*, where *ScreenName* is the screen that you want to open.  
  
5.  Perform one of the following sets of steps:  
  
    -   To create a **View Details** screen, expand the *EntityName* list, where *EntityName* is the entity on which the screen is based. Enter *EntityName*`.selectedItem`, and then choose the **OK** button.  
  
    -   To create an **Add/Edit Details** screen, expand the *EntityName* list, where *EntityName* is the entity on which the screen is based. Enter either `(New` *EntityName*`)` or *EntityName*`.selectedItem`, and then choose the **OK** button.  
  
    -   To create a **Browse** screen, choose the **OK** button.  
  
6.  In the **Properties** window, expand the **Icon** list, and then choose an icon for the button.  
  
     Choose the **Display Name** property if you want to change the text on the button.  
  
## See Also  
 [HTML Client Screens](../VS_csharp/html-client-screens-for-lightswitch-apps.md)