---
title: "CEvent::CEvent"
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
  - "CEvent::CEvent"
  - "CEvent.CEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEvent class, constructor"
ms.assetid: 887031a7-39e7-4ad6-aa6d-c6226930b775
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEvent::CEvent
Constructs a named or unnamed <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE**, the thread for the **CMultilock** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is enabled. Otherwise, all threads wanting to access the resource must wait.  
  
 *bManualReset*  
 If **TRUE**, specifies that the event object is a manual event, otherwise the event object is an automatic event.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. Must be supplied if the object will be used across process boundaries. If the name matches an existing event, the constructor builds a new <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object which references the event of that name. If the name matches an existing synchronization object that is not an event, the construction will fail. If **NULL**, the name will be null.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Security attributes for the event object. For a full description of this structure, see [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 To access or release a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, create a [CMultiLock](../vs140/cmultilock-class.md) or [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock--lock.md) and [Unlock](../vs140/csinglelock--unlock.md) member functions.  
  
 To change the state of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to signaled (threads do not have to wait), call [SetEvent](../vs140/cevent--setevent.md) or [PulseEvent](../vs140/cevent--pulseevent.md). To set the state of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object to nonsignaled (threads must wait), call [ResetEvent](../vs140/cevent--resetevent.md).  
  
> [!IMPORTANT]
>  After creating the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, use [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to ensure that the mutex didn't already exist. If the mutex did exist unexpectedly, it may indicate a rogue process is squatting and may be intending to use the mutex maliciously. In this case, the recommended security-conscious procedure is to close the handle and continue as if there was a failure in creating the object.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CEvent Class](../vs140/cevent-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)