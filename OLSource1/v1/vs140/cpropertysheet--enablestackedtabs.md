---
title: "CPropertySheet::EnableStackedTabs"
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
  - "CPropertySheet.EnableStackedTabs"
  - "EnableStackedTabs"
  - "CPropertySheet::EnableStackedTabs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabs, stacked"
  - "EnableStackedTabs method"
  - "tabs, scrolling"
  - "CPropertySheet class, attributes"
ms.assetid: 23938bcb-b2a1-4e5f-a025-6eeeda7182c4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::EnableStackedTabs
Indicates whether to stack rows of tabs in a property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether stacked tabs are enabled in the property sheet. Disable stacked rows of tags by setting <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to **FALSE**.  
  
## Remarks  
 By default, if a property sheet has more tabs than will fit in a single row in the width of the property sheet, the tabs will stack in multiple rows. To use scrolling tabs instead of stacking tabs, call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> set to **FALSE** before calling [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md).  
  
 You must call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when you create a modal or a modeless property sheet. To incorporate this style in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived class, write a message handler for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. In the overridden version of [CWnd::OnCreate](../vs140/cwnd--oncreate.md), call **EnableStackedTabs( FALSE )** before calling the base class implementation.  
  
## Example  
 [!code[NVC_MFCDocView#134](../vs140/codesnippet/CPP/cpropertysheet--enablestackedtabs_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)