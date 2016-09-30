---
title: "CTreeCtrl::Create"
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
  - "CTreeCtrl::Create"
  - "CTreeCtrl.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TVS_LINESATROOT"
  - "Create method [C++]"
  - "TVS_HASLINES"
ms.assetid: 57868e7a-fef8-48d0-a3cf-cf19a556dfbe
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::Create
If you specify the tree control in a dialog box template, or if you are using [CTreeView](../vs140/ctreeview-class.md), your tree control is created automatically when the dialog box or view is created.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the tree view control's style. Apply window styles, described in [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679), and any combination of [tree view control styles](http://msdn.microsoft.com/library/windows/desktop/bb760013) as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the tree view control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the tree view control's parent window, usually a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the tree view control's ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
## Remarks  
 If you want to create the tree control as a child window of some other window, use the **Create** member function. If you create the tree control using **Create**, you must pass it **WS_VISIBLE**, in addition to other tree view styles.  
  
 You construct a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in two steps. First call the constructor, then call **Create**, which creates the tree view control and attaches it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 To create a tree control with extended window styles, call [CreateEx](../vs140/ctreectrl--createex.md) instead of **Create**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#1](../vs140/codesnippet/CPP/ctreectrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::CTreeCtrl](../vs140/ctreectrl--ctreectrl.md)