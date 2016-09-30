---
title: "CCommonDialog Class"
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
  - "CCommonDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog boxes [C++], Windows common dialogs"
  - "common dialog boxes [C++], common dialog classes"
  - "common dialog classes [C++]"
  - "MFC dialog boxes, Windows common dialogs"
  - "Windows common dialogs [C++]"
  - "CCommonDialog class"
  - "dialog classes [C++], common"
ms.assetid: 1f68d65f-a0fd-4778-be22-ebbe51a95f95
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommonDialog Class
The base class for classes that encapsulate functionality of the Windows common dialogs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCommonDialog::CCommonDialog](#ccommondialog__ccommondialog)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The following classes encapsulate the functionality of the Windows common dialogs:  
  
-   [CFileDialog](../vs140/cfiledialog-class.md)  
  
-   [CFontDialog](../vs140/cfontdialog-class.md)  
  
-   [CColorDialog](../vs140/ccolordialog-class.md)  
  
-   [CPageSetupDialog](../vs140/cpagesetupdialog-class.md)  
  
-   [CPrintDialog](../vs140/cprintdialog-class.md)  
  
-   [CPrintDialogEx](../vs140/cprintdialogex-class.md)  
  
-   [CFindReplaceDialog](../vs140/cfindreplacedialog-class.md)  
  
-   [COleDialog](../vs140/coledialog-class.md)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="ccommondialog__ccommondialog">\</a>  CCommonDialog::CCommonDialog  
 Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
### Remarks  
 See [CDialog::CDialog](../vs140/cdialog-class.md#cdialog__cdialog) for complete information.  
  
## See Also  
 [Base Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileDialog](../vs140/cfiledialog-class.md)   
 [CFontDialog](../vs140/cfontdialog-class.md)   
 [CColorDialog](../vs140/ccolordialog-class.md)   
 [CPageSetupDialog](../vs140/cpagesetupdialog-class.md)   
 [CPrintDialog](../vs140/cprintdialog-class.md)   
 [CFindReplaceDialog](../vs140/cfindreplacedialog-class.md)   
 [COleDialog](../vs140/coledialog-class.md)