---
title: "COleDispatchDriver::ReleaseDispatch"
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
  - "COleDispatchDriver::ReleaseDispatch"
  - "COleDispatchDriver.ReleaseDispatch"
  - "ReleaseDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, operations"
  - "ReleaseDispatch method"
ms.assetid: bddde6f6-9ec4-4d0d-add9-b088a1dbf03c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::ReleaseDispatch
Releases the `IDispatch` connection. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945)  
  
## Syntax  
  
```  
  
void ReleaseDispatch( );  
```  
  
## Remarks  
 If auto release has been set for this connection, this function calls **IDispatch::Release** before releasing the interface.  
  
## Example  
 See the example for [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::DetachDispatch](../vs140/coledispatchdriver--detachdispatch.md)   
 [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md)   
 [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md)   
 [COleDispatchDriver::m_lpDispatch](../vs140/coledispatchdriver--m_lpdispatch.md)   
 [COleDispatchDriver::m_bAutoRelease](../vs140/coledispatchdriver--m_bautorelease.md)