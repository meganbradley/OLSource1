---
title: "&lt;assembly&gt; Element (ClickOnce Application)"
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
  - "<assembly> element [ClickOnce application manifest]"
ms.assetid: 51410569-10f9-4c0a-96b5-d39185edbefc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;assembly&gt; Element (ClickOnce Application)
The top-level element for the application manifest.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is the root element and is required. Its first contained element must be an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element. The manifest elements must be in one of the following namespaces:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 Child elements of the assembly must also be in these namespaces, by inheritance or by tagging.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Required. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute must be set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
  
## Example  
 The following code example illustrates an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element in an application manifest for a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. This code example is part of a larger example provided in [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)   
 [\<assembly> Element (ClickOnce Deployment)](../vs140/-assembly--element--clickonce-deployment-.md)