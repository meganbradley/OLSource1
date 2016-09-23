---
title: "IViewObjectExImpl::GetExtent"
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
  - IViewObjectExImpl.GetExtent
  - IViewObjectExImpl::GetExtent
  - GetExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetExtent method
ms.assetid: ff19fe02-b992-423e-9ab0-93c5cb5c2c81
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IViewObjectExImpl::GetExtent
Retrieves the control's display size in HIMETRIC units (0.01 millimeter per unit) from the control class data member [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md).  
  
## Syntax  
  
```  
  
      STDMETHOD(GetExtent)(  
   DWORD /* dwDrawAspect */,  
   LONG /* lindex */,  
   DVTARGETDEVICE* /* ptd */,  
   LPSIZEL* lpsizel   
);  
```  
  
## Remarks  
 See [IViewObject2::GetExtent](http://msdn.microsoft.com/library/windows/desktop/ms684032) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)