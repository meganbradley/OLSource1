---
title: "Fatal Error C1051"
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
  - C1051
dev_langs: 
  - C++
helpviewer_keywords: 
  - C1051
ms.assetid: 87dcbd3b-0952-499a-bd42-64f9e8de2605
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Fatal Error C1051
program database file, 'pdbfile', has an obsolete format, delete it and recompile  
  
 The compiler cannot update the program database file, which has an older version number. Delete the file and recompile your program with **/Zi** or **/ZI**. For more information, see [/Z7, /Zd, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md)