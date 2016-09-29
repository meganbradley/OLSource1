---
title: "Fatal Error C1091"
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
  - "C1091"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1091"
ms.assetid: 812d4201-9154-48b0-b9af-5959c082ca33
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1091
compiler limit: string exceeds 'length' bytes in length  
  
 A string constant exceeded the current limit on the length of strings.  
  
 You might want to split the static string into two (or more) variables and use [strcpy_s](../VS_csharp/strcpy_s--wcscpy_s--_mbscpy_s.md) to join the result as part of the declaration or during run time.