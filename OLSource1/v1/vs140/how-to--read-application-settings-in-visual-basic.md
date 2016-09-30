---
title: "How to: Read Application Settings in Visual Basic"
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
  - "reading application settings"
  - "My.Settings object, reading application settings"
  - "application settings, reading"
ms.assetid: eb3428ef-115e-49a8-a878-e0613183fee0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read Application Settings in Visual Basic
You can read a user setting by accessing the setting's property on the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object exposes each setting as a property. The property name is the same as the setting name, and the property type is the same as the setting type. The setting's **Scope** indicates if the property is read-only; the property for an **Application** scope setting is read-only, while the property for a **User** scope setting is read-write. For more information, see [My.Settings Object](../vs140/my.settings-object.md).  
  
## Example  
 This example displays the value of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> setting.  
  
 [!code[VbVbalrMyResources#14](../vs140/codesnippet/VisualBasic/how-to--read-application-settings-in-visual-basic_1.vb)]  
  
 For this example to work, your application must have a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> setting, of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information, see [Managing Application Settings](../vs140/managing-application-settings--.net-.md).  
  
## See Also  
 [My.Settings Object](../vs140/my.settings-object.md)   
 [How to: Change User Settings in Visual Basic](../vs140/how-to--change-user-settings-in-visual-basic.md)   
 [How to: Persist User Settings in Visual Basic](../vs140/how-to--persist-user-settings-in-visual-basic.md)   
 [How to: Create Property Grids for User Settings in Visual Basic](../vs140/how-to--create-property-grids-for-user-settings-in-visual-basic.md)   
 [Managing Application Settings](../vs140/managing-application-settings--.net-.md)