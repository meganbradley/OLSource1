---
title: "Password Protection on Office Documents"
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
  - "permissions [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "passwords [Office development in Visual Studio], document protections"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "Office documents [Office development in Visual Studio, restricted permissions"
ms.assetid: 9cee99c8-73c6-4f89-9d5e-7912c876ff96
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
# Password Protection on Office Documents
  It is possible to set a password on your Microsoft Office Word documents and Microsoft Office Excel workbooks so that they cannot be opened by someone who does not know the password. This option is called **Password on Open**.  
  
 [!INCLUDE[appliesto_alldoc](../VS_officedev/includes/appliesto_alldoc_md.md)]  
  
 You can create document-level projects using existing documents and workbooks that have **Password on Open** enabled. The behavior in Visual Studio is different for Word and Excel documents that have **Password on Open** enabled.  
  
 For information about enabling **Password on Open**, see Help in Word or Excel.  
  
## Behavior of Excel and Word  
 Every time you open an Excel workbook in Visual Studio that has **Password on Open** enabled, Excel prompts you for the password. When you build your solution you will be prompted for the password again, because the document is opened during build.  
  
 The first time you open a Word document in Visual Studio that has **Password on Open** enabled, Word prompts you for the password. After you successfully enter the password, **Password on Open** is removed from the document and opening the document will no longer require a password. If you want the document in your solution to require a password before it can be opened, you must enable **Password on Open** after your final build and before you deploy the solution.  
  
## See Also  
 [Document Protection in Document-Level Solutions](../VS_officedev/document-protection-in-document-level-solutions.md)   
 [Information Rights Management and Managed Code Extensions Overview](../VS_officedev/information-rights-management-and-managed-code-extensions-overview.md)   
 [How to: Permit Code to Run Behind Documents with Restricted Permissions](../VS_officedev/how-to--permit-code-to-run-behind-documents-with-restricted-permissions.md)   
 [Designing and Creating Office Solutions](../VS_officedev/designing-and-creating-office-solutions.md)  
  
  