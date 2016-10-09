---
title: "ProjectOutputFile Element"
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
  - "ProjectOutputFile element"
ms.assetid: 52a017bf-e19c-49e4-bb8f-cbe6958195c2
caps.latest.revision: 13
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
# ProjectOutputFile Element
  Represents the output of a separate project to include with the project item when it is deployed to SharePoint.  
  
## Syntax  
  
```  
<ProjectOutputFile ProjectId = "GUID of the project"  
    ProjectPath = "Relative path of the project"  
    Target = "Deployment path of the project output"  
    Type = "Type of deployment for the project output" />  
```  
  
## Type  
 **ProjectOutputFileType**  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|**ProjectId**|Required **xs:string** attribute.<br /><br /> The GUID of the dependent project that has the output you want to include. This corresponds to the **ProjectGuid** element in the dependent project file.|  
|**ProjectPath**|Required **xs:string** attribute.<br /><br /> The relative path, including the project file name, of the dependent project that has the output you want to include. This path is relative to the root folder of the SharePoint project that contains the SharePoint project item.|  
|**Target**|Optional **xs:string** attribute.<br /><br /> The path where the dependent project output is to be deployed on the SharePoint server, relative to the deployment root folder. The deployment root folder is determined by the deployment type specified by the **Type** attribute.<br /><br /> For more information, see the descriptions for the **Deployment Path** and **Deployment Root** properties of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
|**Type**|Required **xs:string** attribute.<br /><br /> The type of deployment to use for the output of the dependent project. For more information about the possible values, see the description for the **Deployment Type** property of SharePoint project items in [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md).|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Files](../VS_officedev/files-element.md)|Specifies the files to include with the SharePoint project item when it is deployed to SharePoint.|  
  
## Remarks  
 Use the **ProjectOutputFile** element to include the output of a project in the deployment of the SharePoint project item. You can specify a different project, or the same project that contains the project item. For more information, see [Providing Packaging and Deployment Information in Project Items](../VS_officedev/providing-packaging-and-deployment-information-in-project-items.md).  
  
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
 [Developing SharePoint Solutions](../VS_officedev/developing-sharepoint-solutions.md)  
  
  