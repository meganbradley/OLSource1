---
title: "&lt;description&gt; Element (ClickOnce Deployment)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#description"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<description> element [ClickOnce deployment manifest]"
ms.assetid: 18f6919e-a3ab-4942-a57d-167fabfac44e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;description&gt; Element (ClickOnce Deployment)
Identifies application information used to create a shell presence and an **Add or Remove Programs** item in Control Panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is required and is in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> namespace. It contains no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Identifies the company name used for icon placement in the Windows **Start** menu and the **Add or Remove Programs** item in Control Panel, when the deployment is configured for install.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required. Identifies the full product name. Used as the title for the icon installed in the Windows **Start** menu.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Optional. Identifies a subfolder within the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> folder in the Windows **Start** menu.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Optional. Specifies a support URL that is shown in the **Add or Remove Programs** item in Control Panel. A shortcut to this URL is also created for application support in the Windows **Start** menu, when the deployment is configured for installation.|  
  
## Remarks  
 The description element is required in all deployment configurations.  
  
## Example  
 The following code example illustrates a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment manifest. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md) topic.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)