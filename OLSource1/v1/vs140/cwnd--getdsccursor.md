---
title: "CWnd::GetDSCCursor"
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
  - "CWnd::GetDSCCursor"
  - "GetDSCCursor"
  - "CWnd.GetDSCCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd class, data-binding functions"
  - "GetDSCCursor method"
ms.assetid: 09403332-2418-4d72-b88f-67f6f3930cce
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetDSCCursor
Call this member function to retrieve a pointer to the underlying cursor that is defined by the DataSource, UserName, Password, and SQL properties of the data-source control.  
  
## Syntax  
  
```  
  
IUnknown * GetDSCCursor( );  
```  
  
## Return Value  
 A pointer to a cursor that is defined by a data-source control. MFC takes care of calling `AddRef` for the pointer.  
  
## Remarks  
 Use the returned pointer to set the ICursor property of a complex data-bound control, such as the data-bound grid control. A data-source control will not become active until the first bound control requests its cursor. This can happen either explicitly by a call to `GetDSCCursor` or implicitly by the MFC binding manager. In either case, you can force a data-source control to become active by calling `GetDSCCursor` and then calling **Release** on the returned pointer to **IUnknown**. Activation will cause the data-source control to attempt to connect to the underlying data source. The returned pointer might be used in the following context:  
  
## Example  
 [!code[NVC_MFC_AxDataBinding#1](../vs140/codesnippet/CPP/cwnd--getdsccursor_1.cpp)]  
[!code[NVC_MFC_AxDataBinding#5](../vs140/codesnippet/CPP/cwnd--getdsccursor_2.cpp)]  
[!code[NVC_MFC_AxDataBinding#3](../vs140/codesnippet/CPP/cwnd--getdsccursor_3.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BindDefaultProperty](../vs140/cwnd--binddefaultproperty.md)   
 [CWnd::BindProperty](../vs140/cwnd--bindproperty.md)