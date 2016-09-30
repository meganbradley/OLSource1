---
title: "How to: Add a Local Property to a Silverlight Screen"
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
  - "screens [Visual Studio LightSwitch], fields"
  - "screens [Visual Studio LightSwitch], properties"
  - "screens [Visual Studio LightSwitch], controls"
ms.assetid: 364df3cf-b49e-41be-97e0-492f2a952bca
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Local Property to a Silverlight Screen
You can add a field called a *local property* to a screen. You can use a local property to collect an input value or to display a calculated value.  
  
### To create a local property  
  
1.  From the top of the **Screen Designer**, click **Add Data Item…**.  
  
     The **Add Data Item** dialog box appears.  
  
2.  In the **Add Data Item** dialog box, select **Local Property**.  
  
3.  In the **Type** drop-down list choose a type for the local property.  
  
     You can select any of the standard types, such as **String**, **Integer**, **Email Address**, or any of the entities that are associated with your application, such as **Customer**, **Order Detail**, or **Product**.  
  
4.  Select **Is Required** if you want to require this field to contain a value.  
  
    > [!NOTE]
    >  If this field does not contain a value when the user attempts to open the screen, a validation message appears.  
  
5.  In the **Name** textbox, type a name, and then click **OK**.  
  
     The **Add Data Item** dialog box will close. The local property appears in the **Screen Members List**.  
  
### To add a local property to a screen  
  
1.  From the **Screen Members List**, drag the local property onto the desired location of the **Screen Content Tree**.  
  
2.  In the **Screen Content Tree**, in the drop-down list that appears next to the local property, select the desired display type.  
  
     For example, if you are creating a local property to display a monetary value, you can change its display type to **Money Editor** or **Money Viewer**. Likewise, you can display a string local property as either a **Text Box** or a **Label**.  
  
### To apply validation rules to a local property  
  
1.  In the **Screen Members List**, select the local property.  
  
2.  From the **Properties** window, expand the **Validation** node if it is not already expanded.  
  
     The available validation rules will vary depending on the type of the local property.  
  
3.  If the local property must have a value, select **Is Required**.  
  
     Select any other validation rules that you want to apply to the local property.  
  
4.  If you need to perform more complex validation, click **Custom Validation**.  
  
     The Code Editor appears. [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] generates a method named *localPropertyName*_Validate. You can add custom validation logic to this method. The following example displays an error message if the user enters less than three characters for a local property named `CityCode`.  
  
     [!code[LS_Screens#1](../vs140/codesnippet/CSharp/how-to--add-a-local-property-to-a-silverlight-screen_1.cs)]
[!code[LS_Screens#1](../vs140/codesnippet/VisualBasic/how-to--add-a-local-property-to-a-silverlight-screen_1.vb)]  
  
     If the string does not contain at least three characters, the property will be outlined in red and the error message you typed above appears.  
  
### To assign a value to a local property by using code  
  
1.  You can set a value to a local property by using code.  
  
     The following example sets the value of a local property named `ApprovedCheckBox` to `False`.  
  
     [!code[LS_Screens#2](../vs140/codesnippet/CSharp/how-to--add-a-local-property-to-a-silverlight-screen_2.cs)]
[!code[LS_Screens#2](../vs140/codesnippet/VisualBasic/how-to--add-a-local-property-to-a-silverlight-screen_2.vb)]  
  
## See Also  
 [Screens: What the User Sees](../vs140/screens--the-user-interface-of-your-lightswitch-application.md)   
 [How to: Add a Custom Command to a Screen](../vs140/how-to--add-a-custom-command-to-a-silverlight-screen.md)   
 [How to: Customize a Screen By Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md)