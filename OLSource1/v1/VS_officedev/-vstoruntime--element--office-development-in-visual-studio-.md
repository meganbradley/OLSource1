---
title: "&lt;vstoRuntime&gt; Element (Office Development in Visual Studio)"
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
  - "application manifests [Office development in Visual Studio], <vstoRuntime> element"
  - "<vstoRuntime> element"
  - "vstoRuntime element"
ms.assetid: e59a8a61-9ff2-4032-9983-4a1e289e70a7
caps.latest.revision: 10
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
# &lt;vstoRuntime&gt; Element (Office Development in Visual Studio)
  The `vstoRuntime` element of the `vstav3` namespace contains a supported version of the Visual Studio Tools for Office runtime for a specific Office solution.  
  
## Syntax  
  
```  
<vstoRuntime  
    release  
    version  
    supportUrl />  
```  
  
## Elements and Attributes  
 The `vstoRuntime` element is required and is in the `vstav3` namespace. If an Office solution supports two versions of the Visual Studio Tools for Office runtime, there are two `vstoRuntime` elements in the application manifest.  
  
 The `vstoRuntime` element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`release`|Required. The release version of the Visual Studio Tools for Office runtime.|  
|`version`|Required. Version number of the Visual Studio Tools for Office runtime.|  
|`supportUrl`|Optional. Link to the installation location of the Visual Studio Tools for Office runtime.|  
  
 `vstoRuntime` has no elements.  
  
## Example  
 The following code example illustrates the `vstoRuntime` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
```  
<vstav3:vstoRuntime  
    release="VSTOR40Beta1"  
    version="10.0.20303"  
    supportUrl="http://www.microsoft.com" />  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  