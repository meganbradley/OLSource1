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
You can change a user setting by assigning a new value to the setting's property on the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object exposes each setting as a property. The property name is the same as the setting name, and the property type is the same as the setting type. The setting's **Scope** determines if the property is read-only: The property for an **Application**-scope setting is read-only, while the property for a **User**-scope setting is read-write. For more information, see [My.Settings Object](../vs140/my.settings-object.md).  
  
> [!NOTE]
>  Although you can change and save the values of user-scope settings at run time, application-scope settings are read-only and cannot be changed programmatically. You can change application-scope settings when you create the application by using the **Project Designer** or by editing the application's configuration file. For more information, see [Application Settings](../vs140/managing-application-settings--.net-.md).  
  
## Example  
 This example changes the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> user setting.  
  
 [!code[VbVbalrMyResources#7](../vs140/codesnippet/VisualBasic/how-to--change-user-settings-in-visual-basic_1.vb)]  
  
 For this example to work, your application must have a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> user setting, of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The application saves the user settings when the application shuts down. To save the settings immediately, call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method. For more information, see [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md).  
  
## See Also  
 [My.Settings Object](../vs140/my.settings-object.md)   
 [How to: Read Application Settings in Visual Basic](../vs140/how-to--read-application-settings-in-visual-basic.md)   
 [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md)   
 [How to: Create Property Grids for User Settings in Visual Basic](../vs140/how-to--create-property-grids-for-user-settings-in-visual-basic.md)   
 [Managing Application Settings](../vs140/managing-application-settings--.net-.md)