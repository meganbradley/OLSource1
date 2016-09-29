---
title: "How to: Customize a Silverlight Screen in a Running Application"
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
  - "screens [Visual Studio LightSwitch], customizing"
  - "screens [Visual Studio LightSwitch], configuring"
ms.assetid: a9bd7c44-5e91-4a35-af5f-19ac26a76fde
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Customize a Silverlight Screen in a Running Application
You can modify the appearance of a screen while the application is running by using the **Customization Mode** screen. You can also see a preview of how the screen will look after you apply those changes. To open the **Customization Mode** screen, click the **Design Screen** button at the top of the screen.  
  
> [!NOTE]
>  The **Design Screen** button appears at the top of a screen that is open in the running application only. This button does not appear above a screen that is open in the screen designer.  
  
 When you have finished making your changes, click the **Save** button to commit them.  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo")For a related video demonstration, see [How Do I: Create an Edit Details Screen in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205123).  
  
 You can use the **Customization Mode** screen to accomplish the following design tasks:  
  
-   [Add a group of information to a screen](#add).  
  
-   [Modify the layout of a group](#modify).  
  
-   [Add buttons](#add2).  
  
-   [Remove items](#remove).  
  
-   [Move items](#move).  
  
-   [Change item captions](#change).  
  
-   [Change the label position of an item](#change3).  
  
-   [Show or hide an item](#specify).  
  
-   [Change the control type of an item (for example, a label or text box)](#change2).  
  
-   [Undo changes](#reverse).  
  
-   [Reset item properties to their default values](#reset).  
  
 For more information about how to accomplish design tasks by using the screen designer, see [How to: Customize a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md).  
  
##  <a name="add"></a> Add a Group of Information to a Screen  
  
1.  In the **Screen Content Tree**, select the node to which you want to add a group of items.  
  
2.  Click the **Add Group** button. ![Adds a group.](../vs140/media/ls_group_button.gif "LS_Group_Button")  
  
3.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item (for example, a field or command).  
  
4.  Next to the screen, click the **Move Up** (![Moves the item to a higher position in the list.](../vs140/media/ls_addbutton_button.png "LS_AddButton_Button")) and **Move Down** (![Moves an item to a position lower in the list.](../vs140/media/ls_movedown_button.png "LS_MoveDown_Button")) buttons to move an item into the group.  
  
##  <a name="modify"></a> Modify the Layout of a Group  
  
1.  In the **Screen Content Tree**, click the down arrow next to a group that you want to modify.  
  
     A drop-down list appears. The drop-down list shows all of the control types that are available for the group.  
  
2.  In the drop-down list of controls, select a control type.  
  
     The control type that you select affects the layout of the group. For more information about each control type, see [Reference: Screen Properties](../vs140/reference--screen-designer-properties.md).  
  
##  <a name="add2"></a> Add Buttons  
  
1.  In the **Screen Content Tree**, select the node to which you want to add a group of items.  
  
2.  Click the **Add Button** button, and then click **New Button**.  
  
##  <a name="remove"></a> Remove Items  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item that you want to remove from the screen.  
  
2.  Next to the **Screen Content Tree**, click the **Delete** (![Deletes the selected item.](../vs140/media/ls_delete_button.png "LS_Delete_Button")) button.  
  
##  <a name="move"></a> Move Items  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item (for example, a field or command).  
  
2.  Next to the screen, click the **Move Up** (![Moves the item to a higher position in the list.](../vs140/media/ls_addbutton_button.png "LS_AddButton_Button")) and **Move Down** (![Moves an item to a position lower in the list.](../vs140/media/ls_movedown_button.png "LS_MoveDown_Button")) buttons to position an item in the list of items.  
  
##  <a name="change"></a> Change Item Captions  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item (for example, a field or command).  
  
2.  In the **Properties** window, select the **Display Name** field, and then type the text that you want to appear as the caption of the item.  
  
##  <a name="change3"></a> Change the Label Position of an Item  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item (for example, a field or command).  
  
2.  In the **Properties** window, click the drop-down list under **Label Position**, and then select the desired position.  
  
     The following table describes each option.  
  
    |Label position|Description|  
    |--------------------|-----------------|  
    |**Left-aligned**|The label appears to the left of the control.|  
    |**Right-aligned**|The label appears to the right of the control.|  
    |**Top**|The label appears above the control.|  
    |**Bottom**|The label appears below the control.|  
    |**None**|No label appears for the selected data field.|  
    |**Collapsed**|The label appears as collapsed.|  
  
##  <a name="specify"></a> Show or Hide an Item  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the item (for example, a field or command).  
  
2.  In the **Properties** window, select or clear the **Is Visible** property.  
  
     If you select **Is Visible**, the item will appear on the screen. If you clear **Is Visible**, the item will not be visible on the screen.  
  
##  <a name="change2"></a> Change the Control Type of an Item  
  
1.  In the **Screen Content Tree** of the **Customization Mode** screen, select the drop-down list next to the item.  
  
2.  From the drop-down list, click the desired control type.  
  
     Most control types are built-in control types. You can also set the control type to a custom control that you create by using other tools. For more information about custom controls, see [How to: Add a Custom Control to a Screen](../vs140/how-to--add-a-custom-control-to-a-silverlight-screen.md).  
  
##  <a name="reverse"></a> Undo Changes  
  
-   In the **Customization Mode** screen, click **Cancel**.  
  
     All changes that you made since you opened the **Customization Mode** screen will be discarded.  
  
    > [!NOTE]
    >  You cannot undo individual edits on the **Customization Mode** screen.  
  
##  <a name="reset"></a> Reset the Properties of Items to Their Default Values  
  
1.  In the **Screen Content Tree**, select a node that represents a group of items.  
  
2.  Next to the **Screen Content Tree**, click the **Reset Items** button. ![Resets item properties to their default values.](../vs140/media/ls_resetfields_button.png "LS_ResetFields_Button")  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [How to: Customize a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md)