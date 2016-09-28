---
title: "IViewObjectExImpl::GetNaturalExtent"
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
  - "GetNaturalExtent"
  - "IViewObjectExImpl.GetNaturalExtent"
  - "IViewObjectExImpl::GetNaturalExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNaturalExtent method"
ms.assetid: deef7553-378e-4edf-a4bf-de71f000756d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::GetNaturalExtent
Provides sizing hints from the container for the object to use as the user resizes it.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetNaturalExtent)(  
   DWORD dwAspect,  
   LONG /* lindex */,  
   DVTARGETDEVICE* /* ptd */,  
   HDC /* hicTargetDevice */,  
   DVEXTENTINFO* pExtentInfo,  
   LPSIZEL psizel   
);  
```  
  
## Remarks  
 If `dwAspect` is `DVASPECT_CONTENT` and *pExtentInfo->dwExtentMode* is **DVEXTENT_CONTENT**, sets *`psizel` to the control class's data member [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md). Otherwise, returns an error `HRESULT`.  
  
 See [IViewObjectEx::GetNaturalExtent](http://msdn.microsoft.com/library/windows/desktop/ms683718) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)