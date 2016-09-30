---
title: "CAnimationPoint::operator="
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
  - "operator="
  - "afxanimationcontroller/CAnimationPoint::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 5cbdf398-0450-4b8a-a8fc-03a055437735
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAnimationPoint::operator=
Assigns ptSrc to CAnimationPoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Refers to CPoint or POINT.  
  
## Remarks  
 Assigns ptSrc to CAnimationPoint. It's recommended to do that before animation start, because this operator calls SetDefaultValue, which recreates the underlying COM objects for X and Y coordinates if they have been created. If you subscribed this animation object to events (ValueChanged or IntegerValueChanged), you need to re-enable these events.  
  
## Requirements  
 **Header:** afxanimationcontroller.h  
  
## See Also  
 [CAnimationPoint Class](../vs140/canimationpoint-class.md)