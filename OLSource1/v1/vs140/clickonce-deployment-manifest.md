---
title: "ClickOnce Deployment Manifest"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce, deployment manifests"
  - "deployment manifests [ClickOnce]"
ms.assetid: 8457e615-e3b6-4990-8dcf-11bc590e4e9b
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClickOnce Deployment Manifest
A deployment manifest is an XML file that describes a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment, including the identification of the current [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application version to deploy.  
  
 Deployment manifests have the following elements and attributes.  
  
|Element|Description|Attributes|  
|-------------|-----------------|----------------|  
|[\<assembly> Element](../vs140/-assembly--element--clickonce-deployment-.md)|Required. Top-level element.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|[\<assemblyIdentity> Element](../vs140/-assemblyidentity--element--clickonce-deployment-.md)|Required. Identifies the application manifest for the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|[\<description> Element](../vs140/-description--element--clickonce-deployment-.md)|Required. Identifies application information used to create a shell presence and the **Add or Remove Programs** item in Control Panel.|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|[\<deployment> Element](../vs140/-deployment--element--clickonce-deployment-.md)|Optional. Identifies the attributes used for the deployment of updates and exposure to the system.|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|[\<compatibleFrameworks> Element](../vs140/-compatibleframeworks--element--clickonce-deployment-.md)|Required. Identifies the versions of the .NET Framework where this application can install and run.|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|[\<dependency> Element](../vs140/-dependency--element--clickonce-deployment-.md)|Required. Identifies the version of the application to install for the deployment and the location of the application manifest.|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|[\<publisherIdentity> Element](../vs140/-publisheridentity--element--clickonce-deployment-.md)|Required for signed manifests. Contains information about the publisher that signed this deployment manifest.|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|[\<Signature> Element](../vs140/-signature--element--clickonce-deployment-.md)|Optional. Contains the necessary information to digitally sign this deployment manifest.|None|  
|[\<customErrorReporting> Element](../vs140/-customerrorreporting--element--clickonce-deployment-.md)|Optional. Specifies a URI to show when an error occurs.|Uri|  
  
## Remarks  
 The deployment manifest file identifies a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application deployment, including the current version and other deployment settings. It references the application manifest, which describes the current version of the application and all of the files contained within the deployment.  
  
 For more information, see [ClickOnce Deployment Overview](../vs140/clickonce-security-and-deployment.md).  
  
## File Location  
 The deployment manifest file references the correct application manifest for the current version of the application. When you make a new version of an application deployment available, you must update the deployment manifest to refer to the new application manifest.  
  
 The deployment manifest file must be strongly named and can also contain certificates for publisher validation.  
  
## File Name Syntax  
 The name of a deployment manifest file must end with the .application extension.  
  
## Examples  
 The following code example illustrates a deployment manifest.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Publishing ClickOnce Applications](../vs140/publishing-clickonce-applications.md)