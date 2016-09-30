---
title: "ClickOnce Application Manifest"
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
  - "application manifests [ClickOnce]"
  - "ClickOnce, application manifests"
ms.assetid: 29570cec-4e53-4660-a850-abc4fa150243
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ClickOnce Application Manifest
A [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest is an XML file that describes an application that is deployed using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)].  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifests have the following elements and attributes.  
  
|Element|Description|Attributes|  
|-------------|-----------------|----------------|  
|[\<assembly> Element (ClickOnce Reference)](../vs140/-assembly--element--clickonce-application-.md)|Required. Top-level element.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|[\<assemblyIdentity> Element (ClickOnce Reference)](../vs140/-assemblyidentity--element--clickonce-application-.md)|Required. Identifies the primary assembly of the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|[\<trustInfo> Element](../vs140/-trustinfo--element--clickonce-application-.md)|Identifies the application security requirements.|None|  
|[\<entryPoint> Element](../vs140/-entrypoint--element--clickonce-application-.md)|Required. Identifies the application code entry point.|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|[\<dependency> Element (ClickOnce Reference)](../vs140/-dependency--element--clickonce-application-.md)|Required. Identifies each dependency required for the application to run. Optionally identifies assemblies that need to be preinstalled.|None|  
|[\<file> Element](../vs140/-file--element--clickonce-application-.md)|Optional. Identifies each nonassembly file that is used by the application. Can include Component Object Model (COM) isolation data associated with the file.|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|[\<fileAssociation> Element](../vs140/-fileassociation--element--clickonce-application-.md)|Optional. Identifies a file extension to be associated with the application.|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
## Remarks  
 The [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest file identifies an application deployed using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]. For more information about [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)], see [ClickOnce Deployment Overview](../vs140/clickonce-security-and-deployment.md).  
  
## File Location  
 A [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest is specific to a single version of a deployment. For this reason, they should be stored separately from deployment manifests. The common convention is to place them in a subdirectory named after the associated version.  
  
 The application manifest always must be signed prior to deployment. If you change an application manifest manually, you must use mage.exe to re-sign the application manifest, update the deployment manifest, and then re-sign the deployment manifest. For more information, see [Walkthrough: Deploying a ClickOnce Application Manually](../vs140/walkthrough--manually-deploying-a-clickonce-application.md).  
  
## File Name Syntax  
 The name of a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest file should be the full name and extension of the application as identified in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element, followed by the extension .manifest. For example, an application manifest that refers to the Example.exe application would use the following file name syntax.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Example  
 The following code example shows an application manifest for a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Publishing ClickOnce Applications](../vs140/publishing-clickonce-applications.md)