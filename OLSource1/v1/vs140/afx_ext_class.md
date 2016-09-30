---
title: "AFX_EXT_CLASS"
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
  - "afx_ext_class"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_EXT_CLASS macro"
ms.assetid: b8685760-6c2f-4445-9613-9753d37bd0fc
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_EXT_CLASS
[Extension DLLs](../vs140/extension-dlls--overview.md) use the macro **AFX_EXT_CLASS** to export classes; the executables that link to the extension DLL use the macro to import classes.  
  
## Remarks  
 With the **AFX_EXT_CLASS** macro, the same header file(s) used to build the extension DLL can be used with the executables that link to the DLL.  
  
 In the header file for your DLL, add the **AFX_EXT_CLASS** keyword to the declaration of your class as follows:  
  
 [!code[NVC_MFC_DLL#1](../vs140/codesnippet/CPP/afx_ext_class_1.cpp)]  
  
 For more information, see [Export and Import Using AFX_EXT_CLASS](../vs140/exporting-and-importing-using-afx_ext_class.md).  
  
## Requirements  
 Header: **afxv_**dll.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)