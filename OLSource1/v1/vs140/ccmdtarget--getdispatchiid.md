---
title: "CCmdTarget::GetDispatchIID"
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
  - CCmdTarget::GetDispatchIID
  - GetDispatchIID
  - CCmdTarget.GetDispatchIID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDispatchIID method
  - CCmdTarget class, attributes
ms.assetid: 52a6bc3c-add1-449b-8a3f-8794d3a083a2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCmdTarget::GetDispatchIID
Gets the primary dispatch interface ID.  
  
## Syntax  
  
```  
  
      virtual BOOL GetDispatchIID(  
   IID* pIID   
);  
```  
  
#### Parameters  
 *pIID*  
 A pointer to an interface ID (a [GUID](http://msdn.microsoft.com/library/windows/desktop/aa373931)).  
  
## Return Value  
 TRUE if successful, otherwise FALSE. If successful, **pIID* is set to the primary dispatch interface ID.  
  
## Remarks  
 Derived classes should override this member function (if not overridden, `GetDispatchIID` returns FALSE). See [COleControl](../vs140/colecontrol-class.md).  
  
 For more information, see Knowledge Base article Q185720, "HOWTO: Provide Type Information From an MFC Automation Server." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at [http://support.microsoft.com](http://support.microsoft.com/).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)