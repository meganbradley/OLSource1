---
title: "How to: Design a Silverlight Screen by Using the Screen Designer"
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
  - "screens [Visual Studio LightSwitch], design tasks"
  - "screens [Visual Studio LightSwitch], designing"
ms.assetid: a4ad22da-b1c4-459e-a979-0f7abe0ca92c
caps.latest.revision: 30
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Design a Silverlight Screen by Using the Screen Designer
You can modify the appearance of a screen by using the screen designer. You can use the screen designer to accomplish the following design tasks.  
  
 **Field and Command Design Tasks**  
  
-   [Add a group of information to a screen](#add2).  
  
-   [Modify the layout of a group](#modify).  
  
-   [Add buttons](#add3).  
  
-   [Add items](#add).  
  
-   [Remove items](#remove).  
  
-   [Move items](#move).  
  
-   [Change the display name of an item](#change).  
  
-   [Change the label position of an item](#change3).  
  
-   [Change the size of an item](#change4).  
  
-   [Show or hide an item](#specify).  
  
-   [Change the control type of an item](#change2).  
  
-   [Add a custom control to a screen](#custom).  
  
-   [Undo changes](#reverse).  
  
 **Data Collection Design Tasks**  
  
-   [Change whether a collection displays data when the screen loads for the first time](#collection).  
  
-   [Enable or disable paging](#paging).  
  
-   [Enable or disable sorting](#sorting).  
  
-   [Enable or disable search](#search).  
  
 For more information about how to accomplish design tasks while the application is running, see [How to: Customize a Screen in a Running Application](../vs140/how-to--customize-a-silverlight-screen-in-a-running-application.md).  
  
##  <a name="add2"></a> Add a Group of Information to a Screen  
  
1.  In the **Screen Content Tree**, select a group to which you would like to add a group of information.  
  
2.  At the top of the **Screen Designer**, click **Add Layout Item**, and then click **Group**.  
  
     A new group appears.  
  
3.  Drag items to the group. You can drag items from the **Screen Members List** of the designer or from other areas of the screen content tree.  
  
##  <a name="modify"></a> Modify the Layout of a Group  
  
1.  In the **Screen Content Tree**, click the down arrow next to a group that you want to modify.  
  
     A drop-down list appears. The drop-down list shows all of the control types that are available for the group.  
  
2.  In the drop-down list of controls, click a control type.  
  
     The control type that you select affects the layout of the group. For more information about each control type, see [Reference: Screen Properties](../vs140/reference--screen-designer-properties.md).  
  
##  <a name="add3"></a> Add Buttons  
  
1.  In the **Screen Content Tree**, select any **Command Bar** node.  
  
2.  At the top of the **Screen Designer**, click **Add Layout Item**, and then click **Button**.  
  
     A button appears beneath the **Command Bar** node.  
  
3.  Add code that runs when the user clicks the button. For more information, see [How to: Add a Custom Command to a Screen](../vs140/how-to--add-a-custom-command-to-a-silverlight-screen.md).  
  
##  <a name="add"></a> Add Items  
  
-   From the **Screen Members List** of the **Screen Designer**, drag an item (for example, a field or command) to the desired location in the **Screen Content Tree**.  
  
    > [!TIP]
    >  The screen content tree is the hierarchy of screen objects that are shown in the middle of the designer.  
  
     As you drag the item, the mouse cursor changes to indicate whether the item can be placed in a given spot. If the mouse cursor changes to a circle with a slash through it, you cannot drop the item in that location.  
  
     You can also add custom fields to a screen.  For more information, see [How to: Add a Local Field to a Screen](../vs140/how-to--add-a-local-property-to-a-silverlight-screen.md).  
  
##  <a name="remove"></a> Remove Items  
  
1.  In the **Screen Content Tree**, select the item (for example, a field or command) that you want to remove from the screen.  
  
2.  At the top of the **Screen Content Tree**, click the **Delete** button.  
  
##  <a name="Move"></a> Move Items  
  
-   In the **Screen Content Tree**, drag the item (for example, a field or command) to the desired location in the list of items.  
  
     For example, drag the `PostalCode` field to put it beneath the `Country` field, or drag the **Edit** button to put it above the **Delete** button.  
  
    > [!NOTE]
    >  As you drag a field, the mouse cursor changes to indicate whether the item can be placed in a given spot. If the mouse cursor changes to a circle with a slash through it, you cannot drop the item in that location.  
  
##  <a name="change"></a> Change the Display Name of an Item  
  
1.  In the **Screen Content Tree**, select the item (for example, a field or command).  
  
2.  In the **Properties** window, select the text box under **Display Name** and type the desired name for the item.  
  
     Changing the display name does not change the name of the item. It only changes the name of that item as it appears in the screen.  
  
##  <a name="change3"></a> Change the Label Position of an Item  
  
1.  In the **Screen Content Tree**, select the field.  
  
2.  In the **Properties** window, click the drop-down list under **Label Position** and select the desired position.  
  
     The following table describes each option.  
  
    |Label position|Description|  
    |--------------------|-----------------|  
    |**Left-aligned**|The label appears to the left of the control.|  
    |**Right-aligned**|The label appears to the right of the control.|  
    |**Top**|The label appears above the control.|  
    |**Bottom**|The label appears below the control.|  
    |**None**|No label appears for the selected data field.|  
    |**Collapsed**|The field is placed in the space that would otherwise be reserved for the label.|  
  
##  <a name="change4"></a> Change the Size of an Item  
  
1.  In the **Screen Content Tree**, select the item (for example, a field or command).  
  
2.  In the **Properties** window, under **Sizing**, select the desired size for the width and height of the control.  
  
     For information about each setting, see [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md).  
  
##  <a name="specify"></a> Show or Hide an Item  
  
1.  In the **Screen Content Tree**, select the item (for example, a field or command).  
  
2.  In the **Properties** window, select or clear the **Is Visible** property.  
  
     If you select **Is Visible**, the item appears on the screen when the application runs. If you clear **Is Visible**, the item is not visible on the screen when the application runs.  
  
    > [!NOTE]
    >  The label **(Not visible)** appears next to items that are not visible on the screen when the application runs.  
  
##  <a name="change2"></a> Change the Control Type of an Item  
  
1.  In the **Screen Content Tree**, select the drop-down list next to the item.  
  
2.  From the drop-down list, select the desired control type.  
  
     Most control types are built-in control types. You can also set the control type to a custom control that you create by using other tools. For more information about custom controls, see [How to: Add a Custom Control to a Screen](../vs140/how-to--add-a-custom-control-to-a-silverlight-screen.md).  
  
##  <a name="custom"></a> Add a Custom Control to a Screen  
  
1.  In the **Screen Content Tree**, select any group.  
  
2.  At the top of the **Screen Designer**, click **Add Layout Item**, and then click **Custom Control**.  
  
     For more information, see [How to: Add a Custom Control to a Screen](../vs140/how-to--add-a-custom-control-to-a-silverlight-screen.md).  
  
##  <a name="reverse"></a> Undo Changes  
  
-   On the **Edit** menu, click **Undo**.  
  
    > [!TIP]
    >  If you accidentally undo an edit in the **Screen Designer**, on the **Edit** menu, click **Redo**.  
  
##  <a name="collection"></a> Change Whether a Collection Displays Data When the Screen Loads for the First Time  
  
1.  In the **Screen Members List** of the **Screen Designer**, select the heading of a collection (for example, the `OrderCollection` heading).  
  
2.  In the **Properties** window, clear the **Auto Execute Query** check box if you do not want the collection to show any data when the screen appears. Select the **Auto Execute Query** check box if you want to the collection to show data when the screen appears.  
  
##  <a name="paging"></a> Enable or Disable Paging  
  
1.  In the **Screen Members List** of the **Screen Designer**, select the heading of a collection (for example, the `OrderCollection` heading).  
  
2.  In the **Properties** window, clear the **Support paging** check box if you want users to see all rows returned by a query even if the collection of rows is large. Select the **Support paging** check box if you want to limit the number of records that appear to the user when a query returns a large number of records.  
  
3.  If you select **Support paging**, under **No. of Items to Display per page**, specify the number of rows you want to appear to the user.  
  
    > [!NOTE]
    >  Users can advance through sets of rows by clicking a link in the screen.  
  
##  <a name="sorting"></a> Enable or Disable Sorting  
  
1.  In the **Screen Members List** of the **Screen Designer**, select the heading of a collection (for example, the `OrderCollection` heading).  
  
2.  In the **Properties** window, clear the **Support sorting** check box if you do not want users to sort the data that appears for the collection. Select the **Support paging** check box if you want to enable users to sort the data that appears for the collection.  
  
##  <a name="search"></a> Enable or Disable Search  
  
1.  In the **Screen Members List** of the **Screen Designer**, select the heading of a collection (for example, the `OrderCollection` heading).  
  
2.  In the **Properties** window, clear the **Support search** check box if you do not want a search box to appear above the collection. Select the **Support search** check box if you want a search box to appear above the collection.  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [How to: Customize a Screen in a Running Application](../vs140/how-to--customize-a-silverlight-screen-in-a-running-application.md)   
 [How to: Add a Local Property to a Screen](../vs140/how-to--add-a-local-property-to-a-silverlight-screen.md)   
 [How to: Add a Custom Command to a Screen](../vs140/how-to--add-a-custom-command-to-a-silverlight-screen.md)   
 [How to: Add Collections of Data to a Screen](../vs140/how-to--add-data-to-a-screen.md)