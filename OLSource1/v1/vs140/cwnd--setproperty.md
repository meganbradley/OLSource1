---
title: "CWnd::SetProperty"
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
  - "CWnd.SetProperty"
  - "CWnd::SetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetProperty method"
  - "OLE controls, getting and setting properties"
  - "CWnd class, operations"
ms.assetid: 9f42cb90-c27e-41a4-ad62-b3ead53a5aca
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SetProperty
Call this member function to set the OLE control property specified by `dwDispID`.  
  
## Syntax  
  
```  
  
      void AFX_CDECL SetProperty(  
   DISPID dwDispID,  
   VARTYPE vtProp,  
   ...   
);  
```  
  
#### Parameters  
 `dwDispID`  
 Identifies the property to be set.  
  
 `vtProp`  
 Specifies the type of the property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 A single parameter of the type specified by `vtProp`.  
  
## Remarks  
  
> [!NOTE]
>  This function should be called only on a `CWnd` object that represents an OLE control.  
  
 For more information about using this member function with OLE Control Containers, see the article [ActiveX Control Containers: Programming ActiveX Controls in an ActiveX Control Container](../vs140/activex-control-containers--programming-activex-controls-in-an-activex-control-container.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::InvokeHelper](../vs140/cwnd--invokehelper.md)   
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [CWnd::CreateControl](../vs140/cwnd--createcontrol.md)