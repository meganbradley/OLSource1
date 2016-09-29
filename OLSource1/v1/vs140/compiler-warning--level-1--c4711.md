---
title: "Compiler Warning (level 1) C4711"
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
  - "C4711"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4711"
ms.assetid: 270506ab-fead-4328-b714-2978113be238
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4711
function 'function' selected for inline expansion  
  
 The compiler performed inlining on the given function, although it was not marked for inlining.  
  
 C4711 is enabled if [/Ob2](../vs140/-ob--inline-function-expansion-.md) is specified.  
  
 Inlining is performed at the compiler's discretion. This warning is informational.  
  
 This warning is off by default. To enable a warning, use [#pragma warning](../vs140/warning.md). See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.