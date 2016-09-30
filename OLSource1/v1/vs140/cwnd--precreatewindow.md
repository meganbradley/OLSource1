---
title: "CWnd::PreCreateWindow"
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
  - "CWnd.PreCreateWindow"
  - "CWnd::PreCreateWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreCreateWindow method"
  - "windows [C++], creating"
ms.assetid: d0b5d783-15dd-4047-a1d2-1252e7c2a73e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PreCreateWindow
Called by the framework before the creation of the Windows window attached to this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *cs*  
 A [CREATESTRUCT](../vs140/createstruct-structure.md) structure.  
  
## Return Value  
 Nonzero if the window creation should continue; 0 to indicate creation failure.  
  
## Remarks  
  
> [!WARNING]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> now assigns the hMenu member of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> pointer if the menu is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the style contains <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For proper functionality, ensure that your dialog control has an ID that is not <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
>   
>  This change fixes a crash in managed/native interop scenarios. A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> alerts the developer of the problem.  
  
 Never call this function directly.  
  
 The default implementation of this function checks for a **NULL** window class name and substitutes an appropriate default. Override this member function to modify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure before the window is created.  
  
 Each class derived from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> adds its own functionality to its override of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. By design, these derivations of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are not documented. To determine the styles appropriate to each class and the interdependencies between the styles, you can examine the MFC source code for your application's base class. If you choose to override **PreCreateWindow,** you can determine whether the styles used in your application's base class provide the functionality you need by using information gathered from the MFC source code.  
  
 For more information on changing window styles, see the [Changing the Styles of a Window Created by MFC](../vs140/changing-the-styles-of-a-window-created-by-mfc.md).  
  
## Example  
 [!code[NVC_MFCWindowing#112](../vs140/codesnippet/CPP/cwnd--precreatewindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CWnd::CreateEx](../vs140/cwnd--createex.md)   
 [CREATESTRUCT Structure](../vs140/createstruct-structure.md)