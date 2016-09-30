---
title: "Restricting Access to a LightSwitch Screen"
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
  - "Visual Studio LightSwitch, permissions"
  - "Visual Studio LightSwitch, restricting screen access"
ms.assetid: f5845ce3-5113-46b6-9b93-54ef84d0ec08
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Restricting Access to a LightSwitch Screen
In this lesson, you’ll learn how to apply a permission to restrict access to a screen in a LightSwitch application.  
  
## Restricting Access  
 In the previous lesson, you created a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> permission, which is an object. You can reference the object in the code that you write to check permissions for an entity or query. If the permission isn’t assigned to the current user, a JavaScript function is used to disable access to the screen at run time.  
  
#### To write code to set permissions for a query  
  
1.  In **Solution Explorer**, open the shortcut menu for the **CurrentProducts.lsml** node, and then choose **Open**.  
  
2.  On the toolbar, open the **Write Code** list, and then choose **CurrentProducts_CanExecute**.  
  
     The **Code Editor** opens and displays the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.  
  
3.  In the **Code Editor**, enter the following code in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### To write code to set permissions for a screen  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Home.lsml** node, and then choose **Open**.  
  
2.  In the **Screen Designer**, on the toolbar, choose the **Add Data Item** button.  
  
3.  In the **Add Data Item** dialog box, choose the **Query** option button. In the list, choose **NorthwindEntitiesData.CurrentProducts**, and then choose the **OK** button.  
  
4.  On the toolbar, open the **Write Code** list, and then choose **created**.  
  
5.  In the **Code Editor**, add the following code to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  In **Solution Explorer**, open the shortcut menu for the **Screens** node, and then choose **Edit Screen Navigation**.  
  
7.  Open the shortcut menu for the **Products** node, and then choose **Delete**.  
  
8.  Run the application. Notice that the **Products** button is disabled. This is because the Test User account doesn’t have the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> permission. You’ll learn how to grant permission in the next lesson.  
  
## Closer Look  
 In this lesson, you learned how to apply a permission to restrict access to a screen. For HTML client screens, this is a two-part process: setting permissions to run a query on the server, and then checking for permission from the client.  
  
 Every query has a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method that can be used to check for permissions. In this case, the code runs the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method, and checks to see whether the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> permission is assigned to the current user. If it is, the method returns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>; if not, the method returns a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 On the client, the JavaScript code tries to run the query. If the user has permission and the query is successful, the **Products** button on the screen is enabled; if the query fails, the button is disabled.  
  
> [!NOTE]
>  In this example you deleted the **Products** menu item to prevent the user from launching the **Products** screen from the menu. It’s also possible to disable menu items dynamically, but the process is much more involved. See [Using LightSwitch ServerApplicationContext and WebAPI to Get User Permissions](http://blogs.msdn.com/b/bethmassi/archive/2013/04/17/using-lightswitch-serverapplicationcontext-and-webapi-to-get-user-permissions.aspx).  
  
 This is just one example of the code that you could write to check for permissions and restrict access. On the server, you can use any of the entity <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> methods such as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to check for permissions. On the client, you can apply permissions to specific screen elements, and you can use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method to hide an element instead of disabling it.  
  
## Next Steps  
 In the next lesson, you’ll learn how to use debug permissions to test code.  
  
 Next lesson: [Using Debug Permissions to Test Code](../vs140/using-debug-permissions-to-test-lightswitch-code.md)  
  
## See Also  
 [Creating Roles and Permissions](../vs140/enabling-authorization-and-creating-permissions-in-lightswitch.md)   
 [How to: Enable Authentication in an HTML Client App](../vs140/how-to--enable-authentication-in-an-html-client-app.md)