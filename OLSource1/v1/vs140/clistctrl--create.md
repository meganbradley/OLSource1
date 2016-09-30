---
title: "CListCtrl::Create"
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
  - "LVS_SORTASCENDING"
  - "LVS_ICON"
  - "LVS_ALIGNLEFT"
  - "LVS_NOSCROLL"
  - "LVS_ALIGNTOP"
  - "LVS_NOCOLUMNHEADER"
  - "LVS_NOLABELWRAP"
  - "LVS_SORTDESCENDING"
  - "LVS_SMALLICON"
  - "LVS_SHOWSELALWAYS"
  - "LVS_LIST"
  - "LVS_REPORT"
  - "LVS_NOSORTHEADER"
  - "LVS_SHAREIMAGELISTS"
  - "LVS_AUTOARRANGE"
  - "CListCtrl::Create"
  - "LVS_SINGLESEL"
  - "LVS_OWNERDRAWFIXED"
  - "CListCtrl.Create"
  - "LVS_EDITLABELS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVS_NOSORTHEADER"
  - "LVS_NOCOLUMNHEADER"
  - "Create method [C++]"
  - "LVS_SHOWSELALWAYS"
  - "LVS_OWNERDRAWFIXED"
  - "LVS_REPORT"
  - "LVS_SINGLESEL"
  - "LVS_SORTDESCENDING"
  - "LVS_LIST"
  - "LVS_ALIGNTOP"
  - "LVS_SHAREIMAGELISTS"
  - "LVS_AUTOARRANGE"
  - "LVS_NOSCROLL"
  - "LVS_ALIGNLEFT"
  - "LVS_NOLABELWRAP"
  - "LVS_ICON"
  - "LVS_EDITLABELS"
  - "LVS_SORTASCENDING"
  - "LVS_SMALLICON"
ms.assetid: 80878188-62b0-4ef1-bc2c-04c09ad25dbc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::Create
Creates a list control and attaches it to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the list control's style. Apply any combination of list control styles to the control. See [List view window styles](http://msdn.microsoft.com/library/windows/desktop/bb774739) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a complete list of these styles. Set extended styles specific to a control using [SetExtendedStyle](../vs140/clistctrl--setextendedstyle.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the list control's size and position. It can be either a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object or a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the list control's parent window, usually a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It must not be **NULL**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the list control's ID.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in two steps. First, call the constructor and then call **Create**, which creates the list view control and attaches it to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 To apply extended Windows styles to the list control object, call [CreateEx](../vs140/clistctrl--createex.md) instead of **Create**.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#1](../vs140/codesnippet/CPP/clistctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::CListCtrl](../vs140/clistctrl--clistctrl.md)   
 [CListCtrl::CreateEx](../vs140/clistctrl--createex.md)