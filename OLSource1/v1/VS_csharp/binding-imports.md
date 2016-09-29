---
title: "Binding Imports"
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
  - "/DELAY:NOBIND linker option"
  - "DELAY:NOBIND linker option"
ms.assetid: bb766038-deb1-41b1-bcbc-29a30e8c1e2a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Binding Imports
The default linker behavior is to create a bindable import address table for the delay-loaded DLL. If the DLL is bound, the helper function will attempt to use the bound information instead of calling **GetProcAddress** on each of the referenced imports. If either the timestamp or the preferred address do not match those of the loaded DLL, the helper function will assume the bound import address table is out of date and will proceed as if it does not exist.  
  
 If you never intend to bind the DLL's delay-loaded imports, specifying [/delay](../VS_csharp/-delay--delay-load-import-settings-.md):nobind on the linker's command line will prevent the bound import address table from being generated and consuming space in the image file.  
  
## See Also  
 [Linker Support for Delay-Loaded DLLs](../VS_csharp/linker-support-for-delay-loaded-dlls.md)