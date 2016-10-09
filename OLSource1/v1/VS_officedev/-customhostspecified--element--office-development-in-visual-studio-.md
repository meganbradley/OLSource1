---
title: "&lt;customHostSpecified&gt; Element (Office Development in Visual Studio)"
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
  - "application manifests [Office development in Visual Studio], <customHostSpecified> element"
  - "<customHostSpecified> element"
  - "customHostSpecified element"
ms.assetid: 2212b7eb-bf94-4398-b9ea-0ab00203203b
caps.latest.revision: 23
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
# &lt;customHostSpecified&gt; Element (Office Development in Visual Studio)
  The `customHostSpecified` element indicates that this solution is not a stand-alone application. Office solutions contain components that are hosted inside Microsoft Office applications.  
  
## Syntax  
  
```  
<customHostSpecified />  
```  
  
## Elements and Attributes  
 The `customHostSpecified` element is required for Office solutions. This element is in the `co.v1` namespace and specifies that this deployment contains a component that will be deployed inside of a custom host, and is not a stand-alone application.  
  
 This element is a child of the first `<entrypoint>` element in the application manifest. There can be no other child elements in that `<entrypoint>` element or [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] will raise a validation error during installation.  
  
 This element has no attributes and no child elements.  
  
## Example  
 The following code example illustrates the `customHostSpecified` element in an application manifest for an Office  solution. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
```  
<entryPoint>  
    <co.v1:customHostSpecified />  
</entryPoint>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  