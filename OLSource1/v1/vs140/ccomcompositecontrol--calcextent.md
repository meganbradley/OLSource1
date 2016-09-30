---
title: "CComCompositeControl::CalcExtent"
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
  - "ATL::CComCompositeControl<T>::CalcExtent"
  - "ATL.CComCompositeControl.CalcExtent"
  - "CalcExtent"
  - "CComCompositeControl.CalcExtent"
  - "CComCompositeControl<T>::CalcExtent"
  - "ATL::CComCompositeControl::CalcExtent"
  - "CComCompositeControl::CalcExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcExtent method"
ms.assetid: 23d6a58f-5c5e-4571-9891-8f43df69006f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComCompositeControl::CalcExtent
Call this method to calculate the size in **HIMETRIC** units of the dialog resource used to host the composite control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a **SIZE** structure to be filled by this method.  
  
## Return Value  
 TRUE if the control is hosted by a dialog box; otherwise FALSE.  
  
## Remarks  
 The size is returned in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComCompositeControl Class](../vs140/ccomcompositecontrol-class.md)   
 [AtlPixelToHiMetric](../vs140/atlpixeltohimetric.md)