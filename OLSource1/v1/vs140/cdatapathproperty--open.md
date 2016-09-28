---
title: "CDataPathProperty::Open"
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
  - "CDataPathProperty.Open"
  - "CDataPathProperty::Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: a4b9d2e8-f417-4aa2-8a75-f49a08a53583
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::Open
Call this member function to initiate loading of the asynchronous property for the associated control.  
  
## Syntax  
  
```  
  
      virtual BOOL Open(  
   COleControl* pControl,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   LPCTSTR lpszPath,  
   COleControl* pControl,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   LPCTSTR lpszPath,  
   CFileException* pError = NULL   
);  
virtual BOOL Open(  
   CFileException* pError = NULL   
);  
```  
  
#### Parameters  
 `pControl`  
 A pointer to the OLE control object to be associated with this `CDataPathProperty` object.  
  
 `pError`  
 A pointer to a file exception. In the event of an error, will be set to the cause.  
  
 `lpszPath`  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. `CDataPathProperty` uses URLs, not filenames. If you want a `CDataPathProperty` object for a file, prepend `file://` to the path.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The function attempts to obtain the `IBindHost` interface from the control.  
  
 Before calling **Open** without a path, the value for the property's path must be set. This can be done when the object is constructed, or by calling the `SetPath` member function.  
  
 Before calling **Open** without a control, an ActiveX control (formerly known as an OLE control) can be associated with the object. This can be done when the object is constructed, or by calling `SetControl`.  
  
 All overloads of [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile--open.md) are also available from `CDataPathProperty`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::SetControl](../vs140/cdatapathproperty--setcontrol.md)   
 [CDataPathProperty::CDataPathProperty](../vs140/cdatapathproperty--cdatapathproperty.md)   
 [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile--open.md)