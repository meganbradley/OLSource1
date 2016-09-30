---
title: "Precompiled Header Consistency Rules"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "precompiled header files, consistency rules"
ms.assetid: 844b1a14-5b0b-4276-a1f5-cc62f13f6dda
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Precompiled Header Consistency Rules
This section discusses guidelines that will help you use precompiled headers more efficiently:  
  
-   [Consistency Rules for Per-File Use of Precompiled Headers](../vs140/consistency-rules-for-per-file-use-of-precompiled-headers.md)  
  
-   [Consistency Rules for /Yc and /Yu](../vs140/consistency-rules-for--yc-and--yu.md)  
  
 Because PCH files contain information about the machine environment as well as memory address information about the program, you should only use a PCH file on the machine where it was created.  
  
## See Also  
 [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)