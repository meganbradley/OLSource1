---
title: "Linker Tools Error LNK1200"
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
  - LNK1200
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK1200
ms.assetid: 55771145-915e-4006-ac6c-ac702041eb2f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Error LNK1200
error reading program database 'filename'  
  
 The program database (PDB) could not be read.  
  
 This error can be caused by file corruption.  
  
 If `filename` is the PDB for an object file, recompile the object file using [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md).  
  
 If `filename` is the PDB for the main output file, and this error occurred during an incremental link, delete the PDB and relink.