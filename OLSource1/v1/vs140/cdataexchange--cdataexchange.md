---
title: "CDataExchange::CDataExchange"
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
  - "CDataExchange.CDataExchange"
  - "CDataExchange::CDataExchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataExchange class, constructor"
ms.assetid: d8c3dd91-f989-4daf-8152-fdbf132042e7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::CDataExchange
Call this member function to construct a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pDlgWnd*  
 A pointer to the parent window that contains the control. Usually this is a [CDialog](../vs140/cdialog-class.md)-derived object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE**, this object validates data, then writes data from the controls to the members. If **FALSE**, this object will move data from members to controls.  
  
## Remarks  
 Construct a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object yourself to store extra information in the data exchange object to pass to your window's [CWnd::DoDataExchange](../vs140/cwnd--dodataexchange.md) member function.  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#70](../vs140/codesnippet/CPP/cdataexchange--cdataexchange_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)