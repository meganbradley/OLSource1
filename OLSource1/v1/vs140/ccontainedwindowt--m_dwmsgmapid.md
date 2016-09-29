---
title: "CContainedWindowT::m_dwMsgMapID"
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
  - "CContainedWindowT.m_dwMsgMapID"
  - "ATL::CContainedWindowT::m_dwMsgMapID"
  - "ATL.CContainedWindowT.m_dwMsgMapID"
  - "CContainedWindow.m_dwMsgMapID"
  - "CContainedWindow::m_dwMsgMapID"
  - "m_dwMsgMapID"
  - "CContainedWindowT::m_dwMsgMapID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwMsgMapID"
ms.assetid: 0a513438-4858-4449-ab45-522341008988
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::m_dwMsgMapID
Holds the identifier of the message map currently being used for the contained window.  
  
## Syntax  
  
```  
  
DWORD m_dwMsgMapID;  
  
```  
  
## Remarks  
 This message map must be declared in the containing object.  
  
 The default message map, declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md), is always identified by zero. An alternate message map, declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), is identified by `msgMapID`.  
  
 `m_dwMsgMapID` is first initialized by the constructor and can be changed by calling [SwitchMessageMap](../vs140/ccontainedwindowt--switchmessagemap.md). For an example, see the [CContainedWindowT Overview](../vs140/ccontainedwindowt-class.md).  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::m_pObject](../vs140/ccontainedwindowt--m_pobject.md)