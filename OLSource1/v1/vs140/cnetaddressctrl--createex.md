---
title: "CNetAddressCtrl::CreateEx"
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
  - "CNetAddressCtrl.CreateEx"
  - "CNetAddressCtrl::CreateEx"
  - "CreateEx method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 9c58df9e-967e-476c-a4d8-70cadac94bca
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNetAddressCtrl::CreateEx
Creates a network address control with specified extended styles and attaches it to the current `CNetAddressCtrl` object.  
  
## Syntax  
  
```  
virtual BOOL CreateEx(  
        DWORD dwExStyle,   
        DWORD dwStyle,   
        const RECT& rect,   
        CWnd* pParentWnd,   
        UINT nID  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `dwExStyle`|A bitwise combination (OR) of extended styles to be applied to the control. For more information, see the `dwExStyle` parameter of the [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) function.|  
|[in] `dwStyle`|A bitwise combination (OR) of styles to be applied to the control. For more information, see [Edit Styles](../vs140/edit-styles.md).|  
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