---
title: "ProjectItemFolder Element"
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
  - "ProjectItemFolder element"
ms.assetid: 15b386dd-f523-4425-9fcc-517325681358
caps.latest.revision: 12
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
# ProjectItemFolder Element
  Represents a mapped folder.  
  
## Syntax  
  
```  
<ProjectItemFolder Target = "Path of SharePoint folder the mapped folder corresponds to"  
    Type = "Type of deployment for the mapped folder" />  
```  
  
## Type  
 **ProjectItemFolderType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Target**|Required **xs:string** attribute.<br /><br /> The path of the folder in the SharePoint installation that the mapped folder corresponds to, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the mapped folder. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../VS_officedev/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Remarks  
 For more information about mapped folders, see [How to: Add and Remove Mapped Folders](../VS_officedev/how-to--add-and-remove-mapped-folders.md).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)   
 [How to: Add and Remove Mapped Folders](../VS_officedev/how-to--add-and-remove-mapped-folders.md)  
  
  