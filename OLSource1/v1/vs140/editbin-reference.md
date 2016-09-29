---
title: "EDITBIN Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "editbin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary data, editing"
  - "object files, modifying"
  - "EDITBIN program"
  - "COFF files, editing"
ms.assetid: efdda03b-3dfc-4d31-90e6-caf5b3977914
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EDITBIN Reference
The Microsoft COFF Binary File Editor (EDITBIN.EXE) modifies Common Object File Format (COFF) binary files. You can use EDITBIN to modify object files, executable files, and dynamic-link libraries (DLL).  
  
> [!NOTE]
>  You can start this tool only from the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] command prompt. You cannot start it from a system command prompt or from File Explorer.  
  
 EDITBIN is not available for use on files produced with the [/GL](../vs140/-gl--whole-program-optimization-.md) compiler option. Any modifications to binary files produced with /GL will have to be achieved by recompiling and linking.  
  
-   [EDITBIN command line](../vs140/editbin-command-line.md)  
  
-   [EDITBIN options](../vs140/editbin-options.md)  
  
## See Also  
 [C/C++ Build Tools](../vs140/c-c---build-tools.md)