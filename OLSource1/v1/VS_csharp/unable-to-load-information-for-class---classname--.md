---
title: "Unable to load information for class &#39;&lt;classname&gt;&#39;"
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
  - "vbc30712"
  - "bc30712"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30712"
ms.assetid: c7ffbd6d-05c6-4261-b44b-1bcd521bb350
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unable to load information for class &#39;&lt;classname&gt;&#39;
A reference was made to a class that is not available.  
  
 **Error ID:** BC30712  
  
### To correct this error  
  
1.  Verify that the class is defined and that you spelled the name correctly.  
  
2.  Try accessing one of the members declared in the module. In some cases, the debugging environment cannot locate members because the modules where they are declared have not been loaded yet.  
  
## See Also  
 [Debugging in Visual Studio](../VS_csharp/debugging-in-visual-studio.md)