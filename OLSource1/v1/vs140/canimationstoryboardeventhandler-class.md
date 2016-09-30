---
title: "CAnimationStoryboardEventHandler Class"
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
  - "afxanimationcontroller/CAnimationStoryboardEventHandler"
  - "CAnimationStoryboardEventHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAnimationStoryboardEventHandler class"
ms.assetid: 10a7e86b-c02d-4124-9a2e-61ecf8ac62fc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationStoryboardEventHandler Class
Implements a callback, which is called by the Animation API when the status of a storyboard is changed or a storyboard is updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationStoryboardEventHandler::CAnimationStoryboardEventHandler](#canimationstoryboardeventhandler__canimationstoryboardeventhandler)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAnimationStoryboardEventHandler::CreateInstance](#canimationstoryboardeventhandler__createinstance)|Creates an instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> callback.|  
|[CAnimationStoryboardEventHandler::OnStoryboardStatusChanged](#canimationstoryboardeventhandler__onstoryboardstatuschanged)|Handles <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> events, which occur when a storyboard's status changes (Overrides <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.)|  
|[CAnimationStoryboardEventHandler::OnStoryboardUpdated](#canimationstoryboardeventhandler__onstoryboardupdated)|Handles <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> events, which occur when a storyboard is updated (Overrides <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.)|  
|[CAnimationStoryboardEventHandler::SetAnimationController](#canimationstoryboardeventhandler__setanimationcontroller)|Stores a pointer to animation controller to route events.|  
  
## Remarks  
 This event handler is created and passed to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method, when you call <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
##  \<a name="canimationstoryboardeventhandler__canimationstoryboardeventhandler">\</a>  CAnimationStoryboardEventHandler::CAnimationStoryboardEventHandler  
 Constructs a CAnimationStoryboardEventHandler object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="canimationstoryboardeventhandler__createinstance">\</a>  CAnimationStoryboardEventHandler::CreateInstance  
 Creates an instance of CAnimationStoryboardEventHandler callback.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="canimationstoryboardeventhandler__onstoryboardstatuschanged">\</a>  CAnimationStoryboardEventHandler::OnStoryboardStatusChanged  
 Handles OnStoryboardStatusChanged events, which occur when a storyboard's status changes  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to storyboard whose status has changed.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies new storyboard status.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies previous storyboard status.  
  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationstoryboardeventhandler__onstoryboardupdated">\</a>  CAnimationStoryboardEventHandler::OnStoryboardUpdated  
 Handles OnStoryboardUpdated events, which occur when a storyboard is updated  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to storyboard, which was updated.  
  
### Return Value  
 S_OK if the method succeeds; otherwise E_FAIL.  
  
##  \<a name="canimationstoryboardeventhandler__setanimationcontroller">\</a>  CAnimationStoryboardEventHandler::SetAnimationController  
 Stores a pointer to animation controller to route events.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to animation controller, which will receive events.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)