---
title: "-TLS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/TLS"
f1_keywords: 
  - "/TLS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/TLS dumpbin option"
  - "-TLS dumpbin option"
ms.assetid: 2b3f48f9-cac4-4351-b15c-2833b43bc709
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -TLS
Displays the IMAGE_TLS_DIRECTORY structure from an executable.  
  
## Remarks  
 /TLS displays the fields of the TLS structure as well as the addresses of the TLS callback functions.  
  
 If a program does not use thread local storage, its image will not contain a TLS structure.  See [thread](../vs140/thread.md) for more information.  
  
 IMAGE_TLS_DIRECTORY is defined in winnt.h.  
  
## See Also  
 [DUMPBIN Options](../vs140/dumpbin-options.md)