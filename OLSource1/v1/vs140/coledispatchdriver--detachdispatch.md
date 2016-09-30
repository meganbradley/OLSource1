---
title: "COleDispatchDriver::DetachDispatch"
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
  - "DetachDispatch"
  - "COleDispatchDriver::DetachDispatch"
  - "COleDispatchDriver.DetachDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, operations"
  - "DetachDispatch method"
ms.assetid: c4a4365d-74eb-4139-9f1b-d7588ad73dcb
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::DetachDispatch
Detaches the current <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> connection from this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the previously attached OLE <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not released.  
  
 For more information about the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCOleContainer#5](../vs140/codesnippet/CPP/coledispatchdriver--detachdispatch_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::ReleaseDispatch](../vs140/coledispatchdriver--releasedispatch.md)   
 [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md)   
 [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md)   
 [COleDispatchDriver::m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md)