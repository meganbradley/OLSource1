---
title: "&lt;formRegions&gt; Element (Office Development in Visual Studio)"
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
  - "formRegions element"
  - "<formRegions> element"
  - "application manifests [Office development in Visual Studio], <formRegions> element"
ms.assetid: 71faa2da-9d38-43e8-9d7d-0bcd944ef9a3
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
# &lt;formRegions&gt; Element (Office Development in Visual Studio)
  The `formRegions` element of the `vstov4` namespace contains the Microsoft Office Outlook form regions that are associated with an VSTO Add-in.  
  
## Syntax  
  
```  
<formRegions>  
  <formRegion>  
  </formRegion>  
</formRegions>  
```  
  
## Elements and Attributes  
 The `formRegions` element of the `vstov4` namespace contains all the `formRegion` elements for an Outlook VSTO Add-in. It is required only for Outlook VSTO Add-ins that include form regions.  
  
 There can be only one `formRegions` element defined in an application manifest.  
  
 The `formRegions` element has no attributes.  
  
 The `formRegions` element has the following element.  
  
### formRegion  
 Required for Outlook VSTO Add-ins that include form regions. The `formRegion` element is defined in [&#60;formRegion&#62; Element &#40;Office Development in Visual Studio&#41;](../VS_officedev/-formregion--element--office-development-in-visual-studio-.md).  
  
## VSTO Add-in Example  
  
### Description  
 The following code example illustrates a `formRegions` element in an application manifest for an application-level Office solution deployed using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
### Code  
  
```  
<vstov4:formRegions>  
  <vstov4:formRegion  
      name="OutlookAddIn1.FormRegion1">  
    <vstov4:messageClass name="IPM.Note" />  
    <vstov4:messageClass name="IPM.Contact" />  
    <vstov4:messageClass name="IPM.Appointment" />  
  </vstov4:formRegion>  
</vstov4:formRegions>  
```  
  
## See Also  
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  