---
title: "Fatal Error C1099"
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
  - "C1099"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1099"
ms.assetid: c050b074-a06a-4026-9e10-569029cc0739
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1099
Edit and Continue engine terminating compile  
  
 Edit and Continue loaded a precompiled header file in preparation for compiling code changes, but subsequent actions (such as code changes prior to the precompiled header `#include` statement or stopping the debugger) prevented Edit and Continue from finishing the compile with that process. You do not need to take any action to fix this error.