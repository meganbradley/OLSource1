---
title: "CToolBarCtrl::AddButtons"
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
  - "TBSTATE_PRESSED"
  - "TBSTATE_CHECKED"
  - "CToolBarCtrl::AddButtons"
  - "TBSTATE_ENABLED"
  - "CToolBarCtrl.AddButtons"
  - "TBSTYLE_CHECK"
  - "TBSTATE_INDETERMINATE"
  - "TBSTYLE_CHECKGROUP"
  - "TBSTYLE_GROUP"
  - "TBSTATE_HIDDEN"
  - "TBBUTTON"
  - "AddButtons"
  - "TBSTYLE_SEP"
  - "TBSTATE_WRAP"
  - "TBSTYLE_BUTTON"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TBSTYLE_GROUP constant"
  - "TBSTATE_INDETERMINATE constant"
  - "TBSTYLE_CHECK constant"
  - "TBBUTTON structure"
  - "AddButtons method"
  - "TBSTATE_PRESSED constant"
  - "TBSTYLE_SEP constant"
  - "TBSTYLE_BUTTON constant"
  - "TBSTYLE_CHECKGROUP constant"
  - "TBSTATE_CHECKED constant"
  - "TBSTATE_HIDDEN constant"
  - "TBSTATE_ENABLED constant"
  - "TBSTATE_WRAP constant"
ms.assetid: 3496c688-eb2e-4a25-a028-ec56a6cd20f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::AddButtons
Adds one or more buttons to a toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of buttons to add.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of an array of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structures that contains information about the buttons to add. There must be the same number of elements in the array as buttons specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer points to an array of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structures. Each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure associates the button being added with the button's style, image and/or string, command ID, state, and user-defined data:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 The members are as follows:  
  
 **iBitmap**  
 Zero-based index of button image, -1 if no image for this button.  
  
 **idCommand**  
 Command identifier associated with the button. This identifier is sent in a **WM_COMMAND** message when the button is chosen. If the **fsStyle** member has the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value, this member must be zero.  
  
 **fsState**  
 Button state flags. It can be a combination of the values listed below:  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> The button has the **TBSTYLE_CHECKED** style and is being pressed.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> The button accepts user input. A button that does not have this state does not accept user input and is grayed.  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> The button is not visible and cannot receive user input.  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> The button is grayed.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> The button is being pressed.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> A line break follows the button. The button must also have the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> state.  
  
 **fsStyle**  
 Button style. It can be a combination of the values listed below:  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Creates a standard push button.  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> Creates a button that toggles between the pressed and unpressed states each time the user clicks it. The button has a different background color when it is in the pressed state.  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> Creates a check button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> Creates a button that stays pressed until another button in the group is pressed.  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> Creates a separator, providing a small gap between button groups. A button that has this style does not receive user input.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 User-defined data.  
  
 **iString**  
 Zero-based index of the string to use as the button's label, -1 if there is no string for this button.  
  
 The image and/or string whose index you provide must have previously been added to the toolbar control's list using [AddBitmap](../vs140/ctoolbarctrl--addbitmap.md), [AddString](../vs140/ctoolbarctrl--addstring.md), and/or [AddStrings](../vs140/ctoolbarctrl--addstrings.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::InsertButton](../vs140/ctoolbarctrl--insertbutton.md)   
 [CToolBarCtrl::DeleteButton](../vs140/ctoolbarctrl--deletebutton.md)   
 [CToolBarCtrl::AddBitmap](../vs140/ctoolbarctrl--addbitmap.md)   
 [CToolBarCtrl::AddString](../vs140/ctoolbarctrl--addstring.md)   
 [CToolBarCtrl::AddStrings](../vs140/ctoolbarctrl--addstrings.md)