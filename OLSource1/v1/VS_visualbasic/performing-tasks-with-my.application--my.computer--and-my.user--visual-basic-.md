---
title: "Performing Tasks with My.Application, My.Computer, and My.User (Visual Basic)"
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
  - "My.Application object, developing applications"
  - "rapid application development (RAD), My.Application"
  - "rapid application development (RAD), My.Computer"
  - "rapid application development (RAD), My.User"
  - "My.Computer object, developing applications"
  - "My.User object, developing applications"
ms.assetid: c8af61bd-4dd3-4a0f-9af5-795b594b240b
caps.latest.revision: 7
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
# Performing Tasks with My.Application, My.Computer, and My.User (Visual Basic)
The three central `My` objects that provide access to information and commonly used functionality are `My.Application` (\<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase>), `My.Computer` (\<xref:Microsoft.VisualBasic.Devices.Computer>), and `My.User` (\<xref:Microsoft.VisualBasic.ApplicationServices.User>). You can use these objects to access information that is related to the current application, the computer that the application is installed on, or the current user of the application, respectively.  
  
## My.Application, My.Computer, and My.User  
 The following examples demonstrate how information can be retrieved using `My`.  
  
 [!code[VbVbcnMy#1](../VS_visualbasic/codesnippet/VisualBasic/performing-tasks-with-my.application--my.computer--and-my.user--visual-basic-_1.vb)]  
  
 [!code[VbVbcnMy#2](../VS_visualbasic/codesnippet/VisualBasic/performing-tasks-with-my.application--my.computer--and-my.user--visual-basic-_2.vb)]  
  
 In addition to retrieving information, the members exposed through these three objects also allow you to execute methods related to that object. For instance, you can access a variety of methods to manipulate files or update the registry through `My.Computer`.  
  
 File I/O is significantly easier and faster with `My`, which includes a variety of methods and properties for manipulating files, directories, and drives. The \<xref:Microsoft.VisualBasic.FileIO.TextFieldParser> object allows you to read from large structured files that have delimited or fixed-width fields. This example opens the `TextFieldParser``reader` and uses it to read from `C:\TestFolder1\test1.txt`.  
  
 [!code[VbVbalrTextFieldParser#23](../VS_visualbasic/codesnippet/VisualBasic/performing-tasks-with-my.application--my.computer--and-my.user--visual-basic-_3.vb)]  
  
 `My.Application` allows you to change the culture for your application. The following example demonstrates how this method can be called.  
  
 [!code[VbVbcnMy#3](../VS_visualbasic/codesnippet/VisualBasic/performing-tasks-with-my.application--my.computer--and-my.user--visual-basic-_4.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase>   
 \<xref:Microsoft.VisualBasic.Devices.Computer>   
 \<xref:Microsoft.VisualBasic.ApplicationServices.User>   
 [How My Depends on Project Type](../VS_visualbasic/how-my-depends-on-project-type--visual-basic-.md)