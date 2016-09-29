---
title: "How to: Create Menu Items and Navigation Groups in LightSwitch"
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
  - "menu items [Visual Studio LightSwitch]"
  - "menus [Visual Studio LightSwitch]"
  - "menu groups [Visual Studio LightSwitch]"
  - "navigation menu [Visual Studio LightSwitch]"
  - "startup screen [Visual Studio LightSwitch]"
ms.assetid: 6899fa60-2cfd-4102-a0be-45ff1d1db4a0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create Menu Items and Navigation Groups in LightSwitch
Menus and navigation groups in a LightSwitch client application that runs on a desktop appear on the **Navigation Menu** at run time. You manage menus and navigation groups on the **Screen Navigation** tab of the **DesktopClient Designer**.  
  
 Menu items are automatically added to the **Navigation Menu** for most screens that you create. Some screen types, such as the **Details Screen**, do not appear in the menu; they can be opened only by using a **Command** that calls the `Application.Show`*ScreenName* method. Menu items can be renamed. Renaming a menu item does not change the name or display name of the screen.  
  
 By default all menu items appear in a single **Tasks** group. You can rename the group, and you can create additional navigation groups and move menu items among them. You can also change the order of navigation groups. You can remove menu items that you do not want to display, and you can add a menu item to multiple navigation groups.  
  
 You can also specify the **Startup Screen** on the **Screen Navigation** tab. This is the screen that appears when the application starts; the menu item for the **Startup Screen** appears in bold text on the **Navigation Menu**.  
  
### To add a menu item  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the  **Navigation menu structure** list, choose the navigation group node to which you want to add the menu item.  
  
4.  Open the **Include Screen** list, and then choose the menu item that you want to add.  
  
     The menu item is added to the bottom of the selected navigation group in the navigation menu.  
  
### To remove a menu item  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the  **Navigation menu structure** list, open the shortcut menu for the menu item, and then choose **Delete**.  
  
     The menu item is removed from the navigation menu.  
  
### To rename a menu item  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, open the shortcut menu for the menu item that you want to rename, and then choose **Rename**.  
  
     The name field becomes editable.  
  
4.  Enter the new name for the menu item, and then choose the Enter key.  
  
### To reorder menu items  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, choose the menu item node that you want to move.  
  
4.  In the right margin of the designer, choose the **Move Up** or **Move Down** button.  
  
    > [!NOTE]
    >  You can’t move a menu item between navigation groups. You must remove it from one group and then add it to another.  
  
### To add a navigation group  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the  **Navigation menu structure** list, choose the **Add Group** node.  
  
     A new navigation group named **Group** appears.  
  
4.  In the **Group** text box, enter a new name for the navigation group, and then choose the Enter key.  
  
### To remove a navigation group  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, open the shortcut menu for the navigation group node, and then choose **Delete**.  
  
     The navigation group and any menu items that it contains are removed from the navigation menu.  
  
### To rename a navigation group  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, open the shortcut menu for the navigation group that you want to rename, and then choose **Rename**.  
  
     The name field becomes editable.  
  
4.  Enter the new name for the navigation group, and then choose the Enter key.  
  
### To reorder navigation groups  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, choose the navigation group node that you want to move, and then choose the **Move Up** button or the **Move Down** button.  
  
### To change the startup screen  
  
1.  In **Solution Explorer**, choose the **Screens** node.  
  
2.  On the menu bar, choose **Project**, **Edit Screen Navigation**.  
  
     The **Screen Navigation** tab of the **DesktopClient Designer** opens.  
  
3.  In the **Navigation menu structure** list, choose the menu item that you want to use as a startup screen.  
  
4.  At the bottom of the **DesktopClient Designer**, choose the **Set** button.  
  
     The menu item appears in bold text, which signifies that it's now the startup screen.  
  
    > [!NOTE]
    >  If you don’t want a startup screen for your application, you can choose the **Clear** button. If you subsequently add a screen to the application, that screen will automatically become the startup screen, and you'll need to perform this step again.  
  
## See Also  
 [How to: Manage Project Settings](../VS_csharp/how-to--manage-application-settings-in-lightswitch.md)   
 [How to: Create a Custom Command](../VS_csharp/how-to--add-a-custom-command-to-a-silverlight-screen.md)   
 [How to: Manage Application Settings](../VS_csharp/how-to--manage-application-settings-in-lightswitch.md)