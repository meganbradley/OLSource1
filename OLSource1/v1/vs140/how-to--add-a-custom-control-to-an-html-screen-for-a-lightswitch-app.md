---
title: "How to: Add a Custom Control to an HTML Screen for a LightSwitch App"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 37b39203-d4d5-47c2-b668-025f25f7bbb0
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Custom Control to an HTML Screen for a LightSwitch App
You can add custom HTML controls to a screen in a client for a LightSwitch app. By using custom controls, you can display or collect information in ways that exceed the capabilities of the built-in HTML controls for LightSwitch.  
  
## Referencing Custom Controls  
 To use a custom control on a screen, you must first add a file reference to the project, and then you add a script tag to the default.htm file.  
  
#### To reference a custom control  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Scripts** folder, choose **Add**, and then choose **Existing Item**.  
  
2.  Choose the JavaScript (.js) file for the custom control, and then choose the **Add** button.  
  
    > [!NOTE]
    >  Some custom controls require that you also reference additional support files. Consult the documentation for the custom control for any requirements.  
  
3.  In the **<script\>** section of the **default.htm** file for your project, add a script tag that resembles the following example, where *MyControl* is the name of your custom control:  
  
    ```html  
    <script type=”text/javascript” src=”Scripts/MyControl.js” charset=”utf-8”></script>  
    ```  
  
## Adding New Controls and Replacing Existing Controls  
 You can add a new custom control to a screen or replace an existing HTML control in LightSwitch.  
  
#### To add a custom control to a screen  
  
1.  In the **Screen Content Tree**, choose any group.  
  
2.  On the **Screen Designer** toolbar, in the **Add Layout Item** list, choose **Custom Control**.  
  
     The **Add Custom Control** dialog box opens.  
  
3.  In the **Specify the data for the new custom control** text box, enter the item or collection to be bound to the control.  
  
     For example, enter `Customers.selectedItem.PostalCode` to bind to a customer’s postal code, or enter `Customers.selectedItem` to bind to the entire customer record.  
  
4.  Add code that binds the data to a specific property of the control.  
  
     For more information, see [Binding Data to a Property of the Custom Control](#LSBinding) later in this topic.  
  
#### To replace an existing control with a custom control  
  
1.  In the **Screen Content Tree**, choose the control that you want to replace.  
  
2.  In the **Properties** window, open the **Control Type** list, and then choose **Custom Control**.  
  
3.  Add code that binds the data to a specific property of the control.  
  
     For more information, see [Binding Data to a Property of the Custom Control](#LSBinding) later in this topic.  
  
##  <a name="LSBinding"></a> Binding Data to a Property of the Custom Control  
 You must bind the data that you specified in the **Add Custom Control** dialog box to a specific property of the custom control.  
  
#### To bind data to a property of the custom control  
  
1.  In the **Screen Content Tree**, choose the custom control.  
  
2.  In the **Properties** window, choose the **Edit Render Code** hyperlink.  
  
3.  In the code editor, add code that resembles the following example to the render method:  
  
    ```javascript  
    createMyControl(element, contentItem, “max-width: 300px; max-height: 300px”);  
    ```  
  
     This code renders the control at run time. Replace `MyControl` with the name of your control, and change the `max-height` and `max-width` parameters as necessary.  
  
4.  Add code for any additional functionality that the control requires. Consult the documentation for the custom control for any requirements.  
  
## See Also  
 [HTML Client Screens](../vs140/html-client-screens-for-lightswitch-apps.md)