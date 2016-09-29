---
title: "CMenu::operator HMENU"
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
  - "CMenu.operatorHMENU"
  - "HMENU"
  - "operatorHMENU"
  - "CMenu::operatorHMENU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator HMENU"
  - "HMENU operator"
ms.assetid: 602aba83-6772-45ce-8b65-b02b3359fe45
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::operator HMENU
Use this operator to retrieve the handle of the `CMenu` object.  
  
## Syntax  
  
```  
  
operator HMENU( ) const;  
  
```  
  
## Return Value  
 If successful, the handle of the `CMenu` object; otherwise, **NULL**.  
  
## Remarks  
 You can use the handle to call Windows APIs directly.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)