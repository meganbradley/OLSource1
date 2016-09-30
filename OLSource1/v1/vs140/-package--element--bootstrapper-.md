---
title: "&lt;Package&gt; Element (Bootstrapper)"
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
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<package> element [bootstrapper]"
ms.assetid: ecd06658-ad02-4440-bccd-88437b7fb816
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;Package&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is the top-level XML element inside of a package file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element is required. It has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Defines the culture for this package, which determines the language to be used. This attribute is a key into the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element, which lists culture-specific strings for product names and error messages during the installation.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. The name of the package displayed to the developer within a tool such as [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. This attribute is a key into the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element, which should contain a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> properties set to match the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> properties of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. Specifies the name of the file in the distribution package which contains the End-User License Agreement (EULA).  This file can be either plain text (.txt) or Rich Text Format. (.rtf)|  
  
## Example  
 The following code example shows a complete package file for redistributing the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)