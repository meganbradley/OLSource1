---
title: "&#39;Imports&#39; statements must precede any declarations"
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
  - "vbc30465"
  - "bc30465"
helpviewer_keywords: 
  - "BC30465"
ms.assetid: 726365f6-d6fc-454a-a43b-afa41bfea82a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Imports&#39; statements must precede any declarations
An `Imports` statement follows a declaration statement within a source file.  
  
 The `Imports` statement imports namespace names from referenced projects and assemblies, as well as namespace names defined within the same project as the one in which it appears. `Imports` statements must be placed in a source file before any references to identifiers.  
  
 **Error ID:** BC30465  
  
### To correct this error  
  
-   Move the `Imports` statement to the top of the source file, before any declaration statements.  
  
## See Also  
 [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md)