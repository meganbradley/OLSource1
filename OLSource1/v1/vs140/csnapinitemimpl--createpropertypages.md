---
title: "CSnapInItemImpl::CreatePropertyPages"
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
  - "CSnapInItemImpl::CreatePropertyPages"
  - "CreatePropertyPages"
  - "CSnapInItemImpl.CreatePropertyPages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePropertyPages method"
ms.assetid: 91c1d103-4395-4992-ac12-a71645907451
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSnapInItemImpl::CreatePropertyPages
This method implements the Win32 function [IExtendPropertySheet::CreatePropertyPages](http://msdn.microsoft.com/library/aa814846).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpProvider*  
 [in] Pointer to the **IPropertySheetCallback** interface.  
  
 *handle*  
 [in] Specifies the handle used to route the **MMCN_PROPERTY_CHANGE** notification message to the appropriate data class.  
  
 *pUnk*  
 [in] Pointer to the **IExtendPropertySheet** interface on the object that contains context information about the node.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the type of object. It can have one of the following values:  
  
-   **CCT_SCOPE** Data object for scope pane context.  
  
-   **CCT_RESULT** Data object for result pane context.  
  
-   **CCT_SNAPIN_MANAGER** Data object for snap-in manager context.  
  
-   **CCT_UNINITIALIZED** Data object has an invalid type.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)