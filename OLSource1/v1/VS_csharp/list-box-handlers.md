---
title: "List Box Handlers"
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
  - "ON_LBN_DBLCLK"
  - "ON_LBN_ERRSPACE"
  - "ON_LBN_SETFOCUS"
  - "ON_LBN_SELCHANGE"
  - "ON_LBN_KILLFOCUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "list boxes, list box handlers"
  - "ON_LBN_KILLFOCUS"
  - "ON_LBN_ERRSPACE"
  - "ON_LBN_SELCHANGE"
  - "ON_LBN_SETFOCUS"
  - "ON_LBN_DBLCLK"
ms.assetid: e4e54412-2167-436a-883b-5dcad01820b8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List Box Handlers
The following map entries have the corresponding function prototype.  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_LBN_DBLCLK( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_LBN_ERRSPACE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_LBN_KILLFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_LBN_SELCHANGE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_LBN_SETFOCUS( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
  
## See Also  
 [Message Maps](../VS_csharp/message-maps--mfc-.md)