---
title: "&lt;assembly&gt; Element (ClickOnce Deployment)"
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
  - "urn:schemas-microsoft-com:asm.v2#assembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<assembly> element [ClickOnce deployment manifest]"
ms.assetid: b8e3362a-f821-4696-b98d-571d4bbfe431
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;assembly&gt; Element (ClickOnce Deployment)
The top-level element for the deployment manifest.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is the root element and is required. Its first contained element must be an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element. The manifest elements must be in the following namespaces: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Child elements of the assembly must also be in these namespaces, by inheritance or by tagging.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. This attribute must be set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
  
## Example  
 The following code example illustrates an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element in a deployment manifest for an application deployed using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md) topic.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)   
 [\<assembly> Element (ClickOnce Application)](../vs140/-assembly--element--clickonce-application-.md)