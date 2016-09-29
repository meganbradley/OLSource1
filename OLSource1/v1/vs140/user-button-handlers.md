---
title: "User Button Handlers"
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
  - "ON_BN_HILITE"
  - "ON_BN_DOUBLECLICKED"
  - "ON_BN_CLICKED"
  - "ON_BN_PAINT"
  - "ON_BN_DISABLE"
  - "ON_BN_UNHILITE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_BN_PAINT"
  - "user buttons"
  - "ON_BN_DOUBLECLICKED"
  - "ON_BN_DISABLE"
  - "ON_BN_UNHILITE"
  - "ON_BN_HILITE"
  - "ON_BN_CLICKED"
ms.assetid: 410ea968-478f-4806-b7b8-5d7c8dc2bf42
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User Button Handlers
The following map entries correspond to the function prototypes.  
  
|Map entry|Function prototype|  
|---------------|------------------------|  
|ON_BN_CLICKED( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_BN_DISABLE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_BN_DOUBLECLICKED( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_BN_HILITE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_BN_PAINT( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
|ON_BN_UNHILITE( <id\>, <memberFxn\> )|afx_msg void memberFxn( );|  
  
## See Also  
 [Message Maps](../vs140/message-maps--mfc-.md)