---
title: "How to: Add a Local Property to an HTML Screen"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b43cb39f-2e03-40f9-b97e-be67c6ca451e
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Add a Local Property to an HTML Screen
You can collect an input value or display a calculated value by adding a local property field to a screen in an HTML client for a LightSwitch app.  
  
### To create a local property  
  
1.  On the **Screen Designer** toolbar, choose the **Add Data Item** button.  
  
     The **Add Data Item** dialog box appears.  
  
2.  In the **Add Data Item** dialog box, choose the **Local Property** option button.  
  
3.  In the **Type** list, choose a type for the local property.  
  
     You can choose any of the standard types, such as **String**, **Integer**, **Email Address**, or any entity that’s associated with your application, such as **Customer**, **Order Detail**, or **Product**.  
  
4.  Select the **Is Required** check box if you want to require this field to contain a value.  
  
    > [!NOTE]
    >  If this field doesn’t contain a value when the user tries to open the screen, a validation message appears.  
  
5.  In the **Name** text box, enter a name for the property, and then choose the **OK** button.  
  
     The local property appears in the **Screen Members List**.  
  
### To add a local property to a screen  
  
1.  In the **Screen Members List**, drag the local property onto the appropriate location in the **Screen Content Tree**.  
  
2.  In the **Screen Content Tree**, in the list that appears next to the local property, choose the appropriate display type.  
  
     For example, if you are creating a local property to display an email address, you can change its display type to **Email Address Editor** or **Email Address Viewer**. You can also display a string local property as either a **Text Box**, a **Text Area**, or a **Label**.  
  
### To apply validation rules to a local property  
  
1.  In the **Screen Members List**, choose the local property.  
  
2.  In the **Properties** window, expand the **Validation** node if it is not already expanded.  
  
     The available validation rules will vary depending on the type of the local property.  
  
3.  If the local property must have a value, select the **Is Required** check box.  
  
     Choose any other validation rules that you want to apply to the local property. For example, for a string you might set a **Maximum Length** property.  
  
4.  To perform more complex validation, choose **Custom Validation**.  
  
     The Code Editor appears. [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] generates a method that’s named *localPropertyName*_Validate and to which you can add custom validation logic.  
  
## See Also  
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)