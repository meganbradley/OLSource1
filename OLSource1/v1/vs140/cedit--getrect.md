---
title: "CEdit::GetRect"
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
  - "CEdit.GetRect"
  - "CEdit::GetRect"
  - "GetRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "GetRect method"
ms.assetid: 00d66450-9654-4df5-ab54-308db53b72cd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetRect
Call this function to get the formatting rectangle of an edit control.  
  
## Syntax  
  
```  
  
      void GetRect(  
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to the `RECT` structure that receives the formatting rectangle.  
  
## Remarks  
 The formatting rectangle is the limiting rectangle of the text, which is independent of the size of the edit-control window.  
  
 The formatting rectangle of a multiple-line edit control can be modified by the [SetRect](../vs140/cedit--setrect.md) and [SetRectNP](../vs140/cedit--setrectnp.md) member functions.  
  
 For more information, see [EM_GETRECT](http://msdn.microsoft.com/library/windows/desktop/bb761596) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::LimitText](../vs140/cedit--limittext.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetRect](../vs140/cedit--setrect.md)   
 [CEdit::SetRectNP](../vs140/cedit--setrectnp.md)