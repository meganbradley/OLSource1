---
title: "Secure Deployment"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "deploying applications [Office development in Visual Studio], security"
  - "Office development in Visual Studio, security"
  - "Office applications [Office development in Visual Studio], security"
  - "ClickOnce deployment [Office development in Visual Studio], security"
ms.assetid: c5ba86b1-e87f-4508-8c5a-1295681a9590
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
# Secure Deployment
  When you create an Office solution, your development computer is updated automatically to allow the code in your project to run. However, when you deploy your solution, you must provide evidence on which to base a trust decision by signing the solution with a certificate, or using the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] trust prompt key. For more information, see [Granting Trust to Office Solutions](../VS_officedev/granting-trust-to-office-solutions.md).  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 For document-level customizations, if you deploy the document to a network location, you must also add the document's location to the list of trusted locations in the Trust Center of the Office application. For more information about how to set document permissions on end user computers, see [Granting Trust to Documents](../VS_officedev/granting-trust-to-documents.md).  
  
## Preventing Office Solutions from Running Code  
 Administrators can use the registry to prevent all Office solutions from running on a computer. When an Office solution that has managed code extensions is opened, the Visual Studio Tools for Office runtime checks whether an entry with the name `Disabled` exists under one of the following registry keys on the computer:  
  
-   `HKEY_CURRENT_USER\Software\Microsoft\VSTO`  
  
-   `HKEY_LOCAL_MACHINE\Software\Microsoft\VSTO`  
  
 To prevent Office solutions from running code, create a `Disabled` entry under one or both of these registry keys, and specify one of the following data types and values for `Disabled`:  
  
-   A REG_SZ or REG_EXPAND_SZ that is set to any string other than "0" (zero).  
  
-   A REG_DWORD that is set to any value other than 0 (zero).  
  
 To enable Office solutions to run code, set both of the `Disabled` entries to 0 (zero), or delete the registry entries.  
  
## See Also  
 [Deploying an Office Solution](../VS_officedev/deploying-an-office-solution.md)   
 [Preparing Computers to Run or Host Office Solutions](assetId:///be1b173f-7261-4d74-aa4e-94ccd43db8d8)   
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)  
  
  