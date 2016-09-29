---
title: "Fatal Error C1208"
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
  - "C1208"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1208"
ms.assetid: 4eefd8f0-5c2e-4a11-9e63-293e1139db65
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1208
Allocating reference classes on the stack is not supported by the version of the runtime installed  
  
 C1208 occurs when you have a compiler for the current release, but a common language runtime from a previous release.  
  
 Some functionality of the compiler may not work on a previous version of the run time.  
  
 Install the common language runtime version that is intended for use with your compiler.