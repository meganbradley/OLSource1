---
title: "CMenu::GetMenuString"
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
  - "GetMenuString"
  - "CMenu::GetMenuString"
  - "CMenu.GetMenuString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, menu item operations"
  - "GetMenuString method"
ms.assetid: 8c44dd3c-e50c-4796-9f3e-e35e458218a2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::GetMenuString
Copies the label of the specified menu item to the specified buffer.  
  
## Syntax  
  
```  
  
      int GetMenuString(  
   UINT nIDItem,  
   LPTSTR lpString,  
   int nMaxCount,  
   UINT nFlags   
) const;  
int GetMenuString(  
   UINT nIDItem,  
   CString& rString,  
   UINT nFlags   
) const;  
```  
  
#### Parameters  
 `nIDItem`  
 Specifies the integer identifier of the menu item or the offset of the menu item in the menu, depending on the value of `nFlags`.  
  
 `lpString`  
 Points to the buffer that is to receive the label.  
  
 `rString`  
 A reference to a `CString` object that is to receive the copied menu string.  
  
 `nMaxCount`  
 Specifies the maximum length (in characters) of the label to be copied. If the label is longer than the maximum specified in `nMaxCount`, the extra characters are truncated.  
  
 `nFlags`  
 Specifies the interpretation of the `nIDItem` parameter. It can be one of the following values:  
  
|nFlags|Interpretation of nIDItem|  
|------------|-------------------------------|  
|**MF_BYCOMMAND**|Specifies that the parameter gives the command ID of the existing menu item. This is the default if neither **MF_BYCOMMAND** nor **MF_BYPOSITION** is set.|  
|**MF_BYPOSITION**|Specifies that the parameter gives the position of the existing menu item. The first item is at position 0.|  
  
## Return Value  
 Specifies the actual number of characters copied to the buffer, not including the null terminator.  
  
## Remarks  
 The `nMaxCount` parameter should be one larger than the number of characters in the label to accommodate the null character that terminates a string.  
  
## Example  
 See the example for [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMenu::GetMenuState](../vs140/cmenu--getmenustate.md)   
 [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md)   
 [GetMenuString](http://msdn.microsoft.com/library/windows/desktop/ms647983)