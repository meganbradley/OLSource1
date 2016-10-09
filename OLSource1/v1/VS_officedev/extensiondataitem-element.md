---
title: "ExtensionDataItem Element"
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
  - "ExtensionDataItem element"
ms.assetid: 6a5fe7eb-b433-42dc-bd50-4882b780e2fb
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
# ExtensionDataItem Element
  Represents a custom data item that is associated with the SharePoint project item, in key/value format. Both the key and value must be strings.  
  
## Syntax  
  
```  
<ExtensionDataItem Key = "Key of the data item"  
    Value = "Value of the data item" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Key**|Required **xs:string** attribute.<br /><br /> The key that is used to store and retrieve the data item.|  
|**Value**|Required **xs:string** attribute.<br /><br /> The value of the data item.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ExtensionData](../VS_officedev/extensiondata-element.md)|Represents a collection of custom data items that are associated with the SharePoint project item.|  
  
## Remarks  
 When you associate custom data with a SharePoint project item by using the \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData*> property of an \<xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object, Visual Studio saves the data to a new **ExtensionDataItem** element in the .spdata file for the project item. For more information, see [Saving Data in Extensions of the SharePoint Project System](../VS_officedev/saving-data-in-extensions-of-the-sharepoint-project-system.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)  
  
  