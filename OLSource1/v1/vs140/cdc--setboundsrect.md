---
title: "CDC::SetBoundsRect"
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
  - "CDC::SetBoundsRect"
  - "SetBoundsRect"
  - "CDC.SetBoundsRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBoundsRect method"
  - "CDC class, clipping functions"
ms.assetid: 3960fcb0-6fbc-4bfc-9473-68b4f24d35c5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetBoundsRect
Controls the accumulation of bounding-rectangle information for the specified device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that is used to set the bounding rectangle. Rectangle dimensions are given in logical coordinates. This parameter can be **NULL**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies how the new rectangle will be combined with the accumulated rectangle. This parameter can be a combination of the following values:  
  
-   **DCB_ACCUMULATE** Add the rectangle specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to the bounding rectangle (using a rectangle-union operation).  
  
-   **DCB_DISABLE** Turn off bounds accumulation.  
  
-   **DCB_ENABLE** Turn on bounds accumulation. (The default setting for bounds accumulation is disabled.)  
  
## Return Value  
 The current state of the bounding rectangle, if the function is successful. Like <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the return value can be a combination of **DCB_** values:  
  
-   **DCB_ACCUMULATE** The bounding rectangle is not empty. This value will always be set.  
  
-   **DCB_DISABLE** Bounds accumulation is off.  
  
-   **DCB_ENABLE** Bounds accumulation is on.  
  
## Remarks  
 Windows can maintain a bounding rectangle for all drawing operations. This rectangle can be queried and reset by the application. The drawing bounds are useful for invalidating bitmap caches.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetBoundsRect](../vs140/cdc--getboundsrect.md)   
 [SetBoundsRect](http://msdn.microsoft.com/library/windows/desktop/dd162966)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)