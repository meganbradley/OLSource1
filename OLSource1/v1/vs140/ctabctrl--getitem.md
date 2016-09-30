---
title: "CTabCtrl::GetItem"
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
  - "TCIF_TEXT"
  - "CTabCtrl::GetItem"
  - "TCIF_IMAGE"
  - "TC_ITEM"
  - "TC_ITEMHEADER"
  - "CTabCtrl.GetItem"
  - "TCITEM"
  - "TCIF_PARAM"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TC_ITEMHEADER"
  - "TC_ITEM"
  - "GetItem method [MFC]"
  - "TCIF_IMAGE"
  - "TCIF_PARAM"
  - "TCITEM"
  - "TCIF_TEXT"
ms.assetid: c8cfb2ba-64a0-43b2-a073-c8ccdb5304f6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::GetItem
Retrieves information about a tab in a tab control.  
  
## Syntax  
  
```  
  
      BOOL GetItem(  
  int nItem,  
  TCITEM* pTabCtrlItem   
) const;  
```  
  
#### Parameters  
 `nItem`  
 Zero-based index of the tab.  
  
 `pTabCtrlItem`  
 Pointer to a [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) structure, used to specify the information to retrieve. Also used to receive information about the tab. This structure is used with the `InsertItem`, `GetItem`, and `SetItem` member functions.  
  
## Return Value  
 Returns **TRUE** if successful; **FALSE** otherwise.  
  
## Remarks  
 When the message is sent, the **mask** member specifies which attributes to return. If the **mask** member specifies the `TCIF_TEXT` value, the **pszText** member must contain the address of the buffer that receives the item text and the **cchTextMax** member must specify the size of the buffer.  
  
 **mask**  
 Value specifying which `TCITEM` structure members to retrieve or set. This member can be zero or a combination of the following values:  
  
-   `TCIF_TEXT` The **pszText** member is valid.  
  
-   `TCIF_IMAGE` The `iImage` member is valid.  
  
-   `TCIF_PARAM` The **lParam** member is valid.  
  
-   `TCIF_RTLREADING` The text of **pszText** is displayed using right-to-left reading order on Hebrew or Arabic systems.  
  
-   `TCIF_STATE` The **dwState** member is valid.  
  
 **pszText**  
 Pointer to a null-terminated string containing the tab text if the structure contains information about a tab. If the structure is receiving information, this member specifies the address of the buffer that receives the tab text.  
  
 **cchTextMax**  
 Size of the buffer pointed to by **pszText**. This member is ignored if the structure is not receiving information.  
  
 `iImage`  
 Index into the tab control's image list, or – 1 if there is no image for the tab.  
  
 **lParam**  
 Application-defined data associated with the tab. If there are more than four bytes of application-defined data per tab, an application must define a structure and use it instead of the `TCITEM` structure. The first member of the application-defined structure must be a [TCITEMHEADER](http://msdn.microsoft.com/library/windows/desktop/bb760556)structure. The **TCITEMHEADER** structure is identical to the `TCITEM` structure, but without the **lParam** member. The difference between the size of your structure and the size of the **TCITEMHEADER** structure should equal the number of extra bytes per tab.  
  
## Example  
 [!code[NVC_MFC_CTabCtrl#4](../vs140/codesnippet/CPP/ctabctrl--getitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::InsertItem](../vs140/ctabctrl--insertitem.md)   
 [CTabCtrl::SetItem](../vs140/ctabctrl--setitem.md)