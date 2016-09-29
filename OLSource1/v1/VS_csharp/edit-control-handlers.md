---
title: "Edit Control Handlers"
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
  - "ON_EN_ERRSPACE"
  - "ON_EN_UPDATE"
  - "ON_EN_VSCROLL"
  - "ON_EN_HSCROLL"
  - "ON_EN_KILLFOCUS"
  - "ON_EN_MAXTEXT"
  - "ON_EN_SETFOCUS"
  - "ON_EN_CHANGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_EN_ERRSPACE macro"
  - "ON_EN_SETFOCUS macro"
  - "ON_EN_UPDATE macro"
  - "ON_EN_MAXTEXT macro"
  - "ON_EN_CHANGE macro"
  - "ON_EN_HSCROLL macro"
  - "ON_EN_VSCROLL macro"
  - "ON_EN_KILLFOCUS macro"
  - "edit controls, edit control handlers"
ms.assetid: 55b88b5e-12b5-4422-b03e-c8c2f27d095c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Edit Control Handlers
The following map entries correspond to the function prototype.  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_EN_CHANGE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_ERRSPACE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_HSCROLL( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_KILLFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_MAXTEXT( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_SETFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_UPDATE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_EN_VSCROLL( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
  
## See Also  
 [Message Maps](../VS_csharp/message-maps--mfc-.md)