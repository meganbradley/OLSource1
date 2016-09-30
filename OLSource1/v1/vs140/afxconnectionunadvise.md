---
title: "AfxConnectionUnadvise"
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
  - "AFXCTL/AfxConnectionUnadvise"
  - "AfxConnectionUnadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxConnectionUnadvise function"
ms.assetid: fbb8abb6-5921-439e-9636-d53e99a72118
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxConnectionUnadvise
Call this function to disconnect a connection between a source, specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and a sink, specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the object that calls the interface.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the object that implements the interface.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The interface ID of the connection point interface.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **TRUE** indicates that disconnecting the connection should cause the reference count of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to be decremented. **FALSE** indicates that the reference count should not be decremented.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The connection identifier returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if a connection was disconnected; otherwise 0.  
  
## Example  
 [!code[NVC_MFCConnectionPoints#9](../vs140/codesnippet/CPP/afxconnectionunadvise_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxConnectionAdvise](../vs140/afxconnectionadvise.md)