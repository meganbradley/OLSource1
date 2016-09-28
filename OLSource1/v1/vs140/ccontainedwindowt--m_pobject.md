---
title: "CContainedWindowT::m_pObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CContainedWindowT.m_pObject"
  - "m_pObject"
  - "CContainedWindow.m_pObject"
  - "ATL::CContainedWindowT::m_pObject"
  - "ATL.CContainedWindowT.m_pObject"
  - "CContainedWindowT::m_pObject"
  - "CContainedWindow::m_pObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pObject"
ms.assetid: deb78a2c-8e32-41b3-94f8-61b382fc2b76
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::m_pObject
Points to the object containing the `CContainedWindowT` object.  
  
## Syntax  
  
```  
  
CMessageMap* m_pObject;  
  
```  
  
## Remarks  
 This container, whose class must derive from [CMessageMap](../vs140/cmessagemap-class.md), declares the message map used by the contained window.  
  
 `m_pObject` is initialized by the constructor. For an example, see the [CContainedWindowT](../vs140/ccontainedwindowt-class.md) overview.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::m_dwMsgMapID](../vs140/ccontainedwindowt--m_dwmsgmapid.md)