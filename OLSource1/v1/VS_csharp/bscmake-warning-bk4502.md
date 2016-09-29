---
title: "BSCMAKE Warning BK4502"
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
  - "BK4502"
  - "BK1513"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BK1513"
  - "BK4502"
ms.assetid: ee412ec8-df03-4cdb-91ee-5d609ded8691
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BSCMAKE Warning BK4502
truncated .SBR file 'filename' not in filename  
  
 A zero-length .sbr file that was not originally part of the .bsc file was specified during an update.  
  
### To fix by checking the following possible causes  
  
1.  Wrong filename specified.  
  
2.  File deleted. (Error [BK1513](../VS_csharp/bscmake-error-bk1513.md) results.)  
  
3.  File corrupted, requiring BSCMAKE to do a full build.