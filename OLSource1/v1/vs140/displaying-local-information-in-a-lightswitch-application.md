---
title: "Displaying Local Information in a LightSwitch Application"
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
  - "Visual Studio LightSwitch, advanced screen customizations"
ms.assetid: 65512aad-2073-4ac8-9c7c-a1d837772481
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Displaying Local Information in a LightSwitch Application
In this lesson, you’ll learn how to how to customize a screen in a LightSwitch application by adding a local property. A local property displays information that in’t in a data source.  
  
## Adding a Local Property  
 You can use the **Screen Designer** not only to customize the controls on a screen, but also to add data items. For example, you can add a local property that can display a calculated value.  
  
#### To add a local property  
  
1.  In **Solution Explorer**, open the shortcut menu for the **BrowseOrders.lsml** node, and then choose **Open**.  
  
2.  On the toolbar, choose the **Add Data Item** button.  
  
3.  In the **Add Data Item** dialog box, choose the **Local Property** option button. In the **Type** list, choose **Integer**, and then choose the **OK** button.  
  
     A new node named **Property1** is added to the left pane of the **Screen Designer**.  
  
     ![The local property Property1](../vs140/media/ls_tour27.PNG "LS_Tour27")  
  
4.  Choose the **Property1** node. In the Properties window, choose the **Name** property, and then enter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
     The name also changes in the left pane of the designer.  
  
5.  In the Screen Designer, drag the **NumberOfOrders** node just below the **Command Bar** node in the center pane.  
  
6.  Run the application and open the **Browse Orders** screen.  
  
     Notice that a **Number of Orders** label is now displayed below the screen name, and that no value is displayed.  
  
7.  Close the application and return to design mode.  
  
#### To display a value for a local property  
  
1.  In the left pane of the **Screen Designer**, choose the **Orders** node.  
  
2.  On the **ToolBar Ribbon**, in the **Write Code** list, choose **created**.  
  
     The **Code Editor** opens and displays the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method.  
  
3.  In the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, add the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     When the screen is created, this code calculates the number of orders in the **Orders** entity. That value is then displayed in the **Number of Orders** field.  
  
4.  Run the application and open the **Browse Orders** screen.  
  
     Notice that the number of orders appears in the **Number of Orders** field.  
  
5.  Close the application and return to design mode.  
  
## Closer Look  
 This lesson showed how to create a local property to display a calculated value on a screen. In this case, you used the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method of the orders collection to return the total number of orders in the **Orders** entity. The code uses a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to make sure that the data is loaded before returning the value of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> property.  
  
 In addition to using a local property to display a calculated value, you can also use a local property to collect an input value from the user. For example, you could create a local property that displays a list of cities when a user specifies a geographical region.  
  
## Next Steps  
 In the next set of lessons you’ll learn how to create and use queries to control what is displayed on a screen.  
  
 Next lesson: [Filtering Data with Queries](../vs140/filtering-data-with-queries-in-lightswitch.md)  
  
## See Also  
 [Creating Screens](../vs140/creating-screens-in-lightswitch.md)   
 [How to: Add a Local Property to an HTML Screen](../vs140/how-to--add-a-local-property-to-an-html-screen.md)