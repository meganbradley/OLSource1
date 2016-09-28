---
title: "Fatal Error C1603"
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
  - "C1603"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1603"
ms.assetid: e5a06925-f916-4637-8240-6d2d280e6124
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1603
inline assembly branch target out of range by 'number' bytes  
  
 The computed distance between a JCXZ or JECXZ instruction and its specified target label was greater than 128 bytes. Update your code so that the label is closer to the instruction.