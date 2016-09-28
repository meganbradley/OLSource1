---
title: "COleControlSite::BindDefaultProperty"
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
  - "COleControlSite.BindDefaultProperty"
  - "BindDefaultProperty"
  - "COleControlSite::BindDefaultProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BindDefaultProperty method"
ms.assetid: c63f1373-b54c-4393-a2d6-a5eed60a7adf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::BindDefaultProperty
Binds the calling object's default simple bound property, as marked in the type library, to the underlying cursor that is defined by the DataSource, UserName, Password, and SQL properties of the data-source control.  
  
## Syntax  
  
```  
  
      virtual void BindDefaultProperty(  
   DISPID dwDispID,  
   VARTYPE vtProp,  
   LPCTSTR szFieldName,  
   CWnd* pDSCWnd   
);  
```  
  
#### Parameters  
 `dwDispID`  
 Specifies the **DISPID** of a property on a data-bound control that is to be bound to a data-source control.  
  
 `vtProp`  
 Specifies the type of the property to be bound — for example, `VT_BSTR`, **VT_VARIANT**, and so on.  
  
 `szFieldName`  
 Specifies the name of the column, in the cursor provided by the data-source control, to which the property will be bound.  
  
 `pDSCWnd`  
 A pointer to the `CWnd`-derived object that hosts the data-source control to which the property will be bound.  
  
## Remarks  
 The `CWnd` object on which you call this function must be a data-bound control.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::BindProperty](../vs140/colecontrolsite--bindproperty.md)