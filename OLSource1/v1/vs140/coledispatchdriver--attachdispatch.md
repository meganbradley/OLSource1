---
title: "COleDispatchDriver::AttachDispatch"
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
  - "AttachDispatch"
  - "COleDispatchDriver::AttachDispatch"
  - "COleDispatchDriver.AttachDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, operations"
  - "AttachDispatch method"
ms.assetid: 9765d01c-1f3f-4f31-be32-14dc5f44c263
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::AttachDispatch
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to attach an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to an OLE <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to be attached to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
## Remarks  
 This function releases any <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer that is already attached to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_MFCOleContainer#3](../vs140/codesnippet/CPP/coledispatchdriver--attachdispatch_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::DetachDispatch](../vs140/coledispatchdriver--detachdispatch.md)   
 [COleDispatchDriver::ReleaseDispatch](../vs140/coledispatchdriver--releasedispatch.md)   
 [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md)   
 [COleDispatchDriver::m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md)   
 [COleDispatchDriver::m_bAutoRelease](../vs140/coledispatchdriver--m_bautorelease.md)