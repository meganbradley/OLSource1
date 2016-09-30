---
title: "TN014: Custom Controls"
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
  - "vc.controls"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN014"
  - "custom controls [MFC]"
ms.assetid: 1917a498-f643-457c-b570-9a0af7dbf7bb
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN014: Custom Controls
This note describes the MFC Support for custom and self-drawing controls. It also describes dynamic subclassing, and describes the relationship between [CWnd](../vs140/cwnd-class.md) objects and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>s.  
  
 The MFC sample application CTRLTEST illustrates how to use many custom controls. See the source code for the MFC General sample [CTRLTEST](../vs140/visual-c---samples.md) and online help.  
  
## Owner-Draw Controls/Menus  
 Windows provides support for owner-draw controls and menus by using Windows messages. The parent window of any control or menu receives these messages and calls functions in response. You can override these functions to customize the visual appearance and behavior of your owner-draw control or menu.  
  
 MFC directly supports owner-draw with the following functions:  
  
-   [CWnd::OnDrawItem](../vs140/cwnd--ondrawitem.md)  
  
-   [CWnd::OnMeasureItem](../vs140/cwnd--onmeasureitem.md)  
  
-   [CWnd::OnCompareItem](../vs140/cwnd--oncompareitem.md)  
  
-   [CWnd::OnDeleteItem](../vs140/cwnd--ondeleteitem.md)  
  
 You can override these functions in your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> derived class to implement custom draw behavior.  
  
 This approach does not lead to reusable code. If you have two similar controls in two different <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> classes, you must implement the custom control behavior in two locations. The MFC-supported self-drawing control architecture solves this problem.  
  
## Self-Draw Controls and Menus  
 MFC provides a default implementation (in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and [CMenu](../vs140/cmenu-class.md) classes) for the standard owner-draw messages. This default implementation will decode the owner-draw parameters and delegate the owner-draw messages to the controls or menu. This is called self-draw because the drawing code is in the class of the control or menu, not in the owner window.  
  
 By using self-draw controls you can build reusable control classes that use owner-draw semantics to display the control. The code for drawing the control is in the control class, not its parent. This is an object-oriented approach to custom control programming. Add the following list of functions to your self-draw classes:  
  
-   For self-draw buttons:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   For self-draw menus:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   For self-draw list boxes:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   For self-draw combo boxes:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For details on the owner-draw structures ([DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md), [MEASUREITEMSTRUCT](../vs140/measureitemstruct-structure.md), [COMPAREITEMSTRUCT](../vs140/compareitemstruct-structure.md), and [DELETEITEMSTRUCT](../vs140/deleteitemstruct-structure.md)) see the MFC documentation for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> respectively.  
  
## Using self-draw controls and menus  
 For self-draw menus, you must override both the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> methods.  
  
 For self-draw list boxes and combo boxes, you must override <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. You must specify the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> style for list boxes or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> style for combo boxes in the dialog template. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> style will not work with self-draw items because the fixed item height is determined before self-draw controls are attached to the list box. (You can use the methods [CListBox::SetItemHeight](../vs140/clistbox--setitemheight.md) and [CComboBox::SetItemHeight](../vs140/ccombobox--setitemheight.md) to overcome this limitation.)  
  
 Switching to an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> style will force the system to apply the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> style to the control. Because the control cannot calculate an integral height with variable sized items, the default style of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is ignored and the control is always <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. If your items are fixed height, you can prevent partial items from being drawn by specifying the control size to be an integer multiplier of the item size.  
  
 For self-drawing list boxes and combo boxes with the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> style, you must override the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method.  
  
 For self-drawing list boxes and combo boxes, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not usually overridden. You can override <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if you want to perform any special processing. One case where this would be applicable is when additional memory or other resources are stored with each list box or combo box item.  
  
## Examples of Self-Drawing Controls and Menus  
 The MFC General sample [CTRLTEST](../vs140/visual-c---samples.md) provides samples of a self-draw menu and a self-draw list box.  
  
 The most typical example of a self-drawing button is a bitmap button. A bitmap button is a button that shows one, two, or three bitmap images for the different states. An example of this is provided in the MFC class [CBitmapButton](../vs140/cbitmapbutton-class.md).  
  
## Dynamic Subclassing  
 Occasionally you will want to change the functionality of an object that already exists. The previous examples required you to customize the controls before they were created. Dynamic subclassing enables you to customize a control that has already been created.  
  
 Subclassing is the Windows term for replacing the [WndProc](assetId:///94ba8ffa-3c36-46d4-ac74-9bd10b1ffd26) of a window with a customized <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and calling the old <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for default functionality.  
  
 This should not be confused with C++ class derivation. For clarification, the C++ terms *base class* and *derived class* are analogous to *superclass* and *subclass* in the Windows object model. C++ derivation with MFC and Windows subclassing are functionally similar, except C++ does not support dynamic subclassing.  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class provides the connection between a C++ object (derived from <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>) and a Windows window object (known as an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>).  
  
 There are three common ways these are related:  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> creates the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. You can modify the behavior in a derived class by creating a class derived from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is created when your application calls [CWnd::Create](../vs140/cwnd--create.md).  
  
-   The application attaches a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to an existing <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. The behavior of the existing window is not modified. This is a case of delegation and is made possible by calling [CWnd::Attach](../vs140/cwnd--attach.md) to alias an existing <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is attached to an existing <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and you can modify the behavior in a derived class. This is called dynamic subclassing because we are changing the behavior, and therefore the class, of a Windows object at run time.  
  
 You can achieve dynamic subclassing by using the methods [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md) and[CWnd::SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md).  
  
 Both routines attach a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object to an existing <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> takes the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> directly. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is a helper function that takes a control ID and the parent window. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is designed for attaching C++ objects to dialog controls created from a dialog template.  
  
 See the [CTRLTEST](../vs140/visual-c---samples.md) example for several examples of when to use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)