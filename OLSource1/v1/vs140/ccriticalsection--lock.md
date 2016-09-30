---
title: "CCriticalSection::Lock"
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
  - "CCriticalSection::Lock"
  - "CCriticalSection.Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 9d3e0ee9-4626-487f-b88f-1937a7a49e1f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCriticalSection::Lock
Call this member function to gain access to the critical section object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> ignores this parameter value.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a blocking call that will not return until the critical section object is signaled (becomes available).  
  
 If timed waits are necessary, you can use a [CMutex](../vs140/cmutex-class.md) object instead of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> fails to allocate the necessary system memory, a memory exception (of type [CMemoryException](../vs140/cmemoryexception-class.md)) is automatically thrown.  
  
## Example  
 This example demonstrates the nested critical section approach by controlling access to a shared resource (the static <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object) using a shared <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function demonstrates updating a shared resource in a safe manner.  
  
 [!code[NVC_MFC_Utilities#11](../vs140/codesnippet/CPP/ccriticalsection--lock_1.h)]  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CCriticalSection Class](../vs140/ccriticalsection-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CSingleLock::Lock](../vs140/csinglelock--lock.md)