---
title: "CAnimationManagerEventHandler Class"
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
  - "afxanimationcontroller/CAnimationManagerEventHandler"
  - "CAnimationManagerEventHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationManagerEventHandler class"
ms.assetid: 6089ec07-e661-4805-b227-823b4652aade
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationManagerEventHandler Class
Implements a callback, which is called by the Animation API when a status of an animation manager is changed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationManagerEventHandler::CAnimationManagerEventHandler](#canimationmanagereventhandler__canimationmanagereventhandler)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationManagerEventHandler::CreateInstance](#canimationmanagereventhandler__createinstance)|Creates an instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|[CAnimationManagerEventHandler::OnManagerStatusChanged](#canimationmanagereventhandler__onmanagerstatuschanged)|Called when a status of animation manager has changed. (Overrides <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.)|  
|[CAnimationManagerEventHandler::SetAnimationController](#canimationmanagereventhandler__setanimationcontroller)|Stores a pointer to animation controller to route events.|  
  
## Remarks  
 This event handler is created and passed to IUIAnimationManager::SetManagerEventHandler method, when you call CAnimationController::EnableAnimationManagerEvent.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationmanagereventhandler__canimationmanagereventhandler">\</a>  CAnimationManagerEventHandler::CAnimationManagerEventHandler  
 [!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Constructs a CAnimationManagerEventHandler object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="canimationmanagereventhandler__createinstance">\</a>  CAnimationManagerEventHandler::CreateInstance  
 [!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Creates an instance of CAnimationManagerEventHandler object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Output. If the method succeeds it contains a pointer to COM object that will handle status updates to an animation manager.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="canimationmanagereventhandler__onmanagerstatuschanged">\</a>  CAnimationManagerEventHandler::OnManagerStatusChanged  
 [!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Called when a status of animation manager has changed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 New status.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Previous status.  
  
### Return Value  
 Current implementation always returns S_OK;  
  
##  \<a name="canimationmanagereventhandler__setanimationcontroller">\</a>  CAnimationManagerEventHandler::SetAnimationController  
 [!INCLUDE[dev10_sp1required](../vs140/includes/dev10_sp1required_md.md)]  
  
 Stores a pointer to animation controller to route events.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)