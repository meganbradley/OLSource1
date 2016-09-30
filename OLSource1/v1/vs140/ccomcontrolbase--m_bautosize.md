---
title: "CComControlBase::m_bAutoSize"
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
  - "CComControlBase.m_bAutoSize"
  - "m_bAutoSize"
  - "ATL::CComControlBase::m_bAutoSize"
  - "ATL.CComControlBase.m_bAutoSize"
  - "CComControlBase::m_bAutoSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bAutoSize"
ms.assetid: e22ae270-5ecc-451d-9dba-e9824fa1b5eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bAutoSize
Flag indicating the control cannot be any other size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This flag is checked by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and, if **TRUE**, causes the function to return **E_FAIL**.  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 If you add the **Auto Size** option on the [Stock Properties](../vs140/stock-properties--atl-control-wizard.md) tab of the ATL Control Wizard, the wizard automatically creates this data member in your control class, creates put and get methods for the property, and supports [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) to automatically notify the container when the property changes.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IOleObjectImpl::SetExtent](../vs140/ioleobjectimpl--setextent.md)