---
title: "CComControlBase::m_spInPlaceSite"
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
  - "ATL::CComControlBase::m_spInPlaceSite"
  - "m_spInPlaceSite"
  - "CComControlBase::m_spInPlaceSite"
  - "ATL.CComControlBase.m_spInPlaceSite"
  - "CComControlBase.m_spInPlaceSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spInPlaceSite"
ms.assetid: 1d2f194b-ad24-4216-914c-68d472c91943
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_spInPlaceSite
A pointer to the container's [IOleInPlaceSite](http://msdn.microsoft.com/library/windows/desktop/ms686586), [IOleInPlaceSiteEx](http://msdn.microsoft.com/library/windows/desktop/ms693461), or [IOleInPlaceSiteWindowless](http://msdn.microsoft.com/library/windows/desktop/ms682300) interface pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer is valid only if the [m_bNegotiatedWnd](../vs140/ccomcontrolbase--m_bnegotiatedwnd.md) flag is **TRUE**.  
  
 The following table shows how the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer type depends on the [m_bWndLess](../vs140/ccomcontrolbase--m_bwndless.md) and [m_bInPlaceSiteEx](../vs140/ccomcontrolbase--m_binplacesiteex.md) data member flags:  
  
|m_spInPlaceSite Type|m_bWndLess Value|m_bInPlaceSiteEx Value|  
|---------------------------|-----------------------|-----------------------------|  
|**IOleInPlaceSiteWindowless**|**TRUE**|**TRUE** or **FALSE**|  
|**IOleInPlaceSiteEx**|**FALSE**|**TRUE**|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**FALSE**|**FALSE**|  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComPtr Class](../vs140/ccomptr-class.md)