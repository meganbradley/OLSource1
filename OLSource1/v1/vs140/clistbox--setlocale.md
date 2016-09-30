---
title: "CListBox::SetLocale"
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
  - "CListBox.SetLocale"
  - "CListBox::SetLocale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLocale method"
ms.assetid: d36020fd-64ea-4a31-a20c-c7ba0f3d1d04
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetLocale
Sets the locale identifier for this list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new locale identifier (LCID) value to set for the list box.  
  
## Return Value  
 The previous locale identifier (LCID) value for this list box.  
  
## Remarks  
 If **SetLocale** is not called, the default locale is obtained from the system. This system default locale can be modified by using Control Panel's Regional (or International) application.  
  
## Example  
 [!code[NVC_MFC_CListBox#37](../vs140/codesnippet/CPP/clistbox--setlocale_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetLocale](../vs140/clistbox--getlocale.md)