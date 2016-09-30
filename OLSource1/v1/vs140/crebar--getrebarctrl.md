---
title: "CReBar::GetReBarCtrl"
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
  - "GetReBarCtrl"
  - "CReBar.GetReBarCtrl"
  - "CReBar::GetReBarCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBar class, attributes"
  - "GetReBarCtrl method"
ms.assetid: 14524576-bb2f-4742-ae53-e449dd7fd5d0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBar::GetReBarCtrl
This member function allows direct access to the underlying common control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to a [CReBarCtrl](../vs140/crebarctrl-class.md) object.  
  
## Remarks  
 Call this member function to take advantage of the functionality of the Windows rebar common control in customizing your rebar. When you call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, it returns a reference object to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object so you can use either set of member functions.  
  
 For more information about using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to customize your rebar, see [Using CReBarCtrl](../vs140/using-crebarctrl.md).  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#2](../vs140/codesnippet/CPP/crebar--getrebarctrl_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CReBar Class](../vs140/crebar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)