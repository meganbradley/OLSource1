---
title: "ProjectItemFile Element"
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
  - "ProjectItemFile element"
ms.assetid: 68d44d31-625a-4f02-b998-463ac0ffb2ef
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
# ProjectItemFile Element
  Represents a SharePoint file, such as Feature element file, to include with the project item when it is deployed to SharePoint.  
  
## Syntax  
  
```  
<ProjectItemFile Source = "Name of the file"  
    Target = "Deployment path of the file"  
    Type = "Type of deployment for the file" />  
```  
  
## Type  
 **ProjectItemFileType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**Source**|Required **xs:string** attribute.<br /><br /> The name of the file to deploy with the project item.|  
|**Target**|Optional **xs:string** attribute.<br /><br /> The path where the file will be deployed on SharePoint, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute. If the **Target** attribute is not specified, the file will be deployed to a folder with the name specified in the **Source** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment for the file. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Files](../VS_officedev/files-element.md)|Specifies the files to include with the SharePoint project item when it is deployed to SharePoint.|  
  
## Remarks  
 SharePoint files that are typically referenced in **ProjectItemFile** elements include Feature element files (Elements.xml), schema files for list definitions (Schema.xml), and Web Part definition files for Web Parts (.webpart).  
  
## Element Information  
  
|||  
|-|-|  
|**Namespace**|http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel|  
|**Schema name**|SharePoint Project Item Schema|  
|**Validation file**|ProjectItemModelSchema.xsd|  
|**Can be empty**|No|  
  
## See Also  
 [SharePoint Project Item Schema Reference](../VS_officedev/sharepoint-project-item-schema-reference.md)  
  
  