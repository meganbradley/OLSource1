---
title: "My.Settings Object"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "My.MySettingsProperty.Settings"
  - "My.Settings"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "My.Settings object"
ms.assetid: 41f30dc1-202a-4273-b9b7-5728941f996c
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# My.Settings Object
Provides properties and methods for accessing the application's settings.  
  
## Remarks  
 The `My.Settings` object provides access to the application's settings and allows you to dynamically store and retrieve property settings and other information for your application. For more information, see [Managing Application Settings](../vs140/managing-application-settings--.net-.md).  
  
## Properties  
 The properties of the `My.Settings` object provide access to your application's settings. To add or remove settings, use the **Settings Designer**.  
  
 Each setting has a **Name**, **Type**, **Scope**, and **Value**, and these settings determine how the property to access each setting appears in the `My.Settings` object:  
  
-   **Name** determines the name of the property.  
  
-   **Type** determines the type of the property.  
  
-   **Scope** indicates if the property is read-only. If the value is **Application**, the property is read-only; if the value is **User**, the property is read-write.  
  
-   **Value** is the default value of the property.  
  
## Methods  
  
|||  
|-|-|  
|Method|Description|  
|`Reload`|Reloads the user settings from the last saved values.|  
|`Save`|Saves the current user settings.|  
  
 The `My.Settings` object also provides advanced properties and methods, inherited from the <xref:System.Configuration.ApplicationSettingsBase*> class.  
  
## Tasks  
 The following table lists examples of tasks involving the `My.Settings` object.  
  
|||  
|-|-|  
|To|See|  
|Read an application setting|[How to: Read Application Settings in Visual Basic](../vs140/how-to--read-application-settings-in-visual-basic.md)|  
|Change a user setting|[How to: Change User Settings in Visual Basic](../vs140/how-to--change-user-settings-in-visual-basic.md)|  
|Persist user settings|[How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md)|  
|Create a property grid for user settings|[How to: Create Property Grids for User Settings in Visual Basic](../vs140/how-to--create-property-grids-for-user-settings-in-visual-basic.md)|  
  
## Example  
 This example displays the value of the `Nickname` setting.  
  
 [!code[VbVbalrMyResources#14](../vs140/codesnippet/VisualBasic/my.settings-object_1.vb)]  
  
 For this example to work, your application must have a `Nickname` setting, of type `String`.  
  
## See Also  
 <xref:System.Configuration.ApplicationSettingsBase*>   
 [How to: Read Application Settings in Visual Basic](../vs140/how-to--read-application-settings-in-visual-basic.md)   
 [How to: Change User Settings in Visual Basic](../vs140/how-to--change-user-settings-in-visual-basic.md)   
 [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md)   
 [How to: Create Property Grids for User Settings in Visual Basic](../vs140/how-to--create-property-grids-for-user-settings-in-visual-basic.md)   
 [Managing Application Settings](../vs140/managing-application-settings--.net-.md)