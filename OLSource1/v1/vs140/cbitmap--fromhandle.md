---
title: "CBitmap::FromHandle"
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
  - CBitmap::FromHandle
  - CBitmap.FromHandle
dev_langs: 
  - C++
helpviewer_keywords: 
  - FromHandle method [MFC]
ms.assetid: 840735fc-29dd-4a36-b0e7-ee9b965534de
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::FromHandle
Returns a pointer to a `CBitmap` object when given a handle to a Windows GDI bitmap.  
  
## Syntax  
  
```  
  
      static CBitmap* PASCAL FromHandle(  
   HBITMAP hBitmap   
);  
```  
  
#### Parameters  
 `hBitmap`  
 Specifies a Windows GDI bitmap.  
  
## Return Value  
 A pointer to a `CBitmap` object if successful; otherwise **NULL**.  
  
## Remarks  
 If a `CBitmap` object is not already attached to the handle, a temporary `CBitmap` object is created and attached. This temporary `CBitmap` object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)