---
title: "CSyncObject::Lock"
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
  - "CSyncObject.Lock"
  - "CSyncObject::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: b2b37fb0-5a0b-4742-871a-31a9e59272b9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSyncObject::Lock
Call this function to gain access to the resource controlled by the synchronization object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the amount of time in milliseconds to wait for the synchronization object to be available (signaled). If **INFINITE**, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> will wait until the object is signaled before returning.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 If the synchronization object is signaled, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will return successfully and the thread now owns the object. If the synchronization object is nonsignaled (unavailable), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will wait for the synchronization object to become signaled up to the number of milliseconds specified in the *dwTimeOut* parameter. If the synchronization object did not become signaled in the specified amount of time, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns failure.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSyncObject Class](../vs140/csyncobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)