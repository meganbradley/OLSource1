---
title: "TN032: MFC Exception Mechanism"
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
  - "vc.mfc.exceptions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN032"
  - "MFC, exceptions"
  - "CException class, using"
ms.assetid: 0271f0aa-82cb-47a2-b7ea-e88126fc7e43
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN032: MFC Exception Mechanism
Previous versions of Visual C++ did not support the standard C++ exception mechanism, and MFC provided macros **TRY/CATCH/THROW** that were used instead. This version of Visual C++ fully supports C++ exceptions. This note covered some of the advanced implementation details of the previous macros including how to automatically cleanup stack based objects. Because C++ exceptions support stack unwinding by default, this technical note is no longer necessary.  
  
 Refer to [Exceptions: Using MFC Macros and C++ Exceptions](../VS_csharp/exceptions--using-mfc-macros-and-c---exceptions.md) for more information on the differences between the MFC macros and the new C++ keywords.  
  
## See Also  
 [Technical Notes by Number](../VS_csharp/technical-notes-by-number.md)   
 [Technical Notes by Category](../VS_csharp/technical-notes-by-category.md)