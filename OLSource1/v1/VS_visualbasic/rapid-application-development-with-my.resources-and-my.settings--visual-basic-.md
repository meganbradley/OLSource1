---
title: "Rapid Application Development with My.Resources and My.Settings (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "My.Settings object, developing applications"
  - "rapid application development (RAD), My.Resources"
  - "rapid application development (RAD), My.Settings"
  - "My.Resources object, developing applications"
ms.assetid: 68284ab1-b685-4814-a2a4-01ae40445ff8
caps.latest.revision: 6
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Rapid Application Development with My.Resources and My.Settings (Visual Basic)
The `My.Resources` object provides access to the application's resources and allows you to dynamically retrieve resources for your application.  
  
## Retrieving Resources  
 A number of resources such as audio files, icons, images, and strings can be retrieved through the `My.Resources` object. For example, you can access the application's culture-specific resource files. The following example sets the icon of the form to the icon named `Form1Icon` stored in the application's resource file.  
  
 [!code[VbVbcnMy#7](../VS_visualbasic/codesnippet/VisualBasic/rapid-application-development-with-my.resources-and-my.settings--visual-basic-_1.vb)]  
  
 The `My.Resources` object exposes only global resources. It does not provide access to resource files associated with forms. You must access the form resources from the form. For more information, see [Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5).  
  
 Similarly, the `My.Settings` object provides access to the application's settings and allows you to dynamically store and retrieve property settings and other information for your application. For more information, see [My.Resources Object](../VS_visualbasic/my.resources-object.md) and [My.Settings Object](../VS_visualbasic/my.settings-object.md).  
  
## See Also  
 [My.Resources Object](../VS_visualbasic/my.resources-object.md)   
 [My.Settings Object](../VS_visualbasic/my.settings-object.md)   
 [Accessing Application Settings](../VS_visualbasic/accessing-application-settings--visual-basic-.md)