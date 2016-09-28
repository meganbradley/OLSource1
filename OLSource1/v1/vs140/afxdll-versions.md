---
title: "AFXDLL Versions"
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
  - "afxdll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC DLLs [C++], dynamic linking to library"
  - "AFXDLL library"
  - "application wizards [C++], default uses AFXDLL"
  - "MFC libraries [C++], dynamic linking"
  - "MFC [C++], AFXDLL version"
  - "DLL version of MFC [C++]"
ms.assetid: c078ae8f-85a9-43cb-9ded-c09ca2c45723
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFXDLL Versions
Instead of building your application by statically linking to the MFC object-code libraries, you can build your application to use one of the AFXDLL libraries, which contain MFC in a DLL that multiple running applications can share. For a table of AFXDLL names, see [DLLs: Naming Conventions](../vs140/naming-conventions-for-mfc-dlls.md).  
  
> [!NOTE]
>  By default, the MFC Application Wizard creates an AFXDLL project. To use static linking of MFC code instead, set the **Use MFC in a static library** option in the MFC Application Wizard. Static linking is not available in the Standard Edition of Visual C++.  
  
## See Also  
 [MFC Library Versions](../vs140/mfc-library-versions.md)