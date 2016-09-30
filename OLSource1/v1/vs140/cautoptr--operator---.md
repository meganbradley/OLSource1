---
title: "CAutoPtr::operator -&gt;"
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
  - "CAutoPtr.operator->"
  - "ATL.CAutoPtr<T>.operator->"
  - "ATL::CAutoPtr::operator->"
  - "ATL::CAutoPtr<T>::operator->"
  - "CAutoPtr<T>.operator->"
  - "CAutoPtr<T>::operator->"
  - "CAutoPtr::operator->"
  - "ATL.CAutoPtr.operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-> operator"
  - "operator->"
ms.assetid: ec818fcb-166e-4f53-a961-b17774a05f6f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr::operator -&gt;
The pointer-to-member operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the value of the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member variable.  
  
## Remarks  
 Use this operator to call a method in a class pointed to by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. In debug builds, an assertion failure will occur if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> points to NULL.  
  
## Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)