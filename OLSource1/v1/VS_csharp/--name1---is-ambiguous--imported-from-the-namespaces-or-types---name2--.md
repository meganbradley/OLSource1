---
title: "&#39;&lt;name1&gt;&#39; is ambiguous, imported from the namespaces or types &#39;&lt;name2&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30561"
  - "bc30561"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30561"
ms.assetid: 761091f7-1018-4299-b481-3966a4a2c126
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;name1&gt;&#39; is ambiguous, imported from the namespaces or types &#39;&lt;name2&gt;&#39;
You have provided a name that is ambiguous and therefore conflicts with another name. The [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] compiler does not have any conflict resolution rules; you must disambiguate names yourself.  
  
 **Error ID:** BC30561  
  
### To correct this error  
  
1.  Disambiguate the name by removing namespace imports.  
  
2.  Fully qualify the name.  
  
## See Also  
 [Imports Statement (.NET Namespace and Type)](../VS_csharp/imports-statement--.net-namespace-and-type-.md)   
 [Namespaces in Visual Basic](../VS_csharp/namespaces-in-visual-basic.md)   
 [Namespace Statement](../VS_csharp/namespace-statement.md)