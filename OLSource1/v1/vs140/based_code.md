---
title: "BASED_CODE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - BASED_CODE
dev_langs: 
  - C++
helpviewer_keywords: 
  - BASED_CODE macro
ms.assetid: 32339772-53f4-4d28-92ae-2e8a9adfeae8
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BASED_CODE
Under Win32, this macro expands to nothing and is provided for backward compatibility.  
  
 Under 16-bit MFC, the macro ensures that data will be placed in the code segment rather than in the data segment. The result is less impact on your data segment.  
  
## Requirements  
 **Header:** afxver_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)