---
title: "IViewObjectExImpl::Draw"
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
  - "IViewObjectExImpl::Draw"
  - "IViewObjectExImpl.Draw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Draw method"
ms.assetid: b8b176a8-52af-4cd7-b000-126d17f24abc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::Draw
Draws a representation of the control onto a device context.  
  
## Syntax  
  
```  
  
      STDMETHOD(Draw)(  
   DWORD dwDrawAspect,  
   LONG lindex,  
   void* pvAspect,  
   DVTARGETDEVICE* ptd,  
   HDC hicTargetDev,  
   LPCRECTL prcBounds,  
   LPCRECTL prcWBounds,  
   BOOL(_stdcall * /* pfnContinue /) (DWORD_PTR dwContinue),  
   DWORD_PTR /* dwContinue */   
);  
```  
  
## Remarks  
 This method calls **CComControl::OnDrawAdvanced** which in turn calls your control class's `OnDraw` method. An `OnDraw` method is automatically added to your control class when you create your control with the ATL Control Wizard. The Wizard's default `OnDraw` draws a rectangle with the label "ATL 3.0".  
  
 See [IViewObject::Draw](http://msdn.microsoft.com/library/windows/desktop/ms688655) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../VS_csharp/iviewobjecteximpl-class.md)   
 [CComControlBase::OnDrawAdvanced](../Topic/CComControlBase::OnDrawAdvanced.md)   
 [CComControlBase::OnDraw](../Topic/CComControlBase::OnDraw.md)