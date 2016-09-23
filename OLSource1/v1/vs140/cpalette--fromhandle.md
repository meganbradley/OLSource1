---
title: "CPalette::FromHandle"
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
  - CPalette::FromHandle
  - CPalette.FromHandle
dev_langs: 
  - C++
helpviewer_keywords: 
  - handles
  - FromHandle method [MFC]
  - CPalette class, operations
ms.assetid: ea5a403d-2b90-4c07-b8cf-823c803c49cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPalette::FromHandle
Returns a pointer to a `CPalette` object when given a handle to a Windows palette object.  
  
## Syntax  
  
```  
  
      static CPalette* PASCAL FromHandle(  
   HPALETTE hPalette   
);  
```  
  
#### Parameters  
 `hPalette`  
 A handle to a Windows GDI color palette.  
  
## Return Value  
 A pointer to a `CPalette` object if successful; otherwise **NULL**.  
  
## Remarks  
 If a `CPalette` object is not already attached to the Windows palette, a temporary `CPalette` object is created and attached. This temporary `CPalette` object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. In other words, the temporary object is valid only during the processing of one window message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)