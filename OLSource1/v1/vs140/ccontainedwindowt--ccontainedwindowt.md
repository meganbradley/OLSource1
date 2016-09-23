---
title: "CContainedWindowT::CContainedWindowT"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CContainedWindow.CContainedWindow
  - CContainedWindowT::CContainedWindowT
  - ATL::CContainedWindowT::CContainedWindowT
  - ATL.CContainedWindowT.CContainedWindowT
  - CContainedWindowT.CContainedWindowT
  - CContainedWindow::CContainedWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - CContainedWindow constructor
  - CContainedWindow class, constructor
  - CContainedWindowT constructor
  - CContainedWindowT class, constructor
ms.assetid: 0d7612b6-2aae-4403-8356-07302520e5f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CContainedWindowT::CContainedWindowT
The constructor initializes data members.  
  
## Syntax  
  
```  
  
      CContainedWindowT(  
   LPTSTR lpszClassName,  
   CMessageMap* pObject,  
   DWORD dwMsgMapID = 0   
);  
CContainedWindowT( CMessageMap* pObject, DWORD dwMsgMapID = 0 )  
CContainedWindowT( );  
```  
  
#### Parameters  
 `lpszClassName`  
 [in] The name of an existing window class on which the contained window will be based.  
  
 `pObject`  
 [in] A pointer to the containing object that declares the message map. This object's class must derive from [CMessageMap](../vs140/cmessagemap-class.md).  
  
 `dwMsgMapID`  
 [in] Identifies the message map that will process the contained window's messages. The default value, 0, specifies the default message map declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). To use an alternate message map declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), pass `msgMapID`.  
  
## Remarks  
 If you want to create a new window through [Create](../vs140/ccontainedwindowt--create.md), you must pass the name of an existing window class for the `lpszClassName` parameter. For an example, see the [CContainedWindow](../vs140/ccontainedwindowt-class.md) overview.  
  
 There are three constructors:  
  
-   The constructor with three arguments is the one typically called.  
  
-   The constructor with two arguments uses the class name from **TBase::GetWndClassName**.  
  
-   The constructor with no arguments is used if you want to supply the arguments later. You must supply the window class name, message map object, and message map ID when you later call **Create**.  
  
 If you subclass an existing window through [SubclassWindow](../vs140/ccontainedwindowt--subclasswindow.md), the `lpszClassName` value will not be used; therefore, you can pass **NULL** for this parameter.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CContainedWindowT::m_lpszClassName](../vs140/ccontainedwindowt--m_lpszclassname.md)   
 [CContainedWindowT::m_pObject](../vs140/ccontainedwindowt--m_pobject.md)   
 [CContainedWindowT::m_pfnSuperWindowProc](../vs140/ccontainedwindowt--m_pfnsuperwindowproc.md)   
 [CContainedWindowT::SwitchMessageMap](../vs140/ccontainedwindowt--switchmessagemap.md)