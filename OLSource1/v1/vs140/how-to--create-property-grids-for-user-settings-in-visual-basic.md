---
title: "How to: Create Property Grids for User Settings in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Settings object, creating property grids for user settings"
  - "user settings, creating property grids"
  - "property grids, creating for user settings"
  - "property grids"
ms.assetid: b0bc737e-50d1-43d1-a6df-268db6e6f91c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create Property Grids for User Settings in Visual Basic
You can create a property grid for user settings by populating a \<xref:System.Windows.Forms.PropertyGrid*> control with the user setting properties of the `My.Settings` object.  
  
> [!NOTE]
>  In order for this example to work, your application must have its user settings configured. For more information, see [Managing Application Settings](../vs140/managing-application-settings--.net-.md).  
  
 The `My.Settings` object exposes each setting as a property. The property name is the same as the setting name, and the property type is the same as the setting type. The setting's **Scope** determines if the property is read-only; the property for an **Application**-scope setting is read-only, while the property for a **User**-scope setting is read-write. For more information, see [My.Settings Object](../vs140/my.settings-object.md).  
  
> [!NOTE]
>  You cannot change or save the values of application-scope settings at run time. Application-scope settings can be changed only when creating the application (through the **Project Designer**) or by editing the application's configuration file. For more information, see [Managing Application Settings](../vs140/managing-application-settings--.net-.md).  
  
 This example uses a \<xref:System.Windows.Forms.PropertyGrid*> control to access the user-setting properties of the `My.Settings` object. By default, the \<xref:System.Windows.Forms.PropertyGrid*> shows all the properties of the `My.Settings` object. However, the user-setting properties have the \<xref:System.Configuration.UserScopedSettingAttribute*> attribute. This example sets the \<xref:System.Windows.Forms.PropertyGrid.BrowsableAttributes*> property of the \<xref:System.Windows.Forms.PropertyGrid*> to \<xref:System.Configuration.UserScopedSettingAttribute*> to display only the user-setting properties.  
  
### To add a user setting property grid  
  
1.  Add the **PropertyGrid** control from the **Toolbox** to the design surface for your application, assumed here to be `Form1`.  
  
     The default name of the property-grid control is `PropertyGrid1`.  
  
2.  Double-click the design surface for `Form1` to open the code for the form-load event handler.  
  
3.  Set the `My.Settings` object as the selected object for the property grid.  
  
     [!code[VbVbalrMyResources#11](../vs140/codesnippet/VisualBasic/how-to--create-property-grids-for-user-settings-in-visual-basic_1.vb)]  
  
4.  Configure the property grid to show only the user settings.  
  
     [!code[VbVbalrMyResources#12](../vs140/codesnippet/VisualBasic/how-to--create-property-grids-for-user-settings-in-visual-basic_2.vb)]  
  
    > [!NOTE]
    >  To show only the application-scope settings, use the \<xref:System.Configuration.ApplicationScopedSettingAttribute*> attribute instead of  \<xref:System.Configuration.UserScopedSettingAttribute*>.  
  
## Robust Programming  
 The application saves the user settings when the application shuts down. To save the settings immediately, call the `My.Settings.Save` method. For more information, see [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md).  
  
## See Also  
 [My.Settings Object](../vs140/my.settings-object.md)   
 [How to: Read Application Settings in Visual Basic](../vs140/how-to--read-application-settings-in-visual-basic.md)   
 [How to: Change User Settings in Visual Basic](../vs140/how-to--change-user-settings-in-visual-basic.md)   
 [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md)   
 [Managing Application Settings](../vs140/managing-application-settings--.net-.md)