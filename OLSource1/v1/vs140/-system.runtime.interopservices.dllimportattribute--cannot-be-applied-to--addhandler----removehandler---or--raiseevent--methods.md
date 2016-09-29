---
title: "&#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to &#39;AddHandler&#39;, &#39;RemoveHandler&#39;, or &#39;RaiseEvent&#39; methods"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc31531"
  - "vbc31531"
helpviewer_keywords: 
  - "BC31531"
ms.assetid: 0ea3a16c-cfe0-4cb5-b740-358679272f8d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;System.Runtime.InteropServices.DllImportAttribute&#39; cannot be applied to &#39;AddHandler&#39;, &#39;RemoveHandler&#39;, or &#39;RaiseEvent&#39; methods
The `DllImportAttribute` attribute was applied to an `AddHandler`, `RemoveHandler`, or `RaiseEvent` method declaration. This attribute can only be used with an empty `Function` or `Sub`.  
  
 **Error ID:** BC31531  
  
### To correct this error  
  
-   Remove the `DllImportAttribute` attribute from the method declaration.  
  
## See Also  
 <xref:System.Runtime.InteropServices.DllImportAttribute*>   
 [Event Statement](../vs140/event-statement.md)   
 [AddHandler - delete](assetId:///fc464cf8-582c-48a6-a9c2-185c4c3d5ff8)   
 [RemoveHandler - delete](assetId:///35c17f61-6e22-4b87-b6e1-3ed0c27a88a0)   
 [RaiseEvent - delete](assetId:///7f765da0-5491-40b6-9ed5-24c98f9daad9)