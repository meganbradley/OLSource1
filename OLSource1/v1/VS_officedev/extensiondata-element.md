---
title: "ExtensionData Element"
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
  - "ExtensionData element"
ms.assetid: caf6843b-dcf5-4688-a9eb-a424aae1beab
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
# ExtensionData Element
  Represents a collection of custom data items that are associated with the SharePoint project item.  
  
## Syntax  
  
```  
<ExtensionData>  
  <ExtensionDataItem.../>  
</ExtensionData>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ExtensionDataItem](../VS_officedev/extensiondataitem-element.md)|Optional element.<br /><br /> Represents a custom data item that is associated with the SharePoint project item, in key/value format. Both the key and value must be strings.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../VS_officedev/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 When you associate custom data with a SharePoint project item by using the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object, Visual Studio saves the data to the **ExtensionData** element in the .spdata file for the project item. For more information, see [Saving Data in Extensions of the SharePoint Project System](../VS_officedev/saving-data-in-extensions-of-the-sharepoint-project-system.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)  
  
  