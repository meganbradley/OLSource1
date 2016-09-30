---
title: "How to: Design an HTML Screen by Using the Screen Designer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b044149e-fb28-4586-81c1-00f75cb518f0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Design an HTML Screen by Using the Screen Designer
By using the screen designer, you can modify the appearance of screens in an HTML client for a Visual Studio LightSwitch app. For example, you can use the designer to accomplish the following tasks.  
  
-   [Add a tab to a screen](../vs140/how-to--design-an-html-screen-by-using-the-screen-designer.md#tab).  
  
-   [Add a group of information to a screen](#add2).  
  
-   [Modify the layout of a group](#modify).  
  
-   [Add a button](#add3).  
  
-   [Add an item](#add).  
  
-   [Remove an item](#remove).  
  
-   [Move an item](#move).  
  
-   [Change the display name of an item](#change).  
  
-   [Change the label position of an item](#change3).  
  
-   [Change the size of an item](#change4).  
  
-   [Show or hide an item](#specify).  
  
-   [Change the control type of an item](#change2).  
  
-   [Add a custom control to a screen](#custom).  
  
-   [Undo changes](#reverse).  
  
-   [Enable or disable paging](#paging).  
  
##  \<a name="tab">\</a> Add a Tab to a Screen  
  
1.  In the **Screen Content Tree**, open the shortcut menu for the **Tabs** node, and then choose **Add Tab**.  
  
2.  In the **Properties** window, choose the **Group** property, and then enter a name for the tab.  
  
3.  Choose the **Display Name** property, and then enter the name that will appear on the tab.  
  
4.  In the **Screen Content Tree**, choose the new tab, open the **Add** list, and then choose the items that you want to display on the tab.  
  
##  \<a name="add2">\</a> Add a Group of Information to a Screen  
  
1.  In the **Screen Content Tree**, choose the node to which you want to add a group of information.  
  
2.  On the **Screen Designer** toolbar, open the **Add Layout Item** list, and then choose **Group**.  
  
     A new group appears.  
  
3.  In the **Properties** window, in the **Name** text box, enter a name for the group.  
  
4.  In the **Screen Content Tree**, choose the new group, open the **Add** list, and then choose the items that you want to display in the group.  
  
##  \<a name="modify">\</a> Modify the Layout of a Group  
  
1.  In the **Screen Content Tree**, open the list for a group that you want to modify.  
  
     The list shows all of the control types that are available for the group.  
  
2.  In the list, choose a control type.  
  
     The control type that you choose affects the layout of the group. For more information about each control type, see [Reference: Screen Properties](../vs140/reference--screen-designer-properties.md).  
  
##  \<a name="add3">\</a> Add a Button  
  
1.  In the **Screen Content Tree**, choose the node where you want the button to appear.  
  
2.  On the **Screen Designer** toolbar, choose **Add Layout Item**, and then choose **Button**.  
  
     The **Add Button** dialog box appears.  
  
3.  ###### To use a built-in method  
4.  1.  In the **Add Button** dialog box, choose the **Choose an existing method** option button.  
  
    2.  In the **showDialog** list, choose the method to run.  
  
         If you choose a method that displays a screen or a dialog box, more choices may appear. For more information, see [How to: Control Navigation between HTML Screens](../vs140/how-to--control-navigation-between-html-screens-in-a-lightswitch-app.md).  
  
    3.  Choose the **OK** button.  
5.  ###### To create your own method  
6.  1.  In the **Add Button** dialog box, choose the **Write my own method** option button.  
  
    2.  In the **Method** text box, enter a name for the button, and then choose the **OK** button.  
  
    3.  In the **Screen Content Tree**, open the shortcut menu for the new button node, and then choose **Edit Execute** code.  
  
         The code editor appears.  
  
    4.  In the code editor, add code that will run when the user taps the button.  
  
         For more information, see [How to: Add a Custom Command to an HTML Screen](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md).  
  
##  \<a name="add">\</a> Add an Item  
  
-   In the **Screen Members List** of the **Screen Designer**, drag an item (for example, a field or a command) to the appropriate location in the **Screen Content Tree**.  
  
     As you drag the item, the pointer indicates whether you can move the item to a given location. If the pointer changes to a circle with a slash through it, you can’t drop the item in that location.  
  
     For information about how to add custom fields to a screen, see [How to: Add a Local Property to an HTML Screen](../vs140/how-to--add-a-local-property-to-an-html-screen.md).  
  
##  \<a name="remove">\</a> Remove an Item  
  
1.  In the **Screen Content Tree**, choose the item (for example, a field or a command) that you want to remove.  
  
2.  On the **Screen Designer** toolbar, choose the **Delete** button.  
  
##  \<a name="move">\</a> Move an Item  
  
-   In the **Screen Content Tree**, drag an item (for example, a field or a command) to the a different location.  
  
     For example, drag the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> field so that it appears under the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> field, or drag the **Edit** button so that it appears over the **Delete** button.  
  
    > [!NOTE]
    >  As you drag a field, the pointer indicates whether you can move the item to a given location. If the pointer changes to a circle with a slash through it, you cannot move the item to that location.  
  
##  \<a name="change">\</a> Change the Display Name of an Item  
  
1.  In the **Screen Content Tree**, choose the item (for example, a field or a command).  
  
2.  In the **Properties** window, in the text box under **Display Name**, enter a different name for the item.  
  
     If you change the display name of an item, you change only the name that appears in the screen. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property of the item stays the same.  
  
##  \<a name="change3">\</a> Change the Label Position of an Item  
  
1.  In the **Screen Content Tree**, choose the field.  
  
2.  In the **Properties** window, open the list under **Label Position**, and then choose the position that you want.  
  
     The following table describes each option.  
  
    |Label position|Description|  
    |--------------------|-----------------|  
    |**Left-aligned**|The label appears near the left side of the control.|  
    |**Right-aligned**|The label appears  near the right side of the control.|  
    |**Top**|The label appears above the control.|  
    |**Hidden**|No label appears for the control.|  
    |**None**|No label appears for the control, and it’s aligned where the label would have been.|  
  
##  \<a name="change4">\</a> Change the Size of an Item  
  
1.  In the **Screen Content Tree**, choose the item (for example, a field or a command).  
  
2.  In the **Properties** window, under **Sizing**, choose a different size for the width and height of the control.  
  
    > [!NOTE]
    >  Some types of controls don’t support the height properties.  
  
     For information about each setting, see [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md).  
  
##  \<a name="specify">\</a> Show or Hide an Item  
  
1.  In the **Screen Content Tree**, choose the item (for example, a field or a command).  
  
2.  In the **Properties** window, select or clear the check box for the **Is Visible** property.  
  
    > [!NOTE]
    >  The label **(Not visible)** appears in the designer next to items that are not visible when the application runs.  
  
##  \<a name="change2">\</a> Change the Control Type of an Item  
  
1.  In the **Screen Content Tree**, open the list next to the item, and then choose the control type that you want.  
  
     Most control types are built in. You can also set the control type to a custom control that you create by using other tools. For more information, see [How to: Add a Custom Control to an HTML Screen](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md).  
  
##  \<a name="custom">\</a> Add a Custom Control to a Screen  
  
1.  In the **Screen Content Tree**, choose any group.  
  
2.  On the **Screen Designer** toolbar, open the **Add Layout Item** list, and then choose **Custom Control**.  
  
     For more information, see [How to: Add a Custom Control to an HTML Screen](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md).  
  
##  \<a name="reverse">\</a> Undo Changes  
  
-   On the menu bar, choose **Edit**, **Undo**.  
  
    > [!TIP]
    >  If you accidentally undo an edit in the **Screen Designer**, on the menu bar, choose **Edit**, **Redo**.  
  
##  \<a name="paging">\</a> Enable or Disable Paging  
  
1.  In the **Screen Members List** of the **Screen Designer**, choose the parent node of a collection (for example, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> heading).  
  
2.  In the **Properties** window, clear the **Support paging** check box if you want to display all rows that a query returns, even if the collection of rows is large. Select the check box if you want to limit the number of records that appear, and then specify the number of items to display on each page.  
  
    > [!NOTE]
    >  Users can display each page of results by choosing a link in the screen.  
  
## See Also  
 [How to: Control Navigation between HTML Screens](../vs140/how-to--control-navigation-between-html-screens-in-a-lightswitch-app.md)   
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)   
 [How to: Add a Custom Command to an HTML Screen](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md)   
 [How to: Add a Custom Control to an HTML Screen](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md)   
 [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md)