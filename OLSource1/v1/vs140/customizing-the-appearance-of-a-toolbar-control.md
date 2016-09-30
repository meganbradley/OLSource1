---
title: "Customizing the Appearance of a Toolbar Control"
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
  - "TBSTYLE_"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flat toolbars"
  - "CToolBar class, styles"
  - "transparent toolbars"
  - "TBSTYLE_ styles"
  - "CToolBarCtrl class, object styles"
  - "toolbar controls [MFC], style"
ms.assetid: fd0a73db-7ad1-4fe4-889b-02c3980f49e8
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Customizing the Appearance of a Toolbar Control
Class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> provides many styles that affect the appearance (and, occasionally, the behavior) of the toolbar object. Modify the toolbar object by setting the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) member function, when you first create the toolbar control.  
  
 The following styles affect the "3D" aspect of the toolbar buttons and the placement of the button text:  
  
-   **TBSTYLE_FLAT** Creates a flat toolbar where both the toolbar and the buttons are transparent. Button text appears under button bitmaps. When this style is used, the button underneath the cursor is automatically highlighted.  
  
-   **TBSTYLE_TRANSPARENT** Creates a transparent toolbar. In a transparent toolbar, the toolbar is transparent but the buttons are not. Button text appears under button bitmaps.  
  
-   **TBSTYLE_LIST** Places button text to the right of button bitmaps.  
  
> [!NOTE]
>  To prevent repaint problems, the **TBSTYLE_FLAT** and **TBSTYLE_TRANSPARENT** styles should be set before the toolbar object is visible.  
  
 The following styles determine if the toolbar allows a user to reposition individual buttons within a toolbar object using drag and drop:  
  
-   **TBSTYLE_ALTDRAG** Allows users to change a toolbar button's position by dragging it while holding down ALT. If this style is not specified, the user must hold down SHIFT while dragging a button.  
  
    > [!NOTE]
    >  The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> style must be specified to enable toolbar buttons to be dragged.  
  
-   **TBSTYLE_REGISTERDROP** Generates **TBN_GETOBJECT** notification messages to request drop target objects when the mouse pointer passes over toolbar buttons.  
  
 The remaining styles affect visual and nonvisual aspects of the toolbar object:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Creates a toolbar that can have multiple lines of buttons. Toolbar buttons can "wrap" to the next line when the toolbar becomes too narrow to include all buttons on the same line. Wrapping occurs on separation and nongroup boundaries.  
  
-   **TBSTYLE_CUSTOMERASE** Generates **NM_CUSTOMDRAW** notification messages when it processes <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> messages.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Creates a tool tip control that an application can use to display descriptive text for the buttons in the toolbar.  
  
 For a complete listing of toolbar styles and extended styles, see [Toolbar Control and Button Styles](http://msdn.microsoft.com/library/windows/desktop/bb760439) and [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Using CToolBarCtrl](../vs140/using-ctoolbarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)