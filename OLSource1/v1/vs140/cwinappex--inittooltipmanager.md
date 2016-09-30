---
title: "CWinAppEx::InitTooltipManager"
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
  - "CWinAppEx.InitTooltipManager"
  - "CWinAppEx::InitTooltipManager"
  - "InitTooltipManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitTooltipManager method"
ms.assetid: 69a6285e-6892-430a-93e6-bc315346bd32
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::InitTooltipManager
Initializes the [CTooltipManager](../vs140/ctooltipmanager-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the method creates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object; 0 if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object already exists.  
  
## Remarks  
 If you call [CWinAppEx::GetTooltipManager](../vs140/cwinappex--gettooltipmanager.md), the default implementation of that method calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If your application already has a tooltip manager and you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, your application will have an [ASSERT](../vs140/assert--mfc-.md) failure. Therefore, you should not call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if you create a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object directly. If you are not using a custom <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you should use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to create a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::GetTooltipManager](../vs140/cwinappex--gettooltipmanager.md)   
 [CTooltipManager Class](../vs140/ctooltipmanager-class.md)