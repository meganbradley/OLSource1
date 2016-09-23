---
title: "NMAKE Fatal Error U1056"
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
  - U1056
dev_langs: 
  - C++
helpviewer_keywords: 
  - U1056
ms.assetid: da855728-b69e-413c-83ed-df912126215e
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# NMAKE Fatal Error U1056
cannot find command processor  
  
 The command processor was not in the path specified in the **COMSPEC** or **PATH** environment variables.  
  
 NMAKE uses COMMAND.COM or CMD.EXE as a command processor when executing commands. It looks for the command processor first in the path set in **COMSPEC**. If **COMSPEC** does not exist, NMAKE searches the directories specified in **PATH**.