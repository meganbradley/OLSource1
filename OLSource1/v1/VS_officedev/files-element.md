---
title: "Files Element"
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
  - "Files element"
ms.assetid: 3c611d5b-28f1-48a7-a068-63e01fa2f3aa
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
# Files Element
  Specifies the files to deploy with the SharePoint project item, such as Feature element files and the output of dependent non-SharePoint projects.  
  
## Syntax  
  
```  
<Files>  
  <ProjectItemFile.../>  
  <ProjectOutputFile.../>  
</Files>  
```  
  
## Type  
 **FileCollectionType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItemFile](../VS_officedev/projectitemfile-element.md)|Optional **ProjectItemFileType** element.<br /><br /> Represents a SharePoint file, such as Feature element file, to include with the project item when it is deployed to SharePoint.|  
|[ProjectOutputFile](../VS_officedev/projectoutputfile-element.md)|Optional **ProjectOutputFileType** element.<br /><br /> Represents the output of a project to include with the project item when it is deployed to SharePoint.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[ProjectItem](../VS_officedev/projectitem-element.md)|Represents a SharePoint project item. This is the required root element of the .spdata file.|  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)  
  
  