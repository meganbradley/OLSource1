---
title: "Header Items in a Header Control"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - header controls, header items in
  - header items in header controls
  - CHeaderCtrl class, header items in
  - controls [MFC], header
ms.assetid: ac79ef1f-a671-4ab2-93e9-b1aa016a48bf
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Header Items in a Header Control
You have considerable control over the appearance and behavior of the header items that make up a header control ([CHeaderCtrl](../vs140/cheaderctrl-class.md)). Each header item can have a string, a bitmapped image, an image from an associated image list, or an application-defined 32-bit value associated with it. The string, bitmap, or image is displayed in the header item.  
  
 You can customize the appearance and contents of new items when they are created by making a call [CHeaderCtrl::InsertItem](../vs140/cheaderctrl--insertitem.md) or by modifying an existing item, with a call to [CHeaderCtrl::GetItem](../vs140/cheaderctrl--getitem.md) and [CHeaderCtrl::SetItem](../vs140/cheaderctrl--setitem.md).  
  
## What do you want to know more about?  
  
-   [Customizing the header item's appearance](../vs140/customizing-the-header-item-s-appearance.md)  
  
-   [Ordering items in the header control](../vs140/ordering-items-in-the-header-control.md)  
  
-   [Providing drag-and-drop support for the header items](../vs140/providing-drag-and-drop-support-for-header-items.md)  
  
-   [Using image lists with header controls](../vs140/using-image-lists-with-header-controls.md)  
  
## See Also  
 [Using CHeaderCtrl](../vs140/using-cheaderctrl.md)