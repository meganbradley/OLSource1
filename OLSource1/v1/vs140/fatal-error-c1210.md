---
title: "Fatal Error C1210"
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
  - "C1210"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1210"
ms.assetid: e2208309-c284-425c-a7e8-48e96e66f35b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1210
/clr:pure and /clr:safe are not supported by the version of the runtime installed  
  
 C1210 occurs when you have a compiler for the current release, but a common language runtime from a previous release.  
  
 Some functionality of the compiler may not work on a previous version of the run time.  
  
 To resolve C1210 install the common language runtime version that is intended for use with your compiler.