---
title: "CMenu::FromHandle"
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
  - "CMenu::FromHandle"
  - "CMenu.FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMenu class, initialization"
  - "FromHandle method [MFC]"
ms.assetid: 6bd1e029-2e89-450c-8483-89a15b487892
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::FromHandle
Returns a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object given a Windows handle to a menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Windows handle to a menu.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that may be temporary or permanent.  
  
## Remarks  
 If a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is not already attached to the Windows menu object, a temporary <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is created and attached.  
  
 This temporary <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is only valid until the next time the application has idle time in its event loop, at which time all temporary objects are deleted.  
  
## Example  
 See the example for [CMenu::CreateMenu](../vs140/cmenu--createmenu.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)