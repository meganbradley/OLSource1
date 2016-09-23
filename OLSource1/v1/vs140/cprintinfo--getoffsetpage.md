---
title: "CPrintInfo::GetOffsetPage"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetOffsetPage
  - CPrintInfo::GetOffsetPage
  - CPrintInfo.GetOffsetPage
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPrintInfo structure, attributes
  - GetOffsetPage method
ms.assetid: 467ba5c2-e031-4e51-96dd-57e909e0ee23
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPrintInfo::GetOffsetPage
Call this function to retrieve the offset when printing multiple DocObject items from a DocObject client.  
  
## Syntax  
  
```  
  
UINT GetOffsetPage( ) const;  
```  
  
## Return Value  
 The number of pages preceding the first page of a DocObject item being printed in a combined DocObject print job.  
  
## Remarks  
 This value is referenced by the **m_nOffsetPage** member. The first page of your document will be numbered the **m_nOffsetPage** value + 1 when printed as a DocObject with other active documents. The **m_nOffsetPage** member is valid only if the **m_bDocObject** value is **TRUE**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::m_nOffsetPage](../vs140/cprintinfo--m_noffsetpage.md)   
 [CPrintInfo::m_bDocObject](../vs140/cprintinfo--m_bdocobject.md)