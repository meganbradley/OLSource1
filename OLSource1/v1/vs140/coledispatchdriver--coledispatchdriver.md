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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::COleDispatchDriver
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an OLE <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be attached to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether the dispatch is to be released when this object goes out of scope.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Reference to an existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The form <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, **BOOL** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> = **TRUE**) connects the [IDispatch](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945) interface.  
  
 The form <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>(**const** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>& <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) copies an existing <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object and increments the reference count.  
  
 The form <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>( ) creates a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object but does not connect the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface. Before using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>( ) without arguments, you should connect an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to it using either [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md) or [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md). For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::AttachDispatch](../vs140/coledispatchdriver--attachdispatch.md)   
 [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md)