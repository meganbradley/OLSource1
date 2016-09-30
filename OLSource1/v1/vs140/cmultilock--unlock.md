---
title: "CMultiLock::Unlock"
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
  - "CMultiLock.Unlock"
  - "CMultiLock::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 5da58e3c-2d72-4a95-a53d-448533e1fa78
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiLock::Unlock
Releases the synchronization object owned by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of reference counts to release. Must be greater than 0. If the specified amount would cause the object's count to exceed its maximum, the count is not changed and the function returns **FALSE**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a variable to receive the previous count for the synchronization object. If **NULL**, the previous count is not returned.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 This function is called by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>'s destructor.  
  
 The first form of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> tries to unlock the synchronization object managed by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The second form of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> tries to unlock the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects owned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not own any locked <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, the function returns **FALSE**; otherwise, it returns **TRUE**. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are exactly the same as the parameters of [CSingleLock::Unlock](../vs140/csinglelock--unlock.md). The second form of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is rarely applicable to multilock situations.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)