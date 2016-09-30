---
title: "COleDataSource::FlushClipboard"
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
  - "COleDataSource.FlushClipboard"
  - "FlushClipboard"
  - "COleDataSource::FlushClipboard"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FlushClipboard method"
  - "COleDataSource class, operations"
ms.assetid: 9636a5b8-2f99-4dc8-990d-57962da01c04
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDataSource::FlushClipboard
Renders data that is on the Clipboard, and then lets you paste data from the Clipboard after your application shuts down.  
  
## Syntax  
  
```  
static void PASCAL FlushClipboard( );  
```  
  
## Remarks  
 Use [SetClipboard](../vs140/coledatasource--setclipboard.md) to put data on the Clipboard.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDataSource Class](../vs140/coledatasource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::GetClipboardOwner](../vs140/coledatasource--getclipboardowner.md)   
 [COleDataSource::SetClipboard](../vs140/coledatasource--setclipboard.md)