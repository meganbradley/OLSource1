---
title: "CAnimationVariableIntegerChangeHandler Class"
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
  - "afxanimationcontroller/CAnimationVariableIntegerChangeHandler"
  - "CAnimationVariableIntegerChangeHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationVariableIntegerChangeHandler class"
ms.assetid: 6ac8e91b-e514-4ff6-babd-33f77c4b2b61
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariableIntegerChangeHandler Class
Implements a callback, which is called by the Animation API when the value of an animation variable changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationVariableIntegerChangeHandler::CAnimationVariableIntegerChangeHandler](#canimationvariableintegerchangehandler__canimationvariableintegerchangehandler)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationVariableIntegerChangeHandler::CreateInstance](#canimationvariableintegerchangehandler__createinstance)|Creates an instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> callback.|  
|[CAnimationVariableIntegerChangeHandler::OnIntegerValueChanged](#canimationvariableintegerchangehandler__onintegervaluechanged)|Called when a value of an animation variable has changed. (Overrides <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.)|  
|[CAnimationVariableIntegerChangeHandler::SetAnimationController](#canimationvariableintegerchangehandler__setanimationcontroller)|Stores a pointer to animation controller to route events.|  
  
## Remarks  
 This event handler is created and passed to IUIAnimationVariable::SetVariableIntegerChangeHandler method, when you call CAnimationVariable::EnableIntegerValueChangedEvent or CAnimationBaseObject::EnableIntegerValueChangedEvent (which enables this event for all animation variables encapsulated in an animation object).  
  
## Inheritance Hierarchy  
 [MFC Classes](../vs140/mfc-classes.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationvariableintegerchangehandler__canimationvariableintegerchangehandler">\</a>  CAnimationVariableIntegerChangeHandler::CAnimationVariableIntegerChangeHandler  
 Constructs a CAnimationVariableIntegerChangeHandler object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="canimationvariableintegerchangehandler__createinstance">\</a>  CAnimationVariableIntegerChangeHandler::CreateInstance  
 Creates an instance of CAnimationVariableIntegerChangeHandler callback.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="canimationvariableintegerchangehandler__onintegervaluechanged">\</a>  CAnimationVariableIntegerChangeHandler::OnIntegerValueChanged  
 Called when a value of an animation variable has changed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The storyboard that is animating the variable.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The animation variable that was updated.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The new rounded value.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The previous rounded value.  
  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationvariableintegerchangehandler__setanimationcontroller">\</a>  CAnimationVariableIntegerChangeHandler::SetAnimationController  
 Stores a pointer to animation controller to route events.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)