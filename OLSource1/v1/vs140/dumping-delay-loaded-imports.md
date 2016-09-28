---
title: "Dumping Delay-Loaded Imports"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "delay-loaded imports, dumping"
  - "imports (delay-loaded)"
  - "delay-loaded imports"
ms.assetid: f766acf4-9df8-4b85-8cf6-0be3ffc4c124
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dumping Delay-Loaded Imports
Delay-loaded imports can be dumped using [dumpbin /imports](../vs140/-imports--dumpbin-.md) and show up with slightly different information than standard imports. They are segregated into their own section of the /imports dumping and are explicitly labeled as delay-loaded imports. If there is unload information present in the image, that is noted. If there is bind information present, the time/date stamp of the target DLL is noted along with the bound addresses of the imports.  
  
## See Also  
 [Linker Support for Delay-Loaded DLLs](../vs140/linker-support-for-delay-loaded-dlls.md)