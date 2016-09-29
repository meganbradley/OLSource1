---
title: "Fatal Error C1009"
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
  - "C1009"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1009"
ms.assetid: dcc8383c-3362-4c47-9c26-25d2451ebd53
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1009
compiler limit : macros nested too deeply  
  
 The compiler tried to expand too many macros at the same time. The compiler has a limit of 256 levels of nested macros. Split nested macros into simpler macros.