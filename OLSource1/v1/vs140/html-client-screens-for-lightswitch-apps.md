---
title: "HTML Client Screens for LightSwitch Apps"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 562bf54a-e522-4a00-9771-87d075ed355e
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HTML Client Screens for LightSwitch Apps
By using LightSwitch, you can create HTML client screens that are optimized for display on mobile devices. This topic introduces the templates that you can use to create screens that are based on HTML5, the tools that you can use to design screens, and some of the tasks that you can perform to design the best screens for your LightSwitch application.  
  
 For an end-to-end example of a client that utilizes HTML screens, see [Walkthrough: Creating the MoveIt Mobile Application](../vs140/walkthrough--creating-a-lightswitch-client-for-mobile-users.md).  
  
## HTML Clients  
 You can add one or more HTML clients to an existing LightSwitch application, or you can create a LightSwitch application that contains only an HTML client. Each HTML client is contained in its own project within the LightSwitch solution.  
  
## Screen Templates  
 To get started, create a screen by using one of the following screen templates:  
  
-   Common Screen Set  
  
-   Browse Screen  
  
-   View Details Screen  
  
-   Add/Edit Details Screen  
  
 For information about how to choose a template, see [Choosing an HTML Client Screen Type](../vs140/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md).  
  
 For information about how to find these templates, see [How to: Create an HTML Client Screen](../vs140/how-to--create-an-html-client-screen.md).  
  
## Screen Designer  
 You can modify the design of a screen by using the screen designer. The screen designer displays items such as data fields and commands, and the screen content tree, which is a hierarchical representation of your data. You can drag items to the screen content tree and arrange them in the order you want.  
  
 For more information about the screen designer, see [Tour of the Screen Designer](../vs140/tour-of-the-screen-designer.md).  
  
 For more information about how to perform specific tasks in the screen designer, see [How to: Design an HTML Screen by Using the Screen Designer](../vs140/how-to--design-an-html-screen-by-using-the-screen-designer.md).  
  
## Screen Design Tasks  
 To modify the design of a screen, you can perform the following tasks:  
  
-   Modify the appearance of a screen  
  
-   Add fields and commands to a screen  
  
-   Filter the data that appears in a screen  
  
-   Add data to a screen  
  
-   Customize navigation between screens  
  
-   Modify a screen by using code  
  
### Modify the Appearance of a Screen  
 You can modify how data appears in a screen. For example, you can configure a collection of information to appear as a flat list or a tiled list. You can change the order in which fields appear or group fields together.  
  
 For more information, see [How to: Design an HTML Screen by Using the Screen Designer](../vs140/how-to--design-an-html-screen-by-using-the-screen-designer.md).  
  
### Add Fields and Commands to a Screen  
 HTML screens in LightSwitch provide built-in commands so that users can view, update, delete, or save data. You can also add custom commands and fields.  
  
 Add a custom command if you want to add business logic to the screen. For example, you can add a button so that a user can display a list of customers based on sales-order volume. For more information, see [How to: Add a Custom Command to an HTML Screen](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md).  
  
 You can add custom local properties fields to collect or display information. For example, you can add a text box next to the sales-volume button so that the user can specify how many customers they want to appear in the list. For more information, see [How to: Add a Local Property to an HTML Screen](../vs140/how-to--add-a-local-property-to-an-html-screen.md).  
  
### Add Custom Controls to a Screen  
 By adding custom controls to an HTML screen, you can display or collect information in ways that go beyond the capabilities of the controls that are built in to LightSwitch. You can also use a custom control to replace any built-in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] control that appears on the screen. For more information, see [How to: Add a Custom Control to an HTML Screen](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md).  
  
### Filter the Data that Appears in a Screen  
 You can filter the data that appears in a screen by modifying the conditions of screen queries.  
  
 Every group of data that appears in the left pane of the designer is based on a query. The screen displays only the information that is returned by those queries. To change the information that appears for a group of data, modify its query.  
  
 For more information, see [How to: Filter Data on an HTML Screen](../vs140/how-to--filter-data-in-an-html-client-for-a-lightswitch-app.md).  
  
### Add Data to a Screen  
 You can add other kinds of data to a screen. For example, in a screen that displays customers, you can add a data grid that shows a list of orders. For more information, see [How to: Add Data to a Screen](../vs140/how-to--add-data-to-a-screen.md).  
  
### Customize Navigation between Screens  
 In an HTML client, only one screen is active at any time. You can specify how the user opens one screen from another and what happens when a screen becomes inactive.  
  
 For more information, see [How to: Control Navigation between HTML Screens](../vs140/how-to--control-navigation-between-html-screens-in-a-lightswitch-app.md).  
  
### Modify a Screen by Using Code  
 You can add code to partial methods that [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] calls so that, when certain events occur at run time, the screen is modified appropriately. For example, you can add code that hides the name of a company that wants to remain anonymous to the users of your application. This code would examine the company names of customers and, when it finds a match, would set the `IsVisible` property of the `CompanyName` field to `False` before the information appears in the screen.  
  
 For more information about where to write your code, see [How to: Handle Screen Events in a Mobile Client for a LightSwitch App](../vs140/how-to--handle-screen-events-in-a-mobile-client-for-a-lightswitch-app.md).  
  
 For more information about how to add code that modifies a screen, see [How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md).  
  
 For a listing of LightSwitch HTML Client APIs, see [HTML Client API Reference](../vs140/html-client-api-reference.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Choosing an HTML Client Screen Type](../vs140/choosing-a-screen-type-for-an-html-client-of-a-lightswitch-app.md)|Describes templates that you can use as a starting point to create screens.|  
|[How to: Create an HTML Client Screen](../vs140/how-to--create-an-html-client-screen.md)|Shows how to add screens to your application.|  
|[Tour of the Screen Designer](../vs140/tour-of-the-screen-designer.md)|Illustrates the parts of the designer and their functions.|  
|[How to: Design an HTML Screen by Using the Screen Designer](../vs140/how-to--design-an-html-screen-by-using-the-screen-designer.md)|Shows how to use the screen designer.|  
|[How to: Add a Local Property to an HTML Screen](../vs140/how-to--add-a-local-property-to-an-html-screen.md)|Shows how to add a custom local property field to a screen.|  
|[How to: Add a Custom Command to an HTML Screen](../vs140/how-to--add-a-button-to-a-mobile-client-for-lightswitch.md)|Shows how to add a button or a link that runs custom code in a screen.|  
|[How to: Add a Custom Control to an HTML Screen](../vs140/how-to--add-a-custom-control-to-an-html-screen-for-a-lightswitch-app.md)|Shows how to use a custom HTML control in a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] screen.|  
|[How to: Add Data to a Screen](../vs140/how-to--add-data-to-a-screen.md)|Shows how to add data from other queries to a screen.|  
|How to: Filter Data on an HTML Screen|Shows how to use queries to control which data appears in the screen.|  
|[How to: Handle Screen Events in a Mobile Client for a LightSwitch App](../vs140/how-to--handle-screen-events-in-a-mobile-client-for-a-lightswitch-app.md)|Describes how to customize your application by writing code that runs when certain events happen.|  
|[How to: Modify an HTML Screen by Using Code](../vs140/how-to--modify-an-html-screen-by-using-code.md)|Describes how to use code to modify controls and interact with items on a screen.|  
|[Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md)|Describes the properties of items that appear in the screen members list and the screen content tree of the screen designer. You can modify the appearance and behavior of items by using the **Properties** window to set the value of the properties.|  
|[How to: Control Navigation between HTML Screens](../vs140/how-to--control-navigation-between-html-screens-in-a-lightswitch-app.md)|Describes the screen navigation model for an HTML client of a LightSwitch application.|