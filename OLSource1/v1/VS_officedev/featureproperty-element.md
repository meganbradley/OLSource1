---
title: "FeatureProperty Element"
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
  - "FeatureProperty element"
ms.assetid: 36a771a6-98d0-4a40-a278-d76baea82452
caps.latest.revision: 10
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
# FeatureProperty Element
  Represents a custom property that is included with a Feature when it is deployed to SharePoint. After a Feature is deployed, you can access the property in your code.  
  
## Syntax  
  
```  
<FeatureProperty Key = "Key of the property value"  
    Value = "Property value" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Key**|Required **xs:string** attribute.<br /><br /> The key that is used to store and retrieve the property value. Each property must have a key that is unique within the Feature.|  
|**Value**|Required **xs:string** attribute.<br /><br /> The property value.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[FeatureProperties](../VS_officedev/featureproperties-element.md)|Represents a collection of property values that are included with a Feature when it is deployed to SharePoint.|  
  
## Remarks  
 For more information about Feature properties, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)   
 [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md)  
  
  