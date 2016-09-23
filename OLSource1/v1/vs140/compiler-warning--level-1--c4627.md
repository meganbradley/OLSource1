---
title: "Compiler Warning (level 1) C4627"
ms.custom: na
ms.date: 09/23/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4627
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4627
ms.assetid: 8840f3e6-b496-423a-8635-eb55d5f854a2
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4627
'<identifier\>': skipped when looking for precompiled header use  
  
 While searching for the location where a precompiled header is used, the compiler encountered an `#include` directive for the *<identifier\>* include file. The compiler ignores the `#include` directive, but issues warning **C4627** if the precompiled header does not already contain the *<identifier\>* include file.  
  
## See Also  
 [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md)