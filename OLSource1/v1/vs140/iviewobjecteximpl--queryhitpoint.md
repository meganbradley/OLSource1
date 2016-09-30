---
title: "IViewObjectExImpl::QueryHitPoint"
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
  - "QueryHitPoint"
  - "IViewObjectExImpl::QueryHitPoint"
  - "IViewObjectExImpl.QueryHitPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryHitPoint method"
ms.assetid: 27d7911c-99bb-437e-a87c-36f2e698fa3b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IViewObjectExImpl::QueryHitPoint
Checks if the specified point is in the specified rectangle and returns a [HITRESULT](http://msdn.microsoft.com/library/windows/desktop/ms682187) value in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The value can be either **HITRESULT_HIT** or **HITRESULT_OUTSIDE**.  
  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> equals [DVASPECT_CONTENT](http://msdn.microsoft.com/library/windows/desktop/ms690318), the method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Otherwise, the method returns **E_FAIL**.  
  
 See [IViewObjectEx::QueryHitPoint](http://msdn.microsoft.com/library/windows/desktop/ms691209) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IViewObjectExImpl Class](../vs140/iviewobjecteximpl-class.md)   
 [IViewObjectExImpl::QueryHitRect](../vs140/iviewobjecteximpl--queryhitrect.md)