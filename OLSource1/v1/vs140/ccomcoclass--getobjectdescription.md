---
title: "CComCoClass::GetObjectDescription"
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
  - ATL.CComCoClass.GetObjectDescription
  - GetObjectDescription
  - CComCoClass.GetObjectDescription
  - ATL::CComCoClass::GetObjectDescription
  - CComCoClass::GetObjectDescription
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetObjectDescription method
ms.assetid: 37de0261-53cd-485a-b308-8c605bd20844
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComCoClass::GetObjectDescription
This static function retrieves the text description for your class object.  
  
## Syntax  
  
```  
  
static LPCTSTR WINAPI GetObjectDescription( );  
  
```  
  
## Return Value  
 The class object's description.  
  
## Remarks  
 The default implementation returns **NULL**. You can override this method with the [DECLARE_OBJECT_DESCRIPTION](../vs140/declare_object_description.md) macro. For example:  
  
 [!code[NVC_ATL_COM#12](../vs140/codesnippet/CPP/ccomcoclass--getobjectdescription_1.h)]
  
  
 `GetObjectDescription` is called by **IComponentRegistrar::GetComponents**. **IComponentRegistrar** is an Automation interface that allows you to register and unregister individual components in a DLL. When you create a Component Registrar object with the ATL Project Wizard, the wizard will automatically implement the **IComponentRegistrar** interface. **IComponentRegistrar** is typically used by Microsoft Transaction Server.  
  
 For more information about the ATL Project Wizard, see the article [Creating an ATL Project](../vs140/creating-an-atl-project.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCoClass Class](../vs140/ccomcoclass-class.md)