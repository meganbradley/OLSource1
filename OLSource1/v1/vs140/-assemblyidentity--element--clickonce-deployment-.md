---
title: "&lt;assemblyIdentity&gt; Element (ClickOnce Deployment)"
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
  - "urn:schemas-microsoft-com:asm.v2#assemblyIdentity"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<assemblyIdentity> element [ClickOnce deployment manifest]"
ms.assetid: f4a3bb83-c800-47d0-9905-9a5ae2486838
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;assemblyIdentity&gt; Element (ClickOnce Deployment)
Identifies the primary assembly of the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is required. It contains no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. Identifies the human-readable name of the deployment for informational purposes.\<br />\<br /> If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains special characters, such as single or double quotes, the application may fail to activate.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required. Specifies the version number of the assembly, in the following format: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.\<br />\<br /> This value must be incremented in an updated manifest to trigger an application update.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Required. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the SHA-1 hash value of the public key under which the deployment manifest is signed. The public key that is used to sign must be 2048 bits or greater.\<br />\<br /> Although signing an assembly is recommended but optional, this attribute is required. If an assembly is unsigned, you should copy a value from a self-signed assembly or use a "dummy" value of all zeros.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. Specifies the processor. The valid values are <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for all processors, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for 32-bit Windows, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for 64-bit Windows, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for Intel 64-bit Itanium processors.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Required. For compatibility with Windows side-by-side installation technology. The only allowed value is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
  
## Remarks  
  
## Example  
 The following code example illustrates an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment manifest. This code example is part of a larger example provided for the [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md) topic.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)   
 [\<assemblyIdentity> Element (ClickOnce Application)](../vs140/-assemblyidentity--element--clickonce-application-.md)