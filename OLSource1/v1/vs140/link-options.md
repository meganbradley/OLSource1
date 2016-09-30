---
title: "Link Options"
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
  - "C"
helpviewer_keywords: 
  - "nothrownew.obj"
  - "newmode.obj"
  - "noenv.obj"
  - "psetargv.obj"
  - "loosefpmath.obj"
  - "smallheap.obj"
  - "fp10.obj"
  - "nochkclr.obj"
  - "chkstk.obj"
  - "pcommode.obj"
  - "pnoenv.obj"
  - "link options [C++]"
  - "invalidcontinue.obj"
  - "pnothrownew.obj"
  - "pwsetargv.obj"
  - "pinvalidcontinue.obj"
  - "wsetargv.obj"
  - "binmode.obj"
  - "setargv.obj"
  - "noarg.obj"
  - "pnewmode.obj"
  - "commode.obj"
  - "pthreadlocale.obj"
  - "pbinmode.obj"
  - "threadlocale.obj"
  - "pnoarg.obj"
ms.assetid: 05b5a77b-9dd1-494b-ae46-314598c770bb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Link Options
The CRT lib directory includes a number of small object files that enable specific CRT features without any code change. These are called "link options" since you just have to add them to the linker command line to use them.  
  
 Pure mode versions have been added. Use the regular versions for native and /clr code, use the pure versions (prefixed with a p) for /clr:pure mode.  
  
|Native and /clr|Pure mode|Description|  
|----------------------|---------------|-----------------|  
|binmode.obj|pbinmode.obj|Sets the default file-translation mode to binary. See [_fmode](../vs140/_fmode.md).|  
|chkstk.obj|n/a|Provides stack-checking and alloca support when not using the CRT.|  
|commode.obj|pcommode.obj|Sets the global commit flag to "commit". See [fopen, _wfopen](../vs140/fopen--_wfopen.md) and [fopen_s, _wfopen_s](../vs140/fopen_s--_wfopen_s.md).|  
|fp10.obj|n/a|Changes the default precision control to 64 bits. See [Floating-Point Support](../vs140/floating-point-support.md).|  
|invalidcontinue.obj|pinvalidcontinue.obj|Sets a default invalid parameter handler that does nothing, meaning that invalid parameters passed to CRT functions will just set errno and return an error result.|  
|loosefpmath.obj|n/a|Ensures that floating point code tolerates denormal values.|  
|newmode.obj|pnewmode.obj|Causes [malloc](../vs140/malloc.md) to call the new handler on failure. See [_set_new_mode](../vs140/_set_new_mode.md), [_set_new_handler](../vs140/_set_new_handler.md), [calloc](../vs140/calloc.md), and [realloc](../vs140/realloc.md).|  
|noarg.obj|pnoarg.obj|Disables all processing of argc and argv.|  
|nochkclr.obj|n/a|Does nothing. Remove from your project.|  
|noenv.obj|pnoenv.obj|Disables the creation of a cached environment for the CRT.|  
|nothrownew.obj|pnothrownew.obj|Enables the non-throwing version of new in the CRT. See [The new and delete Operators](../vs140/new-and-delete-operators.md).|  
|setargv.obj|psetargv.obj|Enables command-line argument wildcard expansion. See [Expanding Wildcard Arguments](../vs140/expanding-wildcard-arguments.md).|  
|smalheap.obj|n/a|Installs a very simple small heap manager.|  
|threadlocale.obj|pthreadlocale.obj|Enables per-thread locale for all new threads by default.|  
|wsetargv.obj|pwsetargv.obj|Enables command-line argument wildcard expansion. See [Expanding Wildcard Arguments](../vs140/expanding-wildcard-arguments.md).|  
  
## See Also  
 [C Run-Time Libraries](../vs140/crt-library-features.md)