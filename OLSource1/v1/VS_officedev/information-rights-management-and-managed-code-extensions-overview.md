---
title: "Information Rights Management and Managed Code Extensions Overview"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Information Rights Management [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "IRM [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "rights management [Office development in Visual Studio]"
  - "Office documents [Office development in Visual Studio, restricted permissions"
ms.assetid: 9728f5fe-9122-48e7-b0a3-9f5e0a16164f
caps.latest.revision: 21
ms.author: "normesta"
manager: "ghogen"
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
# Information Rights Management and Managed Code Extensions Overview
  Microsoft Office Word and Microsoft Office Excel provide Information Rights Management (IRM), a feature that can help you prevent unauthorized people from viewing or altering sensitive information. For details about how Information Rights Management works, see Help in the specific Office application.  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
## Running Code Behind Documents with Restricted Permissions  
 If your solution contains a document or workbook that uses IRM, by default, Word and Excel do not permit any code to run. If you are the author of the document or have Full Control access, you can change the default so that your solution works. For more information, see [How to: Permit Code to Run Behind Documents with Restricted Permissions](../VS_officedev/how-to--permit-code-to-run-behind-documents-with-restricted-permissions.md).  
  
 IRM prevents use of \<xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ServerDocument> to retrieve or manipulate data that is cached in the document.  
  
## End Users Restricting Permissions to Documents That Use Managed Code Extensions  
 Anyone who has Full Control access to the document or workbook in your solution can use IRM to restrict permissions. For example, if an end user in the accounting department uses a solution that automatically populates a worksheet with data from a database, that user might want to allow Change access only to people in his or her department and Read access to others. When the user adds the restricted permissions, by default, the code behind the worksheet cannot run, and the worksheet will not be populated with data.  
  
 To fix the problem, someone with Full Control access to the document or workbook must change the default permission settings to allow programmatic access to the object model. For more information, see [How to: Permit Code to Run Behind Documents with Restricted Permissions](../VS_officedev/how-to--permit-code-to-run-behind-documents-with-restricted-permissions.md).  
  
## See Also  
 [Document Protection in Document-Level Solutions](../VS_officedev/document-protection-in-document-level-solutions.md)   
 [Password Protection on Office Documents](../VS_officedev/password-protection-on-office-documents.md)   
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)   
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)  
  
  