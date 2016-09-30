---
title: "Ordering Items in the Header Control"
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
  - "DS_DRAGDROP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sequence"
  - "sequence, header control items"
  - "OrderToIndex method"
  - "DS_DRAGDROP notification"
  - "GetOrderArray method"
  - "SetOrderArray method"
  - "header controls, ordering items"
ms.assetid: 5aaef872-75b5-49c5-8fed-6f9a81fca812
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Ordering Items in the Header Control
Once you've [added items to a header control](../vs140/adding-items-to-the-header-control.md), you can manipulate or get information about their order with the following functions:  
  
-   [CHeaderCtrl::GetOrderArray](../vs140/cheaderctrl--getorderarray.md) and [CHeaderCtrl::SetOrderArray](../vs140/cheaderctrl--setorderarray.md)  
  
     Retrieves and sets the left-to-right order of header items.  
  
-   [CHeaderCtrl::OrderToIndex](../vs140/cheaderctrl--ordertoindex.md).  
  
     Retrieves the index value for a specific header item.  
  
 In addition to the previous member functions, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> style allows the user to drag and drop header items within the header control. For more information, see [Providing Drag-and-Drop Support for Header Items](../vs140/providing-drag-and-drop-support-for-header-items.md).  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)