---
title: "Overridable CWinApp Member Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CWinApp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overriding, overridable functions in CWinApp"
  - "application class"
  - "CWinApp class, overridables"
ms.assetid: 07183d5e-734b-45d9-a8b6-9dde4adac0b4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overridable CWinApp Member Functions
[CWinApp](../vs140/cwinapp-class.md) provides several key overridable member functions (`CWinApp` overrides these members from class [CWinThread](../vs140/cwinthread-class.md), from which `CWinApp` derives):  
  
-   [InitInstance](../vs140/initinstance-member-function.md)  
  
-   [Run](../vs140/run-member-function.md)  
  
-   [ExitInstance](../vs140/exitinstance-member-function.md)  
  
-   [OnIdle](../vs140/onidle-member-function.md)  
  
 The only `CWinApp` member function that you must override is `InitInstance`.  
  
## See Also  
 [CWinApp: The Application Class](../vs140/cwinapp--the-application-class.md)