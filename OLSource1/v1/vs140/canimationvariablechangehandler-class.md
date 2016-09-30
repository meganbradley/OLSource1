---
title: "CAnimationVariableChangeHandler Class"
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
  - "afxanimationcontroller/CAnimationVariableChangeHandler"
  - "CAnimationVariableChangeHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationVariableChangeHandler class"
ms.assetid: 2ea4996d-5c04-4dfc-be79-d42d55050795
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationVariableChangeHandler Class
Implements a callback, which is called by the Animation API when the value of an animation variable changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Creates an instance of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
|[CAnimationVariableChangeHandler::OnValueChanged](#canimationvariablechangehandler__onvaluechanged)|Called when a value of an animation variable has changed. (Overrides <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.)|  
|[CAnimationVariableChangeHandler::SetAnimationController](#canimationvariablechangehandler__setanimationcontroller)|Stores a pointer to animation controller to route events.|  
  
## Remarks  
 This event handler is created and passed to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method, when you call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (which enables this event for all animation variables encapsulated in an animation object).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationvariablechangehandler__onvaluechanged">\</a>  CAnimationVariableChangeHandler::OnValueChanged  
 Called when a value of an animation variable has changed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The storyboard that is animating the variable.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The animation variable that was updated.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The new value.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The previous value.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="canimationvariablechangehandler__setanimationcontroller">\</a>  CAnimationVariableChangeHandler::SetAnimationController  
 Stores a pointer to animation controller to route events.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)