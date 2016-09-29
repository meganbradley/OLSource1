---
title: "CWnd::GetProperty"
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
  - "CWnd.GetProperty"
  - "CWnd::GetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperty method"
  - "OLE controls [C++], getting and setting properties"
  - "ActiveX controls [C++], properties"
  - "CWnd class, operations"
ms.assetid: 66e814bd-ee55-46a0-a385-927546df6268
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetProperty
Call this member function to get the ActiveX control property specified by `dwDispID`.  
  
## Syntax  
  
```  
  
      void GetProperty(  
   DISPID dwDispID,  
   VARTYPE vtProp,  
   void* pvProp   
)const;  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the property to be retrieved.  
  
 `vtProp`  
 Specifies the type of the property to be retrieved. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 `pvProp`  
 Address of the variable that will that will receive the property value. It must match the type specified by `vtProp`.  
  
## Remarks  
 **GetProperty** returns the value through `pvProp`.  
  
> [!NOTE]
>  This function should be called only on a `CWnd` object that represents an ActiveX control.  
  
 For more information about using this member function with ActiveX Control Containers, see the article [ActiveX Control Containers: Programming ActiveX Controls in an ActiveX Control Container](../vs140/activex-control-containers--programming-activex-controls-in-an-activex-control-container.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::InvokeHelper](../vs140/cwnd--invokehelper.md)   
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [CWnd::CreateControl](../vs140/cwnd--createcontrol.md)