---
title: "&lt;document&gt; Element (Office Development in Visual Studio)"
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
  - "document element"
  - "application manifests [Office development in Visual Studio], <document> element"
  - "<document> element"
ms.assetid: b4525a0e-8a03-4881-a3e2-8cc019029071
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
# &lt;document&gt; Element (Office Development in Visual Studio)
  The `document` element of the `vstov4` namespace stores customization-specific information for document-level customizations.  
  
## Syntax  
  
```  
<document solutionId />  
```  
  
## Elements and Attributes  
 Required only for document-level customizations. The `document` element is in the `vstov4` namespace. The `document` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`solutionId`|Required. The GUID used by the Visual Studio Tools for Office runtime to uniquely identify a document-level solution. This value is stored as the _AssemblyLocation custom document property. For more information, see [Custom Document Properties Overview](../VS_officedev/custom-document-properties-overview.md).|  
  
 `document` has no child elements.  
  
## Document-Level Customization Example  
  
### Description  
 The following code example illustrates the `document` element in a document-level Office solution deployed by using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:document   
  solutionId="73e" />  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  