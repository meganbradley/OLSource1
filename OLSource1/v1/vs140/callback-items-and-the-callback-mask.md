---
title: "Callback Items and the Callback Mask"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "callback items in CListCtrl class"
  - "CListCtrl class, callback item and callback mask"
ms.assetid: 67c1f76f-6144-453e-9376-6712f89430ae
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Callback Items and the Callback Mask
For each of its items, a list view control typically stores the label text, the image list index of the item's icons, and a set of bit flags for the item's state. You can define individual items as callback items, which are useful if your application already stores some of the information for an item.  
  
 You define an item as a callback item by specifying appropriate values for the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> members of the **LV_ITEM** structure (see [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)). If the application maintains the item's or subitem's text, specify the **LPSTR_TEXTCALLBACK** value for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member. If the application keeps track of the icon for the item, specify the **I_IMAGECALLBACK** value for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member.  
  
 In addition to defining callback items, you can also modify the control's callback mask. This mask is a set of bit flags that specify the item states for which the application, rather than the control, stores the current data. The callback mask applies to all of the control's items, unlike the callback item designation, which applies to a specific item. The callback mask is zero by default, meaning that the control tracks all item states. To change this default behavior, initialize the mask to any combination of the following values:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> The item is marked for a cut-and-paste operation.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> The item is highlighted as a drag-and-drop target.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> The item has the focus.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> The item is selected.  
  
-   **LVIS_OVERLAYMASK** The application stores the image list index of the current overlay image for each item.  
  
-   **LVIS_STATEIMAGEMASK** The application stores the image list index of the current state image for each item.  
  
 For further information on retrieving and setting this mask, see [CListCtrl::GetCallbackMask](../vs140/clistctrl--getcallbackmask.md) and [CListCtrl::SetCallbackMask](../vs140/clistctrl--setcallbackmask.md).  
  
## See Also  
 [Using CListCtrl](../vs140/using-clistctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)