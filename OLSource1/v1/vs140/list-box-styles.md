---
title: "List-Box Styles"
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
  - "LBS_STANDARD"
  - "LBS_NODATA"
  - "LBS_OWNERDRAWVARIABLE"
  - "LBS_EXTENDEDSEL"
  - "LBS_USETABSTOPS"
  - "LBS_WANTKEYBOARDINPUT"
  - "LBS_NOTIFY"
  - "LBS_DISABLENOSCROLL"
  - "LBS_HASSTRINGS"
  - "LBS_NOREDRAW"
  - "LBS_NOSEL"
  - "LBS_NOINTEGRALHEIGHT"
  - "LBS_MULTICOLUMN"
  - "LBS_SORT"
  - "LBS_MULTIPLESEL"
  - "LBS_OWNERDRAWFIXED"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LBS_NOSEL constant"
  - "LBS_NOREDRAW constant"
  - "LBS_HASSTRINGS constant"
  - "LBS_OWNERDRAWFIXED constant"
  - "LBS_WANTKEYBOARDINPUT constant"
  - "LBS_STANDARD constant"
  - "LBS_MULTIPLESEL constant"
  - "LBS_OWNERDRAWVARIABLE constant"
  - "LBS_DISABLENOSCROLL constant"
  - "LBS_NODATA constant"
  - "list boxes, styles"
  - "LBS_EXTENDEDSEL constant"
  - "LBS_MULTICOLUMN constant"
  - "LBS_NOTIFY constant"
  - "LBS_USETABSTOPS constant"
  - "LBS_NOINTEGRALHEIGHT constant"
  - "LBS_SORT constant"
ms.assetid: 3f357b8d-9118-4f41-9e28-02ed92d1e88f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List-Box Styles
-   **LBS_DISABLENOSCROLL** The list box shows a disabled vertical scroll bar when the list box does not contain enough items to scroll. Without this style, the scroll bar is hidden when the list box does not contain enough items.  
  
-   **LBS_EXTENDEDSEL** The user can select multiple items using the SHIFT key and the mouse or special key combinations.  
  
-   **LBS_HASSTRINGS** Specifies an owner-draw list box that contains items consisting of strings. The list box maintains the memory and pointers for the strings so the application can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function to retrieve the text for a particular item.  
  
-   **LBS_MULTICOLUMN** Specifies a multicolumn list box that is scrolled horizontally. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function sets the width of the columns.  
  
-   **LBS_MULTIPLESEL** String selection is toggled each time the user clicks or double-clicks the string. Any number of strings can be selected.  
  
-   **LBS_NODATA** Specifies a no-data list box. Specify this style when the count of items in the list box will exceed one thousand. A no-data list box must also have the **LBS_OWNERDRAWFIXED** style, but must not have the **LBS_SORT** or **LBS_HASSTRINGS** style.  
  
     A no-data list box resembles an owner-drawn list box except that it contains no string or bitmap data for an item. Commands to add, insert, or delete an item always ignore any given item data; requests to find a string within the list box always fail. The system sends the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> message to the owner window when an item must be drawn. The itemID member of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure passed with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message specifies the line number of the item to be drawn. A no-data list box does not send a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message.  
  
-   **LBS_NOINTEGRALHEIGHT** The size of the list box is exactly the size specified by the application when it created the list box. Usually, Windows sizes a list box so that the list box does not display partial items.  
  
-   **LBS_NOREDRAW** List-box display is not updated when changes are made. This style can be changed at any time by sending a **WM_SETREDRAW** message.  
  
-   **LBS_NOSEL** Specifies that the list box contains items that can be viewed but not selected.  
  
-   **LBS_NOTIFY** Parent window receives an input message whenever the user clicks or double-clicks a string.  
  
-   **LBS_OWNERDRAWFIXED** The owner of the list box is responsible for drawing its contents; the items in the list box are the same height.  
  
-   **LBS_OWNERDRAWVARIABLE** The owner of the list box is responsible for drawing its contents; the items in the list box are variable in height.  
  
-   **LBS_SORT** Strings in the list box are sorted alphabetically.  
  
-   **LBS_STANDARD** Strings in the list box are sorted alphabetically, and the parent window receives an input message whenever the user clicks or double-clicks a string. The list box contains borders on all sides.  
  
-   **LBS_USETABSTOPS** Allows a list box to recognize and expand tab characters when drawing its strings. The default tab positions are 32 dialog units. (A dialog unit is a horizontal or vertical distance. One horizontal dialog unit is equal to one-fourth of the current dialog base width unit. The dialog base units are computed based on the height and width of the current system font. The **GetDialogBaseUnits** Windows function returns the current dialog base units in pixels.) This style should not be used with **LBS_OWNERDRAWFIXED**.  
  
-   **LBS_WANTKEYBOARDINPUT** The owner of the list box receives <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> messages whenever the user presses a key while the list box has input focus. This allows an application to perform special processing on the keyboard input.  
  
## See Also  
 [Styles Used by MFC](../vs140/styles-used-by-mfc.md)   
 [CListBox::Create](../vs140/clistbox--create.md)   
 [List Box Styles](http://msdn.microsoft.com/library/windows/desktop/bb775149)