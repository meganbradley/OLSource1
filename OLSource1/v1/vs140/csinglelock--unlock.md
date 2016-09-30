---
title: "CSingleLock::Unlock"
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
  - "CSingleLock.Unlock"
  - "CSingleLock::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 91354207-3458-416e-96da-c21e5d6b656a
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSingleLock::Unlock
Releases the synchronization object owned by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of accesses to release. Must be greater than 0. If the specified amount would cause the object's count to exceed its maximum, the count is not changed and the function returns **FALSE**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a variable to receive the previous count of the synchronization object. If **NULL**, the previous count is not returned.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 This function is called by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>'s destructor.  
  
 If you need to release more than one access count of a semaphore, use the second form of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and specify the number of accesses to release.  
  
## Example  
 [!code[NVC_MFC_Utilities#21](../vs140/codesnippet/CPP/csinglelock--unlock_1.h)]  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSingleLock Class](../vs140/csinglelock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)