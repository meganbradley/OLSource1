---
title: "CSnapInPropertyPageImpl::CancelToClose"
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
  - "CancelToClose"
  - "CSnapInPropertyPageImpl::CancelToClose"
  - "CSnapInPropertyPageImpl.CancelToClose"
  - "ATL.CSnapInPropertyPageImpl.CancelToClose"
  - "ATL::CSnapInPropertyPageImpl::CancelToClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CancelToClose method"
ms.assetid: 9729fe94-4756-4d17-83ae-75d8fbf800e9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInPropertyPageImpl::CancelToClose
Call this function after an unrecoverable change has been made to the data in a page of a modal property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This function will change the **OK** button to **Close** and disable the **Cancel** button. This change alerts the user that a change is permanent and the modifications cannot be cancelled.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function does nothing in a modeless property sheet, because a modeless property sheet does not have a **Cancel** button by default.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInPropertyPageImpl Class](../vs140/csnapinpropertypageimpl-class.md)