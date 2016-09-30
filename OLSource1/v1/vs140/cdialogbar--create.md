---
title: "CDialogBar::Create"
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
  - "CDialogBar.Create"
  - "CBRS_RIGHT"
  - "CBRS_BOTTOM"
  - "CDialogBar::Create"
  - "CBRS_LEFT"
  - "CBRS_TOP"
  - "CBRS_NOALIGN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CBRS_RIGHT constant"
  - "CBRS_NOALIGN constant"
  - "Create method [C++]"
  - "CBRS_LEFT constant"
  - "CBRS_BOTTOM constant"
  - "CDialogBar class, construction/destruction"
  - "CBRS_TOP constant"
ms.assetid: e29d21ba-72f9-4e79-b6b3-4b2f7597bbb3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogBar::Create
Loads the dialog-box resource template specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, creates the dialog-bar window, sets its style, and associates it with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the parent <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the name of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object's dialog-box resource template.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The toolbar style. Additional toolbar styles supported are:  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Control bar is at top of the frame window.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Control bar is at bottom of the frame window.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Control bar is not repositioned when the parent is resized.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Control bar displays tool tips.  
  
-   **CBRS_SIZE_DYNAMIC** Control bar is dynamic.  
  
-   **CBRS_SIZE_FIXED** Control bar is fixed.  
  
-   **CBRS_FLOATING** Control bar is floating.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> Status bar displays information about the button.  
  
-   **CBRS_HIDE_INPLACE** Control bar is not displayed to the user.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The control ID of the dialog bar.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The resource ID of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object's dialog-box template.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If you specify the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> alignment style, the dialog bar's width is that of the frame window and its height is that of the resource specified by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you specify the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> alignment style, the dialog bar's height is that of the frame window and its width is that of the resource specified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCMessageMaps#13](../vs140/codesnippet/CPP/cdialogbar--create_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CDialogBar Class](../vs140/cdialogbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialogBar::CDialogBar](../vs140/cdialogbar--cdialogbar.md)