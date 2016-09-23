---
title: "Callback Functions Used by MFC"
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
  - vc.mfc.functions
dev_langs: 
  - C++
helpviewer_keywords: 
  - callback functions, MFC
  - MFC, callback functions
  - functions [C++], callback
  - callback functions
ms.assetid: b2a6857c-fdd3-45ec-8fd8-2e71fac77582
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Callback Functions Used by MFC
Three callback functions appear in the Microsoft Foundation Class Library. A description of callback functions that are passed to [CDC::EnumObjects](../vs140/cdc--enumobjects.md), [CDC::GrayString](../vs140/cdc--graystring.md), and [CDC::SetAbortProc](../vs140/cdc--setabortproc.md) follows this topic. For the general usage of the callback functions, see the Remarks section of these member functions. Note that all callback functions must trap MFC exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)