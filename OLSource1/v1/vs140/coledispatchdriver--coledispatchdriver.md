---
title: "COleDispatchDriver::COleDispatchDriver"
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
  - "COleDispatchDriver::COleDispatchDriver"
  - "COleDispatchDriver.COleDispatchDriver"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, constructor"
ms.assetid: 9f395054-5928-4df8-be6d-3214da705a61
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::COleDispatchDriver
Constructs a `COleDispatchDriver` object.  
  
## Syntax  
  
```  
  
      COleDispatchDriver( );  
COleDispatchDriver(  
   LPDISPATCH lpDispatch,  
   BOOL bAutoRelease = TRUE   
);  
COleDispatchDriver(  
   const COleDispatchDriver& dispatchSrc   
);  
```  
  
#### Parameters  
 `lpDispatch`  
 Pointer to an OLE `IDispatch` object to be attached to the `COleDispatchDriver` object.  
  
 `bAutoRelease`  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
 `dispatchSrc`  
 Reference to an existing `COleDispatchDriver` object.  
  
## Remarks  
 The form `COleDispatchDriver`(`LPDISPATCH` `lpDispatch`, **BOOL** `bAutoRelease` = **TRUE**) connects the [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface.  
  
 The form `COleDispatchDriver`(**const** `COleDispatchDriver`& `dispatchSrc`) copies an existing `COleDispatchDriver` object and increments the reference count.  
  
 The form `COleDispatchDriver`( ) creates a `COleDispatchDriver` object but does not connect the `IDispatch` interface. Before using `COleDispatchDriver`( ) without arguments, you should connect an `IDispatch` to it using either [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md) or [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md). For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md)   
 [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md)