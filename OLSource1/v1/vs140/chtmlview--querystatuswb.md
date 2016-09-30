---
title: "CHtmlView::QueryStatusWB"
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
  - "CHtmlView.QueryStatusWB"
  - "CHtmlView::QueryStatusWB"
  - "QueryStatusWB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryStatusWB method"
  - "CHtmlView class, properties"
  - "CHtmlView class, attributes"
ms.assetid: 30af8d21-24d5-4340-a1a6-1ea464c9926c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::QueryStatusWB
Call this member function to query a command status.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The [OLECMDID](http://msdn.microsoft.com/library/windows/desktop/ms691264) value of the command for which the caller needs status information.  
  
## Return Value  
 The address of the [OLECMDF](http://msdn.microsoft.com/library/windows/desktop/ms695237) value that receives the status of the command.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> implements the behavior of the [IOleCommandTarget::QueryStatus](http://msdn.microsoft.com/library/windows/desktop/ms688491) method.  
  
 Applies to Internet Explorer and WebBrowser.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::ExecWB](../vs140/chtmlview--execwb.md)   
 [IWebBrowser2::QueryStatusWB](https://msdn.microsoft.com/en-us/library/aa752139.aspx)