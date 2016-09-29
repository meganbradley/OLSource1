---
title: "CDC::ExcludeUpdateRgn"
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
  - "ExcludeUpdateRgn"
  - "CDC.ExcludeUpdateRgn"
  - "CDC::ExcludeUpdateRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, clipping functions"
  - "ExcludeUpdateRgn method"
ms.assetid: 8a94611f-a076-4768-8cee-eac08c546942
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ExcludeUpdateRgn
Prevents drawing within invalid areas of a window by excluding an updated region in the window from the clipping region associated with the `CDC` object.  
  
## Syntax  
  
```  
  
      int ExcludeUpdateRgn(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window object whose window is being updated.  
  
## Return Value  
 The type of excluded region. It can be any one of the following values:  
  
-   **COMPLEXREGION** The region has overlapping borders.  
  
-   **ERROR** No region was created.  
  
-   **NULLREGION** The region is empty.  
  
-   **SIMPLEREGION** The region has no overlapping borders.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::ExcludeClipRect](../vs140/cdc--excludecliprect.md)   
 [ExcludeUpdateRgn](http://msdn.microsoft.com/library/windows/desktop/dd162703)