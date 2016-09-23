---
title: "Compiler Warning (level 1) C4651"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4651
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4651
ms.assetid: f1ea82aa-4dc1-4972-b55a-57fdb962f0dd
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4651
'definition' specified for precompiled header but not for current compile  
  
 The definition was specified when the precompiled header was generated, but not in this compilation.  
  
 The definition will be in effect inside the precompiled header, but not in the rest of the code.  
  
 If a precompiled header was built with /DSYMBOL, the compiler will generate this warning if the /Yu compile doesn't have /DSYMBOL.  Adding /DSYMBOL to the /Yu command line resolves this warning.