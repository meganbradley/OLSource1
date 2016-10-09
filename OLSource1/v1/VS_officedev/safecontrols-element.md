---
title: "SafeControls Element"
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
  - "SafeControls element"
ms.assetid: f5ffdbbe-cf85-4e5a-9d39-3cd4462f2a0e
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
# SafeControls Element
  Represents a collection of ASPX controls and Web Parts that are designated as secure for any user to access on any ASPX page on the SharePoint site.  
  
## Syntax  
  
```  
<SafeControls>  
  <SafeControl.../>  
</SafeControls>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[SafeControl](../VS_officedev/safecontrol-element.md)|Optional element.<br /><br /> Represents an ASPX control or Web Part that is designated as secure for any user to access on any ASPX page on the SharePoint site.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../VS_officedev/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 For more information about safe controls, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md).  
  
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
  
  