---
title: "CTreeCtrl::GetLineColor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTreeCtrl::GetLineColor
  - CTreeCtrl.GetLineColor
  - GetLineColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetLineColor method
ms.assetid: 044a269b-7856-4451-9fde-9a09f250547a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetLineColor
This member function implements the behavior of the win32 message [TVM_GETLINECOLOR](http://msdn.microsoft.com/library/windows/desktop/bb773619), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
COLORREF GetLineColor( ) const;  
  
```  
  
## Return Value  
 The current line color.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#19](../vs140/codesnippet/CPP/ctreectrl--getlinecolor_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetLineColor](../vs140/ctreectrl--setlinecolor.md)