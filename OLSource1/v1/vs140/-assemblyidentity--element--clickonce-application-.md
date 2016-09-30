---
title: "&lt;assemblyIdentity&gt; Element (ClickOnce Application)"
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
  - "<assemblyIdentity> element [ClickOnce application manifest]"
ms.assetid: f48e9531-efac-4d11-8166-f63a5ece1ac5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;assemblyIdentity&gt; Element (ClickOnce Application)
Identifies the application deployed in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is required. It contains no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. Identifies the name of the application.\<br />\<br /> If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains special characters, such as single or double quotes, the application may fail to activate.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required. Specifies the version number of the application in the following format: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> hash value of the public key under which the application or assembly is signed. The public key that is used to sign the catalog must be 2048 bits or greater.\<br />\<br /> Although signing an assembly is recommended but optional, this attribute is required. If an assembly is unsigned, you should copy a value from a self-signed assembly or use a "dummy" value of all zeros.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. Specifies the processor. The valid values are <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for all processors, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for 32-bit Windows, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for 64-bit Windows, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for Intel 64-bit Itanium processors.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Required. Identifies the two part language codes (for example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) of the assembly. This element is in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> namespace. If unspecified, the default is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
## Examples  
  
### Description  
 The following code example illustrates an <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest. This code example is part of a larger example provided in [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md).  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)   
 [\<assemblyIdentity> Element (ClickOnce Deployment)](../vs140/-assemblyidentity--element--clickonce-deployment-.md)