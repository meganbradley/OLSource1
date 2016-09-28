---
title: "CNetAddressCtrl::Create"
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
  - "Create method"
  - "CNetAddressCtrl.Create"
  - "CNetAddressCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 716ff6fe-a0e7-4718-8702-c190be95b834
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNetAddressCtrl::Create
Creates a network address control with specified styles and attaches it to the current `CNetAddressCtrl` object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
        DWORD dwStyle,   
        const RECT& rect,   
        CWnd* pParentWnd,   
        UINT nID  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `dwStyle`|A bitwise combination of styles to be applied to the control. For more information, see [Edit Styles](../vs140/edit-styles.md).|  
|[in] `rect`|A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that contains the position and size of the control.|  
|[in] `pParentWnd`|A non-null pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the control.|  
|[in] `nID`|The ID of the control.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CNetAddressCtrl Class](../vs140/cnetaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CNetAddressCtrl::CreateEx](../vs140/cnetaddressctrl--createex.md)