---
title: "CDocObjectServer::ActivateDocObject"
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
  - "CDocObjectServer.ActivateDocObject"
  - "ActivateDocObject"
  - "CDocObjectServer::ActivateDocObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ActivateDocObject method"
ms.assetid: dbeaa1d9-9ca4-481a-84a4-86530be832ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocObjectServer::ActivateDocObject
Call this function to activate (but not show) the document object server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>'s **ActivateMe** method, but does not show the view because it waits for specific instructions on how to set up and display the view, given in the call to [CDocObjectServer::OnActivateView](../vs140/cdocobjectserver--onactivateview.md).  
  
 Together, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> activate and display the DocObject view. DocObject activation differs from other kinds of OLE in-place activation. DocObject activation bypasses displaying in-place hatch borders and object adornments (such as sizing handles), ignores object extent functions, and draws scroll bars within the view rectangle as opposed to drawing them outside that rectangle (as in normal in-place activation).  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [CDocObjectServer Class](../vs140/cdocobjectserver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocObjectServerItem Class](../vs140/cdocobjectserveritem-class.md)