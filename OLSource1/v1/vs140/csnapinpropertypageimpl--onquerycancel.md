---
title: "CSnapInPropertyPageImpl::OnQueryCancel"
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
  - "ATL.CSnapInPropertyPageImpl.OnQueryCancel"
  - "CSnapInPropertyPageImpl.OnQueryCancel"
  - "ATL::CSnapInPropertyPageImpl::OnQueryCancel"
  - "OnQueryCancel"
  - "CSnapInPropertyPageImpl::OnQueryCancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnQueryCancel method"
ms.assetid: c4e2b220-f018-4a13-bd92-15a345c6c7e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::OnQueryCancel
This member function is called when the user clicks the **Cancel** button and before the cancel action has taken place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero to allow the cancel operation; otherwise 0.  
  
## Remarks  
 Override this member function to specify an action the program takes when the user clicks the **Cancel** button.  
  
 The default implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> returns **TRUE**.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)