---
title: "FeatureProperties Element"
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
  - "FeatureProperties element"
ms.assetid: 89233274-a842-4f40-a81a-5548379f6f39
caps.latest.revision: 11
ms.author: "kempb"
manager: "douge"
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
# FeatureProperties Element
  Represents a collection of property values that are included with a Feature when it is deployed to SharePoint. After a Feature is deployed, you can access the property values in your code.  
  
## Syntax  
  
```  
<FeatureProperties>  
  <FeatureProperty.../>  
</FeatureProperties>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[FeatureProperty](../VS_officedev/featureproperty-element.md)|Optional element.<br /><br /> Represents a custom property, in key/value format.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../VS_officedev/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 For more information about Feature properties, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md).  
  
## Element Information  
  
|Element|Description|  
|-------------|-----------------|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)   
 [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md)  
  
  