---
title: "COleDispatchDriver::GetProperty"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleDispatchDriver::GetProperty
  - COleDispatchDriver.GetProperty
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleDispatchDriver class, operations
  - GetProperty method
ms.assetid: 088d7494-7c94-4969-9558-22af8ce34ea7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleDispatchDriver::GetProperty
Gets the object property specified by `dwDispID`.  
  
## Syntax  
  
```  
  
      void GetProperty(  
   DISPID dwDispID,  
   VARTYPE vtProp,  
   void* pvProp   
) const;  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the property to be retrieved.  
  
 `vtProp`  
 Specifies the property to be retrieved. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `pvProp`  
 Address of the variable that will receive the property value. It must match the type specified by `vtProp`.  
  
## Example  
 [!code[NVC_MFCOleContainer#6](../vs140/codesnippet/CPP/coledispatchdriver--getproperty_1.cpp)]
  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md)   
 [COleDispatchDriver::SetProperty](../vs140/coledispatchdriver--setproperty.md)