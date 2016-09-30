---
title: "CAnimationTimerEventHandler Class"
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
  - "afxanimationcontroller/CAnimationTimerEventHandler"
  - "CAnimationTimerEventHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationTimerEventHandler class"
ms.assetid: 188dea3b-4b5e-4f6b-8df9-09d993a21619
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationTimerEventHandler Class
Implements a callback, which is called by the Animation API when timing events occur.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationTimerEventHandler::CreateInstance](#canimationtimereventhandler__createinstance)|Creates an instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> callback.|  
|[CAnimationTimerEventHandler::OnPostUpdate](#canimationtimereventhandler__onpostupdate)|Handles events that occur after an animation update is finished. (Overrides <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.)|  
|[CAnimationTimerEventHandler::OnPreUpdate](#canimationtimereventhandler__onpreupdate)|Handles events that occur before an animation update begins. (Overrides <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.)|  
|[CAnimationTimerEventHandler::OnRenderingTooSlow](#canimationtimereventhandler__onrenderingtooslow)|Handles events that occur when the rendering frame rate for an animation falls below the minimum desirable frame rate. (Overrides <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.)|  
|[CAnimationTimerEventHandler::SetAnimationController](#canimationtimereventhandler__setanimationcontroller)|Stores a pointer to animation controller to route events.|  
  
## Remarks  
 This event handler is created and passed to IUIAnimationTimer::SetTimerEventHandler when you call CAnimationController::EnableAnimationTimerEventHandler.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationtimereventhandler__createinstance">\</a>  CAnimationTimerEventHandler::CreateInstance  
 Creates an instance of CAnimationTimerEventHandler callback.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="canimationtimereventhandler__onpostupdate">\</a>  CAnimationTimerEventHandler::OnPostUpdate  
 Handles events that occur after an animation update is finished.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationtimereventhandler__onpreupdate">\</a>  CAnimationTimerEventHandler::OnPreUpdate  
 Handles events that occur before an animation update begins.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationtimereventhandler__onrenderingtooslow">\</a>  CAnimationTimerEventHandler::OnRenderingTooSlow  
 Handles events that occur when the rendering frame rate for an animation falls below the minimum desirable frame rate.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationtimereventhandler__setanimationcontroller">\</a>  CAnimationTimerEventHandler::SetAnimationController  
 Stores a pointer to animation controller to route events.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)