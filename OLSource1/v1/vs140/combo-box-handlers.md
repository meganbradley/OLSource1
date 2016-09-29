---
title: "Combo Box Handlers"
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
  - "ON_CBN_KILLFOCUS"
  - "ON_CBN_ERRSPACE"
  - "ON_CBN_EDITCHANGE"
  - "ON_CBN_CLOSEUP"
  - "ON_CBN_DBLCLK"
  - "ON_CBN_EDITUPDATE"
  - "ON_CBN_DROPDOWN"
  - "ON_CBN_SELENDOK"
  - "ON_CBN_SELCHANGE"
  - "ON_CBN_SETFOCUS"
  - "ON_CBN_SELENDCANCEL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_CBN_CLOSEUP"
  - "ON_CBN_SETFOCUS"
  - "ON_CBN_DBLCLK"
  - "ON_CBN_SELENDCANCEL"
  - "ON_CBN_DROPDOWN"
  - "ON_CBN_EDITUPDATE"
  - "ON_CBN_KILLFOCUS"
  - "combo boxes, handlers"
  - "ON_CBN_EDITCHANGE"
  - "ON_CBN_ERRSPACE"
  - "ON_CBN_SELENDOK"
  - "ON_CBN_SELCHANGE"
ms.assetid: 7f092412-01b7-4242-95ec-41ba506b9d71
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Combo Box Handlers
The following map entries correspond to the function prototypes.  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_CBN_CLOSEUP( <id\>, <memberFxn\> )|afx_msg void memberFxn( )|  
|ON_CBN_DBLCLK( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_DROPDOWN( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_EDITCHANGE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_EDITUPDATE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_ERRSPACE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_KILLFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_SELCHANGE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_SELENDCANCEL( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_SELENDOK( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_CBN_SETFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)