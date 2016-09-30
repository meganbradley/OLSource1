---
title: "CSnapInPropertyPageImpl::OnApply"
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
  - "CSnapInPropertyPageImpl::OnApply"
  - "OnApply"
  - "ATL::CSnapInPropertyPageImpl::OnApply"
  - "CSnapInPropertyPageImpl.OnApply"
  - "ATL.CSnapInPropertyPageImpl.OnApply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnApply method"
ms.assetid: 1d2a1137-ac0a-406d-9e5c-ae892b735e14
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::OnApply
This member function is called when the user clicks the **OK** or the **Apply Now** button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the changes are accepted; otherwise 0.  
  
## Remarks  
 Before <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can be called by the framework, you must have called <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and set its parameter to **TRUE**. This will activate the **Apply Now** button as soon as the user makes a change on the property page.  
  
 Override this member function to specify what action your program takes when the user clicks the **Apply Now** button. When overriding, the function should return **TRUE** to accept changes and **FALSE** to prevent changes from taking effect.  
  
 The default implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns **TRUE**.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)