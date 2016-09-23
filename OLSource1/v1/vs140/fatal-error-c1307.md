---
title: "Fatal Error C1307"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C1307
dev_langs: 
  - C++
helpviewer_keywords: 
  - C1307
ms.assetid: 6f77d3d4-ba8a-476c-b540-aff19eb4efc4
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Fatal Error C1307
program has been edited since profile data was collected  
  
 When using [/LTCG:PGOPTIMIZE](../vs140/-ltcg--link-time-code-generation-.md), the linker detected an input module that was recompiled after /LTCG:PGINSTRUMENT and that the module was changed to the point where existing profile data is no longer relevant. For example, if the call graph changed in the recompiled module, the compiler will generate C1307.  
  
 To resolve this error, run /LTCG:PGINSTRUMENT, redo all test runs, and run /LTCG:PGOPTIMIZE. If you cannot run /LTCG:PGINSTRUMENT and redo all test runs, use /LTCG:PGUPDATE instead of /LTCG:PGOPTIMIZE to create the optimized image.