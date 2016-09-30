---
title: "A startup form has not been specified"
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
  - "vbrAppModel_NoStartupForm"
dev_langs: 
  - "VB"
ms.assetid: 8e04af49-4bef-49de-a7ec-e407e9873da7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A startup form has not been specified
The application uses the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase*> class but does not specify the startup form.  
  
 This can occur if the **Enable application framework** check box is selected in the project designer but the **Startup form** is not specified. For more information, see [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md).  
  
### To correct this error  
  
1.  Specify a startup object for the application.  
  
     For more information, see [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md).  
  
2.  Override the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OnCreateMainForm*> method to set the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.MainForm*> property to the startup form.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase*>   
 \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.OnCreateMainForm*>   
 \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.MainForm*>   
 [Overview of the Visual Basic Application Model](../vs140/overview-of-the-visual-basic-application-model.md)