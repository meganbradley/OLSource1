---
title: "&lt;compatibleFrameworks&gt; Element (ClickOnce Deployment)"
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
  - "<compatibleFrameworks> element [ClickOnce deployment manifest]"
ms.assetid: f6c3ee55-9e65-403d-8664-3ebde872c7d4
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;compatibleFrameworks&gt; Element (ClickOnce Deployment)
Identifies the versions of the .NET Framework where this application can install and run.  
  
> [!NOTE]
>  [MageUI.exe](assetId:///f9e130a6-8117-49c4-839c-c988f641dc14) does not support the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element when saving an application manifest that has already been signed with a certificate using [MageUI.exe](assetId:///f9e130a6-8117-49c4-839c-c988f641dc14). Instead, you must use [Mage.exe](assetId:///77dfe576-2962-407e-af13-82255df725a1).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element is required for deployment manifests that target the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] runtime provided by [!INCLUDE[net_v40_short](../vs140/includes/net_v40_short_md.md)] or later. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element contains one or more <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements that specify the .NET Framework versions on which this application can run. The [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] runtime will run the application on the first available <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in this list.  
  
 The following table lists the attribute that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional. Specifies a URL where the preferred compatible .NET Framework version can be downloaded.|  
  
## framework  
 Required. The following table lists the attributes that the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Required. Specifies the version number of the target .NET Framework.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Required. Specifies the profile of the target .NET Framework.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Required. Specifies the version number of the runtime associated with the target .NET Framework.|  
  
## Remarks  
  
## Example  
 The following code example shows a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment manifest. This deployment can run on the [!INCLUDE[net_client_v40_long](../vs140/includes/net_client_v40_long_md.md)]. It can also run on the [!INCLUDE[net_v40_short](../vs140/includes/net_v40_short_md.md)] because it is a superset of the [!INCLUDE[net_client_v40_long](../vs140/includes/net_client_v40_long_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)