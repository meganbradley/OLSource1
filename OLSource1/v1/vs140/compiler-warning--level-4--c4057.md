---
title: "Compiler Warning (level 4) C4057"
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
  - "C4057"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4057"
ms.assetid: e75d0645-84c9-4bef-a812-942ed9879aa3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4057
'operator' : 'identifier1' indirection to slightly different base types from 'identifier2'  
  
 Two pointer expressions refer to different base types. The expressions are used without conversion.  
  
### To fix by checking the following possible causes  
  
1.  Mixing signed and unsigned types.  
  
2.  Mixing **short** and **long** types.