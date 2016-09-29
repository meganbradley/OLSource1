---
title: "CBrush::FromHandle"
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
  - "CBrush.FromHandle"
  - "CBrush::FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "brushes, handles"
  - "handles, brush"
  - "CBrush class, operations"
  - "FromHandle method [MFC]"
ms.assetid: 888c864e-4872-4116-9cc3-391124c1de78
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBrush::FromHandle
Returns a pointer to a `CBrush` object when given a handle to a Windows [HBRUSH](../vs140/cbrush--operator-hbrush.md) object.  
  
## Syntax  
  
```  
  
      static CBrush* PASCAL FromHandle(  
   HBRUSH hBrush   
);  
```  
  
#### Parameters  
 `hBrush`  
 `HANDLE` to a Windows GDI brush.  
  
## Return Value  
 A pointer to a `CBrush` object if successful; otherwise **NULL**.  
  
## Remarks  
 If a `CBrush` object is not already attached to the handle, a temporary `CBrush` object is created and attached. This temporary `CBrush` object is valid only until the next time the application has idle time in its event loop. At this time, all temporary graphic objects are deleted. In other words, the temporary object is valid only during the processing of one window message.  
  
 For more information about using graphic objects, see [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CBrush::CBrush](../vs140/cbrush--cbrush.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBrush Class](../vs140/cbrush-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)