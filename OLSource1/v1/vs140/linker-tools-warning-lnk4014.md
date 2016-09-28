---
title: "Linker Tools Warning LNK4014"
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
  - "LNK4014"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4014"
ms.assetid: 394903e9-3ded-4ea4-b7c0-a3535d4b4da4
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4014
cannot find member object "objectname"  
  
 LIB could not find `objectname` in the library.  
  
 The **/REMOVE** and **/EXTRACT** options require the full name of the member object that is to be deleted or copied to a file. The full name includes the path of the original object file. To see the full names of member objects in a library, use DUMPBIN [/ARCHIVEMEMBERS](../vs140/-archivemembers.md) or LIB [/LIST](../vs140/managing-a-library.md).