---
title: "IMPLEMENT_OLECTLTYPE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IMPLEMENT_OLECTLTYPE"
  - "AFXCTL/IMPLEMENT_OLECTLTYPE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMiscStatus, implementation of"
  - "GetUserTypeNameID member function"
  - "IMPLEMENT_OLECTLTYPE macro"
ms.assetid: 5ec325b8-48f0-418b-bb31-49cf6fb59ae9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IMPLEMENT_OLECTLTYPE
Implements the **GetUserTypeNameID** and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member functions of your control class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *class_name*  
 The name of the control class.  
  
 *idsUserTypeName*  
 The resource ID of a string containing the external name of the control.  
  
 *dwOleMisc*  
 An enumeration containing one or more flags. For more information on this enumeration, see [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 In addition to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you must add the **DECLARE_OLECTLTYPE** macro to your control class declaration.  
  
 The **GetUserTypeNameID** member function returns the resource string that identifies your control class. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns the **OLEMISC** bits for your control. This enumeration specifies a collection of settings describing miscellaneous characteristics of your control. For a full description of the **OLEMISC** settings, see [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  The default settings used by the ActiveX ControlWizard are: **OLEMISC_ACTIVATEWHENVISIBLE**, **OLEMISC_SETCLIENTSITEFIRST**, **OLEMISC_INSIDEOUT**, **OLEMISC_CANTLINKINSIDE**, and **OLEMISC_RECOMPOSEONRESIZE**.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DECLARE_OLECTLTYPE](../vs140/declare_olectltype.md)