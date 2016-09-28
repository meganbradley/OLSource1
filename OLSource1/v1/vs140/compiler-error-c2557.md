---
title: "Compiler Error C2557"
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
  - "C2557"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2557"
ms.assetid: 48a33d82-aa16-4658-b346-2311fcb39864
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2557
'identifier' : private and protected members cannot be initialized without a constructor  
  
 Only members and friends can assign a value to a private or protected member. Nonpublic members should be initialized in the class constructor.