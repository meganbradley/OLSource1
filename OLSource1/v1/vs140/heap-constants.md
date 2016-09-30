---
title: "Heap Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_HEAPBADPTR"
  - "_HEAPEMPTY"
  - "_HEAPBADBEGIN"
  - "_HEAPOK"
  - "_HEAPBADNODE"
  - "_HEAPEND"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_HEAPOK constants"
  - "_HEAPEND constants"
  - "HEAPBADBEGIN constants"
  - "_HEAPBADNODE constants"
  - "HEAPBADNODE constants"
  - "HEAPBADPTR constants"
  - "_HEAPEMPTY constants"
  - "HEAPEND constants"
  - "HEAPOK constants"
  - "HEAPEMPTY constants"
  - "_HEAPBADBEGIN constants"
  - "_HEAPBADPTR constants"
  - "heap constants"
ms.assetid: 3f751bb9-2dc4-486f-b5f5-9061c96d3754
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Heap Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These constants give the return value indicating status of the heap.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Initial header information was not found or was invalid.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Bad node was found, or heap is damaged.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**_pentry** field of **_HEAPINFO** structure does not contain valid pointer into heap (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> routine only).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Heap has not been initialized.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|End of heap was reached successfully (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> routine only).|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Heap is consistent (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> routines only). No errors so far; **_HEAPINFO** structure contains information about next entry (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> routine only).|  
  
## See Also  
 [_heapchk](../vs140/_heapchk.md)   
 [_heapset](../vs140/_heapset.md)   
 [_heapwalk](../vs140/_heapwalk.md)   
 [Global Constants](../vs140/global-constants.md)