---
title: "Compiler Warning (level 1) C4086"
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
  - "C4086"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4086"
ms.assetid: 9248831b-22bf-47af-8684-bfadb17e94fc
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4086
expected pragma parameter to be '1', '2', '4', '8', or '16'  
  
 The pragma parameter does not have the required value (1, 2, 4, 8, or 16).  
  
## Example  
  
```  
// C4086.cpp  
// compile with: /W1 /LD  
#pragma pack( 3 ) // C4086  
```