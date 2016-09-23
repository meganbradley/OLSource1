---
title: "How to: Add a Custom Control to a Silverlight Screen"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - screens [Visual Studio LightSwitch], custom controls
  - screen [Visual Studio LightSwitch], SilverLight controls
ms.assetid: 1f347da3-90b3-47ef-ad18-8d91c19fb01a
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Add a Custom Control to a Silverlight Screen
You can add Silverlight controls to a [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] screen. By using Silverlight controls, you can display or collect information in ways that go beyond the capabilities of the built-in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] controls.  
  
 You can use controls that are included in the Silverlight runtime and the Silverlight SDK. You can also use controls that you create by using Silverlight project templates, for example, those that are available in Visual Studio 2010. Both kinds of controls are referred to as *custom controls* in [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)].  
  
 For information about how to create custom controls by using Silverlight project templates in Visual Studio, see [Control Basics (Silverlight QuickStart)](http://go.microsoft.com/fwlink/?LinkID=207110).  
  
## Adding New Controls and Replacing Existing Controls  
 You can add a custom control to a screen, either as a new control or as a replacement for an existing [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] control.  
  
#### To add a custom control to a screen  
  
1.  In the **Screen Content Tree**, select any group.  
  
2.  At the top of the **Screen Designer**, click **Add Layout Item** and then click **Custom Control**.  
  
3.  In the **Add Custom Control** dialog box, expand the assembly node, expand the namespace node, and then select the control node.  
  
     If the assembly that you want does not appear in the **Add Custom Control** dialog box, click **Add Reference**. In the **Add Reference** dialog box, select an assembly or local project that contains the control that you want to use, and then click **OK**.  
  
    > [!NOTE]
    >  If you created this control by using Silverlight project templates in Visual Studio, and you bound the control to data by modifying the XAML of the control, you do not have to perform the next step. For more information about how to bind a custom control to data by modifying the XAML of the control, see [Using Custom Controls to Enhance Your LightSwitch Application UI](http://go.microsoft.com/fwlink/?LinkID=208837). If the custom control is a built-in Silverlight control, or if you created this control by using Silverlight Project templates in Visual Studio, but you want to bind the control to data by using [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)], proceed to the next step.  
  
4.  In the **Specify the data for the new custom control** field, type the name of the screen data that you want to bind to the control, and then click **OK**.  
  
     For example, if you want a custom list box to show names from a collection named CustomerSet, type **CustomerSet**. If you want the control to show the name of the currently selected customer, type **CustomerSet.SelectedItem.ContactName**.  
  
5.  Add code that binds the data to a specific property of the control. For more information, see [Binding Data to a Property of the Custom Control](#LSBinding) later in this document.  
  
#### To use a custom control to replace an existing control  
  
1.  In the **Screen Content Tree**, in the drop-down list next to the control you want to replace, select **Custom Control**.  
  
2.  In the **Properties** window, next to the **Custom Control** field, click **Change**  
  
3.  In the **Add Custom Control** dialog box, expand the assembly node, expand the namespace node, select the control node, and then click **OK**.  
  
     If the assembly that contains the control does not appear in the **Add Custom Control** dialog box, click **Add Reference**. In the **Add Reference** dialog box, select an assembly or local project that contains the control that you want to use, and then click **OK**.  
  
4.  Add code that binds the data to a specific property of the control. For more information, see [Binding Data to a Property of the Custom Control](#LSBinding) later in this document.  
  
##  <a name="LSBinding"></a> Binding Data to a Property of the Custom Control  
 You must bind the data that you specified in the **Add Custom Control** dialog box to a specific property of the custom control.  
  
#### To bind data to a property of the custom control  
  
1.  In the **Screen Designer**, click the arrow next to the **Write Code** button and then click any method.  
  
    > [!NOTE]
    >  Choose a method that is executed before you want data to appear in the control at run time, for example, `CustomerListDetail_Activated`.  
  
     A method block appears in the Code Editor.  
  
2.  In the method block, add code that binds the screen data to a property of the custom control.  
  
     The following example references a custom list box control named `Customers`. This code binds a data collection that was specified in the **Add Custom Control** dialog box to a specific property of the list box. This code also specifies that data can be modified by using this control.  
  
     [!code[LS_Screens#6](../vs140/codesnippet/CSharp/how-to--add-a-custom-control-to-a-silverlight-screen_1.cs)]
[!code[LS_Screens#6](../vs140/codesnippet/VisualBasic/how-to--add-a-custom-control-to-a-silverlight-screen_1.vb)]
  
  
## See Also  
 [Screens: The User Interface of Your Application](../vs140/how-to--add-a-custom-control-to-a-silverlight-screen.md)   
 [Tour of the Screen Designer](../vs140/tour-of-the-screen-designer.md)   
 [How to: Design a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md)   
 [How to: Add Data to a Screen](../vs140/how-to--add-data-to-a-screen.md)   
 [How to: Add a Local Property to a Screen](../vs140/how-to--add-a-local-property-to-a-silverlight-screen.md)   
 [How to: Add a Custom Command to a Screen](../vs140/how-to--add-a-custom-command-to-a-silverlight-screen.md)