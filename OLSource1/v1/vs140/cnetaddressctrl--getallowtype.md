---
title: "CNetAddressCtrl::GetAllowType"
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
  - "CNetAddressCtrl::GetAllowType"
  - "GetAllowType method"
  - "CNetAddressCtrl.GetAllowType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAllowType method"
ms.assetid: a9cf299f-aafd-4a0a-aa8d-ba7c589b4183
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CNetAddressCtrl::GetAllowType
Retrieves the type of network address that the current network address control can support.  
  
## Syntax  
  
```  
DWORD GetAllowType() const;  
```  
  
## Return Value  
 A bitwise combination (OR) of flags that specifies the types of addresses the network address control can support. For more information, see [NET_STRING](http://msdn.microsoft.com/library/windows/desktop/bb762586).  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Remarks  
 This message invokes the [NetAddr_GetAllowType](http://msdn.microsoft.com/library/windows/desktop/bb774318) macro, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. That macro sends the `NCM_GETALLOWTYPE` message.  
  
## See Also  
 [CNetAddressCtrl Class](../vs140/cnetaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [NetAddr_GetAllowType](http://msdn.microsoft.com/library/windows/desktop/bb774318)   
 [CNetAddressCtrl::SetAllowType](../vs140/cnetaddressctrl--setallowtype.md)   
 [NET_STRING](http://msdn.microsoft.com/library/windows/desktop/bb762586)