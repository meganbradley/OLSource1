---
title: "COleDataSource::GetClipboardOwner"
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
  - "GetClipboardOwner"
  - "COleDataSource::GetClipboardOwner"
  - "COleDataSource.GetClipboardOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDataSource class, operations"
  - "GetClipboardOwner method"
ms.assetid: d68d53fb-bbf4-4c93-8043-9748033725e6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::GetClipboardOwner
Determines whether the data on the Clipboard has changed since [SetClipboard](../vs140/coledatasource--setclipboard.md) was last called and, if so, identifies the current owner.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The data source currently on the Clipboard, or **NULL** if there is nothing on the Clipboard or if the Clipboard is not owned by the calling application.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::FlushClipboard](../vs140/coledatasource--flushclipboard.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)