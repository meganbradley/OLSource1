---
title: "COMPAREITEMSTRUCT Structure"
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
  - "COMPAREITEMSTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COMPAREITEMSTRUCT structure"
ms.assetid: 4b7131a5-5c7d-4e98-aac7-e85650262b52
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COMPAREITEMSTRUCT Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure supplies the identifiers and application-supplied data for two items in a sorted, owner-drawn list box or combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **ODT_LISTBOX** (which specifies an owner-draw list box) or **ODT_COMBOBOX** (which specifies an owner-draw combo box).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The control ID for the list box or combo box.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The window handle of the control.  
  
 *itemID1*  
 The index of the first item in the list box or combo box being compared.  
  
 *itemData1*  
 Application-supplied data for the first item being compared. This value was passed in the call that added the item to the combo or list box.  
  
 *itemID2*  
 Index of the second item in the list box or combo box being compared.  
  
 *itemData2*  
 Application-supplied data for the second item being compared. This value was passed in the call that added the item to the combo or list box.  
  
## Remarks  
 Whenever an application adds a new item to an owner-drawn list box or combo box created with the **CBS_SORT** or **LBS_SORT** style, Windows sends the owner a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter of the message contains a long pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure. Upon receiving the message, the owner compares the two items and returns a value indicating which item sorts before the other.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnCompareItem](../vs140/cwnd--oncompareitem.md)