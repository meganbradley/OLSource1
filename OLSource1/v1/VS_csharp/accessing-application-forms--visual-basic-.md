---
title: "Accessing Application Forms (Visual Basic)"
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
  - "forms, communicating between"
  - "application forms, accessing"
  - "forms, accessing one from another"
  - "My.Forms object"
  - "forms, accessing all open"
ms.assetid: 9aaf5aaf-2012-4f97-89c7-6e62b9d17863
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing Application Forms (Visual Basic)
The `My.Forms` object provides an easy way to access an instance of each Windows Form declared in the application's project. You can also use properties of the `My.Application` object to access the application's splash screen and main form, and get a list of the application's open forms.  
  
## Tasks  
 The following table lists examples showing how to access an application's forms.  
  
|||  
|-|-|  
|To|See|  
|Access one form from another form in an application.|[My.Forms Object (Visual Basic)](../VS_csharp/my.forms-object.md)|  
|Display the titles of all the application's open forms.|<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OpenForms*>|  
|Update the splash screen with status information as the application starts.|<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.SplashScreen*>|  
  
## See Also  
 <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OpenForms*>   
 <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.SplashScreen*>   
 [My.Forms Object](../VS_csharp/my.forms-object.md)