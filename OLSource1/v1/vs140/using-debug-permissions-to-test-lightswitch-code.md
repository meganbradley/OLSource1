---
title: "Using Debug Permissions to Test LightSwitch Code"
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
  - "Visual Studio LightSwitch, debug permissions"
  - "Visual Studio LightSwitch, testing permissions"
ms.assetid: 835feab2-f3fa-42e8-990b-a29c059692bc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Debug Permissions to Test LightSwitch Code
In this lesson, you’ll learn how to test your permissions code by using debug permissions. By using debug permissions, you can simulate the experience of end users, based on their roles and permissions.  
  
## Using Debug Permissions  
 In the previous lesson, you wrote code that determined permissions for viewing the **Products** screen. The administrator of the application assigns permissions to roles. To test your code, you’ll want to run the application both as a user who has the permission and as a user who doesn't.  You can do that by setting debug permissions.  
  
#### To set debug permissions  
  
1.  In **Solution Explorer**, open the shortcut menu for the **My First Application** node, and then choose **Properties**.  
  
2.  In the **My First Application Properties** window, choose the **Access Control** tab.  
  
3.  In the **Define permissions or select permissions to use for debugging** grid, choose the **Can_View_Products** permission, and then select the **Granted for debug** check box.  
  
4.  Run the application.  
  
     On the **Home** screen, the **Products** button is enabled and you can view the **Current Product List** screen.  
  
5.  Close the application and return to design mode.  
  
6.  Choose the **Can_View_Products** permission, and then clear the **Granted for debug** check box.  
  
7.  Run the application again.  
  
     The **Products** menu is disabled because you're running the application without the necessary **Can_View_Products** permission.  
  
## Closer Look  
 In this lesson, you learned how to set debug permissions and test your application. Debug permissions let you run the application and simulate what an end user will see, based on their role and permissions. Without this capability, you would have to create various user identities, close the application, and then log back on by using a different identity.  
  
 In this example, you defined only one permission, but many applications require multiple permissions for multiple purposes. You can identify multiple debug permissions to test different combinations and make sure that your application works as you intended.  
  
## Next Steps  
 This completes the LightSwitch guided tour. Next, you’ll learn about additional steps that you might take when developing a LightSwitch application.  
  
 Next lesson: [Next Steps - LightSwitch Guided Tour](../vs140/next-steps---lightswitch-guided-tour.md)  
  
## See Also  
 [Creating Roles and Permissions](../vs140/enabling-authorization-and-creating-permissions-in-lightswitch.md)   
 [How to: Enable Authentication in an HTML Client App](../vs140/how-to--enable-authentication-in-an-html-client-app.md)