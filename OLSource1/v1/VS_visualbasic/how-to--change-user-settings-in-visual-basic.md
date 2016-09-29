---
title: "How to: Change User Settings in Visual Basic"
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
  - "user settings, changing in Visual Basic"
  - "user settings"
  - "My.Settings object, changing user settings"
  - "examples [Visual Basic], changing user settings"
ms.assetid: 41250181-c594-4854-9988-8183b9eb03cf
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Change User Settings in Visual Basic
You can change a user setting by assigning a new value to the setting's property on the `My.Settings` object.  
  
 The `My.Settings` object exposes each setting as a property. The property name is the same as the setting name, and the property type is the same as the setting type. The setting's **Scope** determines if the property is read-only: The property for an **Application**-scope setting is read-only, while the property for a **User**-scope setting is read-write. For more information, see [My.Settings Object](../VS_csharp/my.settings-object.md).  
  
> [!NOTE]
>  Although you can change and save the values of user-scope settings at run time, application-scope settings are read-only and cannot be changed programmatically. You can change application-scope settings when you create the application by using the **Project Designer** or by editing the application's configuration file. For more information, see [Application Settings](../VS_csharp/managing-application-settings--.net-.md).  
  
## Example  
 This example changes the value of the `Nickname` user setting.  
  
 [!code[VbVbalrMyResources#7](../VS_csharp/codesnippet/VisualBasic/how-to--change-user-settings-in-visual-basic_1.vb)]  
  
 For this example to work, your application must have a `Nickname` user setting, of type `String`.  
  
 The application saves the user settings when the application shuts down. To save the settings immediately, call the `My.Settings.Save` method. For more information, see [How to: Persist User Settings in Visual Basic](../VS_csharp/how-to--persist-user-settings-in-visual-basic.md).  
  
## See Also  
 [My.Settings Object](../VS_csharp/my.settings-object.md)   
 [How to: Read Application Settings in Visual Basic](../VS_csharp/how-to--read-application-settings-in-visual-basic.md)   
 [How to: Persist User Settings in Visual Basic](../VS_csharp/how-to--persist-user-settings-in-visual-basic.md)   
 [How to: Create Property Grids for User Settings in Visual Basic](../VS_csharp/how-to--create-property-grids-for-user-settings-in-visual-basic.md)   
 [Managing Application Settings](../VS_csharp/managing-application-settings--.net-.md)