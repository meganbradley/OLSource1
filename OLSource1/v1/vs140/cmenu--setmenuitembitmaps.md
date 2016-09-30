---
title: "CMenu::SetMenuItemBitmaps"
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
  - "SetMenuItemBitmaps"
  - "CMenu.SetMenuItemBitmaps"
  - "CMenu::SetMenuItemBitmaps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuItemBitmaps method"
  - "CMenu class, menu item operations"
ms.assetid: ed00451e-45cf-4563-8f6d-9d40a5c70826
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::SetMenuItemBitmaps
Associates the specified bitmaps with a menu item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the menu item to be changed. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter can be used to interpret <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the following ways:  
  
|nFlags|Interpretation of nPosition|  
|------------|---------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies how <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is interpreted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the bitmap to use for menu items that are not checked.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the bitmap to use for menu items that are checked.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 Whether the menu item is checked or unchecked, Windows displays the appropriate bitmap next to the menu item.  
  
 If either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **NULL**, then Windows displays nothing next to the menu item for the corresponding attribute. If both parameters are **NULL**, Windows uses the default check mark when the item is checked and removes the check mark when the item is unchecked.  
  
 When the menu is destroyed, these bitmaps are not destroyed; the application must destroy them.  
  
 The Windows **GetMenuCheckMarkDimensions** function retrieves the dimensions of the default check mark used for menu items. The application uses these values to determine the appropriate size for the bitmaps supplied with this function. Get the size, create your bitmaps, and then set them.  
  
## Example  
 [!code[NVC_MFCWindowing#32](../vs140/codesnippet/CPP/cmenu--setmenuitembitmaps_1.cpp)]  
  
 [!code[NVC_MFCWindowing#33](../vs140/codesnippet/CPP/cmenu--setmenuitembitmaps_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetMenuCheckMarkDimensions](http://msdn.microsoft.com/library/windows/desktop/ms647975)   
 [SetMenuItemBitmaps](http://msdn.microsoft.com/library/windows/desktop/ms647998)