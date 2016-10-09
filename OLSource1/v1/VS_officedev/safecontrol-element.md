---
title: "SafeControl Element"
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
  - "SafeControl element"
ms.assetid: e7c61749-fc73-412c-be30-4af5ff2a9fd2
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
# SafeControl Element
  Represents an ASPX control or Web Part that is designated as secure for any user to access on any ASPX page on the SharePoint site.  
  
## Syntax  
  
```  
<SafeControl Assembly = "Name of assembly that contains the safe control"  
    IsSafe = "true/false"  
    IsSafeAgainstScript = "true/false"  
    Name = "Name of this safe control entry"  
    Namespace = "Namespace of the safe control"  
    TypeName = "Type of the safe control" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Assembly**|Optional **xs:string** attribute.<br /><br /> The name of the assembly in which the ASPX control or Web Part is defined. By default, this attribute uses the **$SharePoint.Project.AssemblyFullName$** replaceable parameter for the assembly name. For more information, see [Replaceable Parameters](../VS_officedev/replaceable-parameters.md).|  
|**IsSafe**|Optional **xs:boolean** attribute.<br /><br /> Specifies whether the ASPX control or Web Part is secure for untrusted users to access.|  
|**IsSafeAgainstScript**|Optional **xs:boolean** attribute.<br /><br /> Specifies whether untrusted users can view or edit the properties of the ASPX control or Web Part.|  
|**Name**|Optional **xs:string** attribute.<br /><br /> The name of this safe control entry in the collection.|  
|**Namespace**|Optional **xs:string** attribute.<br /><br /> The namespace of the ASPX control or Web Part.|  
|**TypeName**|Optional **xs:string** attribute.<br /><br /> The type name of the ASPX control or Web Part.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[SafeControls](../VS_officedev/safecontrols-element.md)|Represents a collection of ASPX controls and Web Parts that are designated as secure for any user to access on any ASPX page on the SharePoint site.|  
  
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
  
  