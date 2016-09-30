---
title: "CCmdTarget::FromIDispatch"
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
  - "CCmdTarget.FromIDispatch"
  - "FromIDispatch"
  - "CCmdTarget::FromIDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromIDispatch method"
  - "CCmdTarget class, attributes"
ms.assetid: adf089dd-edf0-4841-a075-15cbaa76c8d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::FromIDispatch
Call this function to map an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer, received from automation member functions of a class, into the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that implements the interfaces of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object associated with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This function returns **NULL** if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is not recognized as a Microsoft Foundation Class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The result of this function is the inverse of a call to the member function <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::GetIDispatch](../vs140/ccmdtarget--getidispatch.md)   
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)