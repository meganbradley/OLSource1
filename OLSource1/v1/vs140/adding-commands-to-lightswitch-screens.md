---
title: "Adding Commands to LightSwitch Screens"
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
  - "Visual Studio LightSwitch, adding a button"
ms.assetid: 15e024b7-fbf8-406f-9c23-df8ec4dade49
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Adding Commands to LightSwitch Screens
This lesson shows how to add commands to LightSwitch screens.  
  
## Adding Commands  
 Commands appear on a screen’s toolbar and perform a task when a user chooses them. In most cases a command will run custom code from a method that you write, but it can also run code from an existing method.  
  
#### To add a command to a screen  
  
1.  In **Solution Explorer**, open the shortcut menu for the **CurrentProductList.lsml** node, and then choose **Open**.  
  
2.  In the **Screen Designer**, expand the **Command Bar** node under the **Rows Layout &#124; Related Products** node.  
  
3.  In the **Add** list, choose **New Button**.  
  
4.  In the **Add Button** dialog box, choose the **Write my own method** option button, name the button `ProductCount`, and then choose the **OK** button.  
  
5.  In the left pane, choose the **ProductCount** node.  
  
6.  In the **Properties** window, choose the **Edit Execute Code** link.  
  
     The **Code Editor** opens and displays the `ProductCount_execute()` method.  
  
7.  In the `ProductCount_execute()` method, add the following code.  
  
    ```javascript  
    myapp.CurrentProductList.ProductCount_execute = function (screen) {  
        var categoryCount;  
        categoryCount = screen.ProductsByCategory.data.length;  
        msls.showMessageBox("There are " + categoryCount + " related products.");  
    };  
    ```  
  
     This code displays a message box when a user chooses the button that you just created.  
  
8.  Run the application. Open the **Current Product List** screen, choose the **Related Products** tab, and then choose the **Product Count** button.  
  
     The **Category Count** message box should display the message “There are 0 related products.”.  
  
9. Choose the **OK** button, choose the **Product List** tab, and then choose a product.  
  
10. Choose the **Related Products** tab and then choose the **Product Count** button.  
  
     The message box should display the correct number of related items.  
  
11. Close the application to return to design mode.  
  
#### To add a command for an existing method  
  
1.  In the **Screen Designer** for the **CurrentProductList.lsml** screen, open the shortcut menu for the **Popups** node, and then choose **Add Popup**.  
  
2.  Open the **Add** list, and then choose **– Selected Item** under **Current Products**.  
  
3.  Open the shortcut menu for the **Command Bar** node, and then choose **Add Button**.  
  
4.  In the **Add Button** dialog box, accept the default choices of **Choose an existing method**, **showPopup**, and **Popup: Group**, and then choose the **OK** button.  
  
5.  In the **Properties** window, choose the **Display Name** property, and then enter `View Details`.  
  
6.  Open the list for the **Icon** property, and then choose **Question**.  
  
7.  Run the application and open the **Current Product List** screen.  
  
     Notice that the toolbar contains a **View Details** button with a question icon.  
  
8.  Choose a product, and then choose the **View Details** button.  
  
     A popup is displayed with details for the product you selected.  
  
## Closer Look  
 This lesson showed how to add a command to the **CurrentProductList** screen and add code that runs every time a user chooses the command button. The code executes the `showMessageBox` method, which displays a message box with the count of products in the selected category.  
  
 You also added a command that executes the existing `showPopup` method to display a popup, and you changed the display name and icon for the button.  
  
 There are many other uses for commands; for example, navigating to another screen, collecting user input, or even sending email.  
  
## Next Steps  
 In the next lesson, you’ll learn how to modify menus.  
  
 Next lesson: [Working with Menus in a LightSwitch Application](../vs140/working-with-menus-in-a-lightswitch-application.md)  
  
## See Also  
 [Creating Menus and Commands](../vs140/creating-commands-and-working-with-menus-in-lightswitch.md)   
 [How to: Add a Button to a Mobile Client for LightSwitch](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md)