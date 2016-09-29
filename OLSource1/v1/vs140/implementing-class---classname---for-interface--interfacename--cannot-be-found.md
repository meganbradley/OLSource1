---
title: "Implementing class &#39;&lt;classname&gt;&#39; for interface &lt;interfacename&gt; cannot be found"
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
  - "vbc31094"
  - "bc31094"
helpviewer_keywords: 
  - "BC31094"
ms.assetid: 262cb67e-2930-4a4a-a63e-bb2e201b3b93
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing class &#39;&lt;classname&gt;&#39; for interface &lt;interfacename&gt; cannot be found
An implementing class in the interop assembly is not available.  
  
 **Error ID:** BC31094  
  
### To correct this error  
  
1.  Verify that the type library for the COM object is valid.  
  
2.  Use the Type Library Importer (Tlbimp.exe) to manually create an interop assembly, and then add a reference to that interop assembly from your project.  
  
## See Also  
 [Implements Statement](../vs140/implements-statement.md)   
 [COM Interop](../vs140/com-interop--visual-basic-.md)   
 [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382)