---
title: "AfxConnectionAdvise"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxConnectionAdvise"
  - "AFXCTL/AfxConnectionAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxConnectionAdvise function"
ms.assetid: 741f9736-551c-4332-bddc-03a4910c7882
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxConnectionAdvise
Call this function to establish a connection between a source, specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and a sink, specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the object that calls the interface.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the object that implements the interface.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The interface ID of the connection.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **TRUE** indicates that creating the connection should cause the reference count of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to be incremented. **FALSE** indicates that the reference count should not be incremented.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> where a connection identifier is returned. This value should be passed as the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when disconnecting the connection.  
  
## Return Value  
 Nonzero if a connection was established; otherwise 0.  
  
## Example  
 [!code[NVC_MFCConnectionPoints#8](../vs140/codesnippet/CPP/afxconnectionadvise_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxConnectionUnadvise](../vs140/afxconnectionunadvise.md)