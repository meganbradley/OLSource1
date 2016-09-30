---
title: "MSBuild Special Characters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "escape characters"
  - "escape"
  - "MSBuild Escape Characters"
ms.assetid: 545e6a59-1093-4514-935e-78679a46fb3c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Special Characters
[!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] reserves some characters for special use in specific contexts. You only have to escape such characters if you want to use them literally in the context in which they are reserved. For example, an asterisk has special meaning only in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> attributes of an item definition, and in calls to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If you want an asterisk to appear as an asterisk in one of those contexts, you must escape it. In every other context, just type the asterisk where you want it to appear.  
  
 To escape a special character, use the syntax %*xx*, where *xx* represents the ASCII hexadecimal value of the character. For more information, see [How to: Escape Special Characters in MSBuild](../vs140/how-to--escape-special-characters-in-msbuild.md).  
  
## Special Characters  
 The following table lists [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] special characters:  
  
|**Character**|**ASCII**|**Reserved Usage**|  
|-------------------|---------------|------------------------|  
|%|%25|Referencing metadata|  
|$|%24|Referencing properties|  
|@|%40|Referencing item lists|  
|'|%27|Conditions and other expressions|  
|;|%3B|List separator|  
|?|%3F|Wildcard character for file names in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attributes|  
|*|%2A|Wildcard character for use in file names in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attributes|  
  
## See Also  
 [MSBuild Advanced Topics](../vs140/msbuild-advanced-concepts.md)   
 [MSBuild Items](../vs140/msbuild-items.md)