---
title: "MEASUREITEMSTRUCT Structure"
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
  - "MEASUREITEMSTRUCT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MEASUREITEMSTRUCT structure"
ms.assetid: d141ace4-47cb-46b5-a81c-ad2c5e5a8501
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MEASUREITEMSTRUCT Structure
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure informs Windows of the dimensions of an owner-drawn control or menu item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the control type. The values for control types are as follows:  
  
-   **ODT_COMBOBOX** Owner-draw combo box  
  
-   **ODT_LISTBOX** Owner-draw list box  
  
-   **ODT_MENU** Owner-draw menu  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the control ID for a combo box, list box, or button. This member is not used for a menu.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Contains the menu-item ID for a menu or the list-box-item ID for a variable-height combo box or list box. This member is not used for a fixed-height combo box or list box, or for a button.  
  
 *itemWidth*  
 Specifies the width of a menu item. The owner of the owner-draw menu item must fill this member before it returns from the message.  
  
 *itemHeight*  
 Specifies the height of an individual item in a list box or a menu. Before it returns from the message, the owner of the owner-draw combo box, list box, or menu item must fill out this member. The maximum height of a list box item is 255.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For a combo box or list box, this member contains the value that was passed to the list box by one of the following:  
  
-   [CComboBox::AddString](../vs140/ccombobox--addstring.md)  
  
-   [CComboBox::InsertString](../vs140/ccombobox--insertstring.md)  
  
-   [CListBox::AddString](../vs140/clistbox--addstring.md)  
  
-   [CListBox::InsertString](../vs140/clistbox--insertstring.md)  
  
 For a menu, this member contains the value that was passed to the menu by one of the following:  
  
-   [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md)  
  
-   [CMenu::InsertMenu](../vs140/cmenu--insertmenu.md)  
  
-   [CMenu::ModifyMenu](../vs140/cmenu--modifymenu.md)  
  
 This allows Windows to process user interaction with the control correctly. Failure to fill out the proper members in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure will cause improper operation of the control.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnMeasureItem](../vs140/cwnd--onmeasureitem.md)