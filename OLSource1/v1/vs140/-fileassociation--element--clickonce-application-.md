---
title: "&lt;fileAssociation&gt; Element (ClickOnce Application)"
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
  - "<fileAssociation> element [ClickOnce application manifest]"
  - "manifests [ClickOnce], fileAssociation element"
ms.assetid: 8f951b4f-54f9-412e-a9e5-af4e379fcf08
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;fileAssociation&gt; Element (ClickOnce Application)
Identifies a file extension to be associated with the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is optional. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. The file extension to be associated with the application.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. A description of the file type for use by the shell.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Required. A name uniquely identifying the file type.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. Specifies the icon to use for files with this extension. The icon file must be specified by using the [\<file> element](../vs140/-file--element--clickonce-application-.md) within the [\<assembly> element](../vs140/-assembly--element--clickonce-application-.md) that contains this element.|  
  
## Remarks  
 This element must include an XML namespace reference to "urn:schemas-microsoft-com:clickonce.v1". If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element is used, it must come after the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element in its parent [\<assembly> element](../vs140/-assembly--element--clickonce-application-.md).  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will not overwrite existing file associations. However, a ClickOnce application can override the file extension for the current user only. After that ClickOnce application is uninstalled, ClickOnce deletes the file association for the user, and the per-machine association is active again.  
  
## Example  
 The following code example illustrates <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> elements in an application manifest for a text editor application deployed using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]. This code example also includes the [\<file> element](../vs140/-file--element--clickonce-application-.md) required by the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)