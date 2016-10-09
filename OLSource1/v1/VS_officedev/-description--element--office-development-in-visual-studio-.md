---
title: "&lt;description&gt; Element (Office Development in Visual Studio)"
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
  - "description element"
  - "<description> element"
  - "application manifests [Office development in Visual Studio], <description> element"
ms.assetid: 27c90f8c-393d-4557-9371-2e4e3c4a2d95
caps.latest.revision: 21
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# &lt;description&gt; Element (Office Development in Visual Studio)
  The `description` element of the `vstov4` namespace stores the description for the Office solution that appears in the COM add-ins dialog box of Microsoft Office applications.  
  
## Syntax  
  
```  
<description>  
</description>  
```  
  
## Elements and Attributes  
 Optional. The `description` element is in the `vstov4` namespace. It contains the description of the add-in that appears in the COM add-ins dialog box of Microsoft Office applications.  
  
 The `description` element has no attributes or elements.  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates the `description` element for an application-level solution deployed by using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:description>  
  ContosoOutlookAddIn - Outlook add-in   
  created with Visual Studio Tools for Office  
</vstov4:description>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  