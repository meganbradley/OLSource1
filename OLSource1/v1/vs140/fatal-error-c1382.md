---
title: "Fatal Error C1382"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C1382"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1382"
ms.assetid: 7a100f8c-3179-4927-a2f1-98de4c753850
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1382
the PCH file 'file' has been rebuilt since 'obj' was generated. Please rebuild this object  
  
 When using [/LTCG](../vs140/-ltcg--link-time-code-generation-.md), the compiler detected a .pch file that is newer than a CIL .obj that points to it. The information in the CIL .obj file is out of date. Rebuild the object.  
  
 C1382 can also occur if you compile with **/Yc**, but also pass multiple source code files to the compiler.  To resolve, do not use **/Yc** when passing multiple source code files to the compiler.  For more information, see [/Yc (Create Precompiled Header File)](../vs140/-yc--create-precompiled-header-file-.md).