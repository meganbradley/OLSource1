---
title: "CMFCButton::SetMouseCursor"
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
  - "CMFCButton::SetMouseCursor"
  - "CMFCButton.SetMouseCursor"
  - "SetMouseCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMouseCursor method"
ms.assetid: d9b09dca-743d-4cf0-8147-a43364ccef35
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SetMouseCursor
Sets the cursor image.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The handle of a cursor.  
  
## Remarks  
 Use this method to associate a cursor image, such as the hand cursor, with the button. The cursor is loaded from the application resources.  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class. The example is part of the code in the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#28](../vs140/codesnippet/CPP/cmfcbutton--setmousecursor_1.h)]  
[!code[NVC_MFC_NewControls#30](../vs140/codesnippet/CPP/cmfcbutton--setmousecursor_2.cpp)]  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCButton::SetMouseCursorHand](../vs140/cmfcbutton--setmousecursorhand.md)