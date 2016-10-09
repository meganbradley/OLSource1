---
title: "&lt;formRegion&gt; Element (Office Development in Visual Studio)"
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
  - "application manifests [Office development in Visual Studio], <formRegion> element"
ms.assetid: d397cf31-c0ef-47f0-860a-cd816e4bf6eb
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
# &lt;formRegion&gt; Element (Office Development in Visual Studio)
  The `formRegion` element of the `vstov4` namespace identifies a Microsoft Office Outlook form region that is associated with an VSTO Add-in.  
  
## Syntax  
  
```  
<formRegion  
  name>  
  <messageClass  
    name/>  
</formRegion>  
```  
  
## Elements and Attributes  
 The `formRegion` element of the `vstov4` namespace identifies a form region that is associated with an Outlook VSTO Add-in. It is required only for Outlook VSTO Add-ins that include form regions.  
  
 There can be multiple `formRegion` elements defined inside a `formRegions` element for a single VSTO Add-in.  
  
 The `formRegion` element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`name`|Required. Identifies the form region name.|  
  
 The `formRegion` element has the following child elements.  
  
### messageClass  
 The `messageClass` element identifies the Outlook form that is associated with the form region.  
  
 The `messageClass` element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`name`|Required. Identifies the form that is associated with the form region.|  
  
## Example  
 The following code example illustrates a `formRegion` element in an application manifest for an Outlook VSTO Add-in deployed using [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)]. There are three message classes associated with this one form region. This code example is part of a larger example provided in [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md).  
  
```  
<vstov4:formRegion  
    name="OutlookAddIn1.FormRegion1">  
  <vstov4:messageClass name="IPM.Note" />  
  <vstov4:messageClass name="IPM.Contact" />  
  <vstov4:messageClass name="IPM.Appointment" />  
</vstov4:formRegion>  
```  
  
## See Also  
 [Creating Outlook Form Regions](../VS_officedev/creating-outlook-form-regions.md)   
 [Application Manifests for Office Solutions](../VS_officedev/application-manifests-for-office-solutions.md)   
 [Deployment Manifests for Office Solutions](../VS_officedev/deployment-manifests-for-office-solutions.md)   
 [ClickOnce Application Manifest](../Topic/ClickOnce%20Application%20Manifest.md)  
  
  